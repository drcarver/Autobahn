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
        public static List<RefFrequencyUnit> RefFrequencyUnitList = new List<RefFrequencyUnit> =
        {
            new RefFrequencyUnit { Id=Guid.Parse("cb92bbac-4b42-4dc8-9b7c-3a0bd9d8536d"), Code="Day is the unit of time by which a cycle is defined.", Description="Day", Definition="", SortOrder=0 },
            new RefFrequencyUnit { Id=Guid.Parse("ed52974e-7f86-4133-85d0-e8401ff1ac73"), Code="Hour is the unit of time by which a cycle is defined.", Description="Hour", Definition="", SortOrder=0 },
            new RefFrequencyUnit { Id=Guid.Parse("a4e0feb8-f72a-4dab-b6aa-103284b17562"), Code="Minute is the unit of time by which a cycle is defined.", Description="Minute", Definition="", SortOrder=0 },
            new RefFrequencyUnit { Id=Guid.Parse("66621995-1d8a-493d-8229-62f13037f6e0"), Code="Month is the unit of time by which a cycle is defined.", Description="Month", Definition="", SortOrder=0 },
            new RefFrequencyUnit { Id=Guid.Parse("0f89bc40-32c7-49c0-a217-7c7f5617b9c9"), Code="Week is the unit of time by which a cycle is defined.", Description="Week", Definition="", SortOrder=0 },
            new RefFrequencyUnit { Id=Guid.Parse("f5df8cf1-38d1-43d3-8782-2548f681e19e"), Code="Year is the unit of time by which a cycle is defined.", Description="Year", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFrequencyUnit Pick List
         /// </summary>
        public static List<RefFrequencyUnit> RefFrequencyUnitPickList = new List<RefFrequencyUnit> =
        {
            new RefFrequencyUnit { Id=Guid.Parse("cb92bbac-4b42-4dc8-9b7c-3a0bd9d8536d"), Code="Day is the unit of time by which a cycle is defined.", SortOrder=0 },
            new RefFrequencyUnit { Id=Guid.Parse("ed52974e-7f86-4133-85d0-e8401ff1ac73"), Code="Hour is the unit of time by which a cycle is defined.", SortOrder=0 },
            new RefFrequencyUnit { Id=Guid.Parse("a4e0feb8-f72a-4dab-b6aa-103284b17562"), Code="Minute is the unit of time by which a cycle is defined.", SortOrder=0 },
            new RefFrequencyUnit { Id=Guid.Parse("66621995-1d8a-493d-8229-62f13037f6e0"), Code="Month is the unit of time by which a cycle is defined.", SortOrder=0 },
            new RefFrequencyUnit { Id=Guid.Parse("0f89bc40-32c7-49c0-a217-7c7f5617b9c9"), Code="Week is the unit of time by which a cycle is defined.", SortOrder=0 },
            new RefFrequencyUnit { Id=Guid.Parse("f5df8cf1-38d1-43d3-8782-2548f681e19e"), Code="Year is the unit of time by which a cycle is defined.", SortOrder=0 },
       };
   }
}
