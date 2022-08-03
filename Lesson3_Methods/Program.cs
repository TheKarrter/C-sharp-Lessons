//Method 1 - dont give, dont get
void Method1()
{
    Console.WriteLine("Автор молодец");
}
//Method1();

//Method 2 - dont give, do get
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
//Method2(msg:"Текст сообщения", count: 5);
//Method2(count: 5, msg:"Текст сообщения");
//Method2("Текст сообщения", 5);

//Method 3 - do give, dont get
int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

//Method 4 - do give, do get
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "abc");
System.Console.WriteLine(res);