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

            //DisplayArray(array); //Moved into function for additional use

            //Step 2 - try foreach to set values and see what happens?
                //Throws out of bounds exception...
            //foreach (int value in array)
            //{
            //    array[value] = 10;
            //}

            //DisplayArray(array); //Moved into function for additional use

            Crap[] classArray = new Crap[10];

            for (int i = 0; i < classArray.Length; ++i)
            {
                classArray[i] = new Crap(); //So this would normally be in it's own for loop to instantiate...
                //Console.WriteLine(classArray[i].GetValue());

                classArray[i].SetValue(i + 1);
                Console.WriteLine(classArray[i].GetValue());
            }

            //Set internal Values
            //for (int i = 0; i < classArray.Length; ++i)
            //{
            //    classArray[i].SetValue(i);
            //}


            //Crap[] secondClassArray = (Crap[])classArray.Clone();

            Crap[] secondClassArray = new Crap[classArray.Length];//Crap[10];

            for (int i = 0; i < classArray.Length; ++i)
            {
                secondClassArray[i] = new Crap();
                secondClassArray[i] = Crap.Duplicate(classArray[i]);    //So I had to write my own function to achieve a value copy :@
            }
            
            //classArray.CopyTo(secondClassArray, 0);

            //Array.Copy(classArray, secondClassArray, classArray.Length);

            //secondClassArray = (Crap[]) classArray.Copy();
            
            for (int i = 0; i < classArray.Length; ++i)
            {
                secondClassArray[i].IncrementValue();
            }


            for (int i = 0; i < classArray.Length; ++i)
            {
                Console.WriteLine("Original : Copy - {0} : {1}", classArray[i].GetValue(), secondClassArray[i].GetValue());
            }
        }

        public void DisplayArray(int[] array_)  //This also covers Step 3 - pass the array into a function
        {
            Console.WriteLine("array_.Length: " + array_.Length);
            Console.WriteLine("array_.GetLength(0): " + array_.GetLength(0));

            foreach (int value in array_)
            {
                Console.WriteLine(array_[value]);
            }
        }

        public void ListExample()
        {
            //List<int> myList = new List<int>();
            //myList.Add(10);
            //myList.Add(1);

            List<int> myList = new List<int>() {3, 5, 2, 9, 7};

            //foreach(int item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            //Step 3: use an Index
            //for (int i = 0; i < myList.Count(); ++i)
            //{
            //    Console.WriteLine(myList[i]);
            //}

            //Step 3: try to access out of bounds
            //for (int i = 0; i < myList.Count(); ++i)
            //{
            //    Console.WriteLine(myList[i + 1]);
            //}

            //Step 4: convert to array
            //int[] tempArray = myList.ToArray();

            //for (int i = 0; i < myList.Count(); ++i)
            //{
            //    //tempArray[i] += 10;   //Me testing if it converts and copy's via reference - it doesn't
            //    Console.WriteLine("List : Array - {0} : {1}", myList[i], tempArray[i]);
            //}

            //Step 5: Remove 4th & 5th values
            //myList.RemoveRange(3, 2);   //4th value is at position 3, remove 2 values from that point
            
            //myList.RemoveAt(3);
            //myList.RemoveAt(3); //Both at point 3 as once the first instance is removed, point 4 becomes point 3

            //Step 6: Sort the list using inbuilt method
            myList.Sort();

            for (int i = 0; i < myList.Count(); ++i)
            {
                Console.WriteLine(myList[i]);
            }
        }

        public void StackExample()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(3);                        //3
            myStack.Push(1);                        //3, 1

            Console.WriteLine(myStack.Pop());       //3     Prints 1

            myStack.Push(2);                        //3, 2


            Console.WriteLine("Peek: {0}", myStack.Peek());

            Console.WriteLine("ElementAt: {0}", myStack.ElementAt<int>(0));

            while(myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());   //3     Prints 2
                                                    //      Prints 3
            }



            Console.WriteLine("\n\n");


            //Step 5: Modify to use Queue instead of Stack
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);

            Console.WriteLine(myQueue.Dequeue());

            myQueue.Enqueue(3);

            while(myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
        }

        public void DictionaryExample()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(0, "Cat");
            myDictionary.Add(1, "Dog");
            myDictionary[5] = "Bird";
            myDictionary[4] = "Crab";

            Console.WriteLine(myDictionary[5]);
            
            //Step 3: Access a key which is not yet added
            //Console.WriteLine(myDictionary[4]); //Unhandled Exception

            //Step 2: Check if a value or key is in the dictionary
            if(myDictionary.ContainsKey(4))
            {
                Console.WriteLine("Key 4 exists.");
            }
            else
            {
                Console.WriteLine("Key 4 doesn't exist.");
            }

            //Step 4: write a loop to iterate through dictionary - it is not sorted...
            foreach(KeyValuePair<int, string> pair in myDictionary)
            {
                Console.WriteLine("Key {0} has a value of {1}", pair.Key, pair.Value);
            }
        }
    }
}
