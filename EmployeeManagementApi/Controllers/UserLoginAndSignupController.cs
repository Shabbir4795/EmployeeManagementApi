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
        [HttpPost]        
        public UserLoginResponse Login(UserLoginRequest loginRequest)
        {
            return _userAuthentication.Login(loginRequest);
            //return "OK";
        }
    }
}
