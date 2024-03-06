﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
        public class Book
        {
            private string title;
            private double rating;

            public Book(string title, double rating)
            {
                this.Title = title;
                this.Rating = rating;
            }

            public string Title
            {
                get
                {
                   return title;
                }

                set
                {
                title = value; 
                }
            }

            public double Rating
            {
                get
                {
                return rating;
                }

                set
                {
                rating = value;
                }
            }

            public override string ToString()
            {
            return $"Book {Title} is with {Rating:F1} rating.";
            }
        }
}

