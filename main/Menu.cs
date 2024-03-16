using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static OOPAssignment1.Set;

namespace OOPAssignment1
{
    internal class Menu
    {
        Set sequence = new Set();
        public void start()
        {

            bool boolean = true;
            while (boolean)
            {
                MenuPrint();
                string operations = (Console.ReadLine());
                switch (operations)
                {
                    case "1":
                        try
                        {
                            Console.Write("\nEnter the element you wish to insert:  ");
                            int element = Convert.ToInt32(Console.ReadLine());
                            sequence.Insert(element);
                        }
                        catch (ElementAlreadyExists)
                        {
                            Console.WriteLine("\nThe element already exists in the set");
                            Console.WriteLine("------------------------");
                        }
                        break;

                    case "2":
                        try
                        {
                            Console.Write("\nEnter an element you want to remove: ");
                            int element = Convert.ToInt32(Console.ReadLine());
                            sequence.Remove(element);
                        }
                        catch (SetEmpty)
                        {
                            Console.WriteLine("\nThe set is empty and does not contain any elements. ");
                            Console.WriteLine("------------------------");
                        }
                        catch (ElementDoesNotExist)
                        {
                            Console.WriteLine("\nThe element you entered does not exist in the set.");
                            Console.WriteLine("------------------------");
                        }
                        break;

                    case "3":
                        sequence.IsEmpty(); 
                        break;

                    case "4":
                        try
                        {
                            Console.Write("\nEnter the element you want to check is part of the set: ");
                            int element = Convert.ToInt32(Console.ReadLine());
                            bool Contains = sequence.Contains(element);

                            if (Contains)
                            {
                                Console.WriteLine("\nYes, the element {0} is a part of the set.", element);
                                Console.WriteLine("------------------------");
                            }
                            else
                            {
                                Console.WriteLine("\nNo, the element {0} is not part of the set.", element);
                                Console.WriteLine("------------------------");

                            }
                        }
                        catch (SetEmpty)
                        {
                            Console.WriteLine("\nThe set is empty. ");
                            Console.WriteLine("------------------------");
                        }

                        break;

                    case "5":
                        try
                        {
                            Console.Write("Random element is: ");
                            Console.WriteLine(sequence.RandomElement());
                            Console.WriteLine();
                            Console.WriteLine("------------------------");
                        }
                        catch 
                        {
                            Console.WriteLine("\nYour list is empty.");
                            Console.WriteLine("------------------------");
                        }
                        break;

                    case "6":
                        try
                        {
                            sequence.Maximum();
                        }
                        catch(SetEmpty)
                        {
                            Console.WriteLine("\nThe set is empty.");
                            Console.WriteLine("------------------------");
                        }
                        break;

                    case "7":
                        sequence.Print();
                        break;

                    case "8":
                        boolean = false;
                        break;

                    default:
                        Console.WriteLine("\nInvalid input. Please select a number between 1-7. ");
                        Console.WriteLine("------------------------");
                        break;
                }
            }

        }
        static private void MenuPrint()
        {
            Console.WriteLine("Please select one of the numbers from the menu below to perform these operations on the set:");
            Console.WriteLine("1. Insert an element to the set");
            Console.WriteLine("2. Remove an element of the set");
            Console.WriteLine("3. Check whether the set is empty or not");
            Console.WriteLine("4. Check if the set contains an element");
            Console.WriteLine("5. Return a random element of the set"); 
            Console.WriteLine("6. Return the largest element of the set");
            Console.WriteLine("7. Print the current set");
            Console.WriteLine("8. Exit");
            Console.WriteLine();
            //Console.WriteLine("------------------------");
            Console.Write("Enter a number from 1-8: ");
        }
    }
}

