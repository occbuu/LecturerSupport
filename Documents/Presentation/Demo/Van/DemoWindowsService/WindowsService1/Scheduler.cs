using System;
using System.IO;
using System.Timers;

namespace WindowsService1
{
    class Scheduler
    {
        Timer _timer = null;
        double _interval = 1000;

        public void Start()
        {
            _timer = new Timer(_interval);
            _timer.AutoReset = true;
            _timer.Enabled = true;
            _timer.Start();
            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            FileCreation();
        }

        void FileCreation()
        {
            string sourcePath = @"D:\Newfolder\";
            string targetPath = @"D:\abc\Newfolder\";
            bool exists = Directory.Exists(sourcePath);
            if (exists)
            {
                Directory.CreateDirectory(targetPath);
                DirectoryInfo dirCopy = new DirectoryInfo(sourcePath);
                FileInfo[] fiDiskFile = dirCopy.GetFiles();
                foreach (FileInfo file in fiDiskFile)
                {
                    try
                    {
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