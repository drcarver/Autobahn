//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefPsLepTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefPsLepType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPsLepType"> List
         /// </summary>
        public static List<RefPsLepType> RefPsLepTypeList = new List<RefPsLepType>
        {
            new RefPsLepType { Id=Guid.Parse("98e2e15f-95fe-4b9a-8456-0bbce97141bf"), Code="Yes", Description="Currently meets standard for limited English proficiency", Definition="The person currently meets the standard for limited English proficiency.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsLepType { Id=Guid.Parse("4fe36a12-8b8c-4d67-925a-28aba219bc12"), Code="No", Description="Currently does not meet standard for limited English proficiency", Definition="The person currently does not meet the standard for limited English proficiency.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsLepType { Id=Guid.Parse("34ab40b3-0ffa-4507-939f-26233868ceb5"), Code="Ever", Description="Ever met standard for limited English proficiency", Definition="The person currently does not meet the standard for limited English proficiency, but previously did meet the standard for limited English proficiency.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefPsLepType Pick List
         /// </summary>
        public static List<RefPsLepType> RefPsLepTypePickList = new List<RefPsLepType>
        {
            new RefPsLepType { Id=Guid.Parse("98e2e15f-95fe-4b9a-8456-0bbce97141bf"), Code="Yes", Description="Currently meets standard for limited English proficiency", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsLepType { Id=Guid.Parse("4fe36a12-8b8c-4d67-925a-28aba219bc12"), Code="No", Description="Currently does not meet standard for limited English proficiency", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsLepType { Id=Guid.Parse("34ab40b3-0ffa-4507-939f-26233868ceb5"), Code="Ever", Description="Ever met standard for limited English proficiency", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
