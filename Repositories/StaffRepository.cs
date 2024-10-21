using System;
using BlazorStaff.Models;
using BlazorStaff.Repository;
using Microsoft.EntityFrameworkCore;

public class StaffRepository: IStaffRepository
{
    public StaffsContext staffsContext;

    public StaffRepository(StaffsContext staffsContext){
        this.staffsContext = staffsContext;
    }

    public async Task<Employee> GetEmployee(int id){
        return (from Employee in staffsContext.Employees
            where Employee.EmployeeId == id
            select Employee).First();
        
    }


    // private readonly StaffsContext staffsContext;

    // public StaffRepository(StaffsContext staffsContext)
    // {
    //     staffsContext = staffsContext;  // Inject StaffsContext thông qua DI
    // }

//     public async Task<Employee> GetEmployee(int id)
// {
//     return await staffsContext.Employees
//         .Include(e => e.Department) // Bao gồm bảng Department
//         .Include(e => e.Gender) // Bao gồm bảng Gender nếu cần
//         .FirstOrDefaultAsync(e => e.EmployeeId == id); // Sử dụng FirstOrDefaultAsync để tránh ngoại lệ nếu không tìm thấy
// }


    public async Task<IEnumerable<Employee>> GetAllEmployee() {
        return staffsContext.Employees;
    }



//     public async Task<IEnumerable<Employee>> GetAllEmployee()
// {
//     return await staffsContext.Employees
//         .Include(e => e.Department) // Bao gồm bảng Department
//         .Include(e => e.Gender) // Bao gồm bảng Gender nếu cần
//         .ToListAsync(); // Sử dụng ToListAsync để trả về danh sách
// }

}