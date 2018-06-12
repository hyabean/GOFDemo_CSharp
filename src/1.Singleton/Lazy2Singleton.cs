using System;

namespace aa {
    public sealed class Singleton {
        public Singleton () {

        }

        static public Singleton Instance {
            get {
                return Nested.instance;
            }
        }

        class Nested {
            static Nested () { }

            internal static readonly Singleton instance = new Singleton ();
        }
    }
}