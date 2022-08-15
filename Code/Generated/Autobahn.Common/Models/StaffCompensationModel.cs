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
        public System.Decimal? StaffCompensationBaseSalary { get; set; }

    }
}
