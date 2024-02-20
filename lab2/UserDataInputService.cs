using System;

public class UserDataInput
{
    public string? GetName()
    {
        Console.Write("Enter a name: ");
        return Console.ReadLine();
    }

    public string? GetSurname()
    {
        Console.Write("Enter a surname: ");
        return Console.ReadLine();
    }

    public string? GetPhone()
    {
        Console.Write("Enter a phone: ");
        return Console.ReadLine();
    }

    public string? GetEmail()
    {
        Console.Write("Enter an email: ");
        return Console.ReadLine();
    }

    public string? GetPost()
    {
        Console.Write("Enter a post: ");
        return Console.ReadLine();
    }

    public string? GetPassword()
    {
        Console.Write("Enter a password: ");
        return Console.ReadLine();
    }

    public string? GetDuplicatePassword()
    {
        Console.Write("Enter a duplicate password: ");
        return Console.ReadLine();
    }

    
}