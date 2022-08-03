//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffEmployment.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffEmployment
     /// </summary>
    public partial class StaffEmployment : IStaffEmployment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the StaffEmployment.HireDate nullable property
        /// </summary>
        public System.DateTime? HireDate { get; set; }

        /// <summary>
        /// Defines the StaffEmployment.PositionTitle non nullable property
        /// </summary>
        public System.String PositionTitle { get; set; }

        /// <summary>
        /// Defines the StaffEmployment.UnionMembershipName non nullable property
        /// </summary>
        public System.String UnionMembershipName { get; set; }

        /// <summary>
        /// Defines the StaffEmployment.WeeksEmployedPerYear nullable property
        /// </summary>
        public System.Int32? WeeksEmployedPerYear { get; set; }

        /// <summary>
        /// Defines the StaffEmployment.StandardOccupationalClassification non nullable property
        /// </summary>
        public System.String StandardOccupationalClassification { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentSeparationType"/> model
        /// </summary>
        public Guid? RefEmploymentSeparationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentSeparationReason"/> model
        /// </summary>
        public Guid? RefEmploymentSeparationReasonId { get; set; }

        /// <summary>
        /// Defines the StaffEmployment.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the StaffEmployment.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the StaffEmployment.FullTimeEquivalency nullable property
        /// </summary>
        public System.Decimal? FullTimeEquivalency { get; set; }

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
