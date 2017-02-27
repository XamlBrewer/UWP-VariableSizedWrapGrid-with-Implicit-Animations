using Windows.UI.Xaml.Controls;

namespace XamlBrewer.Uwp.ImplicitAnimation
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Yep: that's all.
            VariableSizedWrapGrid.RegisterImplicitAnimations();
        }
    }
}
