namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (radioButton1.Checked == true) gender = "��";
            else gender = "��";

            string checkB = "";
            if (checkBox1.Checked == true) checkB += "���� ";
            if (checkBox2.Checked == true) checkB += "���� ";
            if (checkBox3.Checked == true) checkB += "���� ";
            if (checkBox4.Checked == true) checkB += "��Ÿ ";


            MessageBox.Show("�̸� " +textBox1.Text +
                "\n����: " + gender +
                "\n���̵�: " + textBox2.Text +
                "\n��й�ȣ: " + textBox3.Text +
                "\n��й�ȣ ���Է�: " + textBox4.Text + 
                "\n�ּ�: " + textBox5.Text +
                "\n�̸���: " + textBox6.Text + "@" + textBox7.Text + " " + comboBox1.Text +
                "\n��ȭ��ȣ: " + comboBox2.Text + textBox8.Text+ textBox9.Text +
                "\n���: " + checkB +
                "\n�ڱ�Ұ�: " + textBox10.Text);
        }

        //�޺��ڽ� �����Ѱ�
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox7.Text = comboBox1.Text;
        }

        //�̸����ؽ�Ʈ
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}