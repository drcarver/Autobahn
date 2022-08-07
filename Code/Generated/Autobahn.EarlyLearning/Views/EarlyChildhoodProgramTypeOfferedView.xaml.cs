//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   EarlyChildhoodProgramTypeOfferedView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The EarlyChildhoodProgramTypeOfferedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EarlyChildhoodProgramTypeOfferedView : ContentPage
    {
        /// <summary>
        /// Inject the IEarlyChildhoodProgramTypeOfferedViewModel as the data context for the view
        /// </summary>
        public EarlyChildhoodProgramTypeOfferedView(IEarlyChildhoodProgramTypeOfferedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
