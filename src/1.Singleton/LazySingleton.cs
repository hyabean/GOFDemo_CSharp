using System;

namespace AA
{
    class Singleton
    { 
        private static Singleton instance;

        private static object _lock = new object();

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock(_lock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }

        public void CallTest()
        {
            Console.WriteLine("output from Singleton class.");
        }

        public static void Main(string[] args)
        {
            Singleton.GetInstance().CallTest();

            Console.ReadKey();
        }
    }
}