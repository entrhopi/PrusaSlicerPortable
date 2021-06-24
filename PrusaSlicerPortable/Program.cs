using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrusaSlicerPortable
{
    class Program
    {
        static void Main(string[] args)
        {
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = "cmd.exe";
            ExternalProcess.StartInfo.Arguments = "/c start prusa-slicer.exe --datadir profile";
            ExternalProcess.StartInfo.UseShellExecute = false;
            ExternalProcess.Start();
        }
    }
}
