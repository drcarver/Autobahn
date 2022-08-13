//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffCompensationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffCompensation Model
     /// </summary>
    public partial class StaffCompensationModel : AutobahnBase, Interfaces.IStaffCompensation
    {
        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        public Guid? RefStaffCompensationSourceTypeId { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        public System.Decimal? StaffCompensationAnnualSupplement { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        public System.Decimal? StaffCompensationBaseSalary { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        public System.Decimal? StaffCompensationHealthBenefits { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        public System.Decimal? StaffCompensationLongevity { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        public System.Decimal? StaffCompensationOtherBenefits { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        public System.Decimal? StaffCompensationRetirementBenefits { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        public System.Decimal? StaffCompensationTotalBenefits { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        public System.Decimal? StaffCompensationTotalSalary { get; set; }

        /// <summary>
        /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
        /// </summary>
        public Guid StaffEmploymentId { get; set; }

    }
}
