using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PbEditor.Contracts.Entity
{
    public class FileEntity
    {
        public string FileName
        {
            get;
            set;
        }

        public string Extension
        {
            get;
            set;
        }

        public string Path
        {
            get;
            set;
        }
    }
}
