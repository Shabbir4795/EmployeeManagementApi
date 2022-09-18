namespace EmployeeManagementApi.Model.UserAuthentication
{
    public class UserLoginResponse
    {
        public string? LoginPassword { get; set; }
        public string PasswordUpdateRequired { get; set; }
        public string AccountExists { get; set; }
    }
}
