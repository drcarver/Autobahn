//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramAccommodationSubjectViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAccommodationSubjectViewModel
     /// </summary>
    public partial class IndividualizedProgramAccommodationSubjectViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAccommodationSubject
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAccommodationSubject";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefSCEDCourseSubjectAreaId property
        private Guid? _RefSCEDCourseSubjectAreaId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseSubjectArea"/> model
        /// </summary>
        public Guid? RefSCEDCourseSubjectAreaId { get => _RefSCEDCourseSubjectAreaId; set => SetProperty(ref _RefSCEDCourseSubjectAreaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramAccommodationSubject model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefSCEDCourseSubjectAreaId = model.RefSCEDCourseSubjectAreaId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
