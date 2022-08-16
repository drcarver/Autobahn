//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentViewModel
     /// </summary>
    public partial class AssessmentViewModel : ViewModelBase, Interfaces.IAssessment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Assessment";

        // member variable for the AssessmentFamilyShortName property
        private  _AssessmentFamilyShortName;

        // member variable for the AssessmentFamilyTitle property
        private  _AssessmentFamilyTitle;

        // member variable for the AssessmentRevisionDate property
        private  _AssessmentRevisionDate;

        // member variable for the GUID property
        private  _GUID;

        // member variable for the IdentificationSystem property
        private  _IdentificationSystem;

        // member variable for the Identifier property
        private  _Identifier;

        // member variable for the Objective property
        private  _Objective;

        // member variable for the Provider property
        private  _Provider;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAcademicSubjectId property
        private Guid? _RefAcademicSubjectId;

        // member variable for the RefAssessmentPurposeId property
        private  _RefAssessmentPurposeId;

        // member variable for the RefAssessmentTypeChildrenWithDisabilitiesId property
        private  _RefAssessmentTypeChildrenWithDisabilitiesId;

        // member variable for the RefAssessmentTypeId property
        private  _RefAssessmentTypeId;

        // member variable for the ShortName property
        private  _ShortName;

        // member variable for the Title property
        private  _Title;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AssessmentFamilyShortName { get => _AssessmentFamilyShortName; set => SetProperty(ref _AssessmentFamilyShortName, value); }

        /// <summary>
        /// </summary>
        public  AssessmentFamilyTitle { get => _AssessmentFamilyTitle; set => SetProperty(ref _AssessmentFamilyTitle, value); }

        /// <summary>
        /// </summary>
        public  AssessmentRevisionDate { get => _AssessmentRevisionDate; set => SetProperty(ref _AssessmentRevisionDate, value); }

        /// <summary>
        /// </summary>
        public  GUID { get => _GUID; set => SetProperty(ref _GUID, value); }

        /// <summary>
        /// </summary>
        public  IdentificationSystem { get => _IdentificationSystem; set => SetProperty(ref _IdentificationSystem, value); }

        /// <summary>
        /// </summary>
        public  Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// </summary>
        public  Objective { get => _Objective; set => SetProperty(ref _Objective, value); }

        /// <summary>
        /// </summary>
        public  Provider { get => _Provider; set => SetProperty(ref _Provider, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicSubject"/> model
        /// </summary>
        public Guid? RefAcademicSubjectId { get => _RefAcademicSubjectId; set => SetProperty(ref _RefAcademicSubjectId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurpose"/> model
        /// </summary>
        public  RefAssessmentPurposeId { get => _RefAssessmentPurposeId; set => SetProperty(ref _RefAssessmentPurposeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentTypeChildrenWithDisabilities"/> model
        /// </summary>
        public  RefAssessmentTypeChildrenWithDisabilitiesId { get => _RefAssessmentTypeChildrenWithDisabilitiesId; set => SetProperty(ref _RefAssessmentTypeChildrenWithDisabilitiesId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentType"/> model
        /// </summary>
        public  RefAssessmentTypeId { get => _RefAssessmentTypeId; set => SetProperty(ref _RefAssessmentTypeId, value); }

        /// <summary>
        /// </summary>
        public  ShortName { get => _ShortName; set => SetProperty(ref _ShortName, value); }

        /// <summary>
        /// </summary>
        public  Title { get => _Title; set => SetProperty(ref _Title, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessment model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentFamilyShortName = model.AssessmentFamilyShortName; // 
            AssessmentFamilyTitle = model.AssessmentFamilyTitle; // 
            AssessmentRevisionDate = model.AssessmentRevisionDate; // 
            GUID = model.GUID; // 
            IdentificationSystem = model.IdentificationSystem; // 
            Identifier = model.Identifier; // 
            Objective = model.Objective; // 
            Provider = model.Provider; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAcademicSubjectId = model.RefAcademicSubjectId; // 
            RefAssessmentPurposeId = model.RefAssessmentPurposeId; // 
            RefAssessmentTypeChildrenWithDisabilitiesId = model.RefAssessmentTypeChildrenWithDisabilitiesId; // 
            RefAssessmentTypeId = model.RefAssessmentTypeId; // 
            ShortName = model.ShortName; // 
            Title = model.Title; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
