using Newtonsoft.Json;
using System.IO;
using System.Windows;

namespace Jadens_Manager
{
    internal class MenuManager
    {
        

        public static void ImportFiles(string[] filePaths, MainWindow mainWindow)
        {
            if (filePaths.Length == 2 && ((filePaths[0].EndsWith(".jdat") && filePaths[1].EndsWith(".jdatk")) || (filePaths[0].EndsWith(".jdatk") && filePaths[1].EndsWith(".jdat"))))
            {
                string jdatkJson = filePaths[1].EndsWith(".jdatk") ? File.ReadAllText(filePaths[1]) : File.ReadAllText(filePaths[0]);
                JDATK? jdatk = JsonConvert.DeserializeObject<JDATK>(jdatkJson);
                if (jdatk == null)
                {
                    MessageBox.Show("Jdatk file is either corrupt or using an incorrect format.");
                    return;
                }

                string jdatJson = filePaths[1].EndsWith(".jdat") ? File.ReadAllText(filePaths[1]) : File.ReadAllText(filePaths[0]);
                JDAT? jdat = JsonConvert.DeserializeObject<JDAT>(FileManager.DecryptJson(jdatJson, jdatk.key, jdatk.iv));

                if (jdat != null)
                {
                    while (mainWindow.PasswordsStackPanel.Children.Count > 1)
                    {
                        mainWindow.PasswordsStackPanel.Children.RemoveAt(1);
                    }
                    foreach (DATA data in jdat.datas)
                    {
                        LabeledProperty lp = new LabeledProperty();
                        lp.Text1 = data.user;
                        lp.Text2 = data.password;

                        mainWindow.PasswordsStackPanel.Children.Add(lp);
                    }
                }
            }
            else {
                MessageBox.Show("Please select one .jdat file and one .jdatk file.");
                return;
            }
        }
        public static void ExportFiles(string filePath, MainWindow mainWindow)
        {
            string keyPath = Path.ChangeExtension(filePath, ".jdatk");

            List<DATA> datas = new List<DATA>();

            foreach (var child in mainWindow.PasswordsStackPanel.Children)
            {
                if (child is LabeledProperty labeledProperty)
                {
                    string user = labeledProperty.Text1;
                    string password = labeledProperty.Text2;

                    datas.Add(new DATA(user, password));
                }
            }
            JDATK jdatk = FileManager.GenerateKeyAndIV();
            string jdatkJson = JsonConvert.SerializeObject(jdatk);
            File.WriteAllText(keyPath, jdatkJson);

            JDAT jdat = new JDAT(datas);
            string jdatJson = JsonConvert.SerializeObject(jdat);
            string encryptedJson = FileManager.EncryptJson(jdatJson, jdatk.key, jdatk.iv);
            File.WriteAllText(filePath, encryptedJson);
        }
    }
}
