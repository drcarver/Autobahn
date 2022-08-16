//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationAccreditationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationAccreditation Model
     /// </summary>
    public partial class OrganizationAccreditationModel : AutobahnBase, Interfaces.IOrganizationAccreditation
    {
        /// <summary>
        /// 
        /// </summary>
        public  AccreditationAgencyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AccreditationAwardDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AccreditationExpirationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAccreditationAgencyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SeekingAccreditationDate { get; set; }

    }
}
