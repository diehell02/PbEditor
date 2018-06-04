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
using System.IO;
using PbEditor.Contracts.Entity;
using System.Collections.ObjectModel;
using Microsoft.Win32;

namespace PbEditor
{
    /// <summary>
    /// AddFile.xaml 的交互逻辑
    /// </summary>
    public partial class AddFile : Window
    {
        ObservableCollection<FileEntity> FileEntityList = new ObservableCollection<FileEntity>();

        public AddFile()
        {
            InitializeComponent();

            FileListView.ItemsSource = FileEntityList;
        }

        private void ListView_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                object data = e.Data.GetData(DataFormats.FileDrop);
                if (data is Array)
                {
                    Array dropArray = data as Array;

                    foreach (string path in dropArray)
                    {
                        AddFilesToListView(path);
                    }
                }
            }
        }

        private void AddFilesToListView(string path)
        {
            if(File.Exists(path))
            {
                string fileName = path.Substring(path.LastIndexOf("\\") + 1);
                string extension = string.Empty;
                int index = fileName.LastIndexOf(".");
                if (index > -1)
                {
                    extension = fileName.Substring(index);
                }
                FileEntityList.Add(new FileEntity()
                {
                    FileName = fileName,
                    Extension = extension,
                    Path = path
                });
            }
            else if(Directory.Exists(path))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                FileInfo[] fileInfos = directoryInfo.GetFiles();

                foreach (FileInfo fileInfo in directoryInfo.GetFiles())
                {
                    AddFilesToListView(fileInfo.FullName);
                }
            }
        }

        private void FileListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(sender is ListView)
            {
                object selectedItem = (sender as ListView).SelectedItem;

                if(selectedItem is FileEntity)
                {
                    string path = (selectedItem as FileEntity).Path;

                    //this.Hide();
                    //new MainWindow(path).ShowDialog();
                    //this.Show();
                }
            }
        }

        private void AddFilesButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            var result = openFileDialog.ShowDialog();

            if (result == true)
            {
                foreach (string path in openFileDialog.FileNames)
                {
                    AddFilesToListView(path);
                }
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            FileEntityList.Clear();
        }
    }
}
