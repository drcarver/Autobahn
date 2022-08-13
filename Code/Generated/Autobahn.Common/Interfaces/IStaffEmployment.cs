//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IStaffEmployment.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffEmployment Interface
     /// </summary>
    public partial interface IStaffEmployment : IAutobahnBase
    {
        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        System.Decimal? FullTimeEquivalency { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        System.DateTime? HireDate { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        System.String PositionTitle { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        Guid? RefEmploymentSeparationReasonId { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        Guid? RefEmploymentSeparationTypeId { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        System.String StandardOccupationalClassification { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        System.String UnionMembershipName { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        System.Int32? WeeksEmployedPerYear { get; set; }

    }
}
