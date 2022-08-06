//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefContentStandardTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefContentStandardType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefContentStandardType"> List
         /// </summary>
        public static List<RefContentStandardType> RefContentStandardTypeList = new List<RefContentStandardType> =
        {
            new RefContentStandardType { Id=Guid.Parse("96790dfa-c123-4675-a4d2-1deb5733888e"), Code="The assessment conforms to a standard defined by an association.", Description="AssociationStandard", Definition="", SortOrder=0 },
            new RefContentStandardType { Id=Guid.Parse("652eb773-fe98-4470-8450-36939b371d9a"), Code="The assessment conforms to local standard.", Description="LocalStandard", Definition="", SortOrder=0 },
            new RefContentStandardType { Id=Guid.Parse("9e2251b7-5a58-40b1-9adf-7fa9a5e190d2"), Code="The assessment does not conform to a standard.", Description="None", Definition="", SortOrder=0 },
            new RefContentStandardType { Id=Guid.Parse("43a20202-f830-4694-8403-3095b54e7ae3"), Code="Other is specified as to whether an assessment conforms to a standard.", Description="Other", Definition="", SortOrder=0 },
            new RefContentStandardType { Id=Guid.Parse("cbf7a381-0cc4-4d0d-a414-57101f8b0e53"), Code="The assessment conforms to a content standard type not yet defined in CEDS.", Description="OtherStandard", Definition="", SortOrder=0 },
            new RefContentStandardType { Id=Guid.Parse("33bc977d-8e84-483d-b000-4ffd121d870c"), Code="The assessment conforms to a regional standard.", Description="RegionalStandard", Definition="", SortOrder=0 },
            new RefContentStandardType { Id=Guid.Parse("6975ce08-4afa-4cbb-b2a6-323472fadf7e"), Code="The assessment conforms to a school standard.", Description="SchoolStandard", Definition="", SortOrder=0 },
            new RefContentStandardType { Id=Guid.Parse("bf2d6ff0-1aa3-4936-8e85-9c005fe42921"), Code="The assessment conforms to a statewide standard.", Description="StatewideStandard", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefContentStandardType Pick List
         /// </summary>
        public static List<RefContentStandardType> RefContentStandardTypePickList = new List<RefContentStandardType> =
        {
            new RefContentStandardType { Id=Guid.Parse("96790dfa-c123-4675-a4d2-1deb5733888e"), Code="The assessment conforms to a standard defined by an association.", SortOrder=0 },
            new RefContentStandardType { Id=Guid.Parse("652eb773-fe98-4470-8450-36939b371d9a"), Code="The assessment conforms to local standard.", SortOrder=0 },
            new RefContentStandardType { Id=Guid.Parse("9e2251b7-5a58-40b1-9adf-7fa9a5e190d2"), Code="The assessment does not conform to a standard.", SortOrder=0 },
            new RefContentStandardType { Id=Guid.Parse("43a20202-f830-4694-8403-3095b54e7ae3"), Code="Other is specified as to whether an assessment conforms to a standard.", SortOrder=0 },
            new RefContentStandardType { Id=Guid.Parse("cbf7a381-0cc4-4d0d-a414-57101f8b0e53"), Code="The assessment conforms to a content standard type not yet defined in CEDS.", SortOrder=0 },
            new RefContentStandardType { Id=Guid.Parse("33bc977d-8e84-483d-b000-4ffd121d870c"), Code="The assessment conforms to a regional standard.", SortOrder=0 },
            new RefContentStandardType { Id=Guid.Parse("6975ce08-4afa-4cbb-b2a6-323472fadf7e"), Code="The assessment conforms to a school standard.", SortOrder=0 },
            new RefContentStandardType { Id=Guid.Parse("bf2d6ff0-1aa3-4936-8e85-9c005fe42921"), Code="The assessment conforms to a statewide standard.", SortOrder=0 },
       };
   }
}
