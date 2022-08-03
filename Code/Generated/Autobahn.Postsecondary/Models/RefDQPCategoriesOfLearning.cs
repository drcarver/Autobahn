//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefDQPCategoriesOfLearning.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefDQPCategoriesOfLearning
     /// </summary>
    public partial class RefDQPCategoriesOfLearning : IRefDQPCategoriesOfLearning
    {
        /// <summary>
        /// Defines the RefDQPCategoriesOfLearning.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefDQPCategoriesOfLearning.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefDQPCategoriesOfLearning.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefDQPCategoriesOfLearning.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefDQPCategoriesOfLearning.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefDQPCategoriesOfLearning.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
