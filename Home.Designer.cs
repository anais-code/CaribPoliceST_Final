namespace CaribPoliceST
{
    partial class Home
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
            HomePanel = new Panel();
            label1 = new Label();
            SignUpButton = new Button();
            LoginButton = new Button();
            pictureBox1 = new PictureBox();
            HomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // HomePanel
            // 
            HomePanel.BackColor = Color.FromArgb(39, 70, 144);
            HomePanel.Controls.Add(label1);
            HomePanel.Controls.Add(SignUpButton);
            HomePanel.Controls.Add(LoginButton);
            HomePanel.Controls.Add(pictureBox1);
            HomePanel.Dock = DockStyle.Fill;
            HomePanel.Location = new Point(0, 0);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(1774, 1129);
            HomePanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(758, 797);
            label1.Name = "label1";
            label1.Size = new Size(293, 37);
            label1.TabIndex = 3;
            label1.Text = "Don't have an account?";
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.Black;
            SignUpButton.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpButton.ForeColor = Color.WhiteSmoke;
            SignUpButton.Location = new Point(724, 869);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(352, 79);
            SignUpButton.TabIndex = 2;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.Location = new Point(724, 595);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(352, 79);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CaribPolice_ST_3_removebg_preview;
            pictureBox1.Location = new Point(715, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1774, 1129);
            Controls.Add(HomePanel);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            HomePanel.ResumeLayout(false);
            HomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel HomePanel;
        private Button LoginButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Button SignUpButton;
    }
}
