// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    static void pass (string password){
        if(password.Length < 6){
            throw new Exception("Password must be at least 6 characters long");
        }

        if(!password.Any(char.IsDigit)){
            throw new Exception("Password must contain at least one digit");
        }

        if(!password.Any(char.IsLetter)){
            throw new Exception("Password must contain at least one letter");
        }

    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your password: ");
        string password = Console.ReadLine();
        try{
            pass(password);
            Console.WriteLine("Password is valid");
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }


    }
}

