namespace Adapters
{
    /// <summary>
    /// The 'Adaptee' class, Real-world example
    /// </summary>
    public class ChemicalDatabank
    {
        /// <summary>
        /// The databank 'legacy API' - takes in a chemicical compound and a chemical state
        /// </summary>
        /// <param name="compound"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        public float GetCriticalPoint(Chemical compound, State point)
        {
            // Melting Point
            if (point == State.Melting)
            {
                switch (compound)
                {
                    case Chemical.Water: return 0.0f;
                    case Chemical.Benzene: return 5.5f;
                    case Chemical.Ethanol: return -114.1f;
                    default: return 0f;
                }
            }
            // Boiling Point
            else
            {
                switch (compound)
                {
                    case Chemical.Water: return 100.0f;
                    case Chemical.Benzene: return 80.1f;
                    case Chemical.Ethanol: return 78.3f;
                    default: return 0f;
                }
            }
        }

        /// <summary>
        /// Gets the Molecular structure of a compound
        /// </summary>
        /// <param name="compound"></param>
        /// <returns></returns>
        public string GetMolecularStructure(Chemical compound)
        {
            switch (compound)
            {
                case Chemical.Water: return "H20";
                case Chemical.Benzene: return "C6H6";
                case Chemical.Ethanol: return "C2H5OH";
                default: return "";
            }
        }

        /// <summary>
        /// Gets the Molecular weight of a compound
        /// </summary>
        /// <param name="compound"></param>
        /// <returns></returns>
        public double GetMolecularWeight(Chemical compound)
        {
            switch (compound)
            {
                case Chemical.Water: return 18.015;
                case Chemical.Benzene: return 78.1134;
                case Chemical.Ethanol: return 46.0688;
            }
            return 0d;
        }
    }
}
