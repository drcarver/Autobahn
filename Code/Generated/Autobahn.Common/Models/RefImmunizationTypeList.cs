//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefImmunizationTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefImmunizationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefImmunizationTypeModel"> List
         /// </summary>
        public static List<RefImmunizationTypeModel> RefImmunizationTypeList = new List<RefImmunizationTypeModel>
        {
            new RefImmunizationType { Id=Guid.Parse("1d6f4e8b-eaab-4c8c-b537-62fa92098363"), Code="Diphtheria", Description="Diphtheria", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefImmunizationType { Id=Guid.Parse("0de7d14d-d904-475f-8b80-ecaf078cb7e9"), Code="HaemophilusInfluenzae", Description="Haemophilus Influenzae", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefImmunizationType { Id=Guid.Parse("25cd8adc-93de-4e7b-bc62-32ae9047c470"), Code="HepatitisA", Description="Hepatitis A", Definition="", SortOrder=Convert.ToDecimal("3.00") },
            new RefImmunizationType { Id=Guid.Parse("0941bda1-9ce2-4df2-abc3-daf8c5cc1d8e"), Code="HepatitisB", Description="Hepatitis B", Definition="", SortOrder=Convert.ToDecimal("5.00") },
            new RefImmunizationType { Id=Guid.Parse("eb436122-39e2-4c6c-b96a-e5194ce069d0"), Code="InactivatedPoliovirus", Description="Inactivated Poliovirus", Definition="", SortOrder=Convert.ToDecimal("6.00") },
            new RefImmunizationType { Id=Guid.Parse("83bb92c6-7dbe-43a1-a4cb-d4266b8c322e"), Code="Influenza", Description="Influenza", Definition="", SortOrder=Convert.ToDecimal("7.00") },
            new RefImmunizationType { Id=Guid.Parse("85a0bcde-1694-4065-9b84-f9a743780ddb"), Code="Meningococcal", Description="Meningococcal", Definition="", SortOrder=Convert.ToDecimal("8.00") },
            new RefImmunizationType { Id=Guid.Parse("d0863676-a7c1-45fd-a0bb-e91eb9f74ec4"), Code="Mumps", Description="Mumps", Definition="", SortOrder=Convert.ToDecimal("9.00") },
            new RefImmunizationType { Id=Guid.Parse("6239471a-c2b8-4c4c-bfe9-ebc96ede7976"), Code="Pertussis", Description="Pertussis (Whooping Cough)", Definition="", SortOrder=Convert.ToDecimal("11.00") },
            new RefImmunizationType { Id=Guid.Parse("f91ec3d5-8412-4492-9c13-682778de817f"), Code="Pneumococcal", Description="Pneumococcal", Definition="", SortOrder=Convert.ToDecimal("12.00") },
            new RefImmunizationType { Id=Guid.Parse("feda63f4-cc5e-4af7-bb0f-1ec51153164e"), Code="RhImmuneGlobulin", Description="Rh. Immune Globulin", Definition="", SortOrder=Convert.ToDecimal("14.00") },
            new RefImmunizationType { Id=Guid.Parse("3b0d7e07-e212-477f-a970-0101284138cc"), Code="Rotavirus", Description="Rotavirus", Definition="", SortOrder=Convert.ToDecimal("15.00") },
            new RefImmunizationType { Id=Guid.Parse("fc01f79e-8843-4a9f-86c1-fd09eeebb2dc"), Code="Rubella", Description="Rubella (German measles)", Definition="", SortOrder=Convert.ToDecimal("16.00") },
            new RefImmunizationType { Id=Guid.Parse("ecc690cc-415b-4068-905c-2893148540d4"), Code="Rubeola", Description="Rubeola (Measles)", Definition="", SortOrder=Convert.ToDecimal("17.00") },
            new RefImmunizationType { Id=Guid.Parse("0f8e3550-c343-4341-8e69-b255484ae0b8"), Code="Smallpox", Description="Smallpox", Definition="", SortOrder=Convert.ToDecimal("19.00") },
            new RefImmunizationType { Id=Guid.Parse("f9e35015-fd45-47cc-b4ea-9edf89fe7ee9"), Code="Tetanus", Description="Tetanus", Definition="", SortOrder=Convert.ToDecimal("21.00") },
            new RefImmunizationType { Id=Guid.Parse("7e075a1f-e41d-4f5b-a369-5a99f71f7879"), Code="Tuberculosis", Description="Tuberculosis (BCG)", Definition="", SortOrder=Convert.ToDecimal("23.00") },
            new RefImmunizationType { Id=Guid.Parse("d3726f79-8df5-4fc8-b17d-fa7feadd0f26"), Code="Varicella", Description="Varicella", Definition="", SortOrder=Convert.ToDecimal("35.00") },
            new RefImmunizationType { Id=Guid.Parse("5a1c2ab4-0c6c-4867-b2a5-efe0c8916ef0"), Code="ParentOptOut", Description="Parent opt-out", Definition="", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefImmunizationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefImmunizationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefImmunizationType { Id=Guid.Parse("1d6f4e8b-eaab-4c8c-b537-62fa92098363"), Description="Diphtheria", SortOrder=Convert.ToDecimal("1.00") },
            new RefImmunizationType { Id=Guid.Parse("0de7d14d-d904-475f-8b80-ecaf078cb7e9"), Description="Haemophilus Influenzae", SortOrder=Convert.ToDecimal("2.00") },
            new RefImmunizationType { Id=Guid.Parse("25cd8adc-93de-4e7b-bc62-32ae9047c470"), Description="Hepatitis A", SortOrder=Convert.ToDecimal("3.00") },
            new RefImmunizationType { Id=Guid.Parse("0941bda1-9ce2-4df2-abc3-daf8c5cc1d8e"), Description="Hepatitis B", SortOrder=Convert.ToDecimal("5.00") },
            new RefImmunizationType { Id=Guid.Parse("eb436122-39e2-4c6c-b96a-e5194ce069d0"), Description="Inactivated Poliovirus", SortOrder=Convert.ToDecimal("6.00") },
            new RefImmunizationType { Id=Guid.Parse("83bb92c6-7dbe-43a1-a4cb-d4266b8c322e"), Description="Influenza", SortOrder=Convert.ToDecimal("7.00") },
            new RefImmunizationType { Id=Guid.Parse("85a0bcde-1694-4065-9b84-f9a743780ddb"), Description="Meningococcal", SortOrder=Convert.ToDecimal("8.00") },
            new RefImmunizationType { Id=Guid.Parse("d0863676-a7c1-45fd-a0bb-e91eb9f74ec4"), Description="Mumps", SortOrder=Convert.ToDecimal("9.00") },
            new RefImmunizationType { Id=Guid.Parse("6239471a-c2b8-4c4c-bfe9-ebc96ede7976"), Description="Pertussis (Whooping Cough)", SortOrder=Convert.ToDecimal("11.00") },
            new RefImmunizationType { Id=Guid.Parse("f91ec3d5-8412-4492-9c13-682778de817f"), Description="Pneumococcal", SortOrder=Convert.ToDecimal("12.00") },
            new RefImmunizationType { Id=Guid.Parse("feda63f4-cc5e-4af7-bb0f-1ec51153164e"), Description="Rh. Immune Globulin", SortOrder=Convert.ToDecimal("14.00") },
            new RefImmunizationType { Id=Guid.Parse("3b0d7e07-e212-477f-a970-0101284138cc"), Description="Rotavirus", SortOrder=Convert.ToDecimal("15.00") },
            new RefImmunizationType { Id=Guid.Parse("fc01f79e-8843-4a9f-86c1-fd09eeebb2dc"), Description="Rubella (German measles)", SortOrder=Convert.ToDecimal("16.00") },
            new RefImmunizationType { Id=Guid.Parse("ecc690cc-415b-4068-905c-2893148540d4"), Description="Rubeola (Measles)", SortOrder=Convert.ToDecimal("17.00") },
            new RefImmunizationType { Id=Guid.Parse("0f8e3550-c343-4341-8e69-b255484ae0b8"), Description="Smallpox", SortOrder=Convert.ToDecimal("19.00") },
            new RefImmunizationType { Id=Guid.Parse("f9e35015-fd45-47cc-b4ea-9edf89fe7ee9"), Description="Tetanus", SortOrder=Convert.ToDecimal("21.00") },
            new RefImmunizationType { Id=Guid.Parse("7e075a1f-e41d-4f5b-a369-5a99f71f7879"), Description="Tuberculosis (BCG)", SortOrder=Convert.ToDecimal("23.00") },
            new RefImmunizationType { Id=Guid.Parse("d3726f79-8df5-4fc8-b17d-fa7feadd0f26"), Description="Varicella", SortOrder=Convert.ToDecimal("35.00") },
            new RefImmunizationType { Id=Guid.Parse("5a1c2ab4-0c6c-4867-b2a5-efe0c8916ef0"), Description="Parent opt-out", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
