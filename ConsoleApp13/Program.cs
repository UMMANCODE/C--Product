﻿using System;
using System.Reflection;

namespace ConsoleApp13 {
    internal class Program {
        static void Main(string[] args) {
            // Ansi colors
            const string RESET = "\033[0m";
            const string RED = "\033[0;31m";
            const string GREEN = "\033[0;32m";
            const string BLUE = "\033[0;34m";

            string[] products = new string[] { "Apple", "Banana", "Orange", "Kiwi", "Pineapple" };
            int option;
            do {
                ShowMenu();
                Console.Write("\nEnter the option: ");
                option = int.Parse(Console.ReadLine());
                switch (option) {
                    case 1:
                        Console.WriteLine();
                        ShowProducts(products);
                        break;
                    case 2:
                        Console.Write("\nEnter the index of the product: ");
                        int index = int.Parse(Console.ReadLine());
                        ShowSpecifiedProduct(products, index);
                        break;
                    case 3:
                        Console.Write("\nEnter the name of the product: ");
                        string product = Console.ReadLine();
                        AddNewProduct(ref products, product);
                        break;
                    case 4:
                        Console.Write("\nEnter the index of the product: ");
                        index = int.Parse(Console.ReadLine());
                        Console.Write("\nEnter the new name of the product: ");
                        product = Console.ReadLine();
                        ChangeProductName(products, index, product);
                        break;
                    case 5:
                        Console.Write("\nEnter the index of the product: ");
                        index = int.Parse(Console.ReadLine());
                        RemoveSpecifiedProduct(ref products, index);
                        break;
                    case 0:
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("Wrong option");
                        break;
                }
            } while (option != 0);
        }

        static void ShowMenu() {
            Console.WriteLine("\n\tMenu\t");
            Console.WriteLine("1. Show all the products");
            Console.WriteLine("2. Look for the specified indexed product");
            Console.WriteLine("3. Add a new product");
            Console.WriteLine("4. Change the name of the product");
            Console.WriteLine("5. Remove the specified indexed product");
            Console.WriteLine("0. Exit");
        }

        static void ShowProducts(string[] array) {
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }
        }

        static void ShowSpecifiedProduct(string[] array, int index) {
            Console.WriteLine(array[index]);
        }

        static void AddNewProduct(ref string[] array, string product) {
            string[] newArray = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++) {
                newArray[i] = array[i];
            }
            newArray[newArray.Length - 1] = product;
            array = newArray;
        }

        static void ChangeProductName(string[] array, int index, string product) {
            array[index] = product;
        }

        static void RemoveSpecifiedProduct(ref string[] array, int index) {
            string[] newArray = new string[array.Length - 1];
            int j = 0;
            for (int i = 0; i < array.Length; i++) {
                if (i == index) continue;
                newArray[j++] = array[i];
            }
            array = newArray;
        }
    }
}
