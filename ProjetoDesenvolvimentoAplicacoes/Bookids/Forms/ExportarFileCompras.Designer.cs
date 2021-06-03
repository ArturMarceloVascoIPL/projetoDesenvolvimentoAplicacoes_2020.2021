
namespace Bookids.Forms
{
    partial class ExportarFileCompras
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
            this.buttonPDF = new System.Windows.Forms.Button();
            this.buttonTXT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPDF
            // 
            this.buttonPDF.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPDF.Location = new System.Drawing.Point(39, 121);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(70, 70);
            this.buttonPDF.TabIndex = 1;
            this.buttonPDF.Text = "PDF";
            this.buttonPDF.UseVisualStyleBackColor = false;
            this.buttonPDF.MouseEnter += new System.EventHandler(this.buttonPDF_MouseHover);
            this.buttonPDF.MouseLeave += new System.EventHandler(this.buttonPDF_MouseHover);
            this.buttonPDF.MouseHover += new System.EventHandler(this.buttonPDF_MouseHover);
            // 
            // buttonTXT
            // 
            this.buttonTXT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTXT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTXT.Location = new System.Drawing.Point(130, 121);
            this.buttonTXT.Name = "buttonTXT";
            this.buttonTXT.Size = new System.Drawing.Size(70, 70);
            this.buttonTXT.TabIndex = 2;
            this.buttonTXT.Text = "TXT";
            this.buttonTXT.UseVisualStyleBackColor = false;
            this.buttonTXT.MouseEnter += new System.EventHandler(this.buttonTXT_MouseHover);
            this.buttonTXT.MouseLeave += new System.EventHandler(this.buttonTXT_MouseLeave);
            this.buttonTXT.MouseHover += new System.EventHandler(this.buttonTXT_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exportar";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(176, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(44, 44);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ExportarFileCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 215);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTXT);
            this.Controls.Add(this.buttonPDF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportarFileCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportarFileCompras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPDF;
        private System.Windows.Forms.Button buttonTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
    }
}