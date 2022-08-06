//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingEnergySourceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingEnergySourceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingEnergySourceType"> List
         /// </summary>
        public static List<RefBuildingEnergySourceType> RefBuildingEnergySourceTypeList = new List<RefBuildingEnergySourceType>
        {
            new RefBuildingEnergySourceType { Id=Guid.Parse("592b448d-9879-4969-a256-58255556e978"), Code="13655", Description="Biomass", Definition="Biomass is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("f7ffd76a-6899-452f-92cd-a213ce823a49"), Code="02858", Description="Coal", Definition="Coal is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("c7055e28-f4e5-46db-9df3-0826a771cfca"), Code="02854", Description="Electric", Definition="Electric is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("70dfc7ed-a7bb-427a-a84b-b3a39a720298"), Code="02853", Description="Gas", Definition="Gas is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("1135fccb-a2b2-4f2c-ae7a-6d0647873c22"), Code="02857", Description="Geothermal", Definition="Geothermal is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("6d644f0c-66f8-4066-a7fe-56f9b933ead3"), Code="02859", Description="Nuclear", Definition="Nuclear is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("5b7e7cd2-8003-47be-9868-d8a0c589f226"), Code="02842", Description="Oil", Definition="Oil is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("72b92806-a79a-434f-a14c-a0bfc32b3602"), Code="02855", Description="Solar", Definition="Solar is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("fdab4139-f50a-4167-8591-f5d9a8ddbb9b"), Code="02843", Description="Water", Definition="Water is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("a6748c6c-d1e6-4527-b929-5116e092624f"), Code="02856", Description="Wind", Definition="Wind is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("10.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("929a0f62-f6ab-4840-923b-11546095df50"), Code="09999", Description="Other", Definition="Other is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingEnergySourceType Pick List
         /// </summary>
        public static List<RefBuildingEnergySourceType> RefBuildingEnergySourceTypePickList = new List<RefBuildingEnergySourceType>
        {
            new RefBuildingEnergySourceType { Id=Guid.Parse("592b448d-9879-4969-a256-58255556e978"), Code="13655", Description="Biomass", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("f7ffd76a-6899-452f-92cd-a213ce823a49"), Code="02858", Description="Coal", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("c7055e28-f4e5-46db-9df3-0826a771cfca"), Code="02854", Description="Electric", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("70dfc7ed-a7bb-427a-a84b-b3a39a720298"), Code="02853", Description="Gas", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("1135fccb-a2b2-4f2c-ae7a-6d0647873c22"), Code="02857", Description="Geothermal", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("6d644f0c-66f8-4066-a7fe-56f9b933ead3"), Code="02859", Description="Nuclear", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("5b7e7cd2-8003-47be-9868-d8a0c589f226"), Code="02842", Description="Oil", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("72b92806-a79a-434f-a14c-a0bfc32b3602"), Code="02855", Description="Solar", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("fdab4139-f50a-4167-8591-f5d9a8ddbb9b"), Code="02843", Description="Water", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("a6748c6c-d1e6-4527-b929-5116e092624f"), Code="02856", Description="Wind", SortOrder=Convert.ToDecimal("10.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("929a0f62-f6ab-4840-923b-11546095df50"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
