//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentLiteracyAssessmentViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentLiteracyAssessmentViewModel
     /// </summary>
    public partial class K12StudentLiteracyAssessmentViewModel : BindableBase, IK12StudentLiteracyAssessment
    {
#region "Backing Fields"
        // member variable for the LiteracyPreTestStatus property
        private System.Boolean? _LiteracyPreTestStatus;

        // member variable for the LiteracyPostTestStatus property
        private System.Boolean? _LiteracyPostTestStatus;

        // member variable for the LiteracyGoalMetStatus property
        private System.Boolean? _LiteracyGoalMetStatus;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.Boolean? LiteracyPreTestStatus { get => _LiteracyPreTestStatus; set => SetProperty(ref _LiteracyPreTestStatus, value); }

        public System.Boolean? LiteracyPostTestStatus { get => _LiteracyPostTestStatus; set => SetProperty(ref _LiteracyPostTestStatus, value); }

        public System.Boolean? LiteracyGoalMetStatus { get => _LiteracyGoalMetStatus; set => SetProperty(ref _LiteracyGoalMetStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLiteracyAssessmentId"/> model
        /// </summary>
        public Guid? RefLiteracyAssessmentId { get; set; }

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
        public void Load(IK12StudentLiteracyAssessment model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            LiteracyPreTestStatus = model.LiteracyPreTestStatus;
            LiteracyPostTestStatus = model.LiteracyPostTestStatus;
            LiteracyGoalMetStatus = model.LiteracyGoalMetStatus;
            RefLiteracyAssessmentId = model.RefLiteracyAssessmentId;
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
