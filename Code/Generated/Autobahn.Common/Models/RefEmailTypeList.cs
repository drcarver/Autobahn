//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmailTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEmailType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEmailTypeModel"> List
         /// </summary>
        public static List<RefEmailTypeModel> RefEmailTypeList = new List<RefEmailTypeModel>
        {
            new RefEmailType { Id=Guid.Parse("f82f3077-6d50-46f4-997c-056c03e92b68"), Code="Home", Description="Home/personal", Definition="Home/personal is the type of electronic mail (e-mail) address listed for a person or organization.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmailType { Id=Guid.Parse("42fe05b1-2442-43d1-ada1-566913803969"), Code="Work", Description="Work", Definition="Work is the type of electronic mail (e-mail) address listed for a person or organization.", SortOrder=Convert.ToDecimal("2.00") },
            new RefEmailType { Id=Guid.Parse("3fcbdc36-0438-4372-ac0c-f661be59c889"), Code="Organizational", Description="Organizational (school) address", Definition="Organizational (school) address is the type of electronic mail (e-mail) address listed for a person or organization.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmailType { Id=Guid.Parse("5d29fbea-2ab1-4d25-b3b5-a238a92cd14a"), Code="Other", Description="Other", Definition="Other is the type of electronic mail (e-mail) address listed for a person or organization.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefEmailType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefEmailTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefEmailType { Id=Guid.Parse("f82f3077-6d50-46f4-997c-056c03e92b68"), Description="Home/personal", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmailType { Id=Guid.Parse("42fe05b1-2442-43d1-ada1-566913803969"), Description="Work", SortOrder=Convert.ToDecimal("2.00") },
            new RefEmailType { Id=Guid.Parse("3fcbdc36-0438-4372-ac0c-f661be59c889"), Description="Organizational (school) address", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmailType { Id=Guid.Parse("5d29fbea-2ab1-4d25-b3b5-a238a92cd14a"), Description="Other", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
