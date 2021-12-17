using Microsoft.AspNetCore.Mvc;

using Org.Example.Data;
using Org.Example.Domain;

namespace Org.Example.Controller
{
  ///
  /// Provides and API for querying information about a chemical element and
  /// its known natural isotopes.
  ///
  [ApiController]
  [Route("/api/isotopes")]
  public sealed class IsotopeAPI : ControllerBase
  {
    ///
    /// Finds information about a chemical symbol having a given symbol.
    ///
    [HttpGet("{symbol}")]
    public ChemicalElement? GetElement(String symbol)
    {
      return ChemicalElementRepository.Instance.FindBySymbol(symbol);
    }
  }
}
