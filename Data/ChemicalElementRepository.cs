using Org.Example.Domain;

namespace Org.Example.Data
{
  ///
  /// A collection of chemical elements.
  ///
  public sealed class ChemicalElementRepository
  {
    public static readonly ChemicalElementRepository Instance = new ChemicalElementRepository();

    private Dictionary<String, ChemicalElement> elements;

    ///
    /// Creates a repository of chemical elements.
    ///
    private ChemicalElementRepository()
    {
      elements = new Dictionary<String, ChemicalElement>();

      // Add Hydrogen.
      ChemicalElement hydrogen = new ChemicalElement(1,
                            "H",
                            new Decimal(1.00794),
                            "Hydrogen",
                            1, 2, 3);
      elements.Add(hydrogen.Symbol, hydrogen);

      // Add Helium.
      ChemicalElement helium = new ChemicalElement(2,
                            "He",
                            new Decimal(4.002602),
                            "Helium",
                            3, 4);
      elements.Add(helium.Symbol, helium);

      // Add Lithium.
      ChemicalElement lithium = new ChemicalElement(3,
                            "Li",
                            new Decimal(6.941),
                            "Lithium",
                            6, 7);
      elements.Add(lithium.Symbol, lithium);

      // Add Beryllium.
      ChemicalElement beryllium = new ChemicalElement(4,
                            "Be",
                            new Decimal(9.012182),
                            "Beryllium",
                            9);
      elements.Add(beryllium.Symbol, beryllium);

      // Add Boron.
      ChemicalElement boron = new ChemicalElement(5,
                            "B",
                            new Decimal(10.811),
                            "Boron",
                            10, 11);
      elements.Add(boron.Symbol, boron);

      // Add Carbon.
      ChemicalElement carbon = new ChemicalElement(6,
                            "C",
                            new Decimal(12.0107),
                            "Carbon",
                            12, 13, 14);
      elements.Add(carbon.Symbol, carbon);

      // Add Nitrogen.
      ChemicalElement nitrogen = new ChemicalElement(7,
                            "N",
                            new Decimal(14.0067),
                            "Nitrogen",
                            14, 15);
      elements.Add(nitrogen.Symbol, nitrogen);

      // Add Oxygen.
      ChemicalElement oxygen = new ChemicalElement(8,
                            "O",
                            new Decimal(15.9994),
                            "Oxygen",
                            16, 17, 18);
      elements.Add(oxygen.Symbol, oxygen);

      // Add Fluorine.
      ChemicalElement fluorine = new ChemicalElement(9,
                            "F",
                            new Decimal(18.9984032),
                            "Fluorine",
                            19);
      elements.Add(fluorine.Symbol, fluorine);

      // Add Neon.
      ChemicalElement neon = new ChemicalElement(10,
                            "Ne",
                            new Decimal(20.1797),
                            "Neon",
                            20, 21, 22);
      elements.Add(neon.Symbol, neon);
    }

    ///
    /// Finds a chemical element, given its chemical symbol.
    ///
    public ChemicalElement? FindBySymbol(String symbol)
    {
      return elements.ContainsKey(symbol) ? elements[symbol] : null;
    }
  }
}
