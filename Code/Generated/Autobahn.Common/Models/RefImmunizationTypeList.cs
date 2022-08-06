//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefImmunizationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefImmunizationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefImmunizationType"> List
         /// </summary>
        public static List<RefImmunizationType> RefImmunizationTypeList = new List<RefImmunizationType>
        {
            new RefImmunizationType { Id=Guid.Parse("adc56591-e58e-4d73-ad01-53898b0a525b"), Code="Diphtheria", Description="Diphtheria", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefImmunizationType { Id=Guid.Parse("95c11665-535a-4c17-8fc0-750b244deb1f"), Code="HaemophilusInfluenzae", Description="Haemophilus Influenzae", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefImmunizationType { Id=Guid.Parse("461f1a95-defc-47f4-8ee7-15c4171d98b8"), Code="HepatitisA", Description="Hepatitis A", Definition="", SortOrder=Convert.ToDecimal("3.00") },
            new RefImmunizationType { Id=Guid.Parse("494ac15a-eec2-498c-a601-1df7bb0bbcd5"), Code="HepatitisB", Description="Hepatitis B", Definition="", SortOrder=Convert.ToDecimal("5.00") },
            new RefImmunizationType { Id=Guid.Parse("514da6ac-477f-46cf-b713-30d26594da42"), Code="InactivatedPoliovirus", Description="Inactivated Poliovirus", Definition="", SortOrder=Convert.ToDecimal("6.00") },
            new RefImmunizationType { Id=Guid.Parse("414e3c16-52f8-4364-9151-4dae2af8a992"), Code="Influenza", Description="Influenza", Definition="", SortOrder=Convert.ToDecimal("7.00") },
            new RefImmunizationType { Id=Guid.Parse("e320a94e-35bc-4bee-a1cd-97cc4ad64e0a"), Code="Meningococcal", Description="Meningococcal", Definition="", SortOrder=Convert.ToDecimal("8.00") },
            new RefImmunizationType { Id=Guid.Parse("2a184411-bc0d-40bb-87df-06af377412a5"), Code="Mumps", Description="Mumps", Definition="", SortOrder=Convert.ToDecimal("9.00") },
            new RefImmunizationType { Id=Guid.Parse("07fd5fb6-705c-4477-a0fa-2ced9c6cdd9c"), Code="Pertussis", Description="Pertussis (Whooping Cough)", Definition="", SortOrder=Convert.ToDecimal("11.00") },
            new RefImmunizationType { Id=Guid.Parse("3a1ea58f-02fc-43e7-908a-31957fe5fa60"), Code="Pneumococcal", Description="Pneumococcal", Definition="", SortOrder=Convert.ToDecimal("12.00") },
            new RefImmunizationType { Id=Guid.Parse("172506f7-6f6e-4408-a2d1-8e44e445c30d"), Code="RhImmuneGlobulin", Description="Rh. Immune Globulin", Definition="", SortOrder=Convert.ToDecimal("14.00") },
            new RefImmunizationType { Id=Guid.Parse("0c2d4c13-17e7-442d-9b0d-70b5c65132cb"), Code="Rotavirus", Description="Rotavirus", Definition="", SortOrder=Convert.ToDecimal("15.00") },
            new RefImmunizationType { Id=Guid.Parse("ea32b0bf-c1b9-41ca-ae3c-0b86299981ad"), Code="Rubella", Description="Rubella (German measles)", Definition="", SortOrder=Convert.ToDecimal("16.00") },
            new RefImmunizationType { Id=Guid.Parse("27383265-fb99-488d-8990-320517bec3e3"), Code="Rubeola", Description="Rubeola (Measles)", Definition="", SortOrder=Convert.ToDecimal("17.00") },
            new RefImmunizationType { Id=Guid.Parse("27622ed4-992d-45c2-87bd-c0bd77592daa"), Code="Smallpox", Description="Smallpox", Definition="", SortOrder=Convert.ToDecimal("19.00") },
            new RefImmunizationType { Id=Guid.Parse("dc06a35d-4711-4867-8251-9647ecdb67db"), Code="Tetanus", Description="Tetanus", Definition="", SortOrder=Convert.ToDecimal("21.00") },
            new RefImmunizationType { Id=Guid.Parse("24def25a-2330-450c-9ece-44f2caf6d088"), Code="Tuberculosis", Description="Tuberculosis (BCG)", Definition="", SortOrder=Convert.ToDecimal("23.00") },
            new RefImmunizationType { Id=Guid.Parse("2a7b7a11-8d70-4083-9e43-9512e43c8e2c"), Code="Varicella", Description="Varicella", Definition="", SortOrder=Convert.ToDecimal("35.00") },
            new RefImmunizationType { Id=Guid.Parse("268764f1-72f1-477c-9920-44984b2c41b5"), Code="ParentOptOut", Description="Parent opt-out", Definition="", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefImmunizationType Pick List
         /// </summary>
        public static List<RefImmunizationType> RefImmunizationTypePickList = new List<RefImmunizationType>
        {
            new RefImmunizationType { Id=Guid.Parse("adc56591-e58e-4d73-ad01-53898b0a525b"), Code="Diphtheria", Description="Diphtheria", SortOrder=Convert.ToDecimal("1.00") },
            new RefImmunizationType { Id=Guid.Parse("95c11665-535a-4c17-8fc0-750b244deb1f"), Code="HaemophilusInfluenzae", Description="Haemophilus Influenzae", SortOrder=Convert.ToDecimal("2.00") },
            new RefImmunizationType { Id=Guid.Parse("461f1a95-defc-47f4-8ee7-15c4171d98b8"), Code="HepatitisA", Description="Hepatitis A", SortOrder=Convert.ToDecimal("3.00") },
            new RefImmunizationType { Id=Guid.Parse("494ac15a-eec2-498c-a601-1df7bb0bbcd5"), Code="HepatitisB", Description="Hepatitis B", SortOrder=Convert.ToDecimal("5.00") },
            new RefImmunizationType { Id=Guid.Parse("514da6ac-477f-46cf-b713-30d26594da42"), Code="InactivatedPoliovirus", Description="Inactivated Poliovirus", SortOrder=Convert.ToDecimal("6.00") },
            new RefImmunizationType { Id=Guid.Parse("414e3c16-52f8-4364-9151-4dae2af8a992"), Code="Influenza", Description="Influenza", SortOrder=Convert.ToDecimal("7.00") },
            new RefImmunizationType { Id=Guid.Parse("e320a94e-35bc-4bee-a1cd-97cc4ad64e0a"), Code="Meningococcal", Description="Meningococcal", SortOrder=Convert.ToDecimal("8.00") },
            new RefImmunizationType { Id=Guid.Parse("2a184411-bc0d-40bb-87df-06af377412a5"), Code="Mumps", Description="Mumps", SortOrder=Convert.ToDecimal("9.00") },
            new RefImmunizationType { Id=Guid.Parse("07fd5fb6-705c-4477-a0fa-2ced9c6cdd9c"), Code="Pertussis", Description="Pertussis (Whooping Cough)", SortOrder=Convert.ToDecimal("11.00") },
            new RefImmunizationType { Id=Guid.Parse("3a1ea58f-02fc-43e7-908a-31957fe5fa60"), Code="Pneumococcal", Description="Pneumococcal", SortOrder=Convert.ToDecimal("12.00") },
            new RefImmunizationType { Id=Guid.Parse("172506f7-6f6e-4408-a2d1-8e44e445c30d"), Code="RhImmuneGlobulin", Description="Rh. Immune Globulin", SortOrder=Convert.ToDecimal("14.00") },
            new RefImmunizationType { Id=Guid.Parse("0c2d4c13-17e7-442d-9b0d-70b5c65132cb"), Code="Rotavirus", Description="Rotavirus", SortOrder=Convert.ToDecimal("15.00") },
            new RefImmunizationType { Id=Guid.Parse("ea32b0bf-c1b9-41ca-ae3c-0b86299981ad"), Code="Rubella", Description="Rubella (German measles)", SortOrder=Convert.ToDecimal("16.00") },
            new RefImmunizationType { Id=Guid.Parse("27383265-fb99-488d-8990-320517bec3e3"), Code="Rubeola", Description="Rubeola (Measles)", SortOrder=Convert.ToDecimal("17.00") },
            new RefImmunizationType { Id=Guid.Parse("27622ed4-992d-45c2-87bd-c0bd77592daa"), Code="Smallpox", Description="Smallpox", SortOrder=Convert.ToDecimal("19.00") },
            new RefImmunizationType { Id=Guid.Parse("dc06a35d-4711-4867-8251-9647ecdb67db"), Code="Tetanus", Description="Tetanus", SortOrder=Convert.ToDecimal("21.00") },
            new RefImmunizationType { Id=Guid.Parse("24def25a-2330-450c-9ece-44f2caf6d088"), Code="Tuberculosis", Description="Tuberculosis (BCG)", SortOrder=Convert.ToDecimal("23.00") },
            new RefImmunizationType { Id=Guid.Parse("2a7b7a11-8d70-4083-9e43-9512e43c8e2c"), Code="Varicella", Description="Varicella", SortOrder=Convert.ToDecimal("35.00") },
            new RefImmunizationType { Id=Guid.Parse("268764f1-72f1-477c-9920-44984b2c41b5"), Code="ParentOptOut", Description="Parent opt-out", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
