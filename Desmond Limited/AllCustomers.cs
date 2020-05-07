using System;
using System.Collections.Generic;
using System.Text;

namespace Desmond_Limited
{
    class AllCustomers
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Principal { get; set; }
        public double Interest { get; set; }
        public int Time { get; set; }

       

        public AllCustomers(string name,string gender,double principal, double intrest,int time)
        {
            Name = name;
            Gender = gender;
            Principal = principal;
            Interest = intrest;
            Time = time;
        }


        public double SimpleInterest(double p,double r,int t)
        {
            return (p*r*t) / 100;
        }
        public double CompoundInterest(double p, double r, int t)
        {
            return  p*(Math.Pow((1 + r),t));
        }
    }
}
