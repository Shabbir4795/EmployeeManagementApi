using EmployeeManagementApi.Model.ChangePassword;
using EmployeeManagementApi.Model.UserAuthentication;
using EmployeeManagementApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginAndSignupController : ControllerBase
    {
        private readonly IUserAuthentication _userAuthentication;
        public UserLoginAndSignupController(IUserAuthentication userAuth)
        {
            _userAuthentication = userAuth;
        }

        [HttpGet]
        public UserLoginResponse GetString(string userName)
        {
            return _userAuthentication.Signin(userName);
        }

        [HttpPut]
        public ChangePasswordResponse ChangeUserPassword([FromBody] ChangePasswordRequest changePasswordRequest)
        {
            return _userAuthentication.UpdatePassword(changePasswordRequest);
        }
    }
}
