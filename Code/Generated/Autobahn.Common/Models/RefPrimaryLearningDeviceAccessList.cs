//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPrimaryLearningDeviceAccessList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPrimaryLearningDeviceAccess Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPrimaryLearningDeviceAccess"> List
         /// </summary>
        public static List<RefPrimaryLearningDeviceAccess> RefPrimaryLearningDeviceAccessList = new List<RefPrimaryLearningDeviceAccess> =
        {
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("5c69339c-d6af-434a-b6c2-f7efc6709c2d"), Code="The primary learning device is not shared with another individual.", Description="NotShared", Definition="", SortOrder=0 },
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("65efb916-1317-4583-805b-11468c834601"), Code="The primary learning device is shared with another individual.", Description="Shared", Definition="", SortOrder=0 },
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("97cd7de8-3f45-473a-a012-125eaa5ea259"), Code="It is not known whether the primary learning device is shared with another individual.", Description="Unknown", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPrimaryLearningDeviceAccess Pick List
         /// </summary>
        public static List<RefPrimaryLearningDeviceAccess> RefPrimaryLearningDeviceAccessPickList = new List<RefPrimaryLearningDeviceAccess> =
        {
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("5c69339c-d6af-434a-b6c2-f7efc6709c2d"), Code="The primary learning device is not shared with another individual.", SortOrder=0 },
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("65efb916-1317-4583-805b-11468c834601"), Code="The primary learning device is shared with another individual.", SortOrder=0 },
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("97cd7de8-3f45-473a-a012-125eaa5ea259"), Code="It is not known whether the primary learning device is shared with another individual.", SortOrder=0 },
       };
   }
}
