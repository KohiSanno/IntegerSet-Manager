using System.ComponentModel;
using System.Runtime.InteropServices;

namespace OOPAssignment1
{
    public class Set
    {
        #region Attribute
        private List<int> elements = new List<int>();
        private int element;
        private int index;
        private int num;
        #endregion

        #region Exceptions
        //public class ElementAlreadyExists : Exception { };

        public class ElementAlreadyExists : Exception { };
        public class ElementDoesNotExist : Exception { };
        public class SetNotEmpty : Exception { };
        public class SetEmpty : Exception { };
        #endregion

        //Insert Method
        #region Operations
        public void Insert(int element)
        {
            Console.WriteLine();

            bool check = false;

            for(int i = 0; i < elements.Count; i++)
            {
                if (elements[i] == element)
                {
                    check = true;
                    throw new ElementAlreadyExists();
                }
            }

            if(!check)
            {
                elements.Add(element);
                Console.WriteLine("Successfully inserted.");
                Console.WriteLine("Current set: {0}", string.Join(",", elements));
                Console.WriteLine("------------------------");
            }
            

            
        }


        //Remove method
        public void Remove(int element)
        {
            bool check = false;
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] == element)
                {
                    elements.Remove(element);
                    check = true;
                    Console.WriteLine("{0} removed.", element);
                    Console.WriteLine("------------------------");
                    break;
                }
            }

            if(!check)
            {
                if (elements.Count == 0)
                {
                    throw new SetEmpty();
                }
                else
                {
                    throw new ElementDoesNotExist();
                }
            }
        }

        //To check whether the set is empty or not
        public bool IsEmpty()
        {
            if (elements.Count == 0)
            {
                
                Console.WriteLine("The set is empty!");
                Console.WriteLine("------------------------");
                return true;
            }
            else
            { 
                Console.WriteLine("The set is NOT empty.\nCurrent set: {0}", string.Join(",", elements));
                Console.WriteLine("------------------------");
                return false;
            }
        }

        //To check whether the set contains an element or not
        
        public bool Contains(int element)
        {
            if(elements.Count == 0)
            {
                throw new SetEmpty();
            }

            for(int i = 0; i < elements.Count; i++)
            {
                if (elements[i] == element)
                {
                    return true;
                }
            }

            return false;
        }
        

        //To generate a random element from the set
        public int RandomElement()
        {
            if (elements.Count == 0)
            {
                throw new SetEmpty();
            }
            else if (elements.Count != 0)
            {
                
                Random num = new Random();
                int randomelement = num.Next(0, elements.Count);            
                return elements[randomelement];
                Console.WriteLine("------------------------");
            }
            return -1;
           
            
        }

        //To find the maximum element in the set
        public int Maximum()
        {

            if (elements.Count == 0)
            {
                throw new SetEmpty();
            }

            int maxElement = elements[0];
            for (int i = 1; i < elements.Count; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            Console.WriteLine("The largest element of the set is {0}", maxElement);
            Console.WriteLine("------------------------");

            return maxElement;
        

        }


    //To print out the current elements 
    public bool Print()
        {
          
                if (elements.Count != 0)
                {
                    Console.WriteLine($"Current Set: {{0}}", string.Join(",", elements));
                    Console.WriteLine("------------------------");
                    return true;
                }
                else if (elements.Count == 0)
                {
                    Console.WriteLine("Empty Set");
                    Console.WriteLine("------------------------");
                    return false;
                }
                else
                {
                     return false;
                }

            
           
        }
        #endregion


        #region Getters
        public List<int> GetList
        {
            get { return elements; }
            set { elements = value; }
        }

        public int GetElement
        {
            get { return element; }
            set { element = value; }
        }

        public int GetIndex
        {
            get { return index; }
            set { index = value; }
        }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        #endregion


    }
}

