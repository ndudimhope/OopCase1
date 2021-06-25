using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopCase1.OopCase1.Objects
{
    interface ITelephone
    {

        string Manufacturer { get; }

        string Model { get; }

        void MakeCall();
        void RecieveCall();
    }
}
