//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDAudienceTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDAudienceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDAudienceTypeModel"> List
         /// </summary>
        public static List<RefPDAudienceTypeModel> RefPDAudienceTypeList = new List<RefPDAudienceTypeModel>
        {
            new RefPDAudienceType { Id=Guid.Parse("6e635cdb-2b5e-4a4d-ab15-a5e8348750c2"), Code="Individual", Description="Individual", Definition="The professional development activity is intended for delivery to an individual.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPDAudienceType { Id=Guid.Parse("f50f4981-2483-4055-91f1-2062619368a6"), Code="Group", Description="Group", Definition="The professional development activity is intended for delivery to a group.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefPDAudienceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPDAudienceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPDAudienceType { Id=Guid.Parse("6e635cdb-2b5e-4a4d-ab15-a5e8348750c2"), Description="Individual", SortOrder=Convert.ToDecimal("1.00") },
            new RefPDAudienceType { Id=Guid.Parse("f50f4981-2483-4055-91f1-2062619368a6"), Description="Group", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
