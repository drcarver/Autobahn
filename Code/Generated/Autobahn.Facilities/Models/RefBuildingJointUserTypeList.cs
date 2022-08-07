//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingJointUserTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingJointUserType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingJointUserTypeModel"> List
         /// </summary>
        public static List<RefBuildingJointUserTypeModel> RefBuildingJointUserTypeList = new List<RefBuildingJointUserTypeModel>
        {
            new RefBuildingJointUserType { Id=Guid.Parse("1514833d-a9da-4598-b79e-ebdd73bd68e2"), Code="13705", Description="Civic groups", Definition="Individuals, groups, or organizations, who seek occasional use of school buildings and grounds for activities or events such as polling stations, community meetings, and special events.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("247e5730-a20e-40df-90b8-ed9fca8f6aae"), Code="13704", Description="Individuals", Definition="Persons, generally residents of a community, who have access to exterior spaces, such as play equipment, athletic fields or courts, and open space for personal use.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("b3390da7-5757-42cb-b510-6556feb9f47b"), Code="13706", Description="Other public agencies", Definition="A public agency that is not part of the school district that may offer programs, need to lease space and offer no program connection to the school, and/or may seek joint development with ongoing joint programming.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("dde3d6ae-9ee7-4899-99bf-b8ba85a6c0d3"), Code="13708", Description="Private for-profit corporations", Definition="The use of school building and/or grounds by a private for-profit corporation, either for education-related work such as a private testing service or unrelated work such as private offices.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("b5fb4f72-b80c-4fb3-9fd7-736bbd53e204"), Code="13707", Description="Private non-profit organizations", Definition="The use of school buildings and/or grounds by a non-profit organization such as after-school programs, health clinics, or adult education classes.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefBuildingJointUserType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingJointUserTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingJointUserType { Id=Guid.Parse("1514833d-a9da-4598-b79e-ebdd73bd68e2"), Description="Civic groups", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("247e5730-a20e-40df-90b8-ed9fca8f6aae"), Description="Individuals", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("b3390da7-5757-42cb-b510-6556feb9f47b"), Description="Other public agencies", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("dde3d6ae-9ee7-4899-99bf-b8ba85a6c0d3"), Description="Private for-profit corporations", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("b5fb4f72-b80c-4fb3-9fd7-736bbd53e204"), Description="Private non-profit organizations", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
