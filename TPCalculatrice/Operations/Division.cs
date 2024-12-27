using System;

namespace TPCalculatrice.Operations;

public class Division:Operation
{
    public Division(int _operandeDroite, int _operandeGauche)
        : base(_operandeDroite,_operandeGauche)
    {

    }
    public override void Executer()
    {
        if (OperandeGauche != 0)
        {
            Resultat = OperandeDroite / OperandeGauche;
        }
        
    }
}
