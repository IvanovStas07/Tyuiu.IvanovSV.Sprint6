namespace Tyuiu.IvanovSV.Sprint6.Task0.V14
{
    partial class FormMain
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
            labelFormula_ISV = new Label();
            labelX_ISV = new Label();
            textBoxInput_ISV = new TextBox();
            labelResult_ISV = new Label();
            textBoxResult_ISV = new TextBox();
            buttonCalculatePush_ISV = new Button();
            groupBoxCondition_ISV = new GroupBox();
            groupBoxInput_ISV = new GroupBox();
            groupBoxOutput_ISV = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            groupBoxCondition_ISV.SuspendLayout();
            groupBoxInput_ISV.SuspendLayout();
            groupBoxOutput_ISV.SuspendLayout();
            SuspendLayout();
            // 
            // labelFormula_ISV
            // 
            labelFormula_ISV.AutoSize = true;
            labelFormula_ISV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFormula_ISV.Location = new Point(14, 41);
            labelFormula_ISV.Margin = new Padding(8, 0, 8, 0);
            labelFormula_ISV.Name = "labelFormula_ISV";
            labelFormula_ISV.Size = new Size(294, 37);
            labelFormula_ISV.TabIndex = 1;
            labelFormula_ISV.Text = "y(x) = (1-x)^2 / (-3x)";
            labelFormula_ISV.Click += labelFormula_Click;
            // 
            // labelX_ISV
            // 
            labelX_ISV.AutoSize = true;
            labelX_ISV.Location = new Point(14, 51);
            labelX_ISV.Margin = new Padding(8, 0, 8, 0);
            labelX_ISV.Name = "labelX_ISV";
            labelX_ISV.Size = new Size(192, 32);
            labelX_ISV.TabIndex = 3;
            labelX_ISV.Text = "Переменная X:";
            // 
            // textBoxInput_ISV
            // 
            textBoxInput_ISV.Location = new Point(14, 90);
            textBoxInput_ISV.Margin = new Padding(8, 6, 8, 6);
            textBoxInput_ISV.Name = "textBoxInput_ISV";
            textBoxInput_ISV.Size = new Size(368, 39);
            textBoxInput_ISV.TabIndex = 4;
            textBoxInput_ISV.TextChanged += textBoxInput_ISV_TextChanged;
            // 
            // labelResult_ISV
            // 
            labelResult_ISV.AutoSize = true;
            labelResult_ISV.Location = new Point(14, 51);
            labelResult_ISV.Margin = new Padding(8, 0, 8, 0);
            labelResult_ISV.Name = "labelResult_ISV";
            labelResult_ISV.Size = new Size(133, 32);
            labelResult_ISV.TabIndex = 6;
            labelResult_ISV.Text = "Результат:";
            // 
            // textBoxResult_ISV
            // 
            textBoxResult_ISV.Location = new Point(14, 90);
            textBoxResult_ISV.Margin = new Padding(8, 6, 8, 6);
            textBoxResult_ISV.Name = "textBoxResult_ISV";
            textBoxResult_ISV.ReadOnly = true;
            textBoxResult_ISV.Size = new Size(368, 39);
            textBoxResult_ISV.TabIndex = 7;
            // 
            // buttonCalculatePush_ISV
            // 
            buttonCalculatePush_ISV.Location = new Point(488, 559);
            buttonCalculatePush_ISV.Margin = new Padding(8, 6, 8, 6);
            buttonCalculatePush_ISV.Name = "buttonCalculatePush_ISV";
            buttonCalculatePush_ISV.Size = new Size(234, 58);
            buttonCalculatePush_ISV.TabIndex = 8;
            buttonCalculatePush_ISV.Text = "Выполнить";
            buttonCalculatePush_ISV.UseVisualStyleBackColor = true;
            buttonCalculatePush_ISV.Click += buttonCalculate_Click;
            // 
            // groupBoxCondition_ISV
            // 
            groupBoxCondition_ISV.Controls.Add(labelFormula_ISV);
            groupBoxCondition_ISV.Location = new Point(24, 26);
            groupBoxCondition_ISV.Margin = new Padding(6);
            groupBoxCondition_ISV.Name = "groupBoxCondition_ISV";
            groupBoxCondition_ISV.Padding = new Padding(6);
            groupBoxCondition_ISV.Size = new Size(1162, 407);
            groupBoxCondition_ISV.TabIndex = 9;
            groupBoxCondition_ISV.TabStop = false;
            groupBoxCondition_ISV.Text = "Условие";
            // 
            // groupBoxInput_ISV
            // 
            groupBoxInput_ISV.Controls.Add(labelX_ISV);
            groupBoxInput_ISV.Controls.Add(textBoxInput_ISV);
            groupBoxInput_ISV.Location = new Point(24, 469);
            groupBoxInput_ISV.Margin = new Padding(6);
            groupBoxInput_ISV.Name = "groupBoxInput_ISV";
            groupBoxInput_ISV.Padding = new Padding(6);
            groupBoxInput_ISV.Size = new Size(400, 213);
            groupBoxInput_ISV.TabIndex = 9;
            groupBoxInput_ISV.TabStop = false;
            groupBoxInput_ISV.Text = "Ввод данных";
            groupBoxInput_ISV.Enter += groupBoxInput_ISV_Enter;
            // 
            // groupBoxOutput_ISV
            // 
            groupBoxOutput_ISV.Controls.Add(textBoxResult_ISV);
            groupBoxOutput_ISV.Controls.Add(labelResult_ISV);
            groupBoxOutput_ISV.Location = new Point(786, 469);
            groupBoxOutput_ISV.Margin = new Padding(6);
            groupBoxOutput_ISV.Name = "groupBoxOutput_ISV";
            groupBoxOutput_ISV.Padding = new Padding(6);
            groupBoxOutput_ISV.RightToLeft = RightToLeft.No;
            groupBoxOutput_ISV.Size = new Size(400, 213);
            groupBoxOutput_ISV.TabIndex = 10;
            groupBoxOutput_ISV.TabStop = false;
            groupBoxOutput_ISV.Text = "Вывод данных";
            groupBoxOutput_ISV.Enter += groupBoxOutput_ISV_Enter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1668, 715);
            Controls.Add(groupBoxOutput_ISV);
            Controls.Add(buttonCalculatePush_ISV);
            Controls.Add(groupBoxInput_ISV);
            Controls.Add(groupBoxCondition_ISV);
            Margin = new Padding(8, 6, 8, 6);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 14 | Иванов С. В. ";
            Load += FormMain_Load;
            groupBoxCondition_ISV.ResumeLayout(false);
            groupBoxCondition_ISV.PerformLayout();
            groupBoxInput_ISV.ResumeLayout(false);
            groupBoxInput_ISV.PerformLayout();
            groupBoxOutput_ISV.ResumeLayout(false);
            groupBoxOutput_ISV.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelFormula_ISV;
        private System.Windows.Forms.Label labelX_ISV;
        private System.Windows.Forms.TextBox textBoxInput_ISV;
        private System.Windows.Forms.Label labelResult_ISV;
        private System.Windows.Forms.TextBox textBoxResult_ISV;
        private System.Windows.Forms.Button buttonCalculatePush_ISV;
        private GroupBox groupBoxCondition_ISV;
        private GroupBox groupBoxInput_ISV;
        private GroupBox groupBoxOutput_ISV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}