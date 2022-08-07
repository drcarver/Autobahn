//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRaceList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefRace Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefRaceModel"> List
         /// </summary>
        public static List<RefRaceModel> RefRaceList = new List<RefRaceModel>
        {
            new RefRace { Id=Guid.Parse("37b23062-163e-40c7-8bb4-0d39b4b15d91"), Code="RaceAmericanIndianorAlaskaNative", Description="American Indian or Alaska Native", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("2a0f012e-64ea-4351-aebc-a3177bfd2c91"), Code="RaceAsian", Description="Asian", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("71d40af8-9746-486c-9b69-a95d59972690"), Code="RaceBlackorAfricanAmerican", Description="Black or African American", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("dc12a949-8b06-4bbe-96e2-cfe28d07c3d8"), Code="RaceNativeHawaiianorOtherPacificIslander", Description="Native Hawaiian or Other Pacific Islander", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("affaf600-e40e-4163-8f18-a3469888d1f8"), Code="RaceWhite", Description="White", Definition="", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefRace Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefRaceViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefRace { Id=Guid.Parse("37b23062-163e-40c7-8bb4-0d39b4b15d91"), Description="American Indian or Alaska Native", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("2a0f012e-64ea-4351-aebc-a3177bfd2c91"), Description="Asian", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("71d40af8-9746-486c-9b69-a95d59972690"), Description="Black or African American", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("dc12a949-8b06-4bbe-96e2-cfe28d07c3d8"), Description="Native Hawaiian or Other Pacific Islander", SortOrder=Convert.ToDecimal("") },
            new RefRace { Id=Guid.Parse("affaf600-e40e-4163-8f18-a3469888d1f8"), Description="White", SortOrder=Convert.ToDecimal("") },
       };
   }
}
