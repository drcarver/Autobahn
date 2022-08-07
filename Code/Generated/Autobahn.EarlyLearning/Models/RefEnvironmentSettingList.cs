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
        /// The complete <see cref="RefEnvironmentSettingModel"> List
         /// </summary>
        public static List<RefEnvironmentSettingModel> RefEnvironmentSettingList = new List<RefEnvironmentSettingModel>
        {
            new RefEnvironmentSetting { Id=Guid.Parse("aefb03a6-bfa1-40b0-8667-8e5795b9b84b"), Code="HomeBased", Description="Home-based (Child's Home)", Definition="Home-based (Child's Home) is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=Convert.ToDecimal("0.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("63f8207e-56a8-4e6c-8d52-ed300fd00d44"), Code="CommunityBased", Description="Community-based (outside the child's home)", Definition="Community-based (outside the child's home) is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("ac2b76b6-18c0-4903-b220-3460024fc2cb"), Code="CenterBased", Description="Center-based (including a school setting)", Definition="Center-based (including a school setting) is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=Convert.ToDecimal("2.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("5511eb40-f563-4011-af28-e83f7fe1f613"), Code="CenterBasedSpecial", Description="Center-based for children with special needs", Definition="Center-based for children with special needs is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=Convert.ToDecimal("4.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("99bc09c6-c989-4e00-b060-67cda5e9af0d"), Code="FamilyChildCare", Description="Family Child Care Home (Provider's Home)", Definition="Family Child Care Home (Provider's Home) is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=Convert.ToDecimal("6.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("491ee72c-23ce-4607-99f6-ebfcf1ecb464"), Code="MultiSetting", Description="Multi-setting", Definition="Multi-setting is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=Convert.ToDecimal("8.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("7c87e4d3-0b36-462c-815b-05777d0b4ab7"), Code="LocallyDesigned", Description="Locally designed", Definition="Locally designed is the site or setting in which early childhood care, education, and/or services are provided.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The Reference RefEnvironmentSetting Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefEnvironmentSettingViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefEnvironmentSetting { Id=Guid.Parse("aefb03a6-bfa1-40b0-8667-8e5795b9b84b"), Description="Home-based (Child's Home)", SortOrder=Convert.ToDecimal("0.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("63f8207e-56a8-4e6c-8d52-ed300fd00d44"), Description="Community-based (outside the child's home)", SortOrder=Convert.ToDecimal("1.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("ac2b76b6-18c0-4903-b220-3460024fc2cb"), Description="Center-based (including a school setting)", SortOrder=Convert.ToDecimal("2.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("5511eb40-f563-4011-af28-e83f7fe1f613"), Description="Center-based for children with special needs", SortOrder=Convert.ToDecimal("4.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("99bc09c6-c989-4e00-b060-67cda5e9af0d"), Description="Family Child Care Home (Provider's Home)", SortOrder=Convert.ToDecimal("6.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("491ee72c-23ce-4607-99f6-ebfcf1ecb464"), Description="Multi-setting", SortOrder=Convert.ToDecimal("8.00") },
            new RefEnvironmentSetting { Id=Guid.Parse("7c87e4d3-0b36-462c-815b-05777d0b4ab7"), Description="Locally designed", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
