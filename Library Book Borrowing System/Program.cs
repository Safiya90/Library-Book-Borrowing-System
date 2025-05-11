namespace Library_Book_Borrowing_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] books = { "Arabic", "Islamic", "Math", "Since", "Biology" };
            bool[] isBorrowed = new bool[books.Length];

            while (true)
            {
                Console.WriteLine("Menu:\r\n1-View Books\r\n2-Borrow Book\r\n3-Return Book\r\n4-Check Availability\r\n5-Exit");
                Console.Write("Please choose from 1 to 5: ");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        for (int i = 0; i < books.Length; i++)
                        {
                            string status = isBorrowed[i] ? "Borrowed" : "Available";
                            Console.WriteLine($"{i + 1}. {books[i]} is :  {status}");
                        }
                        break;
                    case "2":
                        Console.Write("Enter book number to borrow: ");
                        int borrowbook = int.Parse(Console.ReadLine()) - 1;
                        if (borrowbook >= 0 && borrowbook < books.Length)
                        {
                            if (!isBorrowed[borrowbook])
                            {
                                isBorrowed[borrowbook] = true;
                                Console.WriteLine($"You borrowed '{books[borrowbook]}'.");
                            }
                            else
                            {
                                Console.WriteLine("This book is already borrowed.");
                            }
                        }
                        break;
                    case "3":
                        Console.Write("Enter book number to return: ");
                        int returnbook = int.Parse(Console.ReadLine()) - 1;
                        if (returnbook >= 0 && returnbook < books.Length)
                        {
                            if (isBorrowed[returnbook])
                            {
                                isBorrowed[returnbook] = false;
                                Console.WriteLine($"You returned '{books[returnbook]}'.");
                            }
                            else
                            {
                                Console.WriteLine("This book was not borrowed.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid book number.");
                        }
                        break;
                    case "4":
                        Console.Write("Enter book number to check availability: ");
                        int checkbook = int.Parse(Console.ReadLine()) - 1;
                        if (checkbook >= 0 && checkbook < books.Length)
                        {
                            string status = isBorrowed[checkbook] ? "Not available" : "Available";
                            Console.WriteLine($"'{books[checkbook]}' is {status}.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid book number.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Thank you!");
                        return;
                }
                }
            }
    }
}
