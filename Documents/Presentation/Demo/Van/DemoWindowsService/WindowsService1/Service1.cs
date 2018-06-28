using System;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        string _dateTime = DateTime.Now.ToString();
        string _filePath = @"D:\NewFolder\xyz.txt";
        StreamWriter _fileWriter;

        public Service1()
        {
            InitializeComponent();
            InitializeSchedule();
        }

        private void InitializeSchedule()
        {
            Scheduler scheduler = new Scheduler();
            scheduler.Start();
        }

        protected override void OnStart(string[] args)
        {
            //EventLog.CreateEventSource("MonitorService", "Application");
            _fileWriter = new StreamWriter(_filePath, true);
            _fileWriter.WriteLine("\n" + "Service start: " + _dateTime);
            _fileWriter.Close();
            EventLog.WriteEntry("Successfully");
        }

        protected override void OnStop()
        {
            _fileWriter = new StreamWriter(_filePath, true);
            _fileWriter.WriteLine("\n" + "Service stop: " + DateTime.Now.ToString());
            _fileWriter.WriteLine("\n" + "--------------------------------------------");
            _fileWriter.Close();
            //backup
            string sourcePath = @"D:\Newfolder\";
            string targetPath = @"D:\abc\Newfolder\";
            bool exists = Directory.Exists(targetPath);
            if (exists)
            {
                DirectoryInfo dirCopy = new DirectoryInfo(sourcePath);
                FileInfo[] fiDiskFile = dirCopy.GetFiles();
                foreach (FileInfo file in fiDiskFile)
                {
                    try
                    {
                        File.Delete(targetPath + file.Name);
                        File.Copy(file.FullName, targetPath + file.Name);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}