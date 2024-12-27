using System;

namespace TPCalculatrice.Operations;

public class Multiplication:Operation
{
    public Multiplication(int _operandeDroite,int _operandeGauche)
        : base(_operandeDroite,_operandeGauche)
    {

    }
    public override void Executer()
    {
        Resultat = OperandeDroite*OperandeGauche;
    }
}
