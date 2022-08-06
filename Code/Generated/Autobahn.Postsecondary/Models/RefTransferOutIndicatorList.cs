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
        /// The complete <see cref="RefTransferOutIndicator"> List
         /// </summary>
        public static List<RefTransferOutIndicator> RefTransferOutIndicatorList = new List<RefTransferOutIndicator> =
        {
            new RefTransferOutIndicator { Id=Guid.Parse("5300e96d-e99e-4fc4-9103-0f6f0302efad"), Code="", Description="Yes", Definition="", SortOrder=0 },
            new RefTransferOutIndicator { Id=Guid.Parse("59a5a441-6be2-43ba-a5de-c6c82700aaec"), Code="", Description="No", Definition="", SortOrder=0 },
            new RefTransferOutIndicator { Id=Guid.Parse("1a75ec13-fe18-4b75-8d46-e6686f420b6b"), Code="", Description="Unknown", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefTransferOutIndicator Pick List
         /// </summary>
        public static List<RefTransferOutIndicator> RefTransferOutIndicatorPickList = new List<RefTransferOutIndicator> =
        {
            new RefTransferOutIndicator { Id=Guid.Parse("5300e96d-e99e-4fc4-9103-0f6f0302efad"), Code="", SortOrder=0 },
            new RefTransferOutIndicator { Id=Guid.Parse("59a5a441-6be2-43ba-a5de-c6c82700aaec"), Code="", SortOrder=0 },
            new RefTransferOutIndicator { Id=Guid.Parse("1a75ec13-fe18-4b75-8d46-e6686f420b6b"), Code="", SortOrder=0 },
       };
   }
}
