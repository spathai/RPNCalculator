using System;
using System.Collections.Generic;

namespace Operation
{
    public class calculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public double SumFloat(double a, double b)
        {
            return a + b;
        }


        public double? calculateRPN(string rpnString)
        {
            double? result = null;
            try
            {
                string[] rpnArray = rpnString.Split(',');
                List<string> tempList = new List<string>();
                int currentCount = 0;
                for (int i = 0; i < rpnArray.Length; i++)
                {
                    switch (rpnArray[i])
                    {
                        case "+":
                            result = Convert.ToDouble(tempList[tempList.Count - 2]) + Convert.ToDouble(tempList[tempList.Count - 1]);
                            currentCount = tempList.Count;
                            tempList.RemoveAt(currentCount - 1);
                            tempList.RemoveAt(currentCount - 2);
                            tempList.Add(result.ToString());
                            break;
                        case "-":
                            result = Convert.ToDouble(tempList[tempList.Count - 2]) - Convert.ToDouble(tempList[tempList.Count - 1]);
                            currentCount = tempList.Count;
                            tempList.RemoveAt(currentCount - 1);
                            tempList.RemoveAt(currentCount - 2);
                            tempList.Add(result.ToString());
                            break;
                        case "*":
                            result = Convert.ToDouble(tempList[tempList.Count - 2]) * Convert.ToDouble(tempList[tempList.Count - 1]);
                            currentCount = tempList.Count;
                            tempList.RemoveAt(currentCount - 1);
                            tempList.RemoveAt(currentCount - 2);
                            tempList.Add(result.ToString());
                            break;
                        case "/":
                            result = Convert.ToDouble(tempList[tempList.Count - 2]) / Convert.ToDouble(tempList[tempList.Count - 1]);
                            currentCount = tempList.Count;
                            tempList.RemoveAt(currentCount - 1);
                            tempList.RemoveAt(currentCount - 2);
                            tempList.Add(result.ToString());
                            break;
                        case "%":
                            result = Convert.ToDouble(tempList[tempList.Count - 1]) / 100;
                            currentCount = tempList.Count;
                            tempList.RemoveAt(currentCount - 1);
                            tempList.Add(result.ToString());
                            break;
                        case "!":
                            result = CalFactorial(Convert.ToInt32(tempList[tempList.Count - 1]));
                            currentCount = tempList.Count;
                            tempList.RemoveAt(currentCount - 1);
                            tempList.Add(result.ToString());
                            break;
                        default:
                            tempList.Add(rpnArray[i]);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            return result;
        }
        private int CalFactorial(int n)
        {
            int result = 1;
            try
            {
                for (int i = 1; i <= n; i++)
                {
                    result = result * i;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}


