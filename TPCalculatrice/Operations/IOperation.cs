using System;

namespace TPCalculatrice.Operations;

public interface IOperation
{
    int Resultat { get; }
    void Executer();

}
