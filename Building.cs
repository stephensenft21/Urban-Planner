using System;
using System.Collections.Generic;

namespace Planner
{

    // Define the class

    class Building
    {
        // C O N S T R U C T O R 

        public Building(string address)
        {
            _address = address;

        }

        // P R I V A T E 
        private string _owner { get; set; }
        private string _address { get; set; }
        private string _buildingDesigner = "Stephen Senft";
        private DateTime _dateConstructed { get; set; }

        // P U B L I C
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {

            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public string buildingAddress()
        {
            return _address;
        }
        public string designer()
        {

            return _buildingDesigner;
        }
        public string owner() {
            return _owner;
        }
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public DateTime Constructed()
        {
            return _dateConstructed;
        }
        /*The void keyword in the C# language indicates that a method returns nothing. When a void method is invoked,
         it has no result and no variable can be assigned. Void is a return type and it used when method doesn't returns.*/
        public void Purchase(string owner) {
            _owner = owner;
        }

    }

}