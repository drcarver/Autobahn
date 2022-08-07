//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefTeachingAssignmentRoleList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefTeachingAssignmentRole Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTeachingAssignmentRoleModel"> List
         /// </summary>
        public static List<RefTeachingAssignmentRoleModel> RefTeachingAssignmentRoleList = new List<RefTeachingAssignmentRoleModel>
        {
            new RefTeachingAssignmentRole { Id=Guid.Parse("8b76d458-7e72-4eac-9afa-c3134719657f"), Code="LeadTeacher", Description="Lead Teacher", Definition="Lead teacher with the primary responsibility for student learning in the assigned class section", SortOrder=Convert.ToDecimal("1.00") },
            new RefTeachingAssignmentRole { Id=Guid.Parse("af9f0641-87bc-45b8-ad6c-06ded05e290a"), Code="TeamTeacher", Description="Team Teacher", Definition=" Team teacher with shared responsibility for student learning within the assigned class section", SortOrder=Convert.ToDecimal("2.00") },
            new RefTeachingAssignmentRole { Id=Guid.Parse("15d27f5c-81f8-4684-8a73-0421ef0b9040"), Code="ContributingProfessional", Description="Contributing Professional", Definition="Contributing professional who has been assigned the responsibility to provide additional services that support and increase a student learning", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefTeachingAssignmentRole Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTeachingAssignmentRoleViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTeachingAssignmentRole { Id=Guid.Parse("8b76d458-7e72-4eac-9afa-c3134719657f"), Description="Lead Teacher", SortOrder=Convert.ToDecimal("1.00") },
            new RefTeachingAssignmentRole { Id=Guid.Parse("af9f0641-87bc-45b8-ad6c-06ded05e290a"), Description="Team Teacher", SortOrder=Convert.ToDecimal("2.00") },
            new RefTeachingAssignmentRole { Id=Guid.Parse("15d27f5c-81f8-4684-8a73-0421ef0b9040"), Description="Contributing Professional", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
