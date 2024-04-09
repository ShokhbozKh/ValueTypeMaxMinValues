using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdParty.BouncyCastle.Math;

namespace ValueTypeMaxMinValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value types max min 

            //Byte
            Console.WriteLine("Byte");
            Console.WriteLine($"Min:{byte.MinValue}; Max:{byte.MaxValue} \n");
            //SByte
            Console.WriteLine("SByte");
            Console.WriteLine($"Min:{sbyte.MinValue}; Max:{sbyte.MaxValue}  \n");
            //Short
            Console.WriteLine("Short");
            Console.WriteLine($"Min:{short.MinValue}; Max:{short.MaxValue}  \n");
            //UShort
            Console.WriteLine("UShort");
            Console.WriteLine($"Min:{ushort.MinValue}; Max:{ushort.MaxValue}  \n");
            //Int
            Console.WriteLine("Int");
            Console.WriteLine($"Min:{int.MinValue}; Max:{int.MaxValue}  \n");
            //UInt
            Console.WriteLine("UInt");
            Console.WriteLine($"Min:{uint.MinValue}; Max:{uint.MaxValue}  \n");
            //Long
            Console.WriteLine("Long");
            Console.WriteLine($"Min:{long.MinValue}; Max:{long.MaxValue}  \n");
            //ULong
            Console.WriteLine("ULong");
            Console.WriteLine($"Min:{ulong.MinValue}; Max:{ulong.MaxValue}  \n");
   
            Console.WriteLine("-------------------------------------------------------");
            //Boolean
            Console.WriteLine("Char");
            Console.WriteLine($"Min:{(int)char.MinValue}; Max:{(int)char.MaxValue} \n");
            //DateTime
            Console.WriteLine("DateTime");
            Console.WriteLine($"Min:{DateTime.MinValue}; Max:{DateTime.MaxValue}  \n");
            //Decimal
            Console.WriteLine("Decimal");
            Console.WriteLine($"Min:{decimal.MinValue}; Max:{decimal.MaxValue}  \n");
            //Double
            Console.WriteLine("Double");
            Console.WriteLine($"Min:{double.MinValue}; Max:{double.MaxValue}  \n");
            //Single
            Console.WriteLine("Single");
            Console.WriteLine($"Min:{Single.MinValue}; Max:{Single.MaxValue}  \n");
            
        }
    }
}
