//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefLeaveEventTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefLeaveEventType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLeaveEventType"> List
         /// </summary>
        public static List<RefLeaveEventType> RefLeaveEventTypeList = new List<RefLeaveEventType>
        {
            new RefLeaveEventType { Id=Guid.Parse("b1a2654d-d79d-4407-aff8-3b35e45c43a5"), Code="Administrative", Description="Administrative", Definition="Administrative is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLeaveEventType { Id=Guid.Parse("89cea147-1580-405b-8707-1ce6c6006c86"), Code="AnnualLeave", Description="Annual leave", Definition="Annual leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLeaveEventType { Id=Guid.Parse("f638eddb-4826-4e32-9bd2-9881820cce19"), Code="Bereavement", Description="Bereavement", Definition="Bereavement is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLeaveEventType { Id=Guid.Parse("5bd5e781-ca83-4a50-9085-b2b951b7615a"), Code="CompensatoryLeaveTime", Description="Compensatory leave time", Definition="Compensatory leave time is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLeaveEventType { Id=Guid.Parse("32d1e606-0065-4021-a21a-9560f80c14c6"), Code="FamilyAndMedicalLeave", Description="Family and medical leave", Definition="Family and medical leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("10.00") },
            new RefLeaveEventType { Id=Guid.Parse("82c91f8f-2ed5-4d49-b2f5-991b64ccb394"), Code="FlexTime", Description="Flex time", Definition="Flex time is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("11.00") },
            new RefLeaveEventType { Id=Guid.Parse("da2a9c38-500a-4bc5-876c-87a492ca7c97"), Code="GovernmentRequested", Description="Government-requested", Definition="Government-requested is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("12.00") },
            new RefLeaveEventType { Id=Guid.Parse("9bd30f2f-5e38-4181-a766-ab780a004a06"), Code="JuryDuty", Description="Jury Duty", Definition="Jury Duty is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("13.00") },
            new RefLeaveEventType { Id=Guid.Parse("7ad0cac8-a394-4cef-813d-ddc167dd023d"), Code="MilitaryLeave", Description="Military leave", Definition="Military leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("14.00") },
            new RefLeaveEventType { Id=Guid.Parse("d4ab82ae-dc96-4b80-af21-6fad90091757"), Code="Other", Description="Other", Definition="Other is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("16.00") },
            new RefLeaveEventType { Id=Guid.Parse("4a896695-75ed-4d4b-a81f-1f49b9eea12e"), Code="Personal", Description="Personal", Definition="Personal is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("18.00") },
            new RefLeaveEventType { Id=Guid.Parse("7d417314-43eb-407c-8263-a45847ab9c77"), Code="ProfessionalDevelopment", Description="Professional development", Definition="Professional development is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("19.00") },
            new RefLeaveEventType { Id=Guid.Parse("24f2735a-09dd-4c1c-b2c7-c42d12ca9de8"), Code="ReleaseTime", Description="Release time", Definition="Release time is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("20.00") },
            new RefLeaveEventType { Id=Guid.Parse("350fb876-cfaa-4aac-abda-e750bc6d1f13"), Code="SabbaticalLeave", Description="Sabbatical leave", Definition="Sabbatical leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("22.00") },
            new RefLeaveEventType { Id=Guid.Parse("0eda4daf-5d21-490c-9ad4-b363d9be2208"), Code="SickLeave", Description="Sick leave", Definition="Sick leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("24.00") },
            new RefLeaveEventType { Id=Guid.Parse("d7eeef16-ef9b-4c17-9680-271e63d0413d"), Code="Suspension", Description="Suspension", Definition="Suspension is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("26.00") },
            new RefLeaveEventType { Id=Guid.Parse("0281e092-1b44-48bc-80b9-34f071a4c569"), Code="WorkersCompensation", Description="Workers compensation", Definition="Workers compensation is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("32.00") },
        };

        /// <summary>
        /// The RefLeaveEventType Pick List
         /// </summary>
        public static List<RefLeaveEventType> RefLeaveEventTypePickList = new List<RefLeaveEventType>
        {
            new RefLeaveEventType { Id=Guid.Parse("b1a2654d-d79d-4407-aff8-3b35e45c43a5"), Code="Administrative", Description="Administrative", SortOrder=Convert.ToDecimal("2.00") },
            new RefLeaveEventType { Id=Guid.Parse("89cea147-1580-405b-8707-1ce6c6006c86"), Code="AnnualLeave", Description="Annual leave", SortOrder=Convert.ToDecimal("4.00") },
            new RefLeaveEventType { Id=Guid.Parse("f638eddb-4826-4e32-9bd2-9881820cce19"), Code="Bereavement", Description="Bereavement", SortOrder=Convert.ToDecimal("6.00") },
            new RefLeaveEventType { Id=Guid.Parse("5bd5e781-ca83-4a50-9085-b2b951b7615a"), Code="CompensatoryLeaveTime", Description="Compensatory leave time", SortOrder=Convert.ToDecimal("8.00") },
            new RefLeaveEventType { Id=Guid.Parse("32d1e606-0065-4021-a21a-9560f80c14c6"), Code="FamilyAndMedicalLeave", Description="Family and medical leave", SortOrder=Convert.ToDecimal("10.00") },
            new RefLeaveEventType { Id=Guid.Parse("82c91f8f-2ed5-4d49-b2f5-991b64ccb394"), Code="FlexTime", Description="Flex time", SortOrder=Convert.ToDecimal("11.00") },
            new RefLeaveEventType { Id=Guid.Parse("da2a9c38-500a-4bc5-876c-87a492ca7c97"), Code="GovernmentRequested", Description="Government-requested", SortOrder=Convert.ToDecimal("12.00") },
            new RefLeaveEventType { Id=Guid.Parse("9bd30f2f-5e38-4181-a766-ab780a004a06"), Code="JuryDuty", Description="Jury Duty", SortOrder=Convert.ToDecimal("13.00") },
            new RefLeaveEventType { Id=Guid.Parse("7ad0cac8-a394-4cef-813d-ddc167dd023d"), Code="MilitaryLeave", Description="Military leave", SortOrder=Convert.ToDecimal("14.00") },
            new RefLeaveEventType { Id=Guid.Parse("d4ab82ae-dc96-4b80-af21-6fad90091757"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("16.00") },
            new RefLeaveEventType { Id=Guid.Parse("4a896695-75ed-4d4b-a81f-1f49b9eea12e"), Code="Personal", Description="Personal", SortOrder=Convert.ToDecimal("18.00") },
            new RefLeaveEventType { Id=Guid.Parse("7d417314-43eb-407c-8263-a45847ab9c77"), Code="ProfessionalDevelopment", Description="Professional development", SortOrder=Convert.ToDecimal("19.00") },
            new RefLeaveEventType { Id=Guid.Parse("24f2735a-09dd-4c1c-b2c7-c42d12ca9de8"), Code="ReleaseTime", Description="Release time", SortOrder=Convert.ToDecimal("20.00") },
            new RefLeaveEventType { Id=Guid.Parse("350fb876-cfaa-4aac-abda-e750bc6d1f13"), Code="SabbaticalLeave", Description="Sabbatical leave", SortOrder=Convert.ToDecimal("22.00") },
            new RefLeaveEventType { Id=Guid.Parse("0eda4daf-5d21-490c-9ad4-b363d9be2208"), Code="SickLeave", Description="Sick leave", SortOrder=Convert.ToDecimal("24.00") },
            new RefLeaveEventType { Id=Guid.Parse("d7eeef16-ef9b-4c17-9680-271e63d0413d"), Code="Suspension", Description="Suspension", SortOrder=Convert.ToDecimal("26.00") },
            new RefLeaveEventType { Id=Guid.Parse("0281e092-1b44-48bc-80b9-34f071a4c569"), Code="WorkersCompensation", Description="Workers compensation", SortOrder=Convert.ToDecimal("32.00") },
       };
   }
}
