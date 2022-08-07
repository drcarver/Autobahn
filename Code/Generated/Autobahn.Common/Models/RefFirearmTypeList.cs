//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFirearmTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFirearmType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFirearmTypeModel"> List
         /// </summary>
        public static List<RefFirearmTypeModel> RefFirearmTypeList = new List<RefFirearmTypeModel>
        {
            new RefFirearmType { Id=Guid.Parse("b01f29ac-f2d4-484f-9c96-4c1da03b937b"), Code="Handguns", Description="Handguns", Definition="Handguns is the type of firearm.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFirearmType { Id=Guid.Parse("1e9639cb-69e1-4906-9f9c-251b536d884d"), Code="RiflesShotguns", Description="Rifles / Shotguns", Definition="Rifles / Shotguns is the type of firearm.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFirearmType { Id=Guid.Parse("79064f60-dd40-4b8a-ade5-7c49be8f611d"), Code="Multiple", Description="More than one type of weapon or firearm", Definition="More than one type of weapon or firearm.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFirearmType { Id=Guid.Parse("72a955f9-4f14-4d6e-b4c5-2b12f16a6517"), Code="Other", Description="Other", Definition="The type of firearm is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefFirearmType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFirearmTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFirearmType { Id=Guid.Parse("b01f29ac-f2d4-484f-9c96-4c1da03b937b"), Description="Handguns", SortOrder=Convert.ToDecimal("1.00") },
            new RefFirearmType { Id=Guid.Parse("1e9639cb-69e1-4906-9f9c-251b536d884d"), Description="Rifles / Shotguns", SortOrder=Convert.ToDecimal("2.00") },
            new RefFirearmType { Id=Guid.Parse("79064f60-dd40-4b8a-ade5-7c49be8f611d"), Description="More than one type of weapon or firearm", SortOrder=Convert.ToDecimal("3.00") },
            new RefFirearmType { Id=Guid.Parse("72a955f9-4f14-4d6e-b4c5-2b12f16a6517"), Description="Other", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
