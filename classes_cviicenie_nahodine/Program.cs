using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("TEST 1. ÚČTU");
        Ucet ucetPeter = new Ucet();
        ucetPeter.zostatok = 500;


        ucetPeter.vlozpeniaze(200);
        Console.WriteLine("Zostatok po vklade: " + ucetPeter.zostatok + " EUR");

        ucetPeter.vlozpeniaze(-50);
        Console.WriteLine("Zostatok po neplatnom vklade: " + ucetPeter.zostatok + " EUR");

        ucetPeter.vyberpeniaze(150);
        Console.WriteLine("Zostatok po výbere: " + ucetPeter.zostatok + " EUR");

        ucetPeter.vyberpeniaze(1000);
        Console.WriteLine("Zostatok po zamietnutom výbere: " + ucetPeter.zostatok + " EUR");

        ucetPeter.vyberpeniaze(-30);
        Console.WriteLine("Zostatok po neplatnom výbere: " + ucetPeter.zostatok + " EUR");


        Console.WriteLine("TEST 2. ÚČTU");
        Ucet ucetJana = new Ucet();
        ucetJana.zostatok = 50;
        
        ucetJana.vlozpeniaze(100);
        Console.WriteLine("Zostatok po vklade: " + ucetJana.zostatok + " EUR");

        ucetJana.vyberpeniaze(150);
        Console.WriteLine("Zostatok po výbere do nuly: " + ucetJana.zostatok + " EUR");

        ucetJana.vyberpeniaze(10);
        Console.WriteLine("Zostatok po zamietnutom výbere: " + ucetJana.zostatok + " EUR");
    }
}

public class Ucet
{
    public string cislo;
    public string majitel;
    public decimal zostatok;

    public int vlozpeniaze(int suma_do_banky)
    {
        if (suma_do_banky >= 0)
        {
            zostatok = suma_do_banky + zostatok;
            int novy_zostatok = Convert.ToInt32(zostatok);
            return novy_zostatok;
        }
        else
        {
            Console.WriteLine("Nesprávna zadaná suma pre vklad.");
            return 0;
        }
    }

    public bool vyberpeniaze(int suma_na_vyber)
    {
        if (suma_na_vyber <= 0)
        {
            Console.WriteLine("Suma na výber musí byť väčšia ako 0.");
            return false;
        }
        else if (suma_na_vyber > zostatok)
        {
            Console.WriteLine("Nedostatok peňazí na účte.");
            return false;
        }
        else
        {
            zostatok = zostatok - suma_na_vyber;
            return true;
        }
    }
}