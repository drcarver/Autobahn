//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildProgramEligibilityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildProgramEligibilityViewModel
     /// </summary>
    public partial class ELChildProgramEligibilityViewModel : ViewModelBase, Interfaces.IELChildProgramEligibility
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildProgramEligibility";

        // member variable for the ExpirationDate property
        private System.DateTime? _ExpirationDate;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefELProgramEligibilityStatusId property
        private Guid? _RefELProgramEligibilityStatusId;

        // member variable for the StatusDate property
        private System.DateTime? _StatusDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildProgramEligibilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month, and day on which the child is no longer eligible for the  Program.
        /// </summary>
        public System.DateTime? ExpirationDate { get => _ExpirationDate; set => SetProperty(ref _ExpirationDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramEligibilityStatus"/> model
        /// </summary>
        public Guid? RefELProgramEligibilityStatusId { get => _RefELProgramEligibilityStatusId; set => SetProperty(ref _RefELProgramEligibilityStatusId, value); }

        /// <summary>
        /// The year, month, and day on which the child is no longer eligible for the  Program.
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
            ExpirationDate = model.ExpirationDate;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefELProgramEligibilityStatusId = model.RefELProgramEligibilityStatusId;
            StatusDate = model.StatusDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
