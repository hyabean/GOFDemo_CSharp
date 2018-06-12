using System.Configuration;
using System.Reflection;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public static AbstractFactory GetInstance()
        {
            string factoryName = ConfigurationManager.AppSettings["FactoryName"];

            AbstractFactory instance;

            //if(factoryName == "ChineseFactory")
            //    instance = new ChineseFactory();
            //else if(factoryName == "AmericanFactory")
            //    instance = new AmericanFactory();
            //else
            //    instance = null;

            if (factoryName != "")
            {
                //instance = (AbstractFactory)Assembly.Load(factoryName).CreateInstance(factoryName);
                instance = (AbstractFactory)Assembly.GetExecutingAssembly().CreateInstance(factoryName);
            }
            else
                instance = null;



            return instance;
        }

       public abstract Tax CreateTax();

       public abstract Bonus CreateBonus();
   }
}
