//**********************************************************
//* DomainName: Assessments
//* FileName:   ChildOfFormSectionView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The ChildOfFormSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChildOfFormSectionView : ContentPage
    {
        /// <summary>
        /// Inject the IChildOfFormSection View Model as the data context for the view
        /// </summary>
        public ChildOfFormSectionView(Interfaces.IChildOfFormSection vm)
        {
            BindingContext  = vm;
        }
    }
}
