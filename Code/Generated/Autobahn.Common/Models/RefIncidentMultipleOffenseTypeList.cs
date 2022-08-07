//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentMultipleOffenseTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentMultipleOffenseType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentMultipleOffenseTypeModel"> List
         /// </summary>
        public static List<RefIncidentMultipleOffenseTypeModel> RefIncidentMultipleOffenseTypeList = new List<RefIncidentMultipleOffenseTypeModel>
        {
            new RefIncidentMultipleOffenseType { Id=Guid.Parse("968bda3f-3fac-4676-af6d-f78f2cd3eacd"), Code="Primary", Description="Primary", Definition="The offense was primary in nature when a single incident included more than one type of offense.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentMultipleOffenseType { Id=Guid.Parse("05a7a18d-85fd-404d-9359-49d427dea9d7"), Code="Secondary", Description="Secondary", Definition="The offense was secondary in nature when a single incident included more than one type of offense.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefIncidentMultipleOffenseType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIncidentMultipleOffenseTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIncidentMultipleOffenseType { Id=Guid.Parse("968bda3f-3fac-4676-af6d-f78f2cd3eacd"), Description="Primary", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentMultipleOffenseType { Id=Guid.Parse("05a7a18d-85fd-404d-9359-49d427dea9d7"), Description="Secondary", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
