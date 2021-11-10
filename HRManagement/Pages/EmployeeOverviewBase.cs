using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using HRManagement.Services.Interfaces;
using HRManagement.Shared;
using HRManagement.Components;
using Microsoft.AspNetCore.Components;

namespace HRManagement
{
    public class EmployeeOverviewBase: ComponentBase
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        public List<Employee> Employees { get; set; }

        protected AddEmployeeDialog AddEmployeeDialog { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }

        public async void AddEmployeeDialog_OnDialogClose()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            StateHasChanged();
        }

        protected void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }

    }
}
