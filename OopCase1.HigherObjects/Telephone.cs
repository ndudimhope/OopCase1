using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopCase1.OopCase1.Objects
{
    class Telephone:ITelephone
    {
        private readonly string _manufacturer;
        private readonly string _model;

        public Telephone()
        {

        }

        public void MakeCall()
        {

        }

        public void RecieveCall()
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
    }
}
