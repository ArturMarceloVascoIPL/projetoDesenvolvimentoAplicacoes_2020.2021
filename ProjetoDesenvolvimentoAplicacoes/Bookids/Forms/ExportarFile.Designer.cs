
namespace Bookids.Forms
{
    partial class ExportarFile
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
            this.buttonPdf = new System.Windows.Forms.Button();
            this.buttonTxt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // buttonPdf
            // 
            this.buttonPdf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPdf.Location = new System.Drawing.Point(25, 65);
            this.buttonPdf.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(52, 57);
            this.buttonPdf.TabIndex = 2;
            this.buttonPdf.Text = "PDF";
            this.buttonPdf.UseVisualStyleBackColor = false;
            this.buttonPdf.MouseEnter += new System.EventHandler(this.buttonPdf_MouseEnter);
            this.buttonPdf.MouseLeave += new System.EventHandler(this.buttonPdf_MouseLeave);
            // 
            // buttonTxt
            // 
            this.buttonTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTxt.Location = new System.Drawing.Point(95, 65);
            this.buttonTxt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTxt.Name = "buttonTxt";
            this.buttonTxt.Size = new System.Drawing.Size(52, 57);
            this.buttonTxt.TabIndex = 3;
            this.buttonTxt.Text = "TXT";
            this.buttonTxt.UseVisualStyleBackColor = false;
            this.buttonTxt.Click += new System.EventHandler(this.buttonTxt_Click);
            this.buttonTxt.MouseEnter += new System.EventHandler(this.buttonTxt_MouseEnter);
            this.buttonTxt.MouseLeave += new System.EventHandler(this.buttonTxt_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exportar";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(130, 11);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(33, 36);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ExportarFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 144);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTxt);
            this.Controls.Add(this.buttonPdf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExportarFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportarFileCompras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPdf;
        private System.Windows.Forms.Button buttonTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
    }
}