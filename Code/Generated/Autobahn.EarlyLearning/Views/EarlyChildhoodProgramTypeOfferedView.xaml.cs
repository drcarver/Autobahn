//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodProgramTypeOfferedView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The EarlyChildhoodProgramTypeOfferedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EarlyChildhoodProgramTypeOfferedView : ContentPage
    {
        /// <summary>
        /// Inject the IEarlyChildhoodProgramTypeOffered View Model as the data context for the view
        /// </summary>
        public EarlyChildhoodProgramTypeOfferedView(Interfaces.IEarlyChildhoodProgramTypeOffered vm)
        {
            BindingContext  = vm;
        }
    }
}
