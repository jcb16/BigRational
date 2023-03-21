using System.Numerics;
using System.Reflection.Metadata;

namespace BigRationalLib
{
    public readonly struct BigRational
    {
        //reprezentacja wewnętrzna
        public BigInteger Numerator { get; init; }
        public BigInteger Denominator { get; init; }
        //stałe         
        
        //konstruktory
        public BigRational(BigInteger numerator, BigInteger denominator) //tu jest wypasiona logika
        {
            Numerator = numerator;
            Denominator = denominator;             
            
            //normalizacja znaku
            if (Denominator < 0 && Numerator > 0)
            {
                Numerator = Numerator * (-1);
                Denominator = Denominator * (-1);
            }
            else if(Denominator > 0 && Numerator < 0)
            {
            }
            
            //if (Denominator < 0 && Numerator < 0)
            //{
            //    Numerator = Numerator * (-1);
            //    Denominator = Denominator * (-1);
            //}

            //skracanie
            BigInteger a = Numerator;
            BigInteger b = Denominator;

            int tmp;
            while (b != 0)
            {
                tmp = (int)(a % b);
                a = b;
                b = tmp;
            }

            Numerator = Numerator / a;
            Denominator = Denominator / a;
        }
        public BigRational() : this(0, 1)//a to wywołanie konstruktora 
        {
        }
        //ToString
        //override ToString
        //public static BigRational Parse(string napis)
        //"8/3" -> 8/3
        //"32/-12" -> -8/3         


        //równość         


        //arytmetyka         


        //relacje         


        //konwersje, parsowanie     }
    }
}

