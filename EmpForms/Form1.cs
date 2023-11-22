namespace EmpForms
{
    public partial class Form1 : Form
    {
        Employee KpmgEmp = new Employee();
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click2;
            button1.Click += Button1_Click3;

            KpmgEmp.Join += srikar_Join;
            KpmgEmp.Join += Rohit_Join;
            KpmgEmp.Join += Lekha_Join;
            KpmgEmp.Join += Keerthi_Join;

            KpmgEmp.Resign += srikar_Resign;






        }

        private void srikar_Resign(object? sender, EventArgs e)
        {
            MessageBox.Show("srikar  resigned kpmg sucessfully");
        }

        private void Keerthi_Join(object? sender, EventArgs e)
        {
            MessageBox.Show("keerthi joined kpmg sucessfully");
        }

        private void Lekha_Join(object? sender, EventArgs e)
        {
            MessageBox.Show("lekha joined kpmg sucessfully");
        }

        private void Rohit_Join(object? sender, EventArgs e)
        {
            MessageBox.Show("rohit joined kpmg sucessfully");
        }

        private void srikar_Join(object? sender, EventArgs e)
        {
            MessageBox.Show("srikar joined kpmg sucessfully");
        }

        private void Button1_Click3(object? sender, EventArgs e)
        {
            MessageBox.Show("you clicked the thrice");
        }

        private void Button1_Click2(object? sender, EventArgs e)
        {
            MessageBox.Show("you clicked the TWICE");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you clicked the button");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            KpmgEmp.TriggerResignEvent();
        }
    }
}