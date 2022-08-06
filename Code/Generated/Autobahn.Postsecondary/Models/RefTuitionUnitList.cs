//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefTuitionUnitList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefTuitionUnit Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTuitionUnit"> List
         /// </summary>
        public static List<RefTuitionUnit> RefTuitionUnitList = new List<RefTuitionUnit> =
        {
            new RefTuitionUnit { Id=Guid.Parse("b716f89a-5779-49e6-87f4-72f02683e0f3"), Code="Tuition is being charged Per Term.", Description="PerTerm", Definition="", SortOrder=0 },
            new RefTuitionUnit { Id=Guid.Parse("4b8f6c60-699a-48c0-b792-abf855f1e33b"), Code="Tuition is being charged Per Year.", Description="PerYear", Definition="", SortOrder=0 },
            new RefTuitionUnit { Id=Guid.Parse("ee8f515f-3e53-44cd-82be-7e4e5c7ebe32"), Code="Tuition is being charged Per Program.", Description="PerProgram", Definition="", SortOrder=0 },
            new RefTuitionUnit { Id=Guid.Parse("303f4cec-e669-4963-a7b0-9f2ecd3b6008"), Code="Tuition is being charged Per Course.", Description="PerCourse", Definition="", SortOrder=0 },
            new RefTuitionUnit { Id=Guid.Parse("44363649-d1d4-4faa-9871-b382eee0da2e"), Code="Tuition is being charged Per Credit.", Description="PerCredit", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefTuitionUnit Pick List
         /// </summary>
        public static List<RefTuitionUnit> RefTuitionUnitPickList = new List<RefTuitionUnit> =
        {
            new RefTuitionUnit { Id=Guid.Parse("b716f89a-5779-49e6-87f4-72f02683e0f3"), Code="Tuition is being charged Per Term.", SortOrder=0 },
            new RefTuitionUnit { Id=Guid.Parse("4b8f6c60-699a-48c0-b792-abf855f1e33b"), Code="Tuition is being charged Per Year.", SortOrder=0 },
            new RefTuitionUnit { Id=Guid.Parse("ee8f515f-3e53-44cd-82be-7e4e5c7ebe32"), Code="Tuition is being charged Per Program.", SortOrder=0 },
            new RefTuitionUnit { Id=Guid.Parse("303f4cec-e669-4963-a7b0-9f2ecd3b6008"), Code="Tuition is being charged Per Course.", SortOrder=0 },
            new RefTuitionUnit { Id=Guid.Parse("44363649-d1d4-4faa-9871-b382eee0da2e"), Code="Tuition is being charged Per Credit.", SortOrder=0 },
       };
   }
}
