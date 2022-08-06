//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefServiceFrequencyList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefServiceFrequency Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefServiceFrequency"> List
         /// </summary>
        public static List<RefServiceFrequency> RefServiceFrequencyList = new List<RefServiceFrequency> =
        {
            new RefServiceFrequency { Id=Guid.Parse("dfa6a713-8d99-4890-a87b-fd1bcbfdd1ef"), Code="The service is planned to be provided Daily.", Description="Daily", Definition="", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("cd74bf65-70d4-47f6-ab20-37ef85931b55"), Code="The service is planned to be provided Weekly.", Description="Weekly", Definition="", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("376a6948-2da2-4511-bfe3-fe9079039096"), Code="The service is planned to be provided Biweekly.", Description="Biweekly", Definition="", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("941543aa-b77b-4476-a919-4d64bd3afbfc"), Code="The service is planned to be provided Monthly.", Description="Monthly", Definition="", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("899ffbdf-eff5-437f-9588-2d09ab0c4c87"), Code="The service is planned to be provided Bimonthly.", Description="Bimonthly", Definition="", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("25e5fd6d-fc5a-4d18-8c7f-b938ace9cc9e"), Code="The service is planned to be provided Quarterly.", Description="Quarterly", Definition="", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("f112b18b-f896-4a07-bb7e-2669f1a2978d"), Code="The service is planned to be provided Semiannually.", Description="Semiannually", Definition="", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("6c810895-15c3-4b1d-b62e-d3b567f8971f"), Code="The service is planned to be provided Annually.", Description="Annually", Definition="", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("87e724b1-3e2f-48d3-a4b5-4b731cc7199e"), Code="The service is planned to be provided at a frequency not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefServiceFrequency Pick List
         /// </summary>
        public static List<RefServiceFrequency> RefServiceFrequencyPickList = new List<RefServiceFrequency> =
        {
            new RefServiceFrequency { Id=Guid.Parse("dfa6a713-8d99-4890-a87b-fd1bcbfdd1ef"), Code="The service is planned to be provided Daily.", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("cd74bf65-70d4-47f6-ab20-37ef85931b55"), Code="The service is planned to be provided Weekly.", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("376a6948-2da2-4511-bfe3-fe9079039096"), Code="The service is planned to be provided Biweekly.", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("941543aa-b77b-4476-a919-4d64bd3afbfc"), Code="The service is planned to be provided Monthly.", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("899ffbdf-eff5-437f-9588-2d09ab0c4c87"), Code="The service is planned to be provided Bimonthly.", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("25e5fd6d-fc5a-4d18-8c7f-b938ace9cc9e"), Code="The service is planned to be provided Quarterly.", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("f112b18b-f896-4a07-bb7e-2669f1a2978d"), Code="The service is planned to be provided Semiannually.", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("6c810895-15c3-4b1d-b62e-d3b567f8971f"), Code="The service is planned to be provided Annually.", SortOrder=0 },
            new RefServiceFrequency { Id=Guid.Parse("87e724b1-3e2f-48d3-a4b5-4b731cc7199e"), Code="The service is planned to be provided at a frequency not yet defined in CEDS.", SortOrder=0 },
       };
   }
}
