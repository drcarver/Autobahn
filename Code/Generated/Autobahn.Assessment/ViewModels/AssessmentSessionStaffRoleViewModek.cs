//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSessionStaffRoleViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentSessionStaffRoleViewModel
     /// </summary>
    public partial class AssessmentSessionStaffRoleViewModel : BindableBase, IAssessmentSessionStaffRole
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionStaffRoleTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentSessionStaffRoleTypeId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSessionId"/> model
        /// </summary>
        public Guid? AssessmentSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentParticipantSessionId"/> model
        /// </summary>
        public Guid? AssessmentParticipantSessionId { get; set; }

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
        public void Load(IAssessmentSessionStaffRole model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAssessmentSessionStaffRoleTypeId = model.RefAssessmentSessionStaffRoleTypeId;
            PersonId = model.PersonId;
            AssessmentSessionId = model.AssessmentSessionId;
            AssessmentParticipantSessionId = model.AssessmentParticipantSessionId;
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
