//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELQualityRatingImprovementView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELQualityRatingImprovementView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELQualityRatingImprovementView : ContentPage
    {
        /// <summary>
        /// Inject the IELQualityRatingImprovement View Model as the data context for the view
        /// </summary>
        public ELQualityRatingImprovementView(Interfaces.IELQualityRatingImprovement vm)
        {
            BindingContext  = vm;
        }
    }
}
