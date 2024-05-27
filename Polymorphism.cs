using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{    
    internal class Sum
    {
        
        public class RTP
        {
            public virtual void bhai()
        {
            Console.WriteLine("North or South shut up ur mouth");
        }
            
        }
        public class so : RTP
        {
            public override void bhai()
            {
                Console.WriteLine("East or west Akash is the best");
            }
        }
        public void sum(int x, int y)
        { int z = x + y;
            Console.WriteLine("sum= "+z);
        }
    
        public void sum(int x, int y, int z)
        {
            int w = x + y + z;
            Console.WriteLine("sum= " + w);

        }
        
    }
}
