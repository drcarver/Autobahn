//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PSStudentProgramViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PSStudentProgramViewModel
     /// </summary>
    public partial class PSStudentProgramViewModel : ViewModelBase, Interfaces.IPSStudentProgram
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PSStudentProgram";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefCipUseId property
        private Guid? _RefCipUseId;

        // member variable for the PsProgramId property
        private Guid? _PsProgramId;

        // member variable for the RefWorkbasedLearningOpportunityTypeId property
        private Guid? _RefWorkbasedLearningOpportunityTypeId;

        // member variable for the RefTransferOutIndicatorId property
        private Guid? _RefTransferOutIndicatorId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RefCareerClusterId property
        private Guid? _RefCareerClusterId;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PSStudentProgramViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipUseId"/> model
        /// </summary>
        public Guid? RefCipUseId { get => _RefCipUseId; set => SetProperty(ref _RefCipUseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PsProgramId"/> model
        /// </summary>
        public Guid? PsProgramId { get => _PsProgramId; set => SetProperty(ref _PsProgramId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityTypeId"/> model
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get => _RefWorkbasedLearningOpportunityTypeId; set => SetProperty(ref _RefWorkbasedLearningOpportunityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTransferOutIndicatorId"/> model
        /// </summary>
        public Guid? RefTransferOutIndicatorId { get => _RefTransferOutIndicatorId; set => SetProperty(ref _RefTransferOutIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerClusterId"/> model
        /// </summary>
        public Guid? RefCareerClusterId { get => _RefCareerClusterId; set => SetProperty(ref _RefCareerClusterId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPSStudentProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefCipUseId = model.RefCipUseId;
            PsProgramId = model.PsProgramId;
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId;
            RefTransferOutIndicatorId = model.RefTransferOutIndicatorId;
            RefCareerClusterId = model.RefCareerClusterId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
