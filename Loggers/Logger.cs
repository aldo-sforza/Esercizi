using System.Diagnostics;

namespace Esercizi.Astrazioni.ClasseAstratta
{
    /*
     * Una classe astratta è caratterizzata dalla parola abstract
     * non può essere istanziata
     * deve per forza essere estesa da un altra classe
     * Di solito, si definisce una classe astratta se c'è almeno un metodo astratto
     *
     */

    public abstract class Logger
    {
        /*
         * i metodi astratti definiscono solo la firma
         * la firma deve finire con ;
         * il corpo non esiste
         */

        public abstract void WriteInformation(string message);

        public abstract void WriteWarning(string message);

        public abstract void WriteError(string message);

        /*
         * una classe astratta può avere un metodo non astratto
         */

        public void WriteDebug(string message)
        {
            Debug.WriteLine(message);
        }
    }
}