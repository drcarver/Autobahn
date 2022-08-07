//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefNumberOfDependentsTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefNumberOfDependentsType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefNumberOfDependentsTypeModel"> List
         /// </summary>
        public static List<RefNumberOfDependentsTypeModel> RefNumberOfDependentsTypeList = new List<RefNumberOfDependentsTypeModel>
        {
            new RefNumberOfDependentsType { Id=Guid.Parse("c99c4b5c-2358-438e-8e66-eb6fac8c0896"), Code="All", Description="All", Definition="The dependents are the person's children, spouse, and person other than the children or spouse", SortOrder=Convert.ToDecimal("1.00") },
            new RefNumberOfDependentsType { Id=Guid.Parse("a0461586-3271-4d1f-bba2-2c3348b1d91a"), Code="Children", Description="Children", Definition="The dependents are the person's children.", SortOrder=Convert.ToDecimal("2.00") },
            new RefNumberOfDependentsType { Id=Guid.Parse("c182a01c-eb39-4354-a324-00ed5d51591a"), Code="PersonOtherThanChildrenOrSpouse", Description="Person other than children or spouse", Definition="The dependent is a person other than the person's children or spouse", SortOrder=Convert.ToDecimal("3.00") },
            new RefNumberOfDependentsType { Id=Guid.Parse("bd2ca633-bbfb-4d7f-a85d-ed03b06c6f9d"), Code="Spouse", Description="Spouse", Definition="The dependent is the person's spouse.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefNumberOfDependentsType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefNumberOfDependentsTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefNumberOfDependentsType { Id=Guid.Parse("c99c4b5c-2358-438e-8e66-eb6fac8c0896"), Description="All", SortOrder=Convert.ToDecimal("1.00") },
            new RefNumberOfDependentsType { Id=Guid.Parse("a0461586-3271-4d1f-bba2-2c3348b1d91a"), Description="Children", SortOrder=Convert.ToDecimal("2.00") },
            new RefNumberOfDependentsType { Id=Guid.Parse("c182a01c-eb39-4354-a324-00ed5d51591a"), Description="Person other than children or spouse", SortOrder=Convert.ToDecimal("3.00") },
            new RefNumberOfDependentsType { Id=Guid.Parse("bd2ca633-bbfb-4d7f-a85d-ed03b06c6f9d"), Description="Spouse", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
