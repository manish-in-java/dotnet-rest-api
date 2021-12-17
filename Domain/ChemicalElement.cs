namespace Org.Example.Domain
{
  ///
  /// A pure substance consisting only of atoms (i.e., no molecules), all of
  /// which have the same number of protons in their nuclei.
  ///
  public sealed class ChemicalElement
  {
    ///
    /// Creates an element with given characteristics.
    ///
    public ChemicalElement(int atomicNumber, String symbol, Decimal atomicWeight, String name)
    {
      this.AtomicNumber = atomicNumber;
      this.AtomicWeight = atomicWeight;
      this.Name = name;
      this.Symbol = symbol;
    }

    ///
    /// Gets the number of protons in the nucleus of the element's atom.
    /// No two elements have the same atomic number.
    ///
    public int AtomicNumber { get; private set; }

    ///
    /// Gets the atomic mass of a single atom of the element expressed in
    /// atomic mass unit, where 1 atomic mass unit is equivalent to 1/12th
    /// the mass of a free electrically neutral carbon atom at absolute rest.
    /// No two elements have the same atomic weight.
    ///
    public Decimal AtomicWeight { get; private set; }

    ///
    /// Gets known isotopes of the element.
    ///
    public List<Isotope>? Isotopes { get; private set; }

    ///
    /// Gets the name with which the element is commonly known. No two
    /// elements have the same name.
    ///
    public String Name { get; private set; }

    ///
    /// Gets the symbol used to represent the element in chemical reactions.
    /// It has one or two letters with the first letter in uppercase and the
    // second in lowercase when present. No two elements have the same symbol.
    ///
    public String Symbol { get; private set; }

    ///
    /// Adds an isotopes to this element.
    ///
    public void AddIsotope(Isotope isotope)
    {
      if (isotope != null)
      {
        if (Isotopes == null)
        {
          Isotopes = new List<Isotope>();
        }

        Isotopes.Add(isotope);
      }
    }
  }

  ///
  /// An atom of an element having different number of neutrons in the nucleus
  /// than another of the same element.
  ///
  public sealed class Isotope
  {
    ///
    /// Creates an isotope with given characteristics.
    ///
    public Isotope(int massNumber, String name)
    {
      this.MassNumber = massNumber;
      this.Name = name;
    }

    ///
    /// Gets the number of protons and neutrons in a nucleus of the element.
    /// No two isotopes of the same element have the same mass number.
    ///
    public int MassNumber { get; private set; }

    ///
    /// Gets the name with which the isotope is commonly known. No two
    /// isotopes have the same name.
    ///
    public String Name { get; private set; }
  }
}
