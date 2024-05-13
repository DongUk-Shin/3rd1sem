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
            lb_msg.Text = "콤보 박스 항목 추가, 인덱스:" + cbox.Items.Count + " Text: " + cbox.Text;
            cbox.Items.Add(cbox.Text);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            lb_msg.Text = "콤보 박스 항목 삭제, 인덱스:" + cbox.SelectedIndex + " Text: " + cbox.SelectedItem;
            cbox.Items.Remove(cbox.SelectedItem);

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            lbox2.Items.Clear();
            lbox2.Items.Add("콤보 박스 항목 개수: " + cbox.Items.Count);
            lbox2.Items.Add("콤보 박스 선택 항목: " + cbox.SelectedIndex);

            lbox2.Items.Add("리스트 박스 항목 개수: " + lbox_1.Items.Count);
            lbox2.Items.Add("리스트 박스 선택 항목: " + lbox_1.SelectedIndex);

            lbox2.Items.Add("체크 리스트 박스 항목 개수: " + chbox.Items.Count);
            lbox2.Items.Add("체크 리스트 박스 선택 항목: " + chbox.SelectedIndex);


            lbox2.Items.Add("체크 리스트 박스 체크 상태 목록 ");
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
            lb_msg.Text = "리스트 박스 항목 추가, 인덱스:" + lbox_1.Items.Count + " Text: " + tbox_1.Text;
            lbox_1.Items.Add(tbox_1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lb_msg.Text = "리스트 박스 항목 삭제, 인덱스:" + lbox_1.SelectedIndex + " Text: " + lbox_1.SelectedItem;
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
            lb_msg.Text = "체크 리스트 박스 항목 추가, 인덱스:" + chbox.Items.Count + " Text: " + tbox_2.Text;
            chbox.Items.Add(tbox_2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lb_msg.Text = "체크 리스트 박스 항목 삭제, 인덱스:" + chbox.SelectedIndex + " Text: " + chbox.SelectedItem;
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