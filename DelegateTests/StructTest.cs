﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTests
{
    public class StructTest
    {
        private static void f(string str) { Console.WriteLine($"f({str})"); }
        private static void g(string str) { Console.WriteLine($"g({str})"); }
        private static void h(string str) { Console.WriteLine($"h({str})"); }

        private struct foo
        {
            private int d_id;
            private int bar_calls;
            private int cbs_calls;

            public foo(int d_id)
            {
                this.d_id = d_id;
                this.bar_calls = 0;
                this.cbs_calls = 0;
            }

            public void bar(string str)
            {
                Console.WriteLine($"foo({this.d_id})::bar({str})");
                this.bar_calls++;
            }

            public void cbs(string str)
            {
                Console.WriteLine($"foo({this.d_id})::cbs({str})");
                this.cbs_calls++;
            }
        }

        public static void Run()
        {
            Action<string> d0 = (string s) => { };

            foo f0 = new foo(0);
            foo f1 = new foo(1);

            d0 += f;
            d0 += g;
            d0 += g;
            d0 += h;

            d0 += f0.bar;
            d0 += f0.cbs;
            d0 += f1.bar;
            d0 += f1.cbs;
            d0("first call");
            d0 -= g;
            d0 -= f0.cbs;
            d0 -= f1.bar;
            d0("second call");
        }
    }
}
