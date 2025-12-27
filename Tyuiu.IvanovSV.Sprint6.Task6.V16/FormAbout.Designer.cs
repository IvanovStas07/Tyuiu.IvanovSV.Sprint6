using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.IvanovSV.Sprint6.Task7.V17
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxFace = new PictureBox();
            label1 = new Label();
            buttonOk_ISV = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFace).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFace
            // 
            pictureBoxFace.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxFace.Enabled = false;
            pictureBoxFace.ErrorImage = null;
            pictureBoxFace.Image = Task6.V16.Properties.Resources.Face;
            pictureBoxFace.ImageLocation = "";
            pictureBoxFace.Location = new Point(13, 29);
            pictureBoxFace.Margin = new Padding(4);
            pictureBoxFace.Name = "pictureBoxFace";
            pictureBoxFace.Size = new Size(341, 437);
            pictureBoxFace.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFace.TabIndex = 0;
            pictureBoxFace.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 1;
            // 
            // buttonOk_ISV
            // 
            buttonOk_ISV.Location = new Point(754, 422);
            buttonOk_ISV.Margin = new Padding(4);
            buttonOk_ISV.Name = "buttonOk_ISV";
            buttonOk_ISV.Size = new Size(157, 44);
            buttonOk_ISV.TabIndex = 2;
            buttonOk_ISV.Text = "Ок";
            buttonOk_ISV.UseVisualStyleBackColor = true;
            buttonOk_ISV.Click += buttonOk_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Segoe UI", 8F, FontStyle.Bold);
            textBox1.Location = new Point(361, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(558, 386);
            textBox1.TabIndex = 3;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 479);
            Controls.Add(textBox1);
            Controls.Add(buttonOk_ISV);
            Controls.Add(label1);
            Controls.Add(pictureBoxFace);
            Margin = new Padding(4);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFace).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxFace;
        private Label label1;
        private Button buttonOk_ISV;
        private TextBox textBox1;
    }
}
