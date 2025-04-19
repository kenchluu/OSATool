using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using system = System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Excel = Microsoft.Office.Interop.Excel;
using Rhino.Geometry;
using EPPL = OfficeOpenXml;
using System.Runtime.InteropServices;
using Microsoft.Vbe.Interop;


namespace OSATool
{
    public partial class Panel_G1_Library : UserControl
    {
        private string curFilePath = String.Empty;
        private DoublyLinkedListNode firstPathNode = new DoublyLinkedListNode();
        private DoublyLinkedListNode curPathNode = new DoublyLinkedListNode();
        private ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
        private bool isInitializeTvwDirectory = true;
        private bool isMove = false;
        const Int32 ALT = 32;
        const Int32 CTRL = 8;
        const Int32 SHIFT = 4;
        private string homeFolder = "";
        private string homeDisk = "";
        private string[] copyFilesSourcePaths = new string[200];

        public Panel_G1_Library()
        {
            InitializeComponent();

            string optionfile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), GlobalVar.Proglink) + @"\Library.dat";
            string TemplatePath = "";

            if (File.Exists(optionfile))
            {

                XmlReader r = new XmlReader(optionfile);
                TemplatePath = r.ReadData("templatelink");

            }

            try
            {
                if (Directory.Exists(TemplatePath))
                {
                    ShowFilesList(TemplatePath, true);
                    if (isInitializeTvwDirectory)
                    {
                        firstPathNode.Path = curFilePath;
                        curPathNode = firstPathNode;
                        isInitializeTvwDirectory = false;
                    }
                }
            }
            catch
            {

            }

            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Panel2.Hide();
        }

        class DoublyLinkedListNode
        {

            public string Path { set; get; }
            public DoublyLinkedListNode PreNode { set; get; }
            public DoublyLinkedListNode NextNode { set; get; }

        }

        private void Open(bool ejtfile)
        {

            if (lvwFiles1.SelectedItems.Count > 0)
            {
                string path = lvwFiles1.SelectedItems[0].Tag.ToString();

                try
                {

                    if (Directory.Exists(path))
                    {

                        ShowFilesList(path, true);

                    }
                    else
                    {

                        if (Path.GetExtension(path).Contains("lnk"))
                        {
                            string shortcutlink = GetShortcutTargetFilePath(path);
                            if (Directory.Exists(shortcutlink))
                            {
                                ShowFilesList(shortcutlink, true);
                            }

                        }
                        else
                        {
                            if (ejtfile)
                            {
                                if (Path.GetExtension(path).Contains("ejt"))
                                {
                                    //openExcelFile(path);
                                }
                            }
                            else
                            {
                                Process.Start(path);
                            }
                        }
                    }

                    if (isInitializeTvwDirectory)
                    {
                        firstPathNode.Path = curFilePath;
                        curPathNode = firstPathNode;
                        isInitializeTvwDirectory = false;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private string[] GetSelection()
        {
            if (lvwFiles1.SelectedItems.Count == 0)
                return null;

            string[] files = new string[lvwFiles1.SelectedItems.Count];
            Int32 i = 0;
            foreach (ListViewItem item in lvwFiles1.SelectedItems)
            {
                files[i++] = item.Tag.ToString();
            }
            return files;
        }

        private void CopyToClipboardFile(bool cut)
        {
            string[] files = GetSelection();
            if (files != null)
            {
                IDataObject data = new DataObject(DataFormats.FileDrop, files);
                MemoryStream memo = new MemoryStream(4);
                byte[] bytes = new byte[] { (byte)(cut ? 2 : 5), 0, 0, 0 };
                memo.Write(bytes, 0, bytes.Length);
                data.SetData("Preferred DropEffect", memo);
                Clipboard.SetDataObject(data);
            }
        }

        private void CopyFiles()
        {
            //SetCopyFilesSourcePaths();
            CopyToClipboardFile(false);
            isMove = false;
        }

        private void CutFiles()
        {
            //SetCopyFilesSourcePaths();
            CopyToClipboardFile(true);
            isMove = true;
        }

        private void PasteFiles()
        {

            homeFolder = curFilePath;
            homeDisk = Path.GetPathRoot(homeFolder).ToUpper();		// C:\ or D:\

            IDataObject data = Clipboard.GetDataObject();
            if (!data.GetDataPresent(DataFormats.FileDrop))
                return;

            string[] files = (string[])data.GetData(DataFormats.FileDrop);

            MemoryStream stream = (MemoryStream)data.GetData("Preferred DropEffect", true);
            Int32 flag = stream.ReadByte();
            if (flag != 2 && flag != 5)
                return;
            bool cut = (flag == 2);

            foreach (string file in files)
            {
                string dest = homeFolder + "\\" + Path.GetFileName(file);
                bool isFolder = Directory.Exists(file);
                bool isFile = File.Exists(file);
                if (!isFolder && !isFile)
                    continue;

                try
                {
                    if (cut)
                    {
                        isMove = true;
                        if (isFile)
                            //File.Move(file, dest);
                            MoveToOrCopyToFileBySourcePath(file);

                        if (isFolder)
                            MoveToOrCopyToDirectoryBySourcePath(file);
                    }
                    else
                    {
                        isMove = false;
                        if (isFile)
                            //File.Copy(file, dest, false);
                            MoveToOrCopyToFileBySourcePath(file);
                        if (isFolder)
                            MoveToOrCopyToDirectoryBySourcePath(file);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(this, "Failed to perform the specified operation:\n\n" + ex.Message, "File operation failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }


            ShowFilesList(curFilePath, false);


        }

        private void DeleteFiles()
        {
            if (lvwFiles1.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("You sure you want to delete it？", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                /////
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        foreach (ListViewItem item in lvwFiles1.SelectedItems)
                        {
                            string path = item.Tag.ToString();

                            if (File.Exists(path))
                            {
                                File.Delete(path);
                            }
                            else if (Directory.Exists(path))
                            {
                                Directory.Delete(path, true);
                            }

                            lvwFiles1.Items.Remove(item);
                        }
                        //LoadChildNodes(curSelectedNode);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public static string GetShortcutTargetFilePath(string shortcutFilename)
        {
            var type = Type.GetTypeFromProgID("WScript.Shell");
            object instance = Activator.CreateInstance(type);
            var result = type.InvokeMember("CreateShortCut", BindingFlags.InvokeMethod, null, instance, new object[] { shortcutFilename });
            var targetFilePath = result.GetType().InvokeMember("TargetPath", BindingFlags.GetProperty, null, result, null) as string;
            return targetFilePath;
        }

        private void SetCopyFilesSourcePaths()
        {
            if (lvwFiles1.SelectedItems.Count > 0)
            {
                Int32 i = 0;

                foreach (ListViewItem item in lvwFiles1.SelectedItems)
                {
                    copyFilesSourcePaths[i++] = item.Tag.ToString();
                }

                isMove = false;
            }
        }

        private void MoveToOrCopyToFileBySourcePath(string sourcePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                string destPath = Path.Combine(curFilePath, fileInfo.Name);



                if (isMove)
                {
                    if (destPath == sourcePath)
                    {
                        return;
                    }
                    fileInfo.MoveTo(destPath);
                }
                else
                {
                    if (destPath == sourcePath)
                    {
                        destPath = Path.Combine(Path.GetDirectoryName(destPath), Path.GetFileNameWithoutExtension(destPath) + "_Copy" + Path.GetExtension(destPath));
                    }
                    fileInfo.CopyTo(destPath);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CopyAndPasteDirectory(DirectoryInfo sourceDirInfo, DirectoryInfo destDirInfo)
        {
            for (DirectoryInfo dirInfo = destDirInfo.Parent; dirInfo != null; dirInfo = dirInfo.Parent)
            {
                if (dirInfo.FullName == sourceDirInfo.FullName)
                {
                    MessageBox.Show("Unable to copy！The destination folder is a subdirectory of the source folder！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!Directory.Exists(destDirInfo.FullName))
            {
                Directory.CreateDirectory(destDirInfo.FullName);
            }

            foreach (FileInfo fileInfo in sourceDirInfo.GetFiles())
            {
                fileInfo.CopyTo(Path.Combine(destDirInfo.FullName, fileInfo.Name));
            }

            foreach (DirectoryInfo sourceSubDirInfo in sourceDirInfo.GetDirectories())
            {
                DirectoryInfo destSubDirInfo = destDirInfo.CreateSubdirectory(sourceSubDirInfo.Name);
                CopyAndPasteDirectory(sourceSubDirInfo, destSubDirInfo);
            }

        }

        private void MoveToOrCopyToDirectoryBySourcePath(string sourcePath)
        {
            try
            {
                DirectoryInfo sourceDirectoryInfo = new DirectoryInfo(sourcePath);

                string destPath = Path.Combine(curFilePath, sourceDirectoryInfo.Name);

                if (isMove)
                {

                    if (destPath == sourcePath)
                    {
                        destPath = destPath + "_Copy";
                        //return;
                    }

                    CopyAndPasteDirectory(sourceDirectoryInfo, new DirectoryInfo(destPath));

                    Directory.Delete(sourcePath, true);

                }
                else
                {
                    if (destPath == sourcePath)
                    {
                        destPath = destPath + "_Copy";
                    }

                    CopyAndPasteDirectory(sourceDirectoryInfo, new DirectoryInfo(destPath));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenameFile()
        {
            if (lvwFiles1.SelectedItems.Count > 0)
            {
                lvwFiles1.SelectedItems[0].BeginEdit();
            }
        }

        private bool IsValidFileName(string fileName)
        {
            bool isValid = true;

            string errChar = "\\/:*?\"<>|";

            for (Int32 i = 0; i < errChar.Length; i++)
            {
                if (fileName.Contains(errChar[i].ToString()))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        public void ShowFilesList(string path, bool isRecord)
        {
            this.tB_FileBack.Enabled = true;

            if (isRecord)
            {
                DoublyLinkedListNode newNode = new DoublyLinkedListNode();
                newNode.Path = path;
                curPathNode.NextNode = newNode;
                newNode.PreNode = curPathNode;
                curPathNode = newNode;
            }

            //this.Com_Path.Text = path;

            ListView curlvwFiles = this.lvwFiles1;

            curlvwFiles.Tag = "Normal";

            curlvwFiles.BeginUpdate();
            curlvwFiles.Items.Clear();

            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
                FileInfo[] fileInfos = directoryInfo.GetFiles();

                foreach (ListViewItem item in curlvwFiles.Items)
                {
                    if (item.Text.EndsWith(".exe"))
                    {
                        ilstIcons.Images.RemoveByKey(item.Text);
                    }
                }


                foreach (DirectoryInfo dirInfo in directoryInfos)
                {
                    ListViewItem item = curlvwFiles.Items.Add(dirInfo.Name, IconsIndexes.Folder);
                    item.Tag = dirInfo.FullName;
                    item.SubItems.Add(dirInfo.LastWriteTime.ToString());
                    item.SubItems.Add("Folder");
                    item.SubItems.Add(String.Empty);
                }

                foreach (FileInfo fileInfo in fileInfos)
                {

                    if (fileInfo.Name.Contains("~$") == false)
                    {
                        ListViewItem item = curlvwFiles.Items.Add(fileInfo.Name);

                        if (fileInfo.Extension == ".exe" || fileInfo.Extension == String.Empty)
                        {
                            Icon fileIcon = GetSystemIcon.GetIconByFileName(fileInfo.FullName);

                            ilstIcons.Images.Add(fileInfo.Name, fileIcon);

                            item.ImageKey = fileInfo.Name;
                        }
                        else
                        {
                            if (!ilstIcons.Images.ContainsKey(fileInfo.Extension))
                            {
                                Icon fileIcon = GetSystemIcon.GetIconByFileName(fileInfo.FullName);

                                ilstIcons.Images.Add(fileInfo.Extension, fileIcon);
                            }

                            item.ImageKey = fileInfo.Extension;
                        }

                        item.Tag = fileInfo.FullName;
                        item.SubItems.Add(fileInfo.LastWriteTime.ToString());
                        item.SubItems.Add(fileInfo.Extension + "File");
                        item.SubItems.Add(ShowFileSize(fileInfo.Length).Split('(')[0]);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            curlvwFiles.EndUpdate();
            curFilePath = path;

        }

        string ShowFileSize(long fileSize)
        {
            string fileSizeStr = String.Empty;

            if (fileSize < 1024)
            {
                fileSizeStr = fileSize + " Byte";
            }
            else if (fileSize >= 1024 && fileSize < 1024 * 1024)
            {
                fileSizeStr = Math.Round(fileSize * 1.0 / 1024, 2, MidpointRounding.AwayFromZero) + " KB(" + fileSize + "Byte)";
            }
            else if (fileSize >= 1024 * 1024 && fileSize < 1024 * 1024 * 1024)
            {
                fileSizeStr = Math.Round(fileSize * 1.0 / (1024 * 1024), 2, MidpointRounding.AwayFromZero) + " MB(" + fileSize + "Byte)";
            }
            else if (fileSize >= 1024 * 1024 * 1024)
            {
                fileSizeStr = Math.Round(fileSize * 1.0 / (1024 * 1024 * 1024), 2, MidpointRounding.AwayFromZero) + " GB(" + fileSize + "Byte)";
            }
            return fileSizeStr;
        }

        private class IconsIndexes
        {
            public const Int32 FixedDrive = 0;
            public const Int32 CDRom = 1;
            public const Int32 RemovableDisk = 2;
            public const Int32 Folder = 3;
            public const Int32 RecentFiles = 4;
        }

        private void Bt_Link_Click(object sender, EventArgs e)
        {
            Form_AssignWB frm = new Form_AssignWB();
            frm.Show();//.ShowDialog();

        }

        private void Bt_ColumnTypeAssign_Click(object sender, EventArgs e)
        {
            string path = "";
            if (lvwFiles1.SelectedItems.Count > 0)
            {

                //for (Int32 i = 0; i < lvwFiles1.SelectedItems.Count; i++)
                //{
                //path = lvwFiles1.SelectedItems[i].Tag.ToString();
                path = lvwFiles1.SelectedItems[0].Tag.ToString();

                if (String.IsNullOrEmpty(path) != true)
                {

                    if (File.Exists(path))


                    {


                        Excel.Workbook objBook = null;
                        Excel.Worksheet objSheet = null;

                        try
                        {


                            //Get a reference to cSapModel to access all API classes and functions
                            objBook = Globals.OSATool.Application.ActiveWorkbook;
                            objSheet = Globals.OSATool.Application.ActiveWorkbook.ActiveSheet;
                            Excel.Range rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

                            for (Int32 i = 0; i < rng.Rows.Count; i++)
                            {
                                for (Int32 j = 0; j < rng.Columns.Count; j++)
                                {

                                    objSheet.Cells[rng.Row + i, rng.Column + j].Value = Path.GetFileNameWithoutExtension(path);
                                }
                            }

                        }
                        catch //(Exception ex)
                        {
                            MessageBox.Show("API script FAILED to complete.");

                        }
                        finally
                        {

                            //Clean up variables
                            objBook = null;
                            objSheet = null;

                        }


                    }





                }
                //}

            }
        }

        private void tB_FileBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (curPathNode != firstPathNode)
                {
                    curPathNode = curPathNode.PreNode;
                    string prePath = curPathNode.Path;

                    ShowFilesList(prePath, false);

                    tB_FileNext.Enabled = true;
                }
                else
                {
                    tB_FileBack.Enabled = false;
                }
            }
            catch
            {
            };
        }

        private void tB_FileNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (curPathNode.NextNode != null)
                {
                    curPathNode = curPathNode.NextNode;
                    string nextPath = curPathNode.Path;

                    ShowFilesList(nextPath, false);

                    tB_FileBack.Enabled = true;
                }
                else
                {
                    tB_FileNext.Enabled = false;
                }
            }
            catch { };
        }

        private void lvwFiles1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            string newName = e.Label;

            ListViewItem selectedItem = lvwFiles1.SelectedItems[0];

            try
            {
                if (string.IsNullOrEmpty(newName))
                {
                    //MessageBox.Show("File name cannot be empty！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    e.CancelEdit = true;
                }
                else if (newName == null)
                {
                    return;
                }
                else if (newName == selectedItem.Text)
                {
                    return;
                }
                else if (!IsValidFileName(newName))
                {
                    MessageBox.Show("The file name cannot contain any of the following characters:\r\n" + "\t\\/:*?\"<>|", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    e.CancelEdit = true;
                }
                else
                {

                    Computer myComputer = new Computer();

                    if (File.Exists(selectedItem.Tag.ToString()))
                    {
                        if (File.Exists(Path.Combine(curFilePath, newName)))
                        {
                            MessageBox.Show("There is a file with the same name in the current path！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            e.CancelEdit = true;
                        }
                        else
                        {
                            myComputer.FileSystem.RenameFile(selectedItem.Tag.ToString(), newName);

                            FileInfo fileInfo = new FileInfo(selectedItem.Tag.ToString());
                            string parentPath = Path.GetDirectoryName(fileInfo.FullName);
                            string newPath = Path.Combine(parentPath, newName);

                            selectedItem.Tag = newPath;

                        }
                    }
                    else if (Directory.Exists(selectedItem.Tag.ToString()))
                    {
                        if (Directory.Exists(Path.Combine(curFilePath, newName)))
                        {
                            MessageBox.Show("There is a folder with the same name in the current path！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            e.CancelEdit = true;
                        }
                        else
                        {
                            myComputer.FileSystem.RenameDirectory(selectedItem.Tag.ToString(), newName);

                            DirectoryInfo directoryInfo = new DirectoryInfo(selectedItem.Tag.ToString());
                            string parentPath = directoryInfo.Parent.FullName;
                            string newPath = Path.Combine(parentPath, newName);

                            selectedItem.Tag = newPath;

                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void lvwFiles1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lvwFiles1.Sort();
        }

        private void lvwFiles1_DragDrop(object sender, DragEventArgs e)
        {

            //string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            //foreach (string file in files)
            //{
            //    string dest = homeFolder + "\\" + Path.GetFileName(file);
            //    bool isFolder = Directory.Exists(file);
            //    bool isFile = File.Exists(file);
            //    if (!isFolder && !isFile)
            //        continue;

            //    try
            //    {
            //        switch (e.Effect)
            //        {
            //            case DragDropEffects.Move:
            //                isMove = true;
            //                if (isFile)
            //                    //File.Move(file, dest);
            //                    MoveToOrCopyToFileBySourcePath(file);

            //                if (isFolder)
            //                    MoveToOrCopyToDirectoryBySourcePath(file);


            //                break;

            //            case DragDropEffects.Copy:
            //                isMove = false;
            //                if (isFile)
            //                    //File.Copy(file, dest, false);
            //                    MoveToOrCopyToFileBySourcePath(file);
            //                if (isFolder)
            //                    MoveToOrCopyToDirectoryBySourcePath(file);

            //                break;


            //            case DragDropEffects.Link:		// TODO: Need to handle links
            //                break;
            //        }
            //    }
            //    catch (IOException ex)
            //    {
            //        MessageBox.Show(this, "Failed to perform the specified operation:\n\n" + ex.Message, "File operation failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    }
            //}

            //ShowFilesList(curFilePath, false);
        }

        private void lvwFiles1_DragOver(object sender, DragEventArgs e)
        {
            //if ((string.IsNullOrEmpty(curFilePath) == false) && Directory.Exists(curFilePath))
            //{
            //    // Determine whether file data exists in the drop data. If not, then
            //    // the drop effect reflects that the drop cannot occur.
            //    if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            //    {
            //        e.Effect = DragDropEffects.None;
            //        return;
            //    }

            //    if ((e.KeyState & SHIFT) == SHIFT &&
            //        (e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
            //    {
            //        e.Effect = DragDropEffects.Move;

            //    }
            //    else if ((e.KeyState & CTRL) == CTRL &&
            //        (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            //    {
            //        e.Effect = DragDropEffects.Copy;
            //    }

            //    else if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
            //    {
            //        // By default, the drop action should be move, if allowed.
            //        e.Effect = DragDropEffects.Move;

            //        // Implement the rather strange behaviour of explorer that if the disk
            //        // is different, then default to a COPY operation
            //        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);


            //        homeFolder = curFilePath;
            //        homeDisk = Path.GetPathRoot(homeFolder).ToUpper();		// C:\ or D:\


            //        if (files.Length > 0 && !files[0].ToUpper().StartsWith(homeDisk) &&			// Probably better ways to do this
            //        (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            //            e.Effect = DragDropEffects.Copy;


            //    }
            //    else
            //        e.Effect = DragDropEffects.None;

            //    // This is an example of how to get the item under the mouse
            //    Point pt = lvwFiles1.PointToClient(new Point(e.X, e.Y));
            //    ListViewItem itemUnder = lvwFiles1.GetItemAt(pt.X, pt.Y);

            //}
        }

        private void lvwFiles1_ItemActivate(object sender, EventArgs e)
        {
            Open(false);
        }

        private void lvwFiles1_ItemDrag(object sender, ItemDragEventArgs e)
        {

            //string[] files = GetSelection();
            //if (files != null)
            //{
            //    DoDragDrop(new DataObject(DataFormats.FileDrop, files), DragDropEffects.Copy | DragDropEffects.Move /* | DragDropEffects.Link */);

            //}
            //ShowFilesList(curFilePath, false);
        }

        private void lvwFiles1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Modifiers == Keys.Control)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.C:
                            CopyFiles();
                            break;

                        case Keys.V:
                            PasteFiles();
                            break;

                        case Keys.X:
                            CutFiles();
                            break;
                    }
                }
                else
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Delete:
                            DeleteFiles();
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Copy/paste operation failed. " + ex.Message, "Copy/Paste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Open(false);
        }

        private void copyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CopyFiles();
        }

        private void cutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CutFiles();
        }

        private void pasteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PasteFiles();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteFiles();
        }

        private void CreateNewFolder()
        {
            string optionfile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), GlobalVar.Proglink) + @"\Library.dat";
            string TemplatePath = "";

            if (File.Exists(optionfile))
            {

                XmlReader r = new XmlReader(optionfile);
                TemplatePath = r.ReadData("templatelink");

            }

            if (Directory.Exists(TemplatePath))
            {

                Int32 index = 1;

                while (Directory.Exists(Path.Combine(TemplatePath, "New Folder " + index)))
                {
                    index = index + 1;
                }

                string new_folder = Path.Combine(TemplatePath, "New Folder " + index);

                Directory.CreateDirectory(new_folder);

                ShowFilesList(curFilePath, false);

            }
        }

        private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewFolder();
        }

        private void bt_SetVar_Click(object sender, EventArgs e)
        {
            if (this.splitContainer1.Panel2Collapsed)
            {
                this.splitContainer1.Panel2Collapsed = false;
                this.splitContainer1.Panel2.Show();
            }
            else 
            {
                this.splitContainer1.Panel2Collapsed = true;
                this.splitContainer1.Panel2.Hide();
            }

        }


        private void UpdateList(string path)
        {
            if (!Directory.Exists(path))
            {
                Excel.Workbook objBook = null;

                try 
                {

                    objBook = Globals.OSATool.Application.ActiveWorkbook;
                    this.lvw_Variables.Items.Clear();

                    var package = new EPPL.ExcelPackage(new FileInfo(path));

                    for (Int32 i = 0; i < package.Workbook.Names.Count; i++)
                    {
                        try
                        {
                            if (Convert.ToString(package.Workbook.Names[i].Value).Contains("#") == false)
                            {
                                string VarName = Convert.ToString(package.Workbook.Names[i].Name);
                                ListViewItem newList = new ListViewItem(VarName, IconsIndexes.RemovableDisk);
                                newList.SubItems.Add(Convert.ToString(Convert.ToString(package.Workbook.Names[i].Value).Replace("=", "")));
                                this.lvw_Variables.Items.Add(newList);

                            }
                        }
                        catch
                        {

                        }
                    }

                    package.Dispose();

                }
                finally
                {
                    objBook = null;

                }
            }
            
        }

        private void lvwFiles1_Click(object sender, EventArgs e)
        {
            if (!this.splitContainer1.Panel2Collapsed)
            {
                if (lvwFiles1.SelectedItems.Count > 0)
                {
                    string path = lvwFiles1.SelectedItems[0].Tag.ToString();
                    UpdateList(path);
                }
            }
        }

        private void Bt_Input_Click(object sender, EventArgs e)
        {
            Excel.Range rng = null;

            if (this.lvw_Variables.SelectedItems.Count > 0)
            {
                rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

                for (Int32 i = 0; i < this.lvw_Variables.SelectedItems.Count; i++)
                {

                    if (this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Substring(0, 1) == "_")
                    {

                        rng.Cells[1, 1 + i].Value = this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Substring(1, this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Length - 1);
                        rng.Cells[1, 1 + i].Font.Color = Color.Brown;
                    }
                    else
                    {
                        rng.Cells[1, 1 + i].Value = this.lvw_Variables.SelectedItems[i].SubItems[0].Text;
                        rng.Cells[1, 1 + i].Font.Color = Color.Brown;
                    }

                }

            }
        }

        private void Bt_Output_Click(object sender, EventArgs e)
        {
            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;
            Excel.Range rng = null;
            string OChar = "*";

            if (GetWBProperty(objBook, "OChar") != null)
            {
                OChar = GetWBProperty(objBook, "OChar");
            }

            if (this.lvw_Variables.SelectedItems.Count > 0)
            {
                rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

                for (Int32 i = 0; i < this.lvw_Variables.SelectedItems.Count; i++)
                {

                    if (this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Substring(0, 1) == "_")
                    {

                        rng.Cells[1, 1 + i].Value = OChar + this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Substring(1, this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Length - 1);
                        rng.Cells[1, 1 + i].Font.Color = Color.Green;
                    }
                    else
                    {
                        rng.Cells[1, 1 + i].Value = OChar + this.lvw_Variables.SelectedItems[i].SubItems[0].Text;
                        rng.Cells[1, 1 + i].Font.Color = Color.Green;
                    }

                }

            }

        }

        static string GetProperty(Excel.Worksheet ws, string name)
        {
            foreach (Excel.CustomProperty cp in ws.CustomProperties)
                if (cp.Name == name)
                    return cp.Value;
            return null;
        }

        void SetProperty(Excel.Worksheet ws, string name, string value)
        {
            bool found = false;
            Excel.CustomProperties cps = ws.CustomProperties;
            foreach (Excel.CustomProperty cp in cps)
            {
                if (cp.Name == name)
                {
                    found = true;
                    cp.Value = value;
                }
            }
            if (!found)
                cps.Add(name, value);
        }

        void DelProperty(Excel.Worksheet ws, string name)
        {
            bool found = false;
            Excel.CustomProperties cps = ws.CustomProperties;
            foreach (Excel.CustomProperty cp in cps)
            {
                if (cp.Name == name)
                {
                    found = true;
                    cp.Delete();
                }
            }
            if (!found) { }
        }

        static string GetWBProperty(Excel.Workbook wb, string name)
        {
            foreach (Microsoft.Office.Core.DocumentProperty cp in wb.CustomDocumentProperties)
                if (cp.Name == name)
                    return cp.Value;
            return null;
        }

        void SetWBProperty(Excel.Workbook wb, string name, string value)
        {
            bool found = false;
            Microsoft.Office.Core.DocumentProperties cps = wb.CustomDocumentProperties;
            foreach (Microsoft.Office.Core.DocumentProperty cp in cps)
            {
                if (cp.Name == name)
                {
                    found = true;
                    cp.Value = value;
                }
            }
            if (!found)
                cps.Add(name, false, Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString, value);
        }

        void DelWBProperty(Excel.Workbook wb, string name)
        {
            bool found = false;
            Microsoft.Office.Core.DocumentProperties cps = wb.CustomDocumentProperties;
            foreach (Microsoft.Office.Core.DocumentProperty cp in cps)
            {
                if (cp.Name == name)
                {
                    found = true;
                    cp.Delete();
                }
            }
            if (!found) { }
        }

        private void Bt_Input2_Click(object sender, EventArgs e)
        {
            Excel.Range rng = null;

            if (this.lvw_Variables.SelectedItems.Count > 0)
            {
                rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

                for (Int32 i = 0; i < this.lvw_Variables.SelectedItems.Count; i++)
                {

                    if (this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Substring(0, 1) == "_")
                    {

                        rng.Cells[1, 1 + i].Value = this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Substring(1, this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Length - 1);
                        rng.Cells[1, 1 + i].Font.Color = Color.Blue;
                    }
                    else
                    {
                        rng.Cells[1, 1 + i].Value = this.lvw_Variables.SelectedItems[i].SubItems[0].Text;
                        rng.Cells[1, 1 + i].Font.Color = Color.Blue;
                    }

                }

            }
        }

        private void Bt_Output2_Click(object sender, EventArgs e)
        {
            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;
            Excel.Range rng = null;
            string OChar = "*";

            if (GetWBProperty(objBook, "OChar") != null)
            {
                OChar = GetWBProperty(objBook, "OChar");
            }

            if (this.lvw_Variables.SelectedItems.Count > 0)
            {
                rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

                for (Int32 i = 0; i < this.lvw_Variables.SelectedItems.Count; i++)
                {

                    if (this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Substring(0, 1) == "_")
                    {

                        rng.Cells[1, 1 + i].Value = OChar + this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Substring(1, this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Length - 1);
                        rng.Cells[1, 1 + i].Font.Color = Color.Blue;
                    }
                    else
                    {
                        rng.Cells[1, 1 + i].Value = OChar + this.lvw_Variables.SelectedItems[i].SubItems[0].Text;
                        rng.Cells[1, 1 + i].Font.Color = Color.Blue;
                    }

                }

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Excel.Range rng = null;

            if (this.lvw_Variables.SelectedItems.Count > 0)
            {
                rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

                for (Int32 i = 0; i < this.lvw_Variables.SelectedItems.Count; i++)
                {

                    if (this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Substring(0, 1) == "_")
                    {

                        rng.Cells[1, 1 + i].Value = this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Substring(1, this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Length - 1);
                        rng.Cells[1, 1 + i].Font.Color = Color.Blue;
                    }
                    else
                    {
                        rng.Cells[1, 1 + i].Value = this.lvw_Variables.SelectedItems[i].SubItems[0].Text;
                        rng.Cells[1, 1 + i].Font.Color = Color.Blue;
                    }

                }

            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;
            Excel.Range rng = null;
            string OChar = "*";

            if (GetWBProperty(objBook, "OChar") != null)
            {
                OChar = GetWBProperty(objBook, "OChar");
            }

            if (this.lvw_Variables.SelectedItems.Count > 0)
            {
                rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

                for (Int32 i = 0; i < this.lvw_Variables.SelectedItems.Count; i++)
                {

                    if (this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Substring(0, 1) == "_")
                    {

                        rng.Cells[1, 1 + i].Value = OChar + this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Substring(1, this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Length - 1);
                        rng.Cells[1, 1 + i].Font.Color = Color.Blue;
                    }
                    else
                    {
                        rng.Cells[1, 1 + i].Value = OChar + this.lvw_Variables.SelectedItems[i].SubItems[0].Text;
                        rng.Cells[1, 1 + i].Font.Color = Color.Blue;
                    }

                }

            }
        }

        private void openPathToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string optionfile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), GlobalVar.Proglink) + @"\Library.dat";
            string TemplatePath = "";

            if (File.Exists(optionfile))
            {

                XmlReader r = new XmlReader(optionfile);
                TemplatePath = r.ReadData("templatelink");

            }

            try
            {
                if (Directory.Exists(TemplatePath))
                {

                    Process.Start("explorer.exe", TemplatePath);

                }
            }
            catch
            {

            }

        }

        private void assignTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sourceFilePath = null;
            string destinationFilePath = null;

            if (lvwFiles1.SelectedItems.Count > 0)
            {

                for (Int32 i = 0; i < lvwFiles1.SelectedItems.Count; i++)
                {
                    sourceFilePath = lvwFiles1.SelectedItems[i].Tag.ToString();

                    if (File.Exists(sourceFilePath)) 
                    {
                        //MessageBox.Show(path);

                        system.OpenFileDialog fd = new system.OpenFileDialog();
                        fd.Title = "Open file";
                        fd.InitialDirectory = String.Empty;

                        fd.Filter = "Excel File (*.xlsm)|*.xlsm";
                        fd.FilterIndex = 2;
                        fd.RestoreDirectory = true;
                        if (fd.ShowDialog() == system.DialogResult.OK)
                        {
                            //MessageBox.Show(fd.FileName);

                            destinationFilePath = fd.FileName;

                            Excel.Workbook objBook1 = null;
                            Excel.Workbook objBook2 = null;
                            Excel.Worksheet resultSheet1 = null;
                            Excel.Worksheet resultSheet2 = null;

                            //string DesignSummaryTab = "DesignSummary";
                            //string DesignForcesTab = "DesignForces";

                            if (File.Exists(destinationFilePath))
                            {

                                Globals.OSATool.Application.DisplayAlerts = false;
                                Globals.OSATool.Application.ScreenUpdating = false;
                                Globals.OSATool.Application.Calculation = Excel.XlCalculation.xlCalculationManual;

                                try
                                {
                                    objBook1 = Globals.OSATool.Application.Workbooks.Open(sourceFilePath, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                                    objBook2 = Globals.OSATool.Application.Workbooks.Open(destinationFilePath, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                                    string SelectPath = GetWBProperty(objBook1, "SelectPath");
                                    string IgnoreEmptyCell = GetWBProperty(objBook1, "IgnoreEmptyCell");
                                    string OChar = GetWBProperty(objBook1, "OChar");
                                    string BeginEndMacro = GetWBProperty(objBook1, "BeginEndMacro");
                                    string BeginEndMacroPrInt32 = GetWBProperty(objBook1, "BeginEndMacroPrint");
                                    string CombinePDF = GetWBProperty(objBook1, "CombinePDF");
                                    string UsingMacroBegin = GetWBProperty(objBook1, "UsingMacroBegin");

                                    if (SelectPath != null)
                                    {
                                        SetWBProperty(objBook2, "SelectPath", "TRUE");
                                    }

                                    if (IgnoreEmptyCell != null)
                                    {
                                        SetWBProperty(objBook2, "IgnoreEmptyCell", "TRUE");
                                    }

                                    if (OChar != null)
                                    {
                                        SetWBProperty(objBook2, "OChar", OChar);
                                    }

                                    if (BeginEndMacro != null)
                                    {
                                        SetWBProperty(objBook2, "BeginEndMacro", "TRUE");
                                    }

                                    if (BeginEndMacroPrInt32 != null)
                                    {
                                        SetWBProperty(objBook2, "BeginEndMacroPrint", "TRUE");
                                    }

                                    if (CombinePDF != null)
                                    {
                                        SetWBProperty(objBook2, "CombinePDF", "TRUE");
                                    }


                                    for (Int32 item_i = 1; item_i < objBook1.VBProject.VBComponents.Count + 1; item_i++)
                                    {
                                        //Int32 item_i = 1;
                                        VBComponent module = objBook1.VBProject.VBComponents.Item(item_i);
                                        string moduleName = module.Name;


                                        if ((moduleName.Contains("Sheet") == false) && (moduleName.Contains("Workbook") == false))
                                        {
                                            string moduleCode = module.CodeModule.Lines[1, module.CodeModule.CountOfLines];
                                            //MessageBox.Show(moduleName);
                                            VBComponent newModule = objBook2.VBProject.VBComponents.Add(vbext_ComponentType.vbext_ct_StdModule);
                                            newModule.Name = moduleName; // Replace with the actual module name
                                            newModule.CodeModule.AddFromString(moduleCode);


                                        }

                                    }


                                    Int32 jj = 1;
                                    while (GetWBProperty(objBook2, "macrobegin" + jj.ToString()) != null)
                                    {
                                        DelWBProperty(objBook2, "macrobegin" + jj.ToString());
                                        jj++;
                                    }

                                    Int32 kk = 1;
                                    while (GetWBProperty(objBook1, "macrobegin" + kk.ToString()) != null)
                                    {
                                        string macroname = GetWBProperty(objBook1, "macrobegin" + kk.ToString());
                                        SetWBProperty(objBook2, "macrobegin" + kk.ToString(), macroname);
                                        kk++;
                                    }



                                    if (UsingMacroBegin != null)
                                    {
                                        SetWBProperty(objBook2, "UsingMacroBegin", "TRUE");
                                    }

                                    //if (CheckSheetExist(objBook2, DesignSummaryTab)) objBook1.Worksheets[DesignSummaryTab].Delete();
                                    //if (CheckSheetExist(objBook2, DesignForcesTab)) objBook1.Worksheets[DesignForcesTab].Delete();

                                    //if (CheckSheetExist(objBook1, DesignSummaryTab))
                                    //{
                                    //    resultSheet = objBook1.Worksheets[DesignSummaryTab];
                                    //    resultSheet.Copy(Type.Missing, objBook2.Sheets[objBook2.Sheets.Count]);
                                    //}

                                    //if (CheckSheetExist(objBook1, DesignForcesTab))
                                    //{
                                    //    resultSheet = objBook1.Worksheets[DesignForcesTab];
                                    //    resultSheet.Copy(Type.Missing, objBook2.Sheets[objBook2.Sheets.Count]);
                                    //}



                                    foreach (Excel.Worksheet sheet in objBook1.Sheets)
                                    {
                                        if (CheckSheetExist(objBook2, sheet.Name)) objBook2.Worksheets[sheet.Name].Delete();

                                        resultSheet1 = objBook1.Worksheets[sheet.Name];
                                        resultSheet1.Copy(Type.Missing, objBook2.Sheets[objBook2.Sheets.Count]);

                                        if (CheckSheetExist(objBook2, sheet.Name))
                                        {
                                            resultSheet2 = objBook2.Worksheets[sheet.Name];
                                        }

                                        string rangeindex = GetProperty(resultSheet1, "rangeindex");
                                        string linkedsheet = GetProperty(resultSheet1, "linkedsheet");
                                        string printMaxValue = GetProperty(resultSheet1, "printMaxValue");

                                        if (rangeindex != null)
                                        {
                                            SetProperty(resultSheet2, "rangeindex", rangeindex);
                                        }

                                        if (linkedsheet != null)
                                        {
                                            SetProperty(resultSheet2, "linkedsheet", linkedsheet);
                                        }

                                        if (printMaxValue != null)
                                        {
                                            SetProperty(resultSheet2, "printMaxValue", printMaxValue);
                                        }

                                        

                                    }


                                    Int32 listcount = 0;
                                    if (GetWBProperty(objBook1, "printsheet_listcount") != null)
                                    {
                                        listcount = Convert.ToInt16(GetWBProperty(objBook1, "printsheet_listcount"));
                                        //MessageBox.Show(listcount.ToString());
                                        if (listcount > 0)
                                        {
                                            SetWBProperty(objBook2, "printsheet_listcount", listcount.ToString());

                                            for (Int32 ii = 0; ii < listcount; ii++)
                                            {
                                                string printsheetname = GetWBProperty(objBook1, "printsheet_" + ii.ToString());
                                                if (printsheetname != null)
                                                {
                                                    SetWBProperty(objBook2, "printsheet_" + ii.ToString(), printsheetname);
                                                }
                                            }
                                        }

                                    }

                                    

                                    objBook2.Save();

                                }
                                finally
                                {
                                    Globals.OSATool.Application.Calculation = Excel.XlCalculation.xlCalculationAutomatic;
                                    Globals.OSATool.Application.DisplayAlerts = true;
                                    Globals.OSATool.Application.ScreenUpdating = true;
                                    


                                    objBook1.Close(false, Type.Missing, Type.Missing);
                                    objBook2.Close(false, Type.Missing, Type.Missing);
                                    //resultSheet1 = null;
                                    //resultSheet2 = null;
                                    //objBook1 = null;
                                    //objBook2 = null;

                                    MessageBox.Show("Complete assign template!");

                                    Marshal.FinalReleaseComObject(resultSheet1);
                                    Marshal.FinalReleaseComObject(resultSheet2);
                                    Marshal.FinalReleaseComObject(objBook1);
                                    Marshal.FinalReleaseComObject(objBook2);


                                }


                            }

                        }


                    }


                }

            }
            
        }



        static bool CheckSheetExist(Excel.Workbook wb, string sheetname)
        {
            bool found = false;
            foreach (Excel.Worksheet sheet in wb.Sheets)
            {
                // Check the name of the current sheet
                if (sheet.Name == sheetname)
                {
                    found = true;
                    break; // Exit the loop now
                }
            }

            return found;
        }

        private void Bt_Range_Click(object sender, EventArgs e)
        {
            
        }

        private void setLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fileFolderDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(fileFolderDialog1.SelectedPath) == false)
                {
                    string TemplatePath = fileFolderDialog1.SelectedPath;

                    try
                    {
                        if (Directory.Exists(TemplatePath))
                        {
                            ShowFilesList(TemplatePath, true);
                            if (isInitializeTvwDirectory)
                            {
                                firstPathNode.Path = curFilePath;
                                curPathNode = firstPathNode;
                                isInitializeTvwDirectory = false;
                            }

                            string optionfile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), GlobalVar.Proglink) + @"\Library.dat";
                            XmlWriter r = new XmlWriter(optionfile);
                            r.WriteData("templatelink", TemplatePath);
                        }
                    }
                    catch
                    {

                    }

                }

            }
        }
    }
}
