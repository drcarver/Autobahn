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
        /// The complete <see cref="RefTeachingAssignmentRole"> List
         /// </summary>
        public static List<RefTeachingAssignmentRole> RefTeachingAssignmentRoleList = new List<RefTeachingAssignmentRole>
        {
            new RefTeachingAssignmentRole { Id=Guid.Parse("a53addae-8df9-41c3-b887-fe96b1f73040"), Code="LeadTeacher", Description="Lead Teacher", Definition="Lead teacher with the primary responsibility for student learning in the assigned class section", SortOrder=Convert.ToDecimal("1.00") },
            new RefTeachingAssignmentRole { Id=Guid.Parse("1a286b8c-275e-4230-8cd8-92f8612f2ed5"), Code="TeamTeacher", Description="Team Teacher", Definition=" Team teacher with shared responsibility for student learning within the assigned class section", SortOrder=Convert.ToDecimal("2.00") },
            new RefTeachingAssignmentRole { Id=Guid.Parse("ee1312dd-bffb-413c-ba17-e46926a30946"), Code="ContributingProfessional", Description="Contributing Professional", Definition="Contributing professional who has been assigned the responsibility to provide additional services that support and increase a student learning", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefTeachingAssignmentRole Pick List
         /// </summary>
        public static List<RefTeachingAssignmentRole> RefTeachingAssignmentRolePickList = new List<RefTeachingAssignmentRole>
        {
            new RefTeachingAssignmentRole { Id=Guid.Parse("a53addae-8df9-41c3-b887-fe96b1f73040"), Code="LeadTeacher", Description="Lead Teacher", SortOrder=Convert.ToDecimal("1.00") },
            new RefTeachingAssignmentRole { Id=Guid.Parse("1a286b8c-275e-4230-8cd8-92f8612f2ed5"), Code="TeamTeacher", Description="Team Teacher", SortOrder=Convert.ToDecimal("2.00") },
            new RefTeachingAssignmentRole { Id=Guid.Parse("ee1312dd-bffb-413c-ba17-e46926a30946"), Code="ContributingProfessional", Description="Contributing Professional", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
