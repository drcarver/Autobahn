//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   RefAuthorizerTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.AuthenticationandAuthorization.Models
{
     /// <summary>
     /// The list of RefAuthorizerType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAuthorizerType"> List
         /// </summary>
        public static List<RefAuthorizerType> RefAuthorizerTypeList = new List<RefAuthorizerType>
        {
            new RefAuthorizerType { Id=Guid.Parse("0c6de0e4-b9e8-46c4-8fc1-5f9c4604ac77"), Code="LEARepresentative", Description="LEA Representative", Definition="LEA Representative is specified as the type of person who authorized the decision or document.", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("7aa995ab-616b-4ef4-8e91-f752ffc6724c"), Code="OutsideAgencySupportRepresentative", Description="Outside Agency Support Representative", Definition="Outside Agency Support Representative is specified as the type of person who authorized the decision or document.", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("afaa8733-885a-4600-84c3-76bf851b2f7a"), Code="Parent/Guardian", Description="Parent/Guardian", Definition="Parent/Guardian is specified as the type of person who authorized the decision or document.", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("53a18133-fa4e-4f95-ae46-245137924ba1"), Code="Staff", Description="Staff", Definition="Staff is specified as the type of person who authorized the decision or document.", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("efae7b80-1367-47be-a07e-dc9bf8a41d92"), Code="Student", Description="Student", Definition="Student is specified as the type of person who authorized the decision or document.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefAuthorizerType Pick List
         /// </summary>
        public static List<RefAuthorizerType> RefAuthorizerTypePickList = new List<RefAuthorizerType>
        {
            new RefAuthorizerType { Id=Guid.Parse("0c6de0e4-b9e8-46c4-8fc1-5f9c4604ac77"), Code="LEARepresentative", Description="LEA Representative", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("7aa995ab-616b-4ef4-8e91-f752ffc6724c"), Code="OutsideAgencySupportRepresentative", Description="Outside Agency Support Representative", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("afaa8733-885a-4600-84c3-76bf851b2f7a"), Code="Parent/Guardian", Description="Parent/Guardian", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("53a18133-fa4e-4f95-ae46-245137924ba1"), Code="Staff", Description="Staff", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("efae7b80-1367-47be-a07e-dc9bf8a41d92"), Code="Student", Description="Student", SortOrder=Convert.ToDecimal("") },
       };
   }
}
