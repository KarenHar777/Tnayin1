using ClassHomework;

public  class Program
{
        static void Main(string[] args)
    {

        NewClass class1= new NewClass();
        class1.Print();

        NewClass class2 = new NewClass("Lana");
        class2.Print();

        NewClass class3 = new NewClass(27, "Inna");
        class3.Print();

        int x = class1.GetAge(38);

        Console.WriteLine(x);
    }

    


    

}
