using EmployeeManagementApi.Master;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementApi.EntityFramework.Interfaces
{
    public interface IApplicationDBContext
    {
        DbSet<AppSetting> AppSettings { get; set; }
        Task<int> SaveChangesAsync();
    }
}
