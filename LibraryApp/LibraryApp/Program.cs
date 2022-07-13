using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("LIBRARY APP");
                Dictionary<string, string> books = new Dictionary<string, string>();
                books.Add("1", "THE GODS MUST BE CRAZY");
                books.Add("2", "THE KING'S AFFECTION");
                books.Add("3", "BROKEN GLASS");
                books.Add("4", "BORN WITH A SLIVER SPOON");
                books.Add("5", "MOONSHINE");

                while (true)
                {
                    Console.WriteLine("WHAT WOULD YOU LIKE TO DO?... 1. BORROW A BOOK OR 2. RETURN A BOOK");
                    string borrow = Console.ReadLine();

                    //for BORROWING A BOOK
                    if (borrow.Equals("1", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("LIST OF BOOKS ARE:");
                        foreach (var book in books)
                        {
                            Console.WriteLine(book);
                        }

                        string BorrowBook = Console.ReadLine();

                        if (books.ContainsKey(BorrowBook))
                        {
                            Console.WriteLine($"YOU BORROWED THE BOOK NUMBERED {BorrowBook} ");
                            books.Remove(BorrowBook);
                        }
                        else
                        {
                            Console.WriteLine("REQUESTED BOOK IS NOT IN THE LIBRARY.");
                        }
                        foreach (var book in books)
                        {
                            Console.WriteLine(book);
                        }
                    }

                    //FOR RETURNING A BOOK

                    else if (borrow.Equals("2", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("HOW MANY DAYS HAVE YOU KEPT THE BOOK");
                        string ReturnBook = Console.ReadLine();
                        if (int.Parse(ReturnBook) <= 10)
                        {
                            Console.WriteLine("BOOK HAS SUCCESSFULLY BEEN RETURNED");
                        }
                        else if (int.Parse(ReturnBook) >= 11 || int.Parse(ReturnBook) <= 30)
                        {
                            int fine = int.Parse(ReturnBook) - 10;
                            Console.WriteLine($"PAY {fine * 50} FOR RETURNING THE BOOK LATE.");
                        }
                        else if (int.Parse(ReturnBook) > 31)
                        {
                            int fine = int.Parse(ReturnBook) - 10;
                            Console.WriteLine($"PAY {fine * 100} FOR RETURNING THE BOOK LATE.");
                        }
                    }

                    else
                    {
                        Console.WriteLine("PLEASE CHOOSE FROM THE ABOVE OPTION");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("KINDLY INPUT A VALID DATA");
            }
        }
    }
}
