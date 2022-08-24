using EmployeeManagementApi.EntityFramework;
using EmployeeManagementApi.EntityFramework.Interfaces;
using EmployeeManagementApi.Model.UserAuthentication;
using EmployeeManagementApi.Services.Interfaces;

namespace EmployeeManagementApi.Services
{
    public class UserAuthenticationService : IUserAuthentication
    {
        private readonly IEmployeeContext employeeContext;
        public UserAuthenticationService(IEmployeeContext emp)
        {
            employeeContext = emp;
        }
        public UserLoginResponse Login(UserLoginRequest loginRequest)
        {
            var loginResponse = new UserLoginResponse();
            var cred = employeeContext.UserCredentials.FirstOrDefault(x => x.UserId.Equals(loginRequest.UserId));
            if(cred != null)
            {
                loginResponse.LoginSuccess = true;
                loginResponse.PasswordUpdateRequired = cred.PasswordUpdateDate < DateTime.Now;
            }
            return loginResponse;
            //return "OK";
        }
    }
}
