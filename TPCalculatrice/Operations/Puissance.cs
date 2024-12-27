using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TPCalculatrice.Operations
{
    public class Puissance : Operation
    {
        public Puissance(int _operandeDroite, int _operandeGauche) 
            : base(_operandeDroite, _operandeGauche)
        {
        }

        public override void Executer()
        {
            Resultat = (int)Math.Pow(OperandeDroite, OperandeGauche);
        }
    }
}