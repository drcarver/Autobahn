//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEducationLevelTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEducationLevelType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEducationLevelTypeModel"> List
         /// </summary>
        public static List<RefEducationLevelTypeModel> RefEducationLevelTypeList = new List<RefEducationLevelTypeModel>
        {
            new RefEducationLevelType { Id=Guid.Parse("4e85d669-9b75-4674-bceb-131bbb569e42"), Code="000141", Description="Highest Level of Education Completed", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("672dcf11-ff71-4a7e-9656-64f4602ec8a8"), Code="000725", Description="Competency Definition Education Level", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("79a59e26-957a-4454-9109-82d588064392"), Code="001229", Description="Maternal Guardian Education", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("e0de6e73-dc73-48e3-905f-c192a8476881"), Code="001230", Description="Paternal Guardian Education", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("6aa5f859-fb96-4280-89e3-289b3ca4db6a"), Code="001246", Description="Learning Resource Education Level�", Definition="", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefEducationLevelType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefEducationLevelTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefEducationLevelType { Id=Guid.Parse("4e85d669-9b75-4674-bceb-131bbb569e42"), Description="Highest Level of Education Completed", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("672dcf11-ff71-4a7e-9656-64f4602ec8a8"), Description="Competency Definition Education Level", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("79a59e26-957a-4454-9109-82d588064392"), Description="Maternal Guardian Education", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("e0de6e73-dc73-48e3-905f-c192a8476881"), Description="Paternal Guardian Education", SortOrder=Convert.ToDecimal("") },
            new RefEducationLevelType { Id=Guid.Parse("6aa5f859-fb96-4280-89e3-289b3ca4db6a"), Description="Learning Resource Education Level�", SortOrder=Convert.ToDecimal("") },
       };
   }
}
