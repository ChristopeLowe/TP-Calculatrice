using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TPCalculatrice.Operations;


namespace TPCalculatrice;

public class Calculatrice
{
    public Operation Operation { get; }

    public int Resultat => Operation.Resultat; //Raccouci

    public Calculatrice(Operation _operation)
    {
        Operation = _operation;
    }

    public void Executer()
    {
        Operation.Executer();
    }

    
   /* public void Executer()
    {
        if(Operation is Addition addition )
        {
            addition.Executer();
        }
        else if(Operation is Division division)
        {
            division.Executer();
        }
        else if (Operation is Modulo modulo)
        {
            modulo.Executer();
        }
        else if (Operation is Multiplication multiplication)
        {
            multiplication.Executer();
        }
        else if( Operation is Soustraction soustraction)
        {
            soustraction.Executer();
        }
        else
        {
            Console.WriteLine("votre Operation est invalide !");
        }
    
    }


   // public int OperandeGauche { get;}
   // public int OperandeDroite { get;}
    
    /// <summary>
    /// cette methode additionne deux nombre et renseigne la propriete Resultat
    /// </summary>
    /// <param name="nb1"> premier nombre</param>
    /// <param name="nb2">deuxieme nombre</param>
    /// <returns>le resultat des operations</returns>
    ///------ */
 /*<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<   
    // Constructeur
    public Calculatrice(int _operandeDroite, int _operandeGauche)
    {
        OperandeDroite = _operandeDroite;
        OperandeGauche = _operandeGauche;
    }

        public void Addition ()
    {
        Resultat = OperandeDroite + OperandeGauche;

    }

    public void Soustraction ()
    {
        Resultat = OperandeDroite - OperandeGauche;
    }

    public void Division ()
    {
        if (OperandeGauche == 0)
        {
            Resultat = 0;  // apres j'utiliserai try ...catch
        } 
         Resultat = OperandeDroite / OperandeGauche;
    }

    public void Modulo ()
    {
        Resultat = OperandeDroite % OperandeGauche;
    }

    public void Multiplication ()
    {
        Resultat = OperandeDroite * OperandeGauche;
    }
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>*/

   /* public int Addition (int nb1, int nb2)
    {
        return nb1 + nb2;

    }

    public int Soustraction (int nb1, int nb2)
    {
        return nb1 - nb2;
    }

    public int Division (int nb1, int nb2)
    {
        if (nb2 == 0)
        {
            return 0;  // apres j'utiliserai try ...catch
        } 
         return nb1 / nb2;
    }

    public int Modulo (int nb1, int nb2)
    {
        return nb1 % nb2;
    }

    public int Multiplication (int nb1, int nb2)
    {
        return nb1 * nb2;
    }*/
    
}
