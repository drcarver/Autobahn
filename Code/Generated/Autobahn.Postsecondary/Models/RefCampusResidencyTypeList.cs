//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCampusResidencyTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefCampusResidencyType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCampusResidencyType"> List
         /// </summary>
        public static List<RefCampusResidencyType> RefCampusResidencyTypeList = new List<RefCampusResidencyType>
        {
            new RefCampusResidencyType { Id=Guid.Parse("7d20abf9-35c0-4916-ad2f-aaaf1416ca52"), Code="OnCampus", Description="On campus", Definition="On campus is specified as a person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).", SortOrder=Convert.ToDecimal("1.00") },
            new RefCampusResidencyType { Id=Guid.Parse("9259d631-56a9-41ad-b1bc-5f92a3003320"), Code="OffCampusWFamily", Description="Off campus, with family", Definition="Off campus, with family is specified as a person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).", SortOrder=Convert.ToDecimal("2.00") },
            new RefCampusResidencyType { Id=Guid.Parse("72a03c47-5118-48e4-845e-b48bbe9a0a7f"), Code="OffCampusWOFamily", Description="Off campus, without family", Definition="Off campus, without family is specified as a person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).", SortOrder=Convert.ToDecimal("3.00") },
            new RefCampusResidencyType { Id=Guid.Parse("7f7a486d-e07a-4dbc-a934-93f95325fae7"), Code="Unknown", Description="Unknown", Definition="A person's residency arrangement is unknown as defined in the Free Application for Federal Student Aid (FAFSA).", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefCampusResidencyType Pick List
         /// </summary>
        public static List<RefCampusResidencyType> RefCampusResidencyTypePickList = new List<RefCampusResidencyType>
        {
            new RefCampusResidencyType { Id=Guid.Parse("7d20abf9-35c0-4916-ad2f-aaaf1416ca52"), Code="OnCampus", Description="On campus", SortOrder=Convert.ToDecimal("1.00") },
            new RefCampusResidencyType { Id=Guid.Parse("9259d631-56a9-41ad-b1bc-5f92a3003320"), Code="OffCampusWFamily", Description="Off campus, with family", SortOrder=Convert.ToDecimal("2.00") },
            new RefCampusResidencyType { Id=Guid.Parse("72a03c47-5118-48e4-845e-b48bbe9a0a7f"), Code="OffCampusWOFamily", Description="Off campus, without family", SortOrder=Convert.ToDecimal("3.00") },
            new RefCampusResidencyType { Id=Guid.Parse("7f7a486d-e07a-4dbc-a934-93f95325fae7"), Code="Unknown", Description="Unknown", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
