using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternss
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object lockObject = new object();

        private Singleton()
        {
            // Приватный конструктор
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
