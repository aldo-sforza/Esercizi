using System;

namespace Shapes.Model
{
    /// <summary>
    /// Questa classe rappresenta la figura geometrica del cerchio.
    /// Per poter avere già a disposizione i metodi per calcolare perimetro e area
    /// questa classe estende la classe astratta Shape
    /// </summary>
    public class Circle : Shape
    {
        #region variabili
        //le variabili dovrebbero essere sempre private
        //la naming convention delle variabili prevede il prefisso con l' underscore (_)
        //se la definizione di una variabile contiene la parola chiave readonly significa che il suo
        //valore può essere modificato solo all'interno del costruttore
        private readonly double _radius;


        #endregion variabili

        #region costruttori

        /// <summary>
        /// Per poter definire un cerchio abbiamo bisogno solo del raggio
        /// </summary>
        /// <param name="radius">raggio del cerchio</param>
        /// <remarks>
        /// Ogni qual volta un costruttore ha dei parametri di ingresso bisogna:
        ///     * validare tali parametri
        ///     * salvare i parametri in variabili di classe
        /// </remarks>
        public Circle(string id, double radius)
            : base(id)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "radius cannot be 0 or less");
            _radius = radius;
        }

        #endregion costruttori

        #region metodi

        // Essendo Circle una classe non astratta che deriva
        // dalla classe astratta Shape, siamo costretti ad implementare i metodi astratti.
        // Se non lo facciamo il compilatore genera degli errori per notificare allo sviluppatore.
        // Per potere implementare i metodi astratti dobbiamo usare la parola chiave override
        // sulla firma del metodo che dobbiamo implementare

        /// <summary>
        /// Calcolo della circonferenza del cerchio
        /// </summary>
        /// <returns><circonferenza/returns>
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * _radius;
        }

        /// <summary>
        /// Calcolo dell'area del cerchio
        /// </summary>
        /// <returns>area</returns>
        public override double CalculateSurface()
        {
            return Math.PI * _radius * _radius;
        }

        /// <summary>
        /// Facciamo override del ToString quando vogliamo descrivere più chiaramente l'oggetto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"this is a circle with radius {_radius}";
        }
        #endregion metodi
    }
}