//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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
        private System.Int32? _InclusionMinutesPerWeek;

        // member variable for the InclusiveSettingIndicator property
        private System.Boolean? _InclusiveSettingIndicator;

        // member variable for the IndividualizedProgramDate property
        private System.DateTime? _IndividualizedProgramDate;

        // member variable for the NonInclusionMinutesPerWeek property
        private System.Int32? _NonInclusionMinutesPerWeek;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefIndividualizedProgramDateType property
        private System.Int32? _RefIndividualizedProgramDateType;

        // member variable for the RefIndividualizedProgramLocationId property
        private Guid? _RefIndividualizedProgramLocationId;

        // member variable for the RefIndividualizedProgramTransitionTypeId property
        private Guid? _RefIndividualizedProgramTransitionTypeId;

        // member variable for the RefIndividualizedProgramTypeId property
        private Guid? _RefIndividualizedProgramTypeId;

        // member variable for the RefStudentSupportServiceTypeId property
        private Guid? _RefStudentSupportServiceTypeId;

        // member variable for the ServicePlanDate property
        private System.DateTime? _ServicePlanDate;

        // member variable for the ServicePlanEndDate property
        private System.DateTime? _ServicePlanEndDate;

        // member variable for the ServicePlanMeetingParticipants property
        private System.String _ServicePlanMeetingParticipants;

        // member variable for the ServicePlanReevaluationDate property
        private System.DateTime? _ServicePlanReevaluationDate;

        // member variable for the ServicePlanSignatureDate property
        private System.DateTime? _ServicePlanSignatureDate;

        // member variable for the ServicePlanSignedBy property
        private System.String _ServicePlanSignedBy;

        // member variable for the TransferOfRightsStatement property
        private System.String _TransferOfRightsStatement;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        public System.Int32? InclusionMinutesPerWeek { get => _InclusionMinutesPerWeek; set => SetProperty(ref _InclusionMinutesPerWeek, value); }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        public System.Boolean? InclusiveSettingIndicator { get => _InclusiveSettingIndicator; set => SetProperty(ref _InclusiveSettingIndicator, value); }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        public System.DateTime? IndividualizedProgramDate { get => _IndividualizedProgramDate; set => SetProperty(ref _IndividualizedProgramDate, value); }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        public System.Int32? NonInclusionMinutesPerWeek { get => _NonInclusionMinutesPerWeek; set => SetProperty(ref _NonInclusionMinutesPerWeek, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        public System.Int32? RefIndividualizedProgramDateType { get => _RefIndividualizedProgramDateType; set => SetProperty(ref _RefIndividualizedProgramDateType, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramLocation"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramLocationId { get => _RefIndividualizedProgramLocationId; set => SetProperty(ref _RefIndividualizedProgramLocationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramTransitionType"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramTransitionTypeId { get => _RefIndividualizedProgramTransitionTypeId; set => SetProperty(ref _RefIndividualizedProgramTransitionTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramType"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramTypeId { get => _RefIndividualizedProgramTypeId; set => SetProperty(ref _RefIndividualizedProgramTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSupportServiceType"/> model
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get => _RefStudentSupportServiceTypeId; set => SetProperty(ref _RefStudentSupportServiceTypeId, value); }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        public System.DateTime? ServicePlanDate { get => _ServicePlanDate; set => SetProperty(ref _ServicePlanDate, value); }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        public System.DateTime? ServicePlanEndDate { get => _ServicePlanEndDate; set => SetProperty(ref _ServicePlanEndDate, value); }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        public System.String ServicePlanMeetingParticipants { get => _ServicePlanMeetingParticipants; set => SetProperty(ref _ServicePlanMeetingParticipants, value); }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        public System.DateTime? ServicePlanReevaluationDate { get => _ServicePlanReevaluationDate; set => SetProperty(ref _ServicePlanReevaluationDate, value); }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        public System.DateTime? ServicePlanSignatureDate { get => _ServicePlanSignatureDate; set => SetProperty(ref _ServicePlanSignatureDate, value); }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        public System.String ServicePlanSignedBy { get => _ServicePlanSignedBy; set => SetProperty(ref _ServicePlanSignedBy, value); }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        public System.String TransferOfRightsStatement { get => _TransferOfRightsStatement; set => SetProperty(ref _TransferOfRightsStatement, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            InclusionMinutesPerWeek = model.InclusionMinutesPerWeek;
            InclusiveSettingIndicator = model.InclusiveSettingIndicator;
            IndividualizedProgramDate = model.IndividualizedProgramDate;
            NonInclusionMinutesPerWeek = model.NonInclusionMinutesPerWeek;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefIndividualizedProgramDateType = model.RefIndividualizedProgramDateType;
            RefIndividualizedProgramLocationId = model.RefIndividualizedProgramLocationId;
            RefIndividualizedProgramTransitionTypeId = model.RefIndividualizedProgramTransitionTypeId;
            RefIndividualizedProgramTypeId = model.RefIndividualizedProgramTypeId;
            RefStudentSupportServiceTypeId = model.RefStudentSupportServiceTypeId;
            ServicePlanDate = model.ServicePlanDate;
            ServicePlanEndDate = model.ServicePlanEndDate;
            ServicePlanMeetingParticipants = model.ServicePlanMeetingParticipants;
            ServicePlanReevaluationDate = model.ServicePlanReevaluationDate;
            ServicePlanSignatureDate = model.ServicePlanSignatureDate;
            ServicePlanSignedBy = model.ServicePlanSignedBy;
            TransferOfRightsStatement = model.TransferOfRightsStatement;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
