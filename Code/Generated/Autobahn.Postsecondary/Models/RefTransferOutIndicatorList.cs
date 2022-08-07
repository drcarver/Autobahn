//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefTransferOutIndicatorList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefTransferOutIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTransferOutIndicatorModel"> List
         /// </summary>
        public static List<RefTransferOutIndicatorModel> RefTransferOutIndicatorList = new List<RefTransferOutIndicatorModel>
        {
            new RefTransferOutIndicator { Id=Guid.Parse("ec49294f-e87f-4938-b535-dd73f06593b7"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefTransferOutIndicator { Id=Guid.Parse("1cf8b3d9-e96b-4497-af10-b032610ca933"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefTransferOutIndicator { Id=Guid.Parse("bd2b301f-b931-48e7-beb4-47565cc87281"), Code="Unknown", Description="Unknown", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefTransferOutIndicator Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTransferOutIndicatorViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTransferOutIndicator { Id=Guid.Parse("ec49294f-e87f-4938-b535-dd73f06593b7"), Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefTransferOutIndicator { Id=Guid.Parse("1cf8b3d9-e96b-4497-af10-b032610ca933"), Description="No", SortOrder=Convert.ToDecimal("2.00") },
            new RefTransferOutIndicator { Id=Guid.Parse("bd2b301f-b931-48e7-beb4-47565cc87281"), Description="Unknown", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
