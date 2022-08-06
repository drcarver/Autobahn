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
        /// The complete <see cref="RefWfProgramParticipation"> List
         /// </summary>
        public static List<RefWfProgramParticipation> RefWfProgramParticipationList = new List<RefWfProgramParticipation>
        {
            new RefWfProgramParticipation { Id=Guid.Parse("86d89670-da74-42e2-8965-bd3f8800c9c7"), Code="01", Description="Labor Exchange Services", Definition="The person's workforce and employment development program participation is Labor Exchange Services.", SortOrder=Convert.ToDecimal("0.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("fdd3ad68-fd28-4d41-bad0-de2f1463c35d"), Code="02", Description="Adult Workforce Investment Act Program", Definition="The person's workforce and employment development program participation is an Adult Workforce Investment Act Program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("9c570433-83cb-4e19-8ed6-6b55095836b3"), Code="03", Description="Dislocated Worker Workforce Investment Act Program", Definition="The person's workforce and employment development program participation is a Dislocated Worker Workforce Investment Act Program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("878c83da-a800-49cb-b187-df3993b9677f"), Code="04", Description="Youth Workforce Investment Act Program", Definition="The person's workforce and employment development program participation is a Youth Workforce Investment Act Program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("a3fe3a50-6285-46c5-905a-6e1528c69dd5"), Code="05", Description="Job Corps", Definition="The person's workforce and employment development program participation is the Job Corps.", SortOrder=Convert.ToDecimal("4.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("a0e8e289-1b11-49d0-a49c-f0095e2bee66"), Code="06", Description="Adult Education and Literacy", Definition="The person's workforce and employment development program participation is Adult Education and Literacy.", SortOrder=Convert.ToDecimal("5.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("157d474b-8f23-4e1b-823b-7329ddd573ea"), Code="07", Description="National Farmworker Jobs Program", Definition="The person's workforce and employment development program participation is with the National Farmworker Jobs Program.", SortOrder=Convert.ToDecimal("6.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("104b7197-2bb9-4649-97fc-feaa2bd82e8b"), Code="08", Description="Indian and Native American Programs", Definition="The person's workforce and employment development program participation is with the Indian and Native American Programs.", SortOrder=Convert.ToDecimal("7.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("ed50da56-e602-4e56-84c9-5b463dd7eba3"), Code="09", Description="Veteran's Programs", Definition="The person's workforce and employment development program participation is with the Veteran's Programs.", SortOrder=Convert.ToDecimal("8.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("86aa841e-6ef4-432d-b9ca-e19db70f1451"), Code="10", Description="Trade Adjustment Assistance Program", Definition="The person's workforce and employment development program participation is with the Trade Adjustment Assistance Program.", SortOrder=Convert.ToDecimal("9.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("94b6e55a-c1ca-46e1-ba9d-ad8446fe5a6a"), Code="11", Description="YouthBuild Program", Definition="The person's workforce and employment development program participation is with the YouthBuild Program.", SortOrder=Convert.ToDecimal("10.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("0b2246b9-5ca6-4106-bc99-743e05be99fc"), Code="12", Description="Title V Older Worker Program", Definition="The person's workforce and employment development program participation is with the Title V Older Worker Program.", SortOrder=Convert.ToDecimal("20.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("6ca26668-d35d-4174-b824-f59a0ba359c2"), Code="13", Description="Registered Apprenticeship", Definition="The person's workforce and employment development program participation is a Registered Apprenticeship.", SortOrder=Convert.ToDecimal("21.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("b0fe0c83-05e9-4194-9e62-31d2d3df7d1b"), Code="14", Description="Non-traditional Apprenticeship", Definition="The person's workforce and employment development program participation is a Non-traditional Apprenticeship.", SortOrder=Convert.ToDecimal("22.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("f892981c-4078-4c0a-a3b3-22b1e07128d3"), Code="15", Description="Vocational Rehabilitation", Definition="The person's workforce and employment development program participation is Vocational Rehabilitation.", SortOrder=Convert.ToDecimal("23.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("cc9aa0b1-cc61-40d3-8951-3add0b7c5ddb"), Code="16", Description="Food Stamp Employment and Training Program", Definition="The person's workforce and employment development program participation is with the Food Stamp Employment and Training Program.", SortOrder=Convert.ToDecimal("24.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("e4670b3c-f6ae-4663-87d9-fa670b3d2c8b"), Code="17", Description="TANF Employment and Training Program", Definition="The person's workforce and employment development program participation is with the TANF Employment and Training Program.", SortOrder=Convert.ToDecimal("25.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("6b10f6f2-b8f2-4a49-9259-e9d5d3a5570d"), Code="18", Description="Other On-The-Job training Program", Definition="The person's workforce and employment development program participation is with an Other On-The-Job training Program.", SortOrder=Convert.ToDecimal("26.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("cf2de60c-3952-4b20-8595-ff6ef221902a"), Code="19", Description="Other Workforce Related Employment and Training Program", Definition="The person's workforce and employment development program participation is with the an Other Workforce Related Employment and Training Program.", SortOrder=Convert.ToDecimal("27.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("2703af14-3f05-478c-b0d8-fdc61b08ce81"), Code="99", Description="No identified services", Definition="No identified services are related to the person's workforce and employment development program participation. ", SortOrder=Convert.ToDecimal("28.00") },
        };

        /// <summary>
        /// The RefWfProgramParticipation Pick List
         /// </summary>
        public static List<RefWfProgramParticipation> RefWfProgramParticipationPickList = new List<RefWfProgramParticipation>
        {
            new RefWfProgramParticipation { Id=Guid.Parse("86d89670-da74-42e2-8965-bd3f8800c9c7"), Code="01", Description="Labor Exchange Services", SortOrder=Convert.ToDecimal("0.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("fdd3ad68-fd28-4d41-bad0-de2f1463c35d"), Code="02", Description="Adult Workforce Investment Act Program", SortOrder=Convert.ToDecimal("1.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("9c570433-83cb-4e19-8ed6-6b55095836b3"), Code="03", Description="Dislocated Worker Workforce Investment Act Program", SortOrder=Convert.ToDecimal("2.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("878c83da-a800-49cb-b187-df3993b9677f"), Code="04", Description="Youth Workforce Investment Act Program", SortOrder=Convert.ToDecimal("3.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("a3fe3a50-6285-46c5-905a-6e1528c69dd5"), Code="05", Description="Job Corps", SortOrder=Convert.ToDecimal("4.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("a0e8e289-1b11-49d0-a49c-f0095e2bee66"), Code="06", Description="Adult Education and Literacy", SortOrder=Convert.ToDecimal("5.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("157d474b-8f23-4e1b-823b-7329ddd573ea"), Code="07", Description="National Farmworker Jobs Program", SortOrder=Convert.ToDecimal("6.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("104b7197-2bb9-4649-97fc-feaa2bd82e8b"), Code="08", Description="Indian and Native American Programs", SortOrder=Convert.ToDecimal("7.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("ed50da56-e602-4e56-84c9-5b463dd7eba3"), Code="09", Description="Veteran's Programs", SortOrder=Convert.ToDecimal("8.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("86aa841e-6ef4-432d-b9ca-e19db70f1451"), Code="10", Description="Trade Adjustment Assistance Program", SortOrder=Convert.ToDecimal("9.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("94b6e55a-c1ca-46e1-ba9d-ad8446fe5a6a"), Code="11", Description="YouthBuild Program", SortOrder=Convert.ToDecimal("10.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("0b2246b9-5ca6-4106-bc99-743e05be99fc"), Code="12", Description="Title V Older Worker Program", SortOrder=Convert.ToDecimal("20.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("6ca26668-d35d-4174-b824-f59a0ba359c2"), Code="13", Description="Registered Apprenticeship", SortOrder=Convert.ToDecimal("21.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("b0fe0c83-05e9-4194-9e62-31d2d3df7d1b"), Code="14", Description="Non-traditional Apprenticeship", SortOrder=Convert.ToDecimal("22.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("f892981c-4078-4c0a-a3b3-22b1e07128d3"), Code="15", Description="Vocational Rehabilitation", SortOrder=Convert.ToDecimal("23.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("cc9aa0b1-cc61-40d3-8951-3add0b7c5ddb"), Code="16", Description="Food Stamp Employment and Training Program", SortOrder=Convert.ToDecimal("24.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("e4670b3c-f6ae-4663-87d9-fa670b3d2c8b"), Code="17", Description="TANF Employment and Training Program", SortOrder=Convert.ToDecimal("25.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("6b10f6f2-b8f2-4a49-9259-e9d5d3a5570d"), Code="18", Description="Other On-The-Job training Program", SortOrder=Convert.ToDecimal("26.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("cf2de60c-3952-4b20-8595-ff6ef221902a"), Code="19", Description="Other Workforce Related Employment and Training Program", SortOrder=Convert.ToDecimal("27.00") },
            new RefWfProgramParticipation { Id=Guid.Parse("2703af14-3f05-478c-b0d8-fdc61b08ce81"), Code="99", Description="No identified services", SortOrder=Convert.ToDecimal("28.00") },
       };
   }
}
