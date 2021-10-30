using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10_Lab
{
    class Payment
    {
        public double payment { get; set; } // instance varible with getter setter

        public Payment() // default constructor, not used in main
        {
            payment = 0.0;
        }

        public Payment(double payment) // constructor takes in one double
        {
            this.payment = payment;
        }

        public virtual void paymentDetails() // displays the total payment to user
        {
            Console.WriteLine("The total payment is: " + payment +"\n");
        }


    }

    class CashPayment : Payment // derived class of the parent class Payment
    {
        public CashPayment(double payment) // Constructor for the cash class
        {
            this.payment = payment;
        }

        public override void paymentDetails() // overrides the method in the parent class
        {
            Console.WriteLine("The total cash payment is: " + payment + "\n");
        }
    }

    class CreditCardPayment : Payment // another derived class of the parent class Payment
    {
        public string name { get; set; } // two new instance variables with getters and setters
        public int number { get; set; }

        public CreditCardPayment(string name, int number,double payment) // Construtor that asks for values
        {
            this.name = name;
            this.number = number;
            this.payment = payment;
        }

        public override void paymentDetails() // Overrides the method in the Parent class
        {
            Console.WriteLine("The credit payment is for: " + name);
            Console.WriteLine("Taken from credit card number: " + number);
            Console.WriteLine("Total payment is: " + payment + "\n");

        }
    }


}
