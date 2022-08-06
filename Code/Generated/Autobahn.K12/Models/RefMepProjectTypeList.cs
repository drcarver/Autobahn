//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefMepProjectTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefMepProjectType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepProjectType"> List
         /// </summary>
        public static List<RefMepProjectType> RefMepProjectTypeList = new List<RefMepProjectType> =
        {
            new RefMepProjectType { Id=Guid.Parse("9f030d63-518f-4272-8c20-d75aac19dbcd"), Code="The project funded in whole or in part by Migrant Education Program funds is  available during the regular school year - school day only.", Description="SchoolDay", Definition="", SortOrder=0 },
            new RefMepProjectType { Id=Guid.Parse("8b75b65e-3388-4812-ac6d-1b2e8a5483d6"), Code="The project funded in whole or in part by Migrant Education Program funds is  available during the regular school year - school day/extended day.", Description="ExtendedDay", Definition="", SortOrder=0 },
            new RefMepProjectType { Id=Guid.Parse("f29cf7f2-7165-49d8-8f22-5152da3b7f13"), Code="The project funded in whole or in part by Migrant Education Program funds is available during summer/intersession only.", Description="SummerIntersession", Definition="", SortOrder=0 },
            new RefMepProjectType { Id=Guid.Parse("0b25b5bb-9221-4372-bb9d-fd29dcf92c40"), Code="The project funded in whole or in part by Migrant Education Program funds is available year round.", Description="YearRound", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefMepProjectType Pick List
         /// </summary>
        public static List<RefMepProjectType> RefMepProjectTypePickList = new List<RefMepProjectType> =
        {
            new RefMepProjectType { Id=Guid.Parse("9f030d63-518f-4272-8c20-d75aac19dbcd"), Code="The project funded in whole or in part by Migrant Education Program funds is  available during the regular school year - school day only.", SortOrder=0 },
            new RefMepProjectType { Id=Guid.Parse("8b75b65e-3388-4812-ac6d-1b2e8a5483d6"), Code="The project funded in whole or in part by Migrant Education Program funds is  available during the regular school year - school day/extended day.", SortOrder=0 },
            new RefMepProjectType { Id=Guid.Parse("f29cf7f2-7165-49d8-8f22-5152da3b7f13"), Code="The project funded in whole or in part by Migrant Education Program funds is available during summer/intersession only.", SortOrder=0 },
            new RefMepProjectType { Id=Guid.Parse("0b25b5bb-9221-4372-bb9d-fd29dcf92c40"), Code="The project funded in whole or in part by Migrant Education Program funds is available year round.", SortOrder=0 },
       };
   }
}
