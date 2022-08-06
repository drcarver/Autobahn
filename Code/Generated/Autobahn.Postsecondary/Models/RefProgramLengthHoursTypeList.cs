//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefProgramLengthHoursTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefProgramLengthHoursType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProgramLengthHoursType"> List
         /// </summary>
        public static List<RefProgramLengthHoursType> RefProgramLengthHoursTypeList = new List<RefProgramLengthHoursType> =
        {
            new RefProgramLengthHoursType { Id=Guid.Parse("2b243668-18b9-4753-9372-943a19ec083d"), Code="Credit is the type of hours (credit or contact) by which the normal length of a program of study is measured.", Description="Credit", Definition="", SortOrder=0 },
            new RefProgramLengthHoursType { Id=Guid.Parse("200f0b05-44c7-4cf1-9c0c-353446a19603"), Code="Contact is the type of hours (credit or contact) by which the normal length of a program of study is measured.", Description="Contact", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefProgramLengthHoursType Pick List
         /// </summary>
        public static List<RefProgramLengthHoursType> RefProgramLengthHoursTypePickList = new List<RefProgramLengthHoursType> =
        {
            new RefProgramLengthHoursType { Id=Guid.Parse("2b243668-18b9-4753-9372-943a19ec083d"), Code="Credit is the type of hours (credit or contact) by which the normal length of a program of study is measured.", SortOrder=0 },
            new RefProgramLengthHoursType { Id=Guid.Parse("200f0b05-44c7-4cf1-9c0c-353446a19603"), Code="Contact is the type of hours (credit or contact) by which the normal length of a program of study is measured.", SortOrder=0 },
       };
   }
}
