//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentFormSectionViewModel
     /// </summary>
    public partial class AssessmentFormSectionViewModel : ViewModelBase, Interfaces.IAssessmentFormSection
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentFormSection";

        // member variable for the AssessmentItemBankIdentifier property
        private  _AssessmentItemBankIdentifier;

        // member variable for the AssessmentItemBankName property
        private  _AssessmentItemBankName;

        // member variable for the GUID property
        private Guid? _GUID;

        // member variable for the Identifier property
        private  _Identifier;

        // member variable for the PublishedDate property
        private  _PublishedDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentFormSectionIdentificationSystemId property
        private  _RefAssessmentFormSectionIdentificationSystemId;

        // member variable for the SectionReentry property
        private  _SectionReentry;

        // member variable for the SectionSealed property
        private  _SectionSealed;

        // member variable for the SectionTimeLimit property
        private  _SectionTimeLimit;

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
        public  AssessmentItemBankIdentifier { get => _AssessmentItemBankIdentifier; set => SetProperty(ref _AssessmentItemBankIdentifier, value); }

        /// <summary>
        /// </summary>
        public  AssessmentItemBankName { get => _AssessmentItemBankName; set => SetProperty(ref _AssessmentItemBankName, value); }

        /// <summary>
        /// </summary>
        public Guid? GUID { get => _GUID; set => SetProperty(ref _GUID, value); }

        /// <summary>
        /// </summary>
        public  Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

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
        /// Reference to an optional instance of the <see cref="RefAssessmentFormSectionentificationSystem"/> model
        /// </summary>
        public  RefAssessmentFormSectionIdentificationSystemId { get => _RefAssessmentFormSectionIdentificationSystemId; set => SetProperty(ref _RefAssessmentFormSectionIdentificationSystemId, value); }

        /// <summary>
        /// </summary>
        public  SectionReentry { get => _SectionReentry; set => SetProperty(ref _SectionReentry, value); }

        /// <summary>
        /// </summary>
        public  SectionSealed { get => _SectionSealed; set => SetProperty(ref _SectionSealed, value); }

        /// <summary>
        /// </summary>
        public  SectionTimeLimit { get => _SectionTimeLimit; set => SetProperty(ref _SectionTimeLimit, value); }

        /// <summary>
        /// </summary>
        public  Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentFormSection model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemBankIdentifier = model.AssessmentItemBankIdentifier; // 
            AssessmentItemBankName = model.AssessmentItemBankName; // 
            GUID = model.GUID; // 
            Identifier = model.Identifier; // 
            PublishedDate = model.PublishedDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentFormSectionIdentificationSystemId = model.RefAssessmentFormSectionIdentificationSystemId; // 
            SectionReentry = model.SectionReentry; // 
            SectionSealed = model.SectionSealed; // 
            SectionTimeLimit = model.SectionTimeLimit; // 
            Version = model.Version; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
