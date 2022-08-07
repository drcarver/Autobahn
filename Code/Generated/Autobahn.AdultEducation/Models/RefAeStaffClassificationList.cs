//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   RefAeStaffClassificationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The list of RefAeStaffClassification Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAeStaffClassificationModel"> List
         /// </summary>
        public static List<RefAeStaffClassificationModel> RefAeStaffClassificationList = new List<RefAeStaffClassificationModel>
        {
            new RefAeStaffClassification { Id=Guid.Parse("93116993-8be7-4c80-9b75-c7d2653d89c6"), Code="01", Description="State-level administrative/supervisory/ancillary services", Definition="State-level administrative/supervisory/ancillary services is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeStaffClassification { Id=Guid.Parse("c4727148-93b5-4d75-b92b-451f58e2c313"), Code="02", Description="Local-level administrative/supervisory/ancillary services", Definition="Local-level administrative/supervisory/ancillary services  is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeStaffClassification { Id=Guid.Parse("bae9b8e9-446e-4c32-99ce-0b41e4f73dfa"), Code="03", Description="Local teacher", Definition="Local teacher is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAeStaffClassification { Id=Guid.Parse("27296643-c955-4093-9ca0-a5481abc01cf"), Code="04", Description="Local counselor", Definition="Local counselor is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAeStaffClassification { Id=Guid.Parse("d3e8d4e8-175d-4f04-ba03-65374d8fe07f"), Code="05", Description="Local paraprofessional", Definition="Local paraprofessional is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAeStaffClassification { Id=Guid.Parse("e94626c4-927e-4d79-b83a-c4992e0b00cb"), Code="06", Description="State Professional Development Staff", Definition="State Professional Development Staff is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("11.00") },
            new RefAeStaffClassification { Id=Guid.Parse("aa3b8cbd-f2ef-4333-958f-d86280c415e8"), Code="07", Description="Regional Professional Development Staff", Definition="Regional Professional Development Staff is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("13.00") },
            new RefAeStaffClassification { Id=Guid.Parse("e92aae68-f58b-43ba-a909-426d8e97a5ad"), Code="08", Description="Local Professional Development Staff", Definition="Local Professional Development Staff is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("15.00") },
        };

        /// <summary>
        /// The Reference RefAeStaffClassification Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAeStaffClassificationViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAeStaffClassification { Id=Guid.Parse("93116993-8be7-4c80-9b75-c7d2653d89c6"), Description="State-level administrative/supervisory/ancillary services", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeStaffClassification { Id=Guid.Parse("c4727148-93b5-4d75-b92b-451f58e2c313"), Description="Local-level administrative/supervisory/ancillary services", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeStaffClassification { Id=Guid.Parse("bae9b8e9-446e-4c32-99ce-0b41e4f73dfa"), Description="Local teacher", SortOrder=Convert.ToDecimal("5.00") },
            new RefAeStaffClassification { Id=Guid.Parse("27296643-c955-4093-9ca0-a5481abc01cf"), Description="Local counselor", SortOrder=Convert.ToDecimal("7.00") },
            new RefAeStaffClassification { Id=Guid.Parse("d3e8d4e8-175d-4f04-ba03-65374d8fe07f"), Description="Local paraprofessional", SortOrder=Convert.ToDecimal("9.00") },
            new RefAeStaffClassification { Id=Guid.Parse("e94626c4-927e-4d79-b83a-c4992e0b00cb"), Description="State Professional Development Staff", SortOrder=Convert.ToDecimal("11.00") },
            new RefAeStaffClassification { Id=Guid.Parse("aa3b8cbd-f2ef-4333-958f-d86280c415e8"), Description="Regional Professional Development Staff", SortOrder=Convert.ToDecimal("13.00") },
            new RefAeStaffClassification { Id=Guid.Parse("e92aae68-f58b-43ba-a909-426d8e97a5ad"), Description="Local Professional Development Staff", SortOrder=Convert.ToDecimal("15.00") },
       };
   }
}
