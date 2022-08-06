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
        public static List<RefCareerEducationPlanType> RefCareerEducationPlanTypeList = new List<RefCareerEducationPlanType> =
        {
            new RefCareerEducationPlanType { Id=Guid.Parse("bc5a5580-4d21-40a9-8db3-5a13e9faeac4"), Code="An individualized guidance and counseling plan for education.", Description="Education", Definition="", SortOrder=0 },
            new RefCareerEducationPlanType { Id=Guid.Parse("d466aae1-a3fe-439f-a9c8-9656be8c5fdc"), Code="An individualized guidance and counseling plan for career.", Description="Career", Definition="", SortOrder=0 },
            new RefCareerEducationPlanType { Id=Guid.Parse("f82751cf-386a-45fd-a1da-29679dd33ebd"), Code="An individualized guidance and counseling plan for both career and education.", Description="Both", Definition="", SortOrder=0 },
            new RefCareerEducationPlanType { Id=Guid.Parse("56b0b58b-a7f0-4e11-bc81-424bdd862fca"), Code="A kind of individualized guidance and counseling plan other than an education plan and a career plan.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCareerEducationPlanType Pick List
         /// </summary>
        public static List<RefCareerEducationPlanType> RefCareerEducationPlanTypePickList = new List<RefCareerEducationPlanType> =
        {
            new RefCareerEducationPlanType { Id=Guid.Parse("bc5a5580-4d21-40a9-8db3-5a13e9faeac4"), Code="An individualized guidance and counseling plan for education.", SortOrder=0 },
            new RefCareerEducationPlanType { Id=Guid.Parse("d466aae1-a3fe-439f-a9c8-9656be8c5fdc"), Code="An individualized guidance and counseling plan for career.", SortOrder=0 },
            new RefCareerEducationPlanType { Id=Guid.Parse("f82751cf-386a-45fd-a1da-29679dd33ebd"), Code="An individualized guidance and counseling plan for both career and education.", SortOrder=0 },
            new RefCareerEducationPlanType { Id=Guid.Parse("56b0b58b-a7f0-4e11-bc81-424bdd862fca"), Code="A kind of individualized guidance and counseling plan other than an education plan and a career plan.", SortOrder=0 },
       };
   }
}
