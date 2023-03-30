namespace CISESPORT
{
    public partial class FormInfo : Form
    {
        private Player _newPlayer;
        public FormInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string lastname = tbLastname.Text;
            string studentid = tbId.Text;
            string email = tbEmail.Text;
            string tel = tbTel.Text;
            string major = tbMajor.Text;
            string gname = tbGname.Text;
            int iAge = 0;

            try
            {
                string age = tbAge.Text;
                iAge = Int32.Parse(age);
            }
            catch (FormatException ex) {
                //Do something if have exception
                MessageBox.Show("คุณใส่ข้อมูลไม่ถูกต้อง");
                return;
            }
            catch (Exception ex) {
                //Do something if have exception
            }

            _newPlayer = new Player(name, lastname, studentid,
                email, tel, major, gname, iAge);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public Player getPlayer() { return _newPlayer; }
    }
}