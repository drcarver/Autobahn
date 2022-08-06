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
        /// The complete <see cref="RefBuildingAssemblySpaceType"> List
         /// </summary>
        public static List<RefBuildingAssemblySpaceType> RefBuildingAssemblySpaceTypeList = new List<RefBuildingAssemblySpaceType>
        {
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("b036ef85-a25b-49b4-ba10-bcc1ef744b10"), Code="02768", Description="Auditorium (fixed seats)", Definition="A space with a stage and audience seating to accommodate performing arts or other activities for a large audience.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("a74506a2-769f-4a9d-8545-43250fd3891b"), Code="02772", Description="Backstage room/green room", Definition="A space for actors and actresses to use before and during performances.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("9558b667-8cb6-4517-b697-9a65bdf0078c"), Code="02769", Description="Control room", Definition="A space adjacent to the auditorium and equipped with a viewing area and built-in projection equipment.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("bd338594-d2f9-4dff-b5a5-5d76e010239c"), Code="02770", Description="Costume storage area", Definition="A space for costume storage.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("fe99348c-8ade-465e-aee0-9b84baa0928d"), Code="03108", Description="Disaster shelter area", Definition="A space that provides temporary shelter for individuals whose residences have been made uninhabitable by fire, flood, earthquake, or other major disaster.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("b3c25b95-3d06-4057-8bae-687befe8bacc"), Code="02773", Description="Multi-purpose Room", Definition="A space with a stage and movable chairs designed for assemblies, but also usable for other purposes.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("8faf656d-d38c-4583-a2a9-281595b3a41a"), Code="02771", Description="Set storage area", Definition="A space for set storage.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("b9c31feb-bb89-4542-8b8f-1c73e155b3f6"), Code="09999", Description="Other", Definition="Other is specified as an area designed primarily for theater productions, assemblies, and other large gatherings.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingAssemblySpaceType Pick List
         /// </summary>
        public static List<RefBuildingAssemblySpaceType> RefBuildingAssemblySpaceTypePickList = new List<RefBuildingAssemblySpaceType>
        {
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("b036ef85-a25b-49b4-ba10-bcc1ef744b10"), Code="02768", Description="Auditorium (fixed seats)", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("a74506a2-769f-4a9d-8545-43250fd3891b"), Code="02772", Description="Backstage room/green room", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("9558b667-8cb6-4517-b697-9a65bdf0078c"), Code="02769", Description="Control room", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("bd338594-d2f9-4dff-b5a5-5d76e010239c"), Code="02770", Description="Costume storage area", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("fe99348c-8ade-465e-aee0-9b84baa0928d"), Code="03108", Description="Disaster shelter area", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("b3c25b95-3d06-4057-8bae-687befe8bacc"), Code="02773", Description="Multi-purpose Room", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("8faf656d-d38c-4583-a2a9-281595b3a41a"), Code="02771", Description="Set storage area", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingAssemblySpaceType { Id=Guid.Parse("b9c31feb-bb89-4542-8b8f-1c73e155b3f6"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
