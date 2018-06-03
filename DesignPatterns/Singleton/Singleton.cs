using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Composite
{
    public class Singleton
    {

        private int value = 10;

        private Singleton() { }
        /// <summary>
        /// making .ctor private to avoid instantiating the object using new
        /// </summary>
        /// <returns></returns>
        private static Singleton GetInstance() {

            return Nested.instance;
        }

        private class Nested
        {
            static Nested() {

               
            }
            internal static readonly Singleton instance = new Singleton();
        }
        public void Increment() {

            value++;

        }
        public int Value { get { return value; } }

    }
}
