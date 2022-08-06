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
        public static List<RefContentStandardType> RefContentStandardTypeList = new List<RefContentStandardType>
        {
            new RefContentStandardType { Id=Guid.Parse("09fd5ca7-f9ad-4563-a409-07c94af9f58f"), Code="AssociationStandard", Description="Association standard", Definition="The assessment conforms to a standard defined by an association.", SortOrder=Convert.ToDecimal("1.00") },
            new RefContentStandardType { Id=Guid.Parse("39b98744-fe21-49d0-9637-7c225dcfc6d1"), Code="LocalStandard", Description="Local standard", Definition="The assessment conforms to local standard.", SortOrder=Convert.ToDecimal("2.00") },
            new RefContentStandardType { Id=Guid.Parse("57457ea0-9128-4564-a55f-b5f2da06aca8"), Code="None", Description="None", Definition="The assessment does not conform to a standard.", SortOrder=Convert.ToDecimal("3.00") },
            new RefContentStandardType { Id=Guid.Parse("28196d82-dc5a-4101-890c-81e29f5ad782"), Code="Other", Description="Other", Definition="Other is specified as to whether an assessment conforms to a standard.", SortOrder=Convert.ToDecimal("4.00") },
            new RefContentStandardType { Id=Guid.Parse("719293b7-e546-43e3-8070-c5ed278ac002"), Code="OtherStandard", Description="Other standard", Definition="The assessment conforms to a content standard type not yet defined in CEDS.", SortOrder=Convert.ToDecimal("5.00") },
            new RefContentStandardType { Id=Guid.Parse("7c10b2b1-8fb6-44b5-be89-cc4d6c6e2ef1"), Code="RegionalStandard", Description="Regional standard", Definition="The assessment conforms to a regional standard.", SortOrder=Convert.ToDecimal("6.00") },
            new RefContentStandardType { Id=Guid.Parse("0573d7fb-3856-416e-82b5-3bebbdaa266c"), Code="SchoolStandard", Description="School standard", Definition="The assessment conforms to a school standard.", SortOrder=Convert.ToDecimal("7.00") },
            new RefContentStandardType { Id=Guid.Parse("e338e429-d8ea-4ee4-a716-1b99b9a079a6"), Code="StatewideStandard", Description="Statewide standard", Definition="The assessment conforms to a statewide standard.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefContentStandardType Pick List
         /// </summary>
        public static List<RefContentStandardType> RefContentStandardTypePickList = new List<RefContentStandardType>
        {
            new RefContentStandardType { Id=Guid.Parse("09fd5ca7-f9ad-4563-a409-07c94af9f58f"), Code="AssociationStandard", Description="Association standard", SortOrder=Convert.ToDecimal("1.00") },
            new RefContentStandardType { Id=Guid.Parse("39b98744-fe21-49d0-9637-7c225dcfc6d1"), Code="LocalStandard", Description="Local standard", SortOrder=Convert.ToDecimal("2.00") },
            new RefContentStandardType { Id=Guid.Parse("57457ea0-9128-4564-a55f-b5f2da06aca8"), Code="None", Description="None", SortOrder=Convert.ToDecimal("3.00") },
            new RefContentStandardType { Id=Guid.Parse("28196d82-dc5a-4101-890c-81e29f5ad782"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("4.00") },
            new RefContentStandardType { Id=Guid.Parse("719293b7-e546-43e3-8070-c5ed278ac002"), Code="OtherStandard", Description="Other standard", SortOrder=Convert.ToDecimal("5.00") },
            new RefContentStandardType { Id=Guid.Parse("7c10b2b1-8fb6-44b5-be89-cc4d6c6e2ef1"), Code="RegionalStandard", Description="Regional standard", SortOrder=Convert.ToDecimal("6.00") },
            new RefContentStandardType { Id=Guid.Parse("0573d7fb-3856-416e-82b5-3bebbdaa266c"), Code="SchoolStandard", Description="School standard", SortOrder=Convert.ToDecimal("7.00") },
            new RefContentStandardType { Id=Guid.Parse("e338e429-d8ea-4ee4-a716-1b99b9a079a6"), Code="StatewideStandard", Description="Statewide standard", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
