using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callerFile {
    class Program {
        static void Main(string[] args) {
            
            ProcessStartInfo stinfo = new ProcessStartInfo();
            
            stinfo.FileName = getDebugFile();
            stinfo.UseShellExecute = true;
            stinfo.CreateNoWindow = true;
            Process myProcess = Process.Start(stinfo.FileName, "yes");
            
        }

        public static string getDebugFile() {
            var target = @"C:\Users\Christian\Documents\Visual Studio 2017\Projects\getResult\getResult\bin\Debug\getResult.exe";
            return target;
        }


        public static string getReleaseFile() {
            string currentDirectory = Environment.CurrentDirectory;
            string target = currentDirectory + "\\getResult.exe";
            return target;
        }
    }
}
