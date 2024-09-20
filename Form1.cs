namespace math3
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        double operations_amount = 0;
        bool dot_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operation_pressed))
                textBox1.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void all_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operations_amount += 1;
            if (operations_amount == 1)
            {
                value = Double.Parse(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                value = operation_Result();
                textBox1.Text = value.ToString();
            }
            operation = b.Text;
            operation_pressed = true;
            dot_pressed = false;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!dot_pressed)
            {
                textBox1.Text = textBox1.Text + ',';
                dot_pressed = true;
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            
            value = operation_Result();
            textBox1.Text = value.ToString();

            operation_pressed = false;
            operations_amount = 0;
            dot_pressed = false;
            operation = "";
        }

        public double operation_Result()
        {
            switch (operation)
            {
                case "+":
                    return (value + Double.Parse(textBox1.Text));
                case "-":
                    return (value - Double.Parse(textBox1.Text));
                case "*":
                    return (value * Double.Parse(textBox1.Text));
                case "/":
                    return (value / Double.Parse(textBox1.Text));
                default:
                    return 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
