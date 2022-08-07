//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefLeaFundsTransferTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefLeaFundsTransferType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLeaFundsTransferTypeModel"> List
         /// </summary>
        public static List<RefLeaFundsTransferTypeModel> RefLeaFundsTransferTypeList = new List<RefLeaFundsTransferTypeModel>
        {
            new RefLeaFundsTransferType { Id=Guid.Parse("a2b3d020-90e4-40b1-8b94-da19c1e77c32"), Code="FromEligibleProgram", Description="From Eligible Program", Definition="The LEA  transferred funds from an eligible program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLeaFundsTransferType { Id=Guid.Parse("5a57b24d-d187-475c-b2e9-a8cbb5c43255"), Code="ToEligibleProgram", Description="To Eligible Program", Definition="The LEA  transferred funds to an eligible program.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefLeaFundsTransferType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLeaFundsTransferTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLeaFundsTransferType { Id=Guid.Parse("a2b3d020-90e4-40b1-8b94-da19c1e77c32"), Description="From Eligible Program", SortOrder=Convert.ToDecimal("1.00") },
            new RefLeaFundsTransferType { Id=Guid.Parse("5a57b24d-d187-475c-b2e9-a8cbb5c43255"), Description="To Eligible Program", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
