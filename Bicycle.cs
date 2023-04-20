using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Objects__All_the_way_down
{
    public class Bicycle
    {
        //create field;
        List<string> _FrameMaterial; //creat a list for farme material;
        string _Brand;
        int _NumberOfWheels;
        SuspensionType _SuspensionType;
        BicycleStyle _BicycleStyle;        
        string _User;
        //create new instance 
        Wheels wheels = new Wheels("ZUKKA", 20, 30, "new");
        
        public Bicycle(List<string> frameMaterial, string brand, int numberOfWheels, string user, SuspensionType suspension, BicycleStyle bicycleStyle)//creat constructor with 6 arguments;
        {
            _FrameMaterial = frameMaterial;
            _Brand = brand;
            _NumberOfWheels = numberOfWheels;
            _SuspensionType = suspension;
            _BicycleStyle = bicycleStyle;
            _User = user;                
        }

        public List<string> FrameMaterial1 { get => _FrameMaterial; set => _FrameMaterial = value; }//creat properties;
        public string Brand { get => _Brand; set => _Brand = value; }
        public int NumberOfWheels { get => _NumberOfWheels; set => _NumberOfWheels = value; }        
        public BicycleStyle BicycleStyle { get => _BicycleStyle; set => _BicycleStyle = value; }
        public string User { get => _User; set => _User = value; }
        public SuspensionType SuspensionType1 { get => _SuspensionType; set => _SuspensionType = value; }

        public override string ToString() //use overrive display the result;
        {
            string result = $"Brand: {_Brand}\nNumber Of Wheels: {_NumberOfWheels}\nSuspension Type: {_SuspensionType}\nBicycle Style: {_BicycleStyle}\nUser: {_User}\n{wheels}\n";
            foreach (var item in FrameMaterial1)
            {
                result += $"Frame Material: {item}\n";
            }
            return result;
        }
    }
}
