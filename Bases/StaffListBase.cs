using System;
using BlazorStaff.Models;
using BlazorStaff.Repository;
using Microsoft.AspNetCore.Components;

namespace BlazorStaff.Components.Pages;

public class EmployeeListBase : ComponentBase{
    [Inject]
    public IStaffRepository staffRepository {get; set;}

    public IEnumerable<Employee> employees {set;get;}


    protected override async Task OnInitializedAsync(){
        //EmployeeService = new EmployeeService();
        employees = await staffRepository.GetAllEmployee();
    }
}