//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMethodOfServiceDeliveryList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMethodOfServiceDelivery Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMethodOfServiceDeliveryModel"> List
         /// </summary>
        public static List<RefMethodOfServiceDeliveryModel> RefMethodOfServiceDeliveryList = new List<RefMethodOfServiceDeliveryModel>
        {
            new RefMethodOfServiceDelivery { Id=Guid.Parse("a9e49613-2154-4ce7-9e7d-63dcd97f6827"), Code="Individual", Description="Individual", Definition="The services will be provided individually.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMethodOfServiceDelivery { Id=Guid.Parse("47807d95-a7b0-4743-8e47-d44eb24dd141"), Code="Group", Description="Group", Definition="The services will be provided in a group.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefMethodOfServiceDelivery Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefMethodOfServiceDeliveryViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefMethodOfServiceDelivery { Id=Guid.Parse("a9e49613-2154-4ce7-9e7d-63dcd97f6827"), Description="Individual", SortOrder=Convert.ToDecimal("2.00") },
            new RefMethodOfServiceDelivery { Id=Guid.Parse("47807d95-a7b0-4743-8e47-d44eb24dd141"), Description="Group", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
