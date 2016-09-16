namespace JunkShop
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelObjects = new System.Windows.Forms.Panel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxItem4 = new System.Windows.Forms.ComboBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.labelItem4 = new System.Windows.Forms.Label();
            this.numericUpDownQua1 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxItem3 = new System.Windows.Forms.ComboBox();
            this.numericUpDownQua2 = new System.Windows.Forms.NumericUpDown();
            this.labelItem3 = new System.Windows.Forms.Label();
            this.numericUpDownQua3 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxItem2 = new System.Windows.Forms.ComboBox();
            this.numericUpDownQua4 = new System.Windows.Forms.NumericUpDown();
            this.labelItem2 = new System.Windows.Forms.Label();
            this.labelItem1 = new System.Windows.Forms.Label();
            this.comboBoxItem1 = new System.Windows.Forms.ComboBox();
            this.labelQuantity1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxWeapons = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRightAlign = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua4)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(364, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::JunkShop.Properties.Resources.close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelObjects);
            this.panel1.Location = new System.Drawing.Point(99, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 512);
            this.panel1.TabIndex = 9;
            // 
            // panelObjects
            // 
            this.panelObjects.Controls.Add(this.labelPrice);
            this.panelObjects.Controls.Add(this.comboBoxItem4);
            this.panelObjects.Controls.Add(this.numericUpDownPrice);
            this.panelObjects.Controls.Add(this.labelItem4);
            this.panelObjects.Controls.Add(this.numericUpDownQua1);
            this.panelObjects.Controls.Add(this.comboBoxItem3);
            this.panelObjects.Controls.Add(this.numericUpDownQua2);
            this.panelObjects.Controls.Add(this.labelItem3);
            this.panelObjects.Controls.Add(this.numericUpDownQua3);
            this.panelObjects.Controls.Add(this.comboBoxItem2);
            this.panelObjects.Controls.Add(this.numericUpDownQua4);
            this.panelObjects.Controls.Add(this.labelItem2);
            this.panelObjects.Controls.Add(this.labelItem1);
            this.panelObjects.Controls.Add(this.comboBoxItem1);
            this.panelObjects.Controls.Add(this.labelQuantity1);
            this.panelObjects.Controls.Add(this.label5);
            this.panelObjects.Controls.Add(this.label3);
            this.panelObjects.Controls.Add(this.label4);
            this.panelObjects.Location = new System.Drawing.Point(8, 4);
            this.panelObjects.Name = "panelObjects";
            this.panelObjects.Size = new System.Drawing.Size(256, 359);
            this.panelObjects.TabIndex = 11;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.labelPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelPrice.Location = new System.Drawing.Point(98, 12);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(64, 17);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price (Gil)";
            // 
            // comboBoxItem4
            // 
            this.comboBoxItem4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxItem4.FormattingEnabled = true;
            this.comboBoxItem4.Items.AddRange(new object[] {
            "None",
            "Potion",
            "Potion+",
            "Hi-Potion",
            "Hi-Potion+",
            "X-Potion",
            "Mega-Potion",
            "Phoenix Down",
            "Mega Phoenix",
            "Elixir",
            "Megalixir",
            "Antidote",
            "Soft",
            "Eye Drops",
            "Echo Screen",
            "Holy Water",
            "Remedy",
            "Remedy+",
            "Hero-Trial",
            "Hero",
            "Holy War-Trial",
            "Holy War",
            "Shell Stone",
            "Protect Stone",
            "Aura Stone",
            "Death Stone",
            "Holy Stone",
            "Flare Stone",
            "Meteor Stone",
            "Ultima Stone",
            "Gysahl Greens",
            "Phoenix Pinion",
            "Friendship",
            "Tent",
            "Pet House",
            "Cottage",
            "G-Potion",
            "G-Hi-Potion",
            "G-Mega-Potion",
            "G-Returner",
            "Rename Card",
            "Amnesia Greens",
            "HP-J Scroll",
            "Str-J Scroll",
            "Vit-J Scroll",
            "Mag-J Scroll",
            "Spr-J Scroll",
            "Spd-J Scroll",
            "Luck-J Scroll",
            "Aegis Amulet",
            "Elem Atk",
            "Elem Guard",
            "Status Atk",
            "Status Guard",
            "Rosetta Stone",
            "Magic Scroll",
            "GF Scroll",
            "Draw Scroll",
            "Item Scroll",
            "Gambler Spirit",
            "Healing Ring",
            "Phoenix Spirit",
            "Med Kit",
            "Bomb Spirit",
            "Hungry Cookpot",
            "Mog\'s Amulet",
            "Steel Pipe",
            "Star Fragment",
            "Energy Crystal",
            "Samantha Soul",
            "Healing Mail",
            "Silver Mail",
            "Gold Armor",
            "Diamod Armor",
            "Regen Ring",
            "Giant\'s Ring",
            "Gaea\'s Ring",
            "Strength Love",
            "Power Wrist",
            "Hyper Wrist",
            "Turtle Shell",
            "Orihalcon",
            "Adamantine",
            "Rune Armlet",
            "Force Armlet",
            "Magic Armlet",
            "Circlet",
            "Hypno Crown",
            "Royal Crown",
            "Jet Engine",
            "Rocket Engine",
            "Moon Curtain",
            "Steel Curtain",
            "Glow Curtain",
            "Accelerator",
            "Monk\'s Code",
            "Knight\'s Code",
            "Doc\'s Code",
            "Hundred Needles",
            "Three Stars",
            "Ribbon",
            "Normal Ammo",
            "Shotgun Ammo",
            "Dark Ammo",
            "Fire Ammo",
            "Demolition Ammo",
            "Fast Ammo",
            "AP Ammo",
            "Pulse Ammo",
            "M-Stone Piece",
            "Magic Stone",
            "Wizard Stone",
            "Ochu Tentacle",
            "Healing Water",
            "Cockatrice Pinion",
            "Zombie Powder",
            "Lightweight",
            "Sharp Spike",
            "Screw",
            "Saw Blade",
            "Mesmerize Blade",
            "Vampire Fang",
            "Fury Fragment",
            "Betrayal Sword",
            "Sleep Powder",
            "Life Ring",
            "Dragon Fang",
            "Spider Web",
            "Coral Fragment",
            "Curse Spike",
            "Black Hole",
            "Water Crystal",
            "Missile",
            "Mystery Fluid",
            "Running Fire",
            "Inferno Fang",
            "Malboro Tentacle",
            "Whisper",
            "Laser Cannon",
            "Barrier",
            "Power Generator",
            "Dark Matter",
            "Bomb Fragment",
            "Red Fang",
            "Arctic Wind",
            "North Wind",
            "Dynamo Stone",
            "Shear Feather",
            "Venom Fang",
            "Steel Orb",
            "Moon Stone",
            "Dino Bone",
            "Windmill",
            "Dragon Skin",
            "Fish Fin",
            "Dragon Fin",
            "Silence Powder",
            "Poison Powder",
            "Dead Spirit",
            "Chef\'s Knife",
            "Cactus Thorn",
            "Shaman Stone",
            "Fuel",
            "Girl Next Door",
            "Sorceress\' Letter",
            "Chocobo\'s Tag",
            "Pet Nametag",
            "Solomon Ring",
            "Magical Lamp",
            "Hp Up",
            "Str Up",
            "Vit Up",
            "Mag Up",
            "Spr Up",
            "Spd Up",
            "Luck Up",
            "LuvLuv G",
            "Weapons Mon 1st",
            "Weapons Mon Mar",
            "Weapons Mon Apr",
            "Weapons Mon May",
            "Weapons Mon Jun",
            "Weapons Mon Jul",
            "Weapons Mon Aug",
            "Combat King 001",
            "Combat King 002",
            "Combat King 003",
            "Combat King 004",
            "Combat King 005",
            "Pet Pals Vol.1",
            "Pet Pals Vol.2",
            "Pet Pals Vol.3",
            "Pet Pals Vol.4",
            "Pet Pals Vol.5",
            "Pet Pals Vol.6",
            "Occult Fan I",
            "Occult Fan II",
            "Occult Fan III",
            "Occult Fan IV"});
            this.comboBoxItem4.Location = new System.Drawing.Point(25, 284);
            this.comboBoxItem4.Name = "comboBoxItem4";
            this.comboBoxItem4.Size = new System.Drawing.Size(146, 23);
            this.comboBoxItem4.TabIndex = 8;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numericUpDownPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPrice.Location = new System.Drawing.Point(103, 32);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            2550,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.ReadOnly = true;
            this.numericUpDownPrice.Size = new System.Drawing.Size(51, 25);
            this.numericUpDownPrice.TabIndex = 1;
            this.numericUpDownPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.numericUpDownPrice, "Only multiple of 10s are available, use the arrows to edit the value.");
            // 
            // labelItem4
            // 
            this.labelItem4.AutoSize = true;
            this.labelItem4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.labelItem4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelItem4.Location = new System.Drawing.Point(32, 263);
            this.labelItem4.Name = "labelItem4";
            this.labelItem4.Size = new System.Drawing.Size(132, 17);
            this.labelItem4.TabIndex = 10;
            this.labelItem4.Text = "Fourth Item Needed";
            // 
            // numericUpDownQua1
            // 
            this.numericUpDownQua1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQua1.Location = new System.Drawing.Point(187, 101);
            this.numericUpDownQua1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownQua1.Name = "numericUpDownQua1";
            this.numericUpDownQua1.Size = new System.Drawing.Size(45, 25);
            this.numericUpDownQua1.TabIndex = 3;
            this.numericUpDownQua1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.numericUpDownQua1, "Needed quantity of the 1st item");
            // 
            // comboBoxItem3
            // 
            this.comboBoxItem3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxItem3.FormattingEnabled = true;
            this.comboBoxItem3.Items.AddRange(new object[] {
            "None",
            "Potion",
            "Potion+",
            "Hi-Potion",
            "Hi-Potion+",
            "X-Potion",
            "Mega-Potion",
            "Phoenix Down",
            "Mega Phoenix",
            "Elixir",
            "Megalixir",
            "Antidote",
            "Soft",
            "Eye Drops",
            "Echo Screen",
            "Holy Water",
            "Remedy",
            "Remedy+",
            "Hero-Trial",
            "Hero",
            "Holy War-Trial",
            "Holy War",
            "Shell Stone",
            "Protect Stone",
            "Aura Stone",
            "Death Stone",
            "Holy Stone",
            "Flare Stone",
            "Meteor Stone",
            "Ultima Stone",
            "Gysahl Greens",
            "Phoenix Pinion",
            "Friendship",
            "Tent",
            "Pet House",
            "Cottage",
            "G-Potion",
            "G-Hi-Potion",
            "G-Mega-Potion",
            "G-Returner",
            "Rename Card",
            "Amnesia Greens",
            "HP-J Scroll",
            "Str-J Scroll",
            "Vit-J Scroll",
            "Mag-J Scroll",
            "Spr-J Scroll",
            "Spd-J Scroll",
            "Luck-J Scroll",
            "Aegis Amulet",
            "Elem Atk",
            "Elem Guard",
            "Status Atk",
            "Status Guard",
            "Rosetta Stone",
            "Magic Scroll",
            "GF Scroll",
            "Draw Scroll",
            "Item Scroll",
            "Gambler Spirit",
            "Healing Ring",
            "Phoenix Spirit",
            "Med Kit",
            "Bomb Spirit",
            "Hungry Cookpot",
            "Mog\'s Amulet",
            "Steel Pipe",
            "Star Fragment",
            "Energy Crystal",
            "Samantha Soul",
            "Healing Mail",
            "Silver Mail",
            "Gold Armor",
            "Diamod Armor",
            "Regen Ring",
            "Giant\'s Ring",
            "Gaea\'s Ring",
            "Strength Love",
            "Power Wrist",
            "Hyper Wrist",
            "Turtle Shell",
            "Orihalcon",
            "Adamantine",
            "Rune Armlet",
            "Force Armlet",
            "Magic Armlet",
            "Circlet",
            "Hypno Crown",
            "Royal Crown",
            "Jet Engine",
            "Rocket Engine",
            "Moon Curtain",
            "Steel Curtain",
            "Glow Curtain",
            "Accelerator",
            "Monk\'s Code",
            "Knight\'s Code",
            "Doc\'s Code",
            "Hundred Needles",
            "Three Stars",
            "Ribbon",
            "Normal Ammo",
            "Shotgun Ammo",
            "Dark Ammo",
            "Fire Ammo",
            "Demolition Ammo",
            "Fast Ammo",
            "AP Ammo",
            "Pulse Ammo",
            "M-Stone Piece",
            "Magic Stone",
            "Wizard Stone",
            "Ochu Tentacle",
            "Healing Water",
            "Cockatrice Pinion",
            "Zombie Powder",
            "Lightweight",
            "Sharp Spike",
            "Screw",
            "Saw Blade",
            "Mesmerize Blade",
            "Vampire Fang",
            "Fury Fragment",
            "Betrayal Sword",
            "Sleep Powder",
            "Life Ring",
            "Dragon Fang",
            "Spider Web",
            "Coral Fragment",
            "Curse Spike",
            "Black Hole",
            "Water Crystal",
            "Missile",
            "Mystery Fluid",
            "Running Fire",
            "Inferno Fang",
            "Malboro Tentacle",
            "Whisper",
            "Laser Cannon",
            "Barrier",
            "Power Generator",
            "Dark Matter",
            "Bomb Fragment",
            "Red Fang",
            "Arctic Wind",
            "North Wind",
            "Dynamo Stone",
            "Shear Feather",
            "Venom Fang",
            "Steel Orb",
            "Moon Stone",
            "Dino Bone",
            "Windmill",
            "Dragon Skin",
            "Fish Fin",
            "Dragon Fin",
            "Silence Powder",
            "Poison Powder",
            "Dead Spirit",
            "Chef\'s Knife",
            "Cactus Thorn",
            "Shaman Stone",
            "Fuel",
            "Girl Next Door",
            "Sorceress\' Letter",
            "Chocobo\'s Tag",
            "Pet Nametag",
            "Solomon Ring",
            "Magical Lamp",
            "Hp Up",
            "Str Up",
            "Vit Up",
            "Mag Up",
            "Spr Up",
            "Spd Up",
            "Luck Up",
            "LuvLuv G",
            "Weapons Mon 1st",
            "Weapons Mon Mar",
            "Weapons Mon Apr",
            "Weapons Mon May",
            "Weapons Mon Jun",
            "Weapons Mon Jul",
            "Weapons Mon Aug",
            "Combat King 001",
            "Combat King 002",
            "Combat King 003",
            "Combat King 004",
            "Combat King 005",
            "Pet Pals Vol.1",
            "Pet Pals Vol.2",
            "Pet Pals Vol.3",
            "Pet Pals Vol.4",
            "Pet Pals Vol.5",
            "Pet Pals Vol.6",
            "Occult Fan I",
            "Occult Fan II",
            "Occult Fan III",
            "Occult Fan IV"});
            this.comboBoxItem3.Location = new System.Drawing.Point(25, 222);
            this.comboBoxItem3.Name = "comboBoxItem3";
            this.comboBoxItem3.Size = new System.Drawing.Size(146, 23);
            this.comboBoxItem3.TabIndex = 6;
            // 
            // numericUpDownQua2
            // 
            this.numericUpDownQua2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQua2.Location = new System.Drawing.Point(187, 160);
            this.numericUpDownQua2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownQua2.Name = "numericUpDownQua2";
            this.numericUpDownQua2.Size = new System.Drawing.Size(45, 25);
            this.numericUpDownQua2.TabIndex = 5;
            this.numericUpDownQua2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.numericUpDownQua2, "Needed quantity of the 2nd item");
            // 
            // labelItem3
            // 
            this.labelItem3.AutoSize = true;
            this.labelItem3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.labelItem3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelItem3.Location = new System.Drawing.Point(37, 201);
            this.labelItem3.Name = "labelItem3";
            this.labelItem3.Size = new System.Drawing.Size(122, 17);
            this.labelItem3.TabIndex = 10;
            this.labelItem3.Text = "Third Item Needed";
            // 
            // numericUpDownQua3
            // 
            this.numericUpDownQua3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQua3.Location = new System.Drawing.Point(187, 221);
            this.numericUpDownQua3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownQua3.Name = "numericUpDownQua3";
            this.numericUpDownQua3.Size = new System.Drawing.Size(45, 25);
            this.numericUpDownQua3.TabIndex = 7;
            this.numericUpDownQua3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.numericUpDownQua3, "Needed quantity of the 3rd item");
            // 
            // comboBoxItem2
            // 
            this.comboBoxItem2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxItem2.FormattingEnabled = true;
            this.comboBoxItem2.Items.AddRange(new object[] {
            "None",
            "Potion",
            "Potion+",
            "Hi-Potion",
            "Hi-Potion+",
            "X-Potion",
            "Mega-Potion",
            "Phoenix Down",
            "Mega Phoenix",
            "Elixir",
            "Megalixir",
            "Antidote",
            "Soft",
            "Eye Drops",
            "Echo Screen",
            "Holy Water",
            "Remedy",
            "Remedy+",
            "Hero-Trial",
            "Hero",
            "Holy War-Trial",
            "Holy War",
            "Shell Stone",
            "Protect Stone",
            "Aura Stone",
            "Death Stone",
            "Holy Stone",
            "Flare Stone",
            "Meteor Stone",
            "Ultima Stone",
            "Gysahl Greens",
            "Phoenix Pinion",
            "Friendship",
            "Tent",
            "Pet House",
            "Cottage",
            "G-Potion",
            "G-Hi-Potion",
            "G-Mega-Potion",
            "G-Returner",
            "Rename Card",
            "Amnesia Greens",
            "HP-J Scroll",
            "Str-J Scroll",
            "Vit-J Scroll",
            "Mag-J Scroll",
            "Spr-J Scroll",
            "Spd-J Scroll",
            "Luck-J Scroll",
            "Aegis Amulet",
            "Elem Atk",
            "Elem Guard",
            "Status Atk",
            "Status Guard",
            "Rosetta Stone",
            "Magic Scroll",
            "GF Scroll",
            "Draw Scroll",
            "Item Scroll",
            "Gambler Spirit",
            "Healing Ring",
            "Phoenix Spirit",
            "Med Kit",
            "Bomb Spirit",
            "Hungry Cookpot",
            "Mog\'s Amulet",
            "Steel Pipe",
            "Star Fragment",
            "Energy Crystal",
            "Samantha Soul",
            "Healing Mail",
            "Silver Mail",
            "Gold Armor",
            "Diamod Armor",
            "Regen Ring",
            "Giant\'s Ring",
            "Gaea\'s Ring",
            "Strength Love",
            "Power Wrist",
            "Hyper Wrist",
            "Turtle Shell",
            "Orihalcon",
            "Adamantine",
            "Rune Armlet",
            "Force Armlet",
            "Magic Armlet",
            "Circlet",
            "Hypno Crown",
            "Royal Crown",
            "Jet Engine",
            "Rocket Engine",
            "Moon Curtain",
            "Steel Curtain",
            "Glow Curtain",
            "Accelerator",
            "Monk\'s Code",
            "Knight\'s Code",
            "Doc\'s Code",
            "Hundred Needles",
            "Three Stars",
            "Ribbon",
            "Normal Ammo",
            "Shotgun Ammo",
            "Dark Ammo",
            "Fire Ammo",
            "Demolition Ammo",
            "Fast Ammo",
            "AP Ammo",
            "Pulse Ammo",
            "M-Stone Piece",
            "Magic Stone",
            "Wizard Stone",
            "Ochu Tentacle",
            "Healing Water",
            "Cockatrice Pinion",
            "Zombie Powder",
            "Lightweight",
            "Sharp Spike",
            "Screw",
            "Saw Blade",
            "Mesmerize Blade",
            "Vampire Fang",
            "Fury Fragment",
            "Betrayal Sword",
            "Sleep Powder",
            "Life Ring",
            "Dragon Fang",
            "Spider Web",
            "Coral Fragment",
            "Curse Spike",
            "Black Hole",
            "Water Crystal",
            "Missile",
            "Mystery Fluid",
            "Running Fire",
            "Inferno Fang",
            "Malboro Tentacle",
            "Whisper",
            "Laser Cannon",
            "Barrier",
            "Power Generator",
            "Dark Matter",
            "Bomb Fragment",
            "Red Fang",
            "Arctic Wind",
            "North Wind",
            "Dynamo Stone",
            "Shear Feather",
            "Venom Fang",
            "Steel Orb",
            "Moon Stone",
            "Dino Bone",
            "Windmill",
            "Dragon Skin",
            "Fish Fin",
            "Dragon Fin",
            "Silence Powder",
            "Poison Powder",
            "Dead Spirit",
            "Chef\'s Knife",
            "Cactus Thorn",
            "Shaman Stone",
            "Fuel",
            "Girl Next Door",
            "Sorceress\' Letter",
            "Chocobo\'s Tag",
            "Pet Nametag",
            "Solomon Ring",
            "Magical Lamp",
            "Hp Up",
            "Str Up",
            "Vit Up",
            "Mag Up",
            "Spr Up",
            "Spd Up",
            "Luck Up",
            "LuvLuv G",
            "Weapons Mon 1st",
            "Weapons Mon Mar",
            "Weapons Mon Apr",
            "Weapons Mon May",
            "Weapons Mon Jun",
            "Weapons Mon Jul",
            "Weapons Mon Aug",
            "Combat King 001",
            "Combat King 002",
            "Combat King 003",
            "Combat King 004",
            "Combat King 005",
            "Pet Pals Vol.1",
            "Pet Pals Vol.2",
            "Pet Pals Vol.3",
            "Pet Pals Vol.4",
            "Pet Pals Vol.5",
            "Pet Pals Vol.6",
            "Occult Fan I",
            "Occult Fan II",
            "Occult Fan III",
            "Occult Fan IV"});
            this.comboBoxItem2.Location = new System.Drawing.Point(25, 161);
            this.comboBoxItem2.Name = "comboBoxItem2";
            this.comboBoxItem2.Size = new System.Drawing.Size(146, 23);
            this.comboBoxItem2.TabIndex = 4;
            // 
            // numericUpDownQua4
            // 
            this.numericUpDownQua4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQua4.Location = new System.Drawing.Point(187, 283);
            this.numericUpDownQua4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownQua4.Name = "numericUpDownQua4";
            this.numericUpDownQua4.Size = new System.Drawing.Size(45, 25);
            this.numericUpDownQua4.TabIndex = 9;
            this.numericUpDownQua4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.numericUpDownQua4, "Needed quantity of the 4th item");
            // 
            // labelItem2
            // 
            this.labelItem2.AutoSize = true;
            this.labelItem2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.labelItem2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelItem2.Location = new System.Drawing.Point(31, 140);
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Size = new System.Drawing.Size(135, 17);
            this.labelItem2.TabIndex = 10;
            this.labelItem2.Text = "Second Item Needed";
            // 
            // labelItem1
            // 
            this.labelItem1.AutoSize = true;
            this.labelItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.labelItem1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelItem1.Location = new System.Drawing.Point(40, 81);
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Size = new System.Drawing.Size(117, 17);
            this.labelItem1.TabIndex = 10;
            this.labelItem1.Text = "First Item Needed";
            // 
            // comboBoxItem1
            // 
            this.comboBoxItem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxItem1.FormattingEnabled = true;
            this.comboBoxItem1.Items.AddRange(new object[] {
            "None",
            "Potion",
            "Potion+",
            "Hi-Potion",
            "Hi-Potion+",
            "X-Potion",
            "Mega-Potion",
            "Phoenix Down",
            "Mega Phoenix",
            "Elixir",
            "Megalixir",
            "Antidote",
            "Soft",
            "Eye Drops",
            "Echo Screen",
            "Holy Water",
            "Remedy",
            "Remedy+",
            "Hero-Trial",
            "Hero",
            "Holy War-Trial",
            "Holy War",
            "Shell Stone",
            "Protect Stone",
            "Aura Stone",
            "Death Stone",
            "Holy Stone",
            "Flare Stone",
            "Meteor Stone",
            "Ultima Stone",
            "Gysahl Greens",
            "Phoenix Pinion",
            "Friendship",
            "Tent",
            "Pet House",
            "Cottage",
            "G-Potion",
            "G-Hi-Potion",
            "G-Mega-Potion",
            "G-Returner",
            "Rename Card",
            "Amnesia Greens",
            "HP-J Scroll",
            "Str-J Scroll",
            "Vit-J Scroll",
            "Mag-J Scroll",
            "Spr-J Scroll",
            "Spd-J Scroll",
            "Luck-J Scroll",
            "Aegis Amulet",
            "Elem Atk",
            "Elem Guard",
            "Status Atk",
            "Status Guard",
            "Rosetta Stone",
            "Magic Scroll",
            "GF Scroll",
            "Draw Scroll",
            "Item Scroll",
            "Gambler Spirit",
            "Healing Ring",
            "Phoenix Spirit",
            "Med Kit",
            "Bomb Spirit",
            "Hungry Cookpot",
            "Mog\'s Amulet",
            "Steel Pipe",
            "Star Fragment",
            "Energy Crystal",
            "Samantha Soul",
            "Healing Mail",
            "Silver Mail",
            "Gold Armor",
            "Diamod Armor",
            "Regen Ring",
            "Giant\'s Ring",
            "Gaea\'s Ring",
            "Strength Love",
            "Power Wrist",
            "Hyper Wrist",
            "Turtle Shell",
            "Orihalcon",
            "Adamantine",
            "Rune Armlet",
            "Force Armlet",
            "Magic Armlet",
            "Circlet",
            "Hypno Crown",
            "Royal Crown",
            "Jet Engine",
            "Rocket Engine",
            "Moon Curtain",
            "Steel Curtain",
            "Glow Curtain",
            "Accelerator",
            "Monk\'s Code",
            "Knight\'s Code",
            "Doc\'s Code",
            "Hundred Needles",
            "Three Stars",
            "Ribbon",
            "Normal Ammo",
            "Shotgun Ammo",
            "Dark Ammo",
            "Fire Ammo",
            "Demolition Ammo",
            "Fast Ammo",
            "AP Ammo",
            "Pulse Ammo",
            "M-Stone Piece",
            "Magic Stone",
            "Wizard Stone",
            "Ochu Tentacle",
            "Healing Water",
            "Cockatrice Pinion",
            "Zombie Powder",
            "Lightweight",
            "Sharp Spike",
            "Screw",
            "Saw Blade",
            "Mesmerize Blade",
            "Vampire Fang",
            "Fury Fragment",
            "Betrayal Sword",
            "Sleep Powder",
            "Life Ring",
            "Dragon Fang",
            "Spider Web",
            "Coral Fragment",
            "Curse Spike",
            "Black Hole",
            "Water Crystal",
            "Missile",
            "Mystery Fluid",
            "Running Fire",
            "Inferno Fang",
            "Malboro Tentacle",
            "Whisper",
            "Laser Cannon",
            "Barrier",
            "Power Generator",
            "Dark Matter",
            "Bomb Fragment",
            "Red Fang",
            "Arctic Wind",
            "North Wind",
            "Dynamo Stone",
            "Shear Feather",
            "Venom Fang",
            "Steel Orb",
            "Moon Stone",
            "Dino Bone",
            "Windmill",
            "Dragon Skin",
            "Fish Fin",
            "Dragon Fin",
            "Silence Powder",
            "Poison Powder",
            "Dead Spirit",
            "Chef\'s Knife",
            "Cactus Thorn",
            "Shaman Stone",
            "Fuel",
            "Girl Next Door",
            "Sorceress\' Letter",
            "Chocobo\'s Tag",
            "Pet Nametag",
            "Solomon Ring",
            "Magical Lamp",
            "Hp Up",
            "Str Up",
            "Vit Up",
            "Mag Up",
            "Spr Up",
            "Spd Up",
            "Luck Up",
            "LuvLuv G",
            "Weapons Mon 1st",
            "Weapons Mon Mar",
            "Weapons Mon Apr",
            "Weapons Mon May",
            "Weapons Mon Jun",
            "Weapons Mon Jul",
            "Weapons Mon Aug",
            "Combat King 001",
            "Combat King 002",
            "Combat King 003",
            "Combat King 004",
            "Combat King 005",
            "Pet Pals Vol.1",
            "Pet Pals Vol.2",
            "Pet Pals Vol.3",
            "Pet Pals Vol.4",
            "Pet Pals Vol.5",
            "Pet Pals Vol.6",
            "Occult Fan I",
            "Occult Fan II",
            "Occult Fan III",
            "Occult Fan IV"});
            this.comboBoxItem1.Location = new System.Drawing.Point(25, 102);
            this.comboBoxItem1.Name = "comboBoxItem1";
            this.comboBoxItem1.Size = new System.Drawing.Size(146, 23);
            this.comboBoxItem1.TabIndex = 2;
            // 
            // labelQuantity1
            // 
            this.labelQuantity1.AutoSize = true;
            this.labelQuantity1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.labelQuantity1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelQuantity1.Location = new System.Drawing.Point(180, 81);
            this.labelQuantity1.Name = "labelQuantity1";
            this.labelQuantity1.Size = new System.Drawing.Size(61, 17);
            this.labelQuantity1.TabIndex = 10;
            this.labelQuantity1.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(180, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(180, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(180, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantity";
            // 
            // listBoxWeapons
            // 
            this.listBoxWeapons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWeapons.FormattingEnabled = true;
            this.listBoxWeapons.ItemHeight = 15;
            this.listBoxWeapons.Items.AddRange(new object[] {
            "Revolver",
            "Shear Trigger",
            "Cutting Trigger",
            "Flame Saber",
            "Twin Lance",
            "Punishment",
            "Lion Heart",
            "Metal Knuckle",
            "Maverick",
            "Gauntlet",
            "Ehrgeiz",
            "Valiant",
            "Ulysses",
            "Bismark",
            "Exeter",
            "Chain Whip",
            "Slaying Tail",
            "Red Scorpion",
            "Save the Queen",
            "Pinwheel",
            "Valkyrie",
            "Rising Sun",
            "Cardinal",
            "Shooting Star",
            "Flail",
            "Morning Star",
            "Crescent Wish",
            "Strange Vision",
            "Hyperion",
            "None",
            "Machine Gun",
            "Katal",
            "Harpoon"});
            this.listBoxWeapons.Location = new System.Drawing.Point(-1, 24);
            this.listBoxWeapons.Name = "listBoxWeapons";
            this.listBoxWeapons.ScrollAlwaysVisible = true;
            this.listBoxWeapons.Size = new System.Drawing.Size(109, 499);
            this.listBoxWeapons.TabIndex = 0;
            this.listBoxWeapons.SelectedIndexChanged += new System.EventHandler(this.listBoxWeapons_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gray;
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus,
            this.toolStripStatusLabelRightAlign,
            this.toolStripStatusLabelFile});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(364, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.BackColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripStatusLabelStatus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabelStatus.Text = "Ready";
            // 
            // toolStripStatusLabelRightAlign
            // 
            this.toolStripStatusLabelRightAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelRightAlign.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.toolStripStatusLabelRightAlign.Name = "toolStripStatusLabelRightAlign";
            this.toolStripStatusLabelRightAlign.Size = new System.Drawing.Size(229, 17);
            this.toolStripStatusLabelRightAlign.Spring = true;
            // 
            // toolStripStatusLabelFile
            // 
            this.toolStripStatusLabelFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.toolStripStatusLabelFile.Name = "toolStripStatusLabelFile";
            this.toolStripStatusLabelFile.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabelFile.Text = "No file loaded";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(-5, -16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 41);
            this.panel2.TabIndex = 26;
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(364, 544);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBoxWeapons);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JunkShop 1.0c";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelObjects.ResumeLayout(false);
            this.panelObjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQua4)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxItem4;
        private System.Windows.Forms.Label labelItem4;
        private System.Windows.Forms.ComboBox comboBoxItem3;
        private System.Windows.Forms.Label labelItem3;
        private System.Windows.Forms.ComboBox comboBoxItem2;
        private System.Windows.Forms.Label labelItem2;
        private System.Windows.Forms.ComboBox comboBoxItem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelQuantity1;
        private System.Windows.Forms.Label labelItem1;
        private System.Windows.Forms.NumericUpDown numericUpDownQua4;
        private System.Windows.Forms.NumericUpDown numericUpDownQua3;
        private System.Windows.Forms.NumericUpDown numericUpDownQua2;
        private System.Windows.Forms.NumericUpDown numericUpDownQua1;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ListBox listBoxWeapons;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRightAlign;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelObjects;
    }
}

