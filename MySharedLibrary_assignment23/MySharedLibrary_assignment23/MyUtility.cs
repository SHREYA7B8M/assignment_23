﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary_assignment23
{
    public class MyUtility
    {
        public static bool IsValidEmail(string email)
        {
            
            return email.Contains("@") && email.Contains(".");
        }

        public static void LogMessage(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
}
