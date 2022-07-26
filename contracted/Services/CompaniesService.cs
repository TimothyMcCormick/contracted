using contracted.Repositories;

namespace contracted.Services
{
  public class CompaniesService
  {
    private readonly CompaniesRepository _repo;

    public CompaniesService(CompaniesRepository repo)
    {
      _repo = repo;
    }
  }
}