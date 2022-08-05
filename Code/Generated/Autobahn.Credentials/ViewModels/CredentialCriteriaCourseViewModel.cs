//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialCriteriaCourseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialCriteriaCourseViewModel
     /// </summary>
    public partial class CredentialCriteriaCourseViewModel : ViewModelBase, Interfaces.ICredentialCriteriaCourse
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialCriteriaCourse";

        // member variable for the CredentialDefCriteriaId property
        private Guid _CredentialDefCriteriaId;

        // member variable for the CourseId property
        private Guid _CourseId;

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
        /// The title of the CredentialCriteriaCourseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefCriteriaId"/> model
        /// </summary>
        public Guid CredentialDefCriteriaId { get => _CredentialDefCriteriaId; set => SetProperty(ref _CredentialDefCriteriaId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CourseId"/> model
        /// </summary>
        public Guid CourseId { get => _CourseId; set => SetProperty(ref _CourseId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialCriteriaCourse model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialDefCriteriaId = model.CredentialDefCriteriaId;
            CourseId = model.CourseId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
