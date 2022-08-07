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
        /// The complete <see cref="RefLearningResourceAccessRightsUrlModel"> List
         /// </summary>
        public static List<RefLearningResourceAccessRightsUrlModel> RefLearningResourceAccessRightsUrlList = new List<RefLearningResourceAccessRightsUrlModel>
        {
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("80897a26-75c7-4feb-801a-a7dcfd24b1fa"), Code="FreeAccess", Description="Free Access", Definition="The right to view and/or download material without financial, registration, or excessive advertising barriers.  [<a href=\u0022https://ceds.ed.gov/element/001561#FreeAccess\u0022>https://ceds.ed.gov/element/001561#FreeAccess</a>]", SortOrder=Convert.ToDecimal("0.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("52ace015-247d-41fd-9ee5-ae994eead947"), Code="FreeAccessWithRegistration", Description="Free Access with Registration", Definition="The right to view and/or download material without financial barriers but users are required to register or experience some other low-barrier to use.  [<a href=\u0022https://ceds.ed.gov/element/001561#FreeAccessWithRegistration\u0022>https://ceds.ed.gov/element/001561#FreeAccessWithRegistration</a>]", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("34713e26-5029-4543-a4ff-8e91aeeb2724"), Code="LimitedFreeAccess", Description="Limited Free Access", Definition="Some material is available for viewing and/or downloading but most material tends to be accessible through other means.  [<a href=\u0022https://ceds.ed.gov/element/001561#LimitedFreeAccess\u0022>https://ceds.ed.gov/element/001561#LimitedFreeAccess</a>]", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("425741c4-0307-47f8-8fab-0116afa99dfd"), Code="AvailableForPurchase", Description="Available for Purchase", Definition="The right to view, keep, and/or download material upon payment of a one-time fee.  [<a href=\u0022https://ceds.ed.gov/element/001561#AvailableForPurchase\u0022>https://ceds.ed.gov/element/001561#AvailableForPurchase</a>]", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("d973269b-5966-4e28-93a7-56b7d31a4132"), Code="AvailableBySubscription", Description="Available by Subscription", Definition="The right to view and/or download material, often for a set period of time, by way of a financial agreement between rights holders and authorized users.  [<a href=\u0022https://ceds.ed.gov/element/001561#AvailableBySubscription\u0022>https://ceds.ed.gov/element/001561#AvailableBySubscription</a>]", SortOrder=Convert.ToDecimal("7.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("8b8787ca-1d7e-4144-bc32-96153176b0f4"), Code="PublisherDefined", Description="Publisher Defined", Definition="Publisher defined conditions that govern the user's ability to access a learning resource.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefLearningResourceAccessRightsUrl Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearningResourceAccessRightsUrlViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("80897a26-75c7-4feb-801a-a7dcfd24b1fa"), Description="Free Access", SortOrder=Convert.ToDecimal("0.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("52ace015-247d-41fd-9ee5-ae994eead947"), Description="Free Access with Registration", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("34713e26-5029-4543-a4ff-8e91aeeb2724"), Description="Limited Free Access", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("425741c4-0307-47f8-8fab-0116afa99dfd"), Description="Available for Purchase", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("d973269b-5966-4e28-93a7-56b7d31a4132"), Description="Available by Subscription", SortOrder=Convert.ToDecimal("7.00") },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("8b8787ca-1d7e-4144-bc32-96153176b0f4"), Description="Publisher Defined", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
