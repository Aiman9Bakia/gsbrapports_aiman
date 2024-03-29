namespace gsbRapports2
{
    partial class listeRapports
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
            this.rapportGv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bdgRapport = new System.Windows.Forms.BindingSource(this.components);
            this.bdgVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rapportGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // rapportGv
            // 
            this.rapportGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rapportGv.Location = new System.Drawing.Point(26, 181);
            this.rapportGv.Name = "rapportGv";
            this.rapportGv.RowHeadersWidth = 62;
            this.rapportGv.RowTemplate.Height = 28;
            this.rapportGv.Size = new System.Drawing.Size(612, 241);
            this.rapportGv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identifiant ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Afficher les rapports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listeRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rapportGv);
            this.Name = "listeRapports";
            this.Text = "listeRapports";
            this.Load += new System.EventHandler(this.listeRapports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rapportGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rapportGv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bdgRapport;
        private System.Windows.Forms.BindingSource bdgVisiteur;
        private System.Windows.Forms.Button button1;
    }
}