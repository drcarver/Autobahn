//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELQualityRatingImprovementView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELQualityRatingImprovementView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELQualityRatingImprovementView : ContentPage
    {
        /// <summary>
        /// Inject the ELQualityRatingImprovementViewModel as the data context for the view
        /// </summary>
        public ELQualityRatingImprovementView(ELQualityRatingImprovementViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
