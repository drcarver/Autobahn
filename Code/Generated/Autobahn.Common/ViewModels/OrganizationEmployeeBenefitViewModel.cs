//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmployeeBenefitViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationEmployeeBenefit View Model
     /// </summary>
    public partial class OrganizationEmployeeBenefitViewModel : ViewModelBase, Interfaces.IOrganizationEmployeeBenefit
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationEmployeeBenefit";

        // FullTimeBenefitIndicator -- (backing property for Full-Time Employee Benefits)
        private System.Boolean? _FullTimeBenefitIndicator;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // PartTimeBenefitIndicator -- (backing property for Part-Time Employee Benefits)
        private System.Boolean? _PartTimeBenefitIndicator;

        // RefEmployeeBenefitId -- (backing property for Full-Time Employee Benefits)
        private Guid? _RefEmployeeBenefitId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Full-Time Employee Benefits
        /// <para>
        /// The benefits offered by a program/facility/employer for full-time staff.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19866">Full-Time Employee Benefits</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? FullTimeBenefitIndicator { get => _FullTimeBenefitIndicator; set => SetProperty(ref _FullTimeBenefitIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Part-Time Employee Benefits
        /// <para>
        /// The benefits offered by a program/facility/employer for part-time staff.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19867">Part-Time Employee Benefits</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? PartTimeBenefitIndicator { get => _PartTimeBenefitIndicator; set => SetProperty(ref _PartTimeBenefitIndicator, value); }

        /// <summary>
        /// Full-Time Employee Benefits
        /// <para>
        /// The benefits offered by a program/facility/employer for full-time staff.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19866">Full-Time Employee Benefits</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEmployeeBenefitId { get => _RefEmployeeBenefitId; set => SetProperty(ref _RefEmployeeBenefitId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationEmployeeBenefit model)
        {
            IsBusy = true;
            Id = model.Id;
            FullTimeBenefitIndicator = model.FullTimeBenefitIndicator; // Full-Time Employee Benefits
            OrganizationId = model.OrganizationId; // 
            PartTimeBenefitIndicator = model.PartTimeBenefitIndicator; // Part-Time Employee Benefits
            RefEmployeeBenefitId = model.RefEmployeeBenefitId; // Full-Time Employee Benefits
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
