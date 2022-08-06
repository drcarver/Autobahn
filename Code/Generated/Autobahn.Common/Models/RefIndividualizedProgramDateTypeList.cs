//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIndividualizedProgramDateTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIndividualizedProgramDateType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIndividualizedProgramDateType"> List
         /// </summary>
        public static List<RefIndividualizedProgramDateType> RefIndividualizedProgramDateTypeList = new List<RefIndividualizedProgramDateType> =
        {
            new RefIndividualizedProgramDateType { Id=Guid.Parse("8dd86798-d447-44d2-93e0-c77e41c98a20"), Code="The related Individualized Program Date is a development date.", Description="Development", Definition="", SortOrder=0 },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("da108935-121f-48f0-81c3-28bbdaa203d0"), Code="The related Individualized Program Date is an implementation date.", Description="Implementation", Definition="", SortOrder=0 },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("8646706b-b5fb-4bf0-ab73-da54c218b313"), Code="The related Individualized Program Date is a tentative revision date.", Description="TentativeRevision", Definition="", SortOrder=0 },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("ece06ff2-2962-4943-a317-e249637d3873"), Code="The related Individualized Program Date is an revision date.", Description="Revision", Definition="", SortOrder=0 },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("b45309e7-4839-43d6-abf9-e46c473465f6"), Code="The related Individualized Program Date is in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIndividualizedProgramDateType Pick List
         /// </summary>
        public static List<RefIndividualizedProgramDateType> RefIndividualizedProgramDateTypePickList = new List<RefIndividualizedProgramDateType> =
        {
            new RefIndividualizedProgramDateType { Id=Guid.Parse("8dd86798-d447-44d2-93e0-c77e41c98a20"), Code="The related Individualized Program Date is a development date.", SortOrder=0 },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("da108935-121f-48f0-81c3-28bbdaa203d0"), Code="The related Individualized Program Date is an implementation date.", SortOrder=0 },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("8646706b-b5fb-4bf0-ab73-da54c218b313"), Code="The related Individualized Program Date is a tentative revision date.", SortOrder=0 },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("ece06ff2-2962-4943-a317-e249637d3873"), Code="The related Individualized Program Date is an revision date.", SortOrder=0 },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("b45309e7-4839-43d6-abf9-e46c473465f6"), Code="The related Individualized Program Date is in a category not yet defined in CEDS.", SortOrder=0 },
       };
   }
}
