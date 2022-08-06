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
        public static List<RefFirearmType> RefFirearmTypeList = new List<RefFirearmType>
        {
            new RefFirearmType { Id=Guid.Parse("15ee0e72-9448-4f4e-b013-43f3dad596c6"), Code="Handguns", Description="Handguns", Definition="Handguns is the type of firearm.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFirearmType { Id=Guid.Parse("967f9af1-c72c-49ea-b8b4-65f2b96d53df"), Code="RiflesShotguns", Description="Rifles / Shotguns", Definition="Rifles / Shotguns is the type of firearm.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFirearmType { Id=Guid.Parse("fe355de3-b3ed-48c3-9323-d482005334b0"), Code="Multiple", Description="More than one type of weapon or firearm", Definition="More than one type of weapon or firearm.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFirearmType { Id=Guid.Parse("7ac91167-d837-4e99-b4d8-7e820b590151"), Code="Other", Description="Other", Definition="The type of firearm is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefFirearmType Pick List
         /// </summary>
        public static List<RefFirearmType> RefFirearmTypePickList = new List<RefFirearmType>
        {
            new RefFirearmType { Id=Guid.Parse("15ee0e72-9448-4f4e-b013-43f3dad596c6"), Code="Handguns", Description="Handguns", SortOrder=Convert.ToDecimal("1.00") },
            new RefFirearmType { Id=Guid.Parse("967f9af1-c72c-49ea-b8b4-65f2b96d53df"), Code="RiflesShotguns", Description="Rifles / Shotguns", SortOrder=Convert.ToDecimal("2.00") },
            new RefFirearmType { Id=Guid.Parse("fe355de3-b3ed-48c3-9323-d482005334b0"), Code="Multiple", Description="More than one type of weapon or firearm", SortOrder=Convert.ToDecimal("3.00") },
            new RefFirearmType { Id=Guid.Parse("7ac91167-d837-4e99-b4d8-7e820b590151"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
