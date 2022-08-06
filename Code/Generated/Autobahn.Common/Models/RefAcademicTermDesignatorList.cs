//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAcademicTermDesignatorList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAcademicTermDesignator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAcademicTermDesignator"> List
         /// </summary>
        public static List<RefAcademicTermDesignator> RefAcademicTermDesignatorList = new List<RefAcademicTermDesignator>
        {
            new RefAcademicTermDesignator { Id=Guid.Parse("a49a87a4-0ebe-4e70-a27b-39c0c0034209"), Code="Fall", Description="Fall", Definition="Fall is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("0.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("f8de99b0-8972-4550-94d8-d728da19e543"), Code="Winter", Description="Winter", Definition="Winter is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("dc28bd67-74e1-472f-8fa2-e71e0f2fdeb4"), Code="WinterIntersession", Description="Winter Intersession", Definition="Winter Intersession is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("d1cbbbe0-8854-45f3-820f-57668563135f"), Code="Spring", Description="Spring", Definition="Spring is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("12a6797b-a46d-410b-8dc1-1687f4e58a1c"), Code="Summer", Description="Summer", Definition="Summer is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("ebaa8d43-289e-45c3-aeaf-0c0b7d9b494b"), Code="Summer1", Description="Summer 1", Definition="Summer 1 is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("f1f8ad6b-10d6-47dc-959e-68add6f80473"), Code="Summer2", Description="Summer 2", Definition="Summer 2 is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("12.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("59f8de48-ec90-4a2b-99c6-1bc6f61e86c3"), Code="SpringIntersession", Description="Spring Intersession", Definition="Spring Intersession is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("14.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("e142d644-88db-4ffa-b264-939a839b51f5"), Code="Other", Description="Other", Definition="Other is the academic term for which the data apply.", SortOrder=Convert.ToDecimal("16.00") },
        };

        /// <summary>
        /// The RefAcademicTermDesignator Pick List
         /// </summary>
        public static List<RefAcademicTermDesignator> RefAcademicTermDesignatorPickList = new List<RefAcademicTermDesignator>
        {
            new RefAcademicTermDesignator { Id=Guid.Parse("a49a87a4-0ebe-4e70-a27b-39c0c0034209"), Code="Fall", Description="Fall", SortOrder=Convert.ToDecimal("0.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("f8de99b0-8972-4550-94d8-d728da19e543"), Code="Winter", Description="Winter", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("dc28bd67-74e1-472f-8fa2-e71e0f2fdeb4"), Code="WinterIntersession", Description="Winter Intersession", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("d1cbbbe0-8854-45f3-820f-57668563135f"), Code="Spring", Description="Spring", SortOrder=Convert.ToDecimal("6.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("12a6797b-a46d-410b-8dc1-1687f4e58a1c"), Code="Summer", Description="Summer", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("ebaa8d43-289e-45c3-aeaf-0c0b7d9b494b"), Code="Summer1", Description="Summer 1", SortOrder=Convert.ToDecimal("10.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("f1f8ad6b-10d6-47dc-959e-68add6f80473"), Code="Summer2", Description="Summer 2", SortOrder=Convert.ToDecimal("12.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("59f8de48-ec90-4a2b-99c6-1bc6f61e86c3"), Code="SpringIntersession", Description="Spring Intersession", SortOrder=Convert.ToDecimal("14.00") },
            new RefAcademicTermDesignator { Id=Guid.Parse("e142d644-88db-4ffa-b264-939a839b51f5"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("16.00") },
       };
   }
}
