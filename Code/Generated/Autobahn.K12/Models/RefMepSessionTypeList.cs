//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefMepSessionTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefMepSessionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepSessionTypeModel"> List
         /// </summary>
        public static List<RefMepSessionTypeModel> RefMepSessionTypeList = new List<RefMepSessionTypeModel>
        {
            new RefMepSessionType { Id=Guid.Parse("99dfd2e3-f7d9-4a04-93fd-3ff1e5922f75"), Code="RegularSchoolYear", Description="Regular School Year", Definition="The Migrant Education Program operates during the Regular School Year.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepSessionType { Id=Guid.Parse("6ca6ece9-0b61-4680-a95f-d4cdaa322c77"), Code="SummerTerm", Description="Summer Term or Intersession", Definition="The Migrant Education Program operates during the Summer Term or Intersession.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefMepSessionType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefMepSessionTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefMepSessionType { Id=Guid.Parse("99dfd2e3-f7d9-4a04-93fd-3ff1e5922f75"), Description="Regular School Year", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepSessionType { Id=Guid.Parse("6ca6ece9-0b61-4680-a95f-d4cdaa322c77"), Description="Summer Term or Intersession", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
