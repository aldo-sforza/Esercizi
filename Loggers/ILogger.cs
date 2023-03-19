using System;
using System.IO;

namespace Esercizi.Astrazioni.Interfaccia
{
    /*
     * Un interfaccia definisce solo u contratto, i metodi.
     * Si usa un interfaccia quando abbiamo bisogno di un comportamento, i metodi,
     * ma non sappiamo, o non ci interessa, ancora come sarà implementato
     *
     * un interfaccia si definisce con la parola chiave interface
     * per convenzione il nome dell'interfaccia inizia sempre con la i maiuscola I
     */

    public interface ILogger
    {
        /*
         * sui metodi dell'interfaccia non si definisce la visibilità,
         * prendono quella definita dall'interfaccia stessa; in questo caso public
         *
         * i metodi dell'interfaccia definiscono sola la firma.
         * la firma deve finire con ;
         * il corpo non esiste
         */

        void WriteInformation(string message);

        void WriteWarning(string message);

        void WriteError(string message);
    }
}