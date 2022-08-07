//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTechnicalAssistanceDeliveryTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefTechnicalAssistanceDeliveryType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTechnicalAssistanceDeliveryTypeModel"> List
         /// </summary>
        public static List<RefTechnicalAssistanceDeliveryTypeModel> RefTechnicalAssistanceDeliveryTypeList = new List<RefTechnicalAssistanceDeliveryTypeModel>
        {
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("419cc72e-4095-45b4-89eb-be4ad3f377da"), Code="Onsite", Description="Onsite", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("3dc8db8b-37ff-4546-b4c8-2b728d7d31a5"), Code="Virtual", Description="Virtual classroom", Definition="", SortOrder=Convert.ToDecimal("4.00") },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("fc5243d1-cdaa-4baf-80fc-fc9c42e20abf"), Code="Off-Site", Description="Off-site classroom", Definition="", SortOrder=Convert.ToDecimal("6.00") },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("066d607e-f0fc-4981-a716-dc4ad878fdfa"), Code="Conference", Description="Conference", Definition="", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefTechnicalAssistanceDeliveryType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTechnicalAssistanceDeliveryTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("419cc72e-4095-45b4-89eb-be4ad3f377da"), Description="Onsite", SortOrder=Convert.ToDecimal("2.00") },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("3dc8db8b-37ff-4546-b4c8-2b728d7d31a5"), Description="Virtual classroom", SortOrder=Convert.ToDecimal("4.00") },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("fc5243d1-cdaa-4baf-80fc-fc9c42e20abf"), Description="Off-site classroom", SortOrder=Convert.ToDecimal("6.00") },
            new RefTechnicalAssistanceDeliveryType { Id=Guid.Parse("066d607e-f0fc-4981-a716-dc4ad878fdfa"), Description="Conference", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
