namespace Shapes.Model
{
    /// <summary>
    /// Questa classe rappresenta la figura geometrica del quadrato
    /// Per poter aver già a disposizione il calcolo del perimetro e area
    /// questa classe estende la classe Rectangle in quanto il quadrato è un rettangolo particolare
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        /// Per poter definire un quadrato abbiamo bisogno solo della lunghezza del suo lato
        /// </summary>
        /// <param name="edge">lato del quadrato</param>
        /// <remarks>
        /// Dato che il quadrato deriva da una classe non astratta, il rettangolo, allora il costruttore
        /// del quadrato DEVE richiamare il costruttore del rettangolo che bisogna della lunghezza dei suoi lati
        /// ma dato che il quadrato è un rettangolo con il alti uguali no9i passiamo il parametro del costruttore
        /// del quadrato come valore per entrambi i lati del costruttore del rettangolo.
        ///
        /// Non dobbiamo ridefinire i metodi per il calcolo di perimetro e area
        /// perché sono i medesimi di quelli del rettangolo
        /// </remarks>
        public Square(string id,double edge)
            : base(id,edge, edge)
        {
        }

        /// <summary>
        /// Facciamo override del ToString quando vogliamo descrivere più chiaramente l'oggetto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"this is a square with edge {_width}";
        }
    }
}