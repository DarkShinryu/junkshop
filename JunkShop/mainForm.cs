using System;
using System.IO;
using System.Windows.Forms;

namespace JunkShop
{
    public partial class mainForm : Form
    {
        public static bool _loaded = false;
        public string existingFilename;
        public mainForm()
        {
            InitializeComponent();
            
            saveToolStripMenuItem.Enabled = false; //for disabling save when no file is open

            #region Event Handlers
            numericUpDownPrice.ValueChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(0, numericUpDownPrice.Value);
            comboBoxItem1.SelectedIndexChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(1, comboBoxItem1.SelectedIndex);
            comboBoxItem2.SelectedIndexChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(3, comboBoxItem2.SelectedIndex);
            comboBoxItem3.SelectedIndexChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(5, comboBoxItem3.SelectedIndex);
            comboBoxItem4.SelectedIndexChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(7, comboBoxItem4.SelectedIndex);
            numericUpDownQua1.ValueChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(2, numericUpDownQua1.Value);
            numericUpDownQua2.ValueChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(4, numericUpDownQua2.Value);
            numericUpDownQua3.ValueChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(6, numericUpDownQua3.Value);
            numericUpDownQua4.ValueChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(8, numericUpDownQua4.Value);

            #endregion
        }


        #region Open File

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open FF8 mwepon.bin";
            openFileDialog.Filter = "FF8 mwepon|*.bin";
            openFileDialog.FileName = "mwepon.bin";

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            {
                using (var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var BR = new BinaryReader(fileStream))
                    {
                        JunkShopWorker.ReadJunkShop(BR.ReadBytes((int)fileStream.Length));
                    }
                }

                existingFilename = openFileDialog.FileName;
                saveToolStripMenuItem.Enabled = true;
                return;
            }
        }

        #endregion

        #region Save File

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(existingFilename)) && JunkShopWorker.Kernel != null)
            {
                File.WriteAllBytes(existingFilename, JunkShopWorker.Kernel);
                return;
            }
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


        private void listBoxWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            _loaded = false;
            if (JunkShopWorker.Kernel == null)
                return;
            JunkShopWorker.ReadWeapons(listBoxWeapons.SelectedIndex);

            try
            {
                numericUpDownPrice.Value = JunkShopWorker.GetSelectedWeaponsData.Price;
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
