using System;

namespace TPCalculatrice.Operations;

public class Soustraction:Operation
{
public Soustraction(int _operandeDroite, int _operandeGauche)
    :base(_operandeDroite, _operandeGauche)
    {
        
    }

    public override void Executer()
    {
        Resultat = OperandeDroite - OperandeGauche;
    }
}
