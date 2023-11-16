using ConsoleApp1;
using tupletask;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("---Find or Even----");
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        Firstcall(num);
        Operations.operationadd();
        Operations.commasepration();
        ConvertIntToText.Converttostring();
        //interface object creation for non static methos
        //interfacename obj = new classname(inherited class)
        Ituple obj = new Tuplees();
        obj.Numbers();
        obj.personsdictionary(); 
    }



    public static void Firstcall(int num)
    {

        OddOrEven.Findoddeven(num);
        Console.WriteLine("Do you want to continue?");
        string check = Console.ReadLine();
        ConfirmFromUser.confirm(check);



    }






}
