namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_msg.Text = "�޺� �ڽ� �׸� �߰�, �ε���:" + cbox.Items.Count + " Text: " + cbox.Text;
            cbox.Items.Add(cbox.Text);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            lb_msg.Text = "�޺� �ڽ� �׸� ����, �ε���:" + cbox.SelectedIndex + " Text: " + cbox.SelectedItem;
            cbox.Items.Remove(cbox.SelectedItem);

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            lbox2.Items.Clear();
            lbox2.Items.Add("�޺� �ڽ� �׸� ����: " + cbox.Items.Count);
            lbox2.Items.Add("�޺� �ڽ� ���� �׸�: " + cbox.SelectedIndex);

            lbox2.Items.Add("����Ʈ �ڽ� �׸� ����: " + lbox_1.Items.Count);
            lbox2.Items.Add("����Ʈ �ڽ� ���� �׸�: " + lbox_1.SelectedIndex);

            lbox2.Items.Add("üũ ����Ʈ �ڽ� �׸� ����: " + chbox.Items.Count);
            lbox2.Items.Add("üũ ����Ʈ �ڽ� ���� �׸�: " + chbox.SelectedIndex);


            lbox2.Items.Add("üũ ����Ʈ �ڽ� üũ ���� ��� ");
            foreach (object i in chbox.CheckedItems)
            {
                lbox2.Items.Add(i);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lb_msg.Text = "����Ʈ �ڽ� �׸� �߰�, �ε���:" + lbox_1.Items.Count + " Text: " + tbox_1.Text;
            lbox_1.Items.Add(tbox_1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lb_msg.Text = "����Ʈ �ڽ� �׸� ����, �ε���:" + lbox_1.SelectedIndex + " Text: " + lbox_1.SelectedItem;
            lbox_1.Items.Remove(lbox_1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lb_msg.Text = "üũ ����Ʈ �ڽ� �׸� �߰�, �ε���:" + chbox.Items.Count + " Text: " + tbox_2.Text;
            chbox.Items.Add(tbox_2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lb_msg.Text = "üũ ����Ʈ �ڽ� �׸� ����, �ε���:" + chbox.SelectedIndex + " Text: " + chbox.SelectedItem;
            chbox.Items.Remove(chbox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}