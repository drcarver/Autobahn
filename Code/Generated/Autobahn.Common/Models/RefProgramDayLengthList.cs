//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProgramDayLengthList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefProgramDayLength Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProgramDayLength"> List
         /// </summary>
        public static List<RefProgramDayLength> RefProgramDayLengthList = new List<RefProgramDayLength> =
        {
            new RefProgramDayLength { Id=Guid.Parse("81a2f56f-04eb-495e-bb4f-f7cd863edac9"), Code="The program is provided to the students it serves as a full-day program.", Description="FullDay", Definition="", SortOrder=0 },
            new RefProgramDayLength { Id=Guid.Parse("e2e92676-5af1-4f20-a42d-2221f4015654"), Code="The program is provided to the students it serves as a part-day program.", Description="Part-day", Definition="", SortOrder=0 },
            new RefProgramDayLength { Id=Guid.Parse("2e806009-bb80-4b84-85f7-d4481faa776c"), Code="Program is not provided.", Description="NotProvided", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefProgramDayLength Pick List
         /// </summary>
        public static List<RefProgramDayLength> RefProgramDayLengthPickList = new List<RefProgramDayLength> =
        {
            new RefProgramDayLength { Id=Guid.Parse("81a2f56f-04eb-495e-bb4f-f7cd863edac9"), Code="The program is provided to the students it serves as a full-day program.", SortOrder=0 },
            new RefProgramDayLength { Id=Guid.Parse("e2e92676-5af1-4f20-a42d-2221f4015654"), Code="The program is provided to the students it serves as a part-day program.", SortOrder=0 },
            new RefProgramDayLength { Id=Guid.Parse("2e806009-bb80-4b84-85f7-d4481faa776c"), Code="Program is not provided.", SortOrder=0 },
       };
   }
}
