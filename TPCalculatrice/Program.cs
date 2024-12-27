// See https://aka.ms/new-console-template for more information
using TPCalculatrice;
using TPCalculatrice.Operations;

Console.WriteLine("Bienvenue sur ma Calculatrice Intelligent C#");

Console.WriteLine("");

//Calculatrice calc = new Calculatrice(); // instantation de la Classe Calculatrice

Console.Write("saisissez un premier nombre : ");

var nb1 = int.Parse(Console.ReadLine());
//int nb1 = int.Parse(Console.ReadLine());
//calc.OperandeDroite = int.Parse(Console.ReadLine());

Console.Write("saisissez un deuxieme nombre : ");

var nb2 = int.Parse(Console.ReadLine());

Console.Write("Sasissez Operateur de Calcul : ");
string Operateur = Console.ReadLine();

Operation _operation; // valeur operation et polymorphisme

//int resultat = 0;
//float resultat2 = 0;

if (Operateur == "+")
{
    _operation = new Addition(nb1,nb2);//polymorphisme
    //calc.Addition();
    //resultat = calc.Addition(nb1, nb2);
}
else if (Operateur == "-")
{
    _operation = new Soustraction(nb1,nb2);
    //calc.Soustraction();
}
else if(Operateur == "*")
{
    _operation = new Multiplication(nb1,nb2);

    //calc.Multiplication();
}
else if (Operateur == "/")
{
    _operation = new Division(nb1,nb2);
    //calc.Division();
}
else if (Operateur == "%")
{
    _operation = new Modulo(nb1,nb2);
    //calc.Modulo();
}
else
{
    Console.WriteLine("Votre Operateur de Calcul est invalide");
    return;
}
Calculatrice calc = new Calculatrice(_operation); // Constructeur et instancier
calc.Executer();
Console.WriteLine("");
Console.WriteLine($"le Resultat de votre Calcul est : {calc.Resultat}");//calc.Operation.Resultat
