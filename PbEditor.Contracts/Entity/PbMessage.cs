using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace PbEditor.Contracts.Entity
{
    public class PbMessage
    {
        public string Name
        {
            get;
            set;
        }

        public object Source
        {
            get;
            set;
        }

        public object Parent
        {
            get;
            set;
        }

        private bool? isExpanded;
        public bool? IsExpanded
        {
            get
            {
                if(isExpanded is null)
                {
                    if (this.Parent != null && this.Parent is PbMessage)
                    {
                        PbMessage parent = this.Parent as PbMessage;

                        if (parent.Source.GetType().IsGenericType)
                        {
                            isExpanded = false;
                            return isExpanded;
                        }
                    }

                    isExpanded = true;
                }

                return isExpanded;
            }
        }

        public ObservableCollection<PbMessage> Messages
        {
            get;
            set;
        }

        public ObservableCollection<PbProperty> Properties
        {
            get;
            set;
        }
    }

    public class PbProperty
    {
        public Type Type
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public object Value
        {
            get;
            set;
        }

        public List<EnumEntity> Enum
        {
            get;
            set;
        }

        public string TextBoxVisibility
        {
            get
            {
                if(Enum is null)
                {
                    return "Visible";
                }

                return "Collapsed";
            }
        }

        public string ComboBoxVisibility
        {
            get
            {
                if (Enum is null)
                {
                    return "Collapsed";
                }

                return "Visible";
            }
        }
    }

    public class EnumEntity
    {
        public string Name
        {
            get;
            set;
        }
    }
}
