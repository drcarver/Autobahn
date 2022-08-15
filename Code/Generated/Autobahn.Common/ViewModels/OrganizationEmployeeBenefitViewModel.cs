//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmployeeBenefitViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationEmployeeBenefitViewModel
     /// </summary>
    public partial class OrganizationEmployeeBenefitViewModel : ViewModelBase, Interfaces.IOrganizationEmployeeBenefit
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationEmployeeBenefit";

        // member variable for the FullTimeBenefitIndicator property
        private System.Boolean? _FullTimeBenefitIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationEmployeeBenefitViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The benefits offered by a program/facility/employer for full-time staff.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19866">Full-Time Employee Benefits</a>
        /// </para>
        /// </summary>
        [DisplayName("Full-Time Employee Benefits")]
        public System.Boolean? FullTimeBenefitIndicator { get => _FullTimeBenefitIndicator; set => SetProperty(ref _FullTimeBenefitIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationEmployeeBenefit model)
        {
            IsBusy = true;
            Id = model.Id;
            FullTimeBenefitIndicator = model.FullTimeBenefitIndicator; // Full-Time Employee Benefits
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
