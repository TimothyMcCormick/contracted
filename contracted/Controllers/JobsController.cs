using contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace contracted.Controllers
{
  public class JobsController : ControllerBase
  {
    private readonly JobsService _js;

    public JobsController(JobsService js)
    {
      _js = js;
    }
  }
}