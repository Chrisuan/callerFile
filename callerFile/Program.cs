using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callerFile {
    class Program {
        static void Main(string[] args) {
            ProcessStartInfo stinfo = new ProcessStartInfo();
            stinfo.FileName = @"C:\Users\Christian\Documents\Visual Studio 2017\Projects\getResult\getResult\bin\Debug\getResult.exe";
            stinfo.UseShellExecute = true;
            stinfo.CreateNoWindow = true;
            Process myProcess = Process.Start(stinfo.FileName, "yes");
            
        }
    }
}
