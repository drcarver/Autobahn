//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefProgressLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefProgressLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProgressLevel"> List
         /// </summary>
        public static List<RefProgressLevel> RefProgressLevelList = new List<RefProgressLevel>
        {
            new RefProgressLevel { Id=Guid.Parse("1114fd7a-aad8-4933-9c60-731bc66c151d"), Code="NEGGRADE", Description="Negative grade level change", Definition="The students showed a negative grade level change from the pre- to post- test", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgressLevel { Id=Guid.Parse("72100163-92cc-4406-9265-fa35432d3ec2"), Code="NOCHANGE", Description="No change", Definition="The students showed no change from the pre- to post- test", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgressLevel { Id=Guid.Parse("1ada1cc6-6520-4d25-bc60-aa2a1cc19954"), Code="UPHALFGRADE", Description="Improvement of up to one half grade level", Definition="The students showed improvement of up to one half grade level from the pre- to post- test", SortOrder=Convert.ToDecimal("3.00") },
            new RefProgressLevel { Id=Guid.Parse("684b556d-55dd-4d4a-874f-d3f40899ae07"), Code="UPONEGRADE", Description="Improvement from one half grade level up to one full grade level", Definition="The students showed improvement from one half grade level up to one full grade level from the pre- to post- test", SortOrder=Convert.ToDecimal("4.00") },
            new RefProgressLevel { Id=Guid.Parse("6fb32bed-67ab-4c1f-8acd-7712d56296a8"), Code="UPGTONE", Description="Improvement of more than one full grade level", Definition="The students showed improvement of more than one full grade level from the pre- to post- test", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefProgressLevel Pick List
         /// </summary>
        public static List<RefProgressLevel> RefProgressLevelPickList = new List<RefProgressLevel>
        {
            new RefProgressLevel { Id=Guid.Parse("1114fd7a-aad8-4933-9c60-731bc66c151d"), Code="NEGGRADE", Description="Negative grade level change", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgressLevel { Id=Guid.Parse("72100163-92cc-4406-9265-fa35432d3ec2"), Code="NOCHANGE", Description="No change", SortOrder=Convert.ToDecimal("2.00") },
            new RefProgressLevel { Id=Guid.Parse("1ada1cc6-6520-4d25-bc60-aa2a1cc19954"), Code="UPHALFGRADE", Description="Improvement of up to one half grade level", SortOrder=Convert.ToDecimal("3.00") },
            new RefProgressLevel { Id=Guid.Parse("684b556d-55dd-4d4a-874f-d3f40899ae07"), Code="UPONEGRADE", Description="Improvement from one half grade level up to one full grade level", SortOrder=Convert.ToDecimal("4.00") },
            new RefProgressLevel { Id=Guid.Parse("6fb32bed-67ab-4c1f-8acd-7712d56296a8"), Code="UPGTONE", Description="Improvement of more than one full grade level", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
