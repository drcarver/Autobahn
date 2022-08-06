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
        /// The complete <see cref="RefBuildingJointUserType"> List
         /// </summary>
        public static List<RefBuildingJointUserType> RefBuildingJointUserTypeList = new List<RefBuildingJointUserType> =
        {
            new RefBuildingJointUserType { Id=Guid.Parse("9fcdd743-cf07-4978-bca9-6a8711c5203c"), Code="Individuals, groups, or organizations, who seek occasional use of school buildings and grounds for activities or events such as polling stations, community meetings, and special events.", Description="13705", Definition="", SortOrder=0 },
            new RefBuildingJointUserType { Id=Guid.Parse("3005ee7c-e1ff-4d9c-aa92-5699c7a78155"), Code="Persons, generally residents of a community, who have access to exterior spaces, such as play equipment, athletic fields or courts, and open space for personal use.", Description="13704", Definition="", SortOrder=0 },
            new RefBuildingJointUserType { Id=Guid.Parse("61a4ec62-44ab-49c3-b9e0-b127cf673144"), Code="A public agency that is not part of the school district that may offer programs, need to lease space and offer no program connection to the school, and/or may seek joint development with ongoing joint programming.", Description="13706", Definition="", SortOrder=0 },
            new RefBuildingJointUserType { Id=Guid.Parse("1f69a403-ef94-48c5-84cc-b5a72da5c47a"), Code="The use of school building and/or grounds by a private for-profit corporation, either for education-related work such as a private testing service or unrelated work such as private offices.", Description="13708", Definition="", SortOrder=0 },
            new RefBuildingJointUserType { Id=Guid.Parse("cc623115-14f1-47a1-bd85-d8b0addb8824"), Code="The use of school buildings and/or grounds by a non-profit organization such as after-school programs, health clinics, or adult education classes.", Description="13707", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBuildingJointUserType Pick List
         /// </summary>
        public static List<RefBuildingJointUserType> RefBuildingJointUserTypePickList = new List<RefBuildingJointUserType> =
        {
            new RefBuildingJointUserType { Id=Guid.Parse("9fcdd743-cf07-4978-bca9-6a8711c5203c"), Code="Individuals, groups, or organizations, who seek occasional use of school buildings and grounds for activities or events such as polling stations, community meetings, and special events.", SortOrder=0 },
            new RefBuildingJointUserType { Id=Guid.Parse("3005ee7c-e1ff-4d9c-aa92-5699c7a78155"), Code="Persons, generally residents of a community, who have access to exterior spaces, such as play equipment, athletic fields or courts, and open space for personal use.", SortOrder=0 },
            new RefBuildingJointUserType { Id=Guid.Parse("61a4ec62-44ab-49c3-b9e0-b127cf673144"), Code="A public agency that is not part of the school district that may offer programs, need to lease space and offer no program connection to the school, and/or may seek joint development with ongoing joint programming.", SortOrder=0 },
            new RefBuildingJointUserType { Id=Guid.Parse("1f69a403-ef94-48c5-84cc-b5a72da5c47a"), Code="The use of school building and/or grounds by a private for-profit corporation, either for education-related work such as a private testing service or unrelated work such as private offices.", SortOrder=0 },
            new RefBuildingJointUserType { Id=Guid.Parse("cc623115-14f1-47a1-bd85-d8b0addb8824"), Code="The use of school buildings and/or grounds by a non-profit organization such as after-school programs, health clinics, or adult education classes.", SortOrder=0 },
       };
   }
}
