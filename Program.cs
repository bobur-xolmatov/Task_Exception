


try
{
    Console.Write("Enter name : ");
    string str = Console.ReadLine();

    int result = LengthOfString(str);
    Console.WriteLine(result);

}

catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}

int LengthOfString(string str)
{
    if (str.Length > 0)
    {
        return str.Length;
    }
    else
    {
        throw new ArgumentException("Str is null");
    }
}



