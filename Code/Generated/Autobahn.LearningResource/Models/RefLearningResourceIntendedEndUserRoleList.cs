//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceIntendedEndUserRoleList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceIntendedEndUserRole Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceIntendedEndUserRole"> List
         /// </summary>
        public static List<RefLearningResourceIntendedEndUserRole> RefLearningResourceIntendedEndUserRoleList = new List<RefLearningResourceIntendedEndUserRole>
        {
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("c048f29f-0e2c-4305-ad41-0694594fcf0a"), Code="Administrator", Description="Administrator", Definition="The resource was produced for use by Administrators.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("48d90ed0-5fc8-491a-a64b-ea963e6e3e8d"), Code="Mentor", Description="Mentor", Definition="The resource was produced for use by Mentors.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("71970311-6447-4453-a6f0-d36d966c2d5d"), Code="Parent", Description="Parent", Definition="The resource was produced for use by Parents.", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("f382d9f9-b3fc-4152-8de5-8d74b09abb8a"), Code="Peer-Tutor", Description="Peer- Tutor", Definition="The resource was produced for use by Peer-Tutors.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("6dd898ad-3d60-458c-a4aa-c8e9853b4c9b"), Code="Specialist", Description="Specialist", Definition="The resource was produced for use by Specialists.", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("2c73ca7b-0ddf-4b89-8a12-34dd1cd0161a"), Code="Student", Description="Student", Definition="The resource was produced for use by Students.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("27d54e81-6566-417d-82c9-da7d98f223e8"), Code="Teacher", Description="Teacher", Definition="The resource was produced for use by Teachers.", SortOrder=Convert.ToDecimal("7.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("b7b22edb-37a1-4429-b160-bc054db9c3b0"), Code="Team", Description="Team", Definition="The resource was produced for use by Teams.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("14558d7c-98a5-4ea3-9e4e-79129ab9e40b"), Code="Other", Description="Other", Definition="The resource was produced for use by a category of person or group not yet defined in the CEDS vocabulary.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefLearningResourceIntendedEndUserRole Pick List
         /// </summary>
        public static List<RefLearningResourceIntendedEndUserRole> RefLearningResourceIntendedEndUserRolePickList = new List<RefLearningResourceIntendedEndUserRole>
        {
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("c048f29f-0e2c-4305-ad41-0694594fcf0a"), Code="Administrator", Description="Administrator", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("48d90ed0-5fc8-491a-a64b-ea963e6e3e8d"), Code="Mentor", Description="Mentor", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("71970311-6447-4453-a6f0-d36d966c2d5d"), Code="Parent", Description="Parent", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("f382d9f9-b3fc-4152-8de5-8d74b09abb8a"), Code="Peer-Tutor", Description="Peer- Tutor", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("6dd898ad-3d60-458c-a4aa-c8e9853b4c9b"), Code="Specialist", Description="Specialist", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("2c73ca7b-0ddf-4b89-8a12-34dd1cd0161a"), Code="Student", Description="Student", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("27d54e81-6566-417d-82c9-da7d98f223e8"), Code="Teacher", Description="Teacher", SortOrder=Convert.ToDecimal("7.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("b7b22edb-37a1-4429-b160-bc054db9c3b0"), Code="Team", Description="Team", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("14558d7c-98a5-4ea3-9e4e-79129ab9e40b"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
