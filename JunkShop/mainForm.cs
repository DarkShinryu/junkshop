using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkShop
{
    public partial class mainForm : Form
    {
        public static bool _loaded = false;
        private static bool _openSaveException = false;
        public string _existingFilename;

        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int memcmp(byte[] b1, byte[] b2, long count);

        public mainForm()
        {
            InitializeComponent();
            
            saveToolStripMenuItem.Enabled = false;

            #region Event Handlers

            numericUpDownPrice.TextChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(0, numericUpDownPrice.Text);
            comboBoxItem1.SelectedIndexChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(1, comboBoxItem1.SelectedIndex);
            comboBoxItem2.SelectedIndexChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(3, comboBoxItem2.SelectedIndex);
            comboBoxItem3.SelectedIndexChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(5, comboBoxItem3.SelectedIndex);
            comboBoxItem4.SelectedIndexChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(7, comboBoxItem4.SelectedIndex);
            numericUpDownQua1.TextChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(2, numericUpDownQua1.Text);
            numericUpDownQua2.TextChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(4, numericUpDownQua2.Text);
            numericUpDownQua3.TextChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(6, numericUpDownQua3.Text);
            numericUpDownQua4.TextChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(8, numericUpDownQua4.Text);

            #endregion
        }

        #region Open File

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open FF8 mwepon.bin";
            openFileDialog.Filter = "FF8 mwepon|*.bin";
            openFileDialog.FileName = "mwepon.bin";

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            {
                try
                {
                    using (var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var BR = new BinaryReader(fileStream))
                        {
                            JunkShopWorker.ReadJunkShop(BR.ReadBytes((int)fileStream.Length));
                        }
                    }
                    _existingFilename = openFileDialog.FileName;
                }
                catch (Exception)
                {
                    MessageBox.Show
                        (String.Format("I cannot open the file {0}, maybe it's locked by another software?", Path.GetFileName(openFileDialog.FileName)), "Error Opening File",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    _openSaveException = true;
                }
            }

            if (!_openSaveException)
            {
                JunkShopWorker.CheckKernel = File.ReadAllBytes(_existingFilename);

                this.KeyUp += new KeyEventHandler(mainForm_KeyUp);
                this.MouseUp += new MouseEventHandler(mainForm_MouseUp);
                this.numericUpDownPrice.TextChanged += new EventHandler(mainForm_Objects);
                this.numericUpDownQua1.TextChanged += new EventHandler(mainForm_Objects);
                this.numericUpDownQua2.TextChanged += new EventHandler(mainForm_Objects);
                this.numericUpDownQua3.TextChanged += new EventHandler(mainForm_Objects);
                this.numericUpDownQua4.TextChanged += new EventHandler(mainForm_Objects);
                this.comboBoxItem1.SelectedIndexChanged += new EventHandler(mainForm_Objects);
                this.comboBoxItem2.SelectedIndexChanged += new EventHandler(mainForm_Objects);
                this.comboBoxItem3.SelectedIndexChanged += new EventHandler(mainForm_Objects);
                this.comboBoxItem4.SelectedIndexChanged += new EventHandler(mainForm_Objects);

                listBoxWeapons.SelectedIndex = 0;

                toolStripStatusLabelStatus.Text = Path.GetFileName(_existingFilename) + " loaded successfully";
                toolStripStatusLabelFile.Text = Path.GetFileName(_existingFilename) + " loaded";
                statusStrip1.BackColor = Color.FromArgb(255, 0, 150, 200);
                toolStripStatusLabelStatus.BackColor = Color.FromArgb(255, 0, 150, 200);
                await Task.Delay(3000);
                statusStrip1.BackColor = Color.Gray;
                toolStripStatusLabelStatus.BackColor = Color.Gray;
                toolStripStatusLabelStatus.Text = "Ready";
            }
            _openSaveException = false;
        }

        #endregion

        #region Save File

        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(_existingFilename)) && JunkShopWorker.Kernel != null)
            {
                try
                {
                    File.WriteAllBytes(_existingFilename, JunkShopWorker.Kernel);
                }
                catch (Exception)
                {
                    MessageBox.Show
                        (String.Format("I cannot save the file {0}, maybe it's locked by another software?", Path.GetFileName(_existingFilename)), "Error Saving File",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    _openSaveException = true;
                }
            }
            if (!_openSaveException)
            {
                JunkShopWorker.CheckKernel = File.ReadAllBytes(_existingFilename);
                saveToolStripMenuItem.Enabled = false;
                toolStripStatusLabelStatus.Text = Path.GetFileName(_existingFilename) + " saved successfully";;
                statusStrip1.BackColor = Color.FromArgb(255, 0, 150, 200);
                toolStripStatusLabelStatus.BackColor = Color.FromArgb(255, 0, 150, 200);
                await Task.Delay(3000);
                statusStrip1.BackColor = Color.Gray;
                toolStripStatusLabelStatus.BackColor = Color.Gray;
                toolStripStatusLabelStatus.Text = "Ready";
            }
            _openSaveException = false;
        }

        #endregion

        #region Close Application

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region About Dialog
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        #endregion

        #region Check when to enable save button

        private void CheckSaveButton()
        {
            if (JunkShopWorker.Kernel.Length == JunkShopWorker.CheckKernel.Length && memcmp(JunkShopWorker.Kernel, JunkShopWorker.CheckKernel, JunkShopWorker.Kernel.Length) == 0)
                saveToolStripMenuItem.Enabled = false;
            else
                saveToolStripMenuItem.Enabled = true;
        }

        private void mainForm_KeyUp(object sender, KeyEventArgs e)
        {
            CheckSaveButton();
        }

        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
            CheckSaveButton();
        }

        private void mainForm_Objects(object sender, EventArgs e)
        {
            CheckSaveButton();
        }

        #endregion

        private void listBoxWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            _loaded = false;
            if (JunkShopWorker.Kernel == null)
                return;
            JunkShopWorker.ReadWeapons(listBoxWeapons.SelectedIndex);

            try
            {
                numericUpDownPrice.Value = JunkShopWorker.GetSelectedWeaponsData.Price * 10;
                comboBoxItem1.SelectedIndex = JunkShopWorker.GetSelectedWeaponsData.Item1;
                numericUpDownQua1.Value = JunkShopWorker.GetSelectedWeaponsData.Quantity1;
                comboBoxItem2.SelectedIndex = JunkShopWorker.GetSelectedWeaponsData.Item2;
                numericUpDownQua2.Value = JunkShopWorker.GetSelectedWeaponsData.Quantity2;
                comboBoxItem3.SelectedIndex = JunkShopWorker.GetSelectedWeaponsData.Item3;
                numericUpDownQua3.Value = JunkShopWorker.GetSelectedWeaponsData.Quantity3;
                comboBoxItem4.SelectedIndex = JunkShopWorker.GetSelectedWeaponsData.Item4;
                numericUpDownQua4.Value = JunkShopWorker.GetSelectedWeaponsData.Quantity4;
            }
            catch (Exception eException)
            {
                MessageBox.Show(eException.ToString());
            }
            _loaded = true;
        }
    }
}
