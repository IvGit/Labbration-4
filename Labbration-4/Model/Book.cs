﻿using System;
namespace Labbration_4
{
    public class Book
    {
        public int ID { get; set; }
        public int Total { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string Författare { get; set; }
        public string genre { get; set; }
        public string format { get; set; }
        public string Språk { get; set; }
        public bool BoVale { get; internal set; }

        public Book()
        {
            BoVale = false;

        }






        public override string ToString()
        {


            return $"{Språk} {price}";
        }
    }
}