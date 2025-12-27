namespace Tyuiu.IvanovSV.Sprint6.Task6.V16
{

    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_ISV = new Panel();
            buttonInfo_ISV = new Button();
            buttonDone_ISV = new Button();
            buttonOpenFile_ISV = new Button();
            panelTask_ISV = new Panel();
            groupBoxTask_ISV = new GroupBox();
            textBoxTask_ISV = new TextBox();
            panelMain_ISV = new Panel();
            groupBoxOutPut_ISV = new GroupBox();
            textBoxOutPut_ISV = new TextBox();
            groupBoxInPut_ISV = new GroupBox();
            textBoxInPut_ISV = new TextBox();
            openFileDialogTask_ISV = new OpenFileDialog();
            toolTip_ISV = new ToolTip(components);
            panelButtons_ISV.SuspendLayout();
            panelTask_ISV.SuspendLayout();
            groupBoxTask_ISV.SuspendLayout();
            panelMain_ISV.SuspendLayout();
            groupBoxOutPut_ISV.SuspendLayout();
            groupBoxInPut_ISV.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons_ISV
            // 
            panelButtons_ISV.Controls.Add(buttonInfo_ISV);
            panelButtons_ISV.Controls.Add(buttonDone_ISV);
            panelButtons_ISV.Controls.Add(buttonOpenFile_ISV);
            panelButtons_ISV.Dock = DockStyle.Top;
            panelButtons_ISV.Location = new Point(0, 0);
            panelButtons_ISV.Margin = new Padding(7, 7, 7, 7);
            panelButtons_ISV.Name = "panelButtons_ISV";
            panelButtons_ISV.Size = new Size(1596, 219);
            panelButtons_ISV.TabIndex = 0;
            // 
            // buttonInfo_ISV
            // 
            buttonInfo_ISV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_ISV.BackColor = Color.LightCyan;
            buttonInfo_ISV.BackgroundImage = Properties.Resources.information;
            buttonInfo_ISV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonInfo_ISV.FlatStyle = FlatStyle.Flat;
            buttonInfo_ISV.Location = new Point(1335, 54);
            buttonInfo_ISV.Margin = new Padding(7, 7, 7, 7);
            buttonInfo_ISV.Name = "buttonInfo_ISV";
            buttonInfo_ISV.Size = new Size(233, 111);
            buttonInfo_ISV.TabIndex = 1;
            toolTip_ISV.SetToolTip(buttonInfo_ISV, "Справка\r\nДополнительная информация");
            buttonInfo_ISV.UseVisualStyleBackColor = false;
            buttonInfo_ISV.Click += buttonInfo_ISV_Click;
            // 
            // buttonDone_ISV
            // 
            buttonDone_ISV.BackColor = Color.LightGreen;
            buttonDone_ISV.BackgroundImage = Properties.Resources.door_out;
            buttonDone_ISV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone_ISV.Enabled = false;
            buttonDone_ISV.FlatStyle = FlatStyle.Flat;
            buttonDone_ISV.Location = new Point(336, 54);
            buttonDone_ISV.Margin = new Padding(7, 7, 7, 7);
            buttonDone_ISV.Name = "buttonDone_ISV";
            buttonDone_ISV.Size = new Size(233, 111);
            buttonDone_ISV.TabIndex = 0;
            toolTip_ISV.SetToolTip(buttonDone_ISV, "Выполнить\r\nПроизводит поиск слов, содержащих \"b\" и выводит их в результирующую строку");
            buttonDone_ISV.UseVisualStyleBackColor = false;
            buttonDone_ISV.Click += buttonDone_ISV_Click;
            buttonDone_ISV.MouseEnter += buttonDone_ISV_MouseEnter;
            buttonDone_ISV.MouseLeave += buttonDone_ISV_MouseLeave;
            // 
            // buttonOpenFile_ISV
            // 
            buttonOpenFile_ISV.BackColor = Color.LightBlue;
            buttonOpenFile_ISV.BackgroundImage = Properties.Resources.application_form_add;
            buttonOpenFile_ISV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpenFile_ISV.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_ISV.Location = new Point(28, 54);
            buttonOpenFile_ISV.Margin = new Padding(1);
            buttonOpenFile_ISV.Name = "buttonOpenFile_ISV";
            buttonOpenFile_ISV.Size = new Size(233, 111);
            buttonOpenFile_ISV.TabIndex = 0;
            toolTip_ISV.SetToolTip(buttonOpenFile_ISV, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_ISV.UseVisualStyleBackColor = false;
            buttonOpenFile_ISV.Click += buttonOpenFile_ISV_Click;
            // 
            // panelTask_ISV
            // 
            panelTask_ISV.Controls.Add(groupBoxTask_ISV);
            panelTask_ISV.Dock = DockStyle.Top;
            panelTask_ISV.Location = new Point(0, 219);
            panelTask_ISV.Margin = new Padding(7, 7, 7, 7);
            panelTask_ISV.Name = "panelTask_ISV";
            panelTask_ISV.Size = new Size(1596, 236);
            panelTask_ISV.TabIndex = 1;
            // 
            // groupBoxTask_ISV
            // 
            groupBoxTask_ISV.Controls.Add(textBoxTask_ISV);
            groupBoxTask_ISV.Dock = DockStyle.Fill;
            groupBoxTask_ISV.Location = new Point(0, 0);
            groupBoxTask_ISV.Margin = new Padding(7, 7, 7, 7);
            groupBoxTask_ISV.Name = "groupBoxTask_ISV";
            groupBoxTask_ISV.Padding = new Padding(7, 7, 7, 7);
            groupBoxTask_ISV.Size = new Size(1596, 236);
            groupBoxTask_ISV.TabIndex = 0;
            groupBoxTask_ISV.TabStop = false;
            groupBoxTask_ISV.Text = "Условие";
            // 
            // textBoxTask_ISV
            // 
            textBoxTask_ISV.Dock = DockStyle.Fill;
            textBoxTask_ISV.Location = new Point(7, 39);
            textBoxTask_ISV.Margin = new Padding(7, 7, 7, 7);
            textBoxTask_ISV.Multiline = true;
            textBoxTask_ISV.Name = "textBoxTask_ISV";
            textBoxTask_ISV.ReadOnly = true;
            textBoxTask_ISV.Size = new Size(1582, 190);
            textBoxTask_ISV.TabIndex = 0;
            textBoxTask_ISV.Text = resources.GetString("textBoxTask_ISV.Text");
            // 
            // panelMain_ISV
            // 
            panelMain_ISV.Controls.Add(groupBoxOutPut_ISV);
            panelMain_ISV.Controls.Add(groupBoxInPut_ISV);
            panelMain_ISV.Dock = DockStyle.Fill;
            panelMain_ISV.Location = new Point(0, 455);
            panelMain_ISV.Margin = new Padding(7, 7, 7, 7);
            panelMain_ISV.Name = "panelMain_ISV";
            panelMain_ISV.Size = new Size(1596, 633);
            panelMain_ISV.TabIndex = 2;
            // 
            // groupBoxOutPut_ISV
            // 
            groupBoxOutPut_ISV.Controls.Add(textBoxOutPut_ISV);
            groupBoxOutPut_ISV.Dock = DockStyle.Fill;
            groupBoxOutPut_ISV.Location = new Point(821, 0);
            groupBoxOutPut_ISV.Margin = new Padding(7, 7, 7, 7);
            groupBoxOutPut_ISV.Name = "groupBoxOutPut_ISV";
            groupBoxOutPut_ISV.Padding = new Padding(7, 7, 7, 7);
            groupBoxOutPut_ISV.Size = new Size(775, 633);
            groupBoxOutPut_ISV.TabIndex = 1;
            groupBoxOutPut_ISV.TabStop = false;
            groupBoxOutPut_ISV.Text = "Вывод данных";
            // 
            // textBoxOutPut_ISV
            // 
            textBoxOutPut_ISV.Dock = DockStyle.Fill;
            textBoxOutPut_ISV.Location = new Point(7, 39);
            textBoxOutPut_ISV.Margin = new Padding(7, 7, 7, 7);
            textBoxOutPut_ISV.Multiline = true;
            textBoxOutPut_ISV.Name = "textBoxOutPut_ISV";
            textBoxOutPut_ISV.ReadOnly = true;
            textBoxOutPut_ISV.Size = new Size(761, 587);
            textBoxOutPut_ISV.TabIndex = 0;
            // 
            // groupBoxInPut_ISV
            // 
            groupBoxInPut_ISV.Controls.Add(textBoxInPut_ISV);
            groupBoxInPut_ISV.Dock = DockStyle.Left;
            groupBoxInPut_ISV.Location = new Point(0, 0);
            groupBoxInPut_ISV.Margin = new Padding(7, 7, 7, 7);
            groupBoxInPut_ISV.Name = "groupBoxInPut_ISV";
            groupBoxInPut_ISV.Padding = new Padding(7, 7, 7, 7);
            groupBoxInPut_ISV.Size = new Size(821, 633);
            groupBoxInPut_ISV.TabIndex = 0;
            groupBoxInPut_ISV.TabStop = false;
            groupBoxInPut_ISV.Text = "Ввод данных";
            // 
            // textBoxInPut_ISV
            // 
            textBoxInPut_ISV.Dock = DockStyle.Fill;
            textBoxInPut_ISV.Location = new Point(7, 39);
            textBoxInPut_ISV.Margin = new Padding(7, 7, 7, 7);
            textBoxInPut_ISV.Multiline = true;
            textBoxInPut_ISV.Name = "textBoxInPut_ISV";
            textBoxInPut_ISV.ReadOnly = true;
            textBoxInPut_ISV.Size = new Size(807, 587);
            textBoxInPut_ISV.TabIndex = 0;
            // 
            // openFileDialogTask_ISV
            // 
            openFileDialogTask_ISV.FileName = "openFileDialog1";
            // 
            // toolTip_ISV
            // 
            toolTip_ISV.ToolTipIcon = ToolTipIcon.Info;
            toolTip_ISV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1596, 1088);
            Controls.Add(panelMain_ISV);
            Controls.Add(panelTask_ISV);
            Controls.Add(panelButtons_ISV);
            Margin = new Padding(7, 7, 7, 7);
            MinimumSize = new Size(1599, 1078);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 16 | иванов с. в.";
            panelButtons_ISV.ResumeLayout(false);
            panelTask_ISV.ResumeLayout(false);
            groupBoxTask_ISV.ResumeLayout(false);
            groupBoxTask_ISV.PerformLayout();
            panelMain_ISV.ResumeLayout(false);
            groupBoxOutPut_ISV.ResumeLayout(false);
            groupBoxOutPut_ISV.PerformLayout();
            groupBoxInPut_ISV.ResumeLayout(false);
            groupBoxInPut_ISV.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_ISV;
        private System.Windows.Forms.Panel panelTask_ISV;
        private System.Windows.Forms.GroupBox groupBoxTask_ISV;
        private System.Windows.Forms.TextBox textBoxTask_ISV;
        private System.Windows.Forms.Panel panelMain_ISV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_ISV;
        private System.Windows.Forms.GroupBox groupBoxInPut_ISV;
        private System.Windows.Forms.Button buttonDone_ISV;
        private System.Windows.Forms.Button buttonOpenFile_ISV;
        private System.Windows.Forms.TextBox textBoxOutPut_ISV;
        private System.Windows.Forms.TextBox textBoxInPut_ISV;
        private System.Windows.Forms.Button buttonInfo_ISV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_ISV;
        private System.Windows.Forms.ToolTip toolTip_ISV;
    }

}