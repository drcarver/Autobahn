//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefContentStandardTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefContentStandardType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefContentStandardTypeModel"> List
         /// </summary>
        public static List<RefContentStandardTypeModel> RefContentStandardTypeList = new List<RefContentStandardTypeModel>
        {
            new RefContentStandardType { Id=Guid.Parse("79767d84-e57e-4abf-9008-a13b0ba65554"), Code="AssociationStandard", Description="Association standard", Definition="The assessment conforms to a standard defined by an association.", SortOrder=Convert.ToDecimal("1.00") },
            new RefContentStandardType { Id=Guid.Parse("2e08ce9c-7954-4986-8fc7-4b678c0cb7cf"), Code="LocalStandard", Description="Local standard", Definition="The assessment conforms to local standard.", SortOrder=Convert.ToDecimal("2.00") },
            new RefContentStandardType { Id=Guid.Parse("a3a0c025-ac25-420b-bc6f-cff9507dab49"), Code="None", Description="None", Definition="The assessment does not conform to a standard.", SortOrder=Convert.ToDecimal("3.00") },
            new RefContentStandardType { Id=Guid.Parse("8b2499d6-6954-4cea-a3a6-b91a8c7a450a"), Code="Other", Description="Other", Definition="Other is specified as to whether an assessment conforms to a standard.", SortOrder=Convert.ToDecimal("4.00") },
            new RefContentStandardType { Id=Guid.Parse("283be891-df46-4975-acf6-449c938f8258"), Code="OtherStandard", Description="Other standard", Definition="The assessment conforms to a content standard type not yet defined in CEDS.", SortOrder=Convert.ToDecimal("5.00") },
            new RefContentStandardType { Id=Guid.Parse("5cb34545-3eb1-4cea-8edd-0ab9dd94b06e"), Code="RegionalStandard", Description="Regional standard", Definition="The assessment conforms to a regional standard.", SortOrder=Convert.ToDecimal("6.00") },
            new RefContentStandardType { Id=Guid.Parse("f177229d-31fe-4127-9bac-6e49366bf57e"), Code="SchoolStandard", Description="School standard", Definition="The assessment conforms to a school standard.", SortOrder=Convert.ToDecimal("7.00") },
            new RefContentStandardType { Id=Guid.Parse("baf25f0b-b3e1-4624-8eca-14e97975bd35"), Code="StatewideStandard", Description="Statewide standard", Definition="The assessment conforms to a statewide standard.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefContentStandardType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefContentStandardTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefContentStandardType { Id=Guid.Parse("79767d84-e57e-4abf-9008-a13b0ba65554"), Description="Association standard", SortOrder=Convert.ToDecimal("1.00") },
            new RefContentStandardType { Id=Guid.Parse("2e08ce9c-7954-4986-8fc7-4b678c0cb7cf"), Description="Local standard", SortOrder=Convert.ToDecimal("2.00") },
            new RefContentStandardType { Id=Guid.Parse("a3a0c025-ac25-420b-bc6f-cff9507dab49"), Description="None", SortOrder=Convert.ToDecimal("3.00") },
            new RefContentStandardType { Id=Guid.Parse("8b2499d6-6954-4cea-a3a6-b91a8c7a450a"), Description="Other", SortOrder=Convert.ToDecimal("4.00") },
            new RefContentStandardType { Id=Guid.Parse("283be891-df46-4975-acf6-449c938f8258"), Description="Other standard", SortOrder=Convert.ToDecimal("5.00") },
            new RefContentStandardType { Id=Guid.Parse("5cb34545-3eb1-4cea-8edd-0ab9dd94b06e"), Description="Regional standard", SortOrder=Convert.ToDecimal("6.00") },
            new RefContentStandardType { Id=Guid.Parse("f177229d-31fe-4127-9bac-6e49366bf57e"), Description="School standard", SortOrder=Convert.ToDecimal("7.00") },
            new RefContentStandardType { Id=Guid.Parse("baf25f0b-b3e1-4624-8eca-14e97975bd35"), Description="Statewide standard", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
