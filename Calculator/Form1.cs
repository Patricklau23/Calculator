

namespace Calculator
{
    public partial class Patrick : Form
    {
        //declare variable 
        private decimal valueFirst;
        private decimal valueSecond;
        private decimal result;
        private string operators;
        private double Sqrtvalue;
        private double Sqrtresult;
        private decimal inversevalue;
        private decimal inverseresult;
        private double Sqvalue;
        private double Sqresult;
        private double Sinvalue;
        private double Sinresult;
        private double Cosvalue;
        private double Cosresult;
        private double Logvalue;
        private double Logresult;


        public Patrick()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //When the user run the program, these will load up
            // It uses Unicode character, which has the code 00B1
            Plusminus.Text = "\u00B1";
            // The standard calculator button is checked 
            Standard.Checked = true;

        }

        private void AboutMe_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Standard_CheckedChanged(object sender, EventArgs e)
        {
            //Here I use tabcontrol to change the size
            //If the standard button is checked, then tabcontrol height is equal to width
            //And hide the other four that are in scientific mode
            if (Standard.Checked==true)
            {
                Calculator.Height = Calculator.Width;
                Square.Visible = false;
                Sin.Visible = false;
                Cos.Visible = false;
                Log.Visible = false;
            }
        }

        private void Scientific_CheckedChanged(object sender, EventArgs e)
        {
            //Here I use tabcontrol to change the size
            //If the scientific button is checked, then tabcontrol height increased by 60
            //And the other four are visible
            if (Scientific.Checked==true)
            {
                Calculator.Height += 60;
                Square.Visible = true;
                Sin.Visible = true;
                Cos.Visible = true;
                Log.Visible = true;
            }
            
        }

        private void Dark_CheckedChanged(object sender, EventArgs e)
        {
            //Here I use tagePage 1 instead of Form when changing the background color 
            //If the checkbox is checked, background color of tabecontrol and some font colors will be changed.
            if(Dark.Checked == true)
            {
                //change the tabecontrol.background color to DarkGray
                tabPage1.BackColor = Color.DarkGray;
                //change two radio and a checkbox font color to white
                this.ForeColor = Color.White;
                Scientific.ForeColor = Color.White;
                Standard.ForeColor = Color.White;
            }
            //otherwise, everything will be set default
            else
            {
                tabPage1.BackColor = DefaultBackColor;
                this.ForeColor = DefaultForeColor;
                Scientific.ForeColor = DefaultForeColor;
                Standard.ForeColor = DefaultForeColor;
            }
        }


        private void button0_Click(object sender, EventArgs e)
        {

            if (Result.Text == "0")
            {
                Result.Text = "0";
            }
            else
            {
                Result.Text = Result.Text + "0";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //When the user click on button 1, if the result is 0, display 1, otherwise display result + string "1"
            if (Result.Text == "0")
            {
                Result.Text = "1";
            }
            else
            {
                Result.Text = Result.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                Result.Text = "2";
            }
            else
            {
                Result.Text = Result.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                Result.Text = "3";
            }
            else
            {
                Result.Text = Result.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                Result.Text = "4";
            }
            else
            {
                Result.Text = Result.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                Result.Text = "5";
            }
            else
            {
                Result.Text = Result.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                Result.Text = "6";
            }
            else
            {
                Result.Text = Result.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                Result.Text = "7";
            }
            else
            {
                Result.Text = Result.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                Result.Text = "8";
            }
            else
            {
                Result.Text = Result.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                Result.Text = "9";
            }
            else
            {
                Result.Text = Result.Text + "9";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            //if the result text has no dot, print the dot. This is used to aviod mutiple dot
            if (!Result.Text.Contains("."))
            {
                Result.Text = Result.Text + ".";
            }

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Plus_Click(object sender, EventArgs e)
        {
            //When the user click on button +
            //Convert the first number data type from string to decimal for calculation
            valueFirst = Convert.ToDecimal(Result.Text);
            //Display 0 when adding two values
            Result.Text = "0";
            //The operator for this button is +
            operators = "+";
            
            
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            //When the user click on button -
            //Convert the first number data type from string to decimal
            valueFirst = Convert.ToDecimal(Result.Text);
            //Display 0 when subtracting two values
            Result.Text = "0";
            //The operator for this button is -
            operators = "-";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            //When the user click on button *
            //Convert the first number data type from string to decimal
            valueFirst = Convert.ToDecimal(Result.Text);
            //Display 0 when multiplying two values
            Result.Text = "0";
            //The operator for this button is *
            operators = "*";
        }

        private void Dividing_Click(object sender, EventArgs e)
        {
            //When the user click on button /
            //Convert the first number data type from string to decimal
            valueFirst = Convert.ToDecimal(Result.Text);
            //Display 0 when dividing two values
            Result.Text = "0";
            //The operator for this button is /
            operators = "/";
        }

        private void Inverse_Click(object sender, EventArgs e)
        {
            //When the user click on button 1/X
            //Convert the number data type from string to decimal
            inversevalue = Convert.ToDecimal(Result.Text);
            //Display 0 when inversing the value
            Result.Text = "0";
            //The operator for this button is 1/X
            operators = "1/X";
        }

        private void SquartRoot_Click(object sender, EventArgs e)
        {
            //When the user click on button กิ
            //Display 0 when Sqrt the value
            Result.Text = "0";
            //The operator for this button is กิ
            operators = "Sqrt";
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            //if the result contains - sign, just Trim the it
            if (Result.Text.Contains("-"))
            {
                Result.Text = Result.Text.Trim('-');
            }
            //Otherwise, add the - sign
            else
            {
                Result.Text = "-" + Result.Text;
            }
        }

        private void Square_Click(object sender, EventArgs e)
        {
            //When the user click on button x^2
            //Convert the number data type from string to decimal
            Sqvalue = Convert.ToDouble(Result.Text);
            //Display 0 when squaring the value
            Result.Text = "0";
            //The operator for this button is x^2
            operators = "X^2";
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            //When the user click on button sin
            //Display 0 when using sin for the value
            Result.Text = "0";
            //The operator for this button is sin
            operators = "Sin";
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            //When the user click on button cos
            //Display 0 when using cos for the value
            Result.Text = "0";
            //The operator for this button is cos
            operators = "Cos";
        }

        private void Log_Click(object sender, EventArgs e)
        {
            //When the user click on button log
            //Display 0 when using log for the value
            Result.Text = "0";
            //The operator for this button is log
            operators = "Log";
        }


        private void Equal_Click(object sender, EventArgs e)
        {
            
            switch (operators)
            {
                //if the operators = "+", add two values and display the result as string. 
                case "+":
                    //When the user click on button equal
                    //Convert the second number data type from string to decimal for calculation
                    valueSecond = Convert.ToDecimal(Result.Text);
                    //Add two values 
                    result = valueFirst + valueSecond;
                    //Display the result
                    Result.Text = result.ToString();
                    break;
                //if the operators = "+", add two values and display the result as string. 
                case "-":
                    //When the user click on button equal
                    //Convert the second number data type from string to decimal
                    valueSecond = Convert.ToDecimal(Result.Text);
                    //Subtract two values 
                    result = valueFirst - valueSecond;
                    //Display the result
                    Result.Text = result.ToString();
                    break;
                case "*":
                    //When the user click on button equal
                    //Convert the second number data type from string to decimal
                    valueSecond = Convert.ToDecimal(Result.Text);
                    //Multiply two values 
                    result = valueFirst * valueSecond;
                    //Display the result
                    Result.Text = result.ToString();
                    break;
                case "/":
                    //When the user click on button equal
                    //Convert the second number data type from string to decimal
                    valueSecond = Convert.ToDecimal(Result.Text);
                    //If Second value is 0, then display Math Error, otherwise, dividing two values and display the result
                    if (valueSecond == 0)
                    {
                        Result.Text = "Math ERROR";
                    }
                    else
                    {
                        result = valueFirst / valueSecond;
                        Result.Text = result.ToString();
                    }
                    break;
                case "1/X":
                    //When the user click on button equal
                    //If value is 0, then display Math Error 
                    if (inversevalue == 0)
                    {
                        Result.Text = "Math ERROR";
                    }
                    //Otherwise, 1 is divided by the value, there's no second value at this point
                    else
                    {
                        inverseresult = 1 / inversevalue;
                        //Display the result
                        Result.Text = inverseresult.ToString();
                    }
                    break;
                case "Sqrt":
                    //When the user click on button equal
                    //The value is put on square root , there's no second value at this point
                    Sqrtvalue = Convert.ToDouble(Result.Text);
                    //Use Sqrt operations to calculate the result
                    Sqrtresult = Math.Sqrt(Sqrtvalue);
                    //Display the result
                    Result.Text = Sqrtresult.ToString();
                    break;
                case "X^2":
                    //When the user click on button equal
                    //The value is put on square, there's no second value at this point
                    //Use Pow operations to calculate the result
                    Sqresult = Math.Pow(Sqvalue, 2);
                    //Display the result
                    Result.Text = Sqresult.ToString();
                    break;
                case "Sin":
                    //When the user click on button equal
                    //The value is put on Sin(), there's no second value at this point
                    //Convert the number data type from string to decimal
                    Sinvalue = Convert.ToDouble(Result.Text);
                    //Use Sin and PI operations to calculate the result
                    Sinresult = Math.Sin((Sinvalue*(Math.PI))/180);
                    //Display the result
                    Result.Text = Sinresult.ToString();
                    break;
                case "Cos":
                    //When the user click on button equal
                    //The value is put on Cos(), there's no second value at this point
                    //Convert the number data type from string to decimal
                    Cosvalue = Convert.ToDouble(Result.Text);
                    //Use Sin and PI operations to calculate the result
                    Cosresult = Math.Cos((Cosvalue * (Math.PI)) / 180);
                    //Display the result
                    Result.Text = Cosresult.ToString();
                    break;
                case "Log":
                    //When the user click on button equal
                    //The value is put on Log, there's no second value at this point
                    //Convert the number data type from string to decimal
                    Logvalue = Convert.ToDouble(Result.Text);
                    //Use Log operations to calculate the result, the default is base 10 for all calculation (e.g.,log10(n))
                    Logresult = Math.Log(Logvalue,10);
                    //Display the result
                    Result.Text = Logresult.ToString();
                    break;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}