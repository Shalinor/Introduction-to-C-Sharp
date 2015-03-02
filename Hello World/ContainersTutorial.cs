using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class ContainersTutorial
    {
//        int[] array;

        public void ArrayExample(int size_)
        {
            //Moved to class property to allow broader use...
//            array = new int[size_];
            int[] array = new int[size_];

            //for(int index = 0; index < array.Length; ++index)
            //{
            //    Console.WriteLine(array[index]);
            //}

            //Step 1 - replace for loop with foreach
            //foreach (int value in array)
            //{
            //    Console.WriteLine(array[value]);
            //}

            DisplayArray(array); //Moved into function for additional use

            //Step 2 - try foreach to set values and see what happens?
                //Throws out of bounds exception...
            //foreach (int value in array)
            //{
            //    array[value] = 10;
            //}

            DisplayArray(array); //Moved into function for additional use
        }

        public void DisplayArray(int[] array_)
        {
            Console.WriteLine("array_.Length: " + array_.Length);
            Console.WriteLine("array_.GetLength(0): " + array_.GetLength(0));

            foreach (int value in array_)
            {
                Console.WriteLine(array_[value]);
            }
        }
    }
}
