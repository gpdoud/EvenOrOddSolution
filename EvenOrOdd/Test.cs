using System;
using System.Collections.Generic;
using System.Text;

namespace EvenOrOdd {
    class Test {

        public static void Run() {
            var ints = new int[] { 1, 2, 3, 4 };
            {
                //var index = 0;
                //while(index < 4) {
                //    Console.WriteLine($"Index {index} of ints is {ints[index]}");
                //    index++;
                //}
            }

            for(var index = 0; index < 4; index++) {
                Console.WriteLine($"Index {index} of ints is {ints[index]}");
            }
        }
    }
}
