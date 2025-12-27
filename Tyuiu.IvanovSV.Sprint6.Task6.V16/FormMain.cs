using Tyuiu.IvanovSV.Sprint6.Task6.V16.Lib;
using Tyuiu.IvanovSV.Sprint6.Task7.V17;

namespace Tyuiu.IvanovSV.Sprint6.Task6.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_ISV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ISV.ShowDialog();
            openFilePath = openFileDialogTask_ISV.FileName;
            textBoxInPut_ISV.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_ISV.Text = "Нечто: " + openFilePath;
            buttonDone_ISV.Enabled = true;
        }

        private void buttonDone_ISV_Click(object sender, EventArgs e)
        {
            textBoxOutPut_ISV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonDone_ISV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_ISV.BackColor = Color.Green;
        }

        private void buttonDone_ISV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_ISV.BackColor = Color.LightGreen;
        }

        private void buttonInfo_ISV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}