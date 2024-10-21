using System.Configuration;
using BlazorStaff.Models;
using Microsoft.AspNetCore.Components;
using BlazorStaff.Repository;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace BlazorStaff.Components.Pages{
    public class StaffDetailsBase : ComponentBase
{
    public Employee employee { get; set; } = new Employee();
    [Inject]
    public IStaffRepository staffRepository { get; set; }

    [Parameter]
    public string Id {get; set; }

    protected async override Task OnInitializedAsync()
    {
        Id = Id ?? "1";
        employee = await staffRepository.GetEmployee(int.Parse(Id));
    }
}
};

