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
        /// The complete <see cref="RefPsLepTypeModel"> List
         /// </summary>
        public static List<RefPsLepTypeModel> RefPsLepTypeList = new List<RefPsLepTypeModel>
        {
            new RefPsLepType { Id=Guid.Parse("8576a41f-070c-4eb0-b336-40662a1c8b34"), Code="Yes", Description="Currently meets standard for limited English proficiency", Definition="The person currently meets the standard for limited English proficiency.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsLepType { Id=Guid.Parse("ab9bd97c-cec3-4387-a556-b7f7d7507f59"), Code="No", Description="Currently does not meet standard for limited English proficiency", Definition="The person currently does not meet the standard for limited English proficiency.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsLepType { Id=Guid.Parse("4b276456-d071-4358-a3d0-db8195c9dc1b"), Code="Ever", Description="Ever met standard for limited English proficiency", Definition="The person currently does not meet the standard for limited English proficiency, but previously did meet the standard for limited English proficiency.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefPsLepType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPsLepTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPsLepType { Id=Guid.Parse("8576a41f-070c-4eb0-b336-40662a1c8b34"), Description="Currently meets standard for limited English proficiency", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsLepType { Id=Guid.Parse("ab9bd97c-cec3-4387-a556-b7f7d7507f59"), Description="Currently does not meet standard for limited English proficiency", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsLepType { Id=Guid.Parse("4b276456-d071-4358-a3d0-db8195c9dc1b"), Description="Ever met standard for limited English proficiency", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
