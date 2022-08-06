//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFirearmTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFirearmType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFirearmType"> List
         /// </summary>
        public static List<RefFirearmType> RefFirearmTypeList = new List<RefFirearmType> =
        {
            new RefFirearmType { Id=Guid.Parse("3fa23b23-cc79-4c66-8f34-5a077bb62462"), Code="Handguns is the type of firearm.", Description="Handguns", Definition="", SortOrder=0 },
            new RefFirearmType { Id=Guid.Parse("b70e140e-6b54-4991-a33c-7398201c1e82"), Code="Rifles / Shotguns is the type of firearm.", Description="RiflesShotguns", Definition="", SortOrder=0 },
            new RefFirearmType { Id=Guid.Parse("72716a98-ee34-4cf1-8098-3b833fb2a985"), Code="More than one type of weapon or firearm.", Description="Multiple", Definition="", SortOrder=0 },
            new RefFirearmType { Id=Guid.Parse("c71a43c3-4217-43c3-b7d5-c85ff6fd916f"), Code="The type of firearm is in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFirearmType Pick List
         /// </summary>
        public static List<RefFirearmType> RefFirearmTypePickList = new List<RefFirearmType> =
        {
            new RefFirearmType { Id=Guid.Parse("3fa23b23-cc79-4c66-8f34-5a077bb62462"), Code="Handguns is the type of firearm.", SortOrder=0 },
            new RefFirearmType { Id=Guid.Parse("b70e140e-6b54-4991-a33c-7398201c1e82"), Code="Rifles / Shotguns is the type of firearm.", SortOrder=0 },
            new RefFirearmType { Id=Guid.Parse("72716a98-ee34-4cf1-8098-3b833fb2a985"), Code="More than one type of weapon or firearm.", SortOrder=0 },
            new RefFirearmType { Id=Guid.Parse("c71a43c3-4217-43c3-b7d5-c85ff6fd916f"), Code="The type of firearm is in a category not yet defined in CEDS.", SortOrder=0 },
       };
   }
}
