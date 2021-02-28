
namespace FernCreekProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtImport = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDelimiter = new System.Windows.Forms.TextBox();
            this.rdoDelimited = new System.Windows.Forms.RadioButton();
            this.rdoJSON = new System.Windows.Forms.RadioButton();
            this.rdoXML = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgrdData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImport
            // 
            this.txtImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImport.Location = new System.Drawing.Point(12, 12);
            this.txtImport.Name = "txtImport";
            this.txtImport.ReadOnly = true;
            this.txtImport.Size = new System.Drawing.Size(500, 23);
            this.txtImport.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(535, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(83, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse Files";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BrowseClick);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(535, 50);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(83, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDelimiter);
            this.groupBox1.Controls.Add(this.rdoDelimited);
            this.groupBox1.Controls.Add(this.rdoJSON);
            this.groupBox1.Controls.Add(this.rdoXML);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 127);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export Format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Delimiter Text";
            // 
            // txtDelimiter
            // 
            this.txtDelimiter.Enabled = false;
            this.txtDelimiter.Location = new System.Drawing.Point(92, 95);
            this.txtDelimiter.Name = "txtDelimiter";
            this.txtDelimiter.Size = new System.Drawing.Size(55, 23);
            this.txtDelimiter.TabIndex = 6;
            this.txtDelimiter.TextChanged += new System.EventHandler(this.txtDelimiter_TextChanged);
            // 
            // rdoDelimited
            // 
            this.rdoDelimited.AutoSize = true;
            this.rdoDelimited.Location = new System.Drawing.Point(6, 72);
            this.rdoDelimited.Name = "rdoDelimited";
            this.rdoDelimited.Size = new System.Drawing.Size(100, 19);
            this.rdoDelimited.TabIndex = 5;
            this.rdoDelimited.Text = "Text Delimited";
            this.rdoDelimited.UseVisualStyleBackColor = true;
            this.rdoDelimited.CheckedChanged += new System.EventHandler(this.rdoDelimited_CheckedChanged);
            // 
            // rdoJSON
            // 
            this.rdoJSON.AutoSize = true;
            this.rdoJSON.Location = new System.Drawing.Point(6, 47);
            this.rdoJSON.Name = "rdoJSON";
            this.rdoJSON.Size = new System.Drawing.Size(53, 19);
            this.rdoJSON.TabIndex = 4;
            this.rdoJSON.Text = "JSON";
            this.rdoJSON.UseVisualStyleBackColor = true;
            // 
            // rdoXML
            // 
            this.rdoXML.AutoSize = true;
            this.rdoXML.Checked = true;
            this.rdoXML.Location = new System.Drawing.Point(6, 22);
            this.rdoXML.Name = "rdoXML";
            this.rdoXML.Size = new System.Drawing.Size(49, 19);
            this.rdoXML.TabIndex = 3;
            this.rdoXML.TabStop = true;
            this.rdoXML.Text = "XML";
            this.rdoXML.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // dgrdData
            // 
            this.dgrdData.AllowUserToAddRows = false;
            this.dgrdData.AllowUserToDeleteRows = false;
            this.dgrdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdData.Location = new System.Drawing.Point(12, 193);
            this.dgrdData.Name = "dgrdData";
            this.dgrdData.ReadOnly = true;
            this.dgrdData.RowTemplate.Height = 25;
            this.dgrdData.Size = new System.Drawing.Size(606, 284);
            this.dgrdData.TabIndex = 9;
            this.dgrdData.Sorted += new System.EventHandler(this.dgrdData_Sorted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sort by clicking on column headers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgrdData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtImport);
            this.Name = "Form1";
            this.Text = "Sort by clicking on column headers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImport;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDelimiter;
        private System.Windows.Forms.RadioButton rdoDelimited;
        private System.Windows.Forms.RadioButton rdoJSON;
        private System.Windows.Forms.RadioButton rdoXML;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgrdData;
        private System.Windows.Forms.Label label2;
    }
}

