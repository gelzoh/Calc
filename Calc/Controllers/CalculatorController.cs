using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using log4net;

namespace Calc.Controllers
{
    public class CalculatorController : ApiController
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Get numbers all numbers up to and including the number entered, except when:
        //  a number is a multiple of 3 output C, and when,
        //  a number is a multiple of 5 output E, and when,
        //  a number is a multiple of both 3 and 5 output Z
        public string GetMultipleNumbers(int id)
        {
            String response = "";
            try
            {
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

            }
            catch (Exception ex)
            {
                response = "There was an error in the application";
                log.Error(ex.Message);
                throw ex;
            }
            return response;
            
        }

        //Get all odd numbers up to and including the number entered
        public string GetOddNumbers(int id)
        {
            String response = "";
            try
            { 
                for (int i = 1; i <= id; i += 2)
                {
                    response += i.ToString();
                    if (i != id - 1 && i != id)
                        response += ",";
                    else if (id % 2 != 0)
                        response += "," + id.ToString();
                }
            }
            catch (Exception ex)
            {
                response = "There was an error in the application";
                log.Error(ex.Message);
                throw ex;
            }
            return response;
        }

        //Get all numbers up to and including the number entered
        public string GetAllNumbers(int id)
        {
            String response = "";
            try
            {
                for (int i = 1; i < id; i++)
                {
                    response += i.ToString() + ",";
                }
                response += id.ToString();
            }
            catch (Exception ex)
            {
                response = "There was an error in the application";
                log.Error(ex.Message);
                throw ex;
            }
            return response;
        }

        //Get all even numbers up to and including the number entered
        public string GetEvenNumbers(int id)
        {
            String response = "";
            try
            {
                for (int i = 2; i <= id; i += 2)
                {
                    response += i.ToString();
                    if (i != id - 1 && i != id)
                        response += ",";
                }
            }
            catch (Exception ex)
            {
                response = "There was an error in the application";
                log.Error(ex.Message);
                throw ex;
            }
            return response;
        }

        //Get all fibonacci numbers up to and including the number entered
        public string GetFibonacchiNumbers(int id)
        {
            String response = "";
            try
            { 
                for (int i = 1; i <= id; i++)
                {

                    response += CalculateFibonacchi(i).ToString();
                    if (i < id)
                        response += ",";
                }
            }
            catch (Exception ex)
            {
                response = "There was an error in the application";
                log.Error(ex.Message);
                throw ex;
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
