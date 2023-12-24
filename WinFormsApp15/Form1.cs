namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float hm = 6.95f;
            float pz = 5.95f;
            float sa = 4.95f;
            if (radioButton1.Checked)
            {
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {

                    float x = hm + (0.75f * (i + 1));
                    float y = (((hm + 0.75f) * 0.775f) / 100);
                    float sum = x + y;
                    textBox1.Text = x.ToString();
                    textBox2.Text = sum.ToString();
                    textBox3.Text = sum.ToString();
                    hm = 6.95f;
                    x = (float)System.Math.Round(x, 1);

                    sum = (float)System.Math.Round(sum, 1);
                }
            }

            else if (radioButton2.Checked)
            {
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {

                    float x = pz + (0.50f * (i + 1));
                    float y = (((pz + 0.75f) * 0.775f) / 100);
                    float sum = x + y;
                    textBox1.Text = x.ToString();
                    textBox2.Text = sum.ToString();
                    textBox3.Text = sum.ToString();
                    pz = 5.95f;
                    x = (float)System.Math.Round(x, 1);
                    sum = (float)System.Math.Round(sum, 1);
                }


            }
            else if (radioButton3.Checked)
            {
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    float x = sa + (0.50f * (i + 1));
                    float y = (((sa + 0.75f) * 0.775f) / 100);
                    float sum = x + y;
                    textBox1.Text = x.ToString();
                    textBox2.Text = sum.ToString();
                    textBox3.Text = sum.ToString();
                    sa = 4.95f;
                    x= (float)System.Math.Round(x, 1);
                    sum = (float)System.Math.Round(sum, 1);
                }
            }
        }
    }
}