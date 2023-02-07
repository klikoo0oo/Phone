using System;

class Phone
{
    public string Model;
    public long Number;
    public short Weight;

    public void recieveCall(string name)
    {
        Console.WriteLine($"Звонит {name}");
    }
    public void getNumber(long number)
    {
        Console.WriteLine($"Номер звонящего {number}");
    }
    public Phone(string model, long number, short weight)
    {
        Model = model;
        Number = number;
        Weight = weight;
    }
    public Phone(string model, long number)
    {
        Model = model;
        Number = number;
    }
    public Phone() { }

    public void recieveCall(string name, long number) { }

    public void sendMessage(int len, int number)
    {
        Console.WriteLine($"Сообщение отправлено с номера {number}");
    }

}

class Program
{
    static void Main()
    {
        Phone Iphone = new Phone();
        Phone BlackBerryy = new Phone();
        Phone Xiaomi = new Phone();

        Iphone.recieveCall("Вася");
        Iphone.getNumber(89999999999);
        Console.WriteLine();

        Xiaomi.recieveCall("Петя");
        Xiaomi.getNumber(8888888888);
        Console.WriteLine();

        BlackBerryy.recieveCall("Витя");
        BlackBerryy.getNumber(8777777777);
    }

}