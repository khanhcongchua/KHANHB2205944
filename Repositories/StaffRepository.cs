using System;
using BlazorStaff.Models;
using BlazorStaff.Repository;

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

    public async Task<IEnumerable<Employee>> GetAllEmployee() {
        return staffsContext.Employees;
    }
}