Console.WriteLine("Seu animal é mamífero?");
string animal = (Console.ReadLine().ToUpper());

if (animal == "SIM") {
    Console.WriteLine("Seu animal e quadrupede?");
    string pata = (Console.ReadLine().ToUpper());
    if (pata == "SIM") 
    {
        Console.WriteLine("Seu animal Carnivoro?");
        string aliment = (Console.ReadLine().ToUpper());
        if (aliment == "SIM")
        {
            Console.WriteLine("Seu animal è o Leão.");
        }
        else
        {
            Console.WriteLine("Seu animal é o cavalo");
        }
      


    }
    else  {
        Console.WriteLine("Seu animal é bipede?");
        string bipede = (Console.ReadLine().ToUpper());
        if (bipede == "SIM"){
            Console.WriteLine("Seu animal é onivoro?");
            string aliment2 = (Console.ReadLine().ToUpper());
            if (aliment2 == "SIM") {
                Console.WriteLine("Seu animal é o Humano");
            }
            else
            {
                Console.WriteLine("Seu animal é o Macaco");
            }
        }
        else
        {
            Console.WriteLine("Seu animal è voador?");
            string voador = (Console.ReadLine().ToUpper());
            if (voador == "SIM") {
                Console.WriteLine("Seu animal é o Morcego");
            }
            else
            {
                Console.WriteLine("Seu animal é a Baleia");
            }
        }

    }



}
else
{
    Console.WriteLine("Seu animal é nadador?");
    string ave = (Console.ReadLine().ToUpper());
    if (ave == "SIM") {
        Console.WriteLine("Seu animal è o Pato");
    }
    else
    {
        Console.WriteLine("Seu animal è de rapina?");
        string ave1 = (Console.ReadLine().ToUpper());
        if (ave1 == "SIM") {
            Console.WriteLine("Seu animal é a Águia");
        }
        else
        {
            Console.WriteLine("Seu animal é tropical?");
            string ave2 = (Console.ReadLine().ToUpper());
            if (ave2 == "SIM"){
                Console.WriteLine("Seu animal é o Aveztruz");
            }
            else
            {
                Console.WriteLine("Seu animal é o Pinguim");
            }

        }

    }

}