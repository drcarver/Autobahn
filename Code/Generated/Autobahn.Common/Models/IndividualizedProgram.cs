//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgram.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgram
     /// </summary>
    public partial class IndividualizedProgram : IIndividualizedProgram
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.RefIndividualizedProgramDateType nullable property
        /// </summary>
        public System.Int32? RefIndividualizedProgramDateType { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.IndividualizedProgramDate nullable property
        /// </summary>
        public System.DateTime? IndividualizedProgramDate { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.NonInclusionMinutesPerWeek nullable property
        /// </summary>
        public System.Int32? NonInclusionMinutesPerWeek { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.InclusionMinutesPerWeek nullable property
        /// </summary>
        public System.Int32? InclusionMinutesPerWeek { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramTransitionType"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramTransitionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramType"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramTypeId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.ServicePlanDate nullable property
        /// </summary>
        public System.DateTime? ServicePlanDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramLocation"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramLocationId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.ServicePlanMeetingParticipants non nullable property
        /// </summary>
        public System.String ServicePlanMeetingParticipants { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.ServicePlanSignedBy non nullable property
        /// </summary>
        public System.String ServicePlanSignedBy { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.ServicePlanSignatureDate nullable property
        /// </summary>
        public System.DateTime? ServicePlanSignatureDate { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.ServicePlanReevaluationDate nullable property
        /// </summary>
        public System.DateTime? ServicePlanReevaluationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSupportServiceType"/> model
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.InclusiveSettingIndicator nullable property
        /// </summary>
        public System.Boolean? InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.ServicePlanEndDate nullable property
        /// </summary>
        public System.DateTime? ServicePlanEndDate { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.TransferOfRightsStatement non nullable property
        /// </summary>
        public System.String TransferOfRightsStatement { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
