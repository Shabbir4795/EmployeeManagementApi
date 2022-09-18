using EmployeeManagementApi.Model.ChangePassword;
using EmployeeManagementApi.Model.UserAuthentication;

namespace EmployeeManagementApi.Services.Interfaces
{
    public interface IUserAuthentication
    {
        public UserLoginResponse Signin(string userName);
        public ChangePasswordResponse UpdatePassword (ChangePasswordRequest changePasswordRequest);
    }
}
