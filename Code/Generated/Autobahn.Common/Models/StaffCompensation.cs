//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffCompensation.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffCompensation
     /// </summary>
    public partial class StaffCompensation : AutobahnBase, Interfaces.IStaffCompensation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="StaffEmployment"/> model
        /// </summary>
        public Guid StaffEmploymentId { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationAnnualSupplement nullable property
        /// </summary>
        public System.Decimal? StaffCompensationAnnualSupplement { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationBaseSalary nullable property
        /// </summary>
        public System.Decimal? StaffCompensationBaseSalary { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationHealthBenefits nullable property
        /// </summary>
        public System.Decimal? StaffCompensationHealthBenefits { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationLongevity nullable property
        /// </summary>
        public System.Decimal? StaffCompensationLongevity { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationOtherBenefits nullable property
        /// </summary>
        public System.Decimal? StaffCompensationOtherBenefits { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationRetirementBenefits nullable property
        /// </summary>
        public System.Decimal? StaffCompensationRetirementBenefits { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationTotalBenefits nullable property
        /// </summary>
        public System.Decimal? StaffCompensationTotalBenefits { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationTotalSalary nullable property
        /// </summary>
        public System.Decimal? StaffCompensationTotalSalary { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStaffCompensationSourceType"/> model
        /// </summary>
        public Guid? RefStaffCompensationSourceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
