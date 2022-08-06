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
        public static List<RefTransferReady> RefTransferReadyList = new List<RefTransferReady> =
        {
            new RefTransferReady { Id=Guid.Parse("cc511084-298b-40ba-a637-1c400abb1a54"), Code="The person has successfully completed a transfer-preparatory program as defined by the state.", Description="YesStateDefined", Definition="", SortOrder=0 },
            new RefTransferReady { Id=Guid.Parse("54d4402f-7e57-4567-8a52-8c712394aa80"), Code="The person has successfully completed a transfer-preparatory program as defined by the institution.", Description="YesInstitutionDefined", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefTransferReady Pick List
         /// </summary>
        public static List<RefTransferReady> RefTransferReadyPickList = new List<RefTransferReady> =
        {
            new RefTransferReady { Id=Guid.Parse("cc511084-298b-40ba-a637-1c400abb1a54"), Code="The person has successfully completed a transfer-preparatory program as defined by the state.", SortOrder=0 },
            new RefTransferReady { Id=Guid.Parse("54d4402f-7e57-4567-8a52-8c712394aa80"), Code="The person has successfully completed a transfer-preparatory program as defined by the institution.", SortOrder=0 },
       };
   }
}
