//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentViewModel
     /// </summary>
    public partial class AssessmentViewModel : BindableBase, IAssessment
    {
#region "Backing Fields"
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

        // member variable for the Objective property
        private System.String _Objective;

        // member variable for the Provider property
        private System.String _Provider;

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

#endregion

#region Properties
        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        public System.Int32? IdentificationSystem { get => _IdentificationSystem; set => SetProperty(ref _IdentificationSystem, value); }

        public System.String GUID  { get => _GUID; set => SetProperty(ref _GUID, value); }

        public System.String Title  { get => _Title; set => SetProperty(ref _Title, value); }

        public System.String ShortName  { get => _ShortName; set => SetProperty(ref _ShortName, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAcademicSubjectId"/> model
        /// </summary>
        public Guid RefAcademicSubjectId { get; set; }

        public System.String Objective  { get => _Objective; set => SetProperty(ref _Objective, value); }

        public System.String Provider  { get => _Provider; set => SetProperty(ref _Provider, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurposeId"/> model
        /// </summary>
        public Guid? RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentTypeChildrenWithDisabilitiesId"/> model
        /// </summary>
        public Guid? RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }

        public System.DateTime? AssessmentRevisionDate { get => _AssessmentRevisionDate; set => SetProperty(ref _AssessmentRevisionDate, value); }

        public System.String AssessmentFamilyTitle  { get => _AssessmentFamilyTitle; set => SetProperty(ref _AssessmentFamilyTitle, value); }

        public System.String AssessmentFamilyShortName  { get => _AssessmentFamilyShortName; set => SetProperty(ref _AssessmentFamilyShortName, value); }

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
        public void Load(IAssessment model)
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
