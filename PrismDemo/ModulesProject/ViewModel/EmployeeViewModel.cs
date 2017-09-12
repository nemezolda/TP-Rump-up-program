using Microsoft.Practices.Prism.Commands;
using PrismDemo.Dal.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModulesProject.ViewModel
{
    public class EmployeeViewModel
    {
        public ObservableCollection<EmployeeModel> Employees { get; set; }

        public EmployeeViewModel()
        {
            Employees = new ObservableCollection<EmployeeModel>()
            {
                new EmployeeModel {Name = "Garry", LastName = "Potter", Age = 14 }
            };
        }

        private ICommand _editEmployee;
        public ICommand EditEmployee
        {
            get
            {
                return _editEmployee ??
                    (_editEmployee = new DelegateCommand(this.EditEployee));
            }
        }

        private void EditEployee()
        {

        }
    }
}
