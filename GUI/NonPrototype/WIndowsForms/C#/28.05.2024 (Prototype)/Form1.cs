using Microsoft.Win32;

namespace C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing); // �������
        }

        private void play_Click(object sender, EventArgs e)
        {

            RegistryKey localMachineKey = Registry.LocalMachine;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Ameteroz GitHub\SHLauncher\Setup", true);
            string Installed = key.GetValue("State").ToString();
            if (Installed == "True")
            {
                // ������ ����������
            };
            if (Installed == "False")
            {
                // ��������� ������
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // ������� ��-�� ����� ����
        {
            Environment.Exit(0);
        }

        private void settings_Click(object sender, EventArgs e) // ���� ����� �������� �� ����� ��������
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.StartPosition = FormStartPosition.CenterParent;
            form2.ShowDialog();
            this.Close();
        }
    }
}
