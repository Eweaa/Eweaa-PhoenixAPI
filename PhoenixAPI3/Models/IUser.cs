
namespace PhoenixAPI3.Models
{
    public interface IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public bool Gender { get; set; }
        public string Bio { get; set; }
        public bool Role { get; set; }

    }
}
