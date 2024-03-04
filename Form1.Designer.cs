namespace Testing_Display_service_type_and_services
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
            ServiceTypeFL = new FlowLayoutPanel();
            ServiceFL = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // ServiceTypeFL
            // 
            ServiceTypeFL.AutoScroll = true;
            ServiceTypeFL.BackColor = Color.DarkGray;
            ServiceTypeFL.Location = new Point(12, 12);
            ServiceTypeFL.Name = "ServiceTypeFL";
            ServiceTypeFL.Size = new Size(1101, 224);
            ServiceTypeFL.TabIndex = 0;
            // 
            // ServiceFL
            // 
            ServiceFL.AutoScroll = true;
            ServiceFL.BackColor = Color.LightGray;
            ServiceFL.Location = new Point(12, 279);
            ServiceFL.Name = "ServiceFL";
            ServiceFL.Size = new Size(960, 300);
            ServiceFL.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 661);
            Controls.Add(ServiceFL);
            Controls.Add(ServiceTypeFL);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ServiceTypeFL;
        private FlowLayoutPanel ServiceFL;
    }
}
