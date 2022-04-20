
namespace BMI_Calculator
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelWeight = new System.Windows.Forms.Label();
			this.labelHeight = new System.Windows.Forms.Label();
			this.labelResult = new System.Windows.Forms.Label();
			this.labelMessage = new System.Windows.Forms.Label();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.buttonReset = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.textBoxWeight = new System.Windows.Forms.TextBox();
			this.textBoxHeight = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			resources.ApplyResources(this.labelTitle, "labelTitle");
			this.labelTitle.Name = "labelTitle";
			// 
			// labelWeight
			// 
			resources.ApplyResources(this.labelWeight, "labelWeight");
			this.labelWeight.Name = "labelWeight";
			// 
			// labelHeight
			// 
			resources.ApplyResources(this.labelHeight, "labelHeight");
			this.labelHeight.Name = "labelHeight";
			// 
			// labelResult
			// 
			resources.ApplyResources(this.labelResult, "labelResult");
			this.labelResult.Name = "labelResult";
			this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
			// 
			// labelMessage
			// 
			resources.ApplyResources(this.labelMessage, "labelMessage");
			this.labelMessage.Name = "labelMessage";
			// 
			// buttonCalculate
			// 
			resources.ApplyResources(this.buttonCalculate, "buttonCalculate");
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.UseVisualStyleBackColor = true;
			this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
			// 
			// buttonReset
			// 
			resources.ApplyResources(this.buttonReset, "buttonReset");
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// buttonExit
			// 
			resources.ApplyResources(this.buttonExit, "buttonExit");
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// textBoxWeight
			// 
			resources.ApplyResources(this.textBoxWeight, "textBoxWeight");
			this.textBoxWeight.Name = "textBoxWeight";
			// 
			// textBoxHeight
			// 
			resources.ApplyResources(this.textBoxHeight, "textBoxHeight");
			this.textBoxHeight.Name = "textBoxHeight";
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxHeight);
			this.Controls.Add(this.textBoxWeight);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.labelMessage);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.labelHeight);
			this.Controls.Add(this.labelWeight);
			this.Controls.Add(this.labelTitle);
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelWeight;
		private System.Windows.Forms.Label labelHeight;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.Label labelMessage;
		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.TextBox textBoxWeight;
		private System.Windows.Forms.TextBox textBoxHeight;
	}
}

