//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefPrekindergartenEligibilityList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefPrekindergartenEligibility Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPrekindergartenEligibility"> List
         /// </summary>
        public static List<RefPrekindergartenEligibility> RefPrekindergartenEligibilityList = new List<RefPrekindergartenEligibility> =
        {
            new RefPrekindergartenEligibility { Id=Guid.Parse("d530e5bb-d625-482d-bd1b-b39e4b788128"), Code="All students", Description="All", Definition="", SortOrder=0 },
            new RefPrekindergartenEligibility { Id=Guid.Parse("7fcd8fb6-b36a-4262-b80f-b34c15e10c29"), Code="Students with disabilities (IDEA)", Description="IDEA", Definition="", SortOrder=0 },
            new RefPrekindergartenEligibility { Id=Guid.Parse("44e83691-9056-4ae8-b915-5a5ead206e8e"), Code="Students in Title I schools", Description="TitleI", Definition="", SortOrder=0 },
            new RefPrekindergartenEligibility { Id=Guid.Parse("f3e0dd5b-8cf8-49aa-aff7-90fb4e4b87a8"), Code="Students from low income families", Description="LowIncome", Definition="", SortOrder=0 },
            new RefPrekindergartenEligibility { Id=Guid.Parse("6b9d4a27-27e8-4755-b41c-04e5bd7732b3"), Code="Other", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPrekindergartenEligibility Pick List
         /// </summary>
        public static List<RefPrekindergartenEligibility> RefPrekindergartenEligibilityPickList = new List<RefPrekindergartenEligibility> =
        {
            new RefPrekindergartenEligibility { Id=Guid.Parse("d530e5bb-d625-482d-bd1b-b39e4b788128"), Code="All students", SortOrder=0 },
            new RefPrekindergartenEligibility { Id=Guid.Parse("7fcd8fb6-b36a-4262-b80f-b34c15e10c29"), Code="Students with disabilities (IDEA)", SortOrder=0 },
            new RefPrekindergartenEligibility { Id=Guid.Parse("44e83691-9056-4ae8-b915-5a5ead206e8e"), Code="Students in Title I schools", SortOrder=0 },
            new RefPrekindergartenEligibility { Id=Guid.Parse("f3e0dd5b-8cf8-49aa-aff7-90fb4e4b87a8"), Code="Students from low income families", SortOrder=0 },
            new RefPrekindergartenEligibility { Id=Guid.Parse("6b9d4a27-27e8-4755-b41c-04e5bd7732b3"), Code="Other", SortOrder=0 },
       };
   }
}
