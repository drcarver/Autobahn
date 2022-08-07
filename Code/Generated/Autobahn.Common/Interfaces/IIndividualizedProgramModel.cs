//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramModel Interface
     /// </summary>
    public partial interface IIndividualizedProgramModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.RefIndividualizedProgramDateType nullable property
        /// </summary>
        System.Int32? RefIndividualizedProgramDateType { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.IndividualizedProgramDate nullable property
        /// </summary>
        System.DateTime? IndividualizedProgramDate { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.NonInclusionMinutesPerWeek nullable property
        /// </summary>
        System.Int32? NonInclusionMinutesPerWeek { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.InclusionMinutesPerWeek nullable property
        /// </summary>
        System.Int32? InclusionMinutesPerWeek { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramTransitionType"/> model
        /// </summary>
        Guid? RefIndividualizedProgramTransitionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramType"/> model
        /// </summary>
        Guid? RefIndividualizedProgramTypeId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.ServicePlanDate nullable property
        /// </summary>
        System.DateTime? ServicePlanDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramLocation"/> model
        /// </summary>
        Guid? RefIndividualizedProgramLocationId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.ServicePlanMeetingParticipants non nullable property
        /// </summary>
        System.String ServicePlanMeetingParticipants { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.ServicePlanSignedBy non nullable property
        /// </summary>
        System.String ServicePlanSignedBy { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.ServicePlanSignatureDate nullable property
        /// </summary>
        System.DateTime? ServicePlanSignatureDate { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.ServicePlanReevaluationDate nullable property
        /// </summary>
        System.DateTime? ServicePlanReevaluationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSupportServiceType"/> model
        /// </summary>
        Guid? RefStudentSupportServiceTypeId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.InclusiveSettingIndicator nullable property
        /// </summary>
        System.Boolean? InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.ServicePlanEndDate nullable property
        /// </summary>
        System.DateTime? ServicePlanEndDate { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgram.TransferOfRightsStatement non nullable property
        /// </summary>
        System.String TransferOfRightsStatement { get; set; }

    }
}
