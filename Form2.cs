using MaterialSkin.Controls;
using MaterialSkin;
using Vitek.Logic;

namespace Vitek
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            comboBox1.Items.AddRange(PlaneManager.Cities);
            comboBox2.Items.AddRange(PlaneManager.Hotels);
            comboBox1.KeyPress += InputOnlyLetter;
            comboBox1.KeyPress += InputOnlyLetter;
            textBox1.KeyPress += InputOnlyNumbers;
            textBox2.KeyPress += InputOnlyNumbers;
            textBox3.KeyPress += InputOnlyNumbers;
            textBox7.KeyPress += InputOnlyNumbers;
        }

        private void Plain_Click(object sender, EventArgs e)
        {
            try
            {
                PlaneManager.SelectPlane(new Plain { Town = Convert.ToString(comboBox1.Text), Vector = checkBox1.Checked, dateTime = Convert.ToDateTime($"{textBox1.Text}/{textBox2.Text}/{textBox3.Text}") });
                MessageBox.Show("Авиабилет успешно куплен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PlainChecked_Click(object sender, EventArgs e)
        {
            try
            {
                label10.Text = Convert.ToString(PlaneManager.PlaneChecked(new Plain { Town = Convert.ToString(comboBox1.Text), Vector = checkBox1.Checked, dateTime = Convert.ToDateTime($"{textBox1.Text}/{textBox2.Text}/{textBox3.Text}") }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Hotel_Click(object sender, EventArgs e)
        {
            HotelManager.CreateHotel(new Hotels { Name = Convert.ToString(comboBox2.Text),Lvl=Convert.ToByte(label13.Text), Num = Convert.ToInt32(textBox7.Text), Days = Convert.ToInt32(textBox4.Text), Variant = checkBox2.Checked });
            MessageBox.Show("Гостиница успешна забронирована.");
        }
        private void HoteChecked_Click(object sender, EventArgs e)
        {
            try
            {
                label11.Text = Convert.ToString(HotelManager.HotelCheked(new Hotels { Name = Convert.ToString(comboBox2.Text), Num = Convert.ToInt32(textBox7.Text),Days=Convert.ToInt32(textBox4.Text), Variant = checkBox2.Checked }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void InputOnlyLetter(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void InputOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
        private void Selecter(object sender, EventArgs e)
        {
            switch(comboBox2.Text)
            {
                case "Курортная":
                    label13.Text = "5";
                    break;
                case "Верховина":
                    label13.Text = "4";
                    break;
                case "Гуцулка":
                    label13.Text = "3";
                    break;
            }
        }
        private void Error(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                if (int.Parse(textBox7.Text) > 2 || int.Parse(textBox7.Text) < 1) textBox7.BackColor = Color.Red;
                else textBox7.BackColor = Color.White;
            }
            else textBox7.BackColor = Color.White;
        }
    }
}
