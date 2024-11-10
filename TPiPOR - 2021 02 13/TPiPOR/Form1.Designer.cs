namespace TPiPOR
{
	partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dopasowanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.jasnośćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ściemnijToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rozjaśnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koloryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocieplenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oziębienieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.skalaSzarościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czarnoBiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czbZWyrównaniemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czbiaFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodaTestowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.jasnośćToolStripMenuItem,
            this.koloryToolStripMenuItem,
            this.filtryToolStripMenuItem,
            this.zamknijToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardowyToolStripMenuItem,
            this.dopasowanyToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripSeparator2,
            this.xToolStripMenuItem,
            this.xToolStripMenuItem1,
            this.xToolStripMenuItem2});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // standardowyToolStripMenuItem
            // 
            this.standardowyToolStripMenuItem.Name = "standardowyToolStripMenuItem";
            this.standardowyToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.standardowyToolStripMenuItem.Text = "Standardowy";
            this.standardowyToolStripMenuItem.Click += new System.EventHandler(this.standardowyToolStripMenuItem_Click);
            // 
            // dopasowanyToolStripMenuItem
            // 
            this.dopasowanyToolStripMenuItem.Name = "dopasowanyToolStripMenuItem";
            this.dopasowanyToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.dopasowanyToolStripMenuItem.Text = "Dopasowany";
            this.dopasowanyToolStripMenuItem.Click += new System.EventHandler(this.dopasowanyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem2.Text = "1 : 2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem3.Text = "1 : 4";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem4.Text = "1 : 8";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.xToolStripMenuItem.Text = "2 x";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem1
            // 
            this.xToolStripMenuItem1.Name = "xToolStripMenuItem1";
            this.xToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.xToolStripMenuItem1.Text = "4 x";
            // 
            // xToolStripMenuItem2
            // 
            this.xToolStripMenuItem2.Name = "xToolStripMenuItem2";
            this.xToolStripMenuItem2.Size = new System.Drawing.Size(143, 22);
            this.xToolStripMenuItem2.Text = "8 x";
            // 
            // jasnośćToolStripMenuItem
            // 
            this.jasnośćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ściemnijToolStripMenuItem1,
            this.rozjaśnijToolStripMenuItem});
            this.jasnośćToolStripMenuItem.Name = "jasnośćToolStripMenuItem";
            this.jasnośćToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.jasnośćToolStripMenuItem.Text = "Jasność";
            // 
            // ściemnijToolStripMenuItem1
            // 
            this.ściemnijToolStripMenuItem1.Name = "ściemnijToolStripMenuItem1";
            this.ściemnijToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.ściemnijToolStripMenuItem1.Text = "Ściemnij";
            this.ściemnijToolStripMenuItem1.Click += new System.EventHandler(this.ściemnijToolStripMenuItem1_Click);
            // 
            // rozjaśnijToolStripMenuItem
            // 
            this.rozjaśnijToolStripMenuItem.Name = "rozjaśnijToolStripMenuItem";
            this.rozjaśnijToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.rozjaśnijToolStripMenuItem.Text = "Rozjaśnij";
            this.rozjaśnijToolStripMenuItem.Click += new System.EventHandler(this.rozjaśnijToolStripMenuItem_Click);
            // 
            // koloryToolStripMenuItem
            // 
            this.koloryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ocieplenieToolStripMenuItem,
            this.oziębienieToolStripMenuItem,
            this.toolStripSeparator3,
            this.skalaSzarościToolStripMenuItem,
            this.czarnoBiaToolStripMenuItem,
            this.czbZWyrównaniemToolStripMenuItem,
            this.czbiaFSToolStripMenuItem});
            this.koloryToolStripMenuItem.Name = "koloryToolStripMenuItem";
            this.koloryToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.koloryToolStripMenuItem.Text = "Kolory";
            // 
            // ocieplenieToolStripMenuItem
            // 
            this.ocieplenieToolStripMenuItem.Name = "ocieplenieToolStripMenuItem";
            this.ocieplenieToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ocieplenieToolStripMenuItem.Text = "Ocieplenie";
            this.ocieplenieToolStripMenuItem.Click += new System.EventHandler(this.ocieplenieToolStripMenuItem_Click);
            // 
            // oziębienieToolStripMenuItem
            // 
            this.oziębienieToolStripMenuItem.Name = "oziębienieToolStripMenuItem";
            this.oziębienieToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.oziębienieToolStripMenuItem.Text = "Oziębienie";
            this.oziębienieToolStripMenuItem.Click += new System.EventHandler(this.oziębienieToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(182, 6);
            // 
            // skalaSzarościToolStripMenuItem
            // 
            this.skalaSzarościToolStripMenuItem.Name = "skalaSzarościToolStripMenuItem";
            this.skalaSzarościToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.skalaSzarościToolStripMenuItem.Text = "Skala szarości";
            this.skalaSzarościToolStripMenuItem.Click += new System.EventHandler(this.skalaSzarościToolStripMenuItem_Click);
            // 
            // czarnoBiaToolStripMenuItem
            // 
            this.czarnoBiaToolStripMenuItem.Name = "czarnoBiaToolStripMenuItem";
            this.czarnoBiaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.czarnoBiaToolStripMenuItem.Text = "Czarno - biały";
            this.czarnoBiaToolStripMenuItem.Click += new System.EventHandler(this.czarnoBiaToolStripMenuItem_Click);
            // 
            // czbZWyrównaniemToolStripMenuItem
            // 
            this.czbZWyrównaniemToolStripMenuItem.Name = "czbZWyrównaniemToolStripMenuItem";
            this.czbZWyrównaniemToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.czbZWyrównaniemToolStripMenuItem.Text = "Cz-b z wyrównaniem";
            this.czbZWyrównaniemToolStripMenuItem.Click += new System.EventHandler(this.czbZWyrównaniemToolStripMenuItem_Click);
            // 
            // czbiaFSToolStripMenuItem
            // 
            this.czbiaFSToolStripMenuItem.Name = "czbiaFSToolStripMenuItem";
            this.czbiaFSToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.czbiaFSToolStripMenuItem.Text = "Cz-bia F-S";
            this.czbiaFSToolStripMenuItem.Click += new System.EventHandler(this.czbiaFSToolStripMenuItem_Click);
            // 
            // filtryToolStripMenuItem
            // 
            this.filtryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem});
            this.filtryToolStripMenuItem.Name = "filtryToolStripMenuItem";
            this.filtryToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filtryToolStripMenuItem.Text = "Filtry";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 433);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 17);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 409);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Pliki BMP (*.bmp)|*.bmp|Pliki JPEG (*.jpg)|*.jpg|Pliki TIFF (*.tif)|*.tif|Pliki P" +
    "NG (*.png)|*.png|Wszystkie pliki (*.*)|*.*";
            this.openFileDialog1.Title = "Wybierz plik obrazu";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodaTestowaToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // metodaTestowaToolStripMenuItem
            // 
            this.metodaTestowaToolStripMenuItem.Name = "metodaTestowaToolStripMenuItem";
            this.metodaTestowaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.metodaTestowaToolStripMenuItem.Text = "MetodaTestowa";
            this.metodaTestowaToolStripMenuItem.Click += new System.EventHandler(this.metodaTestowaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TPiPOR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem standardowyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dopasowanyToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem jasnośćToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ściemnijToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem rozjaśnijToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem koloryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ocieplenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oziębienieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem skalaSzarościToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czarnoBiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czbZWyrównaniemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czbiaFSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem filtryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodaTestowaToolStripMenuItem;
    }
}

