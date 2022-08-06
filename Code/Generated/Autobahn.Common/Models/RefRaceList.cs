//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRaceList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefRace Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefRace"> List
         /// </summary>
        public static List<RefRace> RefRaceList = new List<RefRace>
        {
            new RefRace { Id=Guid.Parse("eff2c8ef-0a27-4df8-a1e1-2418cbf54c0e"), Code="RaceAmericanIndianorAlaskaNative", Description="American Indian or Alaska Native", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("c01a2d4d-f6c5-476c-8155-fdf926a974c5"), Code="RaceAsian", Description="Asian", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("7d26919b-e6d8-43d5-96f6-5c9a7b7035de"), Code="RaceBlackorAfricanAmerican", Description="Black or African American", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("0e492600-d53e-467a-ae5f-9004bf8832ff"), Code="RaceNativeHawaiianorOtherPacificIslander", Description="Native Hawaiian or Other Pacific Islander", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("a7781a3f-6425-4c31-858c-ff14ef9e1e34"), Code="RaceWhite", Description="White", Definition="", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefRace Pick List
         /// </summary>
        public static List<RefRace> RefRacePickList = new List<RefRace>
        {
            new RefRace { Id=Guid.Parse("eff2c8ef-0a27-4df8-a1e1-2418cbf54c0e"), Code="RaceAmericanIndianorAlaskaNative", Description="American Indian or Alaska Native", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("c01a2d4d-f6c5-476c-8155-fdf926a974c5"), Code="RaceAsian", Description="Asian", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("7d26919b-e6d8-43d5-96f6-5c9a7b7035de"), Code="RaceBlackorAfricanAmerican", Description="Black or African American", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("0e492600-d53e-467a-ae5f-9004bf8832ff"), Code="RaceNativeHawaiianorOtherPacificIslander", Description="Native Hawaiian or Other Pacific Islander", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("a7781a3f-6425-4c31-858c-ff14ef9e1e34"), Code="RaceWhite", Description="White", SortOrder=Convert.ToDecimal("") },
       };
   }
}
