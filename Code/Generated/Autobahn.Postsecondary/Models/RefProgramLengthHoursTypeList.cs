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
        public static List<RefProgramLengthHoursType> RefProgramLengthHoursTypeList = new List<RefProgramLengthHoursType>
        {
            new RefProgramLengthHoursType { Id=Guid.Parse("fa536fbc-496f-47c2-93e3-304df6f97a06"), Code="Credit", Description="Credit", Definition="Credit is the type of hours (credit or contact) by which the normal length of a program of study is measured.", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramLengthHoursType { Id=Guid.Parse("778b9fa6-8489-4dc6-ab00-0e301fb77ac0"), Code="Contact", Description="Contact", Definition="Contact is the type of hours (credit or contact) by which the normal length of a program of study is measured.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefProgramLengthHoursType Pick List
         /// </summary>
        public static List<RefProgramLengthHoursType> RefProgramLengthHoursTypePickList = new List<RefProgramLengthHoursType>
        {
            new RefProgramLengthHoursType { Id=Guid.Parse("fa536fbc-496f-47c2-93e3-304df6f97a06"), Code="Credit", Description="Credit", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramLengthHoursType { Id=Guid.Parse("778b9fa6-8489-4dc6-ab00-0e301fb77ac0"), Code="Contact", Description="Contact", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
