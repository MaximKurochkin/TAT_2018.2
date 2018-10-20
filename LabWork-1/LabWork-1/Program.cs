using System;



namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack st = new Stack(4);  //create stack with size 4

                //add elements into stack and print top element
                Console.WriteLine("Max size of stack " + st.GetMaxSize());
                st.Push(1);
                st.Push(2);
                st.Push(3);
                st.Push(4);
                Console.WriteLine("Head element is " + st.GetHead());

                //add one more element, stack is already full
                st.Push(5);
                Console.WriteLine("Head element now is " + st.GetHead());

                //increase the size of stack by hand
                st.ReSize(10);
                Console.WriteLine("Max size of steck now is " + st.GetMaxSize());

                //get and delete top element of the stack
                int head = st.Pop();
                Console.WriteLine("You deleted top element " + head);
                head = st.GetHead();
                Console.WriteLine("Head element now is " + head);
                Console.ReadKey();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }

}

