using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    public sealed class Singleton
    {
        //Lazy Loading

        /*In this approach, the instance is only created when GetInstance() is called for the first time and the instance variable is null.
        It ensures that the instance is created only when needed, potentially saving memory if the Singleton is not always required.
        However, it's not thread-safe. If multiple threads simultaneously call GetInstance() when instance is null, it may result in multiple instances being created.
        */

        //private static readonly Singleton? instance;
        //private Singleton()
        //{

        //}

        //public static Singleton GetInstance()
        //{
        //    if (instance == null)
        //    {
        //        return new Singleton();
        //    }
        //    return instance;
        //}


        //Eager loading
        /*In this approach, the instance is created eagerly when the class is loaded.
        It guarantees that the instance is always available when requested.
        It's thread-safe because the instance is created when the class is loaded, and class loading in c# is inherently thread-safe.
H       owever, it consumes memory even if the instance is never used, which might be undesirable in memory-constrained environments or if the Singleton is resource-intensive.
        */
        private static readonly Singleton instance = new Singleton();
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            return instance;
        }
    }
}
