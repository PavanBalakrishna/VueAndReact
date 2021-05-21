using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Design_Patterns
{
    public sealed class Singleton
    {
        private static Singleton _singleton { get; set; }
        private static object lockobj = new object();

        private Singleton()
        {
            
        }


        public Singleton Instance { get
            {
                lock (lockobj)
                {
                    if (_singleton == null)
                    {
                        _singleton = new Singleton();
                    }
                }
                return _singleton;
            }  
        }

    
    }
}

