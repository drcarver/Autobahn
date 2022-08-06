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
        public static List<RefLeaFundsTransferType> RefLeaFundsTransferTypeList = new List<RefLeaFundsTransferType>
        {
            new RefLeaFundsTransferType { Id=Guid.Parse("92dd1150-de26-4de6-89b0-aa6e31e996b6"), Code="FromEligibleProgram", Description="From Eligible Program", Definition="The LEA  transferred funds from an eligible program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLeaFundsTransferType { Id=Guid.Parse("808db4d0-4332-4523-b230-ab99486dc7b4"), Code="ToEligibleProgram", Description="To Eligible Program", Definition="The LEA  transferred funds to an eligible program.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefLeaFundsTransferType Pick List
         /// </summary>
        public static List<RefLeaFundsTransferType> RefLeaFundsTransferTypePickList = new List<RefLeaFundsTransferType>
        {
            new RefLeaFundsTransferType { Id=Guid.Parse("92dd1150-de26-4de6-89b0-aa6e31e996b6"), Code="FromEligibleProgram", Description="From Eligible Program", SortOrder=Convert.ToDecimal("1.00") },
            new RefLeaFundsTransferType { Id=Guid.Parse("808db4d0-4332-4523-b230-ab99486dc7b4"), Code="ToEligibleProgram", Description="To Eligible Program", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
