//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IndividualizedProgram Model
     /// </summary>
    public partial class IndividualizedProgramModel : AutobahnBase, Interfaces.IIndividualizedProgram
    {
        /// <summary>
        /// Individualized Program Inclusion Minutes Per Week
        /// <para>
        /// The number of minutes per week that a student with disabilities is served in a special education setting separate from his or her non-disabled peers.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20199">Individualized Program Inclusion Minutes Per Week</a>
        /// </para>
        /// </summary>
        public System.Int32? InclusionMinutesPerWeek { get; set; }

        /// <summary>
        /// Inclusive Setting Indicator
        /// <para>
        /// Indicates that services are provided to the child in a place where children of all abilities learn together.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20615">Inclusive Setting Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// Individualized Program Date
        /// <para>
        /// The year, month and day on which the status of an individualized program for a student is significantly altered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20197">Individualized Program Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? IndividualizedProgramDate { get; set; }

        /// <summary>
        /// Individualized Program NonInclusion Minutes Per Week
        /// <para>
        /// The number of minutes per week that a student with disabilities is served in a regular classroom with his or her non-disabled peers.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20198">Individualized Program NonInclusion Minutes Per Week</a>
        /// </para>
        /// </summary>
        public System.Int32? NonInclusionMinutesPerWeek { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Individualized Program Service Plan Date Type
        /// <para>
        /// An indication of the significance of a date to an individualized program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20196">Individualized Program Service Plan Date Type</a>
        /// </para>
        /// </summary>
        public System.Int32? RefIndividualizedProgramDateType { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIndividualizedProgramLocation"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramLocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIndividualizedProgramTransitionType"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramTransitionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIndividualizedProgramType"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefStudentSupportServiceType"/> model
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get; set; }

        /// <summary>
        /// Individualized Program Service Plan Date
        /// <para>
        /// The year, month and day on which the status of the service plan for a child is established or significantly altered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20201">Individualized Program Service Plan Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? ServicePlanDate { get; set; }

        /// <summary>
        /// Individualized Program Service Plan End Date
        /// <para>
        /// The year, month and day on which the status of the service plan for a child effectively ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20664">Individualized Program Service Plan End Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? ServicePlanEndDate { get; set; }

        /// <summary>
        /// Individualized Program Service Plan Meeting Participants
        /// <para>
        /// The position titles of individuals who attend the service plan meeting.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20203">Individualized Program Service Plan Meeting Participants</a>
        /// </para>
        /// </summary>
        public System.String ServicePlanMeetingParticipants { get; set; }

        /// <summary>
        /// Individualized Program Service Plan Reevaluation Date
        /// <para>
        /// Date student will be reevaluated for continued placement in a support program(s).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20207">Individualized Program Service Plan Reevaluation Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? ServicePlanReevaluationDate { get; set; }

        /// <summary>
        /// Individualized Program Service Plan Signature Date
        /// <para>
        /// The year, month and day on which the service plan document is signed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20205">Individualized Program Service Plan Signature Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? ServicePlanSignatureDate { get; set; }

        /// <summary>
        /// Individualized Program Service Plan Signed By
        /// <para>
        /// The position titles of individuals who sign a written service plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20204">Individualized Program Service Plan Signed By</a>
        /// </para>
        /// </summary>
        public System.String ServicePlanSignedBy { get; set; }

        /// <summary>
        /// IEP Transfer of Rights Statement
        /// <para>
        /// Beginning not later than one year before the child reaches the age of majority under State law, the IEP must include a statement that the child has been informed of the child's rights under Part B of the Individuals with Disabilities Education Act, if any, that will transfer to the child on reaching the age of majority under 300.520.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20663">IEP Transfer of Rights Statement</a>
        /// </para>
        /// </summary>
        public System.String TransferOfRightsStatement { get; set; }

    }
}
