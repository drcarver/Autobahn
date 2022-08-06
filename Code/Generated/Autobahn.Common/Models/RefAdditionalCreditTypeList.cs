//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAdditionalCreditTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAdditionalCreditType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAdditionalCreditType"> List
         /// </summary>
        public static List<RefAdditionalCreditType> RefAdditionalCreditTypeList = new List<RefAdditionalCreditType>
        {
            new RefAdditionalCreditType { Id=Guid.Parse("30582d4e-fc8d-414f-bb9b-17afe432060b"), Code="AdvancedPlacement", Description="Advanced Placement", Definition="Advanced Placement is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("0.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("a17aa31f-dd1f-45cc-a001-2835a0c808a4"), Code="ApprenticeshipCredit", Description="Apprenticeship Credit", Definition="Apprenticeship Credit is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("93e1b562-8312-43b6-9e6d-5d93e7a403a2"), Code="CTE", Description="Career and Technical Education", Definition="Career and Technical Education is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("eca5ef45-58a1-40c7-870c-9f0cd1bfce2a"), Code="DualCredit", Description="Dual Credit", Definition="Dual Credit is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("be7879ae-3414-44d9-be55-e720d890fdf0"), Code="InternationalBaccalaureate", Description="International Baccalaureate", Definition="International Baccalaureate is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("73f93e5b-3c3f-4e7d-b483-a648202a0036"), Code="Other", Description="Other", Definition="Other is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("a6cb30db-9f61-410a-af7f-76a69e4d31fd"), Code="QualifiedAdmission", Description="Qualified Admission", Definition="Qualified Admission is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("106cdc80-aef5-4772-826d-cb2ffa6cef90"), Code="STEM", Description="Science, Technology, Engineering and Mathematics", Definition="Science, Technology, Engineering and Mathematics is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("14.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("44a818f2-6f4c-41eb-93f7-f4b2edaf5b5c"), Code="CTEAndAcademic", Description="Simultaneous CTE and Academic Credit", Definition="Simultaneous CTE and Academic Credit is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("16.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("079175a0-5c25-434f-be14-0388c0303b87"), Code="StateScholarship", Description="State Scholarship", Definition="State Scholarship is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("18.00") },
        };

        /// <summary>
        /// The RefAdditionalCreditType Pick List
         /// </summary>
        public static List<RefAdditionalCreditType> RefAdditionalCreditTypePickList = new List<RefAdditionalCreditType>
        {
            new RefAdditionalCreditType { Id=Guid.Parse("30582d4e-fc8d-414f-bb9b-17afe432060b"), Code="AdvancedPlacement", Description="Advanced Placement", SortOrder=Convert.ToDecimal("0.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("a17aa31f-dd1f-45cc-a001-2835a0c808a4"), Code="ApprenticeshipCredit", Description="Apprenticeship Credit", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("93e1b562-8312-43b6-9e6d-5d93e7a403a2"), Code="CTE", Description="Career and Technical Education", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("eca5ef45-58a1-40c7-870c-9f0cd1bfce2a"), Code="DualCredit", Description="Dual Credit", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("be7879ae-3414-44d9-be55-e720d890fdf0"), Code="InternationalBaccalaureate", Description="International Baccalaureate", SortOrder=Convert.ToDecimal("4.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("73f93e5b-3c3f-4e7d-b483-a648202a0036"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("a6cb30db-9f61-410a-af7f-76a69e4d31fd"), Code="QualifiedAdmission", Description="Qualified Admission", SortOrder=Convert.ToDecimal("10.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("106cdc80-aef5-4772-826d-cb2ffa6cef90"), Code="STEM", Description="Science, Technology, Engineering and Mathematics", SortOrder=Convert.ToDecimal("14.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("44a818f2-6f4c-41eb-93f7-f4b2edaf5b5c"), Code="CTEAndAcademic", Description="Simultaneous CTE and Academic Credit", SortOrder=Convert.ToDecimal("16.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("079175a0-5c25-434f-be14-0388c0303b87"), Code="StateScholarship", Description="State Scholarship", SortOrder=Convert.ToDecimal("18.00") },
       };
   }
}
