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
        /// The complete <see cref="RefStandardizedAdmissionTest"> List
         /// </summary>
        public static List<RefStandardizedAdmissionTest> RefStandardizedAdmissionTestList = new List<RefStandardizedAdmissionTest>
        {
            new RefStandardizedAdmissionTest { Id=Guid.Parse("63e109e9-10d9-4a53-8d96-28ff62f5a19b"), Code="SAT_Reading", Description="SAT Reading", Definition="SAT Reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("1.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("ad9a557c-ff9c-428a-b5bc-f80514190189"), Code="SAT_Writing", Description="SAT Writing", Definition="SAT Writing is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("2.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("3d9595b8-7088-46fb-83d7-77e125023c73"), Code="SAT_Math", Description="SAT Math", Definition="SAT Math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("3.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("ff13c2b9-c45a-4299-9c2d-68422b157336"), Code="SAT_Total", Description="SAT Total", Definition="SAT Total is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("4.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("7ec1df7e-132e-4cea-81e5-6a191455915a"), Code="ACT_English", Description="ACT English", Definition="ACT English is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("5.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("2b49b7dc-a79a-40ac-a057-177d31c0d4f5"), Code="ACT_Math", Description="ACT Math", Definition="ACT Math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("6.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("50c29bfd-a18a-4795-a779-b3698d13bab5"), Code="ACT_Reading", Description="ACT Reading", Definition="ACT Reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("7.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("dfcd63f5-f429-4242-89db-b83bc5ffa23f"), Code="ACT_Science", Description="ACT Science", Definition="ACT Science is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("8.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("e602390a-3d21-4b6f-88e3-130529cbcde3"), Code="ACT_Composite", Description="ACT Composite", Definition="ACT Composite is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("9.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("b47dbd74-cf84-4bc9-beda-2e16e94d66c8"), Code="COMPASS_reading", Description="COMPASS reading", Definition="COMPASS reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("10.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("d3b757f7-6a45-439e-be88-df371d664011"), Code="COMPASS_writing", Description="COMPASS writing", Definition="COMPASS writing is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("11.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("2ae97c12-0466-483e-a663-f4a3f47884e4"), Code="COMPASS_math", Description="COMPASS math", Definition="COMPASS math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("12.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("a1e8ccb4-cd67-4dec-86e2-c28cf9f6ded9"), Code="Accuplacer_reading", Description="Accuplacer reading", Definition="Accuplacer reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("13.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("21b84c9e-3dba-4674-8dc8-8f28d7024a47"), Code="Accuplacer_writing", Description="Accuplacer writing", Definition="Accuplacer writing is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("14.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("2ff8a574-84b0-4dbe-b571-a0b12b9ad4b3"), Code="Accuplacer_math", Description="Accuplacer math", Definition="Accuplacer math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("15.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("d2cd4a0f-1549-45c0-8158-063b226effac"), Code="Other", Description="Other", Definition="The test type used for admissions purposes is not yet included in CEDS as a Standardized Admissions Test Type.", SortOrder=Convert.ToDecimal("100.00") },
        };

        /// <summary>
        /// The RefStandardizedAdmissionTest Pick List
         /// </summary>
        public static List<RefStandardizedAdmissionTest> RefStandardizedAdmissionTestPickList = new List<RefStandardizedAdmissionTest>
        {
            new RefStandardizedAdmissionTest { Id=Guid.Parse("63e109e9-10d9-4a53-8d96-28ff62f5a19b"), Code="SAT_Reading", Description="SAT Reading", SortOrder=Convert.ToDecimal("1.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("ad9a557c-ff9c-428a-b5bc-f80514190189"), Code="SAT_Writing", Description="SAT Writing", SortOrder=Convert.ToDecimal("2.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("3d9595b8-7088-46fb-83d7-77e125023c73"), Code="SAT_Math", Description="SAT Math", SortOrder=Convert.ToDecimal("3.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("ff13c2b9-c45a-4299-9c2d-68422b157336"), Code="SAT_Total", Description="SAT Total", SortOrder=Convert.ToDecimal("4.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("7ec1df7e-132e-4cea-81e5-6a191455915a"), Code="ACT_English", Description="ACT English", SortOrder=Convert.ToDecimal("5.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("2b49b7dc-a79a-40ac-a057-177d31c0d4f5"), Code="ACT_Math", Description="ACT Math", SortOrder=Convert.ToDecimal("6.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("50c29bfd-a18a-4795-a779-b3698d13bab5"), Code="ACT_Reading", Description="ACT Reading", SortOrder=Convert.ToDecimal("7.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("dfcd63f5-f429-4242-89db-b83bc5ffa23f"), Code="ACT_Science", Description="ACT Science", SortOrder=Convert.ToDecimal("8.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("e602390a-3d21-4b6f-88e3-130529cbcde3"), Code="ACT_Composite", Description="ACT Composite", SortOrder=Convert.ToDecimal("9.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("b47dbd74-cf84-4bc9-beda-2e16e94d66c8"), Code="COMPASS_reading", Description="COMPASS reading", SortOrder=Convert.ToDecimal("10.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("d3b757f7-6a45-439e-be88-df371d664011"), Code="COMPASS_writing", Description="COMPASS writing", SortOrder=Convert.ToDecimal("11.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("2ae97c12-0466-483e-a663-f4a3f47884e4"), Code="COMPASS_math", Description="COMPASS math", SortOrder=Convert.ToDecimal("12.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("a1e8ccb4-cd67-4dec-86e2-c28cf9f6ded9"), Code="Accuplacer_reading", Description="Accuplacer reading", SortOrder=Convert.ToDecimal("13.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("21b84c9e-3dba-4674-8dc8-8f28d7024a47"), Code="Accuplacer_writing", Description="Accuplacer writing", SortOrder=Convert.ToDecimal("14.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("2ff8a574-84b0-4dbe-b571-a0b12b9ad4b3"), Code="Accuplacer_math", Description="Accuplacer math", SortOrder=Convert.ToDecimal("15.00") },
            new RefStandardizedAdmissionTest { Id=Guid.Parse("d2cd4a0f-1549-45c0-8158-063b226effac"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("100.00") },
       };
   }
}
