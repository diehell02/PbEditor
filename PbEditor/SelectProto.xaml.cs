using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;
using PbEditor.Convertor;

namespace PbEditor
{
    /// <summary>
    /// SelectProto.xaml 的交互逻辑
    /// </summary>
    public partial class SelectProto : Window
    {
        public SelectProto()
        {
            InitializeComponent();
        }

        private void BrowseImportButton_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            var result = folderBrowserDialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ImportPathTextBox.Text = folderBrowserDialog.SelectedPath;

                Generate();
            }
        }

        private void BrowseProtoButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            var result = openFileDialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ProtoFileTextBox.Text = openFileDialog.FileName;

                Generate();
            }
        }

        private void Generate()
        {
            if(!string.IsNullOrEmpty(ImportPathTextBox.Text) && !string.IsNullOrEmpty(ProtoFileTextBox.Text))
            {
                List<string> messages = ProtoFileTools.Generate(ProtoFileTextBox.Text, ImportPathTextBox.Text);

                MessagesComboBox.ItemsSource = messages;
            }
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow(MessagesComboBox.SelectedValue.ToString());
        }
    }
}
