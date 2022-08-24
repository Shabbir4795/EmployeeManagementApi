namespace EmployeeManagementApi.Model.UserAuthentication
{
    public class UserCredentials
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime PasswordCreatedDate { get; set; }
        public DateTime PasswordUpdateDate { get; set; }
    }
}
