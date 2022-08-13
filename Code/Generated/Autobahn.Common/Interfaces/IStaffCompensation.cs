//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IStaffCompensation.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffCompensation Interface
     /// </summary>
    public partial interface IStaffCompensation : IAutobahnBase
    {
        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        Guid? RefStaffCompensationSourceTypeId { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        System.Decimal? StaffCompensationAnnualSupplement { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        System.Decimal? StaffCompensationBaseSalary { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        System.Decimal? StaffCompensationHealthBenefits { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        System.Decimal? StaffCompensationLongevity { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        System.Decimal? StaffCompensationOtherBenefits { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        System.Decimal? StaffCompensationRetirementBenefits { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        System.Decimal? StaffCompensationTotalBenefits { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        System.Decimal? StaffCompensationTotalSalary { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        Guid StaffEmploymentId { get; set; }

    }
}
