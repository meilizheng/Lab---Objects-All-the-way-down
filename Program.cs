using System.Security.Cryptography.X509Certificates;

namespace Lab___Objects__All_the_way_down
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> framematerial1 = new List<string>();//creat a new list instance;
            framematerial1.Add("Aluminum");//add first frame material;
            Bicycle bicycle = new Bicycle(framematerial1, "Huffy", 2, "girls", SuspensionType.Full, BicycleStyle.Country);//creat in bicycle instance 
            Console.WriteLine(bicycle);//display information;
            
        }
    }
}