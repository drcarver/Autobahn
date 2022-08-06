//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefDevelopmentalEducationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefDevelopmentalEducationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDevelopmentalEducationType"> List
         /// </summary>
        public static List<RefDevelopmentalEducationType> RefDevelopmentalEducationTypeList = new List<RefDevelopmentalEducationType> =
        {
            new RefDevelopmentalEducationType { Id=Guid.Parse("d077b2ea-c549-4623-9918-c68f5aaf0621"), Code="Developmental Math is the category of developmental education.", Description="DevelopmentalMath", Definition="", SortOrder=0 },
            new RefDevelopmentalEducationType { Id=Guid.Parse("9233e80f-33f1-4bba-b8aa-736d6a6a4b27"), Code="Developmental English is the category of developmental education.", Description="DevelopmentalEnglish", Definition="", SortOrder=0 },
            new RefDevelopmentalEducationType { Id=Guid.Parse("80c54c06-2a31-4339-8d10-08862fb58381"), Code="Developmental Reading is the category of developmental education.", Description="DevelopmentalReading", Definition="", SortOrder=0 },
            new RefDevelopmentalEducationType { Id=Guid.Parse("05f63007-1375-40c3-ae00-bd9b78dcf797"), Code="Developmental English/Reading is the category of developmental education.", Description="DevelopmentalEnglishReading", Definition="", SortOrder=0 },
            new RefDevelopmentalEducationType { Id=Guid.Parse("319f4eb7-7fa4-48e5-b34f-245561f3700b"), Code="Developmental Other is the category of developmental education.", Description="DevelopmentalOther", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefDevelopmentalEducationType Pick List
         /// </summary>
        public static List<RefDevelopmentalEducationType> RefDevelopmentalEducationTypePickList = new List<RefDevelopmentalEducationType> =
        {
            new RefDevelopmentalEducationType { Id=Guid.Parse("d077b2ea-c549-4623-9918-c68f5aaf0621"), Code="Developmental Math is the category of developmental education.", SortOrder=0 },
            new RefDevelopmentalEducationType { Id=Guid.Parse("9233e80f-33f1-4bba-b8aa-736d6a6a4b27"), Code="Developmental English is the category of developmental education.", SortOrder=0 },
            new RefDevelopmentalEducationType { Id=Guid.Parse("80c54c06-2a31-4339-8d10-08862fb58381"), Code="Developmental Reading is the category of developmental education.", SortOrder=0 },
            new RefDevelopmentalEducationType { Id=Guid.Parse("05f63007-1375-40c3-ae00-bd9b78dcf797"), Code="Developmental English/Reading is the category of developmental education.", SortOrder=0 },
            new RefDevelopmentalEducationType { Id=Guid.Parse("319f4eb7-7fa4-48e5-b34f-245561f3700b"), Code="Developmental Other is the category of developmental education.", SortOrder=0 },
       };
   }
}
