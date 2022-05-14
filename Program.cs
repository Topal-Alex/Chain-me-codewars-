using System;
using System.Linq;


namespace ConsoleApplication1
{
    class  Program
    {
        static void Main(string[] args)
        {
            

        }
        
        public static double Chain(double input, Func<double,double>[] fs)
        {
            for (int i = 0; i < fs.Length; i++)
                input = fs[i](input);
            return input;
        }
        

    }

}