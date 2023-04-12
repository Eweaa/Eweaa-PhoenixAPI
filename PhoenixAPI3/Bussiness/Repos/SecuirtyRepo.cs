using PhoenixAPI3.Business.Interfaces;
using PhoenixAPI3.Data;
using PhoenixAPI3.Data.Models;

namespace PhoenixAPI3.Business.Repos;
public class SecuirtyRepo : ISecuirtyRepo
{
    private readonly DataContext _context;
    public SecuirtyRepo(DataContext context)
    {
        _context = context;
    }
    public AppUser? Login(string userName, string password)
    {
        return _context.AppUsers.FirstOrDefault(x => (x.Name == userName || x.Email == userName) && x.Password == password);
    }
}
