//Copyright (C) 2020 Duncan McDougall, All rights Reserved
using System;
using System.Threading;

namespace Adventure
{
    class Wait5
    {
        internal static void Run()
        {
            int seconds = 5 * 1000;

            var timer =
                new Timer(TimerMethod, null, 0, seconds);
        }

        private static void TimerMethod(object o)
        {

        }
    }




}