using System;

namespace DA
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.Write(args[0]);
                switch (args[0].ToLower())
                {
                    case "md5":
                        if (args.Length > 0)
                        {
                            DemoCryptography.MD5Demo.Test(args[1]);
                        }
                        break;

                    case "sha":
                        DemoCryptography.SHA.Test();
                        break;
                }
            }
        }
    }
}