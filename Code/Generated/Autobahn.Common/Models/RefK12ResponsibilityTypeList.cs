//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefK12ResponsibilityTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefK12ResponsibilityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefK12ResponsibilityTypeModel"> List
         /// </summary>
        public static List<RefK12ResponsibilityTypeModel> RefK12ResponsibilityTypeList = new List<RefK12ResponsibilityTypeModel>
        {
            new RefK12ResponsibilityType { Id=Guid.Parse("2c907556-fef5-42cb-b23c-9caf422d7cfb"), Code="Accountability", Description="Accountability", Definition="The role/relationship type assigned to an organization, institution, or agency responsible for student learning under Federal ESEA and State accountability plans.  (e.g. for AYP reporting)", SortOrder=Convert.ToDecimal("1.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("a01a9e55-ef53-44eb-bf51-58cf0dcec0ba"), Code="Attendance", Description="Attendance", Definition="The role/relationship assigned to an organization, institution, or agency operating the physical or virtual site in which delivery of educational services take place.", SortOrder=Convert.ToDecimal("2.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("2780569a-0f93-40ad-9019-bb3c4a287e5c"), Code="Funding", Description="Funding", Definition="The role/relationship assigned to an organization, institution, or agency responsible for funding related to a student enrollment.  ", SortOrder=Convert.ToDecimal("3.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("dfaf2ad7-6ae8-44bf-8b97-5208be9c2877"), Code="Graduation", Description="Graduation", Definition="The role/relationship assigned to an organization, institution, or agency responsible for issuing/awarding diplomas.  (e.g. for graduation-rate reporting)", SortOrder=Convert.ToDecimal("4.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("bfba4173-e0b0-4b97-ba97-54ec87667d13"), Code="IndividualizedEducationProgram", Description="Individualized education program (IEP)", Definition="The role/relationship type assigned to an organization, institution, or agency responsible for creating and maintaining the student's IEP, a written instructional plan for students with disabilities designated as special education students under the Individuals with Disabilities Education Act (IDEA-Part B) which includes: 1) a statement of present levels of educational performance of a child; 2) a statement of annual goals including short-term instructional objectives; 3) a statement of specific education and related services to be provided and the extent to which the child will be able to participate in regular educational programs; 4) a projected date for initiation and anticipated duration of services; and 5) appropriate objectives, criteria and evaluation procedures and schedules for determining, on at least an annual basis, whether instructional objectives are being achieved.", SortOrder=Convert.ToDecimal("5.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("7fd42e92-a235-4b31-b5ef-f23557a5ca33"), Code="Transportation", Description="Transportation", Definition="The role/relationship type assigned to an organization, institution, or agency responsible for transporting the student to the physical location of the school or facility in which educational services are delivered.", SortOrder=Convert.ToDecimal("6.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("39aef341-db92-4b36-840e-ebf700b390d3"), Code="IEPServiceProvider", Description="Individualized education program service provider", Definition="The role/relationship type assigned to an organization, institution, or agency responsible for providing services to meet the requirements of the student's Individualized Education Program (IEP).", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefK12ResponsibilityType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefK12ResponsibilityTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefK12ResponsibilityType { Id=Guid.Parse("2c907556-fef5-42cb-b23c-9caf422d7cfb"), Description="Accountability", SortOrder=Convert.ToDecimal("1.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("a01a9e55-ef53-44eb-bf51-58cf0dcec0ba"), Description="Attendance", SortOrder=Convert.ToDecimal("2.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("2780569a-0f93-40ad-9019-bb3c4a287e5c"), Description="Funding", SortOrder=Convert.ToDecimal("3.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("dfaf2ad7-6ae8-44bf-8b97-5208be9c2877"), Description="Graduation", SortOrder=Convert.ToDecimal("4.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("bfba4173-e0b0-4b97-ba97-54ec87667d13"), Description="Individualized education program (IEP)", SortOrder=Convert.ToDecimal("5.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("7fd42e92-a235-4b31-b5ef-f23557a5ca33"), Description="Transportation", SortOrder=Convert.ToDecimal("6.00") },
            new RefK12ResponsibilityType { Id=Guid.Parse("39aef341-db92-4b36-840e-ebf700b390d3"), Description="Individualized education program service provider", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
