using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;

namespace FileEncrypter
{
    public partial class Main : Form
    {
        public static StartForm getphrase = new StartForm();
        private ProgressBar progressBarForm;
        public StartForm MyParent;
        public static string packagefiledirectory;

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main(StartForm MyParent)
        {
            InitializeComponent();
            this.MyParent = MyParent;
            this.Shown += new EventHandler(this.Form1_Shown);
            packagefiledirectory = $@"{Directory.GetCurrentDirectory()}\PackageFiles\{MyParent.USERNAME}.pkg";
        }

        private void ControlBar_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void ExitPictureBox_MouseHover(object sender, EventArgs e)
        {
            ExitPictureBox.BackColor = Color.FromArgb(240, 71, 71);
        }

        private void ExitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            ExitPictureBox.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
            MyParent.Close();
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimizePictureBox_MouseHover(object sender, EventArgs e)
        {
            MinimizePictureBox.BackColor = Color.FromArgb(50, 53, 56);
        }

        private void MinimizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            MinimizePictureBox.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            refreshfiles();
            progressBarForm = new ProgressBar(this);
            progressBarForm.ShowDialog();
        }

        private void FilePanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            var filePackage = new FilePackage
            {
                FilePath = packagefiledirectory,
                ContentFilePathList = files.ToList()
            };
            var filePackageWriter = new FilePackageWriter(filePackage);
            filePackageWriter.GeneratePackage(false);
            refreshfiles();
        }

        private void FilePanel_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void encryptbutton_Click(object sender, EventArgs e)
        {
            Encryption.FileEncrypt(packagefiledirectory, "abc");
        }


        #region Refreshing

        private void refreshfiles()
        {
            FilePanel.Controls.Clear();
            Refreshing.RunWorkerAsync();
        }

        private void Refreshing_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                var filePackageReader = new FilePackageReader(packagefiledirectory);
                List<ArchiveEntriesObject> fileNameCustomObjectList = filePackageReader.GetArchiveEntries();
                foreach (var archiveEntry in fileNameCustomObjectList)
                {
                    ///panel
                    Panel panel = new Panel();
                    panel.Size = new Size(600, 20);
                    panel.BackColor = Color.FromArgb(82, 82, 82);
                    panel.BorderStyle = BorderStyle.FixedSingle;


                    ///PictureBox
                    PictureBox exeimage = new PictureBox();
                    exeimage.Image = IconManager.FindIconForFilename(archiveEntry.ZipEntry.Name, false).ToBitmap();
                    exeimage.SizeMode = PictureBoxSizeMode.CenterImage;
                    exeimage.Location = new Point(4, 2);
                    exeimage.Size = new Size(16, 16);

                    ///Label
                    Label label = new Label();
                    label.Text = archiveEntry.ZipEntry.Name;
                    label.ForeColor = Color.White;
                    label.Font = new Font(label.Font.FontFamily, 11);
                    label.AutoSize = true;
                    label.Location = new Point(30, 2);

                    ///Adding Controls
                    panel.Controls.Add(exeimage);
                    panel.Controls.Add(label);
                    panel.Name = archiveEntry.ID.ToString();
                    panel.Click += new EventHandler(DynamicPanel_MouseClick);
                    panel.DoubleClick += new EventHandler(DynamicPanel_DoubleClick);
                    label.Click += new EventHandler(Dynamiclabel_MouseClick);
                    exeimage.Click += new EventHandler(Dynamicpicturbox_MouseClick);
                    Refreshing.ReportProgress(1, panel);
                }
            }
            catch (FileNotFoundException)
            {
                var filePackage = new FilePackage
                {
                    FilePath = packagefiledirectory,
                    ContentFilePathList = null
                };
                var filePackageWriter = new FilePackageWriter(filePackage);
                filePackageWriter.GeneratePackage(false);
            }
        }

        private void Refreshing_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            Panel panel = (Panel)e.UserState;
            FilePanel.Controls.Add(panel);
            progressBarForm.UpdateProgressBar("Starting up", 50, 1);
        }

        private void Refreshing_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            progressBarForm.Close();
        }
        #region events
        void DynamicPanel_MouseClick(object sender, EventArgs e)
        {
            Panel senderpanel = (Panel)sender;
            senderpanel.BackColor = Color.Red;
        }

        void DynamicPanel_DoubleClick(object sender, EventArgs e)
        {
            Panel senderpanel = (Panel)sender;
            string panelid = senderpanel.Name;
            ZipArchiveEntry currentZipEntry = null;
            MemoryStream inMemoryCopy = new MemoryStream();


            var filePackageReader = new FilePackageReader(packagefiledirectory);
            var fileNameCustomObjectList = filePackageReader.GetArchiveEntries();

            fileNameCustomObjectList.Find(item => item.ID == Int32.Parse(panelid));
            foreach(var archiveEntry in fileNameCustomObjectList)
            {
                if (archiveEntry.ID == Int32.Parse(panelid))
                {
                    currentZipEntry = archiveEntry.ZipEntry;
                    break;
                }
            }
            if (currentZipEntry != null)
            {

            }
            else
            {
                refreshfiles();
            }
        }
        void Dynamiclabel_MouseClick(object sender, EventArgs e)
        {
            Label senderlabel = (Label)sender;
            DynamicPanel_MouseClick(senderlabel.Parent, e);
        }
        void Dynamicpicturbox_MouseClick(object sender, EventArgs e)
        {
            PictureBox senderpicturebox = (PictureBox)sender;
            DynamicPanel_MouseClick(senderpicturebox.Parent, e);
        }
        #endregion

        #endregion
    }
    #region Packages
    public class FilePackage
    {
        public string FilePath { get; set; }
        public IEnumerable<string> ContentFilePathList { get; set; }
    }

    public class FilePackageWriter
    {
        private readonly string _filepath;
        private readonly IEnumerable<string> _contentFilePathList;
        private string _tempDirectoryPath;

        public FilePackageWriter(FilePackage filePackage)
        {
            _filepath = filePackage.FilePath;
            _contentFilePathList = filePackage.ContentFilePathList;
        }

        public void GeneratePackage(bool deleteContents)
        {
            try
            {
                string parentDirectoryPath = null;
                string filename = null;

                var fileInfo = new FileInfo(_filepath);

                // Get the parent directory path of the package file and if the package file already exists add to it
                if (fileInfo.Exists)
                {
                    foreach (var filePath in _contentFilePathList)
                    {
                        using (var zipArchive = ZipFile.Open(fileInfo.FullName, ZipArchiveMode.Update))
                        {
                            var addedfileinfo = new FileInfo(filePath);
                            zipArchive.CreateEntryFromFile(addedfileinfo.FullName, addedfileinfo.Name);
                        }
                    }
                    filename = fileInfo.Name;
                    var parentDirectoryInfo = fileInfo.Directory;
                    if (parentDirectoryInfo != null)
                    {
                        parentDirectoryPath = parentDirectoryInfo.FullName;
                    }
                    else
                    {
                        throw new NullReferenceException("Parent directory info was null!");
                    }
                }
                else
                {
                    if (filename == null)
                    {
                        var lastIndexOfFileSeperator = _filepath.LastIndexOf("\\", StringComparison.Ordinal);
                        if (lastIndexOfFileSeperator != -1)
                        {
                            parentDirectoryPath = _filepath.Substring(0, lastIndexOfFileSeperator);
                            filename = _filepath.Substring(lastIndexOfFileSeperator + 1, _filepath.Length - (lastIndexOfFileSeperator + 1));
                        }
                        else
                        {
                            throw new Exception("The input file path '" + _filepath +
                                                "' does not contain any file seperators.");
                        }
                    }

                    // Create a temp directory for our package
                    _tempDirectoryPath = parentDirectoryPath + "\\" + filename + "_temp";
                    if (Directory.Exists(_tempDirectoryPath))
                    {
                        Directory.Delete(_tempDirectoryPath, true);
                    }

                    Directory.CreateDirectory(_tempDirectoryPath);
                    if (_contentFilePathList != null)
                    {
                        foreach (var filePath in _contentFilePathList)
                        {
                            // Copy every content file into the temp directory we created before
                            var filePathInfo = new FileInfo(filePath);
                            if (filePathInfo.Exists)
                            {
                                File.Copy(filePathInfo.FullName, _tempDirectoryPath + "\\" + filePathInfo.Name);
                            }
                            else
                            {
                                throw new FileNotFoundException("File path " + filePath + " doesn't exist!");
                            }
                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(_tempDirectoryPath);
                    }
                    ZipFile.CreateFromDirectory(_tempDirectoryPath, _filepath);
                }
            }
            catch (Exception e)
            {
                var errorMessage = "An error occured while generating the package. " + e.Message;
                throw new Exception(errorMessage);
            }
            finally
            {
                // Clear the temp directory and the content files
                if (Directory.Exists(_tempDirectoryPath))
                {
                    Directory.Delete(_tempDirectoryPath, true);
                }

                if (deleteContents)
                {
                    foreach (var filePath in _contentFilePathList)
                    {
                        if (File.Exists(filePath))
                        {
                            File.Delete(filePath);
                        }
                    }
                }

                Encryption.FileEncrypt(Main.packagefiledirectory, Main.getphrase.PASSPHRASE);
            }
        }
    }
    public class FilePackageReader
    {
        private List<ArchiveEntriesObject> _ArchiveEntryList;
        private readonly string _filepath;

        public FilePackageReader(string filepath)
        {
            _filepath = filepath;
        }

        public List<ArchiveEntriesObject> GetArchiveEntries()
        {
            _ArchiveEntryList = new List<ArchiveEntriesObject>();
            int numberID = 0;

            try
            {
                Encryption.FileDecrypt(Main.packagefiledirectory, Main.getphrase.PASSPHRASE);

                using (var fs = new FileStream(_filepath, FileMode.Open))
                {
                    // Open the package file as a ZIP
                    using (var archive = new ZipArchive(fs))
                    {
                        // Iterate through the content files and add them to a dictionary
                        foreach (var zipArchiveEntry in archive.Entries)
                        {
                            _ArchiveEntryList.Add(new ArchiveEntriesObject { ID = numberID, ZipEntry = zipArchiveEntry });
                            numberID++;
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("Archive File was not found, it was either moved or deleted");
            }

            return _ArchiveEntryList;
        }
    }
    #endregion

    #region GetIcon
    public static class IconManager
    {
        private static readonly Dictionary<string, Icon> _smallIconCache = new Dictionary<string, Icon>();
        private static readonly Dictionary<string, Icon> _largeIconCache = new Dictionary<string, Icon>();
        /// <summary>
        /// Get an icon for a given filename
        /// </summary>
        /// <param name="fileName">any filename</param>
        /// <param name="large">16x16 or 32x32 icon</param>
        /// <returns>null if path is null, otherwise - an icon</returns>
        public static Icon FindIconForFilename(string fileName, bool large)
        {
            var extension = Path.GetExtension(fileName);
            if (extension == null)
                return null;
            var cache = large ? _largeIconCache : _smallIconCache;
            Icon icon;
            if (cache.TryGetValue(extension, out icon))
                return icon;
            icon = IconReader.GetFileIcon(fileName, large ? IconReader.IconSize.Large : IconReader.IconSize.Small, false);
            cache.Add(extension, icon);
            return icon;
        }
        /// <summary>
        /// Provides static methods to read system icons for both folders and files.
        /// </summary>
        /// <example>
        /// <code>IconReader.GetFileIcon("c:\\general.xls");</code>
        /// </example>
        static class IconReader
        {
            /// <summary>
            /// Options to specify the size of icons to return.
            /// </summary>
            public enum IconSize
            {
                /// <summary>
                /// Specify large icon - 32 pixels by 32 pixels.
                /// </summary>
                Large = 0,
                /// <summary>
                /// Specify small icon - 16 pixels by 16 pixels.
                /// </summary>
                Small = 1
            }
            /// <summary>
            /// Returns an icon for a given file - indicated by the name parameter.
            /// </summary>
            /// <param name="name">Pathname for file.</param>
            /// <param name="size">Large or small</param>
            /// <param name="linkOverlay">Whether to include the link icon</param>
            /// <returns>System.Drawing.Icon</returns>
            public static Icon GetFileIcon(string name, IconSize size, bool linkOverlay)
            {
                var shfi = new Shell32.Shfileinfo();
                var flags = Shell32.ShgfiIcon | Shell32.ShgfiUsefileattributes;
                if (linkOverlay) flags += Shell32.ShgfiLinkoverlay;
                /* Check the size specified for return. */
                if (IconSize.Small == size)
                    flags += Shell32.ShgfiSmallicon;
                else
                    flags += Shell32.ShgfiLargeicon;
                Shell32.SHGetFileInfo(name,
                    Shell32.FileAttributeNormal,
                    ref shfi,
                    (uint)Marshal.SizeOf(shfi),
                    flags);
                // Copy (clone) the returned icon to a new object, thus allowing us to clean-up properly
                var icon = (Icon)Icon.FromHandle(shfi.hIcon).Clone();
                User32.DestroyIcon(shfi.hIcon);     // Cleanup
                return icon;
            }
        }
        /// <summary>
        /// Wraps necessary Shell32.dll structures and functions required to retrieve Icon Handles using SHGetFileInfo. Code
        /// courtesy of MSDN Cold Rooster Consulting case study.
        /// </summary>
        static class Shell32
        {
            private const int MaxPath = 256;
            [StructLayout(LayoutKind.Sequential)]
            public struct Shfileinfo
            {
                private const int Namesize = 80;
                public readonly IntPtr hIcon;
                private readonly int iIcon;
                private readonly uint dwAttributes;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxPath)]
                private readonly string szDisplayName;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Namesize)]
                private readonly string szTypeName;
            };
            public const uint ShgfiIcon = 0x000000100;     // get icon
            public const uint ShgfiLinkoverlay = 0x000008000;     // put a link overlay on icon
            public const uint ShgfiLargeicon = 0x000000000;     // get large icon
            public const uint ShgfiSmallicon = 0x000000001;     // get small icon
            public const uint ShgfiUsefileattributes = 0x000000010;     // use passed dwFileAttribute
            public const uint FileAttributeNormal = 0x00000080;
            [DllImport("Shell32.dll")]
            public static extern IntPtr SHGetFileInfo(
                string pszPath,
                uint dwFileAttributes,
                ref Shfileinfo psfi,
                uint cbFileInfo,
                uint uFlags
                );
        }
        /// <summary>
        /// Wraps necessary functions imported from User32.dll. Code courtesy of MSDN Cold Rooster Consulting example.
        /// </summary>
        static class User32
        {
            /// <summary>
            /// Provides access to function required to delete handle. This method is used internally
            /// and is not required to be called separately.
            /// </summary>
            /// <param name="hIcon">Pointer to icon handle.</param>
            /// <returns>N/A</returns>
            [DllImport("User32.dll")]
            public static extern int DestroyIcon(IntPtr hIcon);
        }
    }
    #endregion

    #region Zip Archive class
    public class ArchiveEntriesObject
    {
        public int ID { get; set; }
        public ZipArchiveEntry ZipEntry { get; set; }
    }
    #endregion
}
