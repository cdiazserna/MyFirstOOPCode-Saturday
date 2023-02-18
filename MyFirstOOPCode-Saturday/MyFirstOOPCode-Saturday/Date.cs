using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MyFirstOOPCode_Saturday
{
    public class Date
    {
        #region Fields

        private int _year;
        private int _month;
        private int _day;

        #endregion

        #region Methods
        public Date(int year, int month, int day)
        {
            _year = ValidateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(day, month, year);
        }

        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }

            throw new YearException("The year is invalid!");
        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }

            throw new MonthException("The month is invalid!");
        }

        private int ValidateDay(int day, int month, int year) //day=29, month=12
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            //un arreglo SIEMPRE TIENE LA POSICIÓN 0, 1, 2..... N
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }

            throw new DayException("The day is invalid!");

            //if (month == 2 && day >= 1 && day <= 28)
            //{
            //    return day;
            //}
            //else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 && day >= 1 && day <= 31)
            //{
            //    return day;
            //}
            //else if (day >= 1 && day <= 30)
            //{
            //    return day;
            //}


        }

        //Un año bisiesto se da: CADA 4 AÑOS, CADA 400 AÑOS PERO NO CADA 100 AÑOS
        private bool IsLeapYear(int year)
        {
            bool isLeap = (year % 400 == 0 || year % 4 == 0 && year % 100 != 0);
            return isLeap;
        }

        public override string ToString()
        {
            string date = $"{_year:0000}/{_month:00}/{_day:00}";
            return date;
        }

        #endregion
    }
}
