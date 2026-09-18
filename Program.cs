using System;

namespace Lab04_Bodin
{
    class Program
    {
        static void Main()
        {

            //int age = 15;

            //if (age >= 21) 
            //{
            //Console.WriteLine("Доступ разрешен");
            //}
            //Console.WriteLine("Программа продолжает работу");
            
            //int age = 15;
            //if (age >= 18) {
            //    Console.WriteLine("Доступ разрешен");
            //} else {
            //    Console.WriteLine("Доступ запрещен");
            //    Console.WriteLine($"Осталось ждать до совершеннолетия: {18 - age} лет");
            //}

            //int age = 61;
            //if (age < 13) {
            //    Console.WriteLine("Ребенок");
            //} else if (age < 18) {
            //    Console.WriteLine("Подросток");
            //} else if (age < 60) {
            //    Console.WriteLine("Взрослый");
            //} else {
            //    Console.WriteLine("Пенсионер");
            //}

            int age = 16;
            double height = 1.4;
            bool Soprovod = true;
            if (age >= 14 && height >= 1.5 || age >= 14 && Soprovod == true) {
                Console.WriteLine("Можно кататься");
            } else {
                Console.WriteLine("Пока нельзя");
            }
        }
    }
}
