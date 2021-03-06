﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM_Machine.Functions
{
    public class ShowPanel
    {
        public static void ShowStart()
        {
            Console.WriteLine("Please insert card (enter your card number)");
            
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your PIN code: ");
            string PIN = Console.ReadLine();
            Authentication.CheckPIN(PIN, number);
        }

        public static void ShowPossibilities(Guid id)
        {
            int number;
            ATMDbContext db = new ATMDbContext();
            do { 
            Console.WriteLine("1. Show current account status");
            Console.WriteLine("2. Withdraw money");
            Console.WriteLine("3. Get code for phone");
            Console.WriteLine("4. Exit");
            
            number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                {
                    Account.ShowStatus(id);
                }
                else if (number == 2)
                {
                    Account.WithdrawMoney(id);
                }
                else if (number == 3)
                {
                    Account.GenerateCode(id);
                }
            } while (number != 4);
        }
    }
}
