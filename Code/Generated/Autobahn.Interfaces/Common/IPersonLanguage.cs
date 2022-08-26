//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonLanguage.cs
//***************************************************************************

namespace Autobahn.Interfaces.Common
{
     /// <summary>
     /// The IPersonLanguage Interface
     /// </summary>
    public partial interface IPersonLanguage : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// ISO 639-2 Language Code
        /// <para>
        /// The code for the specific language or dialect that a person uses to communicate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19317">ISO 639-2 Language Code</a>
        /// </para>
        /// </summary>
        Guid RefLanguageId { get; set; }

        /// <summary>
        /// Language Type
        /// <para>
        /// An indication of the function and context in which a person uses a language to communicate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19316">Language Type</a>
        /// </para>
        /// </summary>
        Guid RefLanguageUseTypeId { get; set; }

    }
}
