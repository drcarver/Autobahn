//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSNaturalExpenseList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIPEDSNaturalExpense Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIPEDSNaturalExpense"> List
         /// </summary>
        public static List<RefIPEDSNaturalExpense> RefIPEDSNaturalExpenseList = new List<RefIPEDSNaturalExpense>
        {
            new RefIPEDSNaturalExpense { Id=Guid.Parse("d727c2bd-6c42-4d4e-adcf-e6975d36baa9"), Code="Benefits", Description="Benefits", Definition="Cash contributions in the form of supplementary or deferred compensation other than salary. Excludes the employee's contribution. Employee fringe benefits include retirement plans, social security taxes, medical/dental plans, guaranteed disability income protection plans, tuition plans, housing plans, unemployment compensation plans, group life insurance plans, worker's compensation plans, and other benefits in-kind with cash options.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("f67e72f5-957a-457a-898d-ff6d6a07dfaa"), Code="Depreciation", Description="Depreciation", Definition="The allocation or distribution of the cost of capital assets, less any salvage value, to expenses over the estimated useful life of the asset in a systematic and rational manner. Depreciation for the year is the amount of the allocation or distribution for the year involved.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("a78213ee-0048-4ea5-9c38-18646fc2b25e"), Code="Interest", Description="Interest", Definition="The price paid (or received) for the use of money over a period of time. Interest income is one component of investment income. Interest paid by the institution is interest expense.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("750b966b-eefd-4c9c-a453-d802d17354b4"), Code="Operationmaintenanceofplant", Description="Operation and maintenance of plant", Definition="An expense category that includes expenses for operations established to provide service and maintenance related to campus grounds and facilities used for educational and general purposes. Specific expenses include utilities, fire protection, property insurance, and similar items. This expense does include amounts charged to auxiliary enterprises, hospitals, and independent operations. Also includes information technology expenses related to operation and maintenance of plant activities if the institution separately budgets and expenses information technology resources (otherwise these expenses are included in institutional support).", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("a5e618e3-73d0-47ae-9a7a-70f90dd87d94"), Code="Other", Description="Other", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("57183d6c-2dc1-4f48-be11-4174751c0477"), Code="Salarieswages", Description="Salaries and wages", Definition="Amounts paid as compensation for services to all employees - faculty, staff, part-time, full-time, regular employees, and student employees. This includes regular or periodic payment to a person for the regular or periodic performance of work or a service and payment to a person for more sporadic performance of work or a service (overtime, extra compensation, summer compensation, bonuses, sick or annual leave, etc.).", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefIPEDSNaturalExpense Pick List
         /// </summary>
        public static List<RefIPEDSNaturalExpense> RefIPEDSNaturalExpensePickList = new List<RefIPEDSNaturalExpense>
        {
            new RefIPEDSNaturalExpense { Id=Guid.Parse("d727c2bd-6c42-4d4e-adcf-e6975d36baa9"), Code="Benefits", Description="Benefits", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("f67e72f5-957a-457a-898d-ff6d6a07dfaa"), Code="Depreciation", Description="Depreciation", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("a78213ee-0048-4ea5-9c38-18646fc2b25e"), Code="Interest", Description="Interest", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("750b966b-eefd-4c9c-a453-d802d17354b4"), Code="Operationmaintenanceofplant", Description="Operation and maintenance of plant", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("a5e618e3-73d0-47ae-9a7a-70f90dd87d94"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("57183d6c-2dc1-4f48-be11-4174751c0477"), Code="Salarieswages", Description="Salaries and wages", SortOrder=Convert.ToDecimal("") },
       };
   }
}
