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
        public static List<RefIPSPProgressReportSchedule> RefIPSPProgressReportScheduleList = new List<RefIPSPProgressReportSchedule>
        {
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("a3b78be4-4faf-4b20-8411-6f4a0548d428"), Code="Daily", Description="Daily", Definition="Daily is the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("942e1eb1-e522-4031-a972-fd78f3790f96"), Code="Monthly", Description="Monthly", Definition="Monthly is the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("685f52f5-a8ad-4845-b486-c689caca5808"), Code="Other", Description="Other", Definition="Other is specified as the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("389217d9-8486-4ff3-a6f7-83a52c2dda8a"), Code="Quarterly", Description="Quarterly", Definition="Quarterly is the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("fbe24160-1375-4435-9d5a-c9ddc900e250"), Code="Term", Description="Term", Definition="Term is the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("163bbc98-493b-4363-8eb0-8e7e46631491"), Code="Weekly", Description="Weekly", Definition="Weekly is the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefIPSPProgressReportSchedule Pick List
         /// </summary>
        public static List<RefIPSPProgressReportSchedule> RefIPSPProgressReportSchedulePickList = new List<RefIPSPProgressReportSchedule>
        {
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("a3b78be4-4faf-4b20-8411-6f4a0548d428"), Code="Daily", Description="Daily", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("942e1eb1-e522-4031-a972-fd78f3790f96"), Code="Monthly", Description="Monthly", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("685f52f5-a8ad-4845-b486-c689caca5808"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("389217d9-8486-4ff3-a6f7-83a52c2dda8a"), Code="Quarterly", Description="Quarterly", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("fbe24160-1375-4435-9d5a-c9ddc900e250"), Code="Term", Description="Term", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("163bbc98-493b-4363-8eb0-8e7e46631491"), Code="Weekly", Description="Weekly", SortOrder=Convert.ToDecimal("") },
       };
   }
}
