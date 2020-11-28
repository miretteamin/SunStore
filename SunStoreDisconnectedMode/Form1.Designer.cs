namespace SunStoreDisconnectedMode
{
    partial class SunStoreDisconnectedModefrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Searchbtn = new System.Windows.Forms.RadioButton();
            this.ProductNametxt = new System.Windows.Forms.TextBox();
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.ProductIDcbx = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.ProductNamelbl = new System.Windows.Forms.Label();
            this.ProductsIDlbl = new System.Windows.Forms.Label();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.UPDradiobtn = new System.Windows.Forms.RadioButton();
            this.DELradiobtn = new System.Windows.Forms.RadioButton();
            this.INSradiobtn = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<=",
            ">=",
            "!="});
            this.comboBox1.Location = new System.Drawing.Point(566, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(35, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // Searchbtn
            // 
            this.Searchbtn.AutoSize = true;
            this.Searchbtn.BackColor = System.Drawing.Color.Gray;
            this.Searchbtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Searchbtn.ForeColor = System.Drawing.Color.White;
            this.Searchbtn.Location = new System.Drawing.Point(69, 192);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(64, 17);
            this.Searchbtn.TabIndex = 27;
            this.Searchbtn.TabStop = true;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.CheckedChanged += new System.EventHandler(this.Searchbtn_CheckedChanged_1);
            // 
            // ProductNametxt
            // 
            this.ProductNametxt.ForeColor = System.Drawing.Color.Black;
            this.ProductNametxt.Location = new System.Drawing.Point(615, 95);
            this.ProductNametxt.Name = "ProductNametxt";
            this.ProductNametxt.Size = new System.Drawing.Size(86, 20);
            this.ProductNametxt.TabIndex = 26;
            // 
            // Pricetxt
            // 
            this.Pricetxt.ForeColor = System.Drawing.Color.Black;
            this.Pricetxt.Location = new System.Drawing.Point(615, 153);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(60, 20);
            this.Pricetxt.TabIndex = 25;
            // 
            // ProductIDcbx
            // 
            this.ProductIDcbx.BackColor = System.Drawing.Color.White;
            this.ProductIDcbx.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ProductIDcbx.ForeColor = System.Drawing.Color.Black;
            this.ProductIDcbx.FormattingEnabled = true;
            this.ProductIDcbx.Location = new System.Drawing.Point(606, 44);
            this.ProductIDcbx.Name = "ProductIDcbx";
            this.ProductIDcbx.Size = new System.Drawing.Size(56, 21);
            this.ProductIDcbx.TabIndex = 24;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Gray;
            this.btn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(757, 93);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(64, 23);
            this.btn.TabIndex = 23;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pricelbl.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Pricelbl.ForeColor = System.Drawing.Color.White;
            this.Pricelbl.Location = new System.Drawing.Point(512, 156);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(44, 13);
            this.Pricelbl.TabIndex = 22;
            this.Pricelbl.Text = " Price :";
            // 
            // ProductNamelbl
            // 
            this.ProductNamelbl.AutoSize = true;
            this.ProductNamelbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProductNamelbl.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ProductNamelbl.ForeColor = System.Drawing.Color.White;
            this.ProductNamelbl.Location = new System.Drawing.Point(512, 98);
            this.ProductNamelbl.Name = "ProductNamelbl";
            this.ProductNamelbl.Size = new System.Drawing.Size(89, 13);
            this.ProductNamelbl.TabIndex = 21;
            this.ProductNamelbl.Text = "ProductName :";
            // 
            // ProductsIDlbl
            // 
            this.ProductsIDlbl.AutoSize = true;
            this.ProductsIDlbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProductsIDlbl.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ProductsIDlbl.ForeColor = System.Drawing.Color.White;
            this.ProductsIDlbl.Location = new System.Drawing.Point(512, 47);
            this.ProductsIDlbl.Name = "ProductsIDlbl";
            this.ProductsIDlbl.Size = new System.Drawing.Size(70, 13);
            this.ProductsIDlbl.TabIndex = 20;
            this.ProductsIDlbl.Text = "ProductID :";
            // 
            // Loadbtn
            // 
            this.Loadbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Loadbtn.BackColor = System.Drawing.Color.Gray;
            this.Loadbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Loadbtn.ForeColor = System.Drawing.Color.White;
            this.Loadbtn.Location = new System.Drawing.Point(390, 203);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(75, 26);
            this.Loadbtn.TabIndex = 19;
            this.Loadbtn.Text = "Refresh";
            this.Loadbtn.UseVisualStyleBackColor = false;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click_1);
            // 
            // UPDradiobtn
            // 
            this.UPDradiobtn.AutoSize = true;
            this.UPDradiobtn.BackColor = System.Drawing.Color.Gray;
            this.UPDradiobtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.UPDradiobtn.ForeColor = System.Drawing.Color.White;
            this.UPDradiobtn.Location = new System.Drawing.Point(69, 80);
            this.UPDradiobtn.Name = "UPDradiobtn";
            this.UPDradiobtn.Size = new System.Drawing.Size(66, 17);
            this.UPDradiobtn.TabIndex = 18;
            this.UPDradiobtn.TabStop = true;
            this.UPDradiobtn.Text = "Update";
            this.UPDradiobtn.UseVisualStyleBackColor = false;
            this.UPDradiobtn.CheckedChanged += new System.EventHandler(this.UPDradiobtn_CheckedChanged);
            // 
            // DELradiobtn
            // 
            this.DELradiobtn.AutoSize = true;
            this.DELradiobtn.BackColor = System.Drawing.Color.Gray;
            this.DELradiobtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.DELradiobtn.ForeColor = System.Drawing.Color.White;
            this.DELradiobtn.Location = new System.Drawing.Point(69, 135);
            this.DELradiobtn.Name = "DELradiobtn";
            this.DELradiobtn.Size = new System.Drawing.Size(62, 17);
            this.DELradiobtn.TabIndex = 17;
            this.DELradiobtn.TabStop = true;
            this.DELradiobtn.Text = "Delete";
            this.DELradiobtn.UseVisualStyleBackColor = false;
            this.DELradiobtn.CheckedChanged += new System.EventHandler(this.DELradiobtn_CheckedChanged);
            // 
            // INSradiobtn
            // 
            this.INSradiobtn.AutoSize = true;
            this.INSradiobtn.BackColor = System.Drawing.Color.Gray;
            this.INSradiobtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.INSradiobtn.ForeColor = System.Drawing.Color.White;
            this.INSradiobtn.Location = new System.Drawing.Point(69, 24);
            this.INSradiobtn.Name = "INSradiobtn";
            this.INSradiobtn.Size = new System.Drawing.Size(60, 17);
            this.INSradiobtn.TabIndex = 16;
            this.INSradiobtn.TabStop = true;
            this.INSradiobtn.Text = "Insert";
            this.INSradiobtn.UseVisualStyleBackColor = false;
            this.INSradiobtn.CheckedChanged += new System.EventHandler(this.INSradiobtn_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(4, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(924, 254);
            this.dataGridView1.TabIndex = 15;
            // 
            // SunStoreDisconnectedModefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 489);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.ProductNametxt);
            this.Controls.Add(this.Pricetxt);
            this.Controls.Add(this.ProductIDcbx);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.Pricelbl);
            this.Controls.Add(this.ProductNamelbl);
            this.Controls.Add(this.ProductsIDlbl);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.UPDradiobtn);
            this.Controls.Add(this.DELradiobtn);
            this.Controls.Add(this.INSradiobtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SunStoreDisconnectedModefrm";
            this.Text = "SunStore Disconnected Mode";
            this.Load += new System.EventHandler(this.SunStoreDisconnectedModefrm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton Searchbtn;
        private System.Windows.Forms.TextBox ProductNametxt;
        private System.Windows.Forms.TextBox Pricetxt;
        private System.Windows.Forms.ComboBox ProductIDcbx;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label Pricelbl;
        private System.Windows.Forms.Label ProductNamelbl;
        private System.Windows.Forms.Label ProductsIDlbl;
        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.RadioButton UPDradiobtn;
        private System.Windows.Forms.RadioButton DELradiobtn;
        private System.Windows.Forms.RadioButton INSradiobtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

