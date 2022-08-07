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
        /// The complete <see cref="RefBuildingArtSpecialtySpaceTypeModel"> List
         /// </summary>
        public static List<RefBuildingArtSpecialtySpaceTypeModel> RefBuildingArtSpecialtySpaceTypeList = new List<RefBuildingArtSpecialtySpaceTypeModel>
        {
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("4b55487d-a3ef-4d09-8044-65a89ef56266"), Code="02644", Description="2-dimensional art classroom", Definition="A space for drawing and painting.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("99dd537e-3639-4c14-a9a6-fcc40b7c5d16"), Code="02645", Description="3-dimensional art classroom", Definition="A space for sculpture or three-dimensional art work.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("7e9c6d02-beb3-42e0-b62e-a5735f30fe9c"), Code="02647", Description="Ceramic studio", Definition="A space with built-in equipment for creating pottery.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("571a1916-bd49-4810-92fb-be62680b7297"), Code="02646", Description="Darkroom", Definition="A space with built-in equipment for printing and processing photographic films and papers.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("cff1a588-7796-4409-b1d1-18eaf6134aa0"), Code="02649", Description="Kiln room", Definition="A space with a built-in oven or furnace for pottery making.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("1099fa37-93db-4c78-a033-b405324b697b"), Code="02648", Description="Photography studio/graphic arts", Definition="A space with built-in equipment for producing images.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("21e397f4-4777-4889-9446-0c08811bd334"), Code="09999", Description="Other", Definition="Other is specified as the space designed to support the teaching and learning of 2 dimensional or 3 dimensional visual arts.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingArtSpecialtySpaceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingArtSpecialtySpaceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("4b55487d-a3ef-4d09-8044-65a89ef56266"), Description="2-dimensional art classroom", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("99dd537e-3639-4c14-a9a6-fcc40b7c5d16"), Description="3-dimensional art classroom", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("7e9c6d02-beb3-42e0-b62e-a5735f30fe9c"), Description="Ceramic studio", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("571a1916-bd49-4810-92fb-be62680b7297"), Description="Darkroom", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("cff1a588-7796-4409-b1d1-18eaf6134aa0"), Description="Kiln room", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("1099fa37-93db-4c78-a033-b405324b697b"), Description="Photography studio/graphic arts", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingArtSpecialtySpaceType { Id=Guid.Parse("21e397f4-4777-4889-9446-0c08811bd334"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
