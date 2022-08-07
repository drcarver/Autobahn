//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPrimaryLearningDeviceAccessList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPrimaryLearningDeviceAccess Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPrimaryLearningDeviceAccessModel"> List
         /// </summary>
        public static List<RefPrimaryLearningDeviceAccessModel> RefPrimaryLearningDeviceAccessList = new List<RefPrimaryLearningDeviceAccessModel>
        {
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("282df8a5-3a40-4dc7-a43e-8ec0f6ab3f5a"), Code="NotShared", Description="Not Shared", Definition="The primary learning device is not shared with another individual.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("305de7bf-6753-46a7-8a2a-21fa3c008d8d"), Code="Shared", Description="Shared", Definition="The primary learning device is shared with another individual.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("c9c75a52-18c2-48b3-a6a0-8a54b1e8f450"), Code="Unknown", Description="Unknown", Definition="It is not known whether the primary learning device is shared with another individual.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefPrimaryLearningDeviceAccess Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPrimaryLearningDeviceAccessViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("282df8a5-3a40-4dc7-a43e-8ec0f6ab3f5a"), Description="Not Shared", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("305de7bf-6753-46a7-8a2a-21fa3c008d8d"), Description="Shared", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("c9c75a52-18c2-48b3-a6a0-8a54b1e8f450"), Description="Unknown", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
