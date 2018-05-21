using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoringApp.Model
{
    public class Speed
    {
        Speed(string value)
        {
            this.Value = value;
        }
        public string Value { get; }
        public static Speed MxS() { return new Speed("M/S"); }
        public static Speed KMxHR() { return new Speed("KM/HR"); }
    }
}
 