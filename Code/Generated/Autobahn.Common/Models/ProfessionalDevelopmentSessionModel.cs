//**********************************************************
//* DomainName: Common Models
//* FileName:   ProfessionalDevelopmentSessionModel.cs
//* Name:       Professional Development Session Capacity
//* Definition: The total number of participants that can be accommodated by a professional development session.
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The total number of participants that can be accommodated by a professional development session.
     /// </summary>
    public partial class ProfessionalDevelopmentSessionModel : AutobahnBase, Interfaces.IProfessionalDevelopmentSession
    {
        /// <summary>
        /// Professional Development Session Capacity
        /// <para>
        /// The total number of participants that can be accommodated by a professional development session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20416">Professional Development Session Capacity</a>
        /// </para>
        /// </summary>
        public System.Int32? Capacity { get; set; }

        /// <summary>
        /// Professional Development Session End Date
        /// <para>
        /// The year, month and day a professional development session ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20417">Professional Development Session End Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Professional Development Session End Time
        /// <para>
        /// The time at which a professional development session ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20418">Professional Development Session End Time</a>
        /// </para>
        /// </summary>
        public System.String EndTime { get; set; }

        /// <summary>
        /// Professional Development Session Evaluation Method
        /// <para>
        /// The method used to evaluate a professional development session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20419">Professional Development Session Evaluation Method</a>
        /// </para>
        /// </summary>
        public System.String EvaluationMethod { get; set; }

        /// <summary>
        /// Professional Development Session Evaluation Score
        /// <para>
        /// The score or rating used to determine if a professional development session was successful.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20420">Professional Development Session Evaluation Score</a>
        /// </para>
        /// </summary>
        public System.String EvaluationScore { get; set; }

        /// <summary>
        /// Professional Development Activity Expiration Date
        /// <para>
        /// The year, month, and day on which any certificate awarded as part of a professional development activity expires.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20421">Professional Development Activity Expiration Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Professional Development Funding Source
        /// <para>
        /// The primary source of funding for a professional development session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20413">Professional Development Funding Source</a>
        /// </para>
        /// </summary>
        public System.String FundingSource { get; set; }

        /// <summary>
        /// Professional Development Session Location Name
        /// <para>
        /// The name of a location where a professional development session will be held.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20424">Professional Development Session Location Name</a>
        /// </para>
        /// </summary>
        public System.String LocationName { get; set; }

        /// <summary>
        /// Professional Development Activity Code
        /// <para>
        /// A code assigned to an professional development activity by the organization offering the activity that is unique to the non-variable activity details.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20404">Professional Development Activity Code</a>
        /// </para>
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELTrainerCoreKnowledgeArea"/> model
        /// </summary>
        public Guid? RefELTrainerCoreKnowledgeAreaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDDeliveryMethod"/> model
        /// </summary>
        public Guid? RefPDDeliveryMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDInstructionalDeliveryMode"/> model
        /// </summary>
        public Guid? RefPDInstructionalDeliveryModeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDSessionStatus"/> model
        /// </summary>
        public Guid? RefPDSessionStatusId { get; set; }

        /// <summary>
        /// Professional Development Session Identifier
        /// <para>
        /// The unique, non-duplicated,  identification number assigned by the registry data system for a session of a particular professional development activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20422">Professional Development Session Identifier</a>
        /// </para>
        /// </summary>
        public System.String SessionIdentifier { get; set; }

        /// <summary>
        /// Sponsoring Agency Name
        /// <para>
        /// The name of the sponsoring agency.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20461">Sponsoring Agency Name</a>
        /// </para>
        /// </summary>
        public System.String SponsoringAgencyName { get; set; }

        /// <summary>
        /// Professional Development Session Start Date
        /// <para>
        /// The year, month, and day a professional development session begins.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20426">Professional Development Session Start Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Professional Development Session Start Time
        /// <para>
        /// The time at which a professional development session begins.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20427">Professional Development Session Start Time</a>
        /// </para>
        /// </summary>
        public System.String StartTime { get; set; }

        /// <summary>
        /// Training and Technical Assistance Level
        /// <para>
        /// The level of expertise an individual training and technical assistance specialist has based on a set of established criteria.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20609">Training and Technical Assistance Level</a>
        /// </para>
        /// </summary>
        public System.String TrainingAndTechnicalAssistanceLevel { get; set; }

    }
}
