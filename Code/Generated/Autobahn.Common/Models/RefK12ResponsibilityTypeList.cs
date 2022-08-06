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
        public static List<RefK12ResponsibilityType> RefK12ResponsibilityTypeList = new List<RefK12ResponsibilityType>
        {
            new RefK12ResponsibilityType { Id=Guid.Parse("214991a6-8337-4af0-8f2b-2b70d4de2cd4"), Code="Accountability", Description="Accountability", Definition="The role/relationship type assigned to an organization, institution, or agency responsible for student learning under Federal ESEA and State accountability plans.  (e.g. for AYP reporting)", SortOrder=Convert.ToDecimal("1.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("3498b5ba-a814-44c4-bb95-005472940588"), Code="Attendance", Description="Attendance", Definition="The role/relationship assigned to an organization, institution, or agency operating the physical or virtual site in which delivery of educational services take place.", SortOrder=Convert.ToDecimal("2.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("da22f0bc-fdae-4038-84c1-3501b33a0e17"), Code="Funding", Description="Funding", Definition="The role/relationship assigned to an organization, institution, or agency responsible for funding related to a student enrollment.  ", SortOrder=Convert.ToDecimal("3.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("cb0aa537-71ef-47f2-a2d4-7ec776b72e67"), Code="Graduation", Description="Graduation", Definition="The role/relationship assigned to an organization, institution, or agency responsible for issuing/awarding diplomas.  (e.g. for graduation-rate reporting)", SortOrder=Convert.ToDecimal("4.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("aea395d4-f3bd-4dab-b8bf-cfa2e9e1f254"), Code="IndividualizedEducationProgram", Description="Individualized education program (IEP)", Definition="The role/relationship type assigned to an organization, institution, or agency responsible for creating and maintaining the student's IEP, a written instructional plan for students with disabilities designated as special education students under the Individuals with Disabilities Education Act (IDEA-Part B) which includes: 1) a statement of present levels of educational performance of a child; 2) a statement of annual goals including short-term instructional objectives; 3) a statement of specific education and related services to be provided and the extent to which the child will be able to participate in regular educational programs; 4) a projected date for initiation and anticipated duration of services; and 5) appropriate objectives, criteria and evaluation procedures and schedules for determining, on at least an annual basis, whether instructional objectives are being achieved.", SortOrder=Convert.ToDecimal("5.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("6262bdc4-a5e8-4ad4-8657-96e3ccb93f42"), Code="Transportation", Description="Transportation", Definition="The role/relationship type assigned to an organization, institution, or agency responsible for transporting the student to the physical location of the school or facility in which educational services are delivered.", SortOrder=Convert.ToDecimal("6.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("0d600eb1-5512-4c54-af48-b817bce5f152"), Code="IEPServiceProvider", Description="Individualized education program service provider", Definition="The role/relationship type assigned to an organization, institution, or agency responsible for providing services to meet the requirements of the student's Individualized Education Program (IEP).", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefK12ResponsibilityType Pick List
         /// </summary>
        public static List<RefK12ResponsibilityType> RefK12ResponsibilityTypePickList = new List<RefK12ResponsibilityType>
        {
            new RefK12ResponsibilityType { Id=Guid.Parse("214991a6-8337-4af0-8f2b-2b70d4de2cd4"), Code="Accountability", Description="Accountability", SortOrder=Convert.ToDecimal("1.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("3498b5ba-a814-44c4-bb95-005472940588"), Code="Attendance", Description="Attendance", SortOrder=Convert.ToDecimal("2.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("da22f0bc-fdae-4038-84c1-3501b33a0e17"), Code="Funding", Description="Funding", SortOrder=Convert.ToDecimal("3.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("cb0aa537-71ef-47f2-a2d4-7ec776b72e67"), Code="Graduation", Description="Graduation", SortOrder=Convert.ToDecimal("4.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("aea395d4-f3bd-4dab-b8bf-cfa2e9e1f254"), Code="IndividualizedEducationProgram", Description="Individualized education program (IEP)", SortOrder=Convert.ToDecimal("5.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("6262bdc4-a5e8-4ad4-8657-96e3ccb93f42"), Code="Transportation", Description="Transportation", SortOrder=Convert.ToDecimal("6.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("0d600eb1-5512-4c54-af48-b817bce5f152"), Code="IEPServiceProvider", Description="Individualized education program service provider", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
