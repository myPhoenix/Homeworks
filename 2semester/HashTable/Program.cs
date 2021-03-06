using System;

namespace HashTable
{
    class Program
    {
        /// <summary>
        /// Shows menu
        /// </summary>
        static void ShowMenu()
        {
            Console.WriteLine("1 - Insert key to the hash table");
            Console.WriteLine("2 - Delete element from hash table by its key");
            Console.WriteLine("3 - Find list element by key");
            Console.WriteLine("Other number - exit");
        }

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"> Main array of arguments </param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your hash table size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            HashTable hashTable = new HashTable(size);
            while (true)
            {
                ShowMenu();
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        string key = Console.ReadLine();
                        hashTable.Insert(key);
                        break;
                    case 2:
                        string key1 = Console.ReadLine();
                        hashTable.Delete(key1);
                        break;
                    case 3:
                        string key2 = Console.ReadLine();
                        if (hashTable.Search(key2))
                        {
                            Console.WriteLine("Such element exists in your hash table");
                        }
                        else
                        {
                            Console.WriteLine("Element doesn't exist");
                        }
                        break;
                    default:
                        return;
                }
            }
        }
    }
}

