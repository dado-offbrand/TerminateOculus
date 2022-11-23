using System;
using System.Diagnostics;

namespace TerminateOculus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process p in processes) 
            {
                String pname = p.ProcessName.ToLower();

                if (pname.Contains("oculus") || pname.Contains("ovr"))
                {
                    p.Kill();
                }
            }
        }
    }
}
