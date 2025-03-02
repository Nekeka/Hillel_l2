//  Створіть структуру «Десяткове число». 

//Визначте в ній необхідні поля і методи.Реалізуйте наступну функціональність: 

//■ Перевести число у двійкову систему; 

//■ Перевести число у вісімкову систему; 

//■ Перевести число у шістнадцяткову систему.

using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Decimal test = new Decimal(4531);
            Console.WriteLine(test.DecimalToBinary());
            Console.WriteLine(test.DecimalToHexadecimal());
            Console.WriteLine(test.DecimalToOctal());
           
            test._decimal = 0;
            Console.WriteLine(test.DecimalToBinary());
            Console.WriteLine(test.DecimalToHexadecimal());
            Console.WriteLine(test.DecimalToOctal());

            test._decimal = 1;
            Console.WriteLine(test.DecimalToBinary());
            Console.WriteLine(test.DecimalToHexadecimal());
            Console.WriteLine(test.DecimalToOctal());


            Console.WriteLine("!");
        }
    }


    /// <summary>
    /// represents a decimal number and provides methods for converting to 2 numeral system, 8ns, 16ns 
    /// </summary>
    public struct Decimal
    {
        public int _decimal { get; set; }
        /// <summary>
        /// converting from 10ns to 2ns
        /// </summary>
        /// <returns>string that representing the binary number</returns>
        public string DecimalToBinary()
        {
            int a = _decimal;
            StringBuilder value = new StringBuilder("");

            if (_decimal == 0)
                return "0";
            while (a != 1)
            {
                if (a % 2 == 0)
                    value.Insert(0,"0");
                else
                    value.Insert(0,"1");
                a = a / 2;                           
            }
            value.Insert(0, "1");
            return value.ToString();
        }
        /// <summary>
        /// converting from 10ns to 16ns
        /// </summary>
        /// <returns>string that representing the hexadecimal number</returns>
        public string DecimalToHexadecimal()
        {
            int a = _decimal;
            StringBuilder value = new StringBuilder("");

            if (_decimal == 0)
                return "0";
            while (a > 0)
            {
                int rem = a % 16;
                a = a / 16;                       
                switch (rem)
                {
                    case 10:
                        value.Insert(0,"A");
                        break;
                    case 11:
                        value.Insert(0, "B");
                        break;
                    case 12:
                        value.Insert(0, "C");
                        break;
                    case 13:
                        value.Insert(0, "D");
                        break;
                    case 14:
                        value.Insert(0, "E");
                        break;
                    case 15:
                        value.Insert(0, "F");
                        break;
                    default:
                        value.Insert(0, rem);
                        break;
                }            
            }
            return value.ToString();
        }
        /// <summary>
        /// converting from 10ns to 8ns
        /// </summary>
        /// <returns>string that representing the octal number</returns>
        public string DecimalToOctal()
        {
            int a = _decimal;
            StringBuilder value = new StringBuilder("");

            if (_decimal == 0)
                return "0";
            while (a > 0)
            {
                int rem = a % 8;
                a = a / 8;
                value.Insert(0, rem);
            }
            return value.ToString();
        }
        public Decimal(int value)
        {
            _decimal = value;
        }


    }
}
