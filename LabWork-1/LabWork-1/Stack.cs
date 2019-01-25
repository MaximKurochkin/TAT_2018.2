using System;


namespace LabWork
{
    /*
     * Class generates stack structure for keeping integer numbers
     * parameter {1} data - it is an array in which we keep our numbers
     * parameter {2} maxSize - size of stack
     * parameter {3} actualSize - count of numbers in stack
     */
    class Stack
    {
        private int[] data;
        private int maxSize = 0;
        private int actualSize = 0;

        //Constructor
        //parameter _maxSize - size of stack
        //create an array "data" with size _maxSize
        public Stack(int _maxSize)
        {
            if (_maxSize <= 0) throw new InvalidOperationException("Pease, check the data!");
            else
            {
                data = new int[_maxSize];
                maxSize = _maxSize;
            }
        }

        public int GetMaxSize()
        {
            return maxSize;
        }


        //increas stack size
        //create a new array with a size one larger than the previous one
        //and copy numbers of the old array to new
        public void ReSize()
        {
            maxSize = maxSize + 1;
            int[] newData = new int[maxSize];
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }
            data = new int[maxSize];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = newData[i];
            }
        }

        //increase stack size to a certain size
        //and copy numbers of the old array to new
        //parameter newSize - new size of our stack
        public void ReSize(int newSize)
        {
            maxSize = newSize;
            int[] newData = new int[maxSize];
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }
            data = new int[maxSize];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = newData[i];
            }
        }

        //delete top element in stack
        //return this top element to user
        public int Pop()
        {
            if (actualSize == 0)
            {
                throw new InvalidOperationException("Error! There is nothing to pop");
            }
            else
            {
                int topElem = data[actualSize - 1];
                actualSize--;
                return topElem;
            }
        }

        //to add new element into stack
        //parameter elem - the number we add into stack
        public void Push(int elem)
        {
            //if stack is full increase stack size by one
            if (actualSize == maxSize)
            {
                ReSize();
                data[actualSize] = elem;
            }
            else data[actualSize] = elem;
            actualSize++;
        }

        //return top element to user without deleting
        public int GetHead()
        {
            if (actualSize == 0)
                throw new InvalidOperationException("Error!Steck is empty");
            else return data[actualSize - 1];
        }
    }
}

