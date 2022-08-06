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
        public static List<RefAeStaffClassification> RefAeStaffClassificationList = new List<RefAeStaffClassification>
        {
            new RefAeStaffClassification { Id=Guid.Parse("3c12bb02-88fd-4d08-bac3-cb29af702994"), Code="01", Description="State-level administrative/supervisory/ancillary services", Definition="State-level administrative/supervisory/ancillary services is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeStaffClassification { Id=Guid.Parse("b1f5836a-e744-48f4-b6f9-9026145f6022"), Code="02", Description="Local-level administrative/supervisory/ancillary services", Definition="Local-level administrative/supervisory/ancillary services  is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeStaffClassification { Id=Guid.Parse("b3ac41a4-68fb-4ea5-8271-f7dabcf9c3a9"), Code="03", Description="Local teacher", Definition="Local teacher is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAeStaffClassification { Id=Guid.Parse("022e77e8-26a9-414d-bb05-7bb975f524c5"), Code="04", Description="Local counselor", Definition="Local counselor is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAeStaffClassification { Id=Guid.Parse("1096a62b-aa6d-4747-8fcc-0d4941eedbaa"), Code="05", Description="Local paraprofessional", Definition="Local paraprofessional is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAeStaffClassification { Id=Guid.Parse("d5450726-c4b4-4a8f-989e-9b202dea4399"), Code="06", Description="State Professional Development Staff", Definition="State Professional Development Staff is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("11.00") },
            new RefAeStaffClassification { Id=Guid.Parse("2bd67462-653d-4329-b763-5f0873f21c04"), Code="07", Description="Regional Professional Development Staff", Definition="Regional Professional Development Staff is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("13.00") },
            new RefAeStaffClassification { Id=Guid.Parse("1da634bf-59e4-484b-8062-0773cee6e8b4"), Code="08", Description="Local Professional Development Staff", Definition="Local Professional Development Staff is specified as the classification for the adult education staff member.", SortOrder=Convert.ToDecimal("15.00") },
        };

        /// <summary>
        /// The RefAeStaffClassification Pick List
         /// </summary>
        public static List<RefAeStaffClassification> RefAeStaffClassificationPickList = new List<RefAeStaffClassification>
        {
            new RefAeStaffClassification { Id=Guid.Parse("3c12bb02-88fd-4d08-bac3-cb29af702994"), Code="01", Description="State-level administrative/supervisory/ancillary services", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeStaffClassification { Id=Guid.Parse("b1f5836a-e744-48f4-b6f9-9026145f6022"), Code="02", Description="Local-level administrative/supervisory/ancillary services", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeStaffClassification { Id=Guid.Parse("b3ac41a4-68fb-4ea5-8271-f7dabcf9c3a9"), Code="03", Description="Local teacher", SortOrder=Convert.ToDecimal("5.00") },
            new RefAeStaffClassification { Id=Guid.Parse("022e77e8-26a9-414d-bb05-7bb975f524c5"), Code="04", Description="Local counselor", SortOrder=Convert.ToDecimal("7.00") },
            new RefAeStaffClassification { Id=Guid.Parse("1096a62b-aa6d-4747-8fcc-0d4941eedbaa"), Code="05", Description="Local paraprofessional", SortOrder=Convert.ToDecimal("9.00") },
            new RefAeStaffClassification { Id=Guid.Parse("d5450726-c4b4-4a8f-989e-9b202dea4399"), Code="06", Description="State Professional Development Staff", SortOrder=Convert.ToDecimal("11.00") },
            new RefAeStaffClassification { Id=Guid.Parse("2bd67462-653d-4329-b763-5f0873f21c04"), Code="07", Description="Regional Professional Development Staff", SortOrder=Convert.ToDecimal("13.00") },
            new RefAeStaffClassification { Id=Guid.Parse("1da634bf-59e4-484b-8062-0773cee6e8b4"), Code="08", Description="Local Professional Development Staff", SortOrder=Convert.ToDecimal("15.00") },
       };
   }
}
