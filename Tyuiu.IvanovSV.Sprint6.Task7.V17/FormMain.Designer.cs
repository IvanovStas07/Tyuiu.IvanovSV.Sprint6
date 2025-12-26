using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.IvanovSV.Sprint6.Task7.V17
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_ISV = new Panel();
            buttonOpenFile_ISV = new Button();
            buttonStart_ISV = new Button();
            buttonSaveFile_ISV = new Button();
            buttonHelp_ISV = new Button();
            panelCondition_ISV = new Panel();
            groupBoxCondition_ISV = new GroupBox();
            labelCondition_ISV = new Label();
            panelBoxIn_ISV = new Panel();
            groupBoxIn_ISV = new GroupBox();
            dataGridViewIn_ISV = new DataGridView();
            dataGridViewOut_ISV = new DataGridView();
            toolTipButton = new ToolTip(components);
            openFileDialogTask7 = new OpenFileDialog();
            saveFileDialogTask7 = new SaveFileDialog();
            panelBoxOut_ISV = new Panel();
            groupBoxOut_ISV = new GroupBox();
            splitterRight = new Splitter();
            panelButtons_ISV.SuspendLayout();
            panelCondition_ISV.SuspendLayout();
            groupBoxCondition_ISV.SuspendLayout();
            panelBoxIn_ISV.SuspendLayout();
            groupBoxIn_ISV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_ISV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_ISV).BeginInit();
            panelBoxOut_ISV.SuspendLayout();
            groupBoxOut_ISV.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons_ISV
            // 
            panelButtons_ISV.AutoSize = true;
            panelButtons_ISV.Controls.Add(buttonOpenFile_ISV);
            panelButtons_ISV.Controls.Add(buttonStart_ISV);
            panelButtons_ISV.Controls.Add(buttonSaveFile_ISV);
            panelButtons_ISV.Controls.Add(buttonHelp_ISV);
            panelButtons_ISV.Dock = DockStyle.Top;
            panelButtons_ISV.Location = new Point(0, 0);
            panelButtons_ISV.Margin = new Padding(4);
            panelButtons_ISV.Name = "panelButtons_ISV";
            panelButtons_ISV.Padding = new Padding(5);
            panelButtons_ISV.Size = new Size(2185, 140);
            panelButtons_ISV.TabIndex = 0;
            // 
            // buttonOpenFile_ISV
            // 
            buttonOpenFile_ISV.Image = Properties.Resources.package_go;
            buttonOpenFile_ISV.Location = new Point(77, 11);
            buttonOpenFile_ISV.Margin = new Padding(4);
            buttonOpenFile_ISV.Name = "buttonOpenFile_ISV";
            buttonOpenFile_ISV.Size = new Size(150, 114);
            buttonOpenFile_ISV.TabIndex = 1;
            toolTipButton.SetToolTip(buttonOpenFile_ISV, "Открыть файл для обработки данных в формате CSV");
            buttonOpenFile_ISV.UseVisualStyleBackColor = true;
            buttonOpenFile_ISV.Click += buttonOpenFile_Click;
            buttonOpenFile_ISV.MouseEnter += buttonOpenFile_MouseEnter;
            // 
            // buttonStart_ISV
            // 
            buttonStart_ISV.Enabled = false;
            buttonStart_ISV.Image = Properties.Resources.arrow_right;
            buttonStart_ISV.Location = new Point(297, 7);
            buttonStart_ISV.Margin = new Padding(4);
            buttonStart_ISV.Name = "buttonStart_ISV";
            buttonStart_ISV.Size = new Size(167, 114);
            buttonStart_ISV.TabIndex = 2;
            toolTipButton.SetToolTip(buttonStart_ISV, "Выполнить обработку данных");
            buttonStart_ISV.UseVisualStyleBackColor = true;
            buttonStart_ISV.Click += buttonStart_Click;
            buttonStart_ISV.MouseEnter += buttonStart_MouseEnter;
            // 
            // buttonSaveFile_ISV
            // 
            buttonSaveFile_ISV.Enabled = false;
            buttonSaveFile_ISV.Image = Properties.Resources.accept;
            buttonSaveFile_ISV.Location = new Point(540, 9);
            buttonSaveFile_ISV.Margin = new Padding(4);
            buttonSaveFile_ISV.Name = "buttonSaveFile_ISV";
            buttonSaveFile_ISV.Size = new Size(171, 111);
            buttonSaveFile_ISV.TabIndex = 3;
            toolTipButton.SetToolTip(buttonSaveFile_ISV, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_ISV.UseVisualStyleBackColor = true;
            buttonSaveFile_ISV.Click += buttonSaveFile_Click;
            buttonSaveFile_ISV.MouseEnter += buttonSaveFile_MouseEnter;
            // 
            // buttonHelp_ISV
            // 
            buttonHelp_ISV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_ISV.AutoSize = true;
            buttonHelp_ISV.Image = Properties.Resources.information;
            buttonHelp_ISV.Location = new Point(2006, 5);
            buttonHelp_ISV.Margin = new Padding(4);
            buttonHelp_ISV.Name = "buttonHelp_ISV";
            buttonHelp_ISV.Size = new Size(174, 126);
            buttonHelp_ISV.TabIndex = 0;
            toolTipButton.SetToolTip(buttonHelp_ISV, "Сведения о программе");
            buttonHelp_ISV.UseVisualStyleBackColor = true;
            buttonHelp_ISV.Click += buttonHelp_Click;
            // 
            // panelCondition_ISV
            // 
            panelCondition_ISV.Controls.Add(groupBoxCondition_ISV);
            panelCondition_ISV.Dock = DockStyle.Top;
            panelCondition_ISV.Location = new Point(0, 140);
            panelCondition_ISV.Margin = new Padding(4);
            panelCondition_ISV.Name = "panelCondition_ISV";
            panelCondition_ISV.Size = new Size(2185, 102);
            panelCondition_ISV.TabIndex = 1;
            // 
            // groupBoxCondition_ISV
            // 
            groupBoxCondition_ISV.AutoSize = true;
            groupBoxCondition_ISV.Controls.Add(labelCondition_ISV);
            groupBoxCondition_ISV.Dock = DockStyle.Fill;
            groupBoxCondition_ISV.Location = new Point(0, 0);
            groupBoxCondition_ISV.Margin = new Padding(4);
            groupBoxCondition_ISV.Name = "groupBoxCondition_ISV";
            groupBoxCondition_ISV.Padding = new Padding(4);
            groupBoxCondition_ISV.Size = new Size(2185, 102);
            groupBoxCondition_ISV.TabIndex = 0;
            groupBoxCondition_ISV.TabStop = false;
            groupBoxCondition_ISV.Text = resources.GetString("groupBoxCondition_ISV.Text");
            // 
            // labelCondition_ISV
            // 
            labelCondition_ISV.AutoSize = true;
            labelCondition_ISV.Location = new Point(11, 36);
            labelCondition_ISV.Margin = new Padding(4, 0, 4, 0);
            labelCondition_ISV.Name = "labelCondition_ISV";
            labelCondition_ISV.Size = new Size(0, 32);
            labelCondition_ISV.TabIndex = 0;
            // 
            // panelBoxIn_ISV
            // 
            panelBoxIn_ISV.AutoScroll = true;
            panelBoxIn_ISV.BorderStyle = BorderStyle.FixedSingle;
            panelBoxIn_ISV.Controls.Add(groupBoxIn_ISV);
            panelBoxIn_ISV.Dock = DockStyle.Left;
            panelBoxIn_ISV.Location = new Point(0, 242);
            panelBoxIn_ISV.Margin = new Padding(4);
            panelBoxIn_ISV.Name = "panelBoxIn_ISV";
            panelBoxIn_ISV.Padding = new Padding(6);
            panelBoxIn_ISV.Size = new Size(1148, 911);
            panelBoxIn_ISV.TabIndex = 2;
            // 
            // groupBoxIn_ISV
            // 
            groupBoxIn_ISV.AutoSize = true;
            groupBoxIn_ISV.Controls.Add(dataGridViewIn_ISV);
            groupBoxIn_ISV.Dock = DockStyle.Fill;
            groupBoxIn_ISV.Location = new Point(6, 6);
            groupBoxIn_ISV.Margin = new Padding(4);
            groupBoxIn_ISV.Name = "groupBoxIn_ISV";
            groupBoxIn_ISV.Padding = new Padding(4, 200, 4, 4);
            groupBoxIn_ISV.Size = new Size(1134, 897);
            groupBoxIn_ISV.TabIndex = 0;
            groupBoxIn_ISV.TabStop = false;
            groupBoxIn_ISV.Text = "Ввод";
            groupBoxIn_ISV.Enter += groupBoxIn_ISV_Enter;
            // 
            // dataGridViewIn_ISV
            // 
            dataGridViewIn_ISV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_ISV.ColumnHeadersVisible = false;
            dataGridViewIn_ISV.Dock = DockStyle.Fill;
            dataGridViewIn_ISV.Location = new Point(4, 232);
            dataGridViewIn_ISV.Margin = new Padding(4);
            dataGridViewIn_ISV.Name = "dataGridViewIn_ISV";
            dataGridViewIn_ISV.ReadOnly = true;
            dataGridViewIn_ISV.RowHeadersVisible = false;
            dataGridViewIn_ISV.RowHeadersWidth = 62;
            dataGridViewIn_ISV.ScrollBars = ScrollBars.Vertical;
            dataGridViewIn_ISV.Size = new Size(1126, 661);
            dataGridViewIn_ISV.TabIndex = 0;
            dataGridViewIn_ISV.CellContentClick += dataGridViewIn_ISV_CellContentClick;
            // 
            // dataGridViewOut_ISV
            // 
            dataGridViewOut_ISV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_ISV.Dock = DockStyle.Fill;
            dataGridViewOut_ISV.Location = new Point(4, 232);
            dataGridViewOut_ISV.Margin = new Padding(4);
            dataGridViewOut_ISV.Name = "dataGridViewOut_ISV";
            dataGridViewOut_ISV.ReadOnly = true;
            dataGridViewOut_ISV.RowHeadersWidth = 62;
            dataGridViewOut_ISV.ScrollBars = ScrollBars.Vertical;
            dataGridViewOut_ISV.Size = new Size(1058, 673);
            dataGridViewOut_ISV.TabIndex = 0;
            dataGridViewOut_ISV.CellContentClick += dataGridViewOut_ISV_CellContentClick;
            // 
            // openFileDialogTask7
            // 
            openFileDialogTask7.FileName = "openFileDialog1";
            // 
            // panelBoxOut_ISV
            // 
            panelBoxOut_ISV.BorderStyle = BorderStyle.FixedSingle;
            panelBoxOut_ISV.Controls.Add(groupBoxOut_ISV);
            panelBoxOut_ISV.Dock = DockStyle.Right;
            panelBoxOut_ISV.Location = new Point(1117, 242);
            panelBoxOut_ISV.Name = "panelBoxOut_ISV";
            panelBoxOut_ISV.Size = new Size(1068, 911);
            panelBoxOut_ISV.TabIndex = 1;
            // 
            // groupBoxOut_ISV
            // 
            groupBoxOut_ISV.AutoSize = true;
            groupBoxOut_ISV.Controls.Add(dataGridViewOut_ISV);
            groupBoxOut_ISV.Dock = DockStyle.Fill;
            groupBoxOut_ISV.Location = new Point(0, 0);
            groupBoxOut_ISV.Margin = new Padding(4);
            groupBoxOut_ISV.Name = "groupBoxOut_ISV";
            groupBoxOut_ISV.Padding = new Padding(4, 200, 4, 4);
            groupBoxOut_ISV.Size = new Size(1066, 909);
            groupBoxOut_ISV.TabIndex = 0;
            groupBoxOut_ISV.TabStop = false;
            groupBoxOut_ISV.Text = "Вывод";
            // 
            // splitterRight
            // 
            splitterRight.BackColor = SystemColors.ActiveCaptionText;
            splitterRight.Dock = DockStyle.Right;
            splitterRight.Location = new Point(1100, 242);
            splitterRight.Name = "splitterRight";
            splitterRight.Size = new Size(17, 911);
            splitterRight.TabIndex = 4;
            splitterRight.TabStop = false;
            splitterRight.SplitterMoved += splitter2_SplitterMoved_1;
            // 
            // FormMain
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            ClientSize = new Size(2185, 1153);
            Controls.Add(splitterRight);
            Controls.Add(panelBoxOut_ISV);
            Controls.Add(panelBoxIn_ISV);
            Controls.Add(panelCondition_ISV);
            Controls.Add(panelButtons_ISV);
            Margin = new Padding(4);
            MinimumSize = new Size(1671, 974);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 17 | Иванов С. В.";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panelButtons_ISV.ResumeLayout(false);
            panelButtons_ISV.PerformLayout();
            panelCondition_ISV.ResumeLayout(false);
            panelCondition_ISV.PerformLayout();
            groupBoxCondition_ISV.ResumeLayout(false);
            groupBoxCondition_ISV.PerformLayout();
            panelBoxIn_ISV.ResumeLayout(false);
            panelBoxIn_ISV.PerformLayout();
            groupBoxIn_ISV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_ISV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_ISV).EndInit();
            panelBoxOut_ISV.ResumeLayout(false);
            panelBoxOut_ISV.PerformLayout();
            groupBoxOut_ISV.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelButtons_ISV;
        private Button buttonHelp_ISV;
        private Button buttonSaveFile_ISV;
        private Button buttonStart_ISV;
        private Button buttonOpenFile_ISV;
        private Panel panelCondition_ISV;
        private GroupBox groupBoxCondition_ISV;
        private Panel panelBoxIn_ISV;
        private GroupBox groupBoxIn_ISV;
        private DataGridView dataGridViewIn_ISV;
        private DataGridView dataGridViewOut_ISV;
        private Label labelCondition_ISV;
        private ToolTip toolTipButton;
        private OpenFileDialog openFileDialogTask7;
        private SaveFileDialog saveFileDialogTask7;
        private Panel panelBoxOut_ISV;
        private GroupBox groupBoxOut_ISV;
        private Splitter splitterRight;
    }
}