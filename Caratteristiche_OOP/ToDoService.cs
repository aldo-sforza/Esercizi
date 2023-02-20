using System.Collections.Generic;
using System.Linq;

namespace Esercizi.Caratteristiche_OOP
{
    /*
     * questa è la definizione di una classe
     * la sintassi è 
     *  visibilità class NomeClasse
     *  
     *  la naming convention per la classe è CamelCase
     */
    public class ToDoService
    {
        #region variabili
        /*
         * le variabili di classe sono visibili all'interno di tutta la classe
         * quindi sono utilizzabili all'interno di ogni metodo o proprietà
         */
        private readonly List<ToDoItem> _items = new();
        #endregion

        #region costruttori
        /*
         * questo è il costruttore di default, la sintassi è
         * visibilità NomeClasse()
         * 
         * se nel costruttore non si fanno inizializzazione di variabili di classe si può omettere
         * 
         */
        public ToDoService()
        {

        }

        #endregion

        /*questo è la definizione di un metodo, la sintassi è
         * visibilità valore_di_ritorno NomeDelMetodo()
         * 
         * un metodo con valore_di_ritorno void non ritorna nessun valore
         
         * in questo caso il metodo usa i parametri di ingresso 
         * e le variabili di classe
         * per modificare le variabili di classe
        */
        public void AddToDoItem(ToDoItem toDoItem)
        {
            _items.Add(toDoItem);
        }

        public void MarkAsDone(int toDoItemId)
        {
            var item = _items.SingleOrDefault(t => t.Id == toDoItemId);
            item.MarkAsDone();
        }

        /*
         * un metodo con valore_di_ritorno definito,  in questo caso int
         * deve usare la parola chiave return per ritornare il risultato atteso
         *
         * in questo caso il metodo usa i parametri di ingresso 
         * e le variabili di classe
         * per ritornare il risultato
         * 
         */
        public int GetNumbersOfToDoItem()
        {
            return _items.Count;
        }
    }
}