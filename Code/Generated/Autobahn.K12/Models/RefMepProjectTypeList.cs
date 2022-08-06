//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefMepProjectTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefMepProjectType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepProjectType"> List
         /// </summary>
        public static List<RefMepProjectType> RefMepProjectTypeList = new List<RefMepProjectType>
        {
            new RefMepProjectType { Id=Guid.Parse("215ce549-5a17-4824-99d0-d5f266ed7fac"), Code="SchoolDay", Description="Regular school year - school day only", Definition="The project funded in whole or in part by Migrant Education Program funds is  available during the regular school year - school day only.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepProjectType { Id=Guid.Parse("f9ec6402-c260-4e17-a46c-684f4eb52398"), Code="ExtendedDay", Description="Regular school year - school day/extended day", Definition="The project funded in whole or in part by Migrant Education Program funds is  available during the regular school year - school day/extended day.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepProjectType { Id=Guid.Parse("3a399483-26fc-4b7d-bc53-94dff3595bb9"), Code="SummerIntersession", Description="Summer/intersession only", Definition="The project funded in whole or in part by Migrant Education Program funds is available during summer/intersession only.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepProjectType { Id=Guid.Parse("bdb66294-7604-4abe-831d-e731004a2d25"), Code="YearRound", Description="Year round", Definition="The project funded in whole or in part by Migrant Education Program funds is available year round.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefMepProjectType Pick List
         /// </summary>
        public static List<RefMepProjectType> RefMepProjectTypePickList = new List<RefMepProjectType>
        {
            new RefMepProjectType { Id=Guid.Parse("215ce549-5a17-4824-99d0-d5f266ed7fac"), Code="SchoolDay", Description="Regular school year - school day only", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepProjectType { Id=Guid.Parse("f9ec6402-c260-4e17-a46c-684f4eb52398"), Code="ExtendedDay", Description="Regular school year - school day/extended day", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepProjectType { Id=Guid.Parse("3a399483-26fc-4b7d-bc53-94dff3595bb9"), Code="SummerIntersession", Description="Summer/intersession only", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepProjectType { Id=Guid.Parse("bdb66294-7604-4abe-831d-e731004a2d25"), Code="YearRound", Description="Year round", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
