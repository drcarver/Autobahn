//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCareerEducationPlanTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCareerEducationPlanType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCareerEducationPlanType"> List
         /// </summary>
        public static List<RefCareerEducationPlanType> RefCareerEducationPlanTypeList = new List<RefCareerEducationPlanType>
        {
            new RefCareerEducationPlanType { Id=Guid.Parse("6fac87d5-4bb5-4d39-82b8-58dfbd6b0e97"), Code="Education", Description="Education plan", Definition="An individualized guidance and counseling plan for education.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCareerEducationPlanType { Id=Guid.Parse("d3a80253-c42e-4c20-baee-c73d3437ff12"), Code="Career", Description="Career plan", Definition="An individualized guidance and counseling plan for career.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCareerEducationPlanType { Id=Guid.Parse("cd15b356-a2d3-430d-b1b5-d4eb72bc9725"), Code="Both", Description="Both education and career plan", Definition="An individualized guidance and counseling plan for both career and education.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCareerEducationPlanType { Id=Guid.Parse("e33109e3-293a-4164-a923-0a9ce0b593a4"), Code="Other", Description="Other", Definition="A kind of individualized guidance and counseling plan other than an education plan and a career plan.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefCareerEducationPlanType Pick List
         /// </summary>
        public static List<RefCareerEducationPlanType> RefCareerEducationPlanTypePickList = new List<RefCareerEducationPlanType>
        {
            new RefCareerEducationPlanType { Id=Guid.Parse("6fac87d5-4bb5-4d39-82b8-58dfbd6b0e97"), Code="Education", Description="Education plan", SortOrder=Convert.ToDecimal("1.00") },
            new RefCareerEducationPlanType { Id=Guid.Parse("d3a80253-c42e-4c20-baee-c73d3437ff12"), Code="Career", Description="Career plan", SortOrder=Convert.ToDecimal("3.00") },
            new RefCareerEducationPlanType { Id=Guid.Parse("cd15b356-a2d3-430d-b1b5-d4eb72bc9725"), Code="Both", Description="Both education and career plan", SortOrder=Convert.ToDecimal("5.00") },
            new RefCareerEducationPlanType { Id=Guid.Parse("e33109e3-293a-4164-a923-0a9ce0b593a4"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
