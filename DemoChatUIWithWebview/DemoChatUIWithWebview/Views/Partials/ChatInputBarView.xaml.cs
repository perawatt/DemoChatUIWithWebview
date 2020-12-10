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

        private void chatTextInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            var myText = sender as Editor;
            if (string.IsNullOrEmpty(myText.Text))
            {
                sendButton.IsVisible = false;
                voiceButton.IsVisible = true;
            }
            else
            {
                sendButton.IsVisible = true;
                voiceButton.IsVisible = false;
            }
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            chatTextInput.Text = string.Empty;
            chatTextInput.Focus();
        }
    }
}