//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefCharterSchoolTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefCharterSchoolType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCharterSchoolTypeModel"> List
         /// </summary>
        public static List<RefCharterSchoolTypeModel> RefCharterSchoolTypeList = new List<RefCharterSchoolTypeModel>
        {
            new RefCharterSchoolType { Id=Guid.Parse("d9c3636a-a4a2-42de-b121-3ae632651154"), Code="School", Description="School Charter", Definition="A K12 school created by contract between a state's charter authorization board and an entity other than a  college or university.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCharterSchoolType { Id=Guid.Parse("3cd0650c-2622-4acb-bb65-378f21371b5d"), Code="CollegeUniversity", Description="College/University Charter", Definition="A K12 school created by contract between a college or university and a state's charter authorization board(s).", SortOrder=Convert.ToDecimal("2.00") },
            new RefCharterSchoolType { Id=Guid.Parse("25cba140-d6b7-416a-b6ae-abc4c6e26bea"), Code="NA", Description="Not a Charter School", Definition="A school that is not a charter school.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefCharterSchoolType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCharterSchoolTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCharterSchoolType { Id=Guid.Parse("d9c3636a-a4a2-42de-b121-3ae632651154"), Description="School Charter", SortOrder=Convert.ToDecimal("1.00") },
            new RefCharterSchoolType { Id=Guid.Parse("3cd0650c-2622-4acb-bb65-378f21371b5d"), Description="College/University Charter", SortOrder=Convert.ToDecimal("2.00") },
            new RefCharterSchoolType { Id=Guid.Parse("25cba140-d6b7-416a-b6ae-abc4c6e26bea"), Description="Not a Charter School", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
