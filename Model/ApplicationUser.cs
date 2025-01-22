using Microsoft.AspNetCore.Identity;
using TalIdentity.Models;

namespace TalIdentity.Models
{
    public class ApplicationUser : IdentityUser, IBaseEntity
    {
        public string FullName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
