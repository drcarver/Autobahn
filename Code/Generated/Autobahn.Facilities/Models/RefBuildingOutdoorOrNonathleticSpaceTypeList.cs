//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingOutdoorOrNonathleticSpaceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingOutdoorOrNonathleticSpaceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingOutdoorOrNonathleticSpaceTypeModel"> List
         /// </summary>
        public static List<RefBuildingOutdoorOrNonathleticSpaceTypeModel> RefBuildingOutdoorOrNonathleticSpaceTypeList = new List<RefBuildingOutdoorOrNonathleticSpaceTypeModel>
        {
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("040e01b5-8063-458e-a554-9b55ab63ef7c"), Code="13629", Description="Kitchen garden", Definition="A garden in which plants for the use in the kitchen are cultivated.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("2f0d4e37-918f-4526-82e8-99e8855e6452"), Code="13635", Description="Natural habitat area", Definition="An area planted with native shrubs, trees and plants for instruction in science, social studies, art and literature and for general recreation; provides a safe habitat for birds, butterflies, insects and small animals.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("e495f8b8-a23b-4d80-9934-d00bb5946965"), Code="13633", Description="Outdoor classroom", Definition="An exterior area with seating for a class, shade, work-tables and access to water for informal or formal instruction, particularly for science, art, and nutrition, often in conjunction with a school garden or natural habitat area.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("eb09b66b-943f-4f4a-99ba-1a7cd82ba8ff"), Code="13634", Description="Outdoor seating", Definition="An exterior area with seating for a class, shade, work-tables and access to water for informal or formal instruction, particularly for science, art, and nutrition, often in conjunction with a school garden or natural habitat area.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("b9ee48f6-97ba-4200-98b2-391d8e2e2aa4"), Code="02433", Description="Playground", Definition="A piece of land used for and usually equipped with facilities for recreation especially by children.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("117a8eef-9e14-43e4-9ac8-85189fc7ddd9"), Code="03409", Description="Sandbox", Definition="A box that contains sand for children to play in.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("0a3a715c-428b-4267-9236-67b96e69978a"), Code="03407", Description="Schoolyard Garden", Definition="Defined garden beds in a sunny, flat or terraced area, small enough for children to reach into; access to water; storage for tools, equipment and supplies; preferably a compost area. Proximity to outdoor classroom is optimal.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("b907f19b-649c-4cb5-b1bc-cb455eaaa07f"), Code="13636", Description="Splash play area", Definition="A playground area designed for safe water play with small moving streams, fine spray and/or mist.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefBuildingOutdoorOrNonathleticSpaceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingOutdoorOrNonathleticSpaceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("040e01b5-8063-458e-a554-9b55ab63ef7c"), Description="Kitchen garden", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("2f0d4e37-918f-4526-82e8-99e8855e6452"), Description="Natural habitat area", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("e495f8b8-a23b-4d80-9934-d00bb5946965"), Description="Outdoor classroom", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("eb09b66b-943f-4f4a-99ba-1a7cd82ba8ff"), Description="Outdoor seating", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("b9ee48f6-97ba-4200-98b2-391d8e2e2aa4"), Description="Playground", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("117a8eef-9e14-43e4-9ac8-85189fc7ddd9"), Description="Sandbox", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("0a3a715c-428b-4267-9236-67b96e69978a"), Description="Schoolyard Garden", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingOutdoorOrNonathleticSpaceType { Id=Guid.Parse("b907f19b-649c-4cb5-b1bc-cb455eaaa07f"), Description="Splash play area", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
