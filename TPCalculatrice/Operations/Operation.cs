using System;

namespace TPCalculatrice.Operations;

public abstract class Operation: IOperation
{
    protected int OperandeGauche { get;}
    protected int OperandeDroite { get;}

    public int Resultat { get; protected set; }

    protected Operation(int _operandeDroite, int _operandeGauche)
    {
        OperandeDroite = _operandeDroite;
        OperandeGauche = _operandeGauche;
    }

    public abstract void Executer();

}
