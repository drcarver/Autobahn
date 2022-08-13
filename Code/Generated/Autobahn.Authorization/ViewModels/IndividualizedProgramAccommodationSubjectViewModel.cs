//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramAccommodationSubjectViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAccommodationSubjectViewModel
     /// </summary>
    public partial class IndividualizedProgramAccommodationSubjectViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAccommodationSubject
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAccommodationSubject";

        // member variable for the IndividualizedProgramAccommodationId property
        private Guid _IndividualizedProgramAccommodationId;

        // member variable for the RefSCEDCourseSubjectAreaId property
        private Guid _RefSCEDCourseSubjectAreaId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramAccommodationSubjectViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgramAccommodation"/> model
        /// </summary>
        public Guid IndividualizedProgramAccommodationId { get => _IndividualizedProgramAccommodationId; set => SetProperty(ref _IndividualizedProgramAccommodationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseSubjectArea"/> model
        /// </summary>
        public Guid RefSCEDCourseSubjectAreaId { get => _RefSCEDCourseSubjectAreaId; set => SetProperty(ref _RefSCEDCourseSubjectAreaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramAccommodationSubject model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramAccommodationId = model.IndividualizedProgramAccommodationId;
            RefSCEDCourseSubjectAreaId = model.RefSCEDCourseSubjectAreaId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
