//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingCommunityUseSpaceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingCommunityUseSpaceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingCommunityUseSpaceTypeModel"> List
         /// </summary>
        public static List<RefBuildingCommunityUseSpaceTypeModel> RefBuildingCommunityUseSpaceTypeList = new List<RefBuildingCommunityUseSpaceTypeModel>
        {
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("966be29f-3d15-40a6-92dc-eb51b3f27dce"), Code="02764", Description="Before- and after-school care", Definition="Before- and after-school care is specified as the space designed primarily for community or shared use.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("e43721ad-c1d3-4a52-947b-b9388a923c8a"), Code="02760", Description="Before- and after-school office", Definition="Before- and after-school office is specified as the space designed primarily for community or shared use.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("48284fca-9b39-4206-9437-108583cd1ff1"), Code="02761", Description="Child care and development space", Definition="Child care and development space is specified as the space designed primarily for community or shared use.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("148b941f-4fc7-4484-b495-7df0c408c3d1"), Code="02765", Description="Community room", Definition="Community room is specified as the space designed primarily for community or shared use.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("09bb256f-655e-45af-8009-3965a5df577e"), Code="02767", Description="Family resource center", Definition="Family resource center is specified as the space designed primarily for community or shared use.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("fb00eae0-2537-4a90-95e0-74b5f4d66f18"), Code="02766", Description="Full-service health clinic", Definition="Full-service health clinic is specified as the space designed primarily for community or shared use.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("58c0b7f0-7020-4838-aabb-f4c8a3170767"), Code="02987", Description="Head Start space", Definition="Head Start space is specified as the space designed primarily for community or shared use.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("bf44de1e-4dc7-470d-b108-a16b2954d7e1"), Code="02762", Description="Health clinic", Definition="Health clinic is specified as the space designed primarily for community or shared use.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("859ac8b0-e7b9-47e8-9cde-50179751cf06"), Code="02763", Description="Parent room", Definition="Parent room is specified as the space designed primarily for community or shared use.", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("8ce05b93-62df-4bc2-ae7e-6a690896bd61"), Code="09999", Description="Other", Definition="Other is specified as the space designed primarily for community or shared use.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingCommunityUseSpaceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingCommunityUseSpaceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("966be29f-3d15-40a6-92dc-eb51b3f27dce"), Description="Before- and after-school care", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("e43721ad-c1d3-4a52-947b-b9388a923c8a"), Description="Before- and after-school office", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("48284fca-9b39-4206-9437-108583cd1ff1"), Description="Child care and development space", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("148b941f-4fc7-4484-b495-7df0c408c3d1"), Description="Community room", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("09bb256f-655e-45af-8009-3965a5df577e"), Description="Family resource center", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("fb00eae0-2537-4a90-95e0-74b5f4d66f18"), Description="Full-service health clinic", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("58c0b7f0-7020-4838-aabb-f4c8a3170767"), Description="Head Start space", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("bf44de1e-4dc7-470d-b108-a16b2954d7e1"), Description="Health clinic", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("859ac8b0-e7b9-47e8-9cde-50179751cf06"), Description="Parent room", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingCommunityUseSpaceType { Id=Guid.Parse("8ce05b93-62df-4bc2-ae7e-6a690896bd61"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
