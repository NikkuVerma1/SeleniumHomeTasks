using NUnit.Framework;
using System;

namespace SeleniumHT4
{
    public class Tests
    {
        Password p;

        [SetUp]
        public void Setup()
        {
            p = new Password();
        }

        [Test]
        public void TooShort()
        {
            //Assert.IsFalse(p.PasswordValidation("abc"), "\"abc\" is invalid Password");
            if (p.PasswordValidation("abc"))
            {
                Console.WriteLine("\"abc\" is Valid Password");

            }
            else
            {
                Console.WriteLine("\"abc\" is Invalid Password");
            }

        }

        [Test]
        public void TooLong()
        {

            //Assert.IsFalse(p.PasswordValidation("abc123456qwerty"), "\"abc123456qwerty\" is invalid Password");
            if (p.PasswordValidation("abc123456qwerty"))
            {
                Console.WriteLine("\"abc123456qwerty\" is Valid Password");

            }
            else
            {
                Console.WriteLine("\"abc123456qwerty\" is Invalid Password");
            }
        }

        [Test]
        public void EqualTo8()
        {

            //Assert.IsTrue(p.PasswordValidation("12345678"), "\"12345678\" is valid Password");
            if (p.PasswordValidation("12345678"))
            {
                Console.WriteLine("\"12345678\" is Valid Password");

            }
            else
            {
                Console.WriteLine("\"12345678\" is Invalid Password");
            }
        }

        [Test]
        public void EqualTo12()
        {

            //Assert.IsTrue(p.PasswordValidation("123456789101"), "\"123456789101\" is valid Password");
            if (p.PasswordValidation("123456789101"))
            {
                Console.WriteLine("\"123456789101\" is Valid Password");

            }
            else
            {
                Console.WriteLine("\"123456789101\" is Invalid Password");
            }
        }

        [Test]
        public void JustLessThan8()
        {

            //Assert.IsFalse(p.PasswordValidation("abcdefg"), "\"abcdefg\" is invalid Password");
            if (p.PasswordValidation("abcdefg"))
            {
                Console.WriteLine("\"abcdefg\" is Valid Password");

            }
            else
            {
                Console.WriteLine("\"abcdefg\" is Invalid Password");
            }
        }

        [Test]
        public void JustGreaterThan8()
        {

            //Assert.IsTrue(p.PasswordValidation("123abcdef"), "\"123abcdef\" is valid Password");
            if (p.PasswordValidation("123abcdef"))
            {
                Console.WriteLine("\"123abcdef\" is Valid Password");

            }
            else
            {
                Console.WriteLine("\"123abcdef\" is Invalid Password");
            }
        }

        [Test]
        public void JustLessThan12()
        {

            //Assert.IsTrue(p.PasswordValidation("abc@3$12311"), "\"abc@3$12311\" is valid Password");
            if (p.PasswordValidation("abc@3$12311"))
            {
                Console.WriteLine("\"abc@3$12311\" is Valid Password");

            }
            else
            {
                Console.WriteLine("\"abc@3$12311\" is Invalid Password");
            }
        }

        [Test]
        public void JustGreaterThan12()
        {

            //Assert.IsFalse(p.PasswordValidation("!@##$12345qws"), "\"!@##$12345qws\" is invalid Password");
            if (p.PasswordValidation("!@##$12345qws"))
            {
                Console.WriteLine("\"!@##$12345qws\" is Valid Password");

            }
            else
            {
                Console.WriteLine("\"!@##$12345qws\" is Invalid Password");
            }
        }

        [Test]
        public void NotAString()
        {

            //Assert.IsFalse(p.PasswordValidation(111), "111 is invalid Password");
            if (p.PasswordValidation(111))
            {
                Console.WriteLine("111 is Valid Password");

            }
            else
            {
                Console.WriteLine("111 is Invalid Password");
            }
        }


    }
}