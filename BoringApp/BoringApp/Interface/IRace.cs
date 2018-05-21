using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoringApp.Model;

namespace BoringApp.Interface
{
    public interface IRace
    {
        void PrepareRace(params Car[] cars);
        void StartRace(params Car[]  cars);
        void EndRace();
        bool IsOver(int distance, params Car[] cars);
    }
}
