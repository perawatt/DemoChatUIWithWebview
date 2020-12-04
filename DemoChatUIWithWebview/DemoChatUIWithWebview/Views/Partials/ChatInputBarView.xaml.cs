using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoChatUIWithWebview.Views.Partials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatInputBarView : ContentView
    {
        public ChatInputBarView()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
            {
                this.SetBinding(HeightRequestProperty, new Binding("Height", BindingMode.OneWay, null, null, null, chatTextInput));
            }
        }

        public void UnFocusEntry()
        {
            chatTextInput?.Unfocus();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            chatTextInput.Text = string.Empty;
            chatTextInput.Focus();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            chatTextInput.Text = string.Empty;
            chatTextInput.Focus();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            chatTextInput.Text = string.Empty;
            chatTextInput.Focus();
        }
    }
}