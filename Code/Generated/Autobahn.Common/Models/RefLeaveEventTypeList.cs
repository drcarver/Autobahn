//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefLeaveEventTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefLeaveEventType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLeaveEventTypeModel"> List
         /// </summary>
        public static List<RefLeaveEventTypeModel> RefLeaveEventTypeList = new List<RefLeaveEventTypeModel>
        {
            new RefLeaveEventType { Id=Guid.Parse("a4f6915d-6e06-4817-a8e4-154bd01eaf7a"), Code="Administrative", Description="Administrative", Definition="Administrative is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLeaveEventType { Id=Guid.Parse("47d36747-97fd-438a-af4c-917c5d9051ad"), Code="AnnualLeave", Description="Annual leave", Definition="Annual leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLeaveEventType { Id=Guid.Parse("1abbc09f-671b-49ba-9e40-219b27d171d9"), Code="Bereavement", Description="Bereavement", Definition="Bereavement is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLeaveEventType { Id=Guid.Parse("4bf809fd-550d-46e9-8f60-3ce596d82bcf"), Code="CompensatoryLeaveTime", Description="Compensatory leave time", Definition="Compensatory leave time is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLeaveEventType { Id=Guid.Parse("f654884f-0df0-40f7-ab1e-49ce0c76f105"), Code="FamilyAndMedicalLeave", Description="Family and medical leave", Definition="Family and medical leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("10.00") },
            new RefLeaveEventType { Id=Guid.Parse("a194da94-d34b-4491-ae4a-05a2cc50c50a"), Code="FlexTime", Description="Flex time", Definition="Flex time is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("11.00") },
            new RefLeaveEventType { Id=Guid.Parse("9c8b029a-b561-417b-8eb5-fe01605208d3"), Code="GovernmentRequested", Description="Government-requested", Definition="Government-requested is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("12.00") },
            new RefLeaveEventType { Id=Guid.Parse("9233e6a6-42f4-42d1-9a24-0f46e26fdbdd"), Code="JuryDuty", Description="Jury Duty", Definition="Jury Duty is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("13.00") },
            new RefLeaveEventType { Id=Guid.Parse("a4b24665-377e-42ca-b437-bff328c29f37"), Code="MilitaryLeave", Description="Military leave", Definition="Military leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("14.00") },
            new RefLeaveEventType { Id=Guid.Parse("bbf94ecf-8e30-4935-8a16-25c4b8ccf314"), Code="Other", Description="Other", Definition="Other is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("16.00") },
            new RefLeaveEventType { Id=Guid.Parse("5593ce78-e7a4-4d3b-bb33-8d1267a21b81"), Code="Personal", Description="Personal", Definition="Personal is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("18.00") },
            new RefLeaveEventType { Id=Guid.Parse("8ee9167a-2ca0-49d5-af91-877cb6cbcf2a"), Code="ProfessionalDevelopment", Description="Professional development", Definition="Professional development is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("19.00") },
            new RefLeaveEventType { Id=Guid.Parse("74376b45-56b8-47c3-8246-8ead31bb7413"), Code="ReleaseTime", Description="Release time", Definition="Release time is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("20.00") },
            new RefLeaveEventType { Id=Guid.Parse("4a91dacd-983b-4c0b-a100-03b0e4a665eb"), Code="SabbaticalLeave", Description="Sabbatical leave", Definition="Sabbatical leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("22.00") },
            new RefLeaveEventType { Id=Guid.Parse("bd663859-7600-4a34-8046-67bf8e91b074"), Code="SickLeave", Description="Sick leave", Definition="Sick leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("24.00") },
            new RefLeaveEventType { Id=Guid.Parse("b37938f9-5038-4ab8-b998-9e88fdab89c7"), Code="Suspension", Description="Suspension", Definition="Suspension is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("26.00") },
            new RefLeaveEventType { Id=Guid.Parse("03e975f9-0fe3-4069-8be1-102ff01af5be"), Code="WorkersCompensation", Description="Workers compensation", Definition="Workers compensation is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("32.00") },
        };

        /// <summary>
        /// The Reference RefLeaveEventType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLeaveEventTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLeaveEventType { Id=Guid.Parse("a4f6915d-6e06-4817-a8e4-154bd01eaf7a"), Description="Administrative", SortOrder=Convert.ToDecimal("2.00") },
            new RefLeaveEventType { Id=Guid.Parse("47d36747-97fd-438a-af4c-917c5d9051ad"), Description="Annual leave", SortOrder=Convert.ToDecimal("4.00") },
            new RefLeaveEventType { Id=Guid.Parse("1abbc09f-671b-49ba-9e40-219b27d171d9"), Description="Bereavement", SortOrder=Convert.ToDecimal("6.00") },
            new RefLeaveEventType { Id=Guid.Parse("4bf809fd-550d-46e9-8f60-3ce596d82bcf"), Description="Compensatory leave time", SortOrder=Convert.ToDecimal("8.00") },
            new RefLeaveEventType { Id=Guid.Parse("f654884f-0df0-40f7-ab1e-49ce0c76f105"), Description="Family and medical leave", SortOrder=Convert.ToDecimal("10.00") },
            new RefLeaveEventType { Id=Guid.Parse("a194da94-d34b-4491-ae4a-05a2cc50c50a"), Description="Flex time", SortOrder=Convert.ToDecimal("11.00") },
            new RefLeaveEventType { Id=Guid.Parse("9c8b029a-b561-417b-8eb5-fe01605208d3"), Description="Government-requested", SortOrder=Convert.ToDecimal("12.00") },
            new RefLeaveEventType { Id=Guid.Parse("9233e6a6-42f4-42d1-9a24-0f46e26fdbdd"), Description="Jury Duty", SortOrder=Convert.ToDecimal("13.00") },
            new RefLeaveEventType { Id=Guid.Parse("a4b24665-377e-42ca-b437-bff328c29f37"), Description="Military leave", SortOrder=Convert.ToDecimal("14.00") },
            new RefLeaveEventType { Id=Guid.Parse("bbf94ecf-8e30-4935-8a16-25c4b8ccf314"), Description="Other", SortOrder=Convert.ToDecimal("16.00") },
            new RefLeaveEventType { Id=Guid.Parse("5593ce78-e7a4-4d3b-bb33-8d1267a21b81"), Description="Personal", SortOrder=Convert.ToDecimal("18.00") },
            new RefLeaveEventType { Id=Guid.Parse("8ee9167a-2ca0-49d5-af91-877cb6cbcf2a"), Description="Professional development", SortOrder=Convert.ToDecimal("19.00") },
            new RefLeaveEventType { Id=Guid.Parse("74376b45-56b8-47c3-8246-8ead31bb7413"), Description="Release time", SortOrder=Convert.ToDecimal("20.00") },
            new RefLeaveEventType { Id=Guid.Parse("4a91dacd-983b-4c0b-a100-03b0e4a665eb"), Description="Sabbatical leave", SortOrder=Convert.ToDecimal("22.00") },
            new RefLeaveEventType { Id=Guid.Parse("bd663859-7600-4a34-8046-67bf8e91b074"), Description="Sick leave", SortOrder=Convert.ToDecimal("24.00") },
            new RefLeaveEventType { Id=Guid.Parse("b37938f9-5038-4ab8-b998-9e88fdab89c7"), Description="Suspension", SortOrder=Convert.ToDecimal("26.00") },
            new RefLeaveEventType { Id=Guid.Parse("03e975f9-0fe3-4069-8be1-102ff01af5be"), Description="Workers compensation", SortOrder=Convert.ToDecimal("32.00") },
       };
   }
}
