using System;

namespace ValoresEspeciais
{
    /// <summary>
    /// Initializes the Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Prints the Max and Min values and the special values of all the 
        /// different variable types.
        /// </summary>
        /// <param name="args">Not Used.</param>
        private static void Main(string[] args)
        {
            //Max Values
            int i = int.MaxValue;
            uint ui = uint.MaxValue;
            byte b = byte.MaxValue;
            sbyte sb = sbyte.MaxValue;
            short s = short.MaxValue;
            ushort us = ushort.MaxValue;
            long l = long.MaxValue;
            ulong ul = ulong.MaxValue;
            char c = char.MaxValue;
            float f = float.MaxValue;
            double d = double.MaxValue;
            decimal dec = decimal.MaxValue;

            Console.WriteLine(i);
            Console.WriteLine(ui);
            Console.WriteLine(b);
            Console.WriteLine(sb);
            Console.WriteLine(s);
            Console.WriteLine(us);
            Console.WriteLine(l);
            Console.WriteLine(ul);
            Console.WriteLine(c);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(dec);

            //Min Values
            int mi = int.MinValue;
            uint mui = uint.MinValue;
            byte mb = byte.MinValue;
            sbyte msb = sbyte.MinValue;
            short ms = short.MinValue;
            ushort mus = ushort.MinValue;
            long ml = long.MinValue;
            ulong mul = ulong.MinValue;
            char mc = char.MinValue;
            float mf = float.MinValue;
            double md = double.MinValue;
            decimal mdec = decimal.MinValue;

            Console.WriteLine(mi);
            Console.WriteLine(mui);
            Console.WriteLine(mb);
            Console.WriteLine(msb);
            Console.WriteLine(ms);
            Console.WriteLine(mus);
            Console.WriteLine(ml);
            Console.WriteLine(mul);
            Console.WriteLine(mc);
            Console.WriteLine(mf);
            Console.WriteLine(md);
            Console.WriteLine(mdec);

            float fpi = float.PositiveInfinity;
            float fni = float.NegativeInfinity;
            float fnan = float.NaN;
            double dpi = double.PositiveInfinity;
            double dni = double.NegativeInfinity;
            double dnan = double.NaN;

            Console.WriteLine(fpi);
            Console.WriteLine(fni);
            Console.WriteLine(fnan);
            Console.WriteLine(dpi);
            Console.WriteLine(dni);
            Console.WriteLine(dnan);
        }
    }
}
