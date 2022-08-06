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
        public static List<RefNumberOfDependentsType> RefNumberOfDependentsTypeList = new List<RefNumberOfDependentsType>
        {
            new RefNumberOfDependentsType { Id=Guid.Parse("e1960b9b-fd78-4538-a531-a2765bf162b3"), Code="All", Description="All", Definition="The dependents are the person's children, spouse, and person other than the children or spouse", SortOrder=Convert.ToDecimal("1.00") },
            new RefNumberOfDependentsType { Id=Guid.Parse("f6db6b79-99ae-407f-966f-c672472cb8a8"), Code="Children", Description="Children", Definition="The dependents are the person's children.", SortOrder=Convert.ToDecimal("2.00") },
            new RefNumberOfDependentsType { Id=Guid.Parse("d1d4e4e1-eaf7-4c70-be5f-73301819c726"), Code="PersonOtherThanChildrenOrSpouse", Description="Person other than children or spouse", Definition="The dependent is a person other than the person's children or spouse", SortOrder=Convert.ToDecimal("3.00") },
            new RefNumberOfDependentsType { Id=Guid.Parse("a255802f-9714-45ec-93da-654bc056fe76"), Code="Spouse", Description="Spouse", Definition="The dependent is the person's spouse.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefNumberOfDependentsType Pick List
         /// </summary>
        public static List<RefNumberOfDependentsType> RefNumberOfDependentsTypePickList = new List<RefNumberOfDependentsType>
        {
            new RefNumberOfDependentsType { Id=Guid.Parse("e1960b9b-fd78-4538-a531-a2765bf162b3"), Code="All", Description="All", SortOrder=Convert.ToDecimal("1.00") },
            new RefNumberOfDependentsType { Id=Guid.Parse("f6db6b79-99ae-407f-966f-c672472cb8a8"), Code="Children", Description="Children", SortOrder=Convert.ToDecimal("2.00") },
            new RefNumberOfDependentsType { Id=Guid.Parse("d1d4e4e1-eaf7-4c70-be5f-73301819c726"), Code="PersonOtherThanChildrenOrSpouse", Description="Person other than children or spouse", SortOrder=Convert.ToDecimal("3.00") },
            new RefNumberOfDependentsType { Id=Guid.Parse("a255802f-9714-45ec-93da-654bc056fe76"), Code="Spouse", Description="Spouse", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
