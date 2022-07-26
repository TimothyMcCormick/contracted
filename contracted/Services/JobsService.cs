using contracted.Repositories;

namespace contracted.Services
{
  public class JobsService
  {
    private readonly JobsRepository _repo;

    public JobsService(JobsRepository repo)
    {
      _repo = repo;
    }
  }
}