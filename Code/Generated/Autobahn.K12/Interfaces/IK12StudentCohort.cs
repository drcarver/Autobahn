//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentCohort.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentCohort
     /// </summary>
    public partial interface IK12StudentCohort
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.CohortYear non nullable property
        /// </summary>
        System.String CohortYear { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.CohortGraduationYear non nullable property
        /// </summary>
        System.String CohortGraduationYear { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.GraduationRateSurveyCohortYear non nullable property
        /// </summary>
        System.String GraduationRateSurveyCohortYear { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.GraduationRateSurveyIndicator nullable property
        /// </summary>
        System.Boolean? GraduationRateSurveyIndicator { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.CohortDescription non nullable property
        /// </summary>
        System.String CohortDescription { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.RecordEndDateTime nullable property
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
