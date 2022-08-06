//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAcademicTermDesignatorList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAcademicTermDesignator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAcademicTermDesignator"> List
         /// </summary>
        public static List<RefAcademicTermDesignator> RefAcademicTermDesignatorList = new List<RefAcademicTermDesignator> =
        {
            new RefAcademicTermDesignator { Id=Guid.Parse("8a16c5e5-cb0c-47a2-ae90-e905e2017977"), Code="Fall is the academic term for which the data apply.", Description="Fall", Definition="", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("6585b7eb-8dfb-415f-bb97-c540609a3625"), Code="Winter is the academic term for which the data apply.", Description="Winter", Definition="", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("11db9316-327f-415e-a1f0-fb561236581d"), Code="Winter Intersession is the academic term for which the data apply.", Description="WinterIntersession", Definition="", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("9c45deba-75c7-4086-b46b-dc2252ff3d6b"), Code="Spring is the academic term for which the data apply.", Description="Spring", Definition="", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("ad7949cd-6f15-4edd-8f74-f3159ab782f8"), Code="Summer is the academic term for which the data apply.", Description="Summer", Definition="", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("abaf25af-9b9c-4564-8d9d-e65dc9627392"), Code="Summer 1 is the academic term for which the data apply.", Description="Summer1", Definition="", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("4c8ee365-03a7-4b5d-ac71-bd9d330ed7b9"), Code="Summer 2 is the academic term for which the data apply.", Description="Summer2", Definition="", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("86268fba-41ec-45b9-b0b4-b7fff276b4a3"), Code="Spring Intersession is the academic term for which the data apply.", Description="SpringIntersession", Definition="", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("58303121-0cfe-4c76-a1db-6c0c2c27d455"), Code="Other is the academic term for which the data apply.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAcademicTermDesignator Pick List
         /// </summary>
        public static List<RefAcademicTermDesignator> RefAcademicTermDesignatorPickList = new List<RefAcademicTermDesignator> =
        {
            new RefAcademicTermDesignator { Id=Guid.Parse("8a16c5e5-cb0c-47a2-ae90-e905e2017977"), Code="Fall is the academic term for which the data apply.", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("6585b7eb-8dfb-415f-bb97-c540609a3625"), Code="Winter is the academic term for which the data apply.", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("11db9316-327f-415e-a1f0-fb561236581d"), Code="Winter Intersession is the academic term for which the data apply.", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("9c45deba-75c7-4086-b46b-dc2252ff3d6b"), Code="Spring is the academic term for which the data apply.", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("ad7949cd-6f15-4edd-8f74-f3159ab782f8"), Code="Summer is the academic term for which the data apply.", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("abaf25af-9b9c-4564-8d9d-e65dc9627392"), Code="Summer 1 is the academic term for which the data apply.", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("4c8ee365-03a7-4b5d-ac71-bd9d330ed7b9"), Code="Summer 2 is the academic term for which the data apply.", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("86268fba-41ec-45b9-b0b4-b7fff276b4a3"), Code="Spring Intersession is the academic term for which the data apply.", SortOrder=0 },
            new RefAcademicTermDesignator { Id=Guid.Parse("58303121-0cfe-4c76-a1db-6c0c2c27d455"), Code="Other is the academic term for which the data apply.", SortOrder=0 },
       };
   }
}
