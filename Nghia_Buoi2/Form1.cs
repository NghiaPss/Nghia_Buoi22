namespace Nghia_Buoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kq = string.Empty;
            if (txt_n.Text != string.Empty)
            {
                if (ktraSNT(int.Parse(txt_n.Text)))
                {
                    txt_kq.Text = "Là SNT";
                }
                else
                {
                    txt_kq.Text = "Không Là SNT";
                }
                for (int i = 2; i < int.Parse(txt_n.Text); i++)
                {
                    if (ktraSNT(i))
                    {
                        kq += " " + i;
                    }
                }
                txt_sn.Text = kq;
            }
    }
}
