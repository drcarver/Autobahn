//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   RefOperationalStatusTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Reference.Models
{
     /// <summary>
     /// The list of RefOperationalStatusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefOperationalStatusTypeModel"> List
         /// </summary>
        public static List<RefOperationalStatusTypeModel> RefOperationalStatusTypeList = new List<RefOperationalStatusTypeModel>
        {
            new RefOperationalStatusType { Id=Guid.Parse("2ef38d21-294e-45ae-8b79-a9b8cb22873d"), Code="000174", Description="Local Education Agency Operational Status", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefOperationalStatusType { Id=Guid.Parse("1ca9718e-b996-48f9-b9ab-7193aa961b1f"), Code="000533", Description="School Operational Status", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefOperationalStatusType { Id=Guid.Parse("7c846074-4996-4daf-a391-c53b84079824"), Code="001418", Description="Organization Operational Status", Definition="", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefOperationalStatusType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefOperationalStatusTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefOperationalStatusType { Id=Guid.Parse("2ef38d21-294e-45ae-8b79-a9b8cb22873d"), Description="Local Education Agency Operational Status", SortOrder=Convert.ToDecimal("") },
            new RefOperationalStatusType { Id=Guid.Parse("1ca9718e-b996-48f9-b9ab-7193aa961b1f"), Description="School Operational Status", SortOrder=Convert.ToDecimal("") },
            new RefOperationalStatusType { Id=Guid.Parse("7c846074-4996-4daf-a391-c53b84079824"), Description="Organization Operational Status", SortOrder=Convert.ToDecimal("") },
       };
   }
}
