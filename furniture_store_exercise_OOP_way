using System;

namespace FurnitureStore_01
{
    class Furniture
    {
        public int Price { get; private set; }
        public int ItemNumber { get; private set; }

        public Furniture(int price, int itemNumber)
        {
            Price = price;
            ItemNumber = itemNumber;
        }
        public static bool beetween(Furniture[] furnitures)
        {
            bool answer = false;
            int i = 0;
            while (i < furnitures.Length && furnitures[i].Price >= 10000 && furnitures[i].Price <= 15000)
            {
                i++;
            }
            answer = i < furnitures.Length;
            return answer;
        }
        public static void Sorter(Furniture[] furnitures)
        {
            Furniture[] under_30000 = new Furniture[furnitures.Length];
            Furniture[] between_30000_50000 = new Furniture[furnitures.Length];
            Furniture[] over_50000 = new Furniture[furnitures.Length];
            int u = 0;
            int b = 0;
            int o = 0;

            for (int i = 0; i < furnitures.Length; i++)
            {
                if (furnitures[i].Price < 30000)
                {
                    under_30000[u] = new Furniture(furnitures[i].Price, furnitures[i].ItemNumber);
                    u++;
                }
                else if (furnitures[i].Price >= 30000 || furnitures[i].Price < 50000)
                {
                    between_30000_50000[b] = new Furniture(furnitures[i].Price, furnitures[i].ItemNumber);
                    b++;
                }
                else if (furnitures[i].Price >= 50000)
                {
                    over_50000[o] = new Furniture(furnitures[i].Price, furnitures[i].ItemNumber);
                    o++;
                }
                else
                {
                    continue;
                }
            }
        }
        public static void mostExpensive(Furniture[] furnitures)
        {
            Furniture max = furnitures[0];
            for (int i = 0; i < furnitures.Length; i++)
            {
                if (furnitures[i].Price > max.Price)
                {
                    max = furnitures[i];
                }
            }
            Console.WriteLine($"Most expensive furnitures item number: {max.ItemNumber}");
        }
    }
}
