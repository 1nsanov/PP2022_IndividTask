using MaterialSkin.Controls;
using MaterialSkin;
using Vitek.Logic;

namespace Vitek
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            textBox1.KeyPress += InputOnlyLetter;
            textBox2.KeyPress += InputOnlyNumbers;
            textBox3.KeyPress += InputOnlyLetter;
            textBox4.KeyPress += InputOnlyNumbers;
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            try
            {
                if (LogicMainForm.Register(new User { Name = Convert.ToString(textBox1.Text), Age = Convert.ToInt32(textBox2.Text) }) == true)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("Регистрация прошла успешна");
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Все поля должны быть заполненными"); }
        }

        private void Auto_Click(object sender, EventArgs e)
        {
            try
            {
                if (LogicMainForm.Auth(new User { Name = Convert.ToString(textBox3.Text), Age = Convert.ToInt32(textBox4.Text) }) == true)
                    new Form2().Show();
            }
            catch (Exception ex)
            { MessageBox.Show("Все поля должны быть заполненными"); }
            
        }
        public void InputOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void InputOnlyLetter(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}