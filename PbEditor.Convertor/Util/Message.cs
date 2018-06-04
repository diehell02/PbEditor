using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BonreePB;
using Google.ProtocolBuffers;

namespace PbEditor.Convertor.Util
{
    public sealed class Message
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger("Message");

        public const int LARGE_MSG_SIZE = (1 << 20);
        private static object seq_lock = new object();
        private static uint seq = 1;//(uint)Times.GetCurrentTimeStamp();
        private static long delayOfConfigSyncTime = 0;

        private static CompressType compressType;

        public static void SyncTime(long configtime, long delay)
        {
            delayOfConfigSyncTime = delay;
            //logger.InfoFormat("configTime={0}, delay={1}", configtime, delay);
        }

        //打包msg
        public static Msg WrapMsg(ByteString msgBodyData, MsgType msgType)
        {
            Msg.Builder msg = new Msg.Builder();
            msg.SetVersion(Convert.ToUInt32(APM_MSG_VERSION.APM_PROTO_VERSION_CURRENT));
            lock (seq_lock)
            {
                msg.SetSeq(seq++); //will incremented in service
            }
            byte[] msgBody = msgBodyData.ToByteArray();
            try
            {
                switch (compressType)
                {
                    case CompressType.CT_GZIP:
                        byte[] zipedMsgBody = ZipHelper.Compress(msgBody);
                        msgBody = zipedMsgBody;
                        msgBodyData = ByteString.CopyFrom(msgBody);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                logger.Error("Compress msgBody Fail: ", e);
            }
            int msgLength = msgBody.Length > 0 ? msgBody.Length : 0;
            msg.SetMsgLen(Convert.ToUInt32(msgLength));
            UInt32 crc32 = CRC32.GetCRC32UInt32(msgBody);
            msg.SetCrc(crc32);
            msg.SetEncryptType(Convert.ToUInt32(EncryptType.ET_NONE));
            msg.SetTimeStamp((ulong)((long)Times.GetCurrentTimeStamp() - delayOfConfigSyncTime));
            msg.SetCompressType(Convert.ToUInt32(compressType));
            msg.SetMsgType(msgType);
            msg.SetMsgBody(msgBodyData);
            //Logger.WarnFormat("sent a Msg From Agent, Msg Type = {0}, Msg Seq = {1},Msg stamp={2}", msg.MsgType, msg.Seq, msg.TimeStamp);
            if (msgLength > LARGE_MSG_SIZE)
                logger.InfoFormat("Send Msg Size = {0} bytes, Type = {1}", msgLength, msg.MsgType);
            return msg.Build();
        }


        //解包msg, 目前只检测了长度、CRC32值
        public static byte[] UnWrapMsg(Msg msgData)
        {

            byte[] retMsg = null;
            if (msgData == null)
            {
                logger.Error("msg data is null!");
                return new byte[0];
            }

            if (msgData.MsgBody == null)
            {
                logger.Error("msg body is null!");
                return new byte[0];
            }

            retMsg = msgData.MsgBody.ToByteArray();

            if (retMsg == null)
            {
                logger.Error("ret msg is null!");
                return new byte[0];
            }

            //check length
            int msgLength = retMsg.Length;
            if (msgLength != msgData.MsgLen)
            {
                logger.Error("length is not equal!");
                return new byte[0];
            }

            UInt32 crc32 = CRC32.GetCRC32UInt32(retMsg);
            if (crc32 != msgData.Crc)
            {
                logger.Error("crc is not equal!");
                return new byte[0];
            }

            if (msgData.CompressType == Convert.ToUInt32(CompressType.CT_GZIP))
            {
                try
                {
                    compressType = CompressType.CT_GZIP;
                    retMsg = ZipHelper.Decompress(retMsg);
                }
                catch (Exception e)
                {
                    logger.Error("Decompress msgBody Fail:", e);
                    return new byte[0];
                }
            }

            return retMsg;
        }
    }
}
