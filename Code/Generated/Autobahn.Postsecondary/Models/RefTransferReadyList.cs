//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefTransferReadyList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefTransferReady Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTransferReadyModel"> List
         /// </summary>
        public static List<RefTransferReadyModel> RefTransferReadyList = new List<RefTransferReadyModel>
        {
            new RefTransferReady { Id=Guid.Parse("ff4512da-6851-42ed-a70b-f050b8d12a32"), Code="YesStateDefined", Description="Yes, state defined", Definition="The person has successfully completed a transfer-preparatory program as defined by the state.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTransferReady { Id=Guid.Parse("38ed0ad8-1972-4a74-82e1-aa1964e6792b"), Code="YesInstitutionDefined", Description="Yes, institution defined", Definition="The person has successfully completed a transfer-preparatory program as defined by the institution.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefTransferReady Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTransferReadyViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTransferReady { Id=Guid.Parse("ff4512da-6851-42ed-a70b-f050b8d12a32"), Description="Yes, state defined", SortOrder=Convert.ToDecimal("1.00") },
            new RefTransferReady { Id=Guid.Parse("38ed0ad8-1972-4a74-82e1-aa1964e6792b"), Description="Yes, institution defined", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
