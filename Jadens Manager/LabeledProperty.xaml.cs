using System.Windows;
using System.Windows.Controls;

namespace Jadens_Manager
{
    /// <summary>
    /// Interaction logic for LabeledProperty.xaml
    /// </summary>
    public partial class LabeledProperty : UserControl
    {
        public LabeledProperty()
        {
            InitializeComponent();
        }
        public string Text1
        {
            get { return UsernameProp.Text; }
            set { UsernameProp.Text = value; }
        }

        public string Text2
        {
            get { return PasswordProp.Text; }
            set { PasswordProp.Text = value; }
        }

        // Optional: Handle focus events for styling or functionality
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Optionally, you can change styles or do other actions when focused
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            // Optionally, you can change styles or do other actions when lost focus
        }
    }
}
