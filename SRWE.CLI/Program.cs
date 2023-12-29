using SRWE.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWRE.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 4)
            {
                Console.WriteLine("Usage:");
                Console.WriteLine("SWRE.CLI.exe <EntryExecutable> <WorkingDirectory> <ProcessName> <WindowName>");
                Console.WriteLine();
                Console.WriteLine("Arguments:");
                Console.WriteLine("<EntryExecutable>: The executable to start");
                Console.WriteLine("<WorkingDirectory>: The working directory for the entry executable");
                Console.WriteLine("<ProcessName>: The process name to look for");
                Console.WriteLine("<WindowName>: The window name to latch onto and make borderless");
            }
            else
            {
                var executable = args[0];
                var workingDirectory = args[1];
                var processName = args[2];
                var windowName = args[3];

                int delay = 500;

                Process targetProcess = null;

                var entryProcess = new Process();

                entryProcess.StartInfo.FileName = executable;
                entryProcess.StartInfo.WorkingDirectory = workingDirectory;
                entryProcess.Start();

                Window window = null;

                // Loop every 500ms until the window is found
                while (window == null)
                {
                    var processes = Process.GetProcessesByName(processName);

                    foreach (var p in processes)
                    {
                        window = Window.GetProcessWindows(p).FirstOrDefault(w => w.Text == windowName);

                        // Find the first window that matches
                        if (window != null)
                        {
                            targetProcess = p;
                            break;
                        }
                    }

                    if (window != null)
                    {
                        window.RemoveBorders();

                        if (window.Parent == null)
                        {
                            window.PosX = 0;
                            window.PosY = 0;
                            window.Width = Screen.PrimaryScreen.Bounds.Width;
                            window.Height = Screen.PrimaryScreen.Bounds.Height;
                            window.ApplyChanges();
                        }

                        break;
                    }
                    else
                    {
                        Task.Delay(delay).Wait();
                    }
                }

                if (targetProcess != null && !targetProcess.HasExited)
                    targetProcess.WaitForExit();
                else if (entryProcess != null && !entryProcess.HasExited)
                    entryProcess.WaitForExit();
            }

            Console.WriteLine("Target process ended, exiting!");
        }
    }
}
