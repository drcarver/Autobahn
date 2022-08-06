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
        public static List<RefPsEnrollmentAction> RefPsEnrollmentActionList = new List<RefPsEnrollmentAction>
        {
            new RefPsEnrollmentAction { Id=Guid.Parse("a96c18fb-3c1e-4342-8a71-554c935e1300"), Code="NoInformation", Description="No information", Definition="No information is available about the action taken with respect to postsecondary enrollment by the student who graduated from the school, LEA or state in the past two years.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsEnrollmentAction { Id=Guid.Parse("1f70f67d-213e-4520-aa7c-3bc62ab0f455"), Code="Enrolled", Description="Enrolled", Definition="The student who graduated from the school, LEA or state in the past two years enrolled in a postsecondary institution.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsEnrollmentAction { Id=Guid.Parse("cd94998e-7c82-4190-9a52-1a55e041a3a3"), Code="NotEnrolled", Description="Not enrolled", Definition="The student who graduated from the school, LEA or state in the past two years was NOT  enrolled in a postsecondary institution.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefPsEnrollmentAction Pick List
         /// </summary>
        public static List<RefPsEnrollmentAction> RefPsEnrollmentActionPickList = new List<RefPsEnrollmentAction>
        {
            new RefPsEnrollmentAction { Id=Guid.Parse("a96c18fb-3c1e-4342-8a71-554c935e1300"), Code="NoInformation", Description="No information", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsEnrollmentAction { Id=Guid.Parse("1f70f67d-213e-4520-aa7c-3bc62ab0f455"), Code="Enrolled", Description="Enrolled", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsEnrollmentAction { Id=Guid.Parse("cd94998e-7c82-4190-9a52-1a55e041a3a3"), Code="NotEnrolled", Description="Not enrolled", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
