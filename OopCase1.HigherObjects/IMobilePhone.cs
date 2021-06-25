using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopCase1.OopCase1.Objects
{
    interface IMobilePhone
    {
        string Manufacturer { get; }
        string Model { get; }

        string Imei { get; }

        void SendText();
        void RecieveText();
    }
}
