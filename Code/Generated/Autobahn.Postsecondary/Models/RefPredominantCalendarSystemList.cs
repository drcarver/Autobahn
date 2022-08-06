//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefPredominantCalendarSystemList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefPredominantCalendarSystem Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPredominantCalendarSystem"> List
         /// </summary>
        public static List<RefPredominantCalendarSystem> RefPredominantCalendarSystemList = new List<RefPredominantCalendarSystem> =
        {
            new RefPredominantCalendarSystem { Id=Guid.Parse("2041e5d3-1785-460c-b9a2-4c97d110e88f"), Code="The institution structures most of its courses for the academic year by Semester.", Description="Semester", Definition="", SortOrder=0 },
            new RefPredominantCalendarSystem { Id=Guid.Parse("ba1cb0dc-fa49-4e8b-9c5c-a6a0da94a190"), Code="The institution structures most of its courses for the academic year by Quarter.", Description="Quarter", Definition="", SortOrder=0 },
            new RefPredominantCalendarSystem { Id=Guid.Parse("4c182d58-cfae-4bbe-b8b1-9f447cc6b694"), Code="The institution structures most of its courses for the academic year by Trimester.", Description="Trimester", Definition="", SortOrder=0 },
            new RefPredominantCalendarSystem { Id=Guid.Parse("dffef903-ae4f-4a10-9067-4963978eef5d"), Code="The institution structures most of its courses for the academic year by 4-1-4 or similar plan.", Description="4-1-4", Definition="", SortOrder=0 },
            new RefPredominantCalendarSystem { Id=Guid.Parse("36b9bf69-c1f6-4711-b720-39f117ad06c3"), Code="The institution structures most of its courses for the academic year by an academic plan not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
            new RefPredominantCalendarSystem { Id=Guid.Parse("52379612-5999-4124-8510-cdf8fe98a6dd"), Code="The method by which an institution structures most of its courses for the academic year differs by program.", Description="DiffersByProgram", Definition="", SortOrder=0 },
            new RefPredominantCalendarSystem { Id=Guid.Parse("279446a6-6cd6-4fe2-ac29-b87b85943b8d"), Code="The institution structures most of its courses for the academic year on a continuous basis.", Description="ContinuousBasis", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPredominantCalendarSystem Pick List
         /// </summary>
        public static List<RefPredominantCalendarSystem> RefPredominantCalendarSystemPickList = new List<RefPredominantCalendarSystem> =
        {
            new RefPredominantCalendarSystem { Id=Guid.Parse("2041e5d3-1785-460c-b9a2-4c97d110e88f"), Code="The institution structures most of its courses for the academic year by Semester.", SortOrder=0 },
            new RefPredominantCalendarSystem { Id=Guid.Parse("ba1cb0dc-fa49-4e8b-9c5c-a6a0da94a190"), Code="The institution structures most of its courses for the academic year by Quarter.", SortOrder=0 },
            new RefPredominantCalendarSystem { Id=Guid.Parse("4c182d58-cfae-4bbe-b8b1-9f447cc6b694"), Code="The institution structures most of its courses for the academic year by Trimester.", SortOrder=0 },
            new RefPredominantCalendarSystem { Id=Guid.Parse("dffef903-ae4f-4a10-9067-4963978eef5d"), Code="The institution structures most of its courses for the academic year by 4-1-4 or similar plan.", SortOrder=0 },
            new RefPredominantCalendarSystem { Id=Guid.Parse("36b9bf69-c1f6-4711-b720-39f117ad06c3"), Code="The institution structures most of its courses for the academic year by an academic plan not yet defined in CEDS.", SortOrder=0 },
            new RefPredominantCalendarSystem { Id=Guid.Parse("52379612-5999-4124-8510-cdf8fe98a6dd"), Code="The method by which an institution structures most of its courses for the academic year differs by program.", SortOrder=0 },
            new RefPredominantCalendarSystem { Id=Guid.Parse("279446a6-6cd6-4fe2-ac29-b87b85943b8d"), Code="The institution structures most of its courses for the academic year on a continuous basis.", SortOrder=0 },
       };
   }
}
