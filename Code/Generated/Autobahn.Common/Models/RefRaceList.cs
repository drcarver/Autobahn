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
        public static List<RefRace> RefRaceList = new List<RefRace> =
        {
            new RefRace { Id=Guid.Parse("0cf903ee-8e81-4807-ada8-71f9471c4383"), Code="", Description="RaceAmericanIndianorAlaskaNative", Definition="", SortOrder=0 },
            new RefRace { Id=Guid.Parse("1fe049ff-4536-4003-baa9-243c0371a9b9"), Code="", Description="RaceAsian", Definition="", SortOrder=0 },
            new RefRace { Id=Guid.Parse("8bc919c6-baa1-4772-b458-770beb7a378d"), Code="", Description="RaceBlackorAfricanAmerican", Definition="", SortOrder=0 },
            new RefRace { Id=Guid.Parse("ed7869cb-b24e-49b8-a491-d234a3851668"), Code="", Description="RaceNativeHawaiianorOtherPacificIslander", Definition="", SortOrder=0 },
            new RefRace { Id=Guid.Parse("792f93bc-69f6-4712-a663-855e50b8768a"), Code="", Description="RaceWhite", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefRace Pick List
         /// </summary>
        public static List<RefRace> RefRacePickList = new List<RefRace> =
        {
            new RefRace { Id=Guid.Parse("0cf903ee-8e81-4807-ada8-71f9471c4383"), Code="", SortOrder=0 },
            new RefRace { Id=Guid.Parse("1fe049ff-4536-4003-baa9-243c0371a9b9"), Code="", SortOrder=0 },
            new RefRace { Id=Guid.Parse("8bc919c6-baa1-4772-b458-770beb7a378d"), Code="", SortOrder=0 },
            new RefRace { Id=Guid.Parse("ed7869cb-b24e-49b8-a491-d234a3851668"), Code="", SortOrder=0 },
            new RefRace { Id=Guid.Parse("792f93bc-69f6-4712-a663-855e50b8768a"), Code="", SortOrder=0 },
       };
   }
}
