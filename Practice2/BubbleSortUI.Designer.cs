namespace Practice2
{
	partial class BubbleSortUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtNumber1 = new System.Windows.Forms.TextBox();
			this.txtNumber2 = new System.Windows.Forms.TextBox();
			this.txtNumber3 = new System.Windows.Forms.TextBox();
			this.txtNumber4 = new System.Windows.Forms.TextBox();
			this.btn_sort = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.txtNumber1.Location = new System.Drawing.Point( 40, 143 );
			this.txtNumber1.Name = "textBox1";
			this.txtNumber1.Size = new System.Drawing.Size( 100, 22 );
			this.txtNumber1.TabIndex = 0;
			
			// 
			// textBox2
			// 
			this.txtNumber2.Location = new System.Drawing.Point( 182, 143 );
			this.txtNumber2.Name = "textBox2";
			this.txtNumber2.Size = new System.Drawing.Size( 100, 22 );
			this.txtNumber2.TabIndex = 1;
			
			// 
			// textBox3
			// 
			this.txtNumber3.Location = new System.Drawing.Point( 319, 143 );
			this.txtNumber3.Name = "textBox3";
			this.txtNumber3.Size = new System.Drawing.Size( 100, 22 );
			this.txtNumber3.TabIndex = 2;
			
			// 
			// textBox4
			// 
			this.txtNumber4.Location = new System.Drawing.Point( 459, 143 );
			this.txtNumber4.Name = "textBox4";
			this.txtNumber4.Size = new System.Drawing.Size( 100, 22 );
			this.txtNumber4.TabIndex = 3;
			
			// 
			// btn_sort
			// 
			this.btn_sort.Location = new System.Drawing.Point( 249, 236 );
			this.btn_sort.Name = "btn_sort";
			this.btn_sort.Size = new System.Drawing.Size( 112, 40 );
			this.btn_sort.TabIndex = 4;
			this.btn_sort.Text = "排序";
			this.btn_sort.UseVisualStyleBackColor = true;
			this.btn_sort.Click += new System.EventHandler( this.btn_sort_Click );
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font( "PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 136 ) ) );
			this.label1.Location = new System.Drawing.Point( 211, 64 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 180, 19 );
			this.label1.TabIndex = 5;
			this.label1.Text = "Please Input Integers：";
			// 
			// bubblesort_ui
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 637, 387 );
			this.Controls.Add( this.label1 );
			this.Controls.Add( this.btn_sort );
			this.Controls.Add( this.txtNumber4 );
			this.Controls.Add( this.txtNumber3 );
			this.Controls.Add( this.txtNumber2 );
			this.Controls.Add( this.txtNumber1 );
			this.Name = "bubblesort_ui";
			this.Text = "bubblesortUI";
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNumber1;
		private System.Windows.Forms.TextBox txtNumber2;
		private System.Windows.Forms.TextBox txtNumber3;
		private System.Windows.Forms.TextBox txtNumber4;
		private System.Windows.Forms.Button btn_sort;
		private System.Windows.Forms.Label label1;
	}
}

