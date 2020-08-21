using System;

namespace Laufwerkermittlung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.IO.DriveInfo[] AlleLaufwerke = System.IO.DriveInfo.GetDrives();
            for (int i = 0; i <= AlleLaufwerke.Length-1; i++)
            {
                string LWBuchstabe;
                string LWType;
                string LWFormat;
                string LWFrei;
                string LWGroesse;

                try
                {
                    LWBuchstabe = AlleLaufwerke[i].ToString();
                }
                catch
                {
                    LWBuchstabe = "unbekannt";
                }
                try
                {
                    LWType = AlleLaufwerke[i].DriveType.ToString();
                }
                catch
                {
                    LWType = "unbekannt";
                }
                try
                {
                    LWFormat = AlleLaufwerke[i].DriveFormat.ToString();
                }
                catch
                {
                    LWFormat = "unbekannt";
                }
                try
                {
                    LWFrei = AlleLaufwerke[i].TotalFreeSpace.ToString();
                }
                catch
                {
                    LWFrei = "unbekannt";
                }
                try
                {
                    LWGroesse = AlleLaufwerke[i].TotalSize.ToString();
                }
                catch
                {
                    LWGroesse = "unbekannt";
                }

                Console.WriteLine("Label: {0} Typ: {1} Format: {2} Frei: {3} Byte Total: {4} Byte", LWBuchstabe, LWType, LWFormat, LWFrei, LWGroesse);
            }
        }
    }
}
