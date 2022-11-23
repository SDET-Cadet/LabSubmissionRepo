using System.Collections;namespace AlgorithmDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array here called gradesArray

            float[] gradesArray = new float[5];

        
            // Call the addGrades method, passing it the gradesArray



            // After adding grades to the array, call the displayGrades method
            // to print out the grades to the console window
            // Use the foreach construct to iterate over the array

        

            // Create a new Stack object called myStack

            Stack myStack = new Stack();

            pushStack(gradesArray, myStack);
            popStack(myStack);
            popStack(myStack);

            // Call the pushStack() method passing in the grades array for values

            static void pushStack(float[] gradesArray, Stack stack)
            {
                foreach (float item in gradesArray)
                {
                    stack.Push(item);
                }
            }


            // Call the popStack() method twice to remove the top two items from stack
            // The popStack method will display each popped item to the console window

         
            static void popStack(Stack stack)
            {
                Console.WriteLine("Item removed from the stack: ");
                float item = (float)stack.Pop();
                Console.WriteLine(item);
            }


            // Create a new SortedList object called myCourses

            SortedList myCourses = new SortedList();
           static void populateList(SortedList list)
            {
                list.Add("CS101", "Introduction to Computer Science");
                list.Add("CS102", "Data Structures and Algorithm Analysis");
                list.Add("CS201", "Introduction to Databases");
                list.Add("CS301", "Introduction to Object-Oriented Programming");
            }


            // Call the populateList() method

            populateList(myCourses);


            // display a course in the list by passing a key


            displayList(myCourses, "CS101");



            // Remove an item from the myCourses list using the key

            removeListItem(myCourses, "CS201");
        }


        static void addGrades(float[] gradesArray)
        {
            addGrades(gradesArray);

            gradesArray[0] = 98;
            gradesArray[1] = 99;
            gradesArray[2] = 89;
            gradesArray[3] = 95;
            gradesArray[4] = 96;
        }

        static void displayGrades(float[] gradesArray)
        {
            displayGrades(gradesArray);

            foreach (double item in gradesArray)
            {
                Console.WriteLine(item);
            }
        }


        static void pushStack(float[] gradesArray)
        {

        }

        static void popStack(Stack stack)
        {
            Console.WriteLine("Item removed from the stack: ");

        }

        static void populateList(SortedList list)
        {

        }

        static void displayList(SortedList list, string key)
        {
            int index;
            string course;
            index = list.IndexOfKey(key);
            course = (string)list.GetByIndex(index);
            Console.WriteLine(course);
        }

        static void removeListItem(SortedList list, string key)
        {
            int index;
            string course;
            index = list.IndexOfKey(key);
            course = (string)list.GetByIndex(index);
            list.Remove(key);
            Console.WriteLine(course + " was removed from the list.");
        }
    }
}
