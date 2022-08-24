using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementApi.EntityFramework.Model
{
    public class UserCredentials
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserPassword { get; set; }
        
        public DateTime PasswordCreatedDate { get; set; }
        
        public DateTime PasswordUpdateDate { get; set; }
    }
}
