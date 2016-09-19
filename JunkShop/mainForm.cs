using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
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

            saveToolStripButton.Enabled = false;
            panelObjects.Enabled = false;
            listBoxWeapons.Enabled = false;

            #region Event Handlers

            numericUpDownCost.ValueChanged += (sender, args) => JunkShopWorker.UpdateVariable_Weapons(0, numericUpDownCost.Value);
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

        private async void openToolStripButton_Click(object sender, EventArgs e)
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
                panelObjects.Enabled = true;
                listBoxWeapons.Enabled = true;

                JunkShopWorker.CheckKernel = File.ReadAllBytes(_existingFilename);

                this.KeyUp += new KeyEventHandler(mainForm_KeyUp);
                this.numericUpDownCost.ValueChanged += new EventHandler(mainForm_Objects);
                this.numericUpDownQua1.TextChanged += new EventHandler(mainForm_Objects);
                this.numericUpDownQua2.TextChanged += new EventHandler(mainForm_Objects);
                this.numericUpDownQua3.TextChanged += new EventHandler(mainForm_Objects);
                this.numericUpDownQua4.TextChanged += new EventHandler(mainForm_Objects);
                this.comboBoxItem1.SelectedIndexChanged += new EventHandler(mainForm_Objects);
                this.comboBoxItem2.SelectedIndexChanged += new EventHandler(mainForm_Objects);
                this.comboBoxItem3.SelectedIndexChanged += new EventHandler(mainForm_Objects);
                this.comboBoxItem4.SelectedIndexChanged += new EventHandler(mainForm_Objects);

                listBoxWeapons.SelectedIndex = 0;
                listBoxWeapons.Items[listBoxWeapons.SelectedIndex] = listBoxWeapons.SelectedItem; //used to refresh, useful if opening files more than once

                string language = comboBoxLang.GetItemText(comboBoxLang.SelectedItem);
                switch (language)
                {
                    case "English":
                        toolStripStatusLabelStatus.Text = Path.GetFileName(_existingFilename) + " loaded successfully";
                        toolStripStatusLabelFile.Text = Path.GetFileName(_existingFilename) + " loaded";
                        statusStrip1.BackColor = Color.FromArgb(255, 0, 150, 200);
                        toolStripStatusLabelStatus.BackColor = Color.FromArgb(255, 0, 150, 200);
                        await Task.Delay(4000);
                        statusStrip1.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.Text = "Ready";
                        break;

                    case "French":
                        toolStripStatusLabelStatus.Text = Path.GetFileName(_existingFilename) + " chargé avec succès";
                        toolStripStatusLabelFile.Text = Path.GetFileName(_existingFilename) + " chargé";
                        statusStrip1.BackColor = Color.FromArgb(255, 0, 150, 200);
                        toolStripStatusLabelStatus.BackColor = Color.FromArgb(255, 0, 150, 200);
                        await Task.Delay(4000);
                        statusStrip1.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.Text = "Prêt";
                        break;

                    case "German":
                        toolStripStatusLabelStatus.Text = Path.GetFileName(_existingFilename) + " erfolgreich geladen";
                        toolStripStatusLabelFile.Text = Path.GetFileName(_existingFilename) + " geladen";
                        statusStrip1.BackColor = Color.FromArgb(255, 0, 150, 200);
                        toolStripStatusLabelStatus.BackColor = Color.FromArgb(255, 0, 150, 200);
                        await Task.Delay(4000);
                        statusStrip1.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.Text = "Bereit";
                        break;

                    case "Italian":
                        toolStripStatusLabelStatus.Text = Path.GetFileName(_existingFilename) + " caricato con successo";
                        toolStripStatusLabelFile.Text = Path.GetFileName(_existingFilename) + " caricato";
                        statusStrip1.BackColor = Color.FromArgb(255, 0, 150, 200);
                        toolStripStatusLabelStatus.BackColor = Color.FromArgb(255, 0, 150, 200);
                        await Task.Delay(4000);
                        statusStrip1.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.Text = "Pronto";
                        break;

                    case "Spanish":
                        toolStripStatusLabelStatus.Text = Path.GetFileName(_existingFilename) + " cargado correctamente";
                        toolStripStatusLabelFile.Text = Path.GetFileName(_existingFilename) + " cargado";
                        statusStrip1.BackColor = Color.FromArgb(255, 0, 150, 200);
                        toolStripStatusLabelStatus.BackColor = Color.FromArgb(255, 0, 150, 200);
                        await Task.Delay(4000);
                        statusStrip1.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.Text = "Listo";
                        break;
                }
            }
            _openSaveException = false;
        }

        #endregion

        #region Save File

        private async void saveToolStripButton_Click(object sender, EventArgs e)
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
                        (String.Format("I cannot save the file {0}, maybe it's locked by another software?", Path.GetFileName(_existingFilename)),
                        "Error Saving File", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    _openSaveException = true;
                }
            }
            if (_openSaveException == false)
            {
                JunkShopWorker.CheckKernel = File.ReadAllBytes(_existingFilename);
                saveToolStripButton.Enabled = false;

                string language = comboBoxLang.GetItemText(comboBoxLang.SelectedItem);
                switch (language)
                {
                    case "English":
                        toolStripStatusLabelStatus.Text = Path.GetFileName(_existingFilename) + " saved successfully"; ;
                        statusStrip1.BackColor = Color.FromArgb(255, 0, 150, 200);
                        toolStripStatusLabelStatus.BackColor = Color.FromArgb(255, 0, 150, 200);
                        await Task.Delay(4000);
                        statusStrip1.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.Text = "Ready";
                        break;

                    case "French":
                        toolStripStatusLabelStatus.Text = Path.GetFileName(_existingFilename) + " enregistré avec succès"; ;
                        statusStrip1.BackColor = Color.FromArgb(255, 0, 150, 200);
                        toolStripStatusLabelStatus.BackColor = Color.FromArgb(255, 0, 150, 200);
                        await Task.Delay(4000);
                        statusStrip1.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.Text = "Prêt";
                        break;

                    case "German":
                        toolStripStatusLabelStatus.Text = Path.GetFileName(_existingFilename) + " erfolgreich gespeichert"; ;
                        statusStrip1.BackColor = Color.FromArgb(255, 0, 150, 200);
                        toolStripStatusLabelStatus.BackColor = Color.FromArgb(255, 0, 150, 200);
                        await Task.Delay(4000);
                        statusStrip1.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.Text = "Bereit";
                        break;

                    case "Italian":
                        toolStripStatusLabelStatus.Text = Path.GetFileName(_existingFilename) + " salvato con successo"; ;
                        statusStrip1.BackColor = Color.FromArgb(255, 0, 150, 200);
                        toolStripStatusLabelStatus.BackColor = Color.FromArgb(255, 0, 150, 200);
                        await Task.Delay(4000);
                        statusStrip1.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.Text = "Pronto";
                        break;

                    case "Spanish":
                        toolStripStatusLabelStatus.Text = Path.GetFileName(_existingFilename) + " guardado exitosamente"; ;
                        statusStrip1.BackColor = Color.FromArgb(255, 0, 150, 200);
                        toolStripStatusLabelStatus.BackColor = Color.FromArgb(255, 0, 150, 200);
                        await Task.Delay(4000);
                        statusStrip1.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.BackColor = Color.Gray;
                        toolStripStatusLabelStatus.Text = "Listo";
                        break;
                }
            }
            _openSaveException = false;
        }

        #endregion

        #region Closing Application (Ask save message and save current language to registry)

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saveToolStripButton.Enabled)
            {
                string language = comboBoxLang.GetItemText(comboBoxLang.SelectedItem);
                
                switch (language)
                {
                    case "English":
                        {
                            DialogResult dialogResult = MessageBox.Show("Save changes to " + Path.GetFileName(_existingFilename) + " before closing?", "Close",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                            if (dialogResult == DialogResult.Yes)
                            {
                                try
                                {
                                    File.WriteAllBytes(_existingFilename, JunkShopWorker.Kernel);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show
                                        (String.Format("I cannot save the file {0}, maybe it's locked by another software?", Path.GetFileName(_existingFilename)),
                                        "Error saving file", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                                    _openSaveException = true;
                                }

                                if (_openSaveException == true)
                                {
                                    e.Cancel = true;
                                }
                            }

                            else if (dialogResult == DialogResult.Cancel)
                                e.Cancel = true;
                            _openSaveException = false;

                            break;
                        }


                    case "French":
                        {
                            DialogResult dialogResult = MessageBox.Show("Enregistrer les modifications à " + Path.GetFileName(_existingFilename) + " avant de clôturer?", "Fermer",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                            if (dialogResult == DialogResult.Yes)
                            {
                                try
                                {
                                    File.WriteAllBytes(_existingFilename, JunkShopWorker.Kernel);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show
                                        (String.Format("Je ne peux pas enregistrer le fichier {0}, peut-être il est verrouillé par un autre logiciel?", Path.GetFileName(_existingFilename)),
                                        "Erreur d'enregistrement de fichier", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                                    _openSaveException = true;
                                }

                                if (_openSaveException == true)
                                {
                                    e.Cancel = true;
                                }
                            }

                            else if (dialogResult == DialogResult.Cancel)
                                e.Cancel = true;
                            _openSaveException = false;

                            break;
                        }


                    case "German":
                        {
                            DialogResult dialogResult = MessageBox.Show("Speichern Sie die Änderungen in " + Path.GetFileName(_existingFilename) + " vor dem Schließen?", "Schließen",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                            if (dialogResult == DialogResult.Yes)
                            {
                                try
                                {
                                    File.WriteAllBytes(_existingFilename, JunkShopWorker.Kernel);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show
                                        (String.Format("Ich kann nicht speichern Sie die Datei {0}, vielleicht ist es durch eine andere Software gesperrt?", Path.GetFileName(_existingFilename)),
                                        "Fehler beim Speichern der Datei", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                                    _openSaveException = true;
                                }

                                if (_openSaveException == true)
                                {
                                    e.Cancel = true;
                                }
                            }

                            else if (dialogResult == DialogResult.Cancel)
                                e.Cancel = true;
                            _openSaveException = false;

                            break;
                        }


                    case "Italian":
                        {
                            DialogResult dialogResult = MessageBox.Show("Vuoi salvare il file " + Path.GetFileName(_existingFilename) + " prima di chiudere?", "Chiudi",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                            if (dialogResult == DialogResult.Yes)
                            {
                                try
                                {
                                    File.WriteAllBytes(_existingFilename, JunkShopWorker.Kernel);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show
                                        (String.Format("Non riesco a salvare il file {0}, forse l'accesso è bloccato da un altro programma?", Path.GetFileName(_existingFilename)),
                                        "Errore durante il salvataggio del file", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                                    _openSaveException = true;
                                }

                                if (_openSaveException == true)
                                {
                                    e.Cancel = true;
                                }
                            }

                            else if (dialogResult == DialogResult.Cancel)
                                e.Cancel = true;
                            _openSaveException = false;

                            break;
                        }


                    case "Spanish":
                        {
                            DialogResult dialogResult = MessageBox.Show("¿Quieres guardar el archivo " + Path.GetFileName(_existingFilename) + " antes de cerrar?", "Cerca",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                            if (dialogResult == DialogResult.Yes)
                            {
                                try
                                {
                                    File.WriteAllBytes(_existingFilename, JunkShopWorker.Kernel);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show
                                        (String.Format("No puedo guardar el archivo {0}, tal vez el acceso está bloqueado por otro programa?", Path.GetFileName(_existingFilename)),
                                        "Guardar el archivo de error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                                    _openSaveException = true;
                                }

                                if (_openSaveException == true)
                                {
                                    e.Cancel = true;
                                }
                            }

                            else if (dialogResult == DialogResult.Cancel)
                                e.Cancel = true;
                            _openSaveException = false;

                            break;
                        }
                }
            }

            //Save current language to registry
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\JunkShop");
            key.SetValue("Language", comboBoxLang.SelectedItem.ToString());
        }

        #endregion

        #region About Dialog

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        #endregion

        #region Check when to enable save button

        private void CheckSaveButton()
        {
            if (JunkShopWorker.Kernel.Length == JunkShopWorker.CheckKernel.Length && memcmp(JunkShopWorker.Kernel, JunkShopWorker.CheckKernel, JunkShopWorker.Kernel.Length) == 0)
            {
                saveToolStripButton.Enabled = false;
            }
            else
            {
                saveToolStripButton.Enabled = true;
            }
        }

        private void mainForm_KeyUp(object sender, KeyEventArgs e)
        {
            CheckSaveButton();
        }

        private void mainForm_Objects(object sender, EventArgs e)
        {
            CheckSaveButton();
        }

        #endregion

        #region Translations

        private void applyResources(ComponentResourceManager resources, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                resources.ApplyResources(ctl, ctl.Name);
                applyResources(resources, ctl.Controls);
            }
        }

        private void comboBoxLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string language = comboBoxLang.GetItemText(comboBoxLang.SelectedItem);

            switch (language)
            {
                case "English":
                    {
                        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
                        ComponentResourceManager resourcesEn = new ComponentResourceManager(typeof(mainForm));
                        resourcesEn.ApplyResources(this, "$this");
                        applyResources(resourcesEn, this.Controls);
                        openToolStripButton.Text = "Open...";
                        saveToolStripButton.Text = "Save";
                        helpToolStripButton.Text = "About";
                        toolStripStatusLabelStatus.Text = "Ready";
                        if (_existingFilename != null)
                            toolStripStatusLabelFile.Text = Path.GetFileName(_existingFilename) + " loaded";
                        else
                            toolStripStatusLabelFile.Text = "No file is loaded";

                        listBoxWeapons.Items.Clear();
                        string[] weaponListEn = Properties.Resources.WeaponsListEn.Split('\n');
                        foreach (var line in weaponListEn)
                        {
                            listBoxWeapons.Items.Add(line);
                        }

                        comboBoxItem1.Items.Clear();
                        comboBoxItem2.Items.Clear();
                        comboBoxItem3.Items.Clear();
                        comboBoxItem4.Items.Clear();
                        string[] itemsListEn = Properties.Resources.ItemsListEn.Split('\n');
                        foreach (var line in itemsListEn)
                        {
                            comboBoxItem1.Items.Add(line);
                            comboBoxItem2.Items.Add(line);
                            comboBoxItem3.Items.Add(line);
                            comboBoxItem4.Items.Add(line);
                        }

                        break;
                    }


                case "French":
                    {
                        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr");
                        ComponentResourceManager resourcesFr = new ComponentResourceManager(typeof(mainForm));
                        resourcesFr.ApplyResources(this, "$this");
                        applyResources(resourcesFr, this.Controls);
                        openToolStripButton.Text = "Ouvrir...";
                        saveToolStripButton.Text = "Enregistrer";
                        helpToolStripButton.Text = "Informations";
                        toolStripStatusLabelStatus.Text = "Prêt";
                        if (_existingFilename != null)
                            toolStripStatusLabelFile.Text = Path.GetFileName(_existingFilename) + " chargé";
                        else
                            toolStripStatusLabelFile.Text = "Aucun fichier est chargé";

                        listBoxWeapons.Items.Clear();
                        string[] weaponListFr = Properties.Resources.WeaponsListFr.Split('\n');
                        foreach (var line in weaponListFr)
                        {
                            listBoxWeapons.Items.Add(line);
                        }

                        comboBoxItem1.Items.Clear();
                        comboBoxItem2.Items.Clear();
                        comboBoxItem3.Items.Clear();
                        comboBoxItem4.Items.Clear();
                        string[] itemsListFr = Properties.Resources.ItemsListFr.Split('\n');
                        foreach (var line in itemsListFr)
                        {
                            comboBoxItem1.Items.Add(line);
                            comboBoxItem2.Items.Add(line);
                            comboBoxItem3.Items.Add(line);
                            comboBoxItem4.Items.Add(line);
                        }

                        break;
                    }

                case "German":
                    {
                        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de");
                        ComponentResourceManager resourcesDe = new ComponentResourceManager(typeof(mainForm));
                        resourcesDe.ApplyResources(this, "$this");
                        applyResources(resourcesDe, this.Controls);
                        openToolStripButton.Text = "Öffnen...";
                        saveToolStripButton.Text = "Speichern";
                        helpToolStripButton.Text = "Informationen";
                        toolStripStatusLabelStatus.Text = "Bereit";
                        if (_existingFilename != null)
                            toolStripStatusLabelFile.Text = Path.GetFileName(_existingFilename) + " geladen";
                        else
                            toolStripStatusLabelFile.Text = "Keine datei geladen wird";

                        listBoxWeapons.Items.Clear();
                        string[] weaponListDe = Properties.Resources.WeaponsListDe.Split('\n');
                        foreach (var line in weaponListDe)
                        {
                            listBoxWeapons.Items.Add(line);
                        }

                        comboBoxItem1.Items.Clear();
                        comboBoxItem2.Items.Clear();
                        comboBoxItem3.Items.Clear();
                        comboBoxItem4.Items.Clear();
                        string[] itemsListDe = Properties.Resources.ItemsListDe.Split('\n');
                        foreach (var line in itemsListDe)
                        {
                            comboBoxItem1.Items.Add(line);
                            comboBoxItem2.Items.Add(line);
                            comboBoxItem3.Items.Add(line);
                            comboBoxItem4.Items.Add(line);
                        }

                        break;
                    }

                case "Italian":
                    {
                        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("it");
                        ComponentResourceManager resourcesIt = new ComponentResourceManager(typeof(mainForm));
                        resourcesIt.ApplyResources(this, "$this");
                        applyResources(resourcesIt, this.Controls);
                        openToolStripButton.Text = "Apri...";
                        saveToolStripButton.Text = "Salva";
                        helpToolStripButton.Text = "Informazioni";
                        toolStripStatusLabelStatus.Text = "Pronto";
                        if (_existingFilename != null)
                            toolStripStatusLabelFile.Text = Path.GetFileName(_existingFilename) + " caricato";
                        else
                            toolStripStatusLabelFile.Text = "Nessun file è stato caricato";

                        listBoxWeapons.Items.Clear();
                        string[] weaponListIt = Properties.Resources.WeaponsListIt.Split('\n');
                        foreach (var line in weaponListIt)
                        {
                            listBoxWeapons.Items.Add(line);
                        }

                        comboBoxItem1.Items.Clear();
                        comboBoxItem2.Items.Clear();
                        comboBoxItem3.Items.Clear();
                        comboBoxItem4.Items.Clear();
                        string[] itemsListIt = Properties.Resources.ItemsListIt.Split('\n');
                        foreach (var line in itemsListIt)
                        {
                            comboBoxItem1.Items.Add(line);
                            comboBoxItem2.Items.Add(line);
                            comboBoxItem3.Items.Add(line);
                            comboBoxItem4.Items.Add(line);
                        }

                        break;
                    }

                case "Spanish":
                    {
                        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es");
                        ComponentResourceManager resourcesEs = new ComponentResourceManager(typeof(mainForm));
                        resourcesEs.ApplyResources(this, "$this");
                        applyResources(resourcesEs, this.Controls);
                        openToolStripButton.Text = "Abrir...";
                        saveToolStripButton.Text = "Guardar";
                        helpToolStripButton.Text = "Informaciones";
                        toolStripStatusLabelStatus.Text = "Listo";
                        if (_existingFilename != null)
                            toolStripStatusLabelFile.Text = Path.GetFileName(_existingFilename) + " cargado";
                        else
                            toolStripStatusLabelFile.Text = "Ningún archivo es cargado";

                        listBoxWeapons.Items.Clear();
                        string[] weaponListEs = Properties.Resources.WeaponsListEs.Split('\n');
                        foreach (var line in weaponListEs)
                        {
                            listBoxWeapons.Items.Add(line);
                        }

                        comboBoxItem1.Items.Clear();
                        comboBoxItem2.Items.Clear();
                        comboBoxItem3.Items.Clear();
                        comboBoxItem4.Items.Clear();
                        string[] itemsListEs = Properties.Resources.ItemsListEs.Split('\n');
                        foreach (var line in itemsListEs)
                        {
                            comboBoxItem1.Items.Add(line);
                            comboBoxItem2.Items.Add(line);
                            comboBoxItem3.Items.Add(line);
                            comboBoxItem4.Items.Add(line);
                        }

                        break;
                    }
            }
            if (_existingFilename != null)
                listBoxWeapons.SelectedIndex = 0;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\JunkShop"))
                {
                    if (key != null)
                    {
                        object savedLanguage = key.GetValue("Language");


                        if (savedLanguage != null && ((string)savedLanguage == "English" || (string)savedLanguage == "French" ||
                            (string)savedLanguage == "German" || (string)savedLanguage == "Italian" || (string)savedLanguage == "Spanish"))
                        {
                            comboBoxLang.SelectedItem = savedLanguage;
                        }
                        else
                            comboBoxLang.SelectedItem = "English";
                    }
                    else
                        comboBoxLang.SelectedItem = "English";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
                numericUpDownCost.Value = JunkShopWorker.GetSelectedWeaponsData.Price * 10;
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