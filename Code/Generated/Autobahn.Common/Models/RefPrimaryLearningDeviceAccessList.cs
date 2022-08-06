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
        public static List<RefPrimaryLearningDeviceAccess> RefPrimaryLearningDeviceAccessList = new List<RefPrimaryLearningDeviceAccess>
        {
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("f7a189a4-761b-472c-817a-b979cd1acc68"), Code="NotShared", Description="Not Shared", Definition="The primary learning device is not shared with another individual.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("6852c580-599f-4025-9fa2-20ad24f9601f"), Code="Shared", Description="Shared", Definition="The primary learning device is shared with another individual.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("d18d62d5-162b-4527-b051-afb2f960cd12"), Code="Unknown", Description="Unknown", Definition="It is not known whether the primary learning device is shared with another individual.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefPrimaryLearningDeviceAccess Pick List
         /// </summary>
        public static List<RefPrimaryLearningDeviceAccess> RefPrimaryLearningDeviceAccessPickList = new List<RefPrimaryLearningDeviceAccess>
        {
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("f7a189a4-761b-472c-817a-b979cd1acc68"), Code="NotShared", Description="Not Shared", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("6852c580-599f-4025-9fa2-20ad24f9601f"), Code="Shared", Description="Shared", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrimaryLearningDeviceAccess { Id=Guid.Parse("d18d62d5-162b-4527-b051-afb2f960cd12"), Code="Unknown", Description="Unknown", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
