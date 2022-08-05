//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonBirthplace.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonBirthplace
     /// </summary>
    public partial interface IPersonBirthplace : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonBirthplace.City non nullable property
        /// </summary>
        System.String City { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefState"/> model
        /// </summary>
        Guid? RefStateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountry"/> model
        /// </summary>
        Guid? RefCountryId { get; set; }

    }
}
