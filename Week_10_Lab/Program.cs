/*
 * Payment.cs: Create a class named Payment with two derived classes that show how inheritance is used
 *             both derived classes should override a method that prints output to show the user.
 * Name: Spencer Unitt
 * Module: Week 10 Lab 1
 * 
 * Algorithm
 * 1. Create a new class named Payment with a double, a constructor, and a method that prints the double to the user
 * 2. Create two derived classes of the Payment class.
 * 3. In the first child class, create a constructor that takes in the double payment from the parent class.
 * 4. Override the print method from the parent class to display the payment as cash
 * 5. Do the same thing in the second child class but add a string and int instance variable in the constructor and 
 *    print method.
 * 6. Create two objects of both child classes and call the same print method from the parent class.
 *    The display should be different depending on which object is being used.
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // two cash objects
            Payment cash1 = new CashPayment(49.6);
            Payment cash2 = new CashPayment(32.2);

            // two credit objects
            Payment credit1 = new CreditCardPayment("Spencer", 84739, 78.59);
            Payment credit2 = new CreditCardPayment("Chelsea", 39102, 93.23);

            // calls the same method for each object but shows how each has been overriden 
            cash1.paymentDetails();
            cash2.paymentDetails();
            credit1.paymentDetails();
            credit2.paymentDetails();

            Console.ReadLine();
        }
    }
}
