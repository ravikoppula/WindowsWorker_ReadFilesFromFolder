using Demo.Models;
using Demo.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public interface IEmplyeeService
    {
        #region Employee Details

        List<EmployeeViewModel> GetAllEmployeeDetails();
        tblEmployee AddEmployees();

        //tblEmployee TransferEmployees();
        //tblSkill TransferSkills();

        #endregion 
    }

}
