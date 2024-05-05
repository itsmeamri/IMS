using Microsoft.AspNetCore.Identity;

namespace IMS.web.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public int UserRoleId { get; set; }
        public int StoreId { get; set; }
        public string Address { get; set; }
        // public int PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public string ProfilePictureUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        

    
    }
}
