namespace opsFormsApp1
{
    public partial class Form1 : Form
    {
        String operato = "" ;
        Double answer = 0 ;
        bool operatorperfome = false ;
        double probA,probB,popSize,probAandB;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this is the clear button
            txtElementa.Text = "";
            txtElementb.Text = "";
            txtPopulationsize.Text = "";
            txtPa.Text = "";
            txtPb.Text = "";
            txtPanb.Text = "";
            txtPaub.Text = "";
            txtPab.Text = "";
            warning.Visible = false;

           
           

        }

        private void numberss(object sender, EventArgs e)
        {
            if((txtBox9.Text == "0")||(operatorperfome))
                txtBox9.Clear();
            operatorperfome = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!txtBox9.Text.Contains("."))
                    txtBox9.Text = txtBox9.Text +button.Text;
            }else
                txtBox9.Text = txtBox9.Text + button.Text;
        }

        private void operation_butt(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (answer != 0)
            {
                button26.PerformClick();

                operato = button.Text;
                answer = Double.Parse(txtBox9.Text);
                currentnum.Text = answer + " " + operato;
                operatorperfome = true;
            }else
                operato = button.Text;
                answer = Double.Parse(txtBox9.Text);
                currentnum.Text = answer + " " + operato;
                operatorperfome = true;

        }

        private void clear_butt(object sender, EventArgs e)
        {
            txtBox9.Text="0";
            
        }

        private void clear_all(object sender, EventArgs e)
        {
            txtBox9.Text = "0";
            answer = 0;
        }

        private void equali(object sender, EventArgs e)
        {
            switch (operato)
            {
                case "+":
                    currentnum.Text = currentnum.Text  + txtBox9.Text;
                    txtBox9.Text = (answer+Double.Parse(txtBox9.Text)).ToString();
                   
                    break;
                case "-":
                    
                    txtBox9.Text = (answer - Double.Parse(txtBox9.Text)).ToString();
                    break;
                case "/":
                    txtBox9.Text = (answer / Double.Parse(txtBox9.Text)).ToString();
                    break;
                case "*":
                    txtBox9.Text = (answer * Double.Parse(txtBox9.Text)).ToString();
                    break;
            }
            answer = Double.Parse(txtBox9.Text);
            //currentnum.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtBox9.Text.Length > 0)
            {
                txtBox9.Text = txtBox9.Text.Remove(txtBox9.Text.Length - 1, 1);

            }
            if(txtBox9.Text == "")
            {
                txtBox9.Text = "0";
            }
        }

        private void btnProbB_Click(object sender, EventArgs e)
        {
            if (txtElementa.Text == "" || txtElementb.Text == "")
            {
                warning.Visible = true;
            }
            else
            {
                double a = Double.Parse(txtElementa.Text);
                double b = Double.Parse(txtElementb.Text);
                popSize = a + b;
                if (popSize == 0)
                {
                    warning.Text = "population size can not be 0";
                    warning.Visible = true;
                }
                else
                {
                    probB = b / popSize;
                    txtPb.Text = (probB).ToString();
                    txtPopulationsize.Text = popSize.ToString();
                    warning.Visible = false;
                }
            }
        }

        private void btnProbAandB_Click(object sender, EventArgs e)
        {
            Pofa.PerformClick();
            btnProbB.PerformClick();
            probAandB = probA * probB;
            txtPanb.Text=(probA*probB).ToString();
        }

        private void btnAgivenB_Click(object sender, EventArgs e)
        {
            btnProbB.PerformClick();
            btnProbAandB.PerformClick();
            if (probB == 0)
            {
                warning.Text = "Probability of B is 0";
                warning.Visible=true;   
            }
            else
            {

            txtPab.Text=(probAandB/probB).ToString();
                warning.Visible = false;
            }
        }

        private void txtPanb_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProbAunionB_Click(object sender, EventArgs e)
        {
            Pofa.PerformClick();
            btnProbB.PerformClick();
            txtPaub.Text=(probA+probB).ToString();  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Pofa_Click(object sender, EventArgs e)
        {
           if(txtElementa.Text == ""||txtElementb.Text=="")
            {
                warning.Visible = true;
            }
            else
            {
                double a = Double.Parse(txtElementa.Text);
                double b = Double.Parse(txtElementb.Text);
                popSize = a + b;
                if (popSize == 0)
                {
                    warning.Text = "population size can not be 0";
                    warning.Visible = true;
                }
                else
                {
                    probA = a / popSize;
                    txtPa.Text = (probA).ToString();
                    txtPopulationsize.Text = popSize.ToString();
                    warning.Visible = false;
                }
            }
             
        }
    }

}