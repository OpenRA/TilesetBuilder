namespace OpenRA.TilesetBuilder
{
	partial class FormBuilder
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuilder));
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ImageList = new System.Windows.Forms.ImageList(this.components);
			this.terrainTypes = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
			this.txtTilesetName = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
			this.txtID = new System.Windows.Forms.ToolStripTextBox();
			this.lblExt = new System.Windows.Forms.ToolStripLabel();
			this.txtExt = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
			this.txtPal = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonExport = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDump = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonOverlays = new System.Windows.Forms.ToolStripButton();
			this.surface1 = new OpenRA.TilesetBuilder.Surface();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.terrainTypes.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.terrainTypes);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(908, 571);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(908, 596);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
			this.toolStripContainer1.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.surface1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(788, 571);
			this.panel1.TabIndex = 3;
			// 
			// imageList
			// 
			this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList.Images.SetKeyName(0, "clear.png");
			this.ImageList.Images.SetKeyName(1, "water.png");
			this.ImageList.Images.SetKeyName(2, "road.png");
			this.ImageList.Images.SetKeyName(3, "rock.png");
			this.ImageList.Images.SetKeyName(4, "river.png");
			this.ImageList.Images.SetKeyName(5, "rough.png");
			this.ImageList.Images.SetKeyName(6, "wall.png");
			this.ImageList.Images.SetKeyName(7, "beach.png");
			this.ImageList.Images.SetKeyName(8, "tree.png");
			this.ImageList.Images.SetKeyName(9, "tiberium.png");
			// 
			// tsTerrainTypes
			// 
			this.terrainTypes.AutoSize = false;
			this.terrainTypes.Dock = System.Windows.Forms.DockStyle.Right;
			this.terrainTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripLabel3,
			this.toolStripSeparator3,
			this.toolStripLabel4,
			this.txtTilesetName,
			this.toolStripLabel5,
			this.txtID,
			this.lblExt,
			this.txtExt,
			this.toolStripLabel6,
			this.txtPal,
			this.toolStripSeparator5,
			this.toolStripLabel2,
			this.toolStripSeparator4,
			this.toolStripButton1});
			this.terrainTypes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
			this.terrainTypes.Location = new System.Drawing.Point(788, 0);
			this.terrainTypes.Name = "tsTerrainTypes";
			this.terrainTypes.Size = new System.Drawing.Size(120, 571);
			this.terrainTypes.TabIndex = 1;
			this.terrainTypes.Text = "toolStrip3";
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(118, 13);
			this.toolStripLabel3.Text = "Tileset setup";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(118, 6);
			// 
			// toolStripLabel4
			// 
			this.toolStripLabel4.Name = "toolStripLabel4";
			this.toolStripLabel4.Size = new System.Drawing.Size(118, 13);
			this.toolStripLabel4.Text = "Tileset name:";
			// 
			// txtTilesetName
			// 
			this.txtTilesetName.MaxLength = 32;
			this.txtTilesetName.Name = "txtTilesetName";
			this.txtTilesetName.Size = new System.Drawing.Size(116, 21);
			this.txtTilesetName.Text = "Temperat";
			this.txtTilesetName.TextChanged += new System.EventHandler(this.TilesetNameChanged);
			// 
			// toolStripLabel5
			// 
			this.toolStripLabel5.Name = "toolStripLabel5";
			this.toolStripLabel5.Size = new System.Drawing.Size(118, 13);
			this.toolStripLabel5.Text = "Tileset ID:";
			// 
			// txtID
			// 
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(116, 21);
			this.txtID.Text = "TEMPERAT";
			// 
			// lblExt
			// 
			this.lblExt.Name = "lblExt";
			this.lblExt.Size = new System.Drawing.Size(118, 13);
			this.lblExt.Text = "Extensions:";
			// 
			// txtExt
			// 
			this.txtExt.Name = "txtExt";
			this.txtExt.ReadOnly = true;
			this.txtExt.Size = new System.Drawing.Size(116, 21);
			this.txtExt.Text = ".tem,.shp";
			// 
			// toolStripLabel6
			// 
			this.toolStripLabel6.Name = "toolStripLabel6";
			this.toolStripLabel6.Size = new System.Drawing.Size(118, 13);
			this.toolStripLabel6.Text = "Palette:";
			// 
			// txtPal
			// 
			this.txtPal.Name = "txtPal";
			this.txtPal.ReadOnly = true;
			this.txtPal.Size = new System.Drawing.Size(116, 21);
			this.txtPal.Text = "temperat.pal";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(118, 6);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(118, 13);
			this.toolStripLabel2.Text = "Terrain type";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(118, 6);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Checked = true;
			this.toolStripButton1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(118, 20);
			this.toolStripButton1.Text = "Template Tool";
			this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripButton1.Click += new System.EventHandler(this.TerrainTypeSelectorClicked);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripButtonNew,
			this.toolStripButtonSave,
			this.toolStripButtonExport,
			this.toolStripButtonDump,
			this.toolStripSeparator1,
			this.toolStripButtonOverlays});
			this.toolStrip1.Location = new System.Drawing.Point(3, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(275, 25);
			this.toolStrip1.TabIndex = 0;
			// 
			// toolStripButtonNew
			// 
			this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
			this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonNew.Name = "toolStripButtonNew";
			this.toolStripButtonNew.Size = new System.Drawing.Size(48, 22);
			this.toolStripButtonNew.Text = "New";
			this.toolStripButtonNew.ToolTipText = "Create new tileset";
			this.toolStripButtonNew.Click += new System.EventHandler(this.NewTilesetClicked);
			// 
			// toolStripButtonSave
			// 
			this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
			this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSave.Name = "toolStripButtonSave";
			this.toolStripButtonSave.Size = new System.Drawing.Size(51, 22);
			this.toolStripButtonSave.Text = "Save";
			this.toolStripButtonSave.ToolTipText = "Save Template definitions to file (*.tsx)";
			this.toolStripButtonSave.Click += new System.EventHandler(this.SaveClicked);
			// 
			// toolStripButtonExport
			// 
			this.toolStripButtonExport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExport.Image")));
			this.toolStripButtonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonExport.Name = "toolStripButtonExport";
			this.toolStripButtonExport.Size = new System.Drawing.Size(59, 22);
			this.toolStripButtonExport.Text = "Export";
			this.toolStripButtonExport.ToolTipText = "Export defined Templates to files";
			this.toolStripButtonExport.Click += new System.EventHandler(this.ExportClicked);
			// 
			// toolStripButtonDump
			// 
			this.toolStripButtonDump.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExport.Image")));
			this.toolStripButtonDump.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonDump.Name = "toolStripButtonDump";
			this.toolStripButtonDump.Size = new System.Drawing.Size(65, 22);
			this.toolStripButtonDump.Text = "Dump";
			this.toolStripButtonDump.ToolTipText = "Dump Template ID to tile number mapping to console";
			this.toolStripButtonDump.Click += new System.EventHandler(this.DumpClicked);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonOverlays
			// 
			this.toolStripButtonOverlays.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOverlays.Image")));
			this.toolStripButtonOverlays.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonOverlays.Name = "toolStripButtonOverlays";
			this.toolStripButtonOverlays.Size = new System.Drawing.Size(70, 22);
			this.toolStripButtonOverlays.Text = "Overlays";
			this.toolStripButtonOverlays.ToolTipText = "Show/hide terrain type overlays";
			this.toolStripButtonOverlays.CheckOnClick = true;
			this.toolStripButtonOverlays.Click += new System.EventHandler(this.ShowOverlaysClicked);
			// 
			// surface1
			// 
			this.surface1.BackColor = System.Drawing.Color.Black;
			this.surface1.ImagesList = this.ImageList;
			this.surface1.Location = new System.Drawing.Point(0, 0);
			this.surface1.Name = "surface1";
			this.surface1.ShowTerrainTypes = this.toolStripButtonOverlays.Checked;
			this.surface1.Size = new System.Drawing.Size(653, 454);
			this.surface1.TabIndex = 2;
			this.surface1.Text = "surface1";
			// 
			// frmBuilder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(908, 596);
			this.Controls.Add(this.toolStripContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmBuilder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tileset Builder 2";
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.terrainTypes.ResumeLayout(false);
			this.terrainTypes.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonSave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButtonOverlays;
		private System.Windows.Forms.ToolStripButton toolStripButtonExport;
		private System.Windows.Forms.ToolStripButton toolStripButtonNew;
		private System.Windows.Forms.ToolStripButton toolStripButtonDump;
		public System.Windows.Forms.ImageList ImageList;
		private System.Windows.Forms.ToolStrip terrainTypes;
		private System.Windows.Forms.Panel panel1;
		private Surface surface1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripLabel toolStripLabel4;
		private System.Windows.Forms.ToolStripTextBox txtTilesetName;
		private System.Windows.Forms.ToolStripLabel toolStripLabel5;
		private System.Windows.Forms.ToolStripTextBox txtID;
		private System.Windows.Forms.ToolStripLabel lblExt;
		private System.Windows.Forms.ToolStripTextBox txtExt;
		private System.Windows.Forms.ToolStripLabel toolStripLabel6;
		private System.Windows.Forms.ToolStripTextBox txtPal;
	}
}