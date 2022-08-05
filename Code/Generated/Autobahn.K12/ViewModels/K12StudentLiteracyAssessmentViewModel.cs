//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentLiteracyAssessmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentLiteracyAssessmentViewModel
     /// </summary>
    public partial class K12StudentLiteracyAssessmentViewModel : ViewModelBase, Interfaces.IK12StudentLiteracyAssessment
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentLiteracyAssessment";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the LiteracyPreTestStatus property
        private System.Boolean? _LiteracyPreTestStatus;

        // member variable for the LiteracyPostTestStatus property
        private System.Boolean? _LiteracyPostTestStatus;

        // member variable for the LiteracyGoalMetStatus property
        private System.Boolean? _LiteracyGoalMetStatus;

        // member variable for the RefLiteracyAssessmentId property
        private Guid? _RefLiteracyAssessmentId;

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
        /// The title of the K12StudentLiteracyAssessmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Boolean? LiteracyPreTestStatus { get => _LiteracyPreTestStatus; set => SetProperty(ref _LiteracyPreTestStatus, value); }

        public System.Boolean? LiteracyPostTestStatus { get => _LiteracyPostTestStatus; set => SetProperty(ref _LiteracyPostTestStatus, value); }

        public System.Boolean? LiteracyGoalMetStatus { get => _LiteracyGoalMetStatus; set => SetProperty(ref _LiteracyGoalMetStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLiteracyAssessmentId"/> model
        /// </summary>
        public Guid? RefLiteracyAssessmentId { get => _RefLiteracyAssessmentId; set => SetProperty(ref _RefLiteracyAssessmentId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentLiteracyAssessment model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            LiteracyPreTestStatus = model.LiteracyPreTestStatus;
            LiteracyPostTestStatus = model.LiteracyPostTestStatus;
            LiteracyGoalMetStatus = model.LiteracyGoalMetStatus;
            RefLiteracyAssessmentId = model.RefLiteracyAssessmentId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
