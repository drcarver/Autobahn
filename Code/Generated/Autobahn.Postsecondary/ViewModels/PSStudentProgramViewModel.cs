//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PSStudentProgramViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the PsProgramId property
        private Guid? _PsProgramId;

        // member variable for the RefCareerClusterId property
        private Guid? _RefCareerClusterId;

        // member variable for the RefCipUseId property
        private Guid? _RefCipUseId;

        // member variable for the RefTransferOutIndicatorId property
        private Guid? _RefTransferOutIndicatorId;

        // member variable for the RefWorkbasedLearningOpportunityTypeId property
        private Guid? _RefWorkbasedLearningOpportunityTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PSStudentProgramViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PsProgram"/> model
        /// </summary>
        public Guid? PsProgramId { get => _PsProgramId; set => SetProperty(ref _PsProgramId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
        /// </summary>
        public Guid? RefCareerClusterId { get => _RefCareerClusterId; set => SetProperty(ref _RefCareerClusterId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipUse"/> model
        /// </summary>
        public Guid? RefCipUseId { get => _RefCipUseId; set => SetProperty(ref _RefCipUseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTransferOutIndicator"/> model
        /// </summary>
        public Guid? RefTransferOutIndicatorId { get => _RefTransferOutIndicatorId; set => SetProperty(ref _RefTransferOutIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get => _RefWorkbasedLearningOpportunityTypeId; set => SetProperty(ref _RefWorkbasedLearningOpportunityTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPSStudentProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            PsProgramId = model.PsProgramId;
            RefCareerClusterId = model.RefCareerClusterId;
            RefCipUseId = model.RefCipUseId;
            RefTransferOutIndicatorId = model.RefTransferOutIndicatorId;
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
