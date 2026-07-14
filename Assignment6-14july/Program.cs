using System;


class Program
{   
    //Module 1 -- solution 
    static void Main()
    {
        string correctUsername = "admin";
        string correctPassword = "admin123";

        bool loginSuccess = false;

        try
        {
            for (int attempt = 1; attempt <= 3; attempt++)
            {
                Console.Write("Enter Username: ");
                string username = Console.ReadLine();

                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                if (username == correctUsername && password == correctPassword)
                {
                    Console.WriteLine("\nLogin Successful");
                    loginSuccess = true;
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid Login");

                    if (attempt < 3)
                    {
                        Console.WriteLine("Attempts Left : " + (3 - attempt));
                    }
                }
            }

            if (!loginSuccess)
            {
                throw new LoginFailedException("Login Failed! Account Locked.");
            }
        }
        catch (LoginFailedException ex)
        {
            Console.WriteLine("\nCustom Exception: " + ex.Message);
        }

         //module 2

    
    {
        int choice;

        do
        {
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine(" Stationery Store Management System");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("1. Add Stationery Item");
            Console.WriteLine("2. Display All Items");
            Console.WriteLine("3. Search Item");
            Console.WriteLine("4. Update Item");
            Console.WriteLine("5. Delete Item");
            Console.WriteLine("6. Purchase Item");
            Console.WriteLine("7. View Low Stock Items");
            Console.WriteLine("8. Sort Items");
            Console.WriteLine("9. Exit");

            Console.Write("\nEnter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Add Stationery Item");
                    break;

                case 2:
                    Console.WriteLine("Display All Items");
                    break;

                case 3:
                    Console.WriteLine("Search Item");
                    break;

                case 4:
                    Console.WriteLine("Update Item");
                    break;

                case 5:
                    Console.WriteLine("Delete Item");
                    break;

                case 6:
                    Console.WriteLine("Purchase Item");
                    break;

                case 7:
                    Console.WriteLine("View Low Stock Items");
                    break;

                case 8:
                    Console.WriteLine("Sort Items");
                    break;

                case 9:
                    Console.WriteLine("Thank You!");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        } while (choice != 9);
 
   }
      



    // Method to display details
    public void DisplayDetails()
    {
        Console.WriteLine("\n----- Item Details -----");
        Console.WriteLine("Item ID      : " + ItemId);
        Console.WriteLine("Item Name    : " + ItemName);
        Console.WriteLine("Category     : " + Category);
        Console.WriteLine("Price        : " + Price);
        Console.WriteLine("Quantity     : " + Quantity);
        Console.WriteLine("Brand        : " + Brand);
    }

    // Method to update quantity
    public void UpdateQuantity(int newQuantity)
    {
        Quantity = newQuantity;
        Console.WriteLine("Quantity Updated Successfully.");
    }
}

  StationeryItem item = new StationeryItem();

        item.ItemId = 101;
        item.ItemName = "Pen";
        item.Category = "Writing";
        item.Price = 20;
        item.Quantity = 50;
        item.Brand = "Reynolds";

        item.DisplayDetails();

        item.UpdateQuantity(80);

        item.DisplayDetails();
}







     

