//@BaseCode
namespace CompanyManager.Logic.Contracts
{
    public interface IContext : IDisposable
    {

        int SaveChanges();
    }
}