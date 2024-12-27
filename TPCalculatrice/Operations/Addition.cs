using System;

namespace TPCalculatrice.Operations;


// heritage de la classe enfant Addition du parent Operation 
// qui est un dossier dans le dossier du projet TPCalculatrice
public class Addition:Operation
{
    public Addition(int _operandeDroite,int _operandeGauche)
    //base sur heritage du constructeur du classe operation appel
        :base(_operandeDroite,_operandeGauche)
    {

    }
    public override void Executer()
    {
        Resultat = OperandeDroite + OperandeGauche;
    }

}
