using System;

namespace aa {
        public sealed class Singleton {
                private static readonly Singleton instance = new Singleton ();

                private Singleton () { }

                public static Singleton GetInstance () {
                        return instance;
                }

                private static void Main (string[] args) {
                        Singleton.GetInstance ().CallTest ();

                        Console.ReadKey ();
                }
        }
}