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
        public static List<RefProgramDayLength> RefProgramDayLengthList = new List<RefProgramDayLength>
        {
            new RefProgramDayLength { Id=Guid.Parse("f2d6cddc-6372-468d-8bbf-a256b85e1a4a"), Code="FullDay", Description="Full-day", Definition="The program is provided to the students it serves as a full-day program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramDayLength { Id=Guid.Parse("8984b663-5fbf-43e1-9015-e3b596a766a1"), Code="Part-day", Description="Part-day", Definition="The program is provided to the students it serves as a part-day program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgramDayLength { Id=Guid.Parse("3d501636-deb6-42ff-9a7b-0da79d5f3084"), Code="NotProvided", Description="Not provided", Definition="Program is not provided.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefProgramDayLength Pick List
         /// </summary>
        public static List<RefProgramDayLength> RefProgramDayLengthPickList = new List<RefProgramDayLength>
        {
            new RefProgramDayLength { Id=Guid.Parse("f2d6cddc-6372-468d-8bbf-a256b85e1a4a"), Code="FullDay", Description="Full-day", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramDayLength { Id=Guid.Parse("8984b663-5fbf-43e1-9015-e3b596a766a1"), Code="Part-day", Description="Part-day", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgramDayLength { Id=Guid.Parse("3d501636-deb6-42ff-9a7b-0da79d5f3084"), Code="NotProvided", Description="Not provided", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
