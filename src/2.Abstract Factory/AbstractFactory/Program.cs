using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Bonus bonus = AbstractFactory.GetInstance().CreateBonus();
            double bonusValue = bonus.Calculate();

            Tax tax = AbstractFactory.GetInstance().CreateTax();
            double taxValue = tax.CalculateTex();

            double salary = Constant.BASE_SALARY + bonusValue + taxValue;

            Console.WriteLine("America Salary is : " + salary);
            Console.ReadKey();
        }


        static void Main1(string[] args)
        {
            Bonus bonus = new Factory().CreateBonus();
            double bonusValue = bonus.Calculate();

            Tax tax = new Factory().CreateTax();
            double taxValue = tax.CalculateTex();

            double salary = Constant.BASE_SALARY + bonusValue + taxValue;

            Console.WriteLine("Chinese Salary is : " + salary);
            Console.ReadKey();
        }
    }


}
