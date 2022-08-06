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
        public static List<RefTuitionUnit> RefTuitionUnitList = new List<RefTuitionUnit>
        {
            new RefTuitionUnit { Id=Guid.Parse("a67fa840-c1a7-4ae2-98be-f0706c0151af"), Code="PerTerm", Description="Per Term", Definition="Tuition is being charged Per Term.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTuitionUnit { Id=Guid.Parse("c42a3084-2f46-4269-8ae2-4b7ddf7b538a"), Code="PerYear", Description="Per Year", Definition="Tuition is being charged Per Year.", SortOrder=Convert.ToDecimal("2.00") },
            new RefTuitionUnit { Id=Guid.Parse("9559d81a-2ee3-4ff2-8529-57ea89a7b72f"), Code="PerProgram", Description="Per Program", Definition="Tuition is being charged Per Program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTuitionUnit { Id=Guid.Parse("2d87e52e-caf9-48dd-8545-4dd97b4db761"), Code="PerCourse", Description="Per Course", Definition="Tuition is being charged Per Course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefTuitionUnit { Id=Guid.Parse("3b20f457-4e5d-4b00-8449-fe8a88b31bc2"), Code="PerCredit", Description="Per Credit", Definition="Tuition is being charged Per Credit.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefTuitionUnit Pick List
         /// </summary>
        public static List<RefTuitionUnit> RefTuitionUnitPickList = new List<RefTuitionUnit>
        {
            new RefTuitionUnit { Id=Guid.Parse("a67fa840-c1a7-4ae2-98be-f0706c0151af"), Code="PerTerm", Description="Per Term", SortOrder=Convert.ToDecimal("1.00") },
            new RefTuitionUnit { Id=Guid.Parse("c42a3084-2f46-4269-8ae2-4b7ddf7b538a"), Code="PerYear", Description="Per Year", SortOrder=Convert.ToDecimal("2.00") },
            new RefTuitionUnit { Id=Guid.Parse("9559d81a-2ee3-4ff2-8529-57ea89a7b72f"), Code="PerProgram", Description="Per Program", SortOrder=Convert.ToDecimal("3.00") },
            new RefTuitionUnit { Id=Guid.Parse("2d87e52e-caf9-48dd-8545-4dd97b4db761"), Code="PerCourse", Description="Per Course", SortOrder=Convert.ToDecimal("4.00") },
            new RefTuitionUnit { Id=Guid.Parse("3b20f457-4e5d-4b00-8449-fe8a88b31bc2"), Code="PerCredit", Description="Per Credit", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
