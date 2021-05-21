using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Design_Patterns
{
    sealed class SIngleton3
    {
        
        private static object lockobj = new object();

        private static Lazy<SIngleton3> instance;
        private SIngleton3()
        {

        }
        public SIngleton3 GetInstance { get
            {
                lock (lockobj)
                {
                    if (!instance.IsValueCreated)
                    {
                        instance = new Lazy<SIngleton3>();
                    }

                }
                return instance.Value;
            }
        }
    }
}
