namespace Org.Example.Domain
{
  /// <summary>
  /// A pure substance consisting only of atoms (i.e., no molecules), all of
  /// which have the same number of protons in their nuclei.
  /// </summary>
  public sealed class ChemicalElement
  {
    /// <summary>
    /// Creates an element with given characteristics.
    /// </summary>
    public ChemicalElement(int atomicNumber,
                            String symbol,
                            Decimal atomicWeight,
                            String name,
                            params int[] isotopicMasses)
    {
      this.AtomicNumber = atomicNumber;
      this.AtomicWeight = atomicWeight;
      this.Name = name;
      this.Symbol = symbol;

      for (int i = 0; i < isotopicMasses.Length; ++i)
      {
        AddIsotope(isotopicMasses[i]);
      }
    }

    /// <summary>
    /// Gets the number of protons in the nucleus of the element's atom.
    /// No two elements have the same atomic number.
    /// </summary>
    public int AtomicNumber { get; init; }

    /// <summary>
    /// Gets the atomic mass of a single atom of the element expressed in
    /// atomic mass unit, where 1 atomic mass unit is equivalent to 1/12th
    /// the mass of a free electrically neutral carbon atom at absolute rest.
    /// No two elements have the same atomic weight.
    /// </summary>
    public Decimal AtomicWeight { get; init; }

    /// <summary>
    /// Gets known isotopes of the element.
    /// </summary>
    public List<Isotope>? Isotopes { get; private set; }

    /// <summary>
    /// Gets the name with which the element is commonly known. No two
    /// elements have the same name.
    /// </summary>
    public String Name { get; init; }

    /// <summary>
    /// Gets the symbol used to represent the element in chemical reactions.
    /// It has one or two letters with the first letter in uppercase and the
    /// second in lowercase when present. No two elements have the same symbol.
    /// </summary>
    public String Symbol { get; init; }

    /// <summary>
    /// Adds an isotope to this element.
    /// </summary>
    private void AddIsotope(int massNumber)
    {
      {
        if (Isotopes == null)
        {
          Isotopes = new List<Isotope>();
        }

        Isotopes.Add(new Isotope(massNumber,
                    String.Format("{0}-{1}", Name, massNumber)));
      }
    }
  }

  /// <summary>
  /// An atom of an element having different number of neutrons in the nucleus
  /// than another of the same element.
  /// </summary>
  /// <param name="MassNumber">The number of protons and neutrons in a nucleus
  /// of the element. No two isotopes of the same element have the same mass
  /// number.</param>
  /// <param name="Name">The name with which the isotope is commonly known.
  /// No two isotopes have the same name.</param>
  public sealed record Isotope(int MassNumber, String Name);
}
