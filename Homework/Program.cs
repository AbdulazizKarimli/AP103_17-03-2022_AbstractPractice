using Homework.Models;
using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ClassPracticeHomework
            //int length = GetInputInt("Nece eded kitab daxil edeceksiniz:", 0);


            //Book[] books = new Book[length];
            //for (int i = 0; i < length; i++)
            //{
            //    int no = GetInputInt("no:", 0);

            //    string name = GetInputStr("kitabin adi:", 0, 30);

            //    string genre = GetInputStr("Janr adi:", 4, 15);

            //    double price = GetInputDouble("Qiymet:", 0);

            //    int count = GetInputInt("Say:", 0);

            //    books[i] = new Book(genre, no, name, price)
            //    {
            //        count = count,
            //    };

            //}
            //bool check = true;

            //do
            //{
            //    Console.WriteLine("====== Menu ======");
            //    Console.WriteLine("1. Kitablari qiymete gore filterle");
            //    Console.WriteLine("2. Butun kitablari goster");
            //    Console.WriteLine("0. Proqrami bagla");

            //    string choice = Console.ReadLine();
            //    switch (choice)
            //    {
            //        case "1":
            //            double minPrice = GetInputDouble("min:", 0);
            //            double maxPrice = GetInputDouble("max:", 0);

            //            Book[] filteredBooks = FilterByPrice(books, minPrice, maxPrice);

            //            foreach (Book book in filteredBooks)
            //            {
            //                Console.WriteLine(book.GetInfo());
            //            }
            //            break;
            //        case "2":
            //            foreach (Book book in books)
            //            {
            //                Console.WriteLine(book.GetInfo());
            //            }
            //            break;
            //        case "0":
            //            check = false;
            //            break;
            //        default:
            //            Console.WriteLine("yoxdu");
            //            break;
            //    }
            //} while (check);

            #endregion

            #region AccessModifiersHomework
            User user = new User("test1", "Test123345");
            Console.WriteLine(user.Password);
            #endregion
        }

        #region ClassPracticeHomework

        //static Book[] FilterByPrice(Book[] books, double minPrice, double maxPrice)
        //{
        //    Book[] filteredBooks = new Book[0];

        //    foreach (var book in books)
        //    {
        //        if (book.price >= minPrice && book.price <= maxPrice)
        //        {
        //            Array.Resize(ref filteredBooks, filteredBooks.Length + 1); //Book[] books = new Book[2]
        //            filteredBooks[filteredBooks.Length - 1] = book; // book[1] = book
        //        }
        //    }

        //    return filteredBooks;
        //}

        //static int GetInputInt(string name, int min, int max = int.MaxValue)
        //{
        //    int input;
        //    string inputStr;
        //    bool isNum;
        //    do
        //    {
        //        Console.WriteLine(name);
        //        inputStr = Console.ReadLine();
        //        isNum = int.TryParse(inputStr, out input);
        //    } while (!isNum || input < min || input > max);

        //    return input;
        //}

        //static double GetInputDouble(string name, int min, int max = int.MaxValue)
        //{
        //    double input;
        //    do
        //    {
        //        Console.WriteLine(name);
        //        input = Convert.ToDouble(Console.ReadLine());
        //    } while (input < min || input > max);

        //    return input;
        //}

        //static string GetInputStr(string name, int min, int max = int.MaxValue)
        //{
        //    string input;
        //    do
        //    {
        //        Console.WriteLine(name);
        //        input = Console.ReadLine();
        //    } while (input.Length < min || input.Length > max);

        //    return input;
        //}
        #endregion

    }
}
