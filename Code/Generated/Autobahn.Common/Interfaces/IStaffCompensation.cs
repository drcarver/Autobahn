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
        System.Decimal? StaffCompensationBaseSalary { get; set; }

    }
}
