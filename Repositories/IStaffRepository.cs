using System;
using BlazorStaff.Models;

namespace BlazorStaff.Repository;
public interface IStaffRepository{
    Task <IEnumerable<Employee>> GetAllEmployee();
    Task <Employee> GetEmployee(int id);
}