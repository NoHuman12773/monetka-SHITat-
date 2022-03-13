using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monetka_SHITat_
{
    internal class Summa:Money
    {
        public double Kyp { get; set; }
        public double KolvoKyp { get; set; }
        public Summa(double kyp, double kolvokyp)
        {
            Kyp = kyp;
            KolvoKyp = kolvokyp;
        }
        public override double NominalKypyrs()
        {
            return Kyp;
        }
        public override double KolvoKypyrs()
        {
            return KolvoKyp;
        }
        public override double SummaKyp()
        {
            return KolvoKyp * Kyp;
        }
        public override string Print()
        {
            return $"Сумма купюр (грн.): {SummaKyp()}";
        }
    }
}
