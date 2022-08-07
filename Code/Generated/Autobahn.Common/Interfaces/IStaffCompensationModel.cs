//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IStaffCompensationModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffCompensationModel Interface
     /// </summary>
    public partial interface IStaffCompensationModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="StaffEmployment"/> model
        /// </summary>
        Guid StaffEmploymentId { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationAnnualSupplement nullable property
        /// </summary>
        System.Decimal? StaffCompensationAnnualSupplement { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationBaseSalary nullable property
        /// </summary>
        System.Decimal? StaffCompensationBaseSalary { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationHealthBenefits nullable property
        /// </summary>
        System.Decimal? StaffCompensationHealthBenefits { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationLongevity nullable property
        /// </summary>
        System.Decimal? StaffCompensationLongevity { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationOtherBenefits nullable property
        /// </summary>
        System.Decimal? StaffCompensationOtherBenefits { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationRetirementBenefits nullable property
        /// </summary>
        System.Decimal? StaffCompensationRetirementBenefits { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationTotalBenefits nullable property
        /// </summary>
        System.Decimal? StaffCompensationTotalBenefits { get; set; }

        /// <summary>
        /// Defines the StaffCompensation.StaffCompensationTotalSalary nullable property
        /// </summary>
        System.Decimal? StaffCompensationTotalSalary { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStaffCompensationSourceType"/> model
        /// </summary>
        Guid? RefStaffCompensationSourceTypeId { get; set; }

    }
}
