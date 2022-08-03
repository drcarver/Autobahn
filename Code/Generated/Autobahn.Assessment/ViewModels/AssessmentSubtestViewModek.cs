//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtestViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentSubtestViewModel
     /// </summary>
    public partial class AssessmentSubtestViewModel : BindableBase, IAssessmentSubtest
    {
#region "Backing Fields"
        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the Title property
        private System.String _Title;

        // member variable for the Version property
        private System.String _Version;

        // member variable for the PublishedDate property
        private System.DateTime? _PublishedDate;

        // member variable for the Abbreviation property
        private System.String _Abbreviation;

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

        // member variable for the Description property
        private System.String _Description;

        // member variable for the Rules property
        private System.String _Rules;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSubtestIdentifierTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentSubtestIdentifierTypeId { get; set; }

        public System.String Title  { get => _Title; set => SetProperty(ref _Title, value); }

        public System.String Version  { get => _Version; set => SetProperty(ref _Version, value); }

        public System.DateTime? PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        public System.String Abbreviation  { get => _Abbreviation; set => SetProperty(ref _Abbreviation, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScoreMetricTypeId"/> model
        /// </summary>
        public Guid? RefScoreMetricTypeId { get; set; }

        public System.String MinimumValue  { get => _MinimumValue; set => SetProperty(ref _MinimumValue, value); }

        public System.String MaximumValue  { get => _MaximumValue; set => SetProperty(ref _MaximumValue, value); }

        public System.String OptimalValue  { get => _OptimalValue; set => SetProperty(ref _OptimalValue, value); }

        public System.Int32? Tier { get => _Tier; set => SetProperty(ref _Tier, value); }

        public System.String ContainerOnly  { get => _ContainerOnly; set => SetProperty(ref _ContainerOnly, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurposeId"/> model
        /// </summary>
        public Guid? RefAssessmentPurposeId { get; set; }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String Rules  { get => _Rules; set => SetProperty(ref _Rules, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefContentStandardTypeId"/> model
        /// </summary>
        public Guid? RefContentStandardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicSubjectId"/> model
        /// </summary>
        public Guid? RefAcademicSubjectId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ChildOf_AssessmentSubtestId"/> model
        /// </summary>
        public Guid? ChildOf_AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentFormId"/> model
        /// </summary>
        public Guid? AssessmentFormId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IAssessmentSubtest model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
