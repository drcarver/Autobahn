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
        /// The complete <see cref="RefLeaFundsTransferType"> List
         /// </summary>
        public static List<RefLeaFundsTransferType> RefLeaFundsTransferTypeList = new List<RefLeaFundsTransferType> =
        {
            new RefLeaFundsTransferType { Id=Guid.Parse("a1ef7d1f-e9ec-49bc-8df9-f6efe04eb477"), Code="The LEA  transferred funds from an eligible program.", Description="FromEligibleProgram", Definition="", SortOrder=0 },
            new RefLeaFundsTransferType { Id=Guid.Parse("cea8caf7-0188-4157-9e95-1d41cf2ccc47"), Code="The LEA  transferred funds to an eligible program.", Description="ToEligibleProgram", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLeaFundsTransferType Pick List
         /// </summary>
        public static List<RefLeaFundsTransferType> RefLeaFundsTransferTypePickList = new List<RefLeaFundsTransferType> =
        {
            new RefLeaFundsTransferType { Id=Guid.Parse("a1ef7d1f-e9ec-49bc-8df9-f6efe04eb477"), Code="The LEA  transferred funds from an eligible program.", SortOrder=0 },
            new RefLeaFundsTransferType { Id=Guid.Parse("cea8caf7-0188-4157-9e95-1d41cf2ccc47"), Code="The LEA  transferred funds to an eligible program.", SortOrder=0 },
       };
   }
}
