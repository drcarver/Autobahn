//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPrimaryLearningDeviceProviderList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPrimaryLearningDeviceProvider Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPrimaryLearningDeviceProvider"> List
         /// </summary>
        public static List<RefPrimaryLearningDeviceProvider> RefPrimaryLearningDeviceProviderList = new List<RefPrimaryLearningDeviceProvider> =
        {
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("f623eb87-99bc-42a9-b9be-97d7a04ea626"), Code="The provider of the primary learning device is the student or guardian.", Description="Personal", Definition="", SortOrder=0 },
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("17eb507b-8b95-466b-bf5d-d07c65e124c9"), Code="The provider of the primary learning device is the school.", Description="School", Definition="", SortOrder=0 },
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("6e60cecc-1e1a-4b94-bc67-53af5f826ef8"), Code="The provider of the primary learning device is not yet defined.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPrimaryLearningDeviceProvider Pick List
         /// </summary>
        public static List<RefPrimaryLearningDeviceProvider> RefPrimaryLearningDeviceProviderPickList = new List<RefPrimaryLearningDeviceProvider> =
        {
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("f623eb87-99bc-42a9-b9be-97d7a04ea626"), Code="The provider of the primary learning device is the student or guardian.", SortOrder=0 },
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("17eb507b-8b95-466b-bf5d-d07c65e124c9"), Code="The provider of the primary learning device is the school.", SortOrder=0 },
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("6e60cecc-1e1a-4b94-bc67-53af5f826ef8"), Code="The provider of the primary learning device is not yet defined.", SortOrder=0 },
       };
   }
}
