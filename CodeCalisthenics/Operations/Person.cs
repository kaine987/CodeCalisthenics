﻿using System;

namespace CodeCalisthenics.Operations
{
    public class Person
    {
        public int age;

        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                age = 0;
                var msg = "Age is not valid, setting age to 0.";
                Console.WriteLine(msg);
            }
            else
                age = initialAge;
        }

        public string AmIOld()
        {
            var message = GetStatusMessage();
            Console.WriteLine(message);
            return message;
        }

        public void YearPasses()
        {
            age += 1;
        }

        public string GetStatusMessage()
        {
            if (age < 13)
                return "You are young.";

            return age < 18 
                ? "You are a teenager." : "You are old.";
        }
    }
}