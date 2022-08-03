//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefAssessmentSessionStaffRoleType.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IRefAssessmentSessionStaffRoleType
     /// </summary>
    public partial interface IRefAssessmentSessionStaffRoleType
    {
        /// <summary>
        /// Defines the RefAssessmentSessionStaffRoleType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAssessmentSessionStaffRoleType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAssessmentSessionStaffRoleType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAssessmentSessionStaffRoleType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAssessmentSessionStaffRoleType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAssessmentSessionStaffRoleType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
