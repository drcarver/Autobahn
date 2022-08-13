//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEmploymentModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffEmployment Model
     /// </summary>
    public partial class StaffEmploymentModel : AutobahnBase, Interfaces.IStaffEmployment
    {
        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public System.Decimal? FullTimeEquivalency { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public System.DateTime? HireDate { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public System.String PositionTitle { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public Guid? RefEmploymentSeparationReasonId { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public Guid? RefEmploymentSeparationTypeId { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public System.String StandardOccupationalClassification { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public System.String UnionMembershipName { get; set; }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public System.Int32? WeeksEmployedPerYear { get; set; }

    }
}
