﻿using System;



namespace myApp

{

    class Program

    {

        static void Main()

        {

            Begin1();

            Begin2();

            Begin3();

            Begin4();

            Begin5();

            Begin6();

            Begin7();

            Begin8();

            Begin9();

            Begin10();

            Begin11();

            Begin12();

            Begin13();

            Begin14();

            Begin15();

            Begin16();

            Begin17();

            Begin18();

            Begin19();

            Begin20();

            Begin21();

            Begin22();

            Begin23();

            Begin24();

            Begin25();

            Begin26();

            Begin27();

            Begin28();

            Begin29();

            Begin30();

            Begin31();

            Begin32();

            Begin33();

            Begin34();

            Begin35();

            Begin36();

            Begin37();

            Begin38();

            Begin39();

            Begin40();

        }



        static void Begin1()

        {

            int a = 10;

            int P = a * 4;

            Console.WriteLine(P);

        }

        static void Begin2()

        {

            int a = 3;

            int S = a * a;

            Console.WriteLine(S);

        }

        static void Begin3()

        {

            int a = 5;

            int b = 9;

            int S = a * b;

            int P = 2 * (a + b);

            Console.WriteLine(S + " " + P);

        }

        static void Begin4()

        {

            int d = 6;

            double L = d * Math.PI;

            Console.WriteLine(L);

        }

        static void Begin5()

        {

            int a = 4;

            int V = a * a * a;

            int S = 6 * a * a;

            Console.WriteLine(V + " " + S);

        }

        static void Begin6()

        {

            int a = 3;

            int b = 7;

            int c = 4;

            int V = a * b * c;

            int S = 2 * (a * b + b * c + a * c);

            Console.WriteLine(V + " " + S);

        }

        static void Begin7()

        {

            int R = 6;

            double L = 2 * Math.PI * R;

            double S = R * R * Math.PI;

            Console.WriteLine(L + " " + S);

        }

        static void Begin8()

        {

            float a = 6;

            float b = 9;

            float average = (a + b) / 2;

            Console.WriteLine(average);

        }

        static void Begin9()

        {

            uint a = 5;

            uint b = 9;

            double geom_average = Math.Sqrt(a * b);

            Console.WriteLine(geom_average);

        }

        static void Begin10()

        {

            float a = 3;

            float b = 7;

            float sum = a * a + b * b;

            float sub = a * a - b * b;

            float product = a * a * b * b;

            double division = a * a / b * b;

            Console.WriteLine(sum + " " + sub + " " + product + " " + division);

        }

        static void Begin11()

        {

            float a = Math.Abs(-3);

            float b = Math.Abs(-7);

            float sum = a + b;

            float sub = a - b;

            float product = a * b;

            double division = a / b;

            Console.WriteLine(sum + " " + sub + " " + product + " " + division);

        }

        static void Begin12()

        {

            float a = 5;

            float b = 7;

            double c = Math.Sqrt(a * a + b * b);

            double P = a + b + c;

            Console.WriteLine(c + " " + P);

        }

        static void Begin13()

        {

            int R1 = 8;

            int R2 = 3;

            double S1 = Math.PI * R1 * R1;

            double S2 = Math.PI * R2 * R2;

            double S3 = S1 - S2;

            Console.WriteLine(S1 + " " + S2 + " " + S3);

        }

        static void Begin14()

        {

            int L = 7;

            double R = L / 2 / Math.PI;

            double S = R * R * Math.PI;

            Console.WriteLine(R + " " + S);

        }

        static void Begin15()

        {

            int S = 9;

            double D = Math.Sqrt(S / Math.PI) / 2;

            double L = D * Math.PI;

            Console.WriteLine(D + " " + L);

        }

        static void Begin16()

        {

            int x1 = 5;

            int x2 = 3;

            int L = Math.Abs(x2 - x1);

            Console.WriteLine(L);

        }

        static void Begin17()

        {

            int A = 2;

            int B = 5;

            int C = 8;

            int L1 = Math.Abs(A - C);

            int L2 = Math.Abs(B - C);

            int sum = L1 + L2;

            Console.WriteLine(L1 + " " + L2 + " " + sum);

        }

        static void Begin18()

        {

            int A = 2;

            int B = 5;

            int C = 3;

            int L1 = Math.Abs(A - C);

            int L2 = Math.Abs(B - C);

            int product = L1 * L2;

            Console.WriteLine(L1 + " " + L2 + " " + product);

        }

        static void Begin19()

        {

            int x1 = 2;

            int y1 = 5;

            int x2 = 4;

            int y2 = 7;

            int x3 = x1;

            int y3 = y2;

            int x4 = x2;

            int y4 = y1;

            int L1 = Math.Abs(y1 - y3);

            int L2 = Math.Abs(x1 - x4);

            int S = L1 * L2;

            int P = 2 * (L1 + L2);

            Console.WriteLine(S + " " + P);

        }

        static void Begin20()

        {

            int x1 = 7;

            int y1 = 4;

            int x2 = 5;

            int y2 = 8;

            double L = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            Console.WriteLine(L);

        }

        static void Begin21()

        {

            int x1 = 7;

            int y1 = 4;

            int x2 = 5;

            int y2 = 8;

            int x3 = 2;

            int y3 = 9;

            double a = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            double b = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));

            double c = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));

            double p = (a + b + c) / 2;

            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine(S);

        }

        static void Begin22()

        {

            int A = 4;

            int B = 7;

            int temp = A;

            A = B;

            B = temp;

            Console.WriteLine(A + " " + B);

        }

        static void Begin23()

        {

            int A = 4;

            int B = 7;

            int C = 6;

            int temp = B;

            B = A;

            A = C;

            C = temp;

            Console.WriteLine(A + " " + B + " " + C);

        }

        static void Begin24()

        {

            int A = 4;

            int B = 7;

            int C = 6;

            int temp = C;

            C = A;

            A = B;

            B = temp;

            Console.WriteLine(A + " " + B + " " + C);

        }

        static void Begin25()

        {

            int a = 2;

            double x = 3 * Math.Pow(a, 6) - 6 * a * a - 7;

            Console.WriteLine(x);

        }

        static void Begin26()

        {

            int a = 2;

            double x = 4 * Math.Pow(a - 3, 6) - 7 * (a - 3) * (a - 3) * (a - 3) + 2;

            Console.WriteLine(x);

        }

        static void Begin27()

        {

            int A = 3;

            int A2 = A * A;

            int A4 = A2 * A2;

            int A8 = A4 * A4;

            Console.WriteLine(A2 + " " + A4 + " " + A8);

        }

        static void Begin28()

        {

            int A = 4;

            int A2 = A * A;

            int A3 = A2 * A;

            int A5 = A3 * A * A;

            int A10 = A5 * A5;

            int A15 = A10 * A5;

            Console.WriteLine(A2 + " " + A3 + " " + A5 + " " + A10 + " " + A15);

        }

        static void Begin29()

        {

            double a = 40;

            double x = (a / 180) * Math.PI;

            Console.WriteLine(x);

        }

        static void Begin30()

        {

            double a = 2;

            double x = (a / Math.PI) * 180;

            Console.WriteLine(x);

        }

        static void Begin31()
        {
            int TF = 120;
            int TC = (TF - 32) * 5 / 9;
            Console.WriteLine(TC);


        }
        static void Begin32()
        {
            int TF = 48;
            int TC = (TF - 32) * 5 / 9;
            Console.WriteLine(TC);


        }
        static void Begin33()
        {
            int x = 5;
            int a = 1000;
            int y = 6;
            int s1 = a / x;
            int sy = a / x * y;
            Console.WriteLine(s1+ " " +sy);
          

        }
        static void Begin34()
        {
            int X = 8;
            int A = 50;
            int Y = 12;
            int B = 40;
            double OneKgCandies = (double)1 / X * A;
            double OneKgButterscotch = (double)1 / Y * B;
            double sub = OneKgCandies / OneKgButterscotch;
            Console.WriteLine(OneKgCandies + " " + OneKgButterscotch + " " + sub);
        }
        static void Begin35()
        {
            int V = 8;
            int U = 2;
            int T1 = 3;
            int T2 = 2;
            int S1 = (V + U) * T1;
            int S2 = (V - U) * T2;
            int S = S1 + S2;
            Console.WriteLine(S);
        }
        static void Begin36()
        {
            int V1 = 50;
            int V2 = 30;
            int T = 2;
            int S = (V1 + V2) * T;
            Console.WriteLine(S);
        }
        static void Begin37()
        {
            int V1 = 30;
            int V2 = 40;
            int T = 2;
            int S = 120;
            int S1 = Math.Abs(S - ((V1 + V2) * T));
            Console.WriteLine(S1);
        }
        static void Begin38()
        {
            int A = 10;
            int B = -20;
            double x = (double)-(B / A);
            Console.WriteLine(x);
        }
        static void Begin39()
        {



        }
        static void Begin40()
        {



        }

    }

}


