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
        public static List<RefLearningResourceAccessRightsUrl> RefLearningResourceAccessRightsUrlList = new List<RefLearningResourceAccessRightsUrl> =
        {
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("7268f4a7-6f93-4b3f-af98-4e6767f75bcf"), Code="The right to view and/or download material without financial, registration, or excessive advertising barriers.  [<a href="https://ceds.ed.gov/element/001561#FreeAccess">https://ceds.ed.gov/element/001561#FreeAccess</a>]", Description="FreeAccess", Definition="", SortOrder=0 },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("95edf898-7b9c-4dc9-ba7f-64e70cb09f7b"), Code="The right to view and/or download material without financial barriers but users are required to register or experience some other low-barrier to use.  [<a href="https://ceds.ed.gov/element/001561#FreeAccessWithRegistration">https://ceds.ed.gov/element/001561#FreeAccessWithRegistration</a>]", Description="FreeAccessWithRegistration", Definition="", SortOrder=0 },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("264cf8c4-c25f-4ac3-9264-c1759298f007"), Code="Some material is available for viewing and/or downloading but most material tends to be accessible through other means.  [<a href="https://ceds.ed.gov/element/001561#LimitedFreeAccess">https://ceds.ed.gov/element/001561#LimitedFreeAccess</a>]", Description="LimitedFreeAccess", Definition="", SortOrder=0 },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("df443ef9-9c59-41ec-8f25-1a8259fb7756"), Code="The right to view, keep, and/or download material upon payment of a one-time fee.  [<a href="https://ceds.ed.gov/element/001561#AvailableForPurchase">https://ceds.ed.gov/element/001561#AvailableForPurchase</a>]", Description="AvailableForPurchase", Definition="", SortOrder=0 },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("265a2272-bc09-49e1-a94f-6333d354ce21"), Code="The right to view and/or download material, often for a set period of time, by way of a financial agreement between rights holders and authorized users.  [<a href="https://ceds.ed.gov/element/001561#AvailableBySubscription">https://ceds.ed.gov/element/001561#AvailableBySubscription</a>]", Description="AvailableBySubscription", Definition="", SortOrder=0 },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("5921b7c2-320a-45bc-978a-be736b790e8e"), Code="Publisher defined conditions that govern the user's ability to access a learning resource.", Description="PublisherDefined", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLearningResourceAccessRightsUrl Pick List
         /// </summary>
        public static List<RefLearningResourceAccessRightsUrl> RefLearningResourceAccessRightsUrlPickList = new List<RefLearningResourceAccessRightsUrl> =
        {
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("7268f4a7-6f93-4b3f-af98-4e6767f75bcf"), Code="The right to view and/or download material without financial, registration, or excessive advertising barriers.  [<a href="https://ceds.ed.gov/element/001561#FreeAccess">https://ceds.ed.gov/element/001561#FreeAccess</a>]", SortOrder=0 },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("95edf898-7b9c-4dc9-ba7f-64e70cb09f7b"), Code="The right to view and/or download material without financial barriers but users are required to register or experience some other low-barrier to use.  [<a href="https://ceds.ed.gov/element/001561#FreeAccessWithRegistration">https://ceds.ed.gov/element/001561#FreeAccessWithRegistration</a>]", SortOrder=0 },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("264cf8c4-c25f-4ac3-9264-c1759298f007"), Code="Some material is available for viewing and/or downloading but most material tends to be accessible through other means.  [<a href="https://ceds.ed.gov/element/001561#LimitedFreeAccess">https://ceds.ed.gov/element/001561#LimitedFreeAccess</a>]", SortOrder=0 },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("df443ef9-9c59-41ec-8f25-1a8259fb7756"), Code="The right to view, keep, and/or download material upon payment of a one-time fee.  [<a href="https://ceds.ed.gov/element/001561#AvailableForPurchase">https://ceds.ed.gov/element/001561#AvailableForPurchase</a>]", SortOrder=0 },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("265a2272-bc09-49e1-a94f-6333d354ce21"), Code="The right to view and/or download material, often for a set period of time, by way of a financial agreement between rights holders and authorized users.  [<a href="https://ceds.ed.gov/element/001561#AvailableBySubscription">https://ceds.ed.gov/element/001561#AvailableBySubscription</a>]", SortOrder=0 },
            new RefLearningResourceAccessRightsUrl { Id=Guid.Parse("5921b7c2-320a-45bc-978a-be736b790e8e"), Code="Publisher defined conditions that govern the user's ability to access a learning resource.", SortOrder=0 },
       };
   }
}
