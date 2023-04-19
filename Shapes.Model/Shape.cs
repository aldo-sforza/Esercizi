using Patterns.Repository;
namespace Shapes.Model
{
    /// <summary>
    /// Questa classe rappresenta il concetto di figura geometrica.
    /// Come sua responsabilità c'è la possibilità di:
    ///     * calcolare il perimetro
    ///     * calcolare l'area
    /// Non avendo le informazioni per poter effettuare i suddetti calcoli questa classe non può implementare tali metodi.
    /// In un linguaggio orientato agli oggetti questa classe è un ottima candidata per essere definita astratta.
    ///
    /// Una classe astratta è riconoscibile dalla parola chiave abstract applicata alla classe.
    /// Una classe si definisce astratta se almeno uno dei suoi metodi è definito abstract.
    /// Una classe astratta può avere anche metodi non astratti.
    /// Una classe astratta non può essere istanziata, quindi NON possiamo eseguire un istruzione come quella che segue:
    ///             var shape =new Shape();
    ///
    ///
    /// </summary>
    public abstract class Shape
    {
        public string Id { get; }
        public Shape()
        {
            Id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Calcola il perimetro della figura geometrica
        /// </summary>
        /// <returns>il perimetro della figura</returns>
        /// <remarks>
        /// Un metodo astratto è caratterizzato dalla parola abstract nella firma del metodo
        /// Un metodo astratto non ha un corpo, la firma si conclude con il ;
        /// </remarks>
        public abstract double CalculatePerimeter();

        /// <summary>
        /// Calcola l'area della figura geometrica
        /// </summary>
        /// <returns>l'area della figura</returns>
        /// <remarks>
        /// Un metodo astratto è caratterizzato dalla parola abstract nella firma del metodo
        /// Un metodo astratto non ha un corpo, la firma si conclude con il ;
        /// </remarks>
        public abstract double CalculateSurface();

        /// <summary>
        /// Facciamo override del ToString quando vogliamo descrivere più chiaramente l'oggetto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "unknown shape";
        }
    }
}