//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonImmunization.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonImmunization
     /// </summary>
    public partial interface IPersonImmunization : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonImmunization.ImmunizationDate non nullable property
        /// </summary>
        System.DateTime ImmunizationDate { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefImmunizationType"/> model
        /// </summary>
        Guid RefImmunizationTypeId { get; set; }

    }
}
