using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task4
{
    internal class LicenseVersion
    {
        static void Main(string[] args)
        {
            string Key;
            Console.WriteLine($"Enter your access key (free; trial; pro):");
            Key = Console.ReadLine();
            Console.WriteLine($"Your key: '{Key}'");

            switch (Key)
            {
                case "free":
                    {
                        Console.WriteLine($"Your version is Free");
                        ApplicationLicense freeUser = new ApplicationLicense();
                        freeUser.AllowCommon();


                        break;
                    }

                case "trial":
                    {
                        Console.WriteLine($"Your version is Trial");
                        ApplicationLicense trialUser = new ApplicationLicense();
                        trialUser.AllowTrial();


                        break;
                    }

                case "pro":
                    {
                        Console.WriteLine($"Your version is Pro");
                        ApplicationLicense proUser = new ApplicationLicense();
                        proUser.AllowPro();


                        break;
                    }

                default:
                    Console.WriteLine("Eror");

                    break;
            }
        }

        class ApplicationLicense
        {
            public void AllowCommon()
            {
                Console.WriteLine("Free mode");
            }

            public void AllowTrial()
            {
                Console.WriteLine("Trial mode");
            }

            public void AllowPro()
            {
                Console.WriteLine("Pro mode");
            }
        }
    }
}