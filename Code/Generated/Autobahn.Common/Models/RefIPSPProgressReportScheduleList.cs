//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPSPProgressReportScheduleList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIPSPProgressReportSchedule Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIPSPProgressReportSchedule"> List
         /// </summary>
        public static List<RefIPSPProgressReportSchedule> RefIPSPProgressReportScheduleList = new List<RefIPSPProgressReportSchedule> =
        {
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("65b853ff-1cf1-452f-9b8a-00e423fd28bf"), Code="Daily is the frequency by which parents are notified of the student's progress on annual goals.", Description="Daily", Definition="", SortOrder=0 },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("f54d20e9-3634-49d0-8e3a-b361c0080ce4"), Code="Monthly is the frequency by which parents are notified of the student's progress on annual goals.", Description="Monthly", Definition="", SortOrder=0 },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("69e3908d-5626-45e7-8a3c-5c0eff035006"), Code="Other is specified as the frequency by which parents are notified of the student's progress on annual goals.", Description="Other", Definition="", SortOrder=0 },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("8c783b8d-84ca-4c66-b72b-a12233a31129"), Code="Quarterly is the frequency by which parents are notified of the student's progress on annual goals.", Description="Quarterly", Definition="", SortOrder=0 },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("94616a36-dab3-4664-a29d-7dbd94a70f01"), Code="Term is the frequency by which parents are notified of the student's progress on annual goals.", Description="Term", Definition="", SortOrder=0 },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("75346354-0245-4c3e-95f6-dc26aa15f9d2"), Code="Weekly is the frequency by which parents are notified of the student's progress on annual goals.", Description="Weekly", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIPSPProgressReportSchedule Pick List
         /// </summary>
        public static List<RefIPSPProgressReportSchedule> RefIPSPProgressReportSchedulePickList = new List<RefIPSPProgressReportSchedule> =
        {
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("65b853ff-1cf1-452f-9b8a-00e423fd28bf"), Code="Daily is the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=0 },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("f54d20e9-3634-49d0-8e3a-b361c0080ce4"), Code="Monthly is the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=0 },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("69e3908d-5626-45e7-8a3c-5c0eff035006"), Code="Other is specified as the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=0 },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("8c783b8d-84ca-4c66-b72b-a12233a31129"), Code="Quarterly is the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=0 },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("94616a36-dab3-4664-a29d-7dbd94a70f01"), Code="Term is the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=0 },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("75346354-0245-4c3e-95f6-dc26aa15f9d2"), Code="Weekly is the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=0 },
       };
   }
}
