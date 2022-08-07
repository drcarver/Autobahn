//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRequiredImmunizationModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRequiredImmunizationModel Interface
     /// </summary>
    public partial interface IRequiredImmunizationModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefImmunizationType"/> model
        /// </summary>
        Guid RefImmunizationTypeId { get; set; }

    }
}
