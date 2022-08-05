//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildProgramEligibilityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the StatusDate property
        private System.DateTime? _StatusDate;

        // member variable for the ExpirationDate property
        private System.DateTime? _ExpirationDate;

        // member variable for the RefELProgramEligibilityStatusId property
        private Guid? _RefELProgramEligibilityStatusId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildProgramEligibilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.DateTime? StatusDate { get => _StatusDate; set => SetProperty(ref _StatusDate, value); }

        public System.DateTime? ExpirationDate { get => _ExpirationDate; set => SetProperty(ref _ExpirationDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramEligibilityStatusId"/> model
        /// </summary>
        public Guid? RefELProgramEligibilityStatusId { get => _RefELProgramEligibilityStatusId; set => SetProperty(ref _RefELProgramEligibilityStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildProgramEligibility model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            StatusDate = model.StatusDate;
            ExpirationDate = model.ExpirationDate;
            RefELProgramEligibilityStatusId = model.RefELProgramEligibilityStatusId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
