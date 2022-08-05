//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentViewModel
     /// </summary>
    public partial class AssessmentViewModel : ViewModelBase, Interfaces.IAssessment
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Assessment";

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the IdentificationSystem property
        private System.Int32? _IdentificationSystem;

        // member variable for the GUID property
        private System.String _GUID;

        // member variable for the Title property
        private System.String _Title;

        // member variable for the ShortName property
        private System.String _ShortName;

        // member variable for the RefAcademicSubjectId property
        private Guid _RefAcademicSubjectId;

        // member variable for the Objective property
        private System.String _Objective;

        // member variable for the Provider property
        private System.String _Provider;

        // member variable for the RefAssessmentPurposeId property
        private Guid? _RefAssessmentPurposeId;

        // member variable for the RefAssessmentTypeId property
        private Guid? _RefAssessmentTypeId;

        // member variable for the RefAssessmentTypeChildrenWithDisabilitiesId property
        private Guid? _RefAssessmentTypeChildrenWithDisabilitiesId;

        // member variable for the AssessmentRevisionDate property
        private System.DateTime? _AssessmentRevisionDate;

        // member variable for the AssessmentFamilyTitle property
        private System.String _AssessmentFamilyTitle;

        // member variable for the AssessmentFamilyShortName property
        private System.String _AssessmentFamilyShortName;

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
        /// The title of the AssessmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        public System.Int32? IdentificationSystem { get => _IdentificationSystem; set => SetProperty(ref _IdentificationSystem, value); }

        public System.String GUID  { get => _GUID; set => SetProperty(ref _GUID, value); }

        public System.String Title  { get => _Title; set => SetProperty(ref _Title, value); }

        public System.String ShortName  { get => _ShortName; set => SetProperty(ref _ShortName, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAcademicSubjectId"/> model
        /// </summary>
        public Guid RefAcademicSubjectId { get => _RefAcademicSubjectId; set => SetProperty(ref _RefAcademicSubjectId, value); }

        public System.String Objective  { get => _Objective; set => SetProperty(ref _Objective, value); }

        public System.String Provider  { get => _Provider; set => SetProperty(ref _Provider, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurposeId"/> model
        /// </summary>
        public Guid? RefAssessmentPurposeId { get => _RefAssessmentPurposeId; set => SetProperty(ref _RefAssessmentPurposeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentTypeId { get => _RefAssessmentTypeId; set => SetProperty(ref _RefAssessmentTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentTypeChildrenWithDisabilitiesId"/> model
        /// </summary>
        public Guid? RefAssessmentTypeChildrenWithDisabilitiesId { get => _RefAssessmentTypeChildrenWithDisabilitiesId; set => SetProperty(ref _RefAssessmentTypeChildrenWithDisabilitiesId, value); }

        public System.DateTime? AssessmentRevisionDate { get => _AssessmentRevisionDate; set => SetProperty(ref _AssessmentRevisionDate, value); }

        public System.String AssessmentFamilyTitle  { get => _AssessmentFamilyTitle; set => SetProperty(ref _AssessmentFamilyTitle, value); }

        public System.String AssessmentFamilyShortName  { get => _AssessmentFamilyShortName; set => SetProperty(ref _AssessmentFamilyShortName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessment model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier;
            IdentificationSystem = model.IdentificationSystem;
            GUID = model.GUID;
            Title = model.Title;
            ShortName = model.ShortName;
            RefAcademicSubjectId = model.RefAcademicSubjectId;
            Objective = model.Objective;
            Provider = model.Provider;
            RefAssessmentPurposeId = model.RefAssessmentPurposeId;
            RefAssessmentTypeId = model.RefAssessmentTypeId;
            RefAssessmentTypeChildrenWithDisabilitiesId = model.RefAssessmentTypeChildrenWithDisabilitiesId;
            AssessmentRevisionDate = model.AssessmentRevisionDate;
            AssessmentFamilyTitle = model.AssessmentFamilyTitle;
            AssessmentFamilyShortName = model.AssessmentFamilyShortName;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
