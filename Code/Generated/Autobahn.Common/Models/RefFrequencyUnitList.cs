//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFrequencyUnitList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFrequencyUnit Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFrequencyUnit"> List
         /// </summary>
        public static List<RefFrequencyUnit> RefFrequencyUnitList = new List<RefFrequencyUnit>
        {
            new RefFrequencyUnit { Id=Guid.Parse("d7b93a07-e98d-4408-9d82-5d66fa5c9d61"), Code="Day", Description="Day", Definition="Day is the unit of time by which a cycle is defined.", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("957f489e-1fc7-406f-b344-4b931581e249"), Code="Hour", Description="Hour", Definition="Hour is the unit of time by which a cycle is defined.", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("938b595c-9923-461a-ad0f-8eb29ceea3f1"), Code="Minute", Description="Minute", Definition="Minute is the unit of time by which a cycle is defined.", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("56783418-618f-4253-9dbf-2cc624c1cd9e"), Code="Month", Description="Month", Definition="Month is the unit of time by which a cycle is defined.", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("3376569c-e6e5-41f5-a2af-510eb89cdc6c"), Code="Week", Description="Week", Definition="Week is the unit of time by which a cycle is defined.", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("75aa7df9-d5a5-4244-a70e-84434ff64822"), Code="Year", Description="Year", Definition="Year is the unit of time by which a cycle is defined.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefFrequencyUnit Pick List
         /// </summary>
        public static List<RefFrequencyUnit> RefFrequencyUnitPickList = new List<RefFrequencyUnit>
        {
            new RefFrequencyUnit { Id=Guid.Parse("d7b93a07-e98d-4408-9d82-5d66fa5c9d61"), Code="Day", Description="Day", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("957f489e-1fc7-406f-b344-4b931581e249"), Code="Hour", Description="Hour", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("938b595c-9923-461a-ad0f-8eb29ceea3f1"), Code="Minute", Description="Minute", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("56783418-618f-4253-9dbf-2cc624c1cd9e"), Code="Month", Description="Month", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("3376569c-e6e5-41f5-a2af-510eb89cdc6c"), Code="Week", Description="Week", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("75aa7df9-d5a5-4244-a70e-84434ff64822"), Code="Year", Description="Year", SortOrder=Convert.ToDecimal("") },
       };
   }
}
