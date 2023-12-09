using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ваш домашний номер телефона");
        var homeNumber = Console.ReadLine();

        Console.WriteLine("Введите ваш мобильный номер телефона");
        var mobileNumber = Console.ReadLine();

        Console.WriteLine("Введите ваш email");
        var email = Console.ReadLine();

        Console.WriteLine("Введите ваше ФИО");
        var fullName = Console.ReadLine();


        string patternHomeN = @"^\d{10}$";// должна быть последовательность из 10 цифр

        string patternMobileN = @"^\+?\d{10,}$";//\+? символ может встречаться 0 или 1 раз 

        string patternEmail = "^[0-9a-zA-Z]+[._]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,}$";//должны быть буквыцифры любых реестров, возможен знак точка или подчерк 0 или 1 раз обязательно должен быть символ @ и обязательно точка после точки 2 или более символов

        string patternFullName = @"^\S{2,}\s\S{2,}\s\S{2,}$";//не менее 2 символов которые не являются пробелами, один пробел 

        Console.WriteLine();
        HomeP(homeNumber, patternHomeN);// вызов методов
        MobilePh(mobileNumber, patternMobileN);
        Email(email, patternEmail);
        FullName(fullName, patternFullName);
    }

    static void HomeP(string homeNumber, string patternHomeN)
    {
        if (Regex.IsMatch(homeNumber, patternHomeN))
        {
            Console.WriteLine("Домашний телефон верен");// если дало тру то вот это
        }
        else
        {
            Console.WriteLine("Домашний телефон не верен");// если дало чтото другое фолз например то вот это
        }
    }

    static void MobilePh(string mobileNumber, string patternMobileN)
    {
        if (Regex.IsMatch(mobileNumber, patternMobileN))
        {
            Console.WriteLine("Мобильный номер телефона верен");
        }
        else
        {
            Console.WriteLine("Мобильный номер телефона не верен");
        }


    }
    static void Email(string email, string patternEmail)
    {
        if (Regex.IsMatch(email, patternEmail))
        {
            Console.WriteLine("Ваша почта верна");
        }
        else
        {
            Console.WriteLine("Вы ввели не правильный формат почты");
        }
    }

    static void FullName(string fullName, string patternFullName)
    {
        if (Regex.IsMatch(fullName, patternFullName))
        {
            Console.WriteLine("Ваше имя верно:)");
        }
        else
        {
            Console.WriteLine("Вы вввели имя не правильно");
        }
    }
}
