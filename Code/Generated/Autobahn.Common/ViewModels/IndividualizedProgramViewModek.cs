//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramViewModel
     /// </summary>
    public partial class IndividualizedProgramViewModel : BindableBase, IIndividualizedProgram
    {
#region "Backing Fields"
        // member variable for the RefIndividualizedProgramDateType property
        private System.Int32? _RefIndividualizedProgramDateType;

        // member variable for the IndividualizedProgramDate property
        private System.DateTime? _IndividualizedProgramDate;

        // member variable for the NonInclusionMinutesPerWeek property
        private System.Int32? _NonInclusionMinutesPerWeek;

        // member variable for the InclusionMinutesPerWeek property
        private System.Int32? _InclusionMinutesPerWeek;

        // member variable for the ServicePlanDate property
        private System.DateTime? _ServicePlanDate;

        // member variable for the ServicePlanMeetingParticipants property
        private System.String _ServicePlanMeetingParticipants;

        // member variable for the ServicePlanSignedBy property
        private System.String _ServicePlanSignedBy;

        // member variable for the ServicePlanSignatureDate property
        private System.DateTime? _ServicePlanSignatureDate;

        // member variable for the ServicePlanReevaluationDate property
        private System.DateTime? _ServicePlanReevaluationDate;

        // member variable for the InclusiveSettingIndicator property
        private System.Boolean? _InclusiveSettingIndicator;

        // member variable for the ServicePlanEndDate property
        private System.DateTime? _ServicePlanEndDate;

        // member variable for the TransferOfRightsStatement property
        private System.String _TransferOfRightsStatement;

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

        public System.Int32? RefIndividualizedProgramDateType { get => _RefIndividualizedProgramDateType; set => SetProperty(ref _RefIndividualizedProgramDateType, value); }

        public System.DateTime? IndividualizedProgramDate { get => _IndividualizedProgramDate; set => SetProperty(ref _IndividualizedProgramDate, value); }

        public System.Int32? NonInclusionMinutesPerWeek { get => _NonInclusionMinutesPerWeek; set => SetProperty(ref _NonInclusionMinutesPerWeek, value); }

        public System.Int32? InclusionMinutesPerWeek { get => _InclusionMinutesPerWeek; set => SetProperty(ref _InclusionMinutesPerWeek, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramTransitionTypeId"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramTransitionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramTypeId"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramTypeId { get; set; }

        public System.DateTime? ServicePlanDate { get => _ServicePlanDate; set => SetProperty(ref _ServicePlanDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramLocationId"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramLocationId { get; set; }

        public System.String ServicePlanMeetingParticipants  { get => _ServicePlanMeetingParticipants; set => SetProperty(ref _ServicePlanMeetingParticipants, value); }

        public System.String ServicePlanSignedBy  { get => _ServicePlanSignedBy; set => SetProperty(ref _ServicePlanSignedBy, value); }

        public System.DateTime? ServicePlanSignatureDate { get => _ServicePlanSignatureDate; set => SetProperty(ref _ServicePlanSignatureDate, value); }

        public System.DateTime? ServicePlanReevaluationDate { get => _ServicePlanReevaluationDate; set => SetProperty(ref _ServicePlanReevaluationDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSupportServiceTypeId"/> model
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get; set; }

        public System.Boolean? InclusiveSettingIndicator { get => _InclusiveSettingIndicator; set => SetProperty(ref _InclusiveSettingIndicator, value); }

        public System.DateTime? ServicePlanEndDate { get => _ServicePlanEndDate; set => SetProperty(ref _ServicePlanEndDate, value); }

        public System.String TransferOfRightsStatement  { get => _TransferOfRightsStatement; set => SetProperty(ref _TransferOfRightsStatement, value); }

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
        public void Load(IIndividualizedProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefIndividualizedProgramDateType = model.RefIndividualizedProgramDateType;
            IndividualizedProgramDate = model.IndividualizedProgramDate;
            NonInclusionMinutesPerWeek = model.NonInclusionMinutesPerWeek;
            InclusionMinutesPerWeek = model.InclusionMinutesPerWeek;
            RefIndividualizedProgramTransitionTypeId = model.RefIndividualizedProgramTransitionTypeId;
            RefIndividualizedProgramTypeId = model.RefIndividualizedProgramTypeId;
            ServicePlanDate = model.ServicePlanDate;
            RefIndividualizedProgramLocationId = model.RefIndividualizedProgramLocationId;
            ServicePlanMeetingParticipants = model.ServicePlanMeetingParticipants;
            ServicePlanSignedBy = model.ServicePlanSignedBy;
            ServicePlanSignatureDate = model.ServicePlanSignatureDate;
            ServicePlanReevaluationDate = model.ServicePlanReevaluationDate;
            RefStudentSupportServiceTypeId = model.RefStudentSupportServiceTypeId;
            InclusiveSettingIndicator = model.InclusiveSettingIndicator;
            ServicePlanEndDate = model.ServicePlanEndDate;
            TransferOfRightsStatement = model.TransferOfRightsStatement;
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
