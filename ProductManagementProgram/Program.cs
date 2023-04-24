using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementProgram
{
    internal class Program
    {
        class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
        }

        class MngProgram
        {
            static List<Product> products = new List<Product>();

            static void Main(string[] args)
            {
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("Please select an option:");
                    Console.WriteLine("1. Add product records");
                    Console.WriteLine("2. Display product records");
                    Console.WriteLine("3. Delete product by Id");
                    Console.WriteLine("4. Exit");

                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            AddProduct();
                            break;
                        case 2:
                            DisplayProducts();
                            break;
                        case 3:
                            DeleteProduct();
                            break;
                        case 4:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
            }

            static void AddProduct()
            {
                Console.WriteLine("Please enter the product details:");

                Console.Write("Product ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product { Id = id, Name = name, Price = price };
                products.Add(product);

                Console.WriteLine("Product added successfully.");
            }

            static void DisplayProducts()
            {
                Console.WriteLine("Product List:");
                Console.WriteLine("ID\tName\tPrice");

                foreach (Product product in products)
                {
                    Console.WriteLine(product.Id + "\t" + product.Name + "\t" + product.Price);
                }
            }

            static void DeleteProduct()
            {
                Console.Write("Please enter the product ID to delete: ");
                int id = int.Parse(Console.ReadLine());

                Product product = products.Find(p => p.Id == id);

                if (product != null)
                {
                    products.Remove(product);
                    Console.WriteLine("Product " + product.Name + " with ID " + product.Id + " deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Product with ID " + id + " not found.");
                }
            }
        }
    }
}