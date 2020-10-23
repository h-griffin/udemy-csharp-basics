﻿using System;

namespace HelloWorld
{
    class Program
    {
        // func returnVal name (perameters)
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;      //default double
            char character = 'A';           // char single
            string firstName = "Griffin";   // str double
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            var num = 3;    // defualt int

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            // format string    ^^ 

            const float Pi = 3.14f; //cannot change const

            //Implicit type conversion
            byte a = 1; // 00000001
            int b = a;  // 00000000 00000000 00000000 00000001

            int c = 1;  // no data loss
            float d = c;

            int e = 1;  // wont compile
            byte f = e; // int>byte / int is 4bytes : 3 bytes will be lost

            int g = 1;
            byte h = (byte)g; // change of data loss^^ force conversion

            float i = 1.0f;
            int j = (int)i; // 'cast'

            // non compatable type conversion
            string k = "1";
            int l = (int)k; // wont compile

        }
    }
}

// const float Pi = 3.14f;
//
// camel case : firstName - local vars
// pascal case : FirstName - constants
//
// byte: 0-255
// short: -32,768-32,767
// int: -2.1B- 2.1B
//
// defualt type is double, must specify what kind of num
// float number = 1.2f;
// decimal number = 1.2m;

// ### OVERFLOWING ###
//
// byte number = 255;
// number = number+1; //0 out of bounds
//
// checked
// {
// byte number = 255;
// number = number + 1;
// }
//
// ^^ over flow will not happend with checked keyword


// ### SCOPE ### 
// vars available inside block and children

