//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTitleIIIAccountabilityList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefTitleIIIAccountability Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTitleIIIAccountability"> List
         /// </summary>
        public static List<RefTitleIIIAccountability> RefTitleIIIAccountabilityList = new List<RefTitleIIIAccountability>
        {
            new RefTitleIIIAccountability { Id=Guid.Parse("acafac2c-04a4-48b7-99ab-b38295a3f462"), Code="PROGRESS", Description="Making progress", Definition="The student is making progress toward English proficiency.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIIIAccountability { Id=Guid.Parse("3d3515b6-7295-44b6-a932-7e846b6cdd1e"), Code="NOPROGRESS", Description="Did not make progress", Definition="The student did not make progress toward English proficiency.", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIIIAccountability { Id=Guid.Parse("c8a47c19-7a47-43db-9a48-d75aa45cd1db"), Code="PROFICIENT", Description="Attained proficiency", Definition="The student attained English proficiency.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefTitleIIIAccountability Pick List
         /// </summary>
        public static List<RefTitleIIIAccountability> RefTitleIIIAccountabilityPickList = new List<RefTitleIIIAccountability>
        {
            new RefTitleIIIAccountability { Id=Guid.Parse("acafac2c-04a4-48b7-99ab-b38295a3f462"), Code="PROGRESS", Description="Making progress", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIIIAccountability { Id=Guid.Parse("3d3515b6-7295-44b6-a932-7e846b6cdd1e"), Code="NOPROGRESS", Description="Did not make progress", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIIIAccountability { Id=Guid.Parse("c8a47c19-7a47-43db-9a48-d75aa45cd1db"), Code="PROFICIENT", Description="Attained proficiency", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
