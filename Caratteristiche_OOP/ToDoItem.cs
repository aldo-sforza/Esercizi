namespace Esercizi.Caratteristiche_OOP
{
    public class ToDoItem
    {
        #region variabili

        /*
       * le variabili dovrebbero essere sempre private
       * la naming convention delle variabili prevede il prefisso con l' underscore (_)
       * se la definizione di una variabile contiene la parola chiave readonly significa che il suo
       * valore può essere modificato solo all'interno del costruttore
       */
        private readonly int _id;

        #endregion variabili

        #region proprietà

        /*
         * le proprietà sono un costrutto del linguaggio che serve a proteggere l'accesso alle variabili
         * la sua sintassi può variare a seconda dei casi o dallo stile di scrittura del codice
         *
         * la naming convention per le proprietà è CamelCase
         *
         */

        //questa è un proprietà di sola lettura
        //la proprietà ritorna il valore della variabile _id tramite la funzione =>
        public int Id => _id;

        //questa è un proprietà di sola lettura che non si appoggia ad una variabile di classe
        //il suo valore viene impostato nel costruttore
        public string Description { get; }

        //questa è una proprietà di sola lettura
        //ma il suo valore può essere impostato dovunque all'interno della classe
        public bool IsDone { get; private set; }

        #endregion proprietà

        #region costruttori

        public ToDoItem(int id, string description)
        {
            _id = id;
            Description = description;
        }

        #endregion costruttori

        #region metodi

        public void MarkAsDone()
        {
            IsDone = true;
        }

        #endregion metodi
    }
}