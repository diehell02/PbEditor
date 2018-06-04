using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using BonreePB;
using Google.ProtocolBuffers;
using PbEditor.Convertor.Util;
using Microsoft.CSharp;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;

namespace PbEditor.Convertor
{
    public class ProtoFileTools
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger("ProtoFileTools");

        private static Assembly assembly;

        private static Dictionary<MsgType, Type> MsgTypeDic = new Dictionary<MsgType, Type>();

        static ProtoFileTools()
        {
            init();
        }

        public static List<string> Generate(string protoFile, string srcDir)
        {
            List<string> messages = new List<string>();

            string dstDir = AppDomain.CurrentDomain.BaseDirectory + @"tmp";

            if(!Directory.Exists(dstDir))
            {
                Directory.CreateDirectory(dstDir);
            }

            Process process = new Process();
            ProcessStartInfo info = new ProcessStartInfo(AppDomain.CurrentDomain.BaseDirectory + @"\protoc.exe");
            info.UseShellExecute = false;
            info.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            info.Arguments = string.Format("-I=\"{0}\" --csharp_out=\"{1}\" \"{2}\"", srcDir, dstDir, protoFile);

            process.StartInfo = info;
            process.Start();
            process.WaitForExit();

            assembly = GetAssembly(dstDir);

            foreach(Type type in assembly.GetTypes())
            {
                if(type.IsAssignableFrom(assembly.GetType("GeneratedMessage")))
                {
                    messages.Add(type.ToString());
                }
            }

            return messages;
        }

        private static Assembly GetAssembly(string dstDir)
        {
            List<string> sources = new List<string>();

            DirectoryInfo dirInfo = new DirectoryInfo(dstDir);
            FileInfo[] fileInfos = dirInfo.GetFiles();
            //遍历文件夹
            foreach (FileInfo fileInfo in fileInfos)
            {
                sources.Add(fileInfo.DirectoryName);
            }

            System.EnterpriseServices.Internal.Publish publish = new System.EnterpriseServices.Internal.Publish();

            publish.GacInstall(AppDomain.CurrentDomain.BaseDirectory + @"Google.Protobuf.dll");

            // 1.CSharpCodePrivoder
            CSharpCodeProvider objCSharpCodePrivoder = new CSharpCodeProvider();

            // 3.CompilerParameters
            CompilerParameters objCompilerParameters = new CompilerParameters();
            objCompilerParameters.ReferencedAssemblies.Add("System.dll");
            objCompilerParameters.ReferencedAssemblies.Add("Google.Protobuf.dll");
            objCompilerParameters.GenerateExecutable = false;
            objCompilerParameters.GenerateInMemory = true;

            // 4.CompilerResults
            CompilerResults cr = objCSharpCodePrivoder.CompileAssemblyFromSource(objCompilerParameters, sources.ToArray());

            Assembly objAssembly = cr.CompiledAssembly;

            return objAssembly;
        }

        private static void init()
        {
            MsgTypeDic.Add(MsgType.MT_CONGIF_REQ, typeof(configReq));
            MsgTypeDic.Add(MsgType.MT_CONFIG_RESP, typeof(configResp));
            MsgTypeDic.Add(MsgType.MT_DATA_ERRORS_REQ, typeof(ErrorsReq));
            MsgTypeDic.Add(MsgType.MT_DATA_EVENTS_REQ, typeof(EventsReq));
            MsgTypeDic.Add(MsgType.MT_DATA_SLOW_BACKEND_REQ, typeof(SlowBackendReq));
            MsgTypeDic.Add(MsgType.MT_DATA_SNAPSHOT_REQ, typeof(SnapshotReq));
            MsgTypeDic.Add(MsgType.MT_DATA_METRIC_REQ, typeof(MetricsReq));
            MsgTypeDic.Add(MsgType.MT_PROCESS_RESULT_RESP, typeof(ProcessResultResp));
            MsgTypeDic.Add(MsgType.MT_DATA_AGENTLOG_REQ, typeof(AgentlogReq));
            MsgTypeDic.Add(MsgType.MT_DATA_THREADDUMP_REQ, typeof(ThreadDumpReq));
            MsgTypeDic.Add(MsgType.MT_DATA_AGGREGATOR_BTDATAS_REQ, typeof(BtDatasReq));
        }

        public static object ParseMessage(byte[] data, string messageType)
        {
            try
            {
                Type type = assembly.GetType(messageType);

                return type.GetMethod("ParseFrom", new Type[] { typeof(byte[]) }).Invoke(null, new object[] { data });
            }
            catch
            {
                return null;
            }
        }

        public static byte[] MessageToBytes(object message)
        {
            byte[] bytes = null;

            try
            {
                bytes = (byte[])message.GetType().GetMethod("ToByteArray").Invoke(message, null);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }

            return bytes;
        }

        public static object ParseMsg(byte[] data)
        {
            try
            {
                Msg msg = Msg.ParseFrom(data);

                byte[] msgBody = Message.UnWrapMsg(msg);

                Type msgBodyType = MsgTypeDic[msg.MsgType];

                System.Reflection.MethodInfo methodInfo = msgBodyType.GetMethod("ParseFrom", new Type[] { typeof(byte[]) });

                return methodInfo.Invoke(null, new object[] { msgBody });
            }
            catch
            {
                return null;
            }            
        }

        public static byte[] MsgToBytes(object msgBody)
        {
            byte[] bytes = null;

            try
            {
                Type msgBodyType = msgBody.GetType();
                MsgType msgType = MsgTypeDic.Where(keyValuePair =>
                {
                    if (keyValuePair.Value == msgBodyType)
                    {
                        return true;
                    }

                    return false;
                }).First().Key;

                Msg msg = Message.WrapMsg((ByteString)msgBodyType.GetMethod("ToByteString").Invoke(msgBody, null), msgType);

                bytes = msg.ToByteArray();
            }
            catch(Exception ex)
            {
                logger.Error(ex);
            }

            return bytes;
        }
    }
}
