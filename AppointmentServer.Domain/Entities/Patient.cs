

namespace AppointmentServer.Domain.Entities
{
    //bizim durumumuzda bu Danışmanlık hizmeti almak isteyen müşteri
    public sealed class Patient
    {
        public Patient()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID{ get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty ;
        public string IdentityNumber { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Town { get; set; } = string.Empty;
        public string FullAddress { get; set; } = string.Empty;
    }
}
