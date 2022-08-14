//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodProgramTypeOfferedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The EarlyChildhoodProgramTypeOfferedViewModel
     /// </summary>
    public partial class EarlyChildhoodProgramTypeOfferedViewModel : ViewModelBase, Interfaces.IEarlyChildhoodProgramTypeOffered
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from EarlyChildhoodProgramTypeOffered";

        // member variable for the InclusiveSettingIndicator property
        private System.Boolean? _InclusiveSettingIndicator;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefCommunityBasedTypeId property
        private Guid? _RefCommunityBasedTypeId;

        // member variable for the RefEarlyChildhoodProgramEnrollmentTypeId property
        private Guid _RefEarlyChildhoodProgramEnrollmentTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the EarlyChildhoodProgramTypeOfferedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
        /// </summary>
        public System.Boolean? InclusiveSettingIndicator { get => _InclusiveSettingIndicator; set => SetProperty(ref _InclusiveSettingIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCommunityBasedType"/> model
        /// </summary>
        public Guid? RefCommunityBasedTypeId { get => _RefCommunityBasedTypeId; set => SetProperty(ref _RefCommunityBasedTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEarlyChildhoodProgramEnrollmentType"/> model
        /// </summary>
        public Guid RefEarlyChildhoodProgramEnrollmentTypeId { get => _RefEarlyChildhoodProgramEnrollmentTypeId; set => SetProperty(ref _RefEarlyChildhoodProgramEnrollmentTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IEarlyChildhoodProgramTypeOffered model)
        {
            IsBusy = true;
            Id = model.Id;
            InclusiveSettingIndicator = model.InclusiveSettingIndicator;
            OrganizationId = model.OrganizationId;
            RefCommunityBasedTypeId = model.RefCommunityBasedTypeId;
            RefEarlyChildhoodProgramEnrollmentTypeId = model.RefEarlyChildhoodProgramEnrollmentTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
