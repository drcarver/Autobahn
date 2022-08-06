//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefPsEnrollmentActionList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefPsEnrollmentAction Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPsEnrollmentAction"> List
         /// </summary>
        public static List<RefPsEnrollmentAction> RefPsEnrollmentActionList = new List<RefPsEnrollmentAction> =
        {
            new RefPsEnrollmentAction { Id=Guid.Parse("e8b70d1d-601a-4380-a18d-6500c466dfbf"), Code="No information is available about the action taken with respect to postsecondary enrollment by the student who graduated from the school, LEA or state in the past two years.", Description="NoInformation", Definition="", SortOrder=0 },
            new RefPsEnrollmentAction { Id=Guid.Parse("94d355cd-3216-4973-bfed-7463f0418aa6"), Code="The student who graduated from the school, LEA or state in the past two years enrolled in a postsecondary institution.", Description="Enrolled", Definition="", SortOrder=0 },
            new RefPsEnrollmentAction { Id=Guid.Parse("403290cc-1a5d-46e8-8176-65210c137aac"), Code="The student who graduated from the school, LEA or state in the past two years was NOT  enrolled in a postsecondary institution.", Description="NotEnrolled", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPsEnrollmentAction Pick List
         /// </summary>
        public static List<RefPsEnrollmentAction> RefPsEnrollmentActionPickList = new List<RefPsEnrollmentAction> =
        {
            new RefPsEnrollmentAction { Id=Guid.Parse("e8b70d1d-601a-4380-a18d-6500c466dfbf"), Code="No information is available about the action taken with respect to postsecondary enrollment by the student who graduated from the school, LEA or state in the past two years.", SortOrder=0 },
            new RefPsEnrollmentAction { Id=Guid.Parse("94d355cd-3216-4973-bfed-7463f0418aa6"), Code="The student who graduated from the school, LEA or state in the past two years enrolled in a postsecondary institution.", SortOrder=0 },
            new RefPsEnrollmentAction { Id=Guid.Parse("403290cc-1a5d-46e8-8176-65210c137aac"), Code="The student who graduated from the school, LEA or state in the past two years was NOT  enrolled in a postsecondary institution.", SortOrder=0 },
       };
   }
}
