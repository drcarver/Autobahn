//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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
        private System.String _AssessmentFamilyShortName;

        // member variable for the AssessmentFamilyTitle property
        private System.String _AssessmentFamilyTitle;

        // member variable for the AssessmentRevisionDate property
        private System.DateTime? _AssessmentRevisionDate;

        // member variable for the GUID property
        private System.String _GUID;

        // member variable for the IdentificationSystem property
        private System.Int32? _IdentificationSystem;

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the Objective property
        private System.String _Objective;

        // member variable for the Provider property
        private System.String _Provider;

        // member variable for the RefAcademicSubjectId property
        private Guid _RefAcademicSubjectId;

        // member variable for the RefAssessmentPurposeId property
        private Guid? _RefAssessmentPurposeId;

        // member variable for the RefAssessmentTypeChildrenWithDisabilitiesId property
        private Guid? _RefAssessmentTypeChildrenWithDisabilitiesId;

        // member variable for the RefAssessmentTypeId property
        private Guid? _RefAssessmentTypeId;

        // member variable for the ShortName property
        private System.String _ShortName;

        // member variable for the Title property
        private System.String _Title;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String AssessmentFamilyShortName { get => _AssessmentFamilyShortName; set => SetProperty(ref _AssessmentFamilyShortName, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String AssessmentFamilyTitle { get => _AssessmentFamilyTitle; set => SetProperty(ref _AssessmentFamilyTitle, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.DateTime? AssessmentRevisionDate { get => _AssessmentRevisionDate; set => SetProperty(ref _AssessmentRevisionDate, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String GUID { get => _GUID; set => SetProperty(ref _GUID, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.Int32? IdentificationSystem { get => _IdentificationSystem; set => SetProperty(ref _IdentificationSystem, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Objective { get => _Objective; set => SetProperty(ref _Objective, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Provider { get => _Provider; set => SetProperty(ref _Provider, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicSubject"/> model
        /// </summary>
        public Guid RefAcademicSubjectId { get => _RefAcademicSubjectId; set => SetProperty(ref _RefAcademicSubjectId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurpose"/> model
        /// </summary>
        public Guid? RefAssessmentPurposeId { get => _RefAssessmentPurposeId; set => SetProperty(ref _RefAssessmentPurposeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentTypeChildrenWithDisabilities"/> model
        /// </summary>
        public Guid? RefAssessmentTypeChildrenWithDisabilitiesId { get => _RefAssessmentTypeChildrenWithDisabilitiesId; set => SetProperty(ref _RefAssessmentTypeChildrenWithDisabilitiesId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentType"/> model
        /// </summary>
        public Guid? RefAssessmentTypeId { get => _RefAssessmentTypeId; set => SetProperty(ref _RefAssessmentTypeId, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String ShortName { get => _ShortName; set => SetProperty(ref _ShortName, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Title { get => _Title; set => SetProperty(ref _Title, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessment model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentFamilyShortName = model.AssessmentFamilyShortName;
            AssessmentFamilyTitle = model.AssessmentFamilyTitle;
            AssessmentRevisionDate = model.AssessmentRevisionDate;
            GUID = model.GUID;
            IdentificationSystem = model.IdentificationSystem;
            Identifier = model.Identifier;
            Objective = model.Objective;
            Provider = model.Provider;
            RefAcademicSubjectId = model.RefAcademicSubjectId;
            RefAssessmentPurposeId = model.RefAssessmentPurposeId;
            RefAssessmentTypeChildrenWithDisabilitiesId = model.RefAssessmentTypeChildrenWithDisabilitiesId;
            RefAssessmentTypeId = model.RefAssessmentTypeId;
            ShortName = model.ShortName;
            Title = model.Title;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
