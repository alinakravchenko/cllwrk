namespace cllwrk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e) //���������� ������� ������
        {
            ToolStripMenuItem it = (ToolStripMenuItem)sender; //������ ������, �������� ������������� ������ ������� 
            if (it.Checked == true)
            {
                this.BackColor = Color.Purple;
            }
            mi_theme_Dark.Checked = false;
        }

        private void mi_theme_Dark_Click(object sender, EventArgs e) //���������� ����� ������
        {
            if (mi_theme_Dark.Checked == true)
            {
                this.BackColor = Color.DarkGoldenrod;
            }
           
            mi_theme_Light.Checked = false;
        }
    }
}