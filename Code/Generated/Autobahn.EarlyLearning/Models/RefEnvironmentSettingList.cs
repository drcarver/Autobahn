//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefEnvironmentSettingList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefEnvironmentSetting Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEnvironmentSetting"> List
         /// </summary>
        public static List<RefEnvironmentSetting> RefEnvironmentSettingList = new List<RefEnvironmentSetting> =
        {
            new RefEnvironmentSetting { Id=Guid.Parse("465e1cdc-d8cd-4e96-b913-7e799324a2c7"), Code="Home-based (Child's Home) is the site or setting in which early childhood care, education, and/or services are provided.", Description="HomeBased", Definition="", SortOrder=0 },
            new RefEnvironmentSetting { Id=Guid.Parse("c50ec7d1-849e-469f-8dbe-d8b64e2eb9e6"), Code="Community-based (outside the child's home) is the site or setting in which early childhood care, education, and/or services are provided.", Description="CommunityBased", Definition="", SortOrder=0 },
            new RefEnvironmentSetting { Id=Guid.Parse("66d9cc67-6d27-4ad0-a0a8-62e550c33d87"), Code="Center-based (including a school setting) is the site or setting in which early childhood care, education, and/or services are provided.", Description="CenterBased", Definition="", SortOrder=0 },
            new RefEnvironmentSetting { Id=Guid.Parse("23b19ea9-fef2-4ecd-a0e0-c90f59cc99a8"), Code="Center-based for children with special needs is the site or setting in which early childhood care, education, and/or services are provided.", Description="CenterBasedSpecial", Definition="", SortOrder=0 },
            new RefEnvironmentSetting { Id=Guid.Parse("7febb812-2d66-4da7-b558-9efa76784852"), Code="Family Child Care Home (Provider's Home) is the site or setting in which early childhood care, education, and/or services are provided.", Description="FamilyChildCare", Definition="", SortOrder=0 },
            new RefEnvironmentSetting { Id=Guid.Parse("cb383a82-1ef5-4145-bf6d-67525ab32c42"), Code="Multi-setting is the site or setting in which early childhood care, education, and/or services are provided.", Description="MultiSetting", Definition="", SortOrder=0 },
            new RefEnvironmentSetting { Id=Guid.Parse("c28fedb6-f54f-424e-8732-921a2654bcfe"), Code="Locally designed is the site or setting in which early childhood care, education, and/or services are provided.", Description="LocallyDesigned", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefEnvironmentSetting Pick List
         /// </summary>
        public static List<RefEnvironmentSetting> RefEnvironmentSettingPickList = new List<RefEnvironmentSetting> =
        {
            new RefEnvironmentSetting { Id=Guid.Parse("465e1cdc-d8cd-4e96-b913-7e799324a2c7"), Code="Home-based (Child's Home) is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=0 },
            new RefEnvironmentSetting { Id=Guid.Parse("c50ec7d1-849e-469f-8dbe-d8b64e2eb9e6"), Code="Community-based (outside the child's home) is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=0 },
            new RefEnvironmentSetting { Id=Guid.Parse("66d9cc67-6d27-4ad0-a0a8-62e550c33d87"), Code="Center-based (including a school setting) is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=0 },
            new RefEnvironmentSetting { Id=Guid.Parse("23b19ea9-fef2-4ecd-a0e0-c90f59cc99a8"), Code="Center-based for children with special needs is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=0 },
            new RefEnvironmentSetting { Id=Guid.Parse("7febb812-2d66-4da7-b558-9efa76784852"), Code="Family Child Care Home (Provider's Home) is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=0 },
            new RefEnvironmentSetting { Id=Guid.Parse("cb383a82-1ef5-4145-bf6d-67525ab32c42"), Code="Multi-setting is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=0 },
            new RefEnvironmentSetting { Id=Guid.Parse("c28fedb6-f54f-424e-8732-921a2654bcfe"), Code="Locally designed is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=0 },
       };
   }
}
