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
        public static List<RefTeachingAssignmentRole> RefTeachingAssignmentRoleList = new List<RefTeachingAssignmentRole> =
        {
            new RefTeachingAssignmentRole { Id=Guid.Parse("9e6a8897-94b8-44e5-9899-da0181d90369"), Code="Lead teacher with the primary responsibility for student learning in the assigned class section", Description="LeadTeacher", Definition="", SortOrder=0 },
            new RefTeachingAssignmentRole { Id=Guid.Parse("3c196141-f1d2-4900-9474-7ba9875d46c7"), Code=" Team teacher with shared responsibility for student learning within the assigned class section", Description="TeamTeacher", Definition="", SortOrder=0 },
            new RefTeachingAssignmentRole { Id=Guid.Parse("25930fb5-2764-42e1-9570-de1663b98c28"), Code="Contributing professional who has been assigned the responsibility to provide additional services that support and increase a student learning", Description="ContributingProfessional", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefTeachingAssignmentRole Pick List
         /// </summary>
        public static List<RefTeachingAssignmentRole> RefTeachingAssignmentRolePickList = new List<RefTeachingAssignmentRole> =
        {
            new RefTeachingAssignmentRole { Id=Guid.Parse("9e6a8897-94b8-44e5-9899-da0181d90369"), Code="Lead teacher with the primary responsibility for student learning in the assigned class section", SortOrder=0 },
            new RefTeachingAssignmentRole { Id=Guid.Parse("3c196141-f1d2-4900-9474-7ba9875d46c7"), Code=" Team teacher with shared responsibility for student learning within the assigned class section", SortOrder=0 },
            new RefTeachingAssignmentRole { Id=Guid.Parse("25930fb5-2764-42e1-9570-de1663b98c28"), Code="Contributing professional who has been assigned the responsibility to provide additional services that support and increase a student learning", SortOrder=0 },
       };
   }
}
