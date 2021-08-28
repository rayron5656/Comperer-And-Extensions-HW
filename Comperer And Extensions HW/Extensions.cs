using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comperer_And_Extensions_HW
{
    static class StringExtensions
    {
        static public bool HasLowerCase(this string s)
        {
            foreach (var Ch in s)
            {
                if (Char.IsLower(Ch))
                {
                    return true;
                }

            }
            return false;
        }

        static public string ReverseCase(this string s)
        {
            string NewS = "";
            foreach (var Ch in s)
            {
                if (Char.IsUpper(Ch))
                {
                    NewS += Char.ToLower(Ch);
                }
                else if (Char.IsLower(Ch))
                {
                    NewS += Char.ToUpper(Ch);
                }
                else
                {
                    NewS += " ";
                }
            }
            return NewS;
        }

        static public bool IsValidIsraeliId(this string s)
        {
            int LastNumber = 0;
            int counter = 1;
            int FinallNumber = 0;
            int I10AndUp = 0;
            int Tens = 0;
            int Ones = 0;

            if (s.Length != 9)
            {
                throw new InvalidOperationException("Length is not right");
            }
            else
            {
                foreach (var Ch in s)
                {
                    if (counter != 9)
                    {
                        if (counter % 2 == 1)
                        {

                            FinallNumber += int.Parse(Ch.ToString());

                        }
                        else
                        {
                            if (2 * int.Parse(Ch.ToString()) >= 10)
                            {
                                I10AndUp = 2 * int.Parse(Ch.ToString());
                                Ones = I10AndUp % 10;
                                Tens = (I10AndUp - Ones) / 10;

                                FinallNumber += Ones + Tens;

                            }
                            else
                            {
                                FinallNumber += 2 * int.Parse(Ch.ToString());
                            }
                        }
                        counter++;

                    }
                    else
                    {
                        LastNumber = int.Parse(Ch.ToString());
                    }
                }
                if ((LastNumber + FinallNumber) % 10 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }

    }

    static class IntExtensions
    {
        static public string Print(this int I)
        {
            int Tens = 0;
            int Ones = 0;
            string StringToReturn = "";
            
            if (I > 100 || I < 0)
            {
                return "Ad Kan!";
            }
            Ones = I % 10;
            if (I > 10)
            {
                Tens = I - Ones;
            }
            

            switch (Tens)
            {
                case 0:
                    switch (Ones)
                    {
                        case 0:
                            return "zero";
                        default:
                            break;
 
                    }
                    break;
                case 10:
                    switch (Ones)
                    {
                        case 0:

                            return "Ten";
                        case 1:

                            return "eleven";

                        case 2:

                            return "twelve";
                        case 3:

                            return "thirteen";

                        case 4:

                            return "fourteen";

                        case 5:

                            return "fithteen";

                        case 6:

                            return "sixteen";

                        case 7:

                            return "seventeen";

                        case 8:

                            return "eighteen";

                        case 9:

                            return "nineteen";

                    }
                    break;
                case 20:

                    StringToReturn += "twenty";

                    break;
                case 30:

                    StringToReturn += "Thirty";

                    break;
                case 40:

                    StringToReturn += "Fourty";

                    break;
                case 50:

                    StringToReturn += "fithty";

                    break;
                case 60:

                    StringToReturn += "sixty";

                    break;
                case 70:

                    StringToReturn += "seventy";

                    break;
                case 80:

                    StringToReturn += "eighty";

                    break;
                case 90:

                    StringToReturn += "ninty";

                    break;
                case 100:

                    return "One Hundred";
            }

            switch (Ones)
            {
                case 1:

                    StringToReturn += " one";

                    break;
                case 2:

                    StringToReturn += " two";

                    break;
                case 3:

                    StringToReturn += " three";

                    break;
                case 4:

                    StringToReturn += " four";

                    break;
                case 5:

                    StringToReturn += " five";

                    break;
                case 6:

                    StringToReturn += " six";

                    break;
                case 7:

                    StringToReturn += " seven";


                    break;
                case 8:

                    StringToReturn += " eight";

                    break;
                case 9:

                    StringToReturn += " nine";

                    break;


            }
            return StringToReturn;


        }

        static public int MultiBy(this int I, int b)
        {
            return I * b;
        }
    }
    static class ObjExtension
    {
        public static bool IsNull(this object O)
        {
            return O == null;
        }
    }

}
