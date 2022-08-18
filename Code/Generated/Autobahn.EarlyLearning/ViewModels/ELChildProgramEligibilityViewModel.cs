//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildProgramEligibilityViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildProgramEligibility View Model
     /// </summary>
    public partial class ELChildProgramEligibilityViewModel : ViewModelBase, Interfaces.IELChildProgramEligibility
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildProgramEligibility";

        // ExpirationDate -- (backing property for Early Learning Program Eligibility Expiration Date)
        private System.DateTime? _ExpirationDate;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefELProgramEligibilityStatusId -- (backing property for Early Learning Program Eligibility Status)
        private Guid? _RefELProgramEligibilityStatusId;

        // StatusDate -- (backing property for Early Learning Program Eligibility Status Date)
        private System.DateTime? _StatusDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Early Learning Program Eligibility Expiration Date
        /// <para>
        /// The year, month, and day on which the child is no longer eligible for the  Program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20305">Early Learning Program Eligibility Expiration Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ExpirationDate { get => _ExpirationDate; set => SetProperty(ref _ExpirationDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Early Learning Program Eligibility Status
        /// <para>
        /// The status of eligibility for the child.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20306">Early Learning Program Eligibility Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefELProgramEligibilityStatusId { get => _RefELProgramEligibilityStatusId; set => SetProperty(ref _RefELProgramEligibilityStatusId, value); }

        /// <summary>
        /// Early Learning Program Eligibility Status Date
        /// <para>
        /// The date of status of eligibility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20307">Early Learning Program Eligibility Status Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? StatusDate { get => _StatusDate; set => SetProperty(ref _StatusDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildProgramEligibility model)
        {
            IsBusy = true;
            Id = model.Id;
            ExpirationDate = model.ExpirationDate; // Early Learning Program Eligibility Expiration Date
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefELProgramEligibilityStatusId = model.RefELProgramEligibilityStatusId; // Early Learning Program Eligibility Status
            StatusDate = model.StatusDate; // Early Learning Program Eligibility Status Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
