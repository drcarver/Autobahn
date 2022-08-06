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
        /// The complete <see cref="RefAeStaffClassification"> List
         /// </summary>
        public static List<RefAeStaffClassification> RefAeStaffClassificationList = new List<RefAeStaffClassification> =
        {
            new RefAeStaffClassification { Id=Guid.Parse("0e4e3591-d64a-43b6-921a-5355a73ffda4"), Code="State-level administrative/supervisory/ancillary services is specified as the classification for the adult education staff member.", Description="01", Definition="", SortOrder=0 },
            new RefAeStaffClassification { Id=Guid.Parse("e0778423-2b0c-4306-8e3e-c53f7fd8cd96"), Code="Local-level administrative/supervisory/ancillary services  is specified as the classification for the adult education staff member.", Description="02", Definition="", SortOrder=0 },
            new RefAeStaffClassification { Id=Guid.Parse("f4b2c448-fe8c-411f-b756-5343141a0e7b"), Code="Local teacher is specified as the classification for the adult education staff member.", Description="03", Definition="", SortOrder=0 },
            new RefAeStaffClassification { Id=Guid.Parse("8f976ff7-9ac8-473a-b82f-4abe6fc5b1cd"), Code="Local counselor is specified as the classification for the adult education staff member.", Description="04", Definition="", SortOrder=0 },
            new RefAeStaffClassification { Id=Guid.Parse("e9474611-ff16-494f-8af6-f40dcedc4dfd"), Code="Local paraprofessional is specified as the classification for the adult education staff member.", Description="05", Definition="", SortOrder=0 },
            new RefAeStaffClassification { Id=Guid.Parse("b49639ec-10ad-4e82-8b89-de4cf165dd95"), Code="State Professional Development Staff is specified as the classification for the adult education staff member.", Description="06", Definition="", SortOrder=0 },
            new RefAeStaffClassification { Id=Guid.Parse("bb40fa57-eb34-4390-a750-5deb8eea119f"), Code="Regional Professional Development Staff is specified as the classification for the adult education staff member.", Description="07", Definition="", SortOrder=0 },
            new RefAeStaffClassification { Id=Guid.Parse("0bda1ea4-b528-498b-8f25-c6d2f0003b3f"), Code="Local Professional Development Staff is specified as the classification for the adult education staff member.", Description="08", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAeStaffClassification Pick List
         /// </summary>
        public static List<RefAeStaffClassification> RefAeStaffClassificationPickList = new List<RefAeStaffClassification> =
        {
            new RefAeStaffClassification { Id=Guid.Parse("0e4e3591-d64a-43b6-921a-5355a73ffda4"), Code="State-level administrative/supervisory/ancillary services is specified as the classification for the adult education staff member.", SortOrder=0 },
            new RefAeStaffClassification { Id=Guid.Parse("e0778423-2b0c-4306-8e3e-c53f7fd8cd96"), Code="Local-level administrative/supervisory/ancillary services  is specified as the classification for the adult education staff member.", SortOrder=0 },
            new RefAeStaffClassification { Id=Guid.Parse("f4b2c448-fe8c-411f-b756-5343141a0e7b"), Code="Local teacher is specified as the classification for the adult education staff member.", SortOrder=0 },
            new RefAeStaffClassification { Id=Guid.Parse("8f976ff7-9ac8-473a-b82f-4abe6fc5b1cd"), Code="Local counselor is specified as the classification for the adult education staff member.", SortOrder=0 },
            new RefAeStaffClassification { Id=Guid.Parse("e9474611-ff16-494f-8af6-f40dcedc4dfd"), Code="Local paraprofessional is specified as the classification for the adult education staff member.", SortOrder=0 },
            new RefAeStaffClassification { Id=Guid.Parse("b49639ec-10ad-4e82-8b89-de4cf165dd95"), Code="State Professional Development Staff is specified as the classification for the adult education staff member.", SortOrder=0 },
            new RefAeStaffClassification { Id=Guid.Parse("bb40fa57-eb34-4390-a750-5deb8eea119f"), Code="Regional Professional Development Staff is specified as the classification for the adult education staff member.", SortOrder=0 },
            new RefAeStaffClassification { Id=Guid.Parse("0bda1ea4-b528-498b-8f25-c6d2f0003b3f"), Code="Local Professional Development Staff is specified as the classification for the adult education staff member.", SortOrder=0 },
       };
   }
}
