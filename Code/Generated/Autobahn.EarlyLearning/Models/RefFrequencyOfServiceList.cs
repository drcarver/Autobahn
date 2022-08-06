//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefFrequencyOfServiceList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefFrequencyOfService Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFrequencyOfService"> List
         /// </summary>
        public static List<RefFrequencyOfService> RefFrequencyOfServiceList = new List<RefFrequencyOfService>
        {
            new RefFrequencyOfService { Id=Guid.Parse("66b59630-ba42-491e-b722-a80b1f8888d3"), Code="Daily", Description="Daily", Definition="Daily service is planned to occur.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFrequencyOfService { Id=Guid.Parse("945a73a2-117b-42d0-8075-216da9d78b3e"), Code="Weekly", Description="Weekly", Definition="Weekly service is planned to occur.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFrequencyOfService { Id=Guid.Parse("c9c20077-6fd0-4fe0-9066-cee292b7f184"), Code="Monthly", Description="Monthly", Definition="Monthly service is planned to occur.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFrequencyOfService { Id=Guid.Parse("c7096cbb-527d-4dfb-9c98-d85afd5bd2b7"), Code="Quarterly", Description="Quarterly", Definition="Quarterly service is planned to occur.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFrequencyOfService { Id=Guid.Parse("368666aa-ab27-40ff-8c51-ed6ce7e52172"), Code="Annually", Description="Annually", Definition="Annually service is planned to occur.", SortOrder=Convert.ToDecimal("9.00") },
            new RefFrequencyOfService { Id=Guid.Parse("1c22c934-e027-4f3d-8514-a387b1f4c553"), Code="OneTime", Description="One Time", Definition="The service is planned to occur one time.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The RefFrequencyOfService Pick List
         /// </summary>
        public static List<RefFrequencyOfService> RefFrequencyOfServicePickList = new List<RefFrequencyOfService>
        {
            new RefFrequencyOfService { Id=Guid.Parse("66b59630-ba42-491e-b722-a80b1f8888d3"), Code="Daily", Description="Daily", SortOrder=Convert.ToDecimal("1.00") },
            new RefFrequencyOfService { Id=Guid.Parse("945a73a2-117b-42d0-8075-216da9d78b3e"), Code="Weekly", Description="Weekly", SortOrder=Convert.ToDecimal("3.00") },
            new RefFrequencyOfService { Id=Guid.Parse("c9c20077-6fd0-4fe0-9066-cee292b7f184"), Code="Monthly", Description="Monthly", SortOrder=Convert.ToDecimal("5.00") },
            new RefFrequencyOfService { Id=Guid.Parse("c7096cbb-527d-4dfb-9c98-d85afd5bd2b7"), Code="Quarterly", Description="Quarterly", SortOrder=Convert.ToDecimal("7.00") },
            new RefFrequencyOfService { Id=Guid.Parse("368666aa-ab27-40ff-8c51-ed6ce7e52172"), Code="Annually", Description="Annually", SortOrder=Convert.ToDecimal("9.00") },
            new RefFrequencyOfService { Id=Guid.Parse("1c22c934-e027-4f3d-8514-a387b1f4c553"), Code="OneTime", Description="One Time", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
