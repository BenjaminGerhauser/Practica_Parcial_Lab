namespace Practica_Parcial_Lab
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.grbVideo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(44, 44);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(470, 20);
            this.txtAutor.TabIndex = 1;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(549, 44);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(31, 86);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(739, 212);
            this.grilla.TabIndex = 3;
            this.grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellContentClick);
            // 
            // grbVideo
            // 
            this.grbVideo.AutoSize = true;
            this.grbVideo.Location = new System.Drawing.Point(31, 304);
            this.grbVideo.Name = "grbVideo";
            this.grbVideo.Size = new System.Drawing.Size(1863, 650);
            this.grbVideo.TabIndex = 4;
            this.grbVideo.TabStop = false;
            this.grbVideo.Text = "Video";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 738);
            this.Controls.Add(this.grbVideo);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.GroupBox grbVideo;
    }
}