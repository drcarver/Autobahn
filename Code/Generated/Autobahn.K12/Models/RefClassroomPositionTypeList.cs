//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefClassroomPositionTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefClassroomPositionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefClassroomPositionTypeModel"> List
         /// </summary>
        public static List<RefClassroomPositionTypeModel> RefClassroomPositionTypeList = new List<RefClassroomPositionTypeModel>
        {
            new RefClassroomPositionType { Id=Guid.Parse("cfaca61d-3558-4538-91ab-32e5a081933c"), Code="03187", Description="Administrative staff", Definition="Administrative staff is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("0.00") },
            new RefClassroomPositionType { Id=Guid.Parse("91d6d253-68b5-4a07-9903-a0df98d1c002"), Code="73071", Description="Co-teacher", Definition="Co-teacher is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("1.00") },
            new RefClassroomPositionType { Id=Guid.Parse("703575f7-ec45-4777-b638-0bac86668d9c"), Code="04725", Description="Counselor", Definition="Counselor is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("2.00") },
            new RefClassroomPositionType { Id=Guid.Parse("43cc009f-2124-49cb-b81b-76ffa7dec34e"), Code="73073", Description="Course Proctor", Definition="Course Proctor is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("3.00") },
            new RefClassroomPositionType { Id=Guid.Parse("7c6cf3c5-eaa9-4e9e-8eb1-2a3c11f19b96"), Code="05973", Description="Instructor of record", Definition="Instructor of record is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("4.00") },
            new RefClassroomPositionType { Id=Guid.Parse("5075a9ab-5903-4531-9b42-457addd73f0a"), Code="01234", Description="Intern", Definition="Intern is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("6.00") },
            new RefClassroomPositionType { Id=Guid.Parse("fcc81097-b401-40fc-8a75-e6d7e87ca518"), Code="73072", Description="Lead Team Teacher", Definition="Lead Team Teacher is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("7.00") },
            new RefClassroomPositionType { Id=Guid.Parse("392cd180-fbed-4f7c-8267-f0687ee4c97d"), Code="00069", Description="Non-instructional staff", Definition="Non-instructional staff is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("8.00") },
            new RefClassroomPositionType { Id=Guid.Parse("2e53e00b-0421-49f2-85a4-0d8f16eec337"), Code="09999", Description="Other", Definition="Other is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("10.00") },
            new RefClassroomPositionType { Id=Guid.Parse("4f48c042-ecec-4155-892e-ab39c818995b"), Code="00059", Description="Paraprofessionals/teacher aides", Definition="Paraprofessionals/teacher aides is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("12.00") },
            new RefClassroomPositionType { Id=Guid.Parse("bf544ba3-29d0-4f8e-871e-29f623911d8c"), Code="05971", Description="Primary instructor", Definition="Primary instructor is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("14.00") },
            new RefClassroomPositionType { Id=Guid.Parse("6c661d78-cf8d-465f-8c75-1634d7975dbe"), Code="04735", Description="Resource teacher", Definition="Resource teacher is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("16.00") },
            new RefClassroomPositionType { Id=Guid.Parse("5cad2509-2041-4dfb-bc44-a5ae477567ac"), Code="05972", Description="Secondary instructor", Definition="Secondary instructor is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("18.00") },
            new RefClassroomPositionType { Id=Guid.Parse("5a448502-46c9-4786-b3f7-bc3e8d0c324d"), Code="73074", Description="Special Education Consultant", Definition="Special Education Consultant is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("19.00") },
            new RefClassroomPositionType { Id=Guid.Parse("c15a9141-47df-4ac4-b411-dac793b9ce66"), Code="00080", Description="Student teachers", Definition="Student teachers is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("20.00") },
            new RefClassroomPositionType { Id=Guid.Parse("9210d812-3269-423a-807d-a874f8bcf422"), Code="01382", Description="Volunteer/no contract", Definition="Volunteer/no contract is specified as the type of position the staff member holds in the specific course section.", SortOrder=Convert.ToDecimal("22.00") },
        };

        /// <summary>
        /// The Reference RefClassroomPositionType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefClassroomPositionTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefClassroomPositionType { Id=Guid.Parse("cfaca61d-3558-4538-91ab-32e5a081933c"), Description="Administrative staff", SortOrder=Convert.ToDecimal("0.00") },
            new RefClassroomPositionType { Id=Guid.Parse("91d6d253-68b5-4a07-9903-a0df98d1c002"), Description="Co-teacher", SortOrder=Convert.ToDecimal("1.00") },
            new RefClassroomPositionType { Id=Guid.Parse("703575f7-ec45-4777-b638-0bac86668d9c"), Description="Counselor", SortOrder=Convert.ToDecimal("2.00") },
            new RefClassroomPositionType { Id=Guid.Parse("43cc009f-2124-49cb-b81b-76ffa7dec34e"), Description="Course Proctor", SortOrder=Convert.ToDecimal("3.00") },
            new RefClassroomPositionType { Id=Guid.Parse("7c6cf3c5-eaa9-4e9e-8eb1-2a3c11f19b96"), Description="Instructor of record", SortOrder=Convert.ToDecimal("4.00") },
            new RefClassroomPositionType { Id=Guid.Parse("5075a9ab-5903-4531-9b42-457addd73f0a"), Description="Intern", SortOrder=Convert.ToDecimal("6.00") },
            new RefClassroomPositionType { Id=Guid.Parse("fcc81097-b401-40fc-8a75-e6d7e87ca518"), Description="Lead Team Teacher", SortOrder=Convert.ToDecimal("7.00") },
            new RefClassroomPositionType { Id=Guid.Parse("392cd180-fbed-4f7c-8267-f0687ee4c97d"), Description="Non-instructional staff", SortOrder=Convert.ToDecimal("8.00") },
            new RefClassroomPositionType { Id=Guid.Parse("2e53e00b-0421-49f2-85a4-0d8f16eec337"), Description="Other", SortOrder=Convert.ToDecimal("10.00") },
            new RefClassroomPositionType { Id=Guid.Parse("4f48c042-ecec-4155-892e-ab39c818995b"), Description="Paraprofessionals/teacher aides", SortOrder=Convert.ToDecimal("12.00") },
            new RefClassroomPositionType { Id=Guid.Parse("bf544ba3-29d0-4f8e-871e-29f623911d8c"), Description="Primary instructor", SortOrder=Convert.ToDecimal("14.00") },
            new RefClassroomPositionType { Id=Guid.Parse("6c661d78-cf8d-465f-8c75-1634d7975dbe"), Description="Resource teacher", SortOrder=Convert.ToDecimal("16.00") },
            new RefClassroomPositionType { Id=Guid.Parse("5cad2509-2041-4dfb-bc44-a5ae477567ac"), Description="Secondary instructor", SortOrder=Convert.ToDecimal("18.00") },
            new RefClassroomPositionType { Id=Guid.Parse("5a448502-46c9-4786-b3f7-bc3e8d0c324d"), Description="Special Education Consultant", SortOrder=Convert.ToDecimal("19.00") },
            new RefClassroomPositionType { Id=Guid.Parse("c15a9141-47df-4ac4-b411-dac793b9ce66"), Description="Student teachers", SortOrder=Convert.ToDecimal("20.00") },
            new RefClassroomPositionType { Id=Guid.Parse("9210d812-3269-423a-807d-a874f8bcf422"), Description="Volunteer/no contract", SortOrder=Convert.ToDecimal("22.00") },
       };
   }
}
