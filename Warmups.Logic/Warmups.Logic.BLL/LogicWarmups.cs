using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.Logic.BLL
{
   public class LogicWarmups
    {
       public bool GreatParty(int cigars, bool isWeekend)
       {
           bool result;

           if ((cigars >= 40 && cigars <= 60) || isWeekend == true)
               result = true;

           else
               result = false;

           return result;
       }

       public int CanHazTable(int yourStyle, int dateStyle)
       {
           int result;
           if (yourStyle >= 8 || dateStyle >= 8)
           {
               result = 2;
           }
           else if (yourStyle <= 2 || dateStyle <= 2)
           {
               result = 0;
           }
           else
           {
               result = 1;
           }

           return result;
       }

       public bool PlayOutside(int temp, bool isSummer)
       {
           bool result;
           if (temp >= 60 && temp <= 90 || isSummer == true && temp >= 60 && temp <= 100)
           {
               result = true;
           }
           else
           {
               result = false;
           }

           return result;

       }

       public int CaughtSpeeding(int speed, bool isBirthday)
       {
           int result;

           if (speed <= 60 || (speed <= 65 && isBirthday == true))
           {
               result = 0;
           }
           else if (speed >= 61 && speed <= 80 || (speed >= 65 && speed <= 85 && isBirthday == true))
           {
               result = 1;
           }
           else
           {
               result = 2;
           }
           return result;

       }

       public int SkipSum(int a, int b)
       {
           int result ;
           if (a + b >= 10 && a + b <= 19)
           {
               result = 20;
           }
           else
           {
               result = a + b;
           }

           return result;

       }

       public string AlarmClock(int day, bool vacation)
       {
           string result;
           if (day >= 1 && day <= 5)
           {
               if (vacation == false)
               {
                   result = "7:00";
               }
               else
               {
                   result = "10:00";
               }
           }

           else
           {
               if (vacation == false)
               {
                   result = "10:00";
               }
               else
               {
                   result = "off";
               }
           }

           return result;
       }

       public bool LoveSix(int a, int b)
       {
           bool result;
           int absValue = Math.Abs(a - b);
           int absValue2 = Math.Abs(b - a);

           if (a == 6 || b == 6)
           {
               result = true;
           }
           else if (a + b == 6 || absValue == 6 || absValue2 == 6)
           {
               result = true;
           }
           else
           {
               result = false;
           }

           return result;

       }


       public bool InRange(int n, bool outsideMode)
       {
           bool result;

           if (n >= 1 && n <= 10 && outsideMode == false)
           {
               result = true;
           }
           else if (outsideMode == true && (n >= 1 || n <= 10))
           {
               result = true;
           }
           else
           {
               result = false;
           }

           return result;

       }

       public bool SpecialEleven(int n)
       {
           bool result;

           if (n % 11 == 0 || n % 11 == 1)
           {
               result = true;
           }
           else
           {
               result = false;
           }
           return result;
       }

       public bool Mod20(int n) 
       {
            bool result;
            if(n % 20 == 1 || n % 20 == 2)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
  
        }

       public bool Mod35(int n)
       {
           bool result;

           if (n % 3 == 0 && n % 5 != 0)
           {
               result = true;
           }
           else if (n % 5 == 0 && n % 3 != 0)
           {
               result = true;
           }
           else
           {
               result = false;
           }

           return result;

       }

       public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
       {
           bool result;
           if (isAsleep == true)
           {
               result = false;
           }
           else if (isMorning == true)
           {
               if (isMom == true)
                   result = true;
               else
                   result = false;
           }
           else
           {
               result = true;
           }
           return result;

       }

       public bool TwoIsOne(int a, int b, int c)
       {
           bool result;
           if (a + b == c || a + c == b || b + c == a)
           {
               result = true;
           }
           else
           {
               result = false;
           }
           return result;

       }

       public bool AreInOrder(int a, int b, int c, bool bOk)
       {
           bool result;
           if (b < c)
           {
               if (bOk == true)
                   result = true;
               else if (a < b)
                   result = true;
               else
                   result = false;
           }
           else
           {
               result = false;
           }
           return result;
       }

       public bool InOrderEqual(int a, int b, int c, bool equalOk)
       {
           bool result;
           if (a < b && b < c || a < c && equalOk == true)
               result = true;
           else
               result = false;

           return result;

       }

       public bool LastDigit(int a, int b, int c)
       {
           bool result;
           if (a % 10 == b % 10 || b % 10 == c % 10 || a % 10 == c % 10)
               result = true;
           else
               result = false;

           return result;

       }

        public int RollDice(int die1, int die2, bool noDoubles)
        {
            int result;
            if(noDoubles!=true)
            { 
                result = die2 + die1;
            }
            else
            {
                if (die2 == die1)
                {
                    if (die1 < 6 && die2 < 6)
                    {
                        result = die2 + die1+1;
                    }
                    else
                    {
                        die1 = 1;
                        result = die1 + die2;
                    }
                }
                else
                {
                    result = die2 + die1;
                }
            }

            return result;
        }
    

    }
}
