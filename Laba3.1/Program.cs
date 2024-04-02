using Laba3._1.NewFolder1;
using System;
using System.Collections.Generic;

//For admin
//write 6 - for sorted phones by manufacturer
//write 7 - for sorted phones by display size
//write 8 - for sorted phones by models

namespace Laba3._1
{
    class Program
    {
        static void Main(string[] args)
        {   
            bool active = true;

            Storage storage = new Storage();

            storage.AddPhone(new Smartphone { Model = "Galaxy A34", Manufacturer = "Samsung", DisplaySize = 6.6, Price = 305 });
            storage.AddPhone(new Smartphone { Model = "G54 Power", Manufacturer = "Motorola", DisplaySize = 6.5, Price = 228 });
            storage.AddPhone(new Smartphone { Model = "G54 Power", Manufacturer = "Motorola", DisplaySize = 6.5, Price = 228 });
            storage.AddPhone(new Smartphone { Model = "iPhone 12", Manufacturer = "Apple", DisplaySize = 6.1, Price = 999 });
            storage.AddPhone(new Smartphone { Model = "iPhone 12", Manufacturer = "Apple", DisplaySize = 6.1, Price = 999 });
            storage.AddPhone(new Smartphone { Model = "iPhone 12", Manufacturer = "Apple", DisplaySize = 6.1, Price = 999 });
            storage.AddPhone(new Smartphone { Model = "iPhone 12", Manufacturer = "Apple", DisplaySize = 6.1, Price = 999 });
            storage.AddPhone(new Smartphone { Model = "iPhone 12", Manufacturer = "Apple", DisplaySize = 6.1, Price = 999 });
            storage.AddPhone(new Smartphone { Model = "iPhone 12", Manufacturer = "Apple", DisplaySize = 6.1, Price = 999 });
            storage.AddPhone(new Smartphone { Model = "Galaxy A34", Manufacturer = "Samsung", DisplaySize = 6.6, Price = 305 });
            storage.AddPhone(new Smartphone { Model = "Galaxy A34", Manufacturer = "Samsung", DisplaySize = 6.6, Price = 305 });
            storage.AddPhone(new Smartphone { Model = "Galaxy A34", Manufacturer = "Samsung", DisplaySize = 6.6, Price = 305 });
            storage.AddPhone(new Smartphone { Model = "G54 Power", Manufacturer = "Motorola", DisplaySize = 6.5, Price = 228 });
            storage.AddPhone(new Smartphone { Model = "G54 Power", Manufacturer = "Motorola", DisplaySize = 6.5, Price = 228 });
            storage.AddPhone(new Smartphone { Model = "G54 Power", Manufacturer = "Motorola", DisplaySize = 6.5, Price = 228 });
            storage.AddPhone(new Smartphone { Model = "G54 Power", Manufacturer = "Motorola", DisplaySize = 6.5, Price = 228 });
            storage.AddPhone(new Smartphone { Model = "G54 Power", Manufacturer = "Motorola", DisplaySize = 6.5, Price = 228 });
            storage.AddPhone(new Smartphone { Model = "G54 Power", Manufacturer = "Motorola", DisplaySize = 6.5, Price = 228 });
            storage.AddPhone(new Smartphone { Model = "Nubia NEO", Manufacturer = "ZTE", DisplaySize = 6.5, Price = 128 });
            storage.AddPhone(new Smartphone { Model = "Nubia NEO", Manufacturer = "ZTE", DisplaySize = 6.5, Price = 128 });
            storage.AddPhone(new Smartphone { Model = "Nubia NEO", Manufacturer = "ZTE", DisplaySize = 6.5, Price = 128 });
            storage.AddPhone(new Smartphone { Model = "Nubia NEO", Manufacturer = "ZTE", DisplaySize = 6.5, Price = 128 });
            storage.AddPhone(new Smartphone { Model = "iPhone 12", Manufacturer = "Apple", DisplaySize = 6.1, Price = 999 });

            while (active)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("===========================================");
                Console.WriteLine(" Select a search option");
                Console.WriteLine("1 - Search phone by Model");
                Console.WriteLine("2 - Search phone by Manufacturer");
                Console.WriteLine("3 - Search phone by DisplaySize");
                Console.WriteLine("4 - Search phone by Price");
                Console.WriteLine("5 - Exit");
                Console.WriteLine("===========================================");
                Console.ResetColor();
                int inputValue = int.Parse(Console.ReadLine());
                
                if (inputValue == 1)
                {
                    Console.WriteLine("Write a phone Model");

                    string modelToFind = Console.ReadLine(); 
                    Smartphone foundPhone = storage.FindPhoneByModel(modelToFind);

                    if (foundPhone != null)
                    {
                        Console.WriteLine($"Found phone: {foundPhone.Manufacturer} {foundPhone.Model} - {foundPhone.DisplaySize} - {foundPhone.Price}$");
                    }
                    else
                    {
                        Console.WriteLine($"Phone with model '{modelToFind}' not found.");
                    }

                    Console.WriteLine("Press any key to go back");
                    Console.ReadKey();

                    Console.Clear();
                }
                else if (inputValue == 2)
                {
                    Console.WriteLine("Write a phone Manufacturer");

                    string manufToFind = Console.ReadLine();
                    Smartphone foundPhone = storage.FindPhoneByManufacturer(manufToFind);

                    if (foundPhone != null)
                    {
                        Console.WriteLine($"Found phone: {foundPhone.Manufacturer} - {foundPhone.Model} - {foundPhone.DisplaySize} - {foundPhone.Price}$");
                    }
                    else
                    {
                        Console.WriteLine($"Phone with model '{manufToFind}' not found.");
                    }

                    Console.WriteLine("Press any key to go back");
                    Console.ReadKey();

                    Console.Clear();
                }
                else if (inputValue == 3)
                {
                    Console.WriteLine("Enter display size:");
                    double displaySize = double.Parse(Console.ReadLine());

                    List<Smartphone> phonesByDisplaySize = storage.FindPhonesByDisplaySize(displaySize);

                    Console.WriteLine($"Phones with display size {displaySize}:");
                    foreach (var phone in phonesByDisplaySize)
                    {
                        Console.WriteLine($"{phone.Manufacturer} {phone.Model} - {phone.DisplaySize} - {phone.Price}$");
                    }

                    Console.WriteLine("Press any key to go back");
                    Console.ReadKey();

                    Console.Clear();
                }
                else if (inputValue == 4)
                {
                    Console.WriteLine("Enter the price range (first the minimum, then the maximum)");
                    int minPrice = int.Parse(Console.ReadLine());
                    int maxPrice = int.Parse(Console.ReadLine());
                    List<Smartphone> phonesInRange = storage.FindPhonesByPriceRange(minPrice, maxPrice);
                    Console.WriteLine($"Phones within price range ${minPrice} - ${maxPrice}:");
                    foreach (var phone in phonesInRange)
                    {
                        Console.WriteLine($"{phone.Manufacturer} {phone.Model} - {phone.DisplaySize} - {phone.Price}$");
                    }

                    Console.WriteLine("Press any key to go back");
                    Console.ReadKey();

                    Console.Clear();
                }
                else if (inputValue == 5)
                {
                    Console.Clear();
                    active = false;
                }
                else if (inputValue == 6)
                {
                    storage.SortPhonesByManufacturer();
                    Console.WriteLine("Sorted phones by manufacturer:");

                    for (int i = 0; i < storage.CountTotalPhones(); i++)
                    {
                        var phone = storage[i];
                        Console.WriteLine($"{phone.Manufacturer} {phone.Model} - {phone.DisplaySize} - {phone.Price}$");
                    }
                    Console.WriteLine($"Total phones in warehouse: {storage.CountTotalPhones()}");
                    Console.WriteLine("Press any key to go back");
                    Console.ReadKey();

                    Console.Clear();
                }
                else if (inputValue == 7)
                {
                    storage.SortPhonesByDisplaySize();
                    Console.WriteLine("Sorted phones by display size:");
                    for (int i = 0; i < storage.CountTotalPhones(); i++)
                    {
                        var phone = storage[i];
                        Console.WriteLine($"{phone.Manufacturer} {phone.Model} - {phone.DisplaySize} - {phone.Price}$");
                    }
                    Console.WriteLine($"Total phones in warehouse: {storage.CountTotalPhones()}");
                    Console.WriteLine("Press any key to go back");
                    Console.ReadKey();

                    Console.Clear();
                }
                if (inputValue == 8)
                {
                    storage.SortPhonesByModel();
                    Console.WriteLine("Sorted phones by models:");
                    for (int i = 0; i < storage.CountTotalPhones(); i++)
                    {
                        var phone = storage[i];
                        Console.WriteLine($"{phone.Manufacturer} {phone.Model} - {phone.DisplaySize} - {phone.Price}$");
                    }
                   
                    Console.WriteLine($"Total phones in warehouse: {storage.CountTotalPhones()}");
                    Console.WriteLine("Press any key to go back");
                    Console.ReadKey();

                    Console.Clear();
                }

            }
           
        }
    }
}
