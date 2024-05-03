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

            if (radioButton1.Checked == true) gender = "남";
            else gender = "여";

            string checkB = "";
            if (checkBox1.Checked == true) checkB += "여행 ";
            if (checkBox2.Checked == true) checkB += "쇼핑 ";
            if (checkBox3.Checked == true) checkB += "게임 ";
            if (checkBox4.Checked == true) checkB += "기타 ";


            MessageBox.Show("이름 " +textBox1.Text +
                "\n성별: " + gender +
                "\n아이디: " + textBox2.Text +
                "\n비밀번호: " + textBox3.Text +
                "\n비밀번호 재입력: " + textBox4.Text + 
                "\n주소: " + textBox5.Text +
                "\n이메일: " + textBox6.Text + "@" + textBox7.Text + " " + comboBox1.Text +
                "\n전화번호: " + comboBox2.Text + textBox8.Text+ textBox9.Text +
                "\n취미: " + checkB +
                "\n자기소개: " + textBox10.Text);
        }

        //콤보박스 선택한거
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox7.Text = comboBox1.Text;
        }

        //이메일텍스트
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