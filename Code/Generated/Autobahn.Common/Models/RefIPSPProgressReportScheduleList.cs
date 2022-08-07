//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPSPProgressReportScheduleList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIPSPProgressReportSchedule Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIPSPProgressReportScheduleModel"> List
         /// </summary>
        public static List<RefIPSPProgressReportScheduleModel> RefIPSPProgressReportScheduleList = new List<RefIPSPProgressReportScheduleModel>
        {
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("6c170f73-63f6-4d06-a0c7-615eebb33b1a"), Code="Daily", Description="Daily", Definition="Daily is the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("117e4c45-b6c4-49ff-8b48-fbe7c062367c"), Code="Monthly", Description="Monthly", Definition="Monthly is the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("681411c0-b004-4039-8913-47d8279b7de8"), Code="Other", Description="Other", Definition="Other is specified as the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("9b4624d0-3c6f-454b-b581-9d55b9e9c561"), Code="Quarterly", Description="Quarterly", Definition="Quarterly is the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("453a8ac7-f47d-4046-a662-f9652bde1a50"), Code="Term", Description="Term", Definition="Term is the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("3ce8bc9e-10d0-4333-8aca-b69130b01ae7"), Code="Weekly", Description="Weekly", Definition="Weekly is the frequency by which parents are notified of the student's progress on annual goals.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefIPSPProgressReportSchedule Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIPSPProgressReportScheduleViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("6c170f73-63f6-4d06-a0c7-615eebb33b1a"), Description="Daily", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("117e4c45-b6c4-49ff-8b48-fbe7c062367c"), Description="Monthly", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("681411c0-b004-4039-8913-47d8279b7de8"), Description="Other", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("9b4624d0-3c6f-454b-b581-9d55b9e9c561"), Description="Quarterly", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("453a8ac7-f47d-4046-a662-f9652bde1a50"), Description="Term", SortOrder=Convert.ToDecimal("") },
            new RefIPSPProgressReportSchedule { Id=Guid.Parse("3ce8bc9e-10d0-4333-8aca-b69130b01ae7"), Description="Weekly", SortOrder=Convert.ToDecimal("") },
       };
   }
}
