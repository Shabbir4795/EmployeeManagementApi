using EmployeeManagementApi.EntityFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementApi.EntityFramework.Interfaces
{
    public interface IEmployeeContext
    {
        DbSet<UserCredentials> UserCredentials { get; set; }
    }
}
