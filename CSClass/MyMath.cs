﻿using System;

namespace CSClass
{
    class MyMath
    {
        int some_int = 3;
        /// <summary>
        /// 절대값 구하는 클래스 메서드
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
         public static int Abs(int v) {
            //some_int 5; 인스턴수 변수 : 클래스에서 변수 사용불가
            //foo(); 인스턴스 메서드 : 클래스 메서드에서 사용 불가
            return (v<0) ?-1 : v;
        }

        void foo()
        {
            Console.WriteLine("클래스 메서드에서 접근불가");
        }
    }
}