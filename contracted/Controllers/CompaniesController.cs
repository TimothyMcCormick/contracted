using contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace contracted.Controllers
{
  public class CompaniesController : ControllerBase
  {
    private readonly CompaniesService _comserv;

    public CompaniesController(CompaniesService comserv)
    {
      _comserv = comserv;
    }
  }
}