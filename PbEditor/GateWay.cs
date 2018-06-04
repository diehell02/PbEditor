using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.ObjectModel;
using PbEditor.Contracts.Entity;
using System.Reflection;
using PbEditor.Convertor;

namespace PbEditor
{
    class GateWay
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger("GateWay");

        public static ObservableCollection<PbMessage> GetMessages(string path, string messageType)
        {
            ObservableCollection<PbMessage> pbMessages = new ObservableCollection<PbMessage>();

            try
            {
                byte[] data = File.ReadAllBytes(path);

                object msgBody = ProtoFileTools.ParseMessage(data, messageType);

                if (msgBody == null)
                {
                    return null;
                }

                pbMessages.Add(GetMessage(msgBody, msgBody.GetType().Name, null));
            }
            catch(Exception ex)
            {
                logger.Error(ex);
            }

            return pbMessages;
        }

        public static void SetMessages(string path, ObservableCollection<PbMessage> pbMessages)
        {
            try
            {
                byte[] bytes = null;

                object msgBody = SetMessage(pbMessages[0]);

                bytes = ProtoFileTools.MessageToBytes(msgBody);

                File.WriteAllBytes(path, bytes);
            }
            catch(Exception ex)
            {
                logger.Error(ex);
            }            
        }

        public static PbMessage CreateMessage(Type messageType, string name, object parent)
        {
            PbMessage _message = new PbMessage()
            {
                Messages = new ObservableCollection<PbMessage>(),
                Properties = new ObservableCollection<PbProperty>(),
                Name = name,
                Source = null,
                Parent = parent
            };

            try
            {
                if (!messageType.IsGenericType)
                {
                    foreach (PropertyInfo propertyInfo in messageType.GetProperties())
                    {
                        string propertyName = string.Empty;

                        if (propertyInfo.Name.StartsWith("Has") && propertyInfo.PropertyType.Equals(typeof(bool)))
                        {
                            propertyName = propertyInfo.Name.Substring(3);
                        }
                        else if (propertyInfo.Name.EndsWith("Count") && propertyInfo.PropertyType.Equals(typeof(int)))
                        {
                            propertyName = propertyInfo.Name.Substring(0, propertyInfo.Name.Length - 5) + "List";
                        }
                        else
                        {
                            continue;
                        }

                        PropertyInfo _propertyInfo = messageType.GetProperty(propertyName);

                        if (_propertyInfo.PropertyType.IsValueType || _propertyInfo.PropertyType.Equals(typeof(string)))
                        {
                            PbProperty pbProperty = new PbProperty() { Type = _propertyInfo.PropertyType, Name = _propertyInfo.Name, Value = "" };
                            _message.Properties.Add(pbProperty);
                        }
                        else
                        {
                            PbMessage pbMessage = GetMessage(_propertyInfo.PropertyType, _propertyInfo.Name, _message);
                            _message.Messages.Add(pbMessage);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex);
            }

            return _message;
        }

        private static PbMessage GetMessage(object message, string name, object parent)
        {
            PbMessage _message = new PbMessage()
            {
                Messages = new ObservableCollection<PbMessage>(),
                Properties = new ObservableCollection<PbProperty>(),
                Name = name,
                Source = message,
                Parent = parent
            };

            try
            {
                Type messageType = message.GetType();

                if (messageType.IsGenericType)
                {
                    int count = Convert.ToInt32(messageType.GetProperty("Count").GetValue(message, null));
                    string propertyName = name.Substring(0, name.Length - 4);
                    for (int i = 0; i < count; i++)
                    {
                        PropertyInfo _propertyInfo = messageType.GetProperty("Item");
                        object value = _propertyInfo.GetValue(message, new object[] { i });

                        if (_propertyInfo.PropertyType.IsValueType || _propertyInfo.PropertyType.Equals(typeof(string)))
                        {
                            PbMessage pbMessage = new PbMessage()
                            {
                                Messages = new ObservableCollection<PbMessage>(),
                                Properties = new ObservableCollection<PbProperty>()
                                {
                                    new PbProperty()
                                    {
                                        Type = _propertyInfo.PropertyType,
                                        Name = propertyName,
                                        Value = value
                                    }
                                },
                                Name = propertyName,
                                Source = value,
                                Parent = _message
                            };
                            _message.Messages.Add(pbMessage);
                        }
                        else
                        {
                            PbMessage pbMessage = GetMessage(value, propertyName, _message);
                            _message.Messages.Add(pbMessage);
                        }
                    }
                }
                else
                {
                    foreach (PropertyInfo propertyInfo in messageType.GetProperties())
                    {
                        string propertyName = string.Empty;

                        if (propertyInfo.Name.StartsWith("Has") && propertyInfo.PropertyType.Equals(typeof(bool)))
                        {
                            propertyName = propertyInfo.Name.Substring(3);
                        }
                        else if (propertyInfo.Name.EndsWith("Count") && propertyInfo.PropertyType.Equals(typeof(int)))
                        {
                            propertyName = propertyInfo.Name.Substring(0, propertyInfo.Name.Length - 5) + "List";
                        }
                        else
                        {
                            continue;
                        }

                        PropertyInfo _propertyInfo = messageType.GetProperty(propertyName);

                        if (_propertyInfo.PropertyType.IsValueType || _propertyInfo.PropertyType.Equals(typeof(string)))
                        {
                            PbProperty pbProperty = new PbProperty() { Type = _propertyInfo.PropertyType, Name = _propertyInfo.Name, Value = _propertyInfo.GetValue(message, null) };

                            if(_propertyInfo.PropertyType.IsEnum)
                            {
                                pbProperty.Enum = new List<EnumEntity>();
                                foreach (var value in Enum.GetValues(_propertyInfo.PropertyType))
                                {
                                    pbProperty.Enum.Add(new EnumEntity()
                                    {
                                        Name = value.ToString()
                                    });
                                }
                            }

                            _message.Properties.Add(pbProperty);
                        }
                        else
                        {
                            PbMessage pbMessage = GetMessage(_propertyInfo.GetValue(message, null), _propertyInfo.Name, _message);
                            _message.Messages.Add(pbMessage);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex);
            }

            return _message;
        }

        private static object SetMessage(PbMessage pbMessage)
        {
            try
            {
                if(pbMessage is null)
                {
                    return null;
                }

                object builder = pbMessage.Source.GetType().GetMethod("CreateBuilder", new Type[] { }).Invoke(null, new object[] { });

                foreach (PbProperty pbProperty in pbMessage.Properties)
                {
                    object value = null;

                    if (pbProperty.Type == pbProperty.Value.GetType())
                    {
                        value = pbProperty.Value;
                    }
                    else if (pbProperty.Type.BaseType.Name == "Enum")
                    {
                        value = Enum.Parse(pbProperty.Type, pbProperty.Value.ToString());
                    }
                    else
                    {
                        value = pbProperty.Type.GetMethod("Parse", new Type[] { typeof(string) }).Invoke(null, new object[] { pbProperty.Value });
                    }

                    builder.GetType().GetMethod("Set" + pbProperty.Name, new Type[] { pbProperty.Type }).Invoke(builder, new object[] { value });
                }

                foreach (PbMessage _pbMessage in pbMessage.Messages)
                {
                    if (_pbMessage.Source.GetType().IsGenericType)
                    {
                        Type itemType = _pbMessage.Source.GetType().GetGenericArguments()[0];
                        foreach (PbMessage item in _pbMessage.Messages)
                        {
                            string methodName = "Add" + _pbMessage.Name.Substring(0, _pbMessage.Name.Length - 4);
                            MethodInfo methodInfo = builder.GetType().GetMethod(methodName, new Type[] { itemType });

                            if (item.Source.GetType().IsValueType || item.Source.GetType().Equals(typeof(string)))
                            {
                                if(item.Properties.Count > 0)
                                {
                                    methodInfo.Invoke(builder, new object[] { item.Properties[0].Value });
                                }
                            }
                            else
                            {
                                methodInfo.Invoke(builder, new object[] { SetMessage(item) });
                            } 
                        }
                    }
                    else
                    {
                        builder.GetType().GetMethod("Set" + _pbMessage.Name, new Type[] { _pbMessage.Source.GetType() }).Invoke(builder, new object[] { SetMessage(_pbMessage) });
                    }
                }

                return builder.GetType().GetMethod("Build").Invoke(builder, new object[] { });
            }
            catch(Exception ex)
            {
                logger.Error(ex);
            }

            return null;
        }
    }
}
