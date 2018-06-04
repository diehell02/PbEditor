using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PbEditor.Contracts.Entity;
using System.Collections.ObjectModel;
using Microsoft.Win32;

namespace PbEditor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger("MainWindow");

        ObservableCollection<FileEntity> FileEntityList = new ObservableCollection<FileEntity>();
        ObservableCollection<PbMessage> messages = new ObservableCollection<PbMessage>();

        string messageType;

        public MainWindow()
        {
            InitializeComponent();

            FileListView.ItemsSource = FileEntityList;
        }

        public MainWindow(string messageType)
        {
            InitializeComponent();

            FileListView.ItemsSource = FileEntityList;
            this.messageType = messageType;
        }

        private bool LoadBinFile(string path)
        {
            bool result = false;

            try
            {
                messages = GateWay.GetMessages(path, this.messageType);

                if (messages == null)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }

                MessageTreeView.ItemsSource = messages;
            }
            catch(Exception ex)
            {
                logger.Error(ex);
            }

            return result;
        }

        private void MessageTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            AddItemButton.IsEnabled = false;
            DeleteItemButton.IsEnabled = false;

            if (sender is TreeView)
            {
                TreeView treeView = sender as TreeView;
                if(treeView.SelectedItem is PbMessage)
                {
                    PbMessage message = treeView.SelectedItem as PbMessage;

                    if(message.Source != null)
                    {
                        Type messageType = message.Source.GetType();                        

                        if (messageType.IsGenericType)
                        {
                            AddItemButton.IsEnabled = true;
                        }
                        else if(message.Parent != null && (message.Parent is PbMessage))
                        {
                            PbMessage parent = message.Parent as PbMessage;

                            if(parent.Source.GetType().IsGenericType)
                            {
                                DeleteItemButton.IsEnabled = true;
                            }
                        }
                    }

                    PropertyListBox.ItemsSource = message.Properties;
                }
            }
        }

        private void FindTreeView(ItemsControl container)
        {
            if (null == container)
            {
                return;
            }

            if (container.DataContext is PbMessage)
            {
                PbMessage dataContext = (container.DataContext as PbMessage);

                if(dataContext.Parent != null && dataContext.Parent is PbMessage)
                {
                    PbMessage parent = dataContext.Parent as PbMessage;

                    if(parent.Source.GetType().IsGenericType)
                    {
                        if (container is TreeViewItem)
                        {
                            (container as TreeViewItem).IsExpanded = false;
                        }
                    }
                }
            }

            int count = container.Items.Count;
            for (int i = 0; i < count; i++)
            {
                TreeViewItem subContainer = (TreeViewItem)container.ItemContainerGenerator.ContainerFromIndex(i);

                if (null == subContainer)
                {
                    continue;
                }

                FindTreeView(subContainer);
            }

            return;
        }

        private TreeViewItem FindTreeViewItem(ItemsControl container, object item)
        {
            if (null == container || null == item)
            {
                return null;
            }

            if (container.DataContext == item)
            {
                return container as TreeViewItem;
            }

            int count = container.Items.Count;
            for (int i = 0; i < count; i++)
            {
                TreeViewItem subContainer = (TreeViewItem)container.ItemContainerGenerator.ContainerFromIndex(i);

                if (null == subContainer)
                {
                    continue;
                }
                
                TreeViewItem resultContainer = FindTreeViewItem(subContainer, item);
                if (null != resultContainer)
                {
                    return resultContainer;
                }
            }

            return null;
        }

        private void FileSaveAsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                var result = saveFileDialog.ShowDialog();

                if (result == true)
                {
                    GateWay.SetMessages(saveFileDialog.FileName, messages);
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void EnumComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(sender is ComboBox)
            {
                ComboBox comboBox = sender as ComboBox;

                if(comboBox.SelectedValue != null)
                {
                    string selectedValue = comboBox.SelectedValue.ToString();

                    foreach (UIElement element in ((Panel)comboBox.Parent).Children)
                    {
                        if (element is TextBox)
                        {
                            TextBox textBox = element as TextBox;

                            if(textBox.Name == "ValueTextBox")
                            {
                                textBox.Text = selectedValue;
                            }
                        }
                    }
                }
            }
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageTreeView.SelectedItem is PbMessage)
                {
                    PbMessage message = MessageTreeView.SelectedItem as PbMessage;

                    if (message.Source != null)
                    {
                        Type messageType = message.Source.GetType();

                        Type itemType = messageType.GetGenericArguments()[0];
                        PbMessage pbMessage = GateWay.CreateMessage(itemType, message.Name.Substring(0, message.Name.Length - 4), message);

                        message.Messages.Add(pbMessage);

                        TreeViewItem tviNew = FindTreeViewItem(MessageTreeView, pbMessage);
                        if (null != tviNew)
                        {
                            tviNew.IsSelected = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageTreeView.SelectedItem is PbMessage)
                {
                    PbMessage message = MessageTreeView.SelectedItem as PbMessage;

                    if (message.Parent is PbMessage)
                    {
                        PbMessage parent = message.Parent as PbMessage;

                        parent.Messages.Remove(message);
                    }
                }                        
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
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
            if (File.Exists(path))
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
            else if (Directory.Exists(path))
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
            if (sender is ListView)
            {
                object selectedItem = (sender as ListView).SelectedItem;

                if (selectedItem is FileEntity)
                {
                    string path = (selectedItem as FileEntity).Path;

                    if(!LoadBinFile(path))
                    {
                        MessageBox.Show("该文件不是protobuf二进制文件！", "提示");
                    }
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
