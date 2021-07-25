using System;
using System.Collections.Generic;

namespace Redmind_ATM
{
    public class Program
    {
        // Made two lists one with the withdraws in asked order and one with each bill that exists in the ATM
        private static readonly List<int> withdraws = new() { 1500, 700, 400, 1100, 1000, 700, 300 };
        private static List<int> atmBills = new() { 100, 100, 100, 100, 100, 500, 500, 500, 1000, 1000 };

        static void Main(string[] args)
        {
            for (int i = 0; i < withdraws.Count; i++)
            {
                int bill = withdraws[i];

                bool success = BillAmountCheck(bill);

                if (success == true)
                {
                    Console.WriteLine($"{success} -- Succeded to withdraw {bill}");
                }
                else
                {
                    Console.WriteLine($"{success} -- Failed to withdraw {bill}");
                }
            }
        }

        // Made a bool method that returns if the withdraw is succeeded or not (true or false)
        public static bool BillAmountCheck(int withdraw)
        {
            List<int> withdrawnBills = new();
            int result = 0;

            for (int i = atmBills.Count; i-- > 0;)
            {
                int atmBill = atmBills[i];
                if (withdraw >= result + atmBill && withdraw >= atmBill)
                {
                    result += atmBill;

                    withdrawnBills.Add(i);

                    if (withdraw.Equals(result))
                    {
                        break;
                    }
                }
            }

            if (result != withdraw)
            {
                return false;
            }
            foreach (var bill in withdrawnBills)
            {
                atmBills.RemoveAt(bill);
            }
            return true;
        }
    }
}
