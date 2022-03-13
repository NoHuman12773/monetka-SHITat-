using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monetka_SHITat_
{
    internal class Euro:Money
    {
        public double Kyp { get; set; }
        public double KolvoKyp { get; set; }
        public Euro(double kyp, double kolvokyp)
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
            return (Kyp / 33.33) * KolvoKyp;
            //курс евро в грн. 33.33
            //на момент написания кода
        }
        public override string Print()
        {
            return $"Cтоимость купюр в евро: {SummaKyp():F2}";
        }
    }
}
