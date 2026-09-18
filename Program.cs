// так как у меня старенький мак то вот это начало обязательно
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

            //int age = 16;
            //double height = 1.4;
            //bool Soprovod = true;
            //if (age >= 14 && height >= 1.5 || age >= 14 && Soprovod == true) {
            //    Console.WriteLine("Можно кататься");
            //} else {
            //    Console.WriteLine("Пока нельзя");



            //int number = 6; 
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine($"Число {number} четное");
            //}
            //else
            //{
            //    Console.WriteLine($"Число {number} нечетное");
            //}

                
            //int grade = 2;
            //if (grade == 5)
            //{
            //    Console.WriteLine("Отлично");
            //}
            //else if (grade == 4)
            //{
            //    Console.WriteLine("Хорошо");
            //}
            //else if (grade == 3)
            //{
            //    Console.WriteLine("Удовлетворительно");
            //}
            //else if (grade == 2)
            //{
            //    Console.WriteLine("Неудовлетворительно");
            //}
            //else
            //{
            //   Console.WriteLine("Неверная оценка");
            //}




            //int age = 19;
            //if (age >= 18) {
            //    Console.WriteLine("Доступ разрешен");
            //} else {
            //    Console.WriteLine("Доступ запрещен");
            //}



            int ball = 67;
            if (ball < 0 || ball > 100)
            {
                Console.WriteLine("Неверное значение");
            }
            else if (ball >= 90 && ball <= 100)
            {
                Console.WriteLine("Отлично");
            }
            else if (ball >= 75 && ball <= 89)
            {
                Console.WriteLine("Хорошо");
            }
            else if (ball >= 60 && ball <= 74)
            {
                Console.WriteLine("Удовлетворительно");
            }
            else
            {
                Console.WriteLine("Неудовлетворительно");
            }



            
        }
    }
}
