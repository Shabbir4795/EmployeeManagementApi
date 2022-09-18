using EmployeeManagementApi.EntityFramework;
using EmployeeManagementApi.EntityFramework.Interfaces;
using EmployeeManagementApi.Model.ChangePassword;
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

        public UserLoginResponse Signin(string userName)
        {
            var loginResponse = new UserLoginResponse();
            var cred = employeeContext.UserCredentials.FirstOrDefault(x => x.UserId.Equals(userName));
            if (cred != null)
            {
                loginResponse.LoginPassword = cred.UserPassword;
                loginResponse.PasswordUpdateRequired = cred.PasswordUpdateDate < DateTime.Now ? "YES" : "NO";
                loginResponse.AccountExists = "YES";
            }
            return loginResponse;
        }

        public ChangePasswordResponse UpdatePassword(ChangePasswordRequest changePasswordRequest)
        {
            var changePasswordResponse = new ChangePasswordResponse();
            try
            {
                var cred = employeeContext.UserCredentials.FirstOrDefault(x => x.UserId.Equals(changePasswordRequest.UserId));
                if (cred != null)
                {
                    cred.UserPassword = changePasswordRequest.NewPassword;
                    cred.PasswordUpdateDate = DateTime.Now.AddDays(15);
                    var response = employeeContext.UserCredentials.Update(cred);
                    employeeContext.SaveChangesAsync();
                    changePasswordResponse.UpdateCode = "00";
                    changePasswordResponse.UpdateMessage = "SUCCESS";
                }
            }
            catch(Exception ex)
            {
                changePasswordResponse.UpdateCode = "01";
                changePasswordResponse.UpdateMessage = "FAILURE";
            }
            return changePasswordResponse;
        }
    }
}
