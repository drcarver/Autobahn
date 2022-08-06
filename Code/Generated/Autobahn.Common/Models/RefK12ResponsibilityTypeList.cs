//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefK12ResponsibilityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefK12ResponsibilityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefK12ResponsibilityType"> List
         /// </summary>
        public static List<RefK12ResponsibilityType> RefK12ResponsibilityTypeList = new List<RefK12ResponsibilityType> =
        {
            new RefK12ResponsibilityType { Id=Guid.Parse("43c470e6-64fd-4fb2-be0a-e2ddafcf1e69"), Code="The role/relationship type assigned to an organization, institution, or agency responsible for student learning under Federal ESEA and State accountability plans.  (e.g. for AYP reporting)", Description="Accountability", Definition="", SortOrder=0 },
            new RefK12ResponsibilityType { Id=Guid.Parse("4889d3b4-e60c-4a2d-b99a-31188f7165e0"), Code="The role/relationship assigned to an organization, institution, or agency operating the physical or virtual site in which delivery of educational services take place.", Description="Attendance", Definition="", SortOrder=0 },
            new RefK12ResponsibilityType { Id=Guid.Parse("0319d037-0838-4e0c-be5f-d47aae5b0ec6"), Code="The role/relationship assigned to an organization, institution, or agency responsible for funding related to a student enrollment.  ", Description="Funding", Definition="", SortOrder=0 },
            new RefK12ResponsibilityType { Id=Guid.Parse("79d4b932-ac3b-4fdb-a1a9-66946d39b67c"), Code="The role/relationship assigned to an organization, institution, or agency responsible for issuing/awarding diplomas.  (e.g. for graduation-rate reporting)", Description="Graduation", Definition="", SortOrder=0 },
            new RefK12ResponsibilityType { Id=Guid.Parse("f3979357-4893-410f-8d69-aac1ee51ac77"), Code="The role/relationship type assigned to an organization, institution, or agency responsible for creating and maintaining the student's IEP, a written instructional plan for students with disabilities designated as special education students under the Individuals with Disabilities Education Act (IDEA-Part B) which includes: 1) a statement of present levels of educational performance of a child; 2) a statement of annual goals including short-term instructional objectives; 3) a statement of specific education and related services to be provided and the extent to which the child will be able to participate in regular educational programs; 4) a projected date for initiation and anticipated duration of services; and 5) appropriate objectives, criteria and evaluation procedures and schedules for determining, on at least an annual basis, whether instructional objectives are being achieved.", Description="IndividualizedEducationProgram", Definition="", SortOrder=0 },
            new RefK12ResponsibilityType { Id=Guid.Parse("f449359e-b4e0-497f-aa70-8d20f18178f3"), Code="The role/relationship type assigned to an organization, institution, or agency responsible for transporting the student to the physical location of the school or facility in which educational services are delivered.", Description="Transportation", Definition="", SortOrder=0 },
            new RefK12ResponsibilityType { Id=Guid.Parse("75d2d574-fe1a-4025-98ef-06440de2f6c8"), Code="The role/relationship type assigned to an organization, institution, or agency responsible for providing services to meet the requirements of the student's Individualized Education Program (IEP).", Description="IEPServiceProvider", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefK12ResponsibilityType Pick List
         /// </summary>
        public static List<RefK12ResponsibilityType> RefK12ResponsibilityTypePickList = new List<RefK12ResponsibilityType> =
        {
            new RefK12ResponsibilityType { Id=Guid.Parse("43c470e6-64fd-4fb2-be0a-e2ddafcf1e69"), Code="The role/relationship type assigned to an organization, institution, or agency responsible for student learning under Federal ESEA and State accountability plans.  (e.g. for AYP reporting)", SortOrder=0 },
            new RefK12ResponsibilityType { Id=Guid.Parse("4889d3b4-e60c-4a2d-b99a-31188f7165e0"), Code="The role/relationship assigned to an organization, institution, or agency operating the physical or virtual site in which delivery of educational services take place.", SortOrder=0 },
            new RefK12ResponsibilityType { Id=Guid.Parse("0319d037-0838-4e0c-be5f-d47aae5b0ec6"), Code="The role/relationship assigned to an organization, institution, or agency responsible for funding related to a student enrollment.  ", SortOrder=0 },
            new RefK12ResponsibilityType { Id=Guid.Parse("79d4b932-ac3b-4fdb-a1a9-66946d39b67c"), Code="The role/relationship assigned to an organization, institution, or agency responsible for issuing/awarding diplomas.  (e.g. for graduation-rate reporting)", SortOrder=0 },
            new RefK12ResponsibilityType { Id=Guid.Parse("f3979357-4893-410f-8d69-aac1ee51ac77"), Code="The role/relationship type assigned to an organization, institution, or agency responsible for creating and maintaining the student's IEP, a written instructional plan for students with disabilities designated as special education students under the Individuals with Disabilities Education Act (IDEA-Part B) which includes: 1) a statement of present levels of educational performance of a child; 2) a statement of annual goals including short-term instructional objectives; 3) a statement of specific education and related services to be provided and the extent to which the child will be able to participate in regular educational programs; 4) a projected date for initiation and anticipated duration of services; and 5) appropriate objectives, criteria and evaluation procedures and schedules for determining, on at least an annual basis, whether instructional objectives are being achieved.", SortOrder=0 },
            new RefK12ResponsibilityType { Id=Guid.Parse("f449359e-b4e0-497f-aa70-8d20f18178f3"), Code="The role/relationship type assigned to an organization, institution, or agency responsible for transporting the student to the physical location of the school or facility in which educational services are delivered.", SortOrder=0 },
            new RefK12ResponsibilityType { Id=Guid.Parse("75d2d574-fe1a-4025-98ef-06440de2f6c8"), Code="The role/relationship type assigned to an organization, institution, or agency responsible for providing services to meet the requirements of the student's Individualized Education Program (IEP).", SortOrder=0 },
       };
   }
}
