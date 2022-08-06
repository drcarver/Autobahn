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
        /// The complete <see cref="RefTransferReady"> List
         /// </summary>
        public static List<RefTransferReady> RefTransferReadyList = new List<RefTransferReady>
        {
            new RefTransferReady { Id=Guid.Parse("15971766-a6e3-4222-81ff-801cd0d347e9"), Code="YesStateDefined", Description="Yes, state defined", Definition="The person has successfully completed a transfer-preparatory program as defined by the state.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTransferReady { Id=Guid.Parse("2c221921-9d21-48d5-a2b2-7f5583dc0e7e"), Code="YesInstitutionDefined", Description="Yes, institution defined", Definition="The person has successfully completed a transfer-preparatory program as defined by the institution.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefTransferReady Pick List
         /// </summary>
        public static List<RefTransferReady> RefTransferReadyPickList = new List<RefTransferReady>
        {
            new RefTransferReady { Id=Guid.Parse("15971766-a6e3-4222-81ff-801cd0d347e9"), Code="YesStateDefined", Description="Yes, state defined", SortOrder=Convert.ToDecimal("1.00") },
            new RefTransferReady { Id=Guid.Parse("2c221921-9d21-48d5-a2b2-7f5583dc0e7e"), Code="YesInstitutionDefined", Description="Yes, institution defined", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
