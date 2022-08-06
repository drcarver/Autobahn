//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefParaprofessionalQualificationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefParaprofessionalQualification Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefParaprofessionalQualification"> List
         /// </summary>
        public static List<RefParaprofessionalQualification> RefParaprofessionalQualificationList = new List<RefParaprofessionalQualification> =
        {
            new RefParaprofessionalQualification { Id=Guid.Parse("c79a8767-1ee2-487d-88da-f0d3293e2289"), Code="The paraprofessional is qualified for their assignment according to state definition.", Description="Qualified", Definition="", SortOrder=0 },
            new RefParaprofessionalQualification { Id=Guid.Parse("7cf74038-1b8b-4f1b-93a5-9eb0e482469f"), Code="The paraprofessional is NOT qualified for their assignment according to state definition.", Description="NotQualified", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefParaprofessionalQualification Pick List
         /// </summary>
        public static List<RefParaprofessionalQualification> RefParaprofessionalQualificationPickList = new List<RefParaprofessionalQualification> =
        {
            new RefParaprofessionalQualification { Id=Guid.Parse("c79a8767-1ee2-487d-88da-f0d3293e2289"), Code="The paraprofessional is qualified for their assignment according to state definition.", SortOrder=0 },
            new RefParaprofessionalQualification { Id=Guid.Parse("7cf74038-1b8b-4f1b-93a5-9eb0e482469f"), Code="The paraprofessional is NOT qualified for their assignment according to state definition.", SortOrder=0 },
       };
   }
}
