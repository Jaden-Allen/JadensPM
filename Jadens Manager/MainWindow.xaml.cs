using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Input;
using Newtonsoft.Json;

namespace Jadens_Manager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CloseApplicationEvent(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void MinimizeWindowEvent(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DragToMove(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == System.Windows.Input.MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void ImportDataButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "JDAT and JDATK Files (*.jdat;*.jdatk)|*.jdat;*.jdatk",
                InitialDirectory = ConfigManager.CONFIG.lastDir,
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string[] filePaths = openFileDialog.FileNames;
                ConfigManager.UpdateConfig(filePaths[0]);
                MenuManager.ImportFiles(filePaths, this);
            }
        }

        private void SaveDataButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog() {
                Filter = "Jdat File (*.jdat) | *.jdat",
                DefaultExt = ".jdat",
                InitialDirectory = ConfigManager.CONFIG.lastDir,
                Title = "Save Jdat File"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                string filePath = saveFileDialog.FileName;
                ConfigManager.UpdateConfig(filePath);
                MenuManager.ExportFiles(filePath, this);
            }
        }

        private void AddPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            LabeledProperty labeledProperty = new LabeledProperty();
            PasswordsStackPanel.Children.Add(labeledProperty);
        }

        private void PasswordsStackPanel_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
                MenuManager.ImportFiles(filePaths, this);
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            ConfigManager.SaveConfig();
        }
    }
}