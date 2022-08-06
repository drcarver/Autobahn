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
        public static List<RefIPEDSNaturalExpense> RefIPEDSNaturalExpenseList = new List<RefIPEDSNaturalExpense> =
        {
            new RefIPEDSNaturalExpense { Id=Guid.Parse("6c17f539-048e-4324-89d0-70cd5963cbfc"), Code="Cash contributions in the form of supplementary or deferred compensation other than salary. Excludes the employee's contribution. Employee fringe benefits include retirement plans, social security taxes, medical/dental plans, guaranteed disability income protection plans, tuition plans, housing plans, unemployment compensation plans, group life insurance plans, worker's compensation plans, and other benefits in-kind with cash options.", Description="Benefits", Definition="", SortOrder=0 },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("73177086-c104-41a7-81ec-2f39420d89be"), Code="The allocation or distribution of the cost of capital assets, less any salvage value, to expenses over the estimated useful life of the asset in a systematic and rational manner. Depreciation for the year is the amount of the allocation or distribution for the year involved.", Description="Depreciation", Definition="", SortOrder=0 },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("fa6f32ed-536e-4d1a-a91b-468fbc8277ac"), Code="The price paid (or received) for the use of money over a period of time. Interest income is one component of investment income. Interest paid by the institution is interest expense.", Description="Interest", Definition="", SortOrder=0 },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("6b67ebbe-d5a4-484b-b592-25960cbdfd5a"), Code="An expense category that includes expenses for operations established to provide service and maintenance related to campus grounds and facilities used for educational and general purposes. Specific expenses include utilities, fire protection, property insurance, and similar items. This expense does include amounts charged to auxiliary enterprises, hospitals, and independent operations. Also includes information technology expenses related to operation and maintenance of plant activities if the institution separately budgets and expenses information technology resources (otherwise these expenses are included in institutional support).", Description="Operationmaintenanceofplant", Definition="", SortOrder=0 },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("2f468ac0-f165-44bc-a4b9-89732b61d8eb"), Code="", Description="Other", Definition="", SortOrder=0 },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("edaab92c-1cb3-4983-ae11-f7b7afa22723"), Code="Amounts paid as compensation for services to all employees - faculty, staff, part-time, full-time, regular employees, and student employees. This includes regular or periodic payment to a person for the regular or periodic performance of work or a service and payment to a person for more sporadic performance of work or a service (overtime, extra compensation, summer compensation, bonuses, sick or annual leave, etc.).", Description="Salarieswages", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIPEDSNaturalExpense Pick List
         /// </summary>
        public static List<RefIPEDSNaturalExpense> RefIPEDSNaturalExpensePickList = new List<RefIPEDSNaturalExpense> =
        {
            new RefIPEDSNaturalExpense { Id=Guid.Parse("6c17f539-048e-4324-89d0-70cd5963cbfc"), Code="Cash contributions in the form of supplementary or deferred compensation other than salary. Excludes the employee's contribution. Employee fringe benefits include retirement plans, social security taxes, medical/dental plans, guaranteed disability income protection plans, tuition plans, housing plans, unemployment compensation plans, group life insurance plans, worker's compensation plans, and other benefits in-kind with cash options.", SortOrder=0 },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("73177086-c104-41a7-81ec-2f39420d89be"), Code="The allocation or distribution of the cost of capital assets, less any salvage value, to expenses over the estimated useful life of the asset in a systematic and rational manner. Depreciation for the year is the amount of the allocation or distribution for the year involved.", SortOrder=0 },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("fa6f32ed-536e-4d1a-a91b-468fbc8277ac"), Code="The price paid (or received) for the use of money over a period of time. Interest income is one component of investment income. Interest paid by the institution is interest expense.", SortOrder=0 },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("6b67ebbe-d5a4-484b-b592-25960cbdfd5a"), Code="An expense category that includes expenses for operations established to provide service and maintenance related to campus grounds and facilities used for educational and general purposes. Specific expenses include utilities, fire protection, property insurance, and similar items. This expense does include amounts charged to auxiliary enterprises, hospitals, and independent operations. Also includes information technology expenses related to operation and maintenance of plant activities if the institution separately budgets and expenses information technology resources (otherwise these expenses are included in institutional support).", SortOrder=0 },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("2f468ac0-f165-44bc-a4b9-89732b61d8eb"), Code="", SortOrder=0 },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("edaab92c-1cb3-4983-ae11-f7b7afa22723"), Code="Amounts paid as compensation for services to all employees - faculty, staff, part-time, full-time, regular employees, and student employees. This includes regular or periodic payment to a person for the regular or periodic performance of work or a service and payment to a person for more sporadic performance of work or a service (overtime, extra compensation, summer compensation, bonuses, sick or annual leave, etc.).", SortOrder=0 },
       };
   }
}
