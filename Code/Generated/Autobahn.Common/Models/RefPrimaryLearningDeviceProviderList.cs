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
        public static List<RefPrimaryLearningDeviceProvider> RefPrimaryLearningDeviceProviderList = new List<RefPrimaryLearningDeviceProvider>
        {
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("888e4b82-654a-490e-989f-3c7e16272f36"), Code="Personal", Description="Personal", Definition="The provider of the primary learning device is the student or guardian.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("f9720b62-4426-4152-8740-9de6054c00cc"), Code="School", Description="School", Definition="The provider of the primary learning device is the school.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("f21ae061-04ae-4ad6-9d3b-cb592fe4cd5a"), Code="Other", Description="Other", Definition="The provider of the primary learning device is not yet defined.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefPrimaryLearningDeviceProvider Pick List
         /// </summary>
        public static List<RefPrimaryLearningDeviceProvider> RefPrimaryLearningDeviceProviderPickList = new List<RefPrimaryLearningDeviceProvider>
        {
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("888e4b82-654a-490e-989f-3c7e16272f36"), Code="Personal", Description="Personal", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("f9720b62-4426-4152-8740-9de6054c00cc"), Code="School", Description="School", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("f21ae061-04ae-4ad6-9d3b-cb592fe4cd5a"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
