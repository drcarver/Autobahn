//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   ILearningResourceMediaFeature.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.LearningResources
{
     /// <summary>
     /// The ILearningResourceMediaFeature Interface
     /// </summary>
    public partial interface ILearningResourceMediaFeature : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// Learning Resource Media Feature Type
        /// <para>
        /// Accessible content features included with the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20368">Learning Resource Media Feature Type</a>
        /// </para>
        /// </summary>
        Guid RefLearningResourceMediaFeatureTypeId { get; set; }

    }
}
