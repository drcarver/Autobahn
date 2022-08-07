//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefParticipationTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefParticipationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefParticipationTypeModel"> List
         /// </summary>
        public static List<RefParticipationTypeModel> RefParticipationTypeList = new List<RefParticipationTypeModel>
        {
            new RefParticipationType { Id=Guid.Parse("e1491f94-62c4-49c0-96c2-545d847c1984"), Code="GED Preparation Program Participation", Description="", Definition="GEDPreparationProgramParticipation", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("14dba21b-711e-4120-8ab8-5b5ba8917733"), Code="Gifted and Talented", Description="", Definition="GiftedandTalented", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("19bb488f-83d9-461c-b8ab-30b2188309e2"), Code="Homeless Serviced", Description="", Definition="HomelessServiced", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("6366fd29-4124-4914-9878-a3f8f7e56651"), Code="Migrant Education Program Participation", Description="", Definition="MEP Participation ", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("16050e04-aaca-4705-825c-52a0466215f3"), Code="Neglected or Delinquent", Description="", Definition="NeglectedorDelinquent", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("537cbc5a-dc26-4ed3-b5d4-11648f205392"), Code="Section 504", Description="", Definition="Section504", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("fc94afcc-77c8-49cc-b123-81069331ad13"), Code="Title III Immigrant Participation", Description="", Definition="TitleIIIImmigrantParticipation", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("4e0a3ce5-e284-464b-b03c-d75b961b6af0"), Code="Title I Schoolwide Program Participation", Description="", Definition="TitleISchoolwideProgramParticipation", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("1c61307a-a4a9-4ca6-a224-41259f828e64"), Code="Title I Targeted Assistance Participation", Description="", Definition="TitleITargetedAssistanceParticipation", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("650fe38e-5cac-457e-b2f8-2bb7f7b7c328"), Code="Title III English Learner Participation", Description="", Definition="Title III LEP Participation ", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("5947990b-9535-4bb8-8f64-9dc09e122f8c"), Code="Kindergarten Program Participation", Description="", Definition="KindergartenProgramParticipation", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("84457472-4aea-4662-a7f5-b2b1f4559564"), Code="Career Pathways Program Participation", Description="", Definition="CareerPathwaysProgramParticipation", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("1149cacb-712e-44a9-bd53-dea72bd7b598"), Code="Correctional Education Reentry Services Participation", Description="", Definition="CorrectionalEducationReentryServicesParticipation", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefParticipationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefParticipationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefParticipationType { Id=Guid.Parse("e1491f94-62c4-49c0-96c2-545d847c1984"), Description="", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("14dba21b-711e-4120-8ab8-5b5ba8917733"), Description="", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("19bb488f-83d9-461c-b8ab-30b2188309e2"), Description="", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("6366fd29-4124-4914-9878-a3f8f7e56651"), Description="", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("16050e04-aaca-4705-825c-52a0466215f3"), Description="", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("537cbc5a-dc26-4ed3-b5d4-11648f205392"), Description="", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("fc94afcc-77c8-49cc-b123-81069331ad13"), Description="", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("4e0a3ce5-e284-464b-b03c-d75b961b6af0"), Description="", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("1c61307a-a4a9-4ca6-a224-41259f828e64"), Description="", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("650fe38e-5cac-457e-b2f8-2bb7f7b7c328"), Description="", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("5947990b-9535-4bb8-8f64-9dc09e122f8c"), Description="", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("84457472-4aea-4662-a7f5-b2b1f4559564"), Description="", SortOrder=Convert.ToDecimal("") },
            new RefParticipationType { Id=Guid.Parse("1149cacb-712e-44a9-bd53-dea72bd7b598"), Description="", SortOrder=Convert.ToDecimal("") },
       };
   }
}
