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
        public static List<RefAuthorizerType> RefAuthorizerTypeList = new List<RefAuthorizerType> =
        {
            new RefAuthorizerType { Id=Guid.Parse("f0020462-7813-4218-96dc-0c6137c365e5"), Code="LEA Representative is specified as the type of person who authorized the decision or document.", Description="LEARepresentative", Definition="", SortOrder=0 },
            new RefAuthorizerType { Id=Guid.Parse("63483e2c-f79c-4eaa-aff9-ce3a7492093e"), Code="Outside Agency Support Representative is specified as the type of person who authorized the decision or document.", Description="OutsideAgencySupportRepresentative", Definition="", SortOrder=0 },
            new RefAuthorizerType { Id=Guid.Parse("8b66cc4f-9b82-4cb6-9c80-00d260413edb"), Code="Parent/Guardian is specified as the type of person who authorized the decision or document.", Description="Parent/Guardian", Definition="", SortOrder=0 },
            new RefAuthorizerType { Id=Guid.Parse("3e7444a1-5c87-4e40-823c-98f9882dda4d"), Code="Staff is specified as the type of person who authorized the decision or document.", Description="Staff", Definition="", SortOrder=0 },
            new RefAuthorizerType { Id=Guid.Parse("0f604a59-95d9-43de-9ed0-f1699692bd3e"), Code="Student is specified as the type of person who authorized the decision or document.", Description="Student", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAuthorizerType Pick List
         /// </summary>
        public static List<RefAuthorizerType> RefAuthorizerTypePickList = new List<RefAuthorizerType> =
        {
            new RefAuthorizerType { Id=Guid.Parse("f0020462-7813-4218-96dc-0c6137c365e5"), Code="LEA Representative is specified as the type of person who authorized the decision or document.", SortOrder=0 },
            new RefAuthorizerType { Id=Guid.Parse("63483e2c-f79c-4eaa-aff9-ce3a7492093e"), Code="Outside Agency Support Representative is specified as the type of person who authorized the decision or document.", SortOrder=0 },
            new RefAuthorizerType { Id=Guid.Parse("8b66cc4f-9b82-4cb6-9c80-00d260413edb"), Code="Parent/Guardian is specified as the type of person who authorized the decision or document.", SortOrder=0 },
            new RefAuthorizerType { Id=Guid.Parse("3e7444a1-5c87-4e40-823c-98f9882dda4d"), Code="Staff is specified as the type of person who authorized the decision or document.", SortOrder=0 },
            new RefAuthorizerType { Id=Guid.Parse("0f604a59-95d9-43de-9ed0-f1699692bd3e"), Code="Student is specified as the type of person who authorized the decision or document.", SortOrder=0 },
       };
   }
}
