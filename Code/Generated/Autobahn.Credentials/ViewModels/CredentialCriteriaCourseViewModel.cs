//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialCriteriaCourseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the CourseId property
        private Guid _CourseId;

        // member variable for the CredentialDefCriteriaId property
        private Guid _CredentialDefCriteriaId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialCriteriaCourseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Course"/> model
        /// </summary>
        public Guid CourseId { get => _CourseId; set => SetProperty(ref _CourseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CredentialDefCriteria"/> model
        /// </summary>
        public Guid CredentialDefCriteriaId { get => _CredentialDefCriteriaId; set => SetProperty(ref _CredentialDefCriteriaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialCriteriaCourse model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseId = model.CourseId;
            CredentialDefCriteriaId = model.CredentialDefCriteriaId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
