using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.Text = "BMI Calculator";
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void labelResult_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			labelResult.Text = "";
			labelMessage.Text = "";
		}

		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBoxWeight.Text == "" || textBoxHeight.Text == "")
				{
					labelMessage.Text = "Please enter the Weight and Height \n to calculate your BMI";
				}
				else
				{
					// Parse input as doubles
					double weight = double.Parse(textBoxWeight.Text);
					double height = double.Parse(textBoxHeight.Text);
					double bmi = (weight * 703) / (height * height);

					// Display the result in the result label
					labelResult.Text = "Your BMI: " + String.Format("{0:f}", bmi);

					// Check BMI and give relevant message
					if (bmi < 18.5)
					{
						labelMessage.Text = "Your are under-weight. \n";
						labelMessage.Text += "Take more nutritious food to get your ideal weight. \n";
					}

					else if (bmi >= 18.5 && bmi <= 24.9)
					{
						labelMessage.Text = "Good! Your weight is normal. \n";
					}

					else if (bmi >= 25 && bmi <= 29.9)
					{
						labelMessage.Text = "You are over-weight. \n";
						labelMessage.Text += "Focus on diet and workout. \n";
					}
					else if (bmi >= 30)
					{
						labelMessage.Text = "You are obese. \n";
						labelMessage.Text += "Consult with a doctor immediately. \n";
					}
					else
					{
						labelMessage.Text = "Please provide valid data to calculate BMI";
					}

					labelMessage.Text += "Stay Healthy! Happy Living!";
				}
			}

			catch (Exception ex)
			{
				labelMessage.Text = ex.ToString();
			}
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			textBoxWeight.Text = "";
			textBoxHeight.Text = "";
			labelResult.Text = "";
			labelMessage.Text = "";
		}
	}
}
