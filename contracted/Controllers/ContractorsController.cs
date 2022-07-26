using contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace contracted.Controllers
{
  public class ContractorsController : ControllerBase
  {
    private readonly ContractorsService _conserv;

    public ContractorsController(ContractorsService conserv)
    {
      _conserv = conserv;
    }
  }
}