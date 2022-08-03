//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentLiteracyAssessment.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentLiteracyAssessment
     /// </summary>
    public partial class K12StudentLiteracyAssessment : IK12StudentLiteracyAssessment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentLiteracyAssessment.LiteracyPreTestStatus nullable property
        /// </summary>
        public System.Boolean? LiteracyPreTestStatus { get; set; }

        /// <summary>
        /// Defines the K12StudentLiteracyAssessment.LiteracyPostTestStatus nullable property
        /// </summary>
        public System.Boolean? LiteracyPostTestStatus { get; set; }

        /// <summary>
        /// Defines the K12StudentLiteracyAssessment.LiteracyGoalMetStatus nullable property
        /// </summary>
        public System.Boolean? LiteracyGoalMetStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLiteracyAssessment"/> model
        /// </summary>
        public Guid? RefLiteracyAssessmentId { get; set; }

        /// <summary>
        /// Defines the K12StudentLiteracyAssessment.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12StudentLiteracyAssessment.RecordEndDateTime nullable property
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
