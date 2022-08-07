//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IStaffEmploymentModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffEmploymentModel Interface
     /// </summary>
    public partial interface IStaffEmploymentModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the StaffEmployment.HireDate nullable property
        /// </summary>
        System.DateTime? HireDate { get; set; }

        /// <summary>
        /// Defines the StaffEmployment.PositionTitle non nullable property
        /// </summary>
        System.String PositionTitle { get; set; }

        /// <summary>
        /// Defines the StaffEmployment.UnionMembershipName non nullable property
        /// </summary>
        System.String UnionMembershipName { get; set; }

        /// <summary>
        /// Defines the StaffEmployment.WeeksEmployedPerYear nullable property
        /// </summary>
        System.Int32? WeeksEmployedPerYear { get; set; }

        /// <summary>
        /// Defines the StaffEmployment.StandardOccupationalClassification non nullable property
        /// </summary>
        System.String StandardOccupationalClassification { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentSeparationType"/> model
        /// </summary>
        Guid? RefEmploymentSeparationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentSeparationReason"/> model
        /// </summary>
        Guid? RefEmploymentSeparationReasonId { get; set; }

        /// <summary>
        /// Defines the StaffEmployment.FullTimeEquivalency nullable property
        /// </summary>
        System.Decimal? FullTimeEquivalency { get; set; }

    }
}
