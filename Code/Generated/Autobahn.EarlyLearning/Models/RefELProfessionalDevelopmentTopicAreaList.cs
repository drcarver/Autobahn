//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefELProfessionalDevelopmentTopicAreaList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefELProfessionalDevelopmentTopicArea Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefELProfessionalDevelopmentTopicAreaModel"> List
         /// </summary>
        public static List<RefELProfessionalDevelopmentTopicAreaModel> RefELProfessionalDevelopmentTopicAreaList = new List<RefELProfessionalDevelopmentTopicAreaModel>
        {
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("2777eee0-2bd4-477a-82fb-29a8d217228e"), Code="01", Description="Child Growth and Development", Definition="Child Growth and Development is the early learning staff professional development topical area.", SortOrder=Convert.ToDecimal("1.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("a94c4b97-d767-413c-a95e-0d6938f321a3"), Code="02", Description="Health Safety and Nutrition", Definition="Health Safety and Nutrition is the early learning staff professional development topical area.", SortOrder=Convert.ToDecimal("3.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("e1fe2a4f-3c1a-4600-9c8a-3836d8e515e5"), Code="03", Description="Teaching and Learning", Definition="Teaching and Learning is the early learning staff professional development topical area.", SortOrder=Convert.ToDecimal("5.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("3d0812f4-deba-4dc9-84dc-13caec75826d"), Code="04", Description="Observing", Definition="Observing is the early learning staff professional development topical area.", SortOrder=Convert.ToDecimal("7.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("716ad945-38a4-4b93-be03-29461a4d4d23"), Code="05", Description="Documenting and Assessing Family and Community Relationships", Definition="Documenting and Assessing Family and Community Relationships is the early learning staff professional development topical area.", SortOrder=Convert.ToDecimal("9.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("7a90d071-861a-4384-878c-1a3a28eb33ec"), Code="06", Description="Administration and Management", Definition="Administration and Management is the early learning staff professional development topical area.", SortOrder=Convert.ToDecimal("11.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("915379b6-b17d-42ff-8047-9fdd7491bc8c"), Code="07", Description="Early Childhood Education Profession and Policy", Definition="Early Childhood Education Profession and Policy is the early learning staff professional development topical area.", SortOrder=Convert.ToDecimal("13.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("66ca6ba9-5d27-48c6-8554-b616674736b6"), Code="08", Description="Working with Diverse Populations", Definition="Working with Diverse Populations is the early learning staff professional development topical area.", SortOrder=Convert.ToDecimal("15.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("ce9a3ecf-6b47-4994-b974-782cc3b6c712"), Code="99", Description="Other", Definition="The early learning staff professional development topical area is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefELProfessionalDevelopmentTopicArea Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefELProfessionalDevelopmentTopicAreaViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("2777eee0-2bd4-477a-82fb-29a8d217228e"), Description="Child Growth and Development", SortOrder=Convert.ToDecimal("1.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("a94c4b97-d767-413c-a95e-0d6938f321a3"), Description="Health Safety and Nutrition", SortOrder=Convert.ToDecimal("3.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("e1fe2a4f-3c1a-4600-9c8a-3836d8e515e5"), Description="Teaching and Learning", SortOrder=Convert.ToDecimal("5.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("3d0812f4-deba-4dc9-84dc-13caec75826d"), Description="Observing", SortOrder=Convert.ToDecimal("7.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("716ad945-38a4-4b93-be03-29461a4d4d23"), Description="Documenting and Assessing Family and Community Relationships", SortOrder=Convert.ToDecimal("9.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("7a90d071-861a-4384-878c-1a3a28eb33ec"), Description="Administration and Management", SortOrder=Convert.ToDecimal("11.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("915379b6-b17d-42ff-8047-9fdd7491bc8c"), Description="Early Childhood Education Profession and Policy", SortOrder=Convert.ToDecimal("13.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("66ca6ba9-5d27-48c6-8554-b616674736b6"), Description="Working with Diverse Populations", SortOrder=Convert.ToDecimal("15.00") },
            new RefELProfessionalDevelopmentTopicArea { Id=Guid.Parse("ce9a3ecf-6b47-4994-b974-782cc3b6c712"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
