using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Globalization;
using Microsoft.CSharp;
using System.CodeDom;
using System.CodeDom.Compiler;

namespace PbEditor.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sources = new List<string>();
            DirectoryInfo directoryInfo = new DirectoryInfo(@"E:\SVN\Code\APM\Agent\donet\trunk\donetAgent\Bonree.Agent\Bonree.Common\Common.Proto");
            FileInfo[] fileInfos = directoryInfo.GetFiles();

            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
            {
                sources.Add(File.ReadAllText(fileInfo.FullName));                
            }

            // 1.CSharpCodePrivoder
            CSharpCodeProvider objCSharpCodePrivoder = new CSharpCodeProvider();

            // 3.CompilerParameters
            CompilerParameters objCompilerParameters = new CompilerParameters();
            objCompilerParameters.ReferencedAssemblies.Add("System.dll");
            objCompilerParameters.ReferencedAssemblies.Add("Google.ProtocolBuffers.dll");
            objCompilerParameters.GenerateExecutable = false;
            objCompilerParameters.GenerateInMemory = true;

            // 4.CompilerResults
            CompilerResults cr = objCSharpCodePrivoder.CompileAssemblyFromSource(objCompilerParameters, sources.ToArray());

            Assembly objAssembly = cr.CompiledAssembly;
        }
    }
}
