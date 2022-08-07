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
        /// Inject the IELQualityRatingImprovementViewModel as the data context for the view
        /// </summary>
        public ELQualityRatingImprovementView(IELQualityRatingImprovementViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
