//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgram View Model
     /// </summary>
    public partial class IndividualizedProgramViewModel : ViewModelBase, Interfaces.IIndividualizedProgram
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgram";

        // InclusionMinutesPerWeek -- (backing property for Individualized Program Inclusion Minutes Per Week)
        private System.Int32? _InclusionMinutesPerWeek;

        // InclusiveSettingIndicator -- (backing property for Inclusive Setting Indicator)
        private System.Boolean? _InclusiveSettingIndicator;

        // IndividualizedProgramDate -- (backing property for Individualized Program Date)
        private System.DateTime? _IndividualizedProgramDate;

        // NonInclusionMinutesPerWeek -- (backing property for Individualized Program NonInclusion Minutes Per Week)
        private System.Int32? _NonInclusionMinutesPerWeek;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefIndividualizedProgramDateType -- (backing property for Individualized Program Service Plan Date Type)
        private System.Int32? _RefIndividualizedProgramDateType;

        // RefIndividualizedProgramLocationId -- (backing property for Individualized Program Service Plan Meeting Location)
        private Guid? _RefIndividualizedProgramLocationId;

        // RefIndividualizedProgramTransitionTypeId -- (backing property for Individualized Program Transition Plan Type)
        private Guid? _RefIndividualizedProgramTransitionTypeId;

        // RefIndividualizedProgramTypeId -- (backing property for Individualized Program Type)
        private Guid? _RefIndividualizedProgramTypeId;

        // RefStudentSupportServiceTypeId -- (backing property for Student Support Service Type)
        private Guid? _RefStudentSupportServiceTypeId;

        // ServicePlanDate -- (backing property for Individualized Program Service Plan Date)
        private System.DateTime? _ServicePlanDate;

        // ServicePlanEndDate -- (backing property for Individualized Program Service Plan End Date)
        private System.DateTime? _ServicePlanEndDate;

        // ServicePlanMeetingParticipants -- (backing property for Individualized Program Service Plan Meeting Participants)
        private System.String _ServicePlanMeetingParticipants;

        // ServicePlanReevaluationDate -- (backing property for Individualized Program Service Plan Reevaluation Date)
        private System.DateTime? _ServicePlanReevaluationDate;

        // ServicePlanSignatureDate -- (backing property for Individualized Program Service Plan Signature Date)
        private System.DateTime? _ServicePlanSignatureDate;

        // ServicePlanSignedBy -- (backing property for Individualized Program Service Plan Signed By)
        private System.String _ServicePlanSignedBy;

        // TransferOfRightsStatement -- (backing property for IEP Transfer of Rights Statement)
        private System.String _TransferOfRightsStatement;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Individualized Program Inclusion Minutes Per Week
        /// <para>
        /// The number of minutes per week that a student with disabilities is served in a special education setting separate from his or her non-disabled peers.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20199">Individualized Program Inclusion Minutes Per Week</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? InclusionMinutesPerWeek { get => _InclusionMinutesPerWeek; set => SetProperty(ref _InclusionMinutesPerWeek, value); }

        /// <summary>
        /// Inclusive Setting Indicator
        /// <para>
        /// Indicates that services are provided to the child in a place where children of all abilities learn together.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20615">Inclusive Setting Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? InclusiveSettingIndicator { get => _InclusiveSettingIndicator; set => SetProperty(ref _InclusiveSettingIndicator, value); }

        /// <summary>
        /// Individualized Program Date
        /// <para>
        /// The year, month and day on which the status of an individualized program for a student is significantly altered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20197">Individualized Program Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? IndividualizedProgramDate { get => _IndividualizedProgramDate; set => SetProperty(ref _IndividualizedProgramDate, value); }

        /// <summary>
        /// Individualized Program NonInclusion Minutes Per Week
        /// <para>
        /// The number of minutes per week that a student with disabilities is served in a regular classroom with his or her non-disabled peers.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20198">Individualized Program NonInclusion Minutes Per Week</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? NonInclusionMinutesPerWeek { get => _NonInclusionMinutesPerWeek; set => SetProperty(ref _NonInclusionMinutesPerWeek, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Individualized Program Service Plan Date Type
        /// <para>
        /// An indication of the significance of a date to an individualized program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20196">Individualized Program Service Plan Date Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? RefIndividualizedProgramDateType { get => _RefIndividualizedProgramDateType; set => SetProperty(ref _RefIndividualizedProgramDateType, value); }

        /// <summary>
        /// Individualized Program Service Plan Meeting Location
        /// <para>
        /// The place in which a child's service plan meeting is held.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20202">Individualized Program Service Plan Meeting Location</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIndividualizedProgramLocationId { get => _RefIndividualizedProgramLocationId; set => SetProperty(ref _RefIndividualizedProgramLocationId, value); }

        /// <summary>
        /// Individualized Program Transition Plan Type
        /// <para>
        /// The post-school transition plan for the student recorded on their Individualized Education Program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20200">Individualized Program Transition Plan Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIndividualizedProgramTransitionTypeId { get => _RefIndividualizedProgramTransitionTypeId; set => SetProperty(ref _RefIndividualizedProgramTransitionTypeId, value); }

        /// <summary>
        /// Individualized Program Type
        /// <para>
        /// A designation of the type of program developed for a student.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19320">Individualized Program Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIndividualizedProgramTypeId { get => _RefIndividualizedProgramTypeId; set => SetProperty(ref _RefIndividualizedProgramTypeId, value); }

        /// <summary>
        /// Student Support Service Type
        /// <para>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19273">Student Support Service Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get => _RefStudentSupportServiceTypeId; set => SetProperty(ref _RefStudentSupportServiceTypeId, value); }

        /// <summary>
        /// Individualized Program Service Plan Date
        /// <para>
        /// The year, month and day on which the status of the service plan for a child is established or significantly altered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20201">Individualized Program Service Plan Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ServicePlanDate { get => _ServicePlanDate; set => SetProperty(ref _ServicePlanDate, value); }

        /// <summary>
        /// Individualized Program Service Plan End Date
        /// <para>
        /// The year, month and day on which the status of the service plan for a child effectively ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20664">Individualized Program Service Plan End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ServicePlanEndDate { get => _ServicePlanEndDate; set => SetProperty(ref _ServicePlanEndDate, value); }

        /// <summary>
        /// Individualized Program Service Plan Meeting Participants
        /// <para>
        /// The position titles of individuals who attend the service plan meeting.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20203">Individualized Program Service Plan Meeting Participants</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ServicePlanMeetingParticipants { get => _ServicePlanMeetingParticipants; set => SetProperty(ref _ServicePlanMeetingParticipants, value); }

        /// <summary>
        /// Individualized Program Service Plan Reevaluation Date
        /// <para>
        /// Date student will be reevaluated for continued placement in a support program(s).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20207">Individualized Program Service Plan Reevaluation Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ServicePlanReevaluationDate { get => _ServicePlanReevaluationDate; set => SetProperty(ref _ServicePlanReevaluationDate, value); }

        /// <summary>
        /// Individualized Program Service Plan Signature Date
        /// <para>
        /// The year, month and day on which the service plan document is signed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20205">Individualized Program Service Plan Signature Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ServicePlanSignatureDate { get => _ServicePlanSignatureDate; set => SetProperty(ref _ServicePlanSignatureDate, value); }

        /// <summary>
        /// Individualized Program Service Plan Signed By
        /// <para>
        /// The position titles of individuals who sign a written service plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20204">Individualized Program Service Plan Signed By</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ServicePlanSignedBy { get => _ServicePlanSignedBy; set => SetProperty(ref _ServicePlanSignedBy, value); }

        /// <summary>
        /// IEP Transfer of Rights Statement
        /// <para>
        /// Beginning not later than one year before the child reaches the age of majority under State law, the IEP must include a statement that the child has been informed of the child's rights under Part B of the Individuals with Disabilities Education Act, if any, that will transfer to the child on reaching the age of majority under 300.520.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20663">IEP Transfer of Rights Statement</a>
        /// </para>
        /// </summary>
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
            InclusionMinutesPerWeek = model.InclusionMinutesPerWeek; // Individualized Program Inclusion Minutes Per Week
            InclusiveSettingIndicator = model.InclusiveSettingIndicator; // Inclusive Setting Indicator
            IndividualizedProgramDate = model.IndividualizedProgramDate; // Individualized Program Date
            NonInclusionMinutesPerWeek = model.NonInclusionMinutesPerWeek; // Individualized Program NonInclusion Minutes Per Week
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefIndividualizedProgramDateType = model.RefIndividualizedProgramDateType; // Individualized Program Service Plan Date Type
            RefIndividualizedProgramLocationId = model.RefIndividualizedProgramLocationId; // Individualized Program Service Plan Meeting Location
            RefIndividualizedProgramTransitionTypeId = model.RefIndividualizedProgramTransitionTypeId; // Individualized Program Transition Plan Type
            RefIndividualizedProgramTypeId = model.RefIndividualizedProgramTypeId; // Individualized Program Type
            RefStudentSupportServiceTypeId = model.RefStudentSupportServiceTypeId; // Student Support Service Type
            ServicePlanDate = model.ServicePlanDate; // Individualized Program Service Plan Date
            ServicePlanEndDate = model.ServicePlanEndDate; // Individualized Program Service Plan End Date
            ServicePlanMeetingParticipants = model.ServicePlanMeetingParticipants; // Individualized Program Service Plan Meeting Participants
            ServicePlanReevaluationDate = model.ServicePlanReevaluationDate; // Individualized Program Service Plan Reevaluation Date
            ServicePlanSignatureDate = model.ServicePlanSignatureDate; // Individualized Program Service Plan Signature Date
            ServicePlanSignedBy = model.ServicePlanSignedBy; // Individualized Program Service Plan Signed By
            TransferOfRightsStatement = model.TransferOfRightsStatement; // IEP Transfer of Rights Statement
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
