using System;

namespace _054_Final5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[, ] inventory = new string[number, 2];
            for(int i = 0; i < number; i++)
            {
                string item = Console.ReadLine();
                inventory[i, 0] = item;
                string type = Console.ReadLine();
                inventory[i, 1] = type;
            }
            string mode = Console.ReadLine();
            while (mode == "ShowAll"|| mode == inventory[0,1] || mode == inventory[1, 1] || mode == inventory[2, 1] || mode == inventory[3, 1] || mode == inventory[4, 1] || mode == inventory[5, 1])
            {
                if (mode == "ShowAll")
                {
                    for (int z = 0; z < inventory.GetLength(0); z++)
                    {
                        for (int x = 0; x < inventory.GetLength(1); x++)
                        {
                            Console.WriteLine(inventory[z, x]);
                        }
                        Console.WriteLine();
                    }
                }
                else if (mode == inventory[0, 1] || mode == inventory[1, 1] || mode == inventory[2, 1] || mode == inventory[3, 1] || mode == inventory[4, 1] || mode == inventory[5, 1])
                {
                    for (int z = 0; z < inventory.GetLength(0); z++)
                    {
                        if (inventory[z, 1] == mode)
                        {
                            Console.WriteLine(inventory[z, 0]);
                            Console.WriteLine();
                        }                
                    }
                }
                mode = Console.ReadLine();
            }
            Console.WriteLine("End");
        }
    }
}
