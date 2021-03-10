using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Comparison
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            //Start w/ our variables
            int age = 25;
            string userName = "Mick";

            //Check to see if something is = to something else
            bool equals = age == 41; //equals 
             Console.WriteLine(equals);
            
            bool userIsTerry = userName == "Terry";
            Console.WriteLine(userIsTerry);
            Console.WriteLine("User is 41:" + equals);

            //using the '!'(bang) operator
            bool notEqual = age != 122;
            Console.WriteLine($"User is not 122: {notEqual}");

            //Is not, !=
            bool userIsNotJustin = userName != "Justin";
            Console.WriteLine(userIsNotJustin);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            //Compare the list
            bool listAreEqual = firstList == secondList;
            Console.WriteLine($"The list are equal?: {listAreEqual}");

            //Greater than
            bool greaterThan = age > 12;

            //Greater than or equal to
            bool greaterThanOrEqual = age >= 24;
            Console.WriteLine(greaterThanOrEqual);

            //Less than
            bool lessThan = age <= 66;
            Console.WriteLine(lessThan);

            //Less than or equal to
            bool lessThanOrEqualTo = age <= 24;
            Console.WriteLine(lessThanOrEqualTo);

            //We have the or '||'
            bool orValue = equals || lessThan;


            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || falseValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || falseValue;
            bool fOrF = falseValue || falseValue;

            Console.WriteLine($"True or True { tOrT}");
            Console.WriteLine($"True or False { tOrF}");
            Console.WriteLine($"False or True { fOrT}");
            Console.WriteLine($"False or False {fOrF}");

            //And '&&'
            bool andValue = greaterThan && orValue;

            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndT = falseValue && trueValue;
            bool fAndF = falseValue && falseValue;
        }
    }
}
