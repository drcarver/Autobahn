//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefK12EndOfCourseRequirementList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefK12EndOfCourseRequirement Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefK12EndOfCourseRequirementModel"> List
         /// </summary>
        public static List<RefK12EndOfCourseRequirementModel> RefK12EndOfCourseRequirementList = new List<RefK12EndOfCourseRequirementModel>
        {
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("7901c424-cded-40c9-ae7c-058faf23825d"), Code="LEAOnly", Description="LEA only", Definition="This course has an end of course examination required by the LEA only.", SortOrder=Convert.ToDecimal("1.00") },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("970eb2cb-7f33-4cfa-b41c-65d2a191b496"), Code="SEAOnly", Description="SEA only", Definition="This course has an end of course examination required by the SEA only.", SortOrder=Convert.ToDecimal("3.00") },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("bc37044e-d772-4bcb-8e8c-3b9727540416"), Code="Both", Description="LEA and SEA", Definition="This course has an end of course examination required by the LEA and SEA.", SortOrder=Convert.ToDecimal("5.00") },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("e5fab9b3-e46e-4f13-9734-75d3f741101d"), Code="Neither", Description="Neither LEA or SEA", Definition="This course has an end of course examination required by neither the LEA or SEA.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefK12EndOfCourseRequirement Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefK12EndOfCourseRequirementViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("7901c424-cded-40c9-ae7c-058faf23825d"), Description="LEA only", SortOrder=Convert.ToDecimal("1.00") },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("970eb2cb-7f33-4cfa-b41c-65d2a191b496"), Description="SEA only", SortOrder=Convert.ToDecimal("3.00") },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("bc37044e-d772-4bcb-8e8c-3b9727540416"), Description="LEA and SEA", SortOrder=Convert.ToDecimal("5.00") },
            new RefK12EndOfCourseRequirement { Id=Guid.Parse("e5fab9b3-e46e-4f13-9734-75d3f741101d"), Description="Neither LEA or SEA", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
