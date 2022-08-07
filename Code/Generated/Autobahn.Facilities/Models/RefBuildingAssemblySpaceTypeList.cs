//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingAssemblySpaceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingAssemblySpaceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingAssemblySpaceTypeModel"> List
         /// </summary>
        public static List<RefBuildingAssemblySpaceTypeModel> RefBuildingAssemblySpaceTypeList = new List<RefBuildingAssemblySpaceTypeModel>
        {
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("e1814d7d-7a62-48d3-af5a-d3b8a6561c15"), Code="02768", Description="Auditorium (fixed seats)", Definition="A space with a stage and audience seating to accommodate performing arts or other activities for a large audience.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("f31a9486-7a65-4b52-81d6-2bed017b04ad"), Code="02772", Description="Backstage room/green room", Definition="A space for actors and actresses to use before and during performances.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("af472269-84e2-48d3-916b-64c74c5d05c1"), Code="02769", Description="Control room", Definition="A space adjacent to the auditorium and equipped with a viewing area and built-in projection equipment.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("506cb8cf-5e48-4f68-841b-55a5f2ebf0bd"), Code="02770", Description="Costume storage area", Definition="A space for costume storage.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("e0aa55fe-9067-43bd-9a1a-d33e5a0e7b87"), Code="03108", Description="Disaster shelter area", Definition="A space that provides temporary shelter for individuals whose residences have been made uninhabitable by fire, flood, earthquake, or other major disaster.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("46d75b86-0dfb-42eb-a793-314b4e49b02a"), Code="02773", Description="Multi-purpose Room", Definition="A space with a stage and movable chairs designed for assemblies, but also usable for other purposes.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("c9d72ed8-51ff-4503-942c-380c5c503414"), Code="02771", Description="Set storage area", Definition="A space for set storage.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("5f73b3c2-de35-4038-8b3e-61ba7725afc6"), Code="09999", Description="Other", Definition="Other is specified as an area designed primarily for theater productions, assemblies, and other large gatherings.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingAssemblySpaceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingAssemblySpaceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("e1814d7d-7a62-48d3-af5a-d3b8a6561c15"), Description="Auditorium (fixed seats)", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("f31a9486-7a65-4b52-81d6-2bed017b04ad"), Description="Backstage room/green room", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("af472269-84e2-48d3-916b-64c74c5d05c1"), Description="Control room", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("506cb8cf-5e48-4f68-841b-55a5f2ebf0bd"), Description="Costume storage area", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("e0aa55fe-9067-43bd-9a1a-d33e5a0e7b87"), Description="Disaster shelter area", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("46d75b86-0dfb-42eb-a793-314b4e49b02a"), Description="Multi-purpose Room", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("c9d72ed8-51ff-4503-942c-380c5c503414"), Description="Set storage area", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("5f73b3c2-de35-4038-8b3e-61ba7725afc6"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
