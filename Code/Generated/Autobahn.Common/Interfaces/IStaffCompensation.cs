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
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefStaffCompensationSourceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StaffCompensationAnnualSupplement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? StaffCompensationBaseSalary { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StaffCompensationHealthBenefits { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StaffCompensationLongevity { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StaffCompensationOtherBenefits { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StaffCompensationRetirementBenefits { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StaffCompensationTotalBenefits { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StaffCompensationTotalSalary { get; set; }

    }
}
