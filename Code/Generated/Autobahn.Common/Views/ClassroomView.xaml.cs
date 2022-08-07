//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ClassroomView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ClassroomView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClassroomView : ContentPage
    {
        /// <summary>
        /// Inject the IClassroomViewModel as the data context for the view
        /// </summary>
        public ClassroomView(IClassroomViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
