//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentSubtestViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentSubtestViewModel
     /// </summary>
    public partial class AssessmentSubtestViewModel : ViewModelBase, Interfaces.IAssessmentSubtest
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSubtest";

        // member variable for the Abbreviation property
        private System.String _Abbreviation;

        // member variable for the AssessmentFormId property
        private Guid? _AssessmentFormId;

        // member variable for the ChildOf_AssessmentSubtestId property
        private Guid? _ChildOf_AssessmentSubtestId;

        // member variable for the ContainerOnly property
        private System.String _ContainerOnly;

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the MaximumValue property
        private System.String _MaximumValue;

        // member variable for the MinimumValue property
        private System.String _MinimumValue;

        // member variable for the OptimalValue property
        private System.String _OptimalValue;

        // member variable for the PublishedDate property
        private System.DateTime? _PublishedDate;

        // member variable for the RefAcademicSubjectId property
        private Guid? _RefAcademicSubjectId;

        // member variable for the RefAssessmentPurposeId property
        private Guid? _RefAssessmentPurposeId;

        // member variable for the RefAssessmentSubtestIdentifierTypeId property
        private Guid? _RefAssessmentSubtestIdentifierTypeId;

        // member variable for the RefContentStandardTypeId property
        private Guid? _RefContentStandardTypeId;

        // member variable for the RefScoreMetricTypeId property
        private Guid? _RefScoreMetricTypeId;

        // member variable for the Rules property
        private System.String _Rules;

        // member variable for the Tier property
        private System.Int32? _Tier;

        // member variable for the Title property
        private System.String _Title;

        // member variable for the Version property
        private System.String _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentSubtestViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Abbreviation { get => _Abbreviation; set => SetProperty(ref _Abbreviation, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentForm"/> model
        /// </summary>
        public Guid? AssessmentFormId { get => _AssessmentFormId; set => SetProperty(ref _AssessmentFormId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ChildOf_AssessmentSubtest"/> model
        /// </summary>
        public Guid? ChildOf_AssessmentSubtestId { get => _ChildOf_AssessmentSubtestId; set => SetProperty(ref _ChildOf_AssessmentSubtestId, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String ContainerOnly { get => _ContainerOnly; set => SetProperty(ref _ContainerOnly, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String MaximumValue { get => _MaximumValue; set => SetProperty(ref _MaximumValue, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String MinimumValue { get => _MinimumValue; set => SetProperty(ref _MinimumValue, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String OptimalValue { get => _OptimalValue; set => SetProperty(ref _OptimalValue, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.DateTime? PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicSubject"/> model
        /// </summary>
        public Guid? RefAcademicSubjectId { get => _RefAcademicSubjectId; set => SetProperty(ref _RefAcademicSubjectId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurpose"/> model
        /// </summary>
        public Guid? RefAssessmentPurposeId { get => _RefAssessmentPurposeId; set => SetProperty(ref _RefAssessmentPurposeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSubtestentifierType"/> model
        /// </summary>
        public Guid? RefAssessmentSubtestIdentifierTypeId { get => _RefAssessmentSubtestIdentifierTypeId; set => SetProperty(ref _RefAssessmentSubtestIdentifierTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefContentStandardType"/> model
        /// </summary>
        public Guid? RefContentStandardTypeId { get => _RefContentStandardTypeId; set => SetProperty(ref _RefContentStandardTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScoreMetricType"/> model
        /// </summary>
        public Guid? RefScoreMetricTypeId { get => _RefScoreMetricTypeId; set => SetProperty(ref _RefScoreMetricTypeId, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Rules { get => _Rules; set => SetProperty(ref _Rules, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.Int32? Tier { get => _Tier; set => SetProperty(ref _Tier, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSubtest model)
        {
            IsBusy = true;
            Id = model.Id;
            Abbreviation = model.Abbreviation;
            AssessmentFormId = model.AssessmentFormId;
            ChildOf_AssessmentSubtestId = model.ChildOf_AssessmentSubtestId;
            ContainerOnly = model.ContainerOnly;
            Identifier = model.Identifier;
            MaximumValue = model.MaximumValue;
            MinimumValue = model.MinimumValue;
            OptimalValue = model.OptimalValue;
            PublishedDate = model.PublishedDate;
            RefAcademicSubjectId = model.RefAcademicSubjectId;
            RefAssessmentPurposeId = model.RefAssessmentPurposeId;
            RefAssessmentSubtestIdentifierTypeId = model.RefAssessmentSubtestIdentifierTypeId;
            RefContentStandardTypeId = model.RefContentStandardTypeId;
            RefScoreMetricTypeId = model.RefScoreMetricTypeId;
            Rules = model.Rules;
            Tier = model.Tier;
            Title = model.Title;
            Version = model.Version;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
