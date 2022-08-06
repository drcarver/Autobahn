//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefServiceOptionList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefServiceOption Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefServiceOption"> List
         /// </summary>
        public static List<RefServiceOption> RefServiceOptionList = new List<RefServiceOption> =
        {
            new RefServiceOption { Id=Guid.Parse("80d16b87-83fa-4e84-8f30-3579453b2d89"), Code="Full-day/full-year is the nature of the early childhood program, class or group in which a person is enrolled.", Description="FullDayFullYear", Definition="", SortOrder=0 },
            new RefServiceOption { Id=Guid.Parse("08ccfd0e-b136-4436-9175-125716bf933d"), Code="Full-day/part-year is the nature of the early childhood program, class or group in which a person is enrolled.", Description="FullDayPartYear", Definition="", SortOrder=0 },
            new RefServiceOption { Id=Guid.Parse("acbc94d4-6903-47d5-9803-7d86d0ab40a7"), Code="Part-day/full-year is the nature of the early childhood program, class or group in which a person is enrolled.", Description="PartDayFullYear", Definition="", SortOrder=0 },
            new RefServiceOption { Id=Guid.Parse("e6919372-03f3-480e-bd8c-3378fb187988"), Code="Part-day/part-year is the nature of the early childhood program, class or group in which a person is enrolled.", Description="PartDayPartYear", Definition="", SortOrder=0 },
            new RefServiceOption { Id=Guid.Parse("77d5a4be-8346-4917-be41-277338508624"), Code="Home based is the nature of the early childhood program, class or group in which a person is enrolled.", Description="HomeBased", Definition="", SortOrder=0 },
            new RefServiceOption { Id=Guid.Parse("18be3764-7566-45e7-94ec-2f2a74598c88"), Code="The nature of the early childhood program, class or group in which a person is enrolled is not applicable.", Description="NA", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefServiceOption Pick List
         /// </summary>
        public static List<RefServiceOption> RefServiceOptionPickList = new List<RefServiceOption> =
        {
            new RefServiceOption { Id=Guid.Parse("80d16b87-83fa-4e84-8f30-3579453b2d89"), Code="Full-day/full-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=0 },
            new RefServiceOption { Id=Guid.Parse("08ccfd0e-b136-4436-9175-125716bf933d"), Code="Full-day/part-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=0 },
            new RefServiceOption { Id=Guid.Parse("acbc94d4-6903-47d5-9803-7d86d0ab40a7"), Code="Part-day/full-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=0 },
            new RefServiceOption { Id=Guid.Parse("e6919372-03f3-480e-bd8c-3378fb187988"), Code="Part-day/part-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=0 },
            new RefServiceOption { Id=Guid.Parse("77d5a4be-8346-4917-be41-277338508624"), Code="Home based is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=0 },
            new RefServiceOption { Id=Guid.Parse("18be3764-7566-45e7-94ec-2f2a74598c88"), Code="The nature of the early childhood program, class or group in which a person is enrolled is not applicable.", SortOrder=0 },
       };
   }
}
