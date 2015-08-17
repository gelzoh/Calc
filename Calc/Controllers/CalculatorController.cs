using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Calc.Controllers
{
    public class CalculatorController : ApiController
    {
        public string GetMultipleNumbers(int id)
        {
            String response = "";

            for (int i = 1; i <= id; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    response += "Z";
                else if (i % 3 == 0)
                    response += "C";
                else if (i % 5 == 0)
                    response += "E";
                else
                    response += i.ToString();
                if (i < id)
                    response += ",";
            }
            return response;
        }

        public string GetOddNumbers(int id)
        {
            String response = "";

            for (int i = 1; i <= id; i += 2)
            {
                response += i.ToString();
                if (i != id - 1 && i != id)
                    response += ",";
                else if (id % 2 != 0)
                    response += "," + id.ToString();
            }
            return response;
        }

        public string GetAllNumbers(int id)
        {
            String response = "";

            for (int i = 1; i < id; i++)
            {
                response += i.ToString() + ",";
            }
            response += id.ToString();
            return response;
        }

        public string GetEvenNumbers(int id)
        {
            String response = "";

            for (int i = 2; i <= id; i += 2)
            {
                response += i.ToString();
                if (i != id - 1 && i != id)
                    response += ",";
            }
            return response;
        }

        public string GetFibonacchiNumbers(int id)
        {
            String response = "";
            for (int i = 1; i <= id; i++)
            {

                response += CalculateFibonacchi(i).ToString();
                if (i < id)
                    response += ",";
            }
            return response;
        }

        private static int CalculateFibonacchi(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
                return CalculateFibonacchi(n - 1) + CalculateFibonacchi(n - 2);

        }
    }
}
