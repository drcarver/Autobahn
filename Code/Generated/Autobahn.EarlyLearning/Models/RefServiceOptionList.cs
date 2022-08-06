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
        public static List<RefServiceOption> RefServiceOptionList = new List<RefServiceOption>
        {
            new RefServiceOption { Id=Guid.Parse("304a1152-085a-4fb9-9c17-3b105d78c96b"), Code="FullDayFullYear", Description="Full-day/full-year", Definition="Full-day/full-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("1.00") },
            new RefServiceOption { Id=Guid.Parse("61f26b79-acc0-442d-aa89-8b3b7366cb79"), Code="FullDayPartYear", Description="Full-day/part-year", Definition="Full-day/part-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("2.00") },
            new RefServiceOption { Id=Guid.Parse("c2967c87-e0b8-4f2b-82ac-77da824911f1"), Code="PartDayFullYear", Description="Part-day/full-year", Definition="Part-day/full-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("3.00") },
            new RefServiceOption { Id=Guid.Parse("07eb5783-cb5c-4b4b-9de7-3a07fa607178"), Code="PartDayPartYear", Description="Part-day/part-year", Definition="Part-day/part-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("4.00") },
            new RefServiceOption { Id=Guid.Parse("098f097d-5b95-4728-983f-d67c4734a62c"), Code="HomeBased", Description="Home based", Definition="Home based is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("5.00") },
            new RefServiceOption { Id=Guid.Parse("03c2d0fc-0d55-43e4-abbb-db5db1f01ddb"), Code="NA", Description="Not applicable", Definition="The nature of the early childhood program, class or group in which a person is enrolled is not applicable.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefServiceOption Pick List
         /// </summary>
        public static List<RefServiceOption> RefServiceOptionPickList = new List<RefServiceOption>
        {
            new RefServiceOption { Id=Guid.Parse("304a1152-085a-4fb9-9c17-3b105d78c96b"), Code="FullDayFullYear", Description="Full-day/full-year", SortOrder=Convert.ToDecimal("1.00") },
            new RefServiceOption { Id=Guid.Parse("61f26b79-acc0-442d-aa89-8b3b7366cb79"), Code="FullDayPartYear", Description="Full-day/part-year", SortOrder=Convert.ToDecimal("2.00") },
            new RefServiceOption { Id=Guid.Parse("c2967c87-e0b8-4f2b-82ac-77da824911f1"), Code="PartDayFullYear", Description="Part-day/full-year", SortOrder=Convert.ToDecimal("3.00") },
            new RefServiceOption { Id=Guid.Parse("07eb5783-cb5c-4b4b-9de7-3a07fa607178"), Code="PartDayPartYear", Description="Part-day/part-year", SortOrder=Convert.ToDecimal("4.00") },
            new RefServiceOption { Id=Guid.Parse("098f097d-5b95-4728-983f-d67c4734a62c"), Code="HomeBased", Description="Home based", SortOrder=Convert.ToDecimal("5.00") },
            new RefServiceOption { Id=Guid.Parse("03c2d0fc-0d55-43e4-abbb-db5db1f01ddb"), Code="NA", Description="Not applicable", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
