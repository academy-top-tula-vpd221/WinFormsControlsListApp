namespace WinFormsControlsListApp
{
    public partial class Form1 : Form
    {
        List<User> users;
        List<Product> products;

        public Form1()
        {
            InitializeComponent();

            string[] cities = new[] { "Москва", "Тула", "Саратов", "Ростов" };

            users = new List<User>()
            {
                new(){ Name = "Bob", Age = 24 },
                new(){ Name = "Tom", Age = 19 },
                new(){ Name = "Sam", Age = 35 },
                new(){ Name = "Leo", Age = 27 },
                new(){ Name = "Joe", Age = 34 },
            };

            products = new List<Product>()
            {
                new(){ Title = "Phone", Year = 2019, Price = 18500 },
                new(){ Title = "TV", Year = 2015, Price = 34000 },
                new(){ Title = "DVD player", Year = 2001, Price = 5000 },
                new(){ Title = "Notebook", Year = 2020, Price = 42800 },
            };

            comboBox1.DataSource = products;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "Price";

            checkedListBox1.Items.AddRange(cities);

            domainUpDown1.Items.AddRange(cities);



            //foreach (User user in users)
            //    listBox1.Items.Add(user);

            //foreach (User user in users)
            //    comboBox1.Items.Add(user);

            //comboBox1.Items.AddRange(cities);


            //listBox1.Items.Add("Чита");
            //listBox1.Items.AddRange(new object[] { "Санкт Петербург", "Вологда", "Норильск" });


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add("Тюмень");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListBox list)
            {
                string str = "";
                decimal amount = 0;
                foreach (var item in list.SelectedItems)
                    //str += item.ToString() + '\n';
                    amount += (item as Product).Price;
                //str = list.SelectedValue.ToString();
                MessageBox.Show(amount.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var city = comboBox1.Text;
            if (!comboBox1.Items.Contains(city))
                comboBox1.Items.Add(city);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
                comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            users.Add(new() { Name = "Neo", Age = 41 });
            string s = "";
            foreach (var user in users)
                s += user.ToString() + '\n';
            MessageBox.Show(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!checkedListBox1.CheckedIndices.Contains(1))
                checkedListBox1.SetItemCheckState(1, CheckState.Indeterminate);
            else
                checkedListBox1.SetItemCheckState(1, CheckState.Unchecked);
        }
    }
}