//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingArtSpecialtySpaceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingArtSpecialtySpaceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingArtSpecialtySpaceType"> List
         /// </summary>
        public static List<RefBuildingArtSpecialtySpaceType> RefBuildingArtSpecialtySpaceTypeList = new List<RefBuildingArtSpecialtySpaceType>
        {
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("46e0fe4f-54de-48cc-b865-b18d2dc7c83b"), Code="02644", Description="2-dimensional art classroom", Definition="A space for drawing and painting.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("6b726b39-9a83-46e0-b651-b74cd27bc269"), Code="02645", Description="3-dimensional art classroom", Definition="A space for sculpture or three-dimensional art work.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("1851b42b-90dd-4989-849b-03b7e45d5e08"), Code="02647", Description="Ceramic studio", Definition="A space with built-in equipment for creating pottery.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("d7052a88-9471-49ca-8493-74adc6de2787"), Code="02646", Description="Darkroom", Definition="A space with built-in equipment for printing and processing photographic films and papers.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("0fdb88a9-e768-4f9e-8e60-26f7e0ecd106"), Code="02649", Description="Kiln room", Definition="A space with a built-in oven or furnace for pottery making.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("691482ea-8ebb-4d84-8721-ee7a3cbf22e4"), Code="02648", Description="Photography studio/graphic arts", Definition="A space with built-in equipment for producing images.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("c73d770d-c9bd-46c4-a612-ca26383d4aa5"), Code="09999", Description="Other", Definition="Other is specified as the space designed to support the teaching and learning of 2 dimensional or 3 dimensional visual arts.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingArtSpecialtySpaceType Pick List
         /// </summary>
        public static List<RefBuildingArtSpecialtySpaceType> RefBuildingArtSpecialtySpaceTypePickList = new List<RefBuildingArtSpecialtySpaceType>
        {
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("46e0fe4f-54de-48cc-b865-b18d2dc7c83b"), Code="02644", Description="2-dimensional art classroom", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("6b726b39-9a83-46e0-b651-b74cd27bc269"), Code="02645", Description="3-dimensional art classroom", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("1851b42b-90dd-4989-849b-03b7e45d5e08"), Code="02647", Description="Ceramic studio", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("d7052a88-9471-49ca-8493-74adc6de2787"), Code="02646", Description="Darkroom", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("0fdb88a9-e768-4f9e-8e60-26f7e0ecd106"), Code="02649", Description="Kiln room", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("691482ea-8ebb-4d84-8721-ee7a3cbf22e4"), Code="02648", Description="Photography studio/graphic arts", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("c73d770d-c9bd-46c4-a612-ca26383d4aa5"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
