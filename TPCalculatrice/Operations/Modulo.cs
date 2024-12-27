using System;

namespace TPCalculatrice.Operations;

public class Modulo:Operation
{
    public Modulo(int _operandeDroite,int _operandeGauche)
        : base(_operandeDroite,_operandeGauche)
    {

    }
    public override void Executer()
    {
        Resultat = OperandeDroite % OperandeGauche;
    }
}
