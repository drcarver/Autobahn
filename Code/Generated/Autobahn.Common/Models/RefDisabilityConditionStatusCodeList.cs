//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefDisabilityConditionStatusCodeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefDisabilityConditionStatusCode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDisabilityConditionStatusCodeModel"> List
         /// </summary>
        public static List<RefDisabilityConditionStatusCodeModel> RefDisabilityConditionStatusCodeList = new List<RefDisabilityConditionStatusCodeModel>
        {
            new RefDisabilityConditionStatusCode { Id=Guid.Parse("c747a4c1-4a83-4b91-aeb1-53c81849e7a0"), Code="Permanent", Description="Disability has been confirmed as a permanent disability", Definition="A person's disability has been confirmed as a permanent disability.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisabilityConditionStatusCode { Id=Guid.Parse("7fb90d72-7986-4ec4-a0e0-b9437c37e371"), Code="Temporary", Description="Disability has been confirmed as a temporary disability", Definition="A person's disability has been confirmed as a temporary disability.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefDisabilityConditionStatusCode Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefDisabilityConditionStatusCodeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefDisabilityConditionStatusCode { Id=Guid.Parse("c747a4c1-4a83-4b91-aeb1-53c81849e7a0"), Description="Disability has been confirmed as a permanent disability", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisabilityConditionStatusCode { Id=Guid.Parse("7fb90d72-7986-4ec4-a0e0-b9437c37e371"), Description="Disability has been confirmed as a temporary disability", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
