//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefStandardizedAdmissionTestList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefStandardizedAdmissionTest Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefStandardizedAdmissionTestModel"> List
         /// </summary>
        public static List<RefStandardizedAdmissionTestModel> RefStandardizedAdmissionTestList = new List<RefStandardizedAdmissionTestModel>
        {
            new RefStandardizedAdmissionTest { Id=Guid.Parse("e11d54b6-dc29-401e-a891-76c0acb7bf1a"), Code="SAT_Reading", Description="SAT Reading", Definition="SAT Reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("1.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("29c7c45e-85de-41fd-964b-3f1508a10f08"), Code="SAT_Writing", Description="SAT Writing", Definition="SAT Writing is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("2.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("a8106a59-2824-464c-9185-4f70d0da8e0b"), Code="SAT_Math", Description="SAT Math", Definition="SAT Math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("3.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("1e8bb09c-038c-4df2-bb42-8242cbebfa8b"), Code="SAT_Total", Description="SAT Total", Definition="SAT Total is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("4.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("f6e32ada-ce80-485d-93fa-ec4070b7ec4d"), Code="ACT_English", Description="ACT English", Definition="ACT English is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("5.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("62f39a4b-ee1e-4f28-ac92-dff5687623ca"), Code="ACT_Math", Description="ACT Math", Definition="ACT Math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("6.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("7a50cf26-a913-4356-83e6-b4ca193a82d0"), Code="ACT_Reading", Description="ACT Reading", Definition="ACT Reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("7.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("f7b6ec03-bc99-463c-8b1d-706295d4f613"), Code="ACT_Science", Description="ACT Science", Definition="ACT Science is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("8.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("2a57d0db-207d-4289-82e7-294b8443925e"), Code="ACT_Composite", Description="ACT Composite", Definition="ACT Composite is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("9.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("b15559da-00f4-4124-aa1c-b3e4001cb758"), Code="COMPASS_reading", Description="COMPASS reading", Definition="COMPASS reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("10.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("da558565-8e40-4e0b-8ac9-ae84b4755706"), Code="COMPASS_writing", Description="COMPASS writing", Definition="COMPASS writing is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("11.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("63f23810-9620-45f0-b609-00108f6aabd6"), Code="COMPASS_math", Description="COMPASS math", Definition="COMPASS math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("12.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("f5cbbba7-1eaa-4dcc-b2a0-7850b21279c2"), Code="Accuplacer_reading", Description="Accuplacer reading", Definition="Accuplacer reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("13.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("a2353e04-0ea4-4fe6-a925-872aaba04458"), Code="Accuplacer_writing", Description="Accuplacer writing", Definition="Accuplacer writing is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("14.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("0350544a-b4b6-449a-b7b9-4361d5e65afe"), Code="Accuplacer_math", Description="Accuplacer math", Definition="Accuplacer math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("15.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("01bbd0b2-50e0-4583-a2db-a21599a8dc8a"), Code="Other", Description="Other", Definition="The test type used for admissions purposes is not yet included in CEDS as a Standardized Admissions Test Type.", SortOrder=Convert.ToDecimal("100.00") },
        };

        /// <summary>
        /// The Reference RefStandardizedAdmissionTest Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefStandardizedAdmissionTestViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefStandardizedAdmissionTest { Id=Guid.Parse("e11d54b6-dc29-401e-a891-76c0acb7bf1a"), Description="SAT Reading", SortOrder=Convert.ToDecimal("1.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("29c7c45e-85de-41fd-964b-3f1508a10f08"), Description="SAT Writing", SortOrder=Convert.ToDecimal("2.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("a8106a59-2824-464c-9185-4f70d0da8e0b"), Description="SAT Math", SortOrder=Convert.ToDecimal("3.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("1e8bb09c-038c-4df2-bb42-8242cbebfa8b"), Description="SAT Total", SortOrder=Convert.ToDecimal("4.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("f6e32ada-ce80-485d-93fa-ec4070b7ec4d"), Description="ACT English", SortOrder=Convert.ToDecimal("5.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("62f39a4b-ee1e-4f28-ac92-dff5687623ca"), Description="ACT Math", SortOrder=Convert.ToDecimal("6.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("7a50cf26-a913-4356-83e6-b4ca193a82d0"), Description="ACT Reading", SortOrder=Convert.ToDecimal("7.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("f7b6ec03-bc99-463c-8b1d-706295d4f613"), Description="ACT Science", SortOrder=Convert.ToDecimal("8.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("2a57d0db-207d-4289-82e7-294b8443925e"), Description="ACT Composite", SortOrder=Convert.ToDecimal("9.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("b15559da-00f4-4124-aa1c-b3e4001cb758"), Description="COMPASS reading", SortOrder=Convert.ToDecimal("10.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("da558565-8e40-4e0b-8ac9-ae84b4755706"), Description="COMPASS writing", SortOrder=Convert.ToDecimal("11.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("63f23810-9620-45f0-b609-00108f6aabd6"), Description="COMPASS math", SortOrder=Convert.ToDecimal("12.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("f5cbbba7-1eaa-4dcc-b2a0-7850b21279c2"), Description="Accuplacer reading", SortOrder=Convert.ToDecimal("13.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("a2353e04-0ea4-4fe6-a925-872aaba04458"), Description="Accuplacer writing", SortOrder=Convert.ToDecimal("14.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("0350544a-b4b6-449a-b7b9-4361d5e65afe"), Description="Accuplacer math", SortOrder=Convert.ToDecimal("15.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("01bbd0b2-50e0-4583-a2db-a21599a8dc8a"), Description="Other", SortOrder=Convert.ToDecimal("100.00") },
       };
   }
}
