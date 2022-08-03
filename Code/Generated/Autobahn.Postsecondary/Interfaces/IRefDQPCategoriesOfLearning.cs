//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefDQPCategoriesOfLearning.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IRefDQPCategoriesOfLearning
     /// </summary>
    public partial interface IRefDQPCategoriesOfLearning
    {
        /// <summary>
        /// Defines the RefDQPCategoriesOfLearning.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefDQPCategoriesOfLearning.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefDQPCategoriesOfLearning.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefDQPCategoriesOfLearning.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefDQPCategoriesOfLearning.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefDQPCategoriesOfLearning.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
