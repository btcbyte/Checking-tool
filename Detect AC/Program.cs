using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Reflection;
using Microsoft.Win32;
using static System.Net.WebRequestMethods;
using System.Net.Http;


namespace Detect_AC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Check Tool - By @thcjackk";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Banner();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Menu();
        }

        static void Banner()
        {
            Console.Clear();
            Console.WriteLine(@"
 ________  _______  _________  _______   ________ _________    ________  ________     
|\   ___ \|\  ___ \|\___   ___\\  ___ \ |\   ____\\___   ___\ |\   __  \|\   ____\    
\ \  \_|\ \ \   __/\|___ \  \_\ \   __/|\ \  \___\|___ \  \_| \ \  \|\  \ \  \___|    
 \ \  \ \\ \ \  \_|/__  \ \  \ \ \  \_|/_\ \  \       \ \  \   \ \   __  \ \  \       
  \ \  \_\\ \ \  \_|\ \  \ \  \ \ \  \_|\ \ \  \____   \ \  \ __\ \  \ \  \ \  \____  
   \ \_______\ \_______\  \ \__\ \ \_______\ \_______\  \ \__\\__\ \__\ \__\ \_______\
    \|_______|\|_______|   \|__|  \|_______|\|_______|   \|__\|__|\|__|\|__|\|_______|

");
        }

        static void Menu()
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Banner();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Note: Make sure to create a folder in the desktop with the name 'Checker'.");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n[1] NirSoft Tools");
            Console.WriteLine("[2] Detect Ac Tools");
            Console.WriteLine("[3] Eric Zimmerman's Tools");
            Console.WriteLine("[4] USB Check");
            Console.WriteLine("[5] Journal Trace");
            Console.WriteLine("[6] Disk Drill");
            Console.WriteLine("[7] Magnet Process Capture");
            Console.WriteLine("[8] PowerShell Scripts");
            Console.WriteLine("[9] Hayabusa");
            Console.WriteLine("[10] FTK Imager");
            Console.WriteLine("[11] OsForensics");
            Console.WriteLine("[12] System Informer");
            Console.WriteLine("[13] Echo Journal");
            Console.WriteLine("[14] Exit");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nSelect an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    NirSoftTools();
                    break;
                case "2":
                    DetectAcTools();
                    break;
                case "3":
                    Eric();
                    break;
                case "4":
                    USBCheck();
                    break;
                case "5":
                    JournalTrace();
                    break;
                case "6":
                    DiskDrill();
                    break;
                case "7":
                    MagnetProcessCapture();
                    break;
                case "8":
                    PowerShellScripts();
                    break;
                case "9":
                    Hayabusa();
                    break;
                case "10":
                    FTKImager();
                    break;
                case "11":
                    OSForensics();
                    break;
                case "12":
                    sysinfo();
                    break;
                case "13":
                    EchoJournal();
                    break;
                case "14":
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    Menu();
                    break;
            }
        }

        static void EchoJournal()
        {
            Console.Clear();
            Banner();

            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://cdn.discordapp.com/attachments/1348286203585232989/1349361523834753114/echo-journal.exe?ex=67d2d259&is=67d180d9&hm=70d526c080c83471cdba34c127fcc992cb4e90ad37ddf62b56780d97b8e839ee&", "EchoJournal.exe"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();

        }
        static void JournalTrace()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); 

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://github.com/spokwn/JournalTrace/releases/download/1.2/JournalTrace.exe","JournalTrace.exe"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void DiskDrill()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath);  

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://win.cleverfiles.com/disk-drill-win.exe?_gl=1*1370lef*_gcl_aw*R0NMLjE3NDE3MzIwMDEuQ2p3S0NBand2ci0tQmhCNUVpd0FkNVliWGdNaWVxSWdNTVBUV2tHOUVoS0xpTDNENzBIWjVBZDlQSnNyY0VnX1VLQWdHV3NzaXFWNTVCb0NzQU1RQXZEX0J3RQ..*_gcl_au*MTE0ODc0NDE0Mi4xNzM4Nzc0OTE0*_ga*ODI1NTAxMzc5LjE3Mzg3NzQ5MTQ.*_ga_0YKQ5NLM26*MTc0MTczMTk5NS4yLjEuMTc0MTczMjAxNi4zOS4wLjA.", "DiskDrill.exe"),

            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void MagnetProcessCapture()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://download1523.mediafire.com/gd6ivpsbl9agoECqC6BtuGGmReplPokOtK_E-iDzGYUCWBlq019eEIQm4ApTKONrSsIMOjPe8BB22kRVmzwD-y0g-s-kChlXbdOGuadpB5hCk4Klsp-i-kyMkkkYvEOAcwCsOVJi5cmKUbl7KG4IxwNzZ22rHA9G_1c7TzDd8tmw/b40on9lklo7hmc6/MRCv120.exehttps://d1kpmuwb7gvu1i.cloudfront.net/Imgr/4.7.3.81%20Release/Exterro_FTK_Imager_(x64)-4.7.3.81.exe","MagnetProcessCapture.exe"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }




        static void NirSoftTools()
        {
            Banner();
            Console.WriteLine("\n[1] WinPrefetchView");
            Console.WriteLine("[2] WinDefThreatsView");
            Console.WriteLine("[3] USBDeview");
            Console.WriteLine("[4] Everything");
            Console.WriteLine("[5] LastActivityView");
            Console.WriteLine("[6] AlternateStreamView");
            Console.WriteLine("[7] TaskSchedulerView");
            Console.WriteLine("[8] All Tools Above");
            Console.WriteLine("[9] Exit");
            Console.WriteLine("\nWhich Tool Would You Like To Download ?");
            string nir = Console.ReadLine();
            switch (nir)
            {
                case "1":
                    nirwinpr();
                    break;
                case "2":
                    nirwindef();
                    break;
                case "3":
                    nirusb();
                    break;
                case "4":
                    nirever();
                    break;
                case "5":
                    nirlast();
                    break;
                case "6":
                    niralt();
                    break;
                case "7":
                    nirtask();
                    break;
                case "8":
                    nirall();
                    break;
                case "9":
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    Menu();
                    break;
            }

        }


        static void niralt()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://www.nirsoft.net/utils/alternatestreamview-x64.zip", "AlternateStreamView.zip"),

            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void nirtask()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://www.nirsoft.net/utils/taskschedulerview-x64.zip", "TaskSchedulerView.zip"),

            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void nirlast()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://www.nirsoft.net/utils/lastactivityview.zip","LastActivityView.zip"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }


        static void nirwinpr()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
    {
        ("https://www.nirsoft.net/utils/winprefetchview-x64.zip", "NirSoft-WinPrefetchView.zip"),

};

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void nirwindef()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://www.nirsoft.net/utils/windefthreatsview-x64.zip", "WinDefednerThreatsViewer.zip"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void nirusb()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://www.nirsoft.net/utils/usbdeview.zip", "USBDeview.zip"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void nirever()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://www.voidtools.com/Everything-1.4.1.1026.x86-Setup.exe", "Everything.exe"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void nirall()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
    {
        ("https://www.nirsoft.net/utils/winprefetchview-x64.zip", "NirSoft-WinPrefetchView.zip"),
        ("https://www.nirsoft.net/utils/windefthreatsview-x64.zip", "NirSoft-WinDefThreatsView.zip"),
        ("https://www.nirsoft.net/utils/usbdeview.zip", "NirSoft-USBDeview.zip"),
        ("https://www.nirsoft.net/utils/lastactivityview.zip", "NirSoft-LastActivityView.zip"),
        ("https://www.voidtools.com/Everything-1.4.1.1026.x86-Setup.exe", "Everything-Setup.exe"),
        ("https://www.nirsoft.net/utils/taskschedulerview-x64.zip", "TaskSchedulerView.zip"),
        ("https://www.nirsoft.net/utils/alternatestreamview-x64.zip", "AlternateStreamView.zip"),
};

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();

        }

        static void sysinfo()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://downloads.sourceforge.net/project/systeminformer/systeminformer-3.2.25011-release-setup.exe?ts=gAAAAABn0L-DzassfEh4n0pub50dX7aOju20Uc_aRQbrUwtbucnUMP6siAKE-Y7PQxTAVbaqfUdnTMf4cYbH-D4GhPGtl90IAg%3D%3D&r=https%3A%2F%2Fsourceforge.net%2Fprojects%2Fsysteminformer%2Ffiles%2Flatest%2Fdownload", "SystemInformer(Setup).exe"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }


        static void Hayabusa()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://github.com/Yamato-Security/hayabusa/releases/download/v3.1.1/hayabusa-3.1.1-win-x64.zip", "Hayabusa.zip"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void OSForensics()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://osforensics.com/downloads/OSForensics.exe", "OSForensics.exe"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void DetectAcTools()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Banner();
            Console.WriteLine("[1] Bam Parser");
            Console.WriteLine("[2] Prefetch Parser");
            Console.WriteLine("[3] PcaSvc Executed");
            Console.WriteLine("[4] Process Parser");
            Console.WriteLine("[5] All tools above");
            Console.WriteLine("[6] Exit");
            Console.WriteLine("\nWhich Tool Would You Like To Download ?");
            string det = Console.ReadLine();
            switch (det)
            {
                case "1":
                    detbam();
                    break;
                case "2":
                    detpre();
                    break;
                case "3":
                    detpca();
                    break;
                case "4":
                    detpro();
                    break;
                case "5":
                    detall();
                    break;
                case "6":
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    Menu();
                    break;
            }


        }

        static void detbam()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://github.com/spokwn/BAM-parser/releases/download/v1.2.6/BAMParser.exe", "BamParser.exe"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void detpre()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://github.com/spokwn/prefetch-parser/releases/download/v1.5.3/PrefetchParser.exe", "PrefetchParser.exe")
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();

        }

        static void detpca()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://github.com/spokwn/pcasvc-executed/releases/download/v0.8.5/PcaSvcExecuted.exe", "PcaSvcExecuted.exe"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();

        }

        static void detpro()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://github.com/spokwn/process-parser/releases/download/v0.5.3/ProcessParser.exe", "ProcessParser.exe")
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();

        }

        static void detall()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
    {
        ("https://github.com/spokwn/BAM-parser/releases/download/v1.2.6/BAMParser.exe", "BAMParser.exe"),
        ("https://github.com/spokwn/prefetch-parser/releases/download/v1.5.3/PrefetchParser.exe", "PrefetchParser.exe"),
        ("https://github.com/spokwn/pcasvc-executed/releases/download/v0.8.5/PcaSvcExecuted.exe", "PcaSvcExecuted.exe"),
        ("https://github.com/spokwn/process-parser/releases/download/v0.5.3/ProcessParser.exe", "ProcessParser.exe"),
    };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }


        static void FTKImager()
        {
            Console.Clear();
            Banner();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {              
            
                ("https://d1kpmuwb7gvu1i.cloudfront.net/Imgr/4.7.3.81%20Release/Exterro_FTK_Imager_(x64)-4.7.3.81.exe", "Ftk-Imager.exe"),
            
            }; 

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void Eric()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Banner();
            Console.WriteLine("[1] AmCacheParser");
            Console.WriteLine("[2] Timeline Explorer");
            Console.WriteLine("[3] Bstrings");
            Console.WriteLine("[4] SrumECmd");
            Console.WriteLine("[5] AppCompatCacheParser");
            Console.WriteLine("[6] Registry Explorer");
            Console.WriteLine("[7] MfteCmd");
            Console.WriteLine("[8] All the tools above");
            Console.WriteLine("[9] Exit");
            Console.WriteLine("\nWhich tool would you like to download ?");
            string eric = Console.ReadLine();
            switch (eric)
            {
                case "1":
                    eram();
                    break;
                case "2":
                    ertm();
                    break;
                case "3":
                    erbs();
                    break;
                case "4":
                    ersr();
                    break;
                case "5":
                    erap();
                    break;
                case "6":
                    erre();
                    break;
                case "7":
                    ermf();
                    break;
                case "8":
                    erall();
                    break;
                case "9":
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    Menu();
                    break;
            }

        }

        static void eram()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://download.ericzimmermanstools.com/net9/AmcacheParser.zip", "AmCacheParser.zip"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void ertm()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://download.ericzimmermanstools.com/net9/TimelineExplorer.zip", "TimeLineExplorer.zip"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }
        static void erbs()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://download.ericzimmermanstools.com/net9/TimelineExplorer.zip", "Bstrings.zip"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }
        static void ersr()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://download.ericzimmermanstools.com/net9/SrumECmd.zip", "SrumECmd.zip"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void erap()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://download.ericzimmermanstools.com/net9/AppCompatCacheParser.zip", "AppCompatCacheParser.zip"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void erre()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://download.ericzimmermanstools.com/net9/RegistryExplorer.zip", "RegistryExplorer.zip"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void ermf()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
            {
                ("https://download.ericzimmermanstools.com/net9/MFTECmd.zip", "MFTECmd.zip"),
            };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();
        }

        static void erall()
        {
            Console.Clear();
            Banner();
            string folderPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Desktop\Checker";
            Directory.CreateDirectory(folderPath); // Ensure the directory exists

            List<(string url, string filename)> filesToDownload = new List<(string, string)>
    {
        ("https://download.ericzimmermanstools.com/net9/AmcacheParser.zip", "AmCacheParser.zip"),
        ("https://download.ericzimmermanstools.com/net9/TimelineExplorer.zip", "TimelineExplorer.zip"),
        ("https://download.ericzimmermanstools.com/net9/bstrings.zip", "Bstrings.zip"),
        ("https://download.ericzimmermanstools.com/net9/SrumECmd.zip", "SrumECmd.zip"),
        ("https://download.ericzimmermanstools.com/net9/RegistryExplorer.zip", "RegistryExplorer.zip"),
        ("https://download.ericzimmermanstools.com/net9/MFTECmd.zip", "MFTECmd.zip")

    };

            WebClient client = new WebClient();

            foreach (var file in filesToDownload)
            {
                string filePath = Path.Combine(folderPath, file.filename);
                Console.WriteLine($"Downloading {file.filename}...");
                client.DownloadFile(file.url, filePath);
                Console.WriteLine($"Download Complete! Saved to: {filePath}");
            }
            Thread.Sleep(2000);
            Menu();

        }


        static void USBCheck()
        {
            Console.Clear();

            string[] registryKeys = new string[]
            {
            @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows Search\VolumeInfoCache\D:",
            @"HKEY_LOCAL_MACHINE\SYSTEM\MountedDevices",
            @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\usbflags",
            @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows Portable Devices\Devices"
            };

            foreach (var keyPath in registryKeys)
            {
                if (IsRegistryKeyDeleted(keyPath))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The registry key '{keyPath}' is most likely deleted or does not exist.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The registry key '{keyPath}' exists.");
                }
            }

            Console.ResetColor();

            Console.WriteLine("\nWaiting for 5 seconds...");
            Thread.Sleep(5000);

            Console.Clear();
            Menu();
        }

        static bool IsRegistryKeyDeleted(string keyPath)
        {
            try
            {
                var key = Registry.GetValue(keyPath, "", null);
                return key == null;
            }
            catch (Exception)
            {
                return true;
            }


        }

        static void PowerShellScripts()
        {
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Banner();
            Console.WriteLine("[1] Services");
            Console.WriteLine("[2] Red Lotus BAM");
            Console.WriteLine("[3] Path Signature");
            Console.WriteLine("[4] Hard Disk Volume");
            Console.WriteLine("[5] Exit");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nNote: After every powershell script ran, close and re-run the application.");
            string pwsh = Console.ReadLine();
            switch (pwsh)
            {
                case "1":
                    powser();
                    break;
                case "2":
                    powbam();
                    break;
                case "3":
                    powpath();
                    break;
                case "4":
                    powdisk();
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    Thread.Sleep(1000);
                    Menu();
                    break;
            }

        }
        static void powser()
        {
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            string pwshPath = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";


            string scriptContent = @"

$findstrPath = 'C:\Windows\System32\findstr.exe'


get-service | & $findstrPath -i 'pcasvc'
get-service | & $findstrPath -i 'DPS'
get-service | & $findstrPath -i 'Diagtrack'
get-service | & $findstrPath -i 'sysmain'
get-service | & $findstrPath -i 'eventlog'
get-service | & $findstrPath -i 'sgrmbroker'
get-service | & $findstrPath -i 'cdpusersvc'
";


            RunPowerShellScript(pwshPath, scriptContent);
        }

        static void RunPowerShellScript(string pwshPath, string scriptContent)
        {
            try
            {

                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = pwshPath,
                    Arguments = $"-ExecutionPolicy Bypass -Command \"{scriptContent}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(processStartInfo))
                {

                    using (var reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        Console.WriteLine("PowerShell Output:\n" + result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error running PowerShell script: " + ex.Message);
            }
            Thread.Sleep(Timeout.Infinite);
            Menu();



        }



        static void powbam()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;


            string pwshPath = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";


            string scriptContent = @"
Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass -Force

# Invoke the script from the URL
Invoke-Expression (Invoke-RestMethod https://raw.githubusercontent.com/PureIntent/ScreenShare/main/RedLotusBam.ps1)
";


            RunPowerShellScrit(pwshPath, scriptContent);
        }

        static void RunPowerShellScrit(string pwshPath, string scriptContent)
        {
            try
            {

                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = pwshPath,
                    Arguments = $"-ExecutionPolicy Bypass -Command \"{scriptContent}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };


                using (Process process = Process.Start(processStartInfo))
                {

                    using (var reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        Console.WriteLine("PowerShell Output:\n" + result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error running PowerShell script: " + ex.Message);
            }

            Thread.Sleep(Timeout.Infinite);


            Menu();


        }

        static void powpath()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;


            string pwshPath = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";


            string scriptContent = @"
Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass -Force

# Invoke the script from the URL
Invoke-Expression (Invoke-RestMethod https://raw.githubusercontent.com/bacanoicua/Screenshare/main/RedLotusSignatures.ps1)
";


            RunPowerShellScr(pwshPath, scriptContent);
        }

        static void RunPowerShellScr(string pwshPath, string scriptContent)
        {
            try
            {

                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = pwshPath,
                    Arguments = $"-ExecutionPolicy Bypass -Command \"{scriptContent}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };


                using (Process process = Process.Start(processStartInfo))
                {

                    using (var reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        Console.WriteLine("PowerShell Output:\n" + result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error running PowerShell script: " + ex.Message);
            }


            Thread.Sleep(Timeout.Infinite);


            Menu();

        }

        static void powdisk()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;


            string pwshPath = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";


            string scriptContent = @"
Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass -Force

# Invoke the script from the URL
Invoke-Expression (Invoke-RestMethod https://raw.githubusercontent.com/bacanoicua/Screenshare/main/RedLotusSignatures.ps1)
";


            RunPowerShellSc(pwshPath, scriptContent);
        }

        static void RunPowerShellSc(string pwshPath, string scriptContent)
        {
            try
            {

                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = pwshPath,
                    Arguments = $"-ExecutionPolicy Bypass -Command \"{scriptContent}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };


                using (Process process = Process.Start(processStartInfo))
                {

                    using (var reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        Console.WriteLine("PowerShell Output:\n" + result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error running PowerShell script: " + ex.Message);
            }

            Thread.Sleep(Timeout.Infinite);
            Menu();

        }
    }
}        

