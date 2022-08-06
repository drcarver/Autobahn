//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefELOutcomeMeasurementLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefELOutcomeMeasurementLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefELOutcomeMeasurementLevel"> List
         /// </summary>
        public static List<RefELOutcomeMeasurementLevel> RefELOutcomeMeasurementLevelList = new List<RefELOutcomeMeasurementLevel>
        {
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("f9003df8-5d20-4c6e-a6e3-a03d1404ce4c"), Code="Baseline", Description="Baseline - at entry", Definition="Baseline - at entry is the early learning outcome level.", SortOrder=Convert.ToDecimal("1.00") },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("cda0280b-a117-4687-bade-2f019b02a5c9"), Code="AtExit", Description="At exit", Definition="At exit is the early learning outcome level.", SortOrder=Convert.ToDecimal("3.00") },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("3152b93c-bae1-4f1e-bfce-e50c817dde5d"), Code="No", Description="No", Definition="No is the early learning outcome level.", SortOrder=Convert.ToDecimal("5.00") },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("8821c5a6-7d4f-4aba-b1c1-23cf9ca847ac"), Code="Other", Description="Other", Definition="Other is the early learning outcome level.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefELOutcomeMeasurementLevel Pick List
         /// </summary>
        public static List<RefELOutcomeMeasurementLevel> RefELOutcomeMeasurementLevelPickList = new List<RefELOutcomeMeasurementLevel>
        {
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("f9003df8-5d20-4c6e-a6e3-a03d1404ce4c"), Code="Baseline", Description="Baseline - at entry", SortOrder=Convert.ToDecimal("1.00") },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("cda0280b-a117-4687-bade-2f019b02a5c9"), Code="AtExit", Description="At exit", SortOrder=Convert.ToDecimal("3.00") },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("3152b93c-bae1-4f1e-bfce-e50c817dde5d"), Code="No", Description="No", SortOrder=Convert.ToDecimal("5.00") },
            new RefELOutcomeMeasurementLevel { Id=Guid.Parse("8821c5a6-7d4f-4aba-b1c1-23cf9ca847ac"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
