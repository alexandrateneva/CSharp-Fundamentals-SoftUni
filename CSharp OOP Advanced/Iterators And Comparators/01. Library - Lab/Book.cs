﻿namespace _01.Library___Lab
{
    using System;
    using System.Collections.Generic;

    public class Book : IComparable<Book>
    {
        public string Title { get; private set; }
        public int Year { get; private set; }
        public IReadOnlyList<string> Authors { get; private set; }

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }

        public int CompareTo(Book other)
        {
            var yearCompare = this.Year.CompareTo(other.Year);
            if (yearCompare != 0)
            {
                return yearCompare;
            }
            return this.Title.CompareTo(other.Title);
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}