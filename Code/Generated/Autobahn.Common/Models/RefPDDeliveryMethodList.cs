//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDDeliveryMethodList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDDeliveryMethod Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDDeliveryMethodModel"> List
         /// </summary>
        public static List<RefPDDeliveryMethodModel> RefPDDeliveryMethodList = new List<RefPDDeliveryMethodModel>
        {
            new RefPDDeliveryMethod { Id=Guid.Parse("e5a661b4-4005-4b6b-add1-a6dde3828499"), Code="Onsite", Description="Onsite", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDDeliveryMethod { Id=Guid.Parse("abd46aee-d868-49ca-aa51-ec28739778b2"), Code="Virtual", Description="Virtual classroom", Definition="", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDDeliveryMethod { Id=Guid.Parse("adecfed9-51da-4315-97e1-416e242c3135"), Code="Off-Site", Description="Off-site classroom", Definition="", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDDeliveryMethod { Id=Guid.Parse("8d84fc84-e905-4c96-9933-aa451441fc12"), Code="Conference", Description="Conference", Definition="", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefPDDeliveryMethod Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPDDeliveryMethodViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPDDeliveryMethod { Id=Guid.Parse("e5a661b4-4005-4b6b-add1-a6dde3828499"), Description="Onsite", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDDeliveryMethod { Id=Guid.Parse("abd46aee-d868-49ca-aa51-ec28739778b2"), Description="Virtual classroom", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDDeliveryMethod { Id=Guid.Parse("adecfed9-51da-4315-97e1-416e242c3135"), Description="Off-site classroom", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDDeliveryMethod { Id=Guid.Parse("8d84fc84-e905-4c96-9933-aa451441fc12"), Description="Conference", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
