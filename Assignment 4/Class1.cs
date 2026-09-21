using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    public class Class1
    {
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    enum Colors
    {
        Red,
        Green,
        Blue
    }
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    struct Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}