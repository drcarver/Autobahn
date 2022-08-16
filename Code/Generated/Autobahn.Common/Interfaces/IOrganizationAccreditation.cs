//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationAccreditation.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationAccreditation Interface
     /// </summary>
    public partial interface IOrganizationAccreditation : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AccreditationAgencyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AccreditationAwardDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AccreditationExpirationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAccreditationAgencyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SeekingAccreditationDate { get; set; }

    }
}
