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
        public static List<RefTransferOutIndicator> RefTransferOutIndicatorList = new List<RefTransferOutIndicator>
        {
            new RefTransferOutIndicator { Id=Guid.Parse("3e4d69b8-5cbc-48fc-bbf0-07b080f17f28"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefTransferOutIndicator { Id=Guid.Parse("5c21226b-4bb0-4f77-9413-e88f6d808721"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefTransferOutIndicator { Id=Guid.Parse("89decbc3-6c92-4380-8c92-dfb83995cde1"), Code="Unknown", Description="Unknown", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefTransferOutIndicator Pick List
         /// </summary>
        public static List<RefTransferOutIndicator> RefTransferOutIndicatorPickList = new List<RefTransferOutIndicator>
        {
            new RefTransferOutIndicator { Id=Guid.Parse("3e4d69b8-5cbc-48fc-bbf0-07b080f17f28"), Code="Yes", Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefTransferOutIndicator { Id=Guid.Parse("5c21226b-4bb0-4f77-9413-e88f6d808721"), Code="No", Description="No", SortOrder=Convert.ToDecimal("2.00") },
            new RefTransferOutIndicator { Id=Guid.Parse("89decbc3-6c92-4380-8c92-dfb83995cde1"), Code="Unknown", Description="Unknown", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
