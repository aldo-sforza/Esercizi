using System;

namespace Shapes.Model
{
    /// <summary>
    /// Questa classe rappresenta la figura geometrica del rettangolo.
    /// Per poter avere già a disposizione i metodi per calcolare perimetro e area
    /// questa classe estende la classe astratta Shape
    /// </summary>
    public class Rectangle : Shape
    {
        #region variabili

        /*
         * le variabili dovrebbero essere sempre private
         * la naming convention delle variabili prevede il prefisso con underscore (_)
         * se la definizione di una variabile contiene la parola chiave readonly significa che il suo
         * valore può essere modificato solo all'interno del costruttore
         *
         * Nota Bene: in questo caso la visibilità delle variabile è protected
         * per poter permettere alla classe estesa (leggi Square) di ridefinire
         * il ToString con l'informazione del suo lato
         * 
         * Ricorda: una variabile protetta è visibile solo all'interno della classe 
         * e nelle sue classi derivate
        */
        protected readonly double _width;
        protected readonly double _height;

        #endregion variabili

        #region costruttori

        /// <summary>
        /// Per poter definire un rettangolo abbiamo bisogno della lunghezza dei due lati
        /// </summary>
        /// <param name="width">base del rettangolo</param>
        /// <param name="height">altezza del rettangolo</param>
        /// <exception cref="ArgumentException"></exception>
        /// <remarks>
        /// Ogni qual volta un costruttore ha dei parametri di ingresso bisogna:
        ///     * validare tali parametri
        ///     * salvare i parametri in variabili di classe
        /// </remarks>
        public Rectangle(string id, double width, double height)
            : base(id)
        {
            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(width), "width cannot be 0 or less");
            }
            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(height), "height cannot be 0 or less");
            }

            _width = width;
            _height = height;
        }

        #endregion costruttori

        #region metodi

        // Essendo Rectangle" una classe non astratta che deriva
        // dalla classe astratta Shape, siamo costretti ad implementare i metodi astratti.
        // Se non lo facciamo il compilatore genera degli errori per notificare allo sviluppatore.
        // Per potere implementare i metodi astratti dobbiamo usare la parola chiave override
        // sulla firma del metodo che dobbiamo implementare

        /// <summary>
        /// Calcolo del perimetro del rettangolo
        /// </summary>
        /// <returns><perimetro/returns>
        public override double CalculatePerimeter()
        {
            return 2 * _height + 2 * _width;
        }

        /// <summary>
        /// Calcolo dell'area del rettangolo
        /// </summary>
        /// <returns>area</returns>
        public override double CalculateSurface()
        {
            return _width * _height;
        }

        /// <summary>
        /// Facciamo override del ToString quando vogliamo descrivere più chiaramente l'oggetto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"this is a rectangle with width {_width} and height {_height}";
        }

        #endregion metodi
    }
}