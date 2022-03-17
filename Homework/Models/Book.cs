using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    internal class Book : Product
    {
        public string genre;

        public Book(string genre, int no, string name, double price) : base(no, name, price)
        {
            this.genre = genre;
        }

        public string GetInfo()
        {
            return $"{no} - {name} - {price} - {genre}";
        }
    }
}
