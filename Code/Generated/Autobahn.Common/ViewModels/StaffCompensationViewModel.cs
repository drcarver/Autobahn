//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffCompensationViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffCompensationViewModel
     /// </summary>
    public partial class StaffCompensationViewModel : ViewModelBase, Interfaces.IStaffCompensation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffCompensation";

        // member variable for the StaffCompensationBaseSalary property
        private System.Decimal? _StaffCompensationBaseSalary;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the StaffCompensationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19032">Staff Compensation Base Salary</a>
        /// </para>
        /// </summary>
        [DisplayName("Staff Compensation Base Salary")]
        public System.Decimal? StaffCompensationBaseSalary { get => _StaffCompensationBaseSalary; set => SetProperty(ref _StaffCompensationBaseSalary, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffCompensation model)
        {
            IsBusy = true;
            Id = model.Id;
            StaffCompensationBaseSalary = model.StaffCompensationBaseSalary; // Staff Compensation Base Salary
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
