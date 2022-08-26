//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceMediaFeatureModel.cs
//***************************************************************************

using Autobahn.Interfaces.LearningResources;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearningResourceMediaFeature Model
     /// </summary>
    public partial class LearningResourceMediaFeatureModel : AutobahnBase, ILearningResourceMediaFeature
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// Learning Resource Media Feature Type
        /// <para>
        /// Accessible content features included with the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20368">Learning Resource Media Feature Type</a>
        /// </para>
        /// </summary>
        public Guid RefLearningResourceMediaFeatureTypeId { get; set; }

    }
}
