//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceAccessRightsUrlList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceAccessRightsUrl Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceAccessRightsUrl"> List
         /// </summary>
        public static List<RefLearningResourceAccessRightsUrl> RefLearningResourceAccessRightsUrlList = new List<RefLearningResourceAccessRightsUrl>
        {
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("e08e6059-2681-4c64-8be2-f15060bea1c2"), Code="FreeAccess", Description="Free Access", Definition="The right to view and/or download material without financial, registration, or excessive advertising barriers.  [<a href=\u0022https://ceds.ed.gov/element/001561#FreeAccess\u0022>https://ceds.ed.gov/element/001561#FreeAccess</a>]", SortOrder=Convert.ToDecimal("0.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("ef3d0b54-8fe6-449a-aa5e-b800a14e35c6"), Code="FreeAccessWithRegistration", Description="Free Access with Registration", Definition="The right to view and/or download material without financial barriers but users are required to register or experience some other low-barrier to use.  [<a href=\u0022https://ceds.ed.gov/element/001561#FreeAccessWithRegistration\u0022>https://ceds.ed.gov/element/001561#FreeAccessWithRegistration</a>]", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("ed077791-2250-423a-aa32-06a0e8bd1a6c"), Code="LimitedFreeAccess", Description="Limited Free Access", Definition="Some material is available for viewing and/or downloading but most material tends to be accessible through other means.  [<a href=\u0022https://ceds.ed.gov/element/001561#LimitedFreeAccess\u0022>https://ceds.ed.gov/element/001561#LimitedFreeAccess</a>]", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("7d16b5e3-0f78-44f2-8cb3-04cb41b667e4"), Code="AvailableForPurchase", Description="Available for Purchase", Definition="The right to view, keep, and/or download material upon payment of a one-time fee.  [<a href=\u0022https://ceds.ed.gov/element/001561#AvailableForPurchase\u0022>https://ceds.ed.gov/element/001561#AvailableForPurchase</a>]", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("ddda5d00-c9d5-4c9a-b7ca-459bfaf40e46"), Code="AvailableBySubscription", Description="Available by Subscription", Definition="The right to view and/or download material, often for a set period of time, by way of a financial agreement between rights holders and authorized users.  [<a href=\u0022https://ceds.ed.gov/element/001561#AvailableBySubscription\u0022>https://ceds.ed.gov/element/001561#AvailableBySubscription</a>]", SortOrder=Convert.ToDecimal("7.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("c0c2748b-92ad-45d5-87bc-f64bc53c6a56"), Code="PublisherDefined", Description="Publisher Defined", Definition="Publisher defined conditions that govern the user's ability to access a learning resource.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefLearningResourceAccessRightsUrl Pick List
         /// </summary>
        public static List<RefLearningResourceAccessRightsUrl> RefLearningResourceAccessRightsUrlPickList = new List<RefLearningResourceAccessRightsUrl>
        {
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("e08e6059-2681-4c64-8be2-f15060bea1c2"), Code="FreeAccess", Description="Free Access", SortOrder=Convert.ToDecimal("0.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("ef3d0b54-8fe6-449a-aa5e-b800a14e35c6"), Code="FreeAccessWithRegistration", Description="Free Access with Registration", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("ed077791-2250-423a-aa32-06a0e8bd1a6c"), Code="LimitedFreeAccess", Description="Limited Free Access", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("7d16b5e3-0f78-44f2-8cb3-04cb41b667e4"), Code="AvailableForPurchase", Description="Available for Purchase", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("ddda5d00-c9d5-4c9a-b7ca-459bfaf40e46"), Code="AvailableBySubscription", Description="Available by Subscription", SortOrder=Convert.ToDecimal("7.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("c0c2748b-92ad-45d5-87bc-f64bc53c6a56"), Code="PublisherDefined", Description="Publisher Defined", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
