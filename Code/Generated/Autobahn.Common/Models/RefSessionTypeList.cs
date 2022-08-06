//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSessionTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefSessionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSessionType"> List
         /// </summary>
        public static List<RefSessionType> RefSessionTypeList = new List<RefSessionType>
        {
            new RefSessionType { Id=Guid.Parse("1b8c71db-4685-4720-9338-c258cfe85385"), Code="FullSchoolYear", Description="Full School Year", Definition="A regular school term consisting of no major subdivision of time segments. It usually begins in the late summer or early fall and ends in late spring or early summer (e.g., elementary school).", SortOrder=Convert.ToDecimal("1.00") },
            new RefSessionType { Id=Guid.Parse("90e57b0c-bbbb-4ab8-a703-957cc596e66b"), Code="Intersession", Description="Intersession", Definition="A short session which occurs between longer sessions.", SortOrder=Convert.ToDecimal("2.00") },
            new RefSessionType { Id=Guid.Parse("e7213fdc-fcbd-4558-ab11-f3f471a0b41f"), Code="LongSession", Description="Long Session", Definition="A session that is longer than a semester but shorter than a full year.", SortOrder=Convert.ToDecimal("3.00") },
            new RefSessionType { Id=Guid.Parse("6c53d1c6-0476-4638-a7d9-0446335763d2"), Code="MiniTerm", Description="Mini Term", Definition="A school term which is shorter than a regular session.", SortOrder=Convert.ToDecimal("4.00") },
            new RefSessionType { Id=Guid.Parse("624be73f-b43c-4f93-8875-8876b13a0ae3"), Code="Quarter", Description="Quarter", Definition="One of four equal segments into which a school year is divided.", SortOrder=Convert.ToDecimal("5.00") },
            new RefSessionType { Id=Guid.Parse("825cec51-ac8b-4845-bffd-7e8418328684"), Code="Quinmester", Description="Quinmester", Definition="One of five equal segments into which a school year is divided.", SortOrder=Convert.ToDecimal("6.00") },
            new RefSessionType { Id=Guid.Parse("0dbe9d2d-6a71-4803-98b4-0b7539862abb"), Code="Semester", Description="Semester", Definition="One of two equal segments into which a school year is divided.", SortOrder=Convert.ToDecimal("7.00") },
            new RefSessionType { Id=Guid.Parse("3b55b4af-dabe-4533-9841-9563ce5130e1"), Code="SummerTerm", Description="Summer Term", Definition="A school term which takes place in the summer between two regular school terms.", SortOrder=Convert.ToDecimal("8.00") },
            new RefSessionType { Id=Guid.Parse("98ea8778-849a-4345-8644-b9e999e995f7"), Code="Trimester", Description="Trimester", Definition="One of three equal segments into which a school year is divided.", SortOrder=Convert.ToDecimal("9.00") },
            new RefSessionType { Id=Guid.Parse("0b5dbe3b-6638-4e60-84b7-eb855c53e104"), Code="TwelveMonth", Description="Twelve Month", Definition="An educational program that operates on a full twelve month cycle.", SortOrder=Convert.ToDecimal("10.00") },
            new RefSessionType { Id=Guid.Parse("98fa0743-dd48-46b7-b68d-ef2f5f04e17c"), Code="Other", Description="Other", Definition="The session type is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The RefSessionType Pick List
         /// </summary>
        public static List<RefSessionType> RefSessionTypePickList = new List<RefSessionType>
        {
            new RefSessionType { Id=Guid.Parse("1b8c71db-4685-4720-9338-c258cfe85385"), Code="FullSchoolYear", Description="Full School Year", SortOrder=Convert.ToDecimal("1.00") },
            new RefSessionType { Id=Guid.Parse("90e57b0c-bbbb-4ab8-a703-957cc596e66b"), Code="Intersession", Description="Intersession", SortOrder=Convert.ToDecimal("2.00") },
            new RefSessionType { Id=Guid.Parse("e7213fdc-fcbd-4558-ab11-f3f471a0b41f"), Code="LongSession", Description="Long Session", SortOrder=Convert.ToDecimal("3.00") },
            new RefSessionType { Id=Guid.Parse("6c53d1c6-0476-4638-a7d9-0446335763d2"), Code="MiniTerm", Description="Mini Term", SortOrder=Convert.ToDecimal("4.00") },
            new RefSessionType { Id=Guid.Parse("624be73f-b43c-4f93-8875-8876b13a0ae3"), Code="Quarter", Description="Quarter", SortOrder=Convert.ToDecimal("5.00") },
            new RefSessionType { Id=Guid.Parse("825cec51-ac8b-4845-bffd-7e8418328684"), Code="Quinmester", Description="Quinmester", SortOrder=Convert.ToDecimal("6.00") },
            new RefSessionType { Id=Guid.Parse("0dbe9d2d-6a71-4803-98b4-0b7539862abb"), Code="Semester", Description="Semester", SortOrder=Convert.ToDecimal("7.00") },
            new RefSessionType { Id=Guid.Parse("3b55b4af-dabe-4533-9841-9563ce5130e1"), Code="SummerTerm", Description="Summer Term", SortOrder=Convert.ToDecimal("8.00") },
            new RefSessionType { Id=Guid.Parse("98ea8778-849a-4345-8644-b9e999e995f7"), Code="Trimester", Description="Trimester", SortOrder=Convert.ToDecimal("9.00") },
            new RefSessionType { Id=Guid.Parse("0b5dbe3b-6638-4e60-84b7-eb855c53e104"), Code="TwelveMonth", Description="Twelve Month", SortOrder=Convert.ToDecimal("10.00") },
            new RefSessionType { Id=Guid.Parse("98fa0743-dd48-46b7-b68d-ef2f5f04e17c"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
