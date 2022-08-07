//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtestViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentSubtestViewModel
     /// </summary>
    public partial class AssessmentSubtestViewModel : ViewModelBase, Interfaces.IAssessmentSubtestViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSubtest";

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the RefAssessmentSubtestIdentifierTypeId property
        private Guid? _RefAssessmentSubtestIdentifierTypeId;

        // member variable for the Title property
        private System.String _Title;

        // member variable for the Version property
        private System.String _Version;

        // member variable for the PublishedDate property
        private System.DateTime? _PublishedDate;

        // member variable for the Abbreviation property
        private System.String _Abbreviation;

        // member variable for the RefScoreMetricTypeId property
        private Guid? _RefScoreMetricTypeId;

        // member variable for the MinimumValue property
        private System.String _MinimumValue;

        // member variable for the MaximumValue property
        private System.String _MaximumValue;

        // member variable for the OptimalValue property
        private System.String _OptimalValue;

        // member variable for the Tier property
        private System.Int32? _Tier;

        // member variable for the ContainerOnly property
        private System.String _ContainerOnly;

        // member variable for the RefAssessmentPurposeId property
        private Guid? _RefAssessmentPurposeId;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the Rules property
        private System.String _Rules;

        // member variable for the RefContentStandardTypeId property
        private Guid? _RefContentStandardTypeId;

        // member variable for the RefAcademicSubjectId property
        private Guid? _RefAcademicSubjectId;

        // member variable for the ChildOf_AssessmentSubtestId property
        private Guid? _ChildOf_AssessmentSubtestId;

        // member variable for the AssessmentFormId property
        private Guid? _AssessmentFormId;

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
        /// The title of the AssessmentSubtestViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSubtestIdentifierTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentSubtestIdentifierTypeId { get => _RefAssessmentSubtestIdentifierTypeId; set => SetProperty(ref _RefAssessmentSubtestIdentifierTypeId, value); }

        public System.String Title  { get => _Title; set => SetProperty(ref _Title, value); }

        public System.String Version  { get => _Version; set => SetProperty(ref _Version, value); }

        public System.DateTime? PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        public System.String Abbreviation  { get => _Abbreviation; set => SetProperty(ref _Abbreviation, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScoreMetricTypeId"/> model
        /// </summary>
        public Guid? RefScoreMetricTypeId { get => _RefScoreMetricTypeId; set => SetProperty(ref _RefScoreMetricTypeId, value); }

        public System.String MinimumValue  { get => _MinimumValue; set => SetProperty(ref _MinimumValue, value); }

        public System.String MaximumValue  { get => _MaximumValue; set => SetProperty(ref _MaximumValue, value); }

        public System.String OptimalValue  { get => _OptimalValue; set => SetProperty(ref _OptimalValue, value); }

        public System.Int32? Tier { get => _Tier; set => SetProperty(ref _Tier, value); }

        public System.String ContainerOnly  { get => _ContainerOnly; set => SetProperty(ref _ContainerOnly, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurposeId"/> model
        /// </summary>
        public Guid? RefAssessmentPurposeId { get => _RefAssessmentPurposeId; set => SetProperty(ref _RefAssessmentPurposeId, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String Rules  { get => _Rules; set => SetProperty(ref _Rules, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefContentStandardTypeId"/> model
        /// </summary>
        public Guid? RefContentStandardTypeId { get => _RefContentStandardTypeId; set => SetProperty(ref _RefContentStandardTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicSubjectId"/> model
        /// </summary>
        public Guid? RefAcademicSubjectId { get => _RefAcademicSubjectId; set => SetProperty(ref _RefAcademicSubjectId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ChildOf_AssessmentSubtestId"/> model
        /// </summary>
        public Guid? ChildOf_AssessmentSubtestId { get => _ChildOf_AssessmentSubtestId; set => SetProperty(ref _ChildOf_AssessmentSubtestId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentFormId"/> model
        /// </summary>
        public Guid? AssessmentFormId { get => _AssessmentFormId; set => SetProperty(ref _AssessmentFormId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSubtest model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier;
            RefAssessmentSubtestIdentifierTypeId = model.RefAssessmentSubtestIdentifierTypeId;
            Title = model.Title;
            Version = model.Version;
            PublishedDate = model.PublishedDate;
            Abbreviation = model.Abbreviation;
            RefScoreMetricTypeId = model.RefScoreMetricTypeId;
            MinimumValue = model.MinimumValue;
            MaximumValue = model.MaximumValue;
            OptimalValue = model.OptimalValue;
            Tier = model.Tier;
            ContainerOnly = model.ContainerOnly;
            RefAssessmentPurposeId = model.RefAssessmentPurposeId;
            Description = model.Description;
            Rules = model.Rules;
            RefContentStandardTypeId = model.RefContentStandardTypeId;
            RefAcademicSubjectId = model.RefAcademicSubjectId;
            ChildOf_AssessmentSubtestId = model.ChildOf_AssessmentSubtestId;
            AssessmentFormId = model.AssessmentFormId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
