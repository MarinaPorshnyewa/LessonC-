using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Number2
{
    class MyType
    {
        internal static int A { get; set; }
        internal static int B { get; set; }
        
       
        public static void Parse(string multiplier)
        {
            string[] str = multiplier.Split(' ',',');
            if (str.Length != 2)
            {
                throw new FormatException();
            }
            else
            {
                A = int.Parse(str[0]); 
                B = int.Parse(str[1]);           
            }
               
          

        }
    }
}
