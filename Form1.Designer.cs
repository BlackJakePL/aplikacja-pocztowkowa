namespace aplikacja_pocztowkowa
{
    partial class Aplikacja_pocztowkowa
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplikacja_pocztowkowa));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbSenderSurname = new System.Windows.Forms.TextBox();
            this.tbSenderName = new System.Windows.Forms.TextBox();
            this.tbWishes = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioThird = new System.Windows.Forms.RadioButton();
            this.radioSecond = new System.Windows.Forms.RadioButton();
            this.radioFirst = new System.Windows.Forms.RadioButton();
            this.lbFrame = new System.Windows.Forms.Label();
            this.lbFileLocal = new System.Windows.Forms.Label();
            this.lbLocal = new System.Windows.Forms.Label();
            this.btnImageChoice = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.lbImage = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FlagFile = new System.Windows.Forms.Label();
            this.flagFont = new System.Windows.Forms.Label();
            this.flagPhoto = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbReceiver = new System.Windows.Forms.GroupBox();
            this.tbReceiverPost = new System.Windows.Forms.TextBox();
            this.tbReceiverStreet = new System.Windows.Forms.TextBox();
            this.tbReceiverSurname = new System.Windows.Forms.TextBox();
            this.tbReceiverTitle = new System.Windows.Forms.TextBox();
            this.tbReceiverName = new System.Windows.Forms.TextBox();
            this.gbSender = new System.Windows.Forms.GroupBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbReceiver.SuspendLayout();
            this.gbSender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(36, 161);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(148, 26);
            this.dateTimePicker.TabIndex = 4;
            // 
            // tbCity
            // 
            this.tbCity.AllowDrop = true;
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbCity.Location = new System.Drawing.Point(36, 113);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(148, 26);
            this.tbCity.TabIndex = 2;
            this.tbCity.Text = "Miejscowość";
            this.tbCity.Enter += new System.EventHandler(this.tbCity_Enter);
            this.tbCity.Leave += new System.EventHandler(this.tbCity_Leave);
            // 
            // tbSenderSurname
            // 
            this.tbSenderSurname.AllowDrop = true;
            this.tbSenderSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSenderSurname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbSenderSurname.Location = new System.Drawing.Point(36, 71);
            this.tbSenderSurname.Name = "tbSenderSurname";
            this.tbSenderSurname.Size = new System.Drawing.Size(148, 26);
            this.tbSenderSurname.TabIndex = 1;
            this.tbSenderSurname.Text = "Nazwisko";
            this.tbSenderSurname.Enter += new System.EventHandler(this.tbSenderSurname_Enter);
            this.tbSenderSurname.Leave += new System.EventHandler(this.tbSenderSurname_Leave);
            // 
            // tbSenderName
            // 
            this.tbSenderName.AllowDrop = true;
            this.tbSenderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSenderName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbSenderName.Location = new System.Drawing.Point(36, 28);
            this.tbSenderName.Name = "tbSenderName";
            this.tbSenderName.Size = new System.Drawing.Size(148, 26);
            this.tbSenderName.TabIndex = 0;
            this.tbSenderName.Text = "Imie";
            this.tbSenderName.Enter += new System.EventHandler(this.tbSenderName_Enter);
            this.tbSenderName.Leave += new System.EventHandler(this.tbSenderName_Leave);
            // 
            // tbWishes
            // 
            this.tbWishes.AllowDrop = true;
            this.tbWishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbWishes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbWishes.Location = new System.Drawing.Point(36, 204);
            this.tbWishes.Multiline = true;
            this.tbWishes.Name = "tbWishes";
            this.tbWishes.Size = new System.Drawing.Size(250, 131);
            this.tbWishes.TabIndex = 3;
            this.tbWishes.Text = "Życzenia...";
            this.tbWishes.Enter += new System.EventHandler(this.tbWishes_Enter);
            this.tbWishes.Leave += new System.EventHandler(this.tbWishes_Leave);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(955, 639);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.radioThird);
            this.tabPage1.Controls.Add(this.radioSecond);
            this.tabPage1.Controls.Add(this.radioFirst);
            this.tabPage1.Controls.Add(this.lbFrame);
            this.tabPage1.Controls.Add(this.lbFileLocal);
            this.tabPage1.Controls.Add(this.lbLocal);
            this.tabPage1.Controls.Add(this.btnImageChoice);
            this.tabPage1.Controls.Add(this.pbPhoto);
            this.tabPage1.Controls.Add(this.lbImage);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 613);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Awers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(578, 275);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(578, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(578, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // radioThird
            // 
            this.radioThird.AutoSize = true;
            this.radioThird.Location = new System.Drawing.Point(842, 301);
            this.radioThird.Name = "radioThird";
            this.radioThird.Size = new System.Drawing.Size(14, 13);
            this.radioThird.TabIndex = 11;
            this.radioThird.TabStop = true;
            this.radioThird.UseVisualStyleBackColor = true;
            // 
            // radioSecond
            // 
            this.radioSecond.AutoSize = true;
            this.radioSecond.Location = new System.Drawing.Point(842, 202);
            this.radioSecond.Name = "radioSecond";
            this.radioSecond.Size = new System.Drawing.Size(14, 13);
            this.radioSecond.TabIndex = 10;
            this.radioSecond.TabStop = true;
            this.radioSecond.UseVisualStyleBackColor = true;
            // 
            // radioFirst
            // 
            this.radioFirst.AutoSize = true;
            this.radioFirst.Location = new System.Drawing.Point(842, 94);
            this.radioFirst.Name = "radioFirst";
            this.radioFirst.Size = new System.Drawing.Size(14, 13);
            this.radioFirst.TabIndex = 9;
            this.radioFirst.TabStop = true;
            this.radioFirst.UseVisualStyleBackColor = true;
            // 
            // lbFrame
            // 
            this.lbFrame.AutoSize = true;
            this.lbFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbFrame.Location = new System.Drawing.Point(574, 23);
            this.lbFrame.Name = "lbFrame";
            this.lbFrame.Size = new System.Drawing.Size(187, 20);
            this.lbFrame.TabIndex = 5;
            this.lbFrame.Text = "Wybierz ramke pocztowki";
            // 
            // lbFileLocal
            // 
            this.lbFileLocal.AutoSize = true;
            this.lbFileLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbFileLocal.Location = new System.Drawing.Point(129, 363);
            this.lbFileLocal.Name = "lbFileLocal";
            this.lbFileLocal.Size = new System.Drawing.Size(21, 20);
            this.lbFileLocal.TabIndex = 4;
            this.lbFileLocal.Text = "...";
            // 
            // lbLocal
            // 
            this.lbLocal.AutoSize = true;
            this.lbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLocal.Location = new System.Drawing.Point(34, 363);
            this.lbLocal.Name = "lbLocal";
            this.lbLocal.Size = new System.Drawing.Size(95, 20);
            this.lbLocal.TabIndex = 3;
            this.lbLocal.Text = "Lokalizacja: ";
            // 
            // btnImageChoice
            // 
            this.btnImageChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnImageChoice.Location = new System.Drawing.Point(133, 275);
            this.btnImageChoice.Name = "btnImageChoice";
            this.btnImageChoice.Size = new System.Drawing.Size(148, 67);
            this.btnImageChoice.TabIndex = 2;
            this.btnImageChoice.Text = "Wybierz obraz";
            this.btnImageChoice.UseVisualStyleBackColor = true;
            this.btnImageChoice.Click += new System.EventHandler(this.btnImageChoice_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.Image = global::aplikacja_pocztowkowa.Properties.Resources.nophotoimgpng;
            this.pbPhoto.Location = new System.Drawing.Point(37, 57);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(357, 212);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 1;
            this.pbPhoto.TabStop = false;
            // 
            // lbImage
            // 
            this.lbImage.AutoSize = true;
            this.lbImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbImage.Location = new System.Drawing.Point(33, 23);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(361, 20);
            this.lbImage.TabIndex = 0;
            this.lbImage.Text = "Wybierz zdjeci znajdujace sie na froncie pocztowki";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.FlagFile);
            this.tabPage2.Controls.Add(this.flagFont);
            this.tabPage2.Controls.Add(this.flagPhoto);
            this.tabPage2.Controls.Add(this.btnCreate);
            this.tabPage2.Controls.Add(this.btnSaveFile);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.gbReceiver);
            this.tabPage2.Controls.Add(this.gbSender);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(947, 613);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rewers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FlagFile
            // 
            this.FlagFile.AutoSize = true;
            this.FlagFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlagFile.Location = new System.Drawing.Point(708, 460);
            this.FlagFile.Name = "FlagFile";
            this.FlagFile.Size = new System.Drawing.Size(151, 20);
            this.FlagFile.TabIndex = 17;
            this.FlagFile.Text = "Wybierz nazwe pliku";
            // 
            // flagFont
            // 
            this.flagFont.AutoSize = true;
            this.flagFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorProvider1.SetIconAlignment(this.flagFont, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.flagFont.Location = new System.Drawing.Point(708, 440);
            this.flagFont.Name = "flagFont";
            this.flagFont.Size = new System.Drawing.Size(131, 20);
            this.flagFont.TabIndex = 16;
            this.flagFont.Text = "Wybierz czcionke";
            // 
            // flagPhoto
            // 
            this.flagPhoto.AutoSize = true;
            this.flagPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flagPhoto.Location = new System.Drawing.Point(708, 420);
            this.flagPhoto.Name = "flagPhoto";
            this.flagPhoto.Size = new System.Drawing.Size(93, 20);
            this.flagPhoto.TabIndex = 15;
            this.flagPhoto.Text = "Wybierz zdj ";
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(495, 419);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(167, 56);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Zapisz pocztowke";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveFile.ForeColor = System.Drawing.Color.Black;
            this.btnSaveFile.Location = new System.Drawing.Point(229, 419);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(167, 56);
            this.btnSaveFile.TabIndex = 13;
            this.btnSaveFile.Text = "Wybierz miejsce zapisu";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(56, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 56);
            this.button1.TabIndex = 12;
            this.button1.Text = "Wybierz czcionke";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbReceiver
            // 
            this.gbReceiver.Controls.Add(this.tbReceiverPost);
            this.gbReceiver.Controls.Add(this.tbReceiverStreet);
            this.gbReceiver.Controls.Add(this.tbReceiverSurname);
            this.gbReceiver.Controls.Add(this.tbReceiverTitle);
            this.gbReceiver.Controls.Add(this.tbReceiverName);
            this.gbReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbReceiver.Location = new System.Drawing.Point(468, 20);
            this.gbReceiver.Name = "gbReceiver";
            this.gbReceiver.Size = new System.Drawing.Size(436, 393);
            this.gbReceiver.TabIndex = 11;
            this.gbReceiver.TabStop = false;
            this.gbReceiver.Text = "Odbiorca";
            // 
            // tbReceiverPost
            // 
            this.tbReceiverPost.AllowDrop = true;
            this.tbReceiverPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbReceiverPost.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbReceiverPost.Location = new System.Drawing.Point(46, 212);
            this.tbReceiverPost.Name = "tbReceiverPost";
            this.tbReceiverPost.Size = new System.Drawing.Size(148, 26);
            this.tbReceiverPost.TabIndex = 9;
            this.tbReceiverPost.Text = "Kod Poczta";
            this.tbReceiverPost.Enter += new System.EventHandler(this.tbReceiverPost_Enter);
            this.tbReceiverPost.Leave += new System.EventHandler(this.tbReceiverPost_Leave);
            // 
            // tbReceiverStreet
            // 
            this.tbReceiverStreet.AllowDrop = true;
            this.tbReceiverStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbReceiverStreet.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbReceiverStreet.Location = new System.Drawing.Point(46, 164);
            this.tbReceiverStreet.Name = "tbReceiverStreet";
            this.tbReceiverStreet.Size = new System.Drawing.Size(148, 26);
            this.tbReceiverStreet.TabIndex = 7;
            this.tbReceiverStreet.Text = "Ulica/Miejscowość nr";
            this.tbReceiverStreet.Enter += new System.EventHandler(this.tbReceiverStreet_Enter);
            this.tbReceiverStreet.Leave += new System.EventHandler(this.tbReceiverStreet_Leave);
            // 
            // tbReceiverSurname
            // 
            this.tbReceiverSurname.AllowDrop = true;
            this.tbReceiverSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbReceiverSurname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbReceiverSurname.Location = new System.Drawing.Point(46, 122);
            this.tbReceiverSurname.Name = "tbReceiverSurname";
            this.tbReceiverSurname.Size = new System.Drawing.Size(148, 26);
            this.tbReceiverSurname.TabIndex = 6;
            this.tbReceiverSurname.Text = "Nazwisko";
            this.tbReceiverSurname.Enter += new System.EventHandler(this.tbReceiverSurname_Enter);
            this.tbReceiverSurname.Leave += new System.EventHandler(this.tbReceiverSurname_Leave);
            // 
            // tbReceiverTitle
            // 
            this.tbReceiverTitle.AllowDrop = true;
            this.tbReceiverTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbReceiverTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbReceiverTitle.Location = new System.Drawing.Point(46, 36);
            this.tbReceiverTitle.Name = "tbReceiverTitle";
            this.tbReceiverTitle.Size = new System.Drawing.Size(148, 26);
            this.tbReceiverTitle.TabIndex = 8;
            this.tbReceiverTitle.Text = "Przedrostek";
            this.tbReceiverTitle.Enter += new System.EventHandler(this.tbReceiverTitle_Enter);
            this.tbReceiverTitle.Leave += new System.EventHandler(this.tbReceiverTitle_Leave);
            // 
            // tbReceiverName
            // 
            this.tbReceiverName.AllowDrop = true;
            this.tbReceiverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbReceiverName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbReceiverName.Location = new System.Drawing.Point(46, 79);
            this.tbReceiverName.Name = "tbReceiverName";
            this.tbReceiverName.Size = new System.Drawing.Size(148, 26);
            this.tbReceiverName.TabIndex = 5;
            this.tbReceiverName.Text = "Imie";
            this.tbReceiverName.Enter += new System.EventHandler(this.tbReceiverName_Enter);
            this.tbReceiverName.Leave += new System.EventHandler(this.tbReceiverName_Leave);
            // 
            // gbSender
            // 
            this.gbSender.Controls.Add(this.tbCity);
            this.gbSender.Controls.Add(this.tbSenderSurname);
            this.gbSender.Controls.Add(this.tbSenderName);
            this.gbSender.Controls.Add(this.dateTimePicker);
            this.gbSender.Controls.Add(this.tbWishes);
            this.gbSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbSender.Location = new System.Drawing.Point(20, 20);
            this.gbSender.Name = "gbSender";
            this.gbSender.Size = new System.Drawing.Size(436, 393);
            this.gbSender.TabIndex = 10;
            this.gbSender.TabStop = false;
            this.gbSender.Text = "Adresat";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Aplikacja_pocztowkowa
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 640);
            this.Controls.Add(this.tabControl1);
            this.Name = "Aplikacja_pocztowkowa";
            this.Text = "Aplikacja pocztowkowa";
            this.Load += new System.EventHandler(this.Aplikacja_pocztowkowa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbReceiver.ResumeLayout(false);
            this.gbReceiver.PerformLayout();
            this.gbSender.ResumeLayout(false);
            this.gbSender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbSenderSurname;
        private System.Windows.Forms.TextBox tbSenderName;
        private System.Windows.Forms.TextBox tbWishes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbReceiverPost;
        private System.Windows.Forms.TextBox tbReceiverTitle;
        private System.Windows.Forms.TextBox tbReceiverName;
        private System.Windows.Forms.TextBox tbReceiverSurname;
        private System.Windows.Forms.TextBox tbReceiverStreet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbReceiver;
        private System.Windows.Forms.GroupBox gbSender;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lbImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnImageChoice;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label lbLocal;
        private System.Windows.Forms.Label lbFileLocal;
        private System.Windows.Forms.RadioButton radioThird;
        private System.Windows.Forms.RadioButton radioSecond;
        private System.Windows.Forms.RadioButton radioFirst;
        private System.Windows.Forms.Label lbFrame;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FlagFile;
        private System.Windows.Forms.Label flagFont;
        private System.Windows.Forms.Label flagPhoto;
        private System.Windows.Forms.Button button2;
    }
}

