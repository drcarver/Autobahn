//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonBirthplace.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonBirthplace Interface
     /// </summary>
    public partial interface IPersonBirthplace : IAutobahnBase
    {
        /// <summary>
        /// The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.
        /// </summary>
        System.String City { get; set; }

        /// <summary>
        /// The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.
        /// </summary>
        Guid? RefCountryId { get; set; }

        /// <summary>
        /// The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.
        /// </summary>
        Guid? RefStateId { get; set; }

    }
}
