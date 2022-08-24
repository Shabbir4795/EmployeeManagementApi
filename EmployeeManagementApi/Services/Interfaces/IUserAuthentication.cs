using EmployeeManagementApi.Model.UserAuthentication;

namespace EmployeeManagementApi.Services.Interfaces
{
    public interface IUserAuthentication
    {
        public UserLoginResponse Login(UserLoginRequest loginRequest);
    }
}
