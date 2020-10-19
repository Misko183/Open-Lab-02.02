using System;
using System.Net.Http;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            string message = "";
            foreach (double i in numbers)

            {
                message = message + string.Format("{0:0.00} ", i);
            }

            message = message.Replace("," , ".");
            message = message.Replace("," , ".");
            message = message.Trim();
            Console.Write(message);

        }
    }
}
