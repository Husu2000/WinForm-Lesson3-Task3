using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = users;

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            User u = new(NameBox.Text, SurnameBox.Text, EmailBox.Text, PhoneBox.Text, DateTime.Parse(dateTimePicker1.Text));
            users[listBox1.SelectedIndex] = u;
            listBox1.DataSource = null;
            listBox1.DataSource = users;
            NameBox.Text = string.Empty;
            SurnameBox.Text = string.Empty;
            EmailBox.Text = string.Empty;
            PhoneBox.Text = string.Empty;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            User u = new(NameBox.Text, SurnameBox.Text, EmailBox.Text, PhoneBox.Text, DateTime.Parse(dateTimePicker1.Text));
            users.Add(u);
            listBox1.DataSource = null;
            listBox1.DataSource = users;
            NameBox.Text = string.Empty;
            SurnameBox.Text = string.Empty;
            EmailBox.Text = string.Empty;
            PhoneBox.Text = string.Empty;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            users = Functions.ReadUserToJson(FileBox.Text);
            FileBox.Text = string.Empty;
            listBox1.DataSource = null;
            listBox1.DataSource = users;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Functions.WriteUserTojson(users, FileBox.Text);
            users.Clear();
            listBox1.DataSource = null;
            listBox1.DataSource = users;
            FileBox.Text = string.Empty;
        }
    }
}