interface IBank
{

    void Clock(Kapital_Bank kb);

}

class Kapital_Bank
{ 
    public IBank location { get; set; }

    public Kapital_Bank()
    {
        location = new OpenFilial();


    }

    public void LoginTime() => location.Clock(this);


}


class OpenFilial : IBank
{
    public void Clock(Kapital_Bank kb)
    {
        Console.WriteLine("Filialımız  acildi");
        kb.location = new ConnectedFilial();

    }
}

class ConnectedFilial : IBank
{
    public void Clock(Kapital_Bank kb)
    {
        Console.WriteLine("Filialimiz baglandi");
        kb.location = new OpenFilial();
    }
}



class Program
{
    
    static void Mian()
    {
        Kapital_Bank kb = new();

        kb.LoginTime();
        kb.LoginTime();
        kb.LoginTime();

    }



}

