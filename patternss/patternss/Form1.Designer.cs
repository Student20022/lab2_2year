namespace patternss
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SingletonExampleButton = new Button();
            AdapterExampleButton = new Button();
            ObserverExampleButton = new Button();
            SuspendLayout();
            // 
            // SingletonExampleButton
            // 
            SingletonExampleButton.Location = new Point(104, 62);
            SingletonExampleButton.Name = "SingletonExampleButton";
            SingletonExampleButton.Size = new Size(75, 23);
            SingletonExampleButton.TabIndex = 0;
            SingletonExampleButton.Text = "button1";
            SingletonExampleButton.UseVisualStyleBackColor = true;
            SingletonExampleButton.Click += SingletonExampleButton_Click;
            // 
            // AdapterExampleButton
            // 
            AdapterExampleButton.Location = new Point(246, 62);
            AdapterExampleButton.Name = "AdapterExampleButton";
            AdapterExampleButton.Size = new Size(75, 23);
            AdapterExampleButton.TabIndex = 1;
            AdapterExampleButton.Text = "button1";
            AdapterExampleButton.UseVisualStyleBackColor = true;
            AdapterExampleButton.Click += AdapterExampleButton_Click;
            // 
            // ObserverExampleButton
            // 
            ObserverExampleButton.Location = new Point(389, 62);
            ObserverExampleButton.Name = "ObserverExampleButton";
            ObserverExampleButton.Size = new Size(75, 23);
            ObserverExampleButton.TabIndex = 2;
            ObserverExampleButton.Text = "button1";
            ObserverExampleButton.UseVisualStyleBackColor = true;
            ObserverExampleButton.Click += ObserverExampleButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ObserverExampleButton);
            Controls.Add(AdapterExampleButton);
            Controls.Add(SingletonExampleButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button SingletonExampleButton;
        private Button AdapterExampleButton;
        private Button ObserverExampleButton;
    }
}