//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSNaturalExpenseList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIPEDSNaturalExpense Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIPEDSNaturalExpenseModel"> List
         /// </summary>
        public static List<RefIPEDSNaturalExpenseModel> RefIPEDSNaturalExpenseList = new List<RefIPEDSNaturalExpenseModel>
        {
            new RefIPEDSNaturalExpense { Id=Guid.Parse("a94e70ec-ec8a-4b9e-b237-905a1000bd1c"), Code="Benefits", Description="Benefits", Definition="Cash contributions in the form of supplementary or deferred compensation other than salary. Excludes the employee's contribution. Employee fringe benefits include retirement plans, social security taxes, medical/dental plans, guaranteed disability income protection plans, tuition plans, housing plans, unemployment compensation plans, group life insurance plans, worker's compensation plans, and other benefits in-kind with cash options.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("5170ae95-8ee0-4015-b6b6-9599da93e4f2"), Code="Depreciation", Description="Depreciation", Definition="The allocation or distribution of the cost of capital assets, less any salvage value, to expenses over the estimated useful life of the asset in a systematic and rational manner. Depreciation for the year is the amount of the allocation or distribution for the year involved.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("95ac08a5-1fb4-46c8-b317-91b067de91f7"), Code="Interest", Description="Interest", Definition="The price paid (or received) for the use of money over a period of time. Interest income is one component of investment income. Interest paid by the institution is interest expense.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("53608c5a-930b-4d94-addb-748db6053666"), Code="Operationmaintenanceofplant", Description="Operation and maintenance of plant", Definition="An expense category that includes expenses for operations established to provide service and maintenance related to campus grounds and facilities used for educational and general purposes. Specific expenses include utilities, fire protection, property insurance, and similar items. This expense does include amounts charged to auxiliary enterprises, hospitals, and independent operations. Also includes information technology expenses related to operation and maintenance of plant activities if the institution separately budgets and expenses information technology resources (otherwise these expenses are included in institutional support).", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("ab67fe45-3499-4c85-b743-aeae4f00506d"), Code="Other", Description="Other", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("47a2efbb-3fa9-43b9-aec8-da618b010291"), Code="Salarieswages", Description="Salaries and wages", Definition="Amounts paid as compensation for services to all employees - faculty, staff, part-time, full-time, regular employees, and student employees. This includes regular or periodic payment to a person for the regular or periodic performance of work or a service and payment to a person for more sporadic performance of work or a service (overtime, extra compensation, summer compensation, bonuses, sick or annual leave, etc.).", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefIPEDSNaturalExpense Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIPEDSNaturalExpenseViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIPEDSNaturalExpense { Id=Guid.Parse("a94e70ec-ec8a-4b9e-b237-905a1000bd1c"), Description="Benefits", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("5170ae95-8ee0-4015-b6b6-9599da93e4f2"), Description="Depreciation", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("95ac08a5-1fb4-46c8-b317-91b067de91f7"), Description="Interest", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("53608c5a-930b-4d94-addb-748db6053666"), Description="Operation and maintenance of plant", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("ab67fe45-3499-4c85-b743-aeae4f00506d"), Description="Other", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSNaturalExpense { Id=Guid.Parse("47a2efbb-3fa9-43b9-aec8-da618b010291"), Description="Salaries and wages", SortOrder=Convert.ToDecimal("") },
       };
   }
}
