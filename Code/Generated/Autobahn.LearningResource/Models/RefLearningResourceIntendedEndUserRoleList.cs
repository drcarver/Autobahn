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
        /// The complete <see cref="RefLearningResourceIntendedEndUserRoleModel"> List
         /// </summary>
        public static List<RefLearningResourceIntendedEndUserRoleModel> RefLearningResourceIntendedEndUserRoleList = new List<RefLearningResourceIntendedEndUserRoleModel>
        {
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("4aa99d41-9990-49da-8edc-54fa01573e34"), Code="Administrator", Description="Administrator", Definition="The resource was produced for use by Administrators.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("394375f3-cd4e-4560-8aa6-25a5239fa5fe"), Code="Mentor", Description="Mentor", Definition="The resource was produced for use by Mentors.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("0c9ec2fa-b492-4961-9126-a81a4f6399f8"), Code="Parent", Description="Parent", Definition="The resource was produced for use by Parents.", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("5e4cdd7f-2824-4b15-b710-234111511568"), Code="Peer-Tutor", Description="Peer- Tutor", Definition="The resource was produced for use by Peer-Tutors.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("3bd5864c-431b-4000-87ce-a8bbbcd5783d"), Code="Specialist", Description="Specialist", Definition="The resource was produced for use by Specialists.", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("7fe092f9-818a-4b37-8864-e8f4c01d8f6a"), Code="Student", Description="Student", Definition="The resource was produced for use by Students.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("1a3cfbd8-9720-4354-89c2-4250d6f2a91b"), Code="Teacher", Description="Teacher", Definition="The resource was produced for use by Teachers.", SortOrder=Convert.ToDecimal("7.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("50d8da71-305f-4404-b37e-cc31cad0f2d8"), Code="Team", Description="Team", Definition="The resource was produced for use by Teams.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("4fdb3e11-bc69-4e93-9341-116b5a739ac2"), Code="Other", Description="Other", Definition="The resource was produced for use by a category of person or group not yet defined in the CEDS vocabulary.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefLearningResourceIntendedEndUserRole Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearningResourceIntendedEndUserRoleViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("4aa99d41-9990-49da-8edc-54fa01573e34"), Description="Administrator", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("394375f3-cd4e-4560-8aa6-25a5239fa5fe"), Description="Mentor", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("0c9ec2fa-b492-4961-9126-a81a4f6399f8"), Description="Parent", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("5e4cdd7f-2824-4b15-b710-234111511568"), Description="Peer- Tutor", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("3bd5864c-431b-4000-87ce-a8bbbcd5783d"), Description="Specialist", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("7fe092f9-818a-4b37-8864-e8f4c01d8f6a"), Description="Student", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("1a3cfbd8-9720-4354-89c2-4250d6f2a91b"), Description="Teacher", SortOrder=Convert.ToDecimal("7.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("50d8da71-305f-4404-b37e-cc31cad0f2d8"), Description="Team", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceIntendedEndUserRole { Id=Guid.Parse("4fdb3e11-bc69-4e93-9341-116b5a739ac2"), Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
