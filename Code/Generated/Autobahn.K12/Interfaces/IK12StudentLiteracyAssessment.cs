//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentLiteracyAssessment.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentLiteracyAssessment
     /// </summary>
    public partial interface IK12StudentLiteracyAssessment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentLiteracyAssessment.LiteracyPreTestStatus nullable property
        /// </summary>
        System.Boolean? LiteracyPreTestStatus { get; set; }

        /// <summary>
        /// Defines the K12StudentLiteracyAssessment.LiteracyPostTestStatus nullable property
        /// </summary>
        System.Boolean? LiteracyPostTestStatus { get; set; }

        /// <summary>
        /// Defines the K12StudentLiteracyAssessment.LiteracyGoalMetStatus nullable property
        /// </summary>
        System.Boolean? LiteracyGoalMetStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLiteracyAssessment"/> model
        /// </summary>
        Guid? RefLiteracyAssessmentId { get; set; }

        /// <summary>
        /// Defines the K12StudentLiteracyAssessment.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12StudentLiteracyAssessment.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
