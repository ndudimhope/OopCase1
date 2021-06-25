using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopCase1.OopCase1.Objects
{
    class MobilePhone:IMobilePhone
    {
        private readonly string _manufacturer;
        private readonly string _model;
        private readonly string _imei;

        public MobilePhone()
        {

        }

        public void SendText()
        {


        }

        public void RecieveText()
        {


        }

        public string Manufacturer 
        {
            get => _manufacturer;
        }

        public string Model
        {
            get => _model;
        }

        public string Imei
        {
            get => _imei;
        }
    }
}
