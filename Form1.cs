namespace trpo_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var comboBoxList = new List<object>();
            comboBoxList.Add(new { Name = "Ленточный", Id = 1 });
            comboBoxList.Add(new { Name = "Столбчатый", Id = 2 });
            comboBoxList.Add(new { Name = "Плитный", Id = 3 });
            comboBoxList.Add(new { Name = "Свайно-ростверковый", Id = 4 });
            comboBoxList.Add(new { Name = "Плитный фундамент с цоколем", Id = 5 });

            comboBox.DataSource = comboBoxList;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox.SelectedItem as dynamic;
            var id = (int)item.Id;

            switch (id)
            {
                case 1:
                case 4:
                case 5:
                    textBox_length.Enabled = true;
                    textBox_width.Enabled = true;
                    textBox_height.Enabled = true;
                    textBox_thickness.Enabled = true;
                    break;
                case 2:
                    textBox_length.Enabled = true;
                    textBox_width.Enabled = true;
                    textBox_height.Enabled = true;
                    textBox_thickness.Enabled = false;
                    break;
                case 3:
                    textBox_length.Enabled = true;
                    textBox_width.Enabled = true;
                    textBox_height.Enabled = false;
                    textBox_thickness.Enabled = false;
                    break;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            var item = comboBox.SelectedItem as dynamic;
            var id = (int)item.Id;
            switch (id)
            {
                case 1:
                    RibbonFoundation();
                    break;
                case 2:
                    ColumnarFoundation();
                    break;
                case 3:
                    SlabFoundation();
                    break;
                case 4:
                    PileGrillageFoundation();
                    break;
                case 5:
                    SlabBaseFoundation();
                    break;
            }
        }

        private void RibbonFoundation()
        {
            var cost = double.Parse(textBox_cost.Text);
            var length = double.Parse(textBox_length.Text);
            var width = double.Parse(textBox_width.Text);
            var height = double.Parse(textBox_height.Text);
            var thickness = double.Parse(textBox_thickness.Text);
            var volume = Math.Round(length * width * height * thickness, 4);
            var totalCost = Math.Round(volume * cost, 2);
            label_volume.Text = volume.ToString();
            label_cost.Text = totalCost.ToString();
        }

        private void ColumnarFoundation()
        {
            var cost = double.Parse(textBox_cost.Text);
            var length = double.Parse(textBox_length.Text);
            var width = double.Parse(textBox_width.Text);
            var height = double.Parse(textBox_height.Text);
            var perimetr = width + height;
            var column = length * 0.16;
            var volume = Math.Round(perimetr * column, 4);
            var totalCost = Math.Round(volume * cost, 2);
            label_volume.Text = volume.ToString();
            label_cost.Text = totalCost.ToString();
        }
        private void SlabFoundation()
        {
            var cost = double.Parse(textBox_cost.Text);
            var length = double.Parse(textBox_length.Text);
            var width = double.Parse(textBox_width.Text);
            var volume = Math.Round(length * width * 0.25, 4);
            var totalCost = Math.Round(volume * cost, 2);
            label_volume.Text = volume.ToString();
            label_cost.Text = totalCost.ToString();
        }
        private void PileGrillageFoundation()
        {
            var cost = double.Parse(textBox_cost.Text);
            var length = double.Parse(textBox_length.Text);
            var width = double.Parse(textBox_width.Text);
            var height = double.Parse(textBox_height.Text);
            var thickness = double.Parse(textBox_thickness.Text);
            var pileHeigth = 1.5;
            var column = pileHeigth * 0.16;
            var perimetr = width + height;
            var pileVolume = perimetr * column;
            var volume = Math.Round(length * width * height * thickness + pileVolume, 4);
            var totalCost = Math.Round(volume * cost, 2);
            label_volume.Text = volume.ToString();
            label_cost.Text = totalCost.ToString();
        }
        private void SlabBaseFoundation()
        {
            var cost = double.Parse(textBox_cost.Text);
            var length = double.Parse(textBox_length.Text);
            var width = double.Parse(textBox_width.Text);
            var height = double.Parse(textBox_height.Text);
            var thickness = double.Parse(textBox_thickness.Text);
            var perimetr = width + height;
            var slabVolume = length * width * 0.25 * perimetr;
            var volume = Math.Round(length * width * height * thickness + slabVolume, 4);
            var totalCost = Math.Round(volume * cost, 2);
            label_volume.Text = volume.ToString();
            label_cost.Text = totalCost.ToString();
        }

        private void label_volume_Click(object sender, EventArgs e)
        {

        }
    }
}