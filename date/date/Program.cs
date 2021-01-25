using System;

namespace date
{
    class Program
    {
        static void Main()
        {

            DateTime myDateTimeVariable = new DateTime(2005, 8, 2);
            DateTime myDateTimeVariable2 = DateTime.Now;

            int result = DateTime.Compare(myDateTimeVariable, myDateTimeVariable2);


            Console.WriteLine(result);
            {
                if (myDateTimeVariable < myDateTimeVariable2)
                {
                    Console.WriteLine("Less than");
                }
                else
                {
                    Console.WriteLine("Greater than");
                }
            }
        }
    }
}

    


