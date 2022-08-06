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
        /// The complete <see cref="RefNumberOfDependentsType"> List
         /// </summary>
        public static List<RefNumberOfDependentsType> RefNumberOfDependentsTypeList = new List<RefNumberOfDependentsType> =
        {
            new RefNumberOfDependentsType { Id=Guid.Parse("21a89bce-affc-4695-87f7-4f2a335e459f"), Code="The dependents are the person's children, spouse, and person other than the children or spouse", Description="All", Definition="", SortOrder=0 },
            new RefNumberOfDependentsType { Id=Guid.Parse("5d952d27-f366-4a86-9479-b55d981447f8"), Code="The dependents are the person's children.", Description="Children", Definition="", SortOrder=0 },
            new RefNumberOfDependentsType { Id=Guid.Parse("28410cfa-3127-47b8-a8e0-d2e3168029ab"), Code="The dependent is a person other than the person's children or spouse", Description="PersonOtherThanChildrenOrSpouse", Definition="", SortOrder=0 },
            new RefNumberOfDependentsType { Id=Guid.Parse("db456dbd-789d-4780-98dc-6973e46a3eb2"), Code="The dependent is the person's spouse.", Description="Spouse", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefNumberOfDependentsType Pick List
         /// </summary>
        public static List<RefNumberOfDependentsType> RefNumberOfDependentsTypePickList = new List<RefNumberOfDependentsType> =
        {
            new RefNumberOfDependentsType { Id=Guid.Parse("21a89bce-affc-4695-87f7-4f2a335e459f"), Code="The dependents are the person's children, spouse, and person other than the children or spouse", SortOrder=0 },
            new RefNumberOfDependentsType { Id=Guid.Parse("5d952d27-f366-4a86-9479-b55d981447f8"), Code="The dependents are the person's children.", SortOrder=0 },
            new RefNumberOfDependentsType { Id=Guid.Parse("28410cfa-3127-47b8-a8e0-d2e3168029ab"), Code="The dependent is a person other than the person's children or spouse", SortOrder=0 },
            new RefNumberOfDependentsType { Id=Guid.Parse("db456dbd-789d-4780-98dc-6973e46a3eb2"), Code="The dependent is the person's spouse.", SortOrder=0 },
       };
   }
}
