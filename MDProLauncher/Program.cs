using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace MDProLauncher
{
    internal class Program
    {
        private const string settingPath = "launcher.cfg";

        static void Main(string[] args)
        {
            var argsLine = string.Join(" ", args.ToArray());
            var path = File.ReadAllText(settingPath);
            Process process = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = path,
                    Arguments = argsLine,
                    UseShellExecute = true,
                    CreateNoWindow = false,
                    WorkingDirectory = Path.GetDirectoryName(path)
                }
            };
            File.WriteAllText("lines.cfg", argsLine);
            process.Start();
            process.WaitForExit();
        }
    }
}
