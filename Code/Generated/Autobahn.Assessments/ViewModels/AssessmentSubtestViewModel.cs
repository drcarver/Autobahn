//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
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
        private  _Abbreviation;

        // member variable for the ContainerOnly property
        private  _ContainerOnly;

        // member variable for the Description property
        private  _Description;

        // member variable for the Identifier property
        private  _Identifier;

        // member variable for the MaximumValue property
        private  _MaximumValue;

        // member variable for the MinimumValue property
        private  _MinimumValue;

        // member variable for the OptimalValue property
        private  _OptimalValue;

        // member variable for the PublishedDate property
        private  _PublishedDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAcademicSubjectId property
        private Guid? _RefAcademicSubjectId;

        // member variable for the RefAssessmentPurposeId property
        private  _RefAssessmentPurposeId;

        // member variable for the RefAssessmentSubtestIdentifierTypeId property
        private  _RefAssessmentSubtestIdentifierTypeId;

        // member variable for the RefContentStandardTypeId property
        private  _RefContentStandardTypeId;

        // member variable for the RefScoreMetricTypeId property
        private  _RefScoreMetricTypeId;

        // member variable for the Rules property
        private  _Rules;

        // member variable for the Tier property
        private  _Tier;

        // member variable for the Title property
        private  _Title;

        // member variable for the Version property
        private  _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  Abbreviation { get => _Abbreviation; set => SetProperty(ref _Abbreviation, value); }

        /// <summary>
        /// </summary>
        public  ContainerOnly { get => _ContainerOnly; set => SetProperty(ref _ContainerOnly, value); }

        /// <summary>
        /// </summary>
        public  Description { get => _Description; set => SetProperty(ref _Description, value); }

        /// <summary>
        /// </summary>
        public  Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// </summary>
        public  MaximumValue { get => _MaximumValue; set => SetProperty(ref _MaximumValue, value); }

        /// <summary>
        /// </summary>
        public  MinimumValue { get => _MinimumValue; set => SetProperty(ref _MinimumValue, value); }

        /// <summary>
        /// </summary>
        public  OptimalValue { get => _OptimalValue; set => SetProperty(ref _OptimalValue, value); }

        /// <summary>
        /// </summary>
        public  PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

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
        /// Reference to an optional instance of the <see cref="RefAssessmentSubtestentifierType"/> model
        /// </summary>
        public  RefAssessmentSubtestIdentifierTypeId { get => _RefAssessmentSubtestIdentifierTypeId; set => SetProperty(ref _RefAssessmentSubtestIdentifierTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefContentStandardType"/> model
        /// </summary>
        public  RefContentStandardTypeId { get => _RefContentStandardTypeId; set => SetProperty(ref _RefContentStandardTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScoreMetricType"/> model
        /// </summary>
        public  RefScoreMetricTypeId { get => _RefScoreMetricTypeId; set => SetProperty(ref _RefScoreMetricTypeId, value); }

        /// <summary>
        /// </summary>
        public  Rules { get => _Rules; set => SetProperty(ref _Rules, value); }

        /// <summary>
        /// </summary>
        public  Tier { get => _Tier; set => SetProperty(ref _Tier, value); }

        /// <summary>
        /// </summary>
        public  Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// </summary>
        public  Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSubtest model)
        {
            IsBusy = true;
            Id = model.Id;
            Abbreviation = model.Abbreviation; // 
            ContainerOnly = model.ContainerOnly; // 
            Description = model.Description; // 
            Identifier = model.Identifier; // 
            MaximumValue = model.MaximumValue; // 
            MinimumValue = model.MinimumValue; // 
            OptimalValue = model.OptimalValue; // 
            PublishedDate = model.PublishedDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAcademicSubjectId = model.RefAcademicSubjectId; // 
            RefAssessmentPurposeId = model.RefAssessmentPurposeId; // 
            RefAssessmentSubtestIdentifierTypeId = model.RefAssessmentSubtestIdentifierTypeId; // 
            RefContentStandardTypeId = model.RefContentStandardTypeId; // 
            RefScoreMetricTypeId = model.RefScoreMetricTypeId; // 
            Rules = model.Rules; // 
            Tier = model.Tier; // 
            Title = model.Title; // 
            Version = model.Version; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
