//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffEmploymentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StaffEmploymentViewModel
     /// </summary>
    public partial class K12StaffEmploymentViewModel : ViewModelBase, Interfaces.IK12StaffEmployment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StaffEmployment";

        // member variable for the ContractDaysOfServicePerYear property
        private System.Decimal? _ContractDaysOfServicePerYear;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StaffEmploymentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19047">Contract Days of Service Per Year</a>
        /// </para>
        /// </summary>
        [DisplayName("Contract Days of Service Per Year")]
        public System.Decimal? ContractDaysOfServicePerYear { get => _ContractDaysOfServicePerYear; set => SetProperty(ref _ContractDaysOfServicePerYear, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            ContractDaysOfServicePerYear = model.ContractDaysOfServicePerYear; // Contract Days of Service Per Year
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
