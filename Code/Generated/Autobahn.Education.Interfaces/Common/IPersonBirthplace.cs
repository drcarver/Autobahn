//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonBirthplace.cs
//***************************************************************************

namespace Autobahn.Education.Interfaces.Common
{
     /// <summary>
     /// The IPersonBirthplace Interface
     /// </summary>
    public partial interface IPersonBirthplace : IAutobahnBase
    {
        #region IPersonBirthplace
        /// <summary>
        /// City of Birth
        /// <para>
        ///  The name of the city in which a person was born.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19416">City of Birth</a>
        /// </para>
        /// </summary>
        System.String City { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Country of Birth Code
        /// <para>
        /// The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19051">Country of Birth Code</a>
        /// </para>
        /// </summary>
        Guid? RefCountryId { get; set; }

        /// <summary>
        /// State of Birth Abbreviation
        /// <para>
        /// The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a person was born.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19417">State of Birth Abbreviation</a>
        /// </para>
        /// </summary>
        Guid? RefStateId { get; set; }

        #endregion
    }
}