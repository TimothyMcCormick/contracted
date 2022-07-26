using System.Data;

namespace contracted.Repositories
{
  public class CompaniesRepository
  {
    private readonly IDbConnection _db;

    public CompaniesRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}