//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   RefWfProgramParticipationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Workforce.Models
{
     /// <summary>
     /// The list of RefWfProgramParticipation Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefWfProgramParticipationModel"> List
         /// </summary>
        public static List<RefWfProgramParticipationModel> RefWfProgramParticipationList = new List<RefWfProgramParticipationModel>
        {
            new RefWfProgramParticipation { Id=Guid.Parse("65733c3c-e9ff-4450-8412-adef7c34eb33"), Code="01", Description="Labor Exchange Services", Definition="The person's workforce and employment development program participation is Labor Exchange Services.", SortOrder=Convert.ToDecimal("0.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("ae347670-4d88-49f4-a712-ef12c03a71fa"), Code="02", Description="Adult Workforce Investment Act Program", Definition="The person's workforce and employment development program participation is an Adult Workforce Investment Act Program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("bf959df1-2902-4978-9e2a-10a1b386f8d2"), Code="03", Description="Dislocated Worker Workforce Investment Act Program", Definition="The person's workforce and employment development program participation is a Dislocated Worker Workforce Investment Act Program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("a4c1c6f5-912f-4498-8047-58067b77dc7f"), Code="04", Description="Youth Workforce Investment Act Program", Definition="The person's workforce and employment development program participation is a Youth Workforce Investment Act Program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("e37007ce-3bdb-446f-9540-d264e5ccd7af"), Code="05", Description="Job Corps", Definition="The person's workforce and employment development program participation is the Job Corps.", SortOrder=Convert.ToDecimal("4.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("0b5f8a6e-54f7-4116-b876-23be853797f1"), Code="06", Description="Adult Education and Literacy", Definition="The person's workforce and employment development program participation is Adult Education and Literacy.", SortOrder=Convert.ToDecimal("5.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("b9e649c4-6462-4e12-be89-d8d73e073371"), Code="07", Description="National Farmworker Jobs Program", Definition="The person's workforce and employment development program participation is with the National Farmworker Jobs Program.", SortOrder=Convert.ToDecimal("6.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("9f41c308-1fe2-458a-8f99-4a4519221602"), Code="08", Description="Indian and Native American Programs", Definition="The person's workforce and employment development program participation is with the Indian and Native American Programs.", SortOrder=Convert.ToDecimal("7.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("48d88874-3256-4535-a1de-c4ea2feb318c"), Code="09", Description="Veteran's Programs", Definition="The person's workforce and employment development program participation is with the Veteran's Programs.", SortOrder=Convert.ToDecimal("8.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("7c04239a-d9ac-4b41-8591-b253fe82e03f"), Code="10", Description="Trade Adjustment Assistance Program", Definition="The person's workforce and employment development program participation is with the Trade Adjustment Assistance Program.", SortOrder=Convert.ToDecimal("9.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("486398e7-6301-48eb-90d2-553e6203bc8b"), Code="11", Description="YouthBuild Program", Definition="The person's workforce and employment development program participation is with the YouthBuild Program.", SortOrder=Convert.ToDecimal("10.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("0fe6123d-dd6a-461f-8e8f-8fba106fa23c"), Code="12", Description="Title V Older Worker Program", Definition="The person's workforce and employment development program participation is with the Title V Older Worker Program.", SortOrder=Convert.ToDecimal("20.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("8edb9a63-d52b-4a6e-8bb2-ed4a6ffcac06"), Code="13", Description="Registered Apprenticeship", Definition="The person's workforce and employment development program participation is a Registered Apprenticeship.", SortOrder=Convert.ToDecimal("21.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("e20506e9-ad59-45d0-a70f-ed22aab1a461"), Code="14", Description="Non-traditional Apprenticeship", Definition="The person's workforce and employment development program participation is a Non-traditional Apprenticeship.", SortOrder=Convert.ToDecimal("22.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("9bce8c34-3dbf-46d7-866a-785eba87c421"), Code="15", Description="Vocational Rehabilitation", Definition="The person's workforce and employment development program participation is Vocational Rehabilitation.", SortOrder=Convert.ToDecimal("23.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("d130d177-d8b3-4556-aa75-727d4b4748ef"), Code="16", Description="Food Stamp Employment and Training Program", Definition="The person's workforce and employment development program participation is with the Food Stamp Employment and Training Program.", SortOrder=Convert.ToDecimal("24.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("82805fa4-5bfd-4741-9df4-b345ff955798"), Code="17", Description="TANF Employment and Training Program", Definition="The person's workforce and employment development program participation is with the TANF Employment and Training Program.", SortOrder=Convert.ToDecimal("25.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("1d152a7c-f204-4c37-ac7a-d33ab00d2661"), Code="18", Description="Other On-The-Job training Program", Definition="The person's workforce and employment development program participation is with an Other On-The-Job training Program.", SortOrder=Convert.ToDecimal("26.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("5437ea66-3085-47d6-9cd4-124723a2de6c"), Code="19", Description="Other Workforce Related Employment and Training Program", Definition="The person's workforce and employment development program participation is with the an Other Workforce Related Employment and Training Program.", SortOrder=Convert.ToDecimal("27.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("ac539ffa-da2a-4fea-8591-6f8dcc5c88d1"), Code="99", Description="No identified services", Definition="No identified services are related to the person's workforce and employment development program participation. ", SortOrder=Convert.ToDecimal("28.00") },
        };

        /// <summary>
        /// The Reference RefWfProgramParticipation Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefWfProgramParticipationViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefWfProgramParticipation { Id=Guid.Parse("65733c3c-e9ff-4450-8412-adef7c34eb33"), Description="Labor Exchange Services", SortOrder=Convert.ToDecimal("0.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("ae347670-4d88-49f4-a712-ef12c03a71fa"), Description="Adult Workforce Investment Act Program", SortOrder=Convert.ToDecimal("1.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("bf959df1-2902-4978-9e2a-10a1b386f8d2"), Description="Dislocated Worker Workforce Investment Act Program", SortOrder=Convert.ToDecimal("2.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("a4c1c6f5-912f-4498-8047-58067b77dc7f"), Description="Youth Workforce Investment Act Program", SortOrder=Convert.ToDecimal("3.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("e37007ce-3bdb-446f-9540-d264e5ccd7af"), Description="Job Corps", SortOrder=Convert.ToDecimal("4.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("0b5f8a6e-54f7-4116-b876-23be853797f1"), Description="Adult Education and Literacy", SortOrder=Convert.ToDecimal("5.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("b9e649c4-6462-4e12-be89-d8d73e073371"), Description="National Farmworker Jobs Program", SortOrder=Convert.ToDecimal("6.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("9f41c308-1fe2-458a-8f99-4a4519221602"), Description="Indian and Native American Programs", SortOrder=Convert.ToDecimal("7.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("48d88874-3256-4535-a1de-c4ea2feb318c"), Description="Veteran's Programs", SortOrder=Convert.ToDecimal("8.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("7c04239a-d9ac-4b41-8591-b253fe82e03f"), Description="Trade Adjustment Assistance Program", SortOrder=Convert.ToDecimal("9.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("486398e7-6301-48eb-90d2-553e6203bc8b"), Description="YouthBuild Program", SortOrder=Convert.ToDecimal("10.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("0fe6123d-dd6a-461f-8e8f-8fba106fa23c"), Description="Title V Older Worker Program", SortOrder=Convert.ToDecimal("20.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("8edb9a63-d52b-4a6e-8bb2-ed4a6ffcac06"), Description="Registered Apprenticeship", SortOrder=Convert.ToDecimal("21.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("e20506e9-ad59-45d0-a70f-ed22aab1a461"), Description="Non-traditional Apprenticeship", SortOrder=Convert.ToDecimal("22.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("9bce8c34-3dbf-46d7-866a-785eba87c421"), Description="Vocational Rehabilitation", SortOrder=Convert.ToDecimal("23.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("d130d177-d8b3-4556-aa75-727d4b4748ef"), Description="Food Stamp Employment and Training Program", SortOrder=Convert.ToDecimal("24.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("82805fa4-5bfd-4741-9df4-b345ff955798"), Description="TANF Employment and Training Program", SortOrder=Convert.ToDecimal("25.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("1d152a7c-f204-4c37-ac7a-d33ab00d2661"), Description="Other On-The-Job training Program", SortOrder=Convert.ToDecimal("26.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("5437ea66-3085-47d6-9cd4-124723a2de6c"), Description="Other Workforce Related Employment and Training Program", SortOrder=Convert.ToDecimal("27.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("ac539ffa-da2a-4fea-8591-6f8dcc5c88d1"), Description="No identified services", SortOrder=Convert.ToDecimal("28.00") },
       };
   }
}
