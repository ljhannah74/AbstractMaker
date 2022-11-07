namespace AbstractMaker.Main
{
	partial class MainForm
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
			this.btnCreateNewOrder = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCreateNewOrder
			// 
			this.btnCreateNewOrder.Location = new System.Drawing.Point(339, 331);
			this.btnCreateNewOrder.Name = "btnCreateNewOrder";
			this.btnCreateNewOrder.Size = new System.Drawing.Size(75, 23);
			this.btnCreateNewOrder.TabIndex = 0;
			this.btnCreateNewOrder.Text = "Create New Order";
			this.btnCreateNewOrder.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCreateNewOrder);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCreateNewOrder;
	}
}