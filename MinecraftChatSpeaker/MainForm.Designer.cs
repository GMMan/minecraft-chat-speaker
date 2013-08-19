/*
 * Date: 8/8/2013
 * Time: 9:06 AM
 * (C) Yukai Li (GMMan/GMWare)
 */
namespace MinecraftChatSpeaker
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.logPathLabel = new System.Windows.Forms.Label();
			this.selectLogButton = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.startButton = new System.Windows.Forms.Button();
			this.stopButton = new System.Windows.Forms.Button();
			this.speakTestTextBox = new System.Windows.Forms.TextBox();
			this.testButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Log path:";
			// 
			// logPathLabel
			// 
			this.logPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.logPathLabel.Location = new System.Drawing.Point(70, 17);
			this.logPathLabel.Name = "logPathLabel";
			this.logPathLabel.Size = new System.Drawing.Size(430, 13);
			this.logPathLabel.TabIndex = 1;
			// 
			// selectLogButton
			// 
			this.selectLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.selectLogButton.Location = new System.Drawing.Point(506, 12);
			this.selectLogButton.Name = "selectLogButton";
			this.selectLogButton.Size = new System.Drawing.Size(75, 23);
			this.selectLogButton.TabIndex = 2;
			this.selectLogButton.Text = "Select...";
			this.selectLogButton.UseVisualStyleBackColor = true;
			this.selectLogButton.Click += new System.EventHandler(this.SelectLogButtonClick);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.Location = new System.Drawing.Point(12, 41);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(569, 277);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Title = "Pick output-client.log";
			// 
			// startButton
			// 
			this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.startButton.Location = new System.Drawing.Point(12, 324);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 4;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// stopButton
			// 
			this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.stopButton.Location = new System.Drawing.Point(93, 324);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(75, 23);
			this.stopButton.TabIndex = 5;
			this.stopButton.Text = "Stop";
			this.stopButton.UseVisualStyleBackColor = true;
			this.stopButton.Click += new System.EventHandler(this.StopButtonClick);
			// 
			// speakTestTextBox
			// 
			this.speakTestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.speakTestTextBox.Location = new System.Drawing.Point(174, 326);
			this.speakTestTextBox.Name = "speakTestTextBox";
			this.speakTestTextBox.Size = new System.Drawing.Size(326, 20);
			this.speakTestTextBox.TabIndex = 6;
			// 
			// testButton
			// 
			this.testButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.testButton.Location = new System.Drawing.Point(506, 324);
			this.testButton.Name = "testButton";
			this.testButton.Size = new System.Drawing.Size(75, 23);
			this.testButton.TabIndex = 7;
			this.testButton.Text = "Test";
			this.testButton.UseVisualStyleBackColor = true;
			this.testButton.Click += new System.EventHandler(this.TestButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 357);
			this.Controls.Add(this.testButton);
			this.Controls.Add(this.speakTestTextBox);
			this.Controls.Add(this.stopButton);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.selectLogButton);
			this.Controls.Add(this.logPathLabel);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Minecraft Chat Speaker";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button testButton;
		private System.Windows.Forms.TextBox speakTestTextBox;
		private System.Windows.Forms.Button stopButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button selectLogButton;
		private System.Windows.Forms.Label logPathLabel;
		private System.Windows.Forms.Label label1;
	}
}
