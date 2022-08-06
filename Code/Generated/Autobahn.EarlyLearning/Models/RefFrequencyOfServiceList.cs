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
        public static List<RefFrequencyOfService> RefFrequencyOfServiceList = new List<RefFrequencyOfService> =
        {
            new RefFrequencyOfService { Id=Guid.Parse("fadfa6a0-3f77-4a16-8a2c-c59f3cc75007"), Code="Daily service is planned to occur.", Description="Daily", Definition="", SortOrder=0 },
            new RefFrequencyOfService { Id=Guid.Parse("f58deb2e-1faa-4e37-b673-3eca15992bd7"), Code="Weekly service is planned to occur.", Description="Weekly", Definition="", SortOrder=0 },
            new RefFrequencyOfService { Id=Guid.Parse("a7ee481e-22f3-4c8f-afdb-c6ed48ac15fa"), Code="Monthly service is planned to occur.", Description="Monthly", Definition="", SortOrder=0 },
            new RefFrequencyOfService { Id=Guid.Parse("d877dd28-88e8-4918-9000-8f4151864794"), Code="Quarterly service is planned to occur.", Description="Quarterly", Definition="", SortOrder=0 },
            new RefFrequencyOfService { Id=Guid.Parse("c9774377-1462-44ed-ae90-8e7e5aef1d04"), Code="Annually service is planned to occur.", Description="Annually", Definition="", SortOrder=0 },
            new RefFrequencyOfService { Id=Guid.Parse("5d963c6c-8713-42a8-a608-51b9ec13c509"), Code="The service is planned to occur one time.", Description="OneTime", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFrequencyOfService Pick List
         /// </summary>
        public static List<RefFrequencyOfService> RefFrequencyOfServicePickList = new List<RefFrequencyOfService> =
        {
            new RefFrequencyOfService { Id=Guid.Parse("fadfa6a0-3f77-4a16-8a2c-c59f3cc75007"), Code="Daily service is planned to occur.", SortOrder=0 },
            new RefFrequencyOfService { Id=Guid.Parse("f58deb2e-1faa-4e37-b673-3eca15992bd7"), Code="Weekly service is planned to occur.", SortOrder=0 },
            new RefFrequencyOfService { Id=Guid.Parse("a7ee481e-22f3-4c8f-afdb-c6ed48ac15fa"), Code="Monthly service is planned to occur.", SortOrder=0 },
            new RefFrequencyOfService { Id=Guid.Parse("d877dd28-88e8-4918-9000-8f4151864794"), Code="Quarterly service is planned to occur.", SortOrder=0 },
            new RefFrequencyOfService { Id=Guid.Parse("c9774377-1462-44ed-ae90-8e7e5aef1d04"), Code="Annually service is planned to occur.", SortOrder=0 },
            new RefFrequencyOfService { Id=Guid.Parse("5d963c6c-8713-42a8-a608-51b9ec13c509"), Code="The service is planned to occur one time.", SortOrder=0 },
       };
   }
}
