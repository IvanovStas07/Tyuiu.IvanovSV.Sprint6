using Tyuiu.IvanovSV.Sprint6.Task0.V14.Lib;

namespace Tyuiu.IvanovSV.Sprint6.Task0.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int x = int.Parse(textBoxInput_ISV.Text);
                double result = ds.Calculate(x);
                textBoxResult_ISV.Text = result.ToString("F3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void labelFormula_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxInput_ISV_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxOutput_ISV_Enter(object sender, EventArgs e)
        {

        }
    }
}
