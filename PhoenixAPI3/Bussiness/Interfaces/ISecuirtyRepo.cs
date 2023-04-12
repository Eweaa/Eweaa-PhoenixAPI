using PhoenixAPI3.Data.Models;

namespace PhoenixAPI3.Business.Interfaces;
public interface ISecuirtyRepo
{

    AppUser Login(string userName, string password);
}

