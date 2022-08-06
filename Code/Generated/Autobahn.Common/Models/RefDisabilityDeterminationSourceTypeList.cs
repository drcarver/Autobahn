//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefDisabilityDeterminationSourceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefDisabilityDeterminationSourceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDisabilityDeterminationSourceType"> List
         /// </summary>
        public static List<RefDisabilityDeterminationSourceType> RefDisabilityDeterminationSourceTypeList = new List<RefDisabilityDeterminationSourceType> =
        {
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("89745987-4927-4d69-8d03-424e40ec994e"), Code="The disability determination was by a physician.", Description="01", Definition="", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("ffa0aa05-5ed6-41fc-a406-9d8b5e39e9bb"), Code="The disability determination was by a health care provider.", Description="02", Definition="", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("469a44d4-afbe-4d52-a1ab-d714cf491277"), Code="The disability determination was by a school psychologist or other psychologist.", Description="03", Definition="", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("84eabd85-e7d2-4396-8f40-3bcae223d2aa"), Code="The disability determination was by a licensed physical therapist.", Description="04", Definition="", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("77eda140-ff15-4bcd-8b77-dbf9b463b187"), Code="The disability determination was self-reported.", Description="05", Definition="", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("0d0d3a3c-5c7c-4e6f-af2f-2b407087301d"), Code="The disability determination was by a social service or other type of agency.", Description="06", Definition="", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("7da4066e-ce46-4db4-81b4-ae9bee15d8af"), Code="Disability determination is not applicable to the student.", Description="97", Definition="", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("9675976a-fbc5-4b50-8058-9874a95f311c"), Code="The disability determination source is unknown or unreported.", Description="98", Definition="", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("5d8249a1-26b6-49cf-adf6-652ddd78a825"), Code="The disability determination source is in a category not yet defined by CEDS.", Description="99", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefDisabilityDeterminationSourceType Pick List
         /// </summary>
        public static List<RefDisabilityDeterminationSourceType> RefDisabilityDeterminationSourceTypePickList = new List<RefDisabilityDeterminationSourceType> =
        {
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("89745987-4927-4d69-8d03-424e40ec994e"), Code="The disability determination was by a physician.", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("ffa0aa05-5ed6-41fc-a406-9d8b5e39e9bb"), Code="The disability determination was by a health care provider.", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("469a44d4-afbe-4d52-a1ab-d714cf491277"), Code="The disability determination was by a school psychologist or other psychologist.", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("84eabd85-e7d2-4396-8f40-3bcae223d2aa"), Code="The disability determination was by a licensed physical therapist.", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("77eda140-ff15-4bcd-8b77-dbf9b463b187"), Code="The disability determination was self-reported.", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("0d0d3a3c-5c7c-4e6f-af2f-2b407087301d"), Code="The disability determination was by a social service or other type of agency.", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("7da4066e-ce46-4db4-81b4-ae9bee15d8af"), Code="Disability determination is not applicable to the student.", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("9675976a-fbc5-4b50-8058-9874a95f311c"), Code="The disability determination source is unknown or unreported.", SortOrder=0 },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("5d8249a1-26b6-49cf-adf6-652ddd78a825"), Code="The disability determination source is in a category not yet defined by CEDS.", SortOrder=0 },
       };
   }
}
