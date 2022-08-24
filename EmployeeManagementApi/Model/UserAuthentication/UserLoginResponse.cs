namespace EmployeeManagementApi.Model.UserAuthentication
{
    public class UserLoginResponse
    {
        public bool LoginSuccess { get; set; }
        public bool PasswordUpdateRequired { get; set; }
    }
}
