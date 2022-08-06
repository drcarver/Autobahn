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
        public static List<RefDisabilityDeterminationSourceType> RefDisabilityDeterminationSourceTypeList = new List<RefDisabilityDeterminationSourceType>
        {
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("70aaf425-0cab-44a8-9e95-58de03d07186"), Code="01", Description="By physician", Definition="The disability determination was by a physician.", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("4736f408-d36e-4e06-b35c-be766a5c3e73"), Code="02", Description="By health care provider", Definition="The disability determination was by a health care provider.", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("0052ca80-b3dd-45a7-9ccb-87aeae03321a"), Code="03", Description="By school psychologist or other psychologist", Definition="The disability determination was by a school psychologist or other psychologist.", SortOrder=Convert.ToDecimal("6.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("43f4a0f2-502a-401d-b40a-388324867ab5"), Code="04", Description="By licensed physical therapist", Definition="The disability determination was by a licensed physical therapist.", SortOrder=Convert.ToDecimal("8.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("41b17c0f-cca6-44b9-9b93-782b72a1f8d5"), Code="05", Description="Self-reported", Definition="The disability determination was self-reported.", SortOrder=Convert.ToDecimal("10.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("17dc17dd-8227-41e9-b515-b252e773793a"), Code="06", Description="By social service or other type of agency", Definition="The disability determination was by a social service or other type of agency.", SortOrder=Convert.ToDecimal("12.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("c469d492-3263-45ad-bc57-65452b38f9b5"), Code="97", Description="Not applicable to the student", Definition="Disability determination is not applicable to the student.", SortOrder=Convert.ToDecimal("14.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("5003dc82-b216-4266-8cd7-e75dbf1490a6"), Code="98", Description="Unknown or Unreported", Definition="The disability determination source is unknown or unreported.", SortOrder=Convert.ToDecimal("16.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("03680f84-6941-4662-a2d2-b92c0b30ed00"), Code="99", Description="Other", Definition="The disability determination source is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("18.00") },
        };

        /// <summary>
        /// The RefDisabilityDeterminationSourceType Pick List
         /// </summary>
        public static List<RefDisabilityDeterminationSourceType> RefDisabilityDeterminationSourceTypePickList = new List<RefDisabilityDeterminationSourceType>
        {
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("70aaf425-0cab-44a8-9e95-58de03d07186"), Code="01", Description="By physician", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("4736f408-d36e-4e06-b35c-be766a5c3e73"), Code="02", Description="By health care provider", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("0052ca80-b3dd-45a7-9ccb-87aeae03321a"), Code="03", Description="By school psychologist or other psychologist", SortOrder=Convert.ToDecimal("6.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("43f4a0f2-502a-401d-b40a-388324867ab5"), Code="04", Description="By licensed physical therapist", SortOrder=Convert.ToDecimal("8.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("41b17c0f-cca6-44b9-9b93-782b72a1f8d5"), Code="05", Description="Self-reported", SortOrder=Convert.ToDecimal("10.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("17dc17dd-8227-41e9-b515-b252e773793a"), Code="06", Description="By social service or other type of agency", SortOrder=Convert.ToDecimal("12.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("c469d492-3263-45ad-bc57-65452b38f9b5"), Code="97", Description="Not applicable to the student", SortOrder=Convert.ToDecimal("14.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("5003dc82-b216-4266-8cd7-e75dbf1490a6"), Code="98", Description="Unknown or Unreported", SortOrder=Convert.ToDecimal("16.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("03680f84-6941-4662-a2d2-b92c0b30ed00"), Code="99", Description="Other", SortOrder=Convert.ToDecimal("18.00") },
       };
   }
}
