using System;

namespace Desmond_Limited
{
    public delegate double Intrest(double p,double r, int t);
    class Program
    {
        static void Main(string[] args)
        {
            //jagged array of customers
            string[][] customers = new string[2][];

            customers[0] = new string[2] {"abayomi","male" };
            customers[1] = new string[2] { "chioma", "female"};
             //creating an object of all customers
            AllCustomers customerOne = new AllCustomers(customers[0][0], customers[0][1],23.2,12.1,21);
            AllCustomers customerTwo = new AllCustomers(customers[1][0], customers[1][1], 33.2, 22.1, 22);
            //instantiating the delegate
            Intrest compoundIntrestcustomerOne = customerOne.CompoundInterest;
            Intrest simpleIntrestcustomerOne = customerOne.SimpleInterest;
            Intrest compoundIntrestcustomerTwo = customerTwo.CompoundInterest;
            Intrest simpleIntrestcustomerTwo = customerTwo.SimpleInterest;
           
          double cust1Interest =  compoundIntrestcustomerOne.Invoke(customerOne.Principal,customerOne.Interest,customerOne.Time);
           double cust1SimpleInterest = simpleIntrestcustomerOne.Invoke(customerOne.Principal, customerOne.Interest, customerOne.Time);
            double cust2Interest = compoundIntrestcustomerTwo.Invoke(customerTwo.Principal, customerTwo.Interest, customerTwo.Time);
            double cust2SimpleInterest = simpleIntrestcustomerTwo.Invoke(customerTwo.Principal, customerTwo.Interest, customerTwo.Time);

            Console.WriteLine($"Customer One Compound Intrest is {cust1Interest}");
            Console.WriteLine($"Customer One Simple Intrest is {cust1SimpleInterest}");
            Console.WriteLine($"Customer Two Compound Intrest is {cust2Interest}");
            Console.WriteLine($"Customer Two Simple Intrest is {cust2SimpleInterest}");


            //Intrest intrest = customerOne.CompoundInterest;
            //intrest.Invoke(customerOne.Principal,customerOne.Interest,customerOne.Time);

        }
    }
}
