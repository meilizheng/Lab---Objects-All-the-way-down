using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Objects__All_the_way_down
{
    public class Wheels
    {
        //create field;
        string _Brand;
        int _WheelSize;
        double _WheelSpeed;
        string _Condition;
        
        public Wheels(string brand, int wheelSize, double wheelSpeed, string condition) //creat constructor with all arguments;
        {
            _Brand = brand;
            _WheelSize = wheelSize;
            _WheelSpeed = wheelSpeed;
            _Condition = condition;            
        }

        public string Brand { get => _Brand; set => _Brand = value; }//create propeties;
        public int WheelSize { get => _WheelSize; set => _WheelSize = value; }
        public double WheelSpeed { get => _WheelSpeed; set => _WheelSpeed = value; }        
        public string Condition { get => _Condition; set => _Condition = value; }

        public override string ToString() //use override display result;
        {
            return $"Wheels Brand:{_Brand}\nWheels Size:{_WheelSize}\nWheels Speed:{_WheelSpeed}\nWheels Condition:{_Condition}";
        }
    }
}
