//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefStudentEnrollmentAccessTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefStudentEnrollmentAccessType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefStudentEnrollmentAccessType"> List
         /// </summary>
        public static List<RefStudentEnrollmentAccessType> RefStudentEnrollmentAccessTypeList = new List<RefStudentEnrollmentAccessType>
        {
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("f209c041-d0e6-4d77-a172-79630dc5eb34"), Code="75027", Description="Feeder school rights", Definition="Feeder school rights is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=Convert.ToDecimal("1.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("7ffefc0a-f5a6-4caf-819b-7becb78271e7"), Code="75028", Description="Geographic right", Definition="Geographic right is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=Convert.ToDecimal("2.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("91784f5a-93e0-4d6e-bae9-38bf9928952a"), Code="75029", Description="Lottery", Definition="Lottery is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=Convert.ToDecimal("3.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("ec606079-ebca-4585-8e04-be407504cd3c"), Code="75030", Description="Policy preference", Definition="Policy that modifies student assignment based on preferences associated with such things as walk distances, racial or ethnic diversity, and family risk factors.", SortOrder=Convert.ToDecimal("4.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("3fcc987a-0dd4-48ac-b210-e0f2a3356340"), Code="75031", Description="Selective admissions", Definition="Selective admissions is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefStudentEnrollmentAccessType Pick List
         /// </summary>
        public static List<RefStudentEnrollmentAccessType> RefStudentEnrollmentAccessTypePickList = new List<RefStudentEnrollmentAccessType>
        {
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("f209c041-d0e6-4d77-a172-79630dc5eb34"), Code="75027", Description="Feeder school rights", SortOrder=Convert.ToDecimal("1.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("7ffefc0a-f5a6-4caf-819b-7becb78271e7"), Code="75028", Description="Geographic right", SortOrder=Convert.ToDecimal("2.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("91784f5a-93e0-4d6e-bae9-38bf9928952a"), Code="75029", Description="Lottery", SortOrder=Convert.ToDecimal("3.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("ec606079-ebca-4585-8e04-be407504cd3c"), Code="75030", Description="Policy preference", SortOrder=Convert.ToDecimal("4.00") },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("3fcc987a-0dd4-48ac-b210-e0f2a3356340"), Code="75031", Description="Selective admissions", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
