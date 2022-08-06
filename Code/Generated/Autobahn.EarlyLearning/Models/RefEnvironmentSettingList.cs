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
        public static List<RefEnvironmentSetting> RefEnvironmentSettingList = new List<RefEnvironmentSetting>
        {
            new RefEnvironmentSetting { Id=Guid.Parse("ba92bd0d-7666-451d-bc1d-d025f4e70570"), Code="HomeBased", Description="Home-based (Child's Home)", Definition="Home-based (Child's Home) is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=Convert.ToDecimal("0.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("9e21954e-e2e8-46a2-a93b-e9bcb750a4f9"), Code="CommunityBased", Description="Community-based (outside the child's home)", Definition="Community-based (outside the child's home) is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("7f7de5e9-bb2c-4c8d-ae74-86cc6977a4e9"), Code="CenterBased", Description="Center-based (including a school setting)", Definition="Center-based (including a school setting) is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=Convert.ToDecimal("2.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("24e8807e-16f1-46e4-8212-b9233fdfa7dc"), Code="CenterBasedSpecial", Description="Center-based for children with special needs", Definition="Center-based for children with special needs is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=Convert.ToDecimal("4.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("23b680d6-1564-4278-bb41-098bcab6e150"), Code="FamilyChildCare", Description="Family Child Care Home (Provider's Home)", Definition="Family Child Care Home (Provider's Home) is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=Convert.ToDecimal("6.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("a31f6e22-e9e9-41bb-87e1-1780753bbe8a"), Code="MultiSetting", Description="Multi-setting", Definition="Multi-setting is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=Convert.ToDecimal("8.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("d902078f-840f-48c9-8dd1-f6f1649f0333"), Code="LocallyDesigned", Description="Locally designed", Definition="Locally designed is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The RefEnvironmentSetting Pick List
         /// </summary>
        public static List<RefEnvironmentSetting> RefEnvironmentSettingPickList = new List<RefEnvironmentSetting>
        {
            new RefEnvironmentSetting { Id=Guid.Parse("ba92bd0d-7666-451d-bc1d-d025f4e70570"), Code="HomeBased", Description="Home-based (Child's Home)", SortOrder=Convert.ToDecimal("0.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("9e21954e-e2e8-46a2-a93b-e9bcb750a4f9"), Code="CommunityBased", Description="Community-based (outside the child's home)", SortOrder=Convert.ToDecimal("1.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("7f7de5e9-bb2c-4c8d-ae74-86cc6977a4e9"), Code="CenterBased", Description="Center-based (including a school setting)", SortOrder=Convert.ToDecimal("2.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("24e8807e-16f1-46e4-8212-b9233fdfa7dc"), Code="CenterBasedSpecial", Description="Center-based for children with special needs", SortOrder=Convert.ToDecimal("4.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("23b680d6-1564-4278-bb41-098bcab6e150"), Code="FamilyChildCare", Description="Family Child Care Home (Provider's Home)", SortOrder=Convert.ToDecimal("6.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("a31f6e22-e9e9-41bb-87e1-1780753bbe8a"), Code="MultiSetting", Description="Multi-setting", SortOrder=Convert.ToDecimal("8.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("d902078f-840f-48c9-8dd1-f6f1649f0333"), Code="LocallyDesigned", Description="Locally designed", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
