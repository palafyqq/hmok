using MaterialSkin.Controls;
using hmok.Code;
using hmok.Forms;

namespace hmok
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            ListServiceForm listServiceForm = new ListServiceForm();
            switch (materialTextBox21.Text)
            {
                case "0000":
                   GlobalVar.AdministrationMode= true;
                    listServiceForm.Show();
                    this.Hide();
                    MessageBox.Show("Вы вошли с правами Администратора", "Информация",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "":
                    GlobalVar.AdministrationMode= false;
                    listServiceForm.Show();
                    this.Hide();
                    MessageBox.Show("Вы вошли под обычным пользовтателем", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Не верный код! Оставьте поле пустым, если хотите войти под обычным пользователем", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;



            }
        }
    }
}