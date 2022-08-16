//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramViewModel
     /// </summary>
    public partial class IndividualizedProgramViewModel : ViewModelBase, Interfaces.IIndividualizedProgram
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgram";

        // member variable for the InclusionMinutesPerWeek property
        private  _InclusionMinutesPerWeek;

        // member variable for the InclusiveSettingIndicator property
        private  _InclusiveSettingIndicator;

        // member variable for the IndividualizedProgramDate property
        private  _IndividualizedProgramDate;

        // member variable for the NonInclusionMinutesPerWeek property
        private  _NonInclusionMinutesPerWeek;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefIndividualizedProgramDateType property
        private  _RefIndividualizedProgramDateType;

        // member variable for the RefIndividualizedProgramLocationId property
        private  _RefIndividualizedProgramLocationId;

        // member variable for the RefIndividualizedProgramTransitionTypeId property
        private  _RefIndividualizedProgramTransitionTypeId;

        // member variable for the RefIndividualizedProgramTypeId property
        private  _RefIndividualizedProgramTypeId;

        // member variable for the RefStudentSupportServiceTypeId property
        private Guid? _RefStudentSupportServiceTypeId;

        // member variable for the ServicePlanDate property
        private  _ServicePlanDate;

        // member variable for the ServicePlanEndDate property
        private  _ServicePlanEndDate;

        // member variable for the ServicePlanMeetingParticipants property
        private  _ServicePlanMeetingParticipants;

        // member variable for the ServicePlanReevaluationDate property
        private  _ServicePlanReevaluationDate;

        // member variable for the ServicePlanSignatureDate property
        private  _ServicePlanSignatureDate;

        // member variable for the ServicePlanSignedBy property
        private  _ServicePlanSignedBy;

        // member variable for the TransferOfRightsStatement property
        private  _TransferOfRightsStatement;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  InclusionMinutesPerWeek { get => _InclusionMinutesPerWeek; set => SetProperty(ref _InclusionMinutesPerWeek, value); }

        /// <summary>
        /// </summary>
        public  InclusiveSettingIndicator { get => _InclusiveSettingIndicator; set => SetProperty(ref _InclusiveSettingIndicator, value); }

        /// <summary>
        /// </summary>
        public  IndividualizedProgramDate { get => _IndividualizedProgramDate; set => SetProperty(ref _IndividualizedProgramDate, value); }

        /// <summary>
        /// </summary>
        public  NonInclusionMinutesPerWeek { get => _NonInclusionMinutesPerWeek; set => SetProperty(ref _NonInclusionMinutesPerWeek, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  RefIndividualizedProgramDateType { get => _RefIndividualizedProgramDateType; set => SetProperty(ref _RefIndividualizedProgramDateType, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramLocation"/> model
        /// </summary>
        public  RefIndividualizedProgramLocationId { get => _RefIndividualizedProgramLocationId; set => SetProperty(ref _RefIndividualizedProgramLocationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramTransitionType"/> model
        /// </summary>
        public  RefIndividualizedProgramTransitionTypeId { get => _RefIndividualizedProgramTransitionTypeId; set => SetProperty(ref _RefIndividualizedProgramTransitionTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramType"/> model
        /// </summary>
        public  RefIndividualizedProgramTypeId { get => _RefIndividualizedProgramTypeId; set => SetProperty(ref _RefIndividualizedProgramTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSupportServiceType"/> model
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get => _RefStudentSupportServiceTypeId; set => SetProperty(ref _RefStudentSupportServiceTypeId, value); }

        /// <summary>
        /// </summary>
        public  ServicePlanDate { get => _ServicePlanDate; set => SetProperty(ref _ServicePlanDate, value); }

        /// <summary>
        /// </summary>
        public  ServicePlanEndDate { get => _ServicePlanEndDate; set => SetProperty(ref _ServicePlanEndDate, value); }

        /// <summary>
        /// </summary>
        public  ServicePlanMeetingParticipants { get => _ServicePlanMeetingParticipants; set => SetProperty(ref _ServicePlanMeetingParticipants, value); }

        /// <summary>
        /// </summary>
        public  ServicePlanReevaluationDate { get => _ServicePlanReevaluationDate; set => SetProperty(ref _ServicePlanReevaluationDate, value); }

        /// <summary>
        /// </summary>
        public  ServicePlanSignatureDate { get => _ServicePlanSignatureDate; set => SetProperty(ref _ServicePlanSignatureDate, value); }

        /// <summary>
        /// </summary>
        public  ServicePlanSignedBy { get => _ServicePlanSignedBy; set => SetProperty(ref _ServicePlanSignedBy, value); }

        /// <summary>
        /// </summary>
        public  TransferOfRightsStatement { get => _TransferOfRightsStatement; set => SetProperty(ref _TransferOfRightsStatement, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            InclusionMinutesPerWeek = model.InclusionMinutesPerWeek; // 
            InclusiveSettingIndicator = model.InclusiveSettingIndicator; // 
            IndividualizedProgramDate = model.IndividualizedProgramDate; // 
            NonInclusionMinutesPerWeek = model.NonInclusionMinutesPerWeek; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefIndividualizedProgramDateType = model.RefIndividualizedProgramDateType; // 
            RefIndividualizedProgramLocationId = model.RefIndividualizedProgramLocationId; // 
            RefIndividualizedProgramTransitionTypeId = model.RefIndividualizedProgramTransitionTypeId; // 
            RefIndividualizedProgramTypeId = model.RefIndividualizedProgramTypeId; // 
            RefStudentSupportServiceTypeId = model.RefStudentSupportServiceTypeId; // 
            ServicePlanDate = model.ServicePlanDate; // 
            ServicePlanEndDate = model.ServicePlanEndDate; // 
            ServicePlanMeetingParticipants = model.ServicePlanMeetingParticipants; // 
            ServicePlanReevaluationDate = model.ServicePlanReevaluationDate; // 
            ServicePlanSignatureDate = model.ServicePlanSignatureDate; // 
            ServicePlanSignedBy = model.ServicePlanSignedBy; // 
            TransferOfRightsStatement = model.TransferOfRightsStatement; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
