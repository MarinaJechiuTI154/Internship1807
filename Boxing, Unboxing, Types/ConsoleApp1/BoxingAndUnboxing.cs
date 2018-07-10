using System;
using System.Collections.Generic;

namespace ConsoleApp2{
     class BoxingAndUnboxing
    {
        private static List<object> list = new List<object>();
        public static void Boxing(object o)
        {
            list.Add(o);
        }

        public static int SumOfIntElements()
        {
            int sum = 0;
            foreach(object o in list)
            {
                try
                {
                    int i = (int)o;
                    sum += i;
                }
                catch(InvalidCastException e){

                }
            }
            return sum;
        }
    }
}

