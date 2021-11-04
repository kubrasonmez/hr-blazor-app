using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using HRManagement.Services.Interfaces;
using HRManagement.Shared;

namespace HRManagement
{
    public class EmployeeOverviewBase: ComponentBase
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        public List<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }

    }
}
