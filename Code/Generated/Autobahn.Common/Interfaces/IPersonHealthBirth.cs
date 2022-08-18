//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonHealthBirth.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonHealthBirth Interface
     /// </summary>
    public partial interface IPersonHealthBirth : IAutobahnBase
    {
        /// <summary>
        /// Multiple Birth Indicator
        /// <para>
        /// An indication that the person is a twin, triplet, etc.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19421">Multiple Birth Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? MultipleBirthIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTrimesterWhenPrenatalCareBegan"/> model
        /// </summary>
        Guid? RefTrimesterWhenPrenatalCareBeganId { get; set; }

        /// <summary>
        /// Weeks of Gestation
        /// <para>
        /// The number of weeks during gestational period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19313">Weeks of Gestation</a>
        /// </para>
        /// </summary>
        System.Int32? WeeksOfGestation { get; set; }

        /// <summary>
        /// Weight at Birth
        /// <para>
        /// The weight of a child at birth in pounds and ounces.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19312">Weight at Birth</a>
        /// </para>
        /// </summary>
        System.String WeightAtBirth { get; set; }

    }
}
