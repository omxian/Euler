using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class CountingSundays
    {
        public enum Weeks
        {
            Mon,
            Tues,
            Wed,
            Thur,
            Fri,
            Sat,
            Sun,
        }
        
        public class Date
        {
            enum Months
            {
                None,
                Jan,
                Feb,
                Mar,
                Apr,
                May,
                Jun,
                Jul,
                Aug,
                Sep,
                Oct,
                Nov,
                Dec
            }
            static int[] monthDay = new int[] { 0, 31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int year;
            Months month;
            int day;
            public Date(int y, int m, int d)
            {
                year = y;
                month = (Months)m;
                day = d;
            }

            public bool Equals(Date compare)
            {
                return day == compare.day && month == compare.month && year == compare.year;
            }
            
            /// <summary>
            /// 获得二月份天数
            /// </summary>
            private int GetFebDays(int year)
            {
                if (IsLeapYear(year))
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }

            /// <summary>
            /// 判断输入是否闰年
            /// </summary>
            /// <param name="year"></param>
            /// <returns></returns>
            private bool IsLeapYear(int year)
            {
                //世纪年
                if (year % 100 == 0)
                {
                    return year % 400 == 0;
                }
                //普通年
                else
                {
                    return year % 4 == 0;
                }
            }

            /// <summary>
            /// 下一天
            /// </summary>
            public void NextDay()
            {
                if (DayFull())
                {
                    day = 1;
                    NextMonth();
                }
                else
                {
                    day++;
                }
            }

            /// <summary>
            /// 下个月
            /// </summary>
            private void NextMonth()
            {
                if (MonthFull())
                {
                    month = Months.Jan;
                    NextYear();
                }
                else
                {
                    month++;
                }
            }

            private void NextYear()
            {
                year++;
            }

            //日满进月
            private bool DayFull()
            {
                int days = monthDay[(int)month];
                //二月不确定
                if (month == Months.Feb)
                {
                    days = GetFebDays(year);
                }
                return day == days;
            }

            //月满进年
            private bool MonthFull()
            {
                return month == Months.Dec;
            }
            
            //是否是一个月的第一天
            public bool FirstOfMonth()
            {
                return day == 1;
            }
        }

        //计算1901 1 1 -> 2000 12 31 每个月的第一天有多少个星期天 
        public int Solution()
        {
            //Week在外面处理较好
            Date date1 = new Date(1900, 1, 1);
            Date date2 = new Date(1901, 1, 1);
            Date date3 = new Date(2000, 12, 31);

            //计算1901,1,1是周几,已知1900 1 1是周一
            Weeks current = Weeks.Mon;
            while(!date1.Equals(date2))
            {
                date1.NextDay();
                current++;
            }

            //计算1901 1 1 -> 2000 12 31 每个月的第一天有多少个星期天 
            int count = 0;
            while (!date1.Equals(date3))
            {
                if (date1.FirstOfMonth() && current == Weeks.Sun)
                {
                    count++;
                }

                date1.NextDay();
                current = (Weeks)((int)(current + 1) % 7);
            }
            
            return count;
        }
    }
}
