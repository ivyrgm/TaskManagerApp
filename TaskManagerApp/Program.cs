using System.Transactions;
using TaskManagerApp;

class Program
{
    static List<Task> tasks = new List<Task>();
    static User currentUser;

    static void Main(string[] args)
    {
        ShowWelcomeScreen();
        Login();
        ShowMainMenu();
    }

    static void ShowWelcomeScreen()
    {
        Console.WriteLine("Welcome to My Task Manager Application!");
        Console.WriteLine("***************************************");
        Console.WriteLine();
    }

    static void Login()
    {
        Console.WriteLine("Enter your UserName and Password to log in.");
        Console.WriteLine("UserName: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        if (username == "admin"  && password == "password") 
        {
            currentUser = new User { UserName = username, Password = password};
            Console.WriteLine("Login Successful!!");
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("INVALID USERNAME OR PASSWORD. EXITING THE APPLICATION");
            Environment.Exit(0);
        }
    }

}
