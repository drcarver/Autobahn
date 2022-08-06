//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmailTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEmailType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEmailType"> List
         /// </summary>
        public static List<RefEmailType> RefEmailTypeList = new List<RefEmailType> =
        {
            new RefEmailType { Id=Guid.Parse("96d45e1f-5fcc-4e0e-bd52-d803ae16f356"), Code="Home/personal is the type of electronic mail (e-mail) address listed for a person or organization.", Description="Home", Definition="", SortOrder=0 },
            new RefEmailType { Id=Guid.Parse("e6c8c5e2-1ec0-4734-93f6-00208d5d0390"), Code="Work is the type of electronic mail (e-mail) address listed for a person or organization.", Description="Work", Definition="", SortOrder=0 },
            new RefEmailType { Id=Guid.Parse("e2b4b553-090d-4b2b-8a3a-76e7b8b51116"), Code="Organizational (school) address is the type of electronic mail (e-mail) address listed for a person or organization.", Description="Organizational", Definition="", SortOrder=0 },
            new RefEmailType { Id=Guid.Parse("939384ad-a2b7-4fbe-ae82-ddeddb78db1a"), Code="Other is the type of electronic mail (e-mail) address listed for a person or organization.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefEmailType Pick List
         /// </summary>
        public static List<RefEmailType> RefEmailTypePickList = new List<RefEmailType> =
        {
            new RefEmailType { Id=Guid.Parse("96d45e1f-5fcc-4e0e-bd52-d803ae16f356"), Code="Home/personal is the type of electronic mail (e-mail) address listed for a person or organization.", SortOrder=0 },
            new RefEmailType { Id=Guid.Parse("e6c8c5e2-1ec0-4734-93f6-00208d5d0390"), Code="Work is the type of electronic mail (e-mail) address listed for a person or organization.", SortOrder=0 },
            new RefEmailType { Id=Guid.Parse("e2b4b553-090d-4b2b-8a3a-76e7b8b51116"), Code="Organizational (school) address is the type of electronic mail (e-mail) address listed for a person or organization.", SortOrder=0 },
            new RefEmailType { Id=Guid.Parse("939384ad-a2b7-4fbe-ae82-ddeddb78db1a"), Code="Other is the type of electronic mail (e-mail) address listed for a person or organization.", SortOrder=0 },
       };
   }
}
