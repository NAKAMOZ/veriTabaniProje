namespace proje
{
    partial class anaSayfa
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.danisanlar = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vucutKiEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idelalKilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekleButon = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.yenileButon = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.aramaButon = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            this.projeDataSet = new proje.projeDataSet();
            this.danisanlarTableAdapter = new proje.projeDataSetTableAdapters.danisanlarTableAdapter();
            this.arama = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.sayfaNo = new System.Windows.Forms.Label();
            this.ileri = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.geri = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.danisanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 10;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Width = 1;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // danisanlar
            // 
            this.danisanlar.AllowUserToAddRows = false;
            this.danisanlar.AllowUserToDeleteRows = false;
            this.danisanlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.danisanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danisanlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.danisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danisanlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ad,
            this.cinsiyet,
            this.yas,
            this.Boy,
            this.kilo,
            this.email,
            this.phone,
            this.adress,
            this.vucutKiEn,
            this.idelalKilo});
            this.danisanlar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.danisanlar.Location = new System.Drawing.Point(0, 114);
            this.danisanlar.Margin = new System.Windows.Forms.Padding(0);
            this.danisanlar.Name = "danisanlar";
            this.danisanlar.Palette = this.kryptonPalette1;
            this.danisanlar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.danisanlar.ReadOnly = true;
            this.danisanlar.RowHeadersWidth = 28;
            this.danisanlar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.danisanlar.Size = new System.Drawing.Size(1264, 512);
            this.danisanlar.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.danisanlar.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.danisanlar.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.danisanlar.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.danisanlar.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.danisanlar.StateCommon.DataCell.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.danisanlar.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.danisanlar.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.danisanlar.StateCommon.DataCell.Border.ColorAngle = 90F;
            this.danisanlar.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.danisanlar.StateCommon.DataCell.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.danisanlar.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.danisanlar.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.danisanlar.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Quicksand SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.danisanlar.StateCommon.DataCell.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.danisanlar.StateCommon.DataCell.Content.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.danisanlar.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.danisanlar.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(152)))));
            this.danisanlar.StateCommon.HeaderColumn.Back.ColorAngle = 80F;
            this.danisanlar.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.danisanlar.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.danisanlar.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.danisanlar.StateCommon.HeaderColumn.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.danisanlar.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.danisanlar.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.danisanlar.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.danisanlar.StateCommon.HeaderColumn.Content.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.danisanlar.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.danisanlar.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(152)))));
            this.danisanlar.StateCommon.HeaderRow.Back.ColorAngle = 80F;
            this.danisanlar.StatePressed.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.danisanlar.StatePressed.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(152)))));
            this.danisanlar.StatePressed.HeaderColumn.Back.ColorAngle = 80F;
            this.danisanlar.StatePressed.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.danisanlar.StatePressed.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.danisanlar.StateSelected.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.danisanlar.StateSelected.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(152)))));
            this.danisanlar.StateSelected.HeaderColumn.Back.ColorAngle = 80F;
            this.danisanlar.TabIndex = 0;
            this.danisanlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danisanlar_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ad
            // 
            this.ad.DataPropertyName = "ad";
            this.ad.HeaderText = "Ad";
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            // 
            // cinsiyet
            // 
            this.cinsiyet.DataPropertyName = "column1";
            this.cinsiyet.HeaderText = "Cinsiyet";
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.ReadOnly = true;
            // 
            // yas
            // 
            this.yas.DataPropertyName = "yas";
            this.yas.HeaderText = "Yaş";
            this.yas.Name = "yas";
            this.yas.ReadOnly = true;
            // 
            // Boy
            // 
            this.Boy.DataPropertyName = "boy";
            this.Boy.HeaderText = "Boy";
            this.Boy.Name = "Boy";
            this.Boy.ReadOnly = true;
            // 
            // kilo
            // 
            this.kilo.DataPropertyName = "kilo";
            this.kilo.HeaderText = "Kilo";
            this.kilo.Name = "kilo";
            this.kilo.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "mail";
            this.email.HeaderText = "E-Mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Telefon Numarası";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // adress
            // 
            this.adress.DataPropertyName = "adres";
            this.adress.HeaderText = "Adres";
            this.adress.Name = "adress";
            this.adress.ReadOnly = true;
            // 
            // vucutKiEn
            // 
            this.vucutKiEn.DataPropertyName = "vucutKiEn";
            this.vucutKiEn.HeaderText = "Vücut Kitle Endeksi";
            this.vucutKiEn.Name = "vucutKiEn";
            this.vucutKiEn.ReadOnly = true;
            // 
            // idelalKilo
            // 
            this.idelalKilo.DataPropertyName = "idealKilo";
            this.idelalKilo.HeaderText = "İdeal Kilo";
            this.idelalKilo.Name = "idelalKilo";
            this.idelalKilo.ReadOnly = true;
            // 
            // ekleButon
            // 
            this.ekleButon.Location = new System.Drawing.Point(19, 19);
            this.ekleButon.Margin = new System.Windows.Forms.Padding(10, 10, 40, 3);
            this.ekleButon.Name = "ekleButon";
            this.ekleButon.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.ekleButon.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.ekleButon.OverrideDefault.Back.ColorAngle = 45F;
            this.ekleButon.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.ekleButon.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.ekleButon.OverrideDefault.Border.ColorAngle = 135F;
            this.ekleButon.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ekleButon.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ekleButon.OverrideDefault.Border.Rounding = 10;
            this.ekleButon.OverrideDefault.Border.Width = 1;
            this.ekleButon.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ekleButon.Size = new System.Drawing.Size(57, 57);
            this.ekleButon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.ekleButon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.ekleButon.StateCommon.Back.ColorAngle = 45F;
            this.ekleButon.StateCommon.Back.Image = global::proje.Properties.Resources.ekle;
            this.ekleButon.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.ekleButon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.ekleButon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.ekleButon.StateCommon.Border.ColorAngle = 135F;
            this.ekleButon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ekleButon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ekleButon.StateCommon.Border.Rounding = 10;
            this.ekleButon.StateCommon.Border.Width = 1;
            this.ekleButon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ekleButon.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ekleButon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleButon.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.ekleButon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(152)))));
            this.ekleButon.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.ekleButon.StatePressed.Back.ColorAngle = 45F;
            this.ekleButon.TabIndex = 5;
            this.ekleButon.Values.Text = "";
            this.ekleButon.Click += new System.EventHandler(this.ekleButon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(19, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "EKLE";
            // 
            // yenileButon
            // 
            this.yenileButon.Location = new System.Drawing.Point(119, 19);
            this.yenileButon.Margin = new System.Windows.Forms.Padding(3, 10, 40, 3);
            this.yenileButon.Name = "yenileButon";
            this.yenileButon.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.yenileButon.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.yenileButon.OverrideDefault.Back.ColorAngle = 45F;
            this.yenileButon.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.yenileButon.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.yenileButon.OverrideDefault.Border.ColorAngle = 135F;
            this.yenileButon.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.yenileButon.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.yenileButon.OverrideDefault.Border.Rounding = 10;
            this.yenileButon.OverrideDefault.Border.Width = 1;
            this.yenileButon.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.yenileButon.Size = new System.Drawing.Size(57, 57);
            this.yenileButon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.yenileButon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.yenileButon.StateCommon.Back.ColorAngle = 45F;
            this.yenileButon.StateCommon.Back.Image = global::proje.Properties.Resources.yenile;
            this.yenileButon.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.yenileButon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.yenileButon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.yenileButon.StateCommon.Border.ColorAngle = 135F;
            this.yenileButon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.yenileButon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.yenileButon.StateCommon.Border.Rounding = 10;
            this.yenileButon.StateCommon.Border.Width = 1;
            this.yenileButon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.yenileButon.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.yenileButon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenileButon.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.yenileButon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(152)))));
            this.yenileButon.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.yenileButon.StatePressed.Back.ColorAngle = 45F;
            this.yenileButon.TabIndex = 9;
            this.yenileButon.Values.Text = "";
            this.yenileButon.Click += new System.EventHandler(this.yenileButon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Quicksand SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.label3.Location = new System.Drawing.Point(112, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "YENİLE";
            // 
            // aramaButon
            // 
            this.aramaButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aramaButon.Location = new System.Drawing.Point(1188, 29);
            this.aramaButon.Margin = new System.Windows.Forms.Padding(3, 10, 40, 3);
            this.aramaButon.Name = "aramaButon";
            this.aramaButon.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.aramaButon.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.aramaButon.OverrideDefault.Back.ColorAngle = 45F;
            this.aramaButon.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.aramaButon.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.aramaButon.OverrideDefault.Border.ColorAngle = 135F;
            this.aramaButon.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.aramaButon.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.aramaButon.OverrideDefault.Border.Rounding = 10;
            this.aramaButon.OverrideDefault.Border.Width = 1;
            this.aramaButon.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.aramaButon.Size = new System.Drawing.Size(57, 57);
            this.aramaButon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.aramaButon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.aramaButon.StateCommon.Back.ColorAngle = 45F;
            this.aramaButon.StateCommon.Back.Image = global::proje.Properties.Resources.ara;
            this.aramaButon.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.aramaButon.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.aramaButon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.aramaButon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.aramaButon.StateCommon.Border.ColorAngle = 135F;
            this.aramaButon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.aramaButon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.aramaButon.StateCommon.Border.Rounding = 10;
            this.aramaButon.StateCommon.Border.Width = 1;
            this.aramaButon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.aramaButon.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.aramaButon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaButon.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.aramaButon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(152)))));
            this.aramaButon.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.aramaButon.StatePressed.Back.ColorAngle = 45F;
            this.aramaButon.TabIndex = 11;
            this.aramaButon.Values.Text = "";
            this.aramaButon.Click += new System.EventHandler(this.aramaButon_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Quicksand SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.label4.Location = new System.Drawing.Point(771, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 40);
            this.label4.TabIndex = 12;
            this.label4.Text = "ARAMA";
            // 
            // projeDataSet
            // 
            this.projeDataSet.DataSetName = "projeDataSet";
            this.projeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danisanlarTableAdapter
            // 
            this.danisanlarTableAdapter.ClearBeforeFill = true;
            // 
            // arama
            // 
            this.arama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.arama.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.arama.Location = new System.Drawing.Point(882, 29);
            this.arama.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(300, 57);
            this.arama.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.arama.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.arama.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.arama.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.arama.StateCommon.Border.Rounding = 10;
            this.arama.StateCommon.Border.Width = 1;
            this.arama.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.arama.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.arama.TabIndex = 13;
            this.arama.Tag = "";
            this.arama.Text = "Arayacağınız Kişinin Adını Ve Ya ID\'sini Giriniz";
            this.arama.Enter += new System.EventHandler(this.arama_Enter);
            this.arama.Leave += new System.EventHandler(this.arama_Leave);
            // 
            // sayfaNo
            // 
            this.sayfaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sayfaNo.AutoSize = true;
            this.sayfaNo.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayfaNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.sayfaNo.Location = new System.Drawing.Point(1089, 641);
            this.sayfaNo.Name = "sayfaNo";
            this.sayfaNo.Size = new System.Drawing.Size(84, 23);
            this.sayfaNo.TabIndex = 14;
            this.sayfaNo.Text = "Sayfa 0/0";
            // 
            // ileri
            // 
            this.ileri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ileri.Location = new System.Drawing.Point(1186, 636);
            this.ileri.Margin = new System.Windows.Forms.Padding(10, 10, 40, 3);
            this.ileri.Name = "ileri";
            this.ileri.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.ileri.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.ileri.OverrideDefault.Back.ColorAngle = 45F;
            this.ileri.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.ileri.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.ileri.OverrideDefault.Border.ColorAngle = 135F;
            this.ileri.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ileri.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ileri.OverrideDefault.Border.Rounding = 10;
            this.ileri.OverrideDefault.Border.Width = 1;
            this.ileri.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ileri.Size = new System.Drawing.Size(52, 33);
            this.ileri.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.ileri.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.ileri.StateCommon.Back.ColorAngle = 45F;
            this.ileri.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.ileri.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.ileri.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.ileri.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.ileri.StateCommon.Border.ColorAngle = 135F;
            this.ileri.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ileri.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ileri.StateCommon.Border.Rounding = 10;
            this.ileri.StateCommon.Border.Width = 1;
            this.ileri.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ileri.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ileri.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ileri.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.ileri.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(152)))));
            this.ileri.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.ileri.StatePressed.Back.ColorAngle = 45F;
            this.ileri.TabIndex = 15;
            this.ileri.Values.Text = ">";
            this.ileri.Click += new System.EventHandler(this.ileri_Click);
            // 
            // geri
            // 
            this.geri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.geri.Location = new System.Drawing.Point(1024, 636);
            this.geri.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.geri.Name = "geri";
            this.geri.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.geri.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.geri.OverrideDefault.Back.ColorAngle = 45F;
            this.geri.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.geri.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.geri.OverrideDefault.Border.ColorAngle = 135F;
            this.geri.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.geri.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.geri.OverrideDefault.Border.Rounding = 10;
            this.geri.OverrideDefault.Border.Width = 1;
            this.geri.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.geri.Size = new System.Drawing.Size(52, 33);
            this.geri.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(60)))), ((int)(((byte)(252)))));
            this.geri.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.geri.StateCommon.Back.ColorAngle = 45F;
            this.geri.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.geri.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.geri.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.geri.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.geri.StateCommon.Border.ColorAngle = 135F;
            this.geri.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.geri.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.geri.StateCommon.Border.Rounding = 10;
            this.geri.StateCommon.Border.Width = 1;
            this.geri.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.geri.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.geri.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.geri.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(152)))));
            this.geri.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(229)))));
            this.geri.StatePressed.Back.ColorAngle = 45F;
            this.geri.TabIndex = 16;
            this.geri.Values.Text = "<";
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // anaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.ileri);
            this.Controls.Add(this.sayfaNo);
            this.Controls.Add(this.arama);
            this.Controls.Add(this.aramaButon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yenileButon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.danisanlar);
            this.Controls.Add(this.ekleButon);
            this.Controls.Add(this.label1);
            this.Name = "anaSayfa";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diyetisyen Takip Sistemi";
            this.Load += new System.EventHandler(this.anaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danisanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView danisanlar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ekleButon;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton yenileButon;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton aramaButon;
        private System.Windows.Forms.Label label4;
        private projeDataSet projeDataSet;
        private projeDataSetTableAdapters.danisanlarTableAdapter danisanlarTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox arama;
        private System.Windows.Forms.Label sayfaNo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ileri;
        private ComponentFactory.Krypton.Toolkit.KryptonButton geri;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn yas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boy;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn vucutKiEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idelalKilo;
    }
}