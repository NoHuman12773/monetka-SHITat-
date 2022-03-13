using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monetka_SHITat_
{
    internal abstract class Money
    {
        public abstract double NominalKypyrs();
        public abstract double KolvoKypyrs();
        public abstract double SummaKyp();
        public abstract string Print();
    }

}
