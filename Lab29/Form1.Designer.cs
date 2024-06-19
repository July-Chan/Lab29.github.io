namespace Lab29
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
            logoutButton = new Button();
            chatTextBox = new RichTextBox();
            messageTextBox = new RichTextBox();
            sendButton = new Button();
            loginButton = new Button();
            label2 = new Label();
            userNameTextBox = new TextBox();
            panel1 = new Panel();
            settingsButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Font = new Font("Times New Roman", 14F);
            logoutButton.Location = new Point(995, 79);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(125, 50);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "Вихід";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click_1;
            // 
            // chatTextBox
            // 
            chatTextBox.Location = new Point(12, 168);
            chatTextBox.Name = "chatTextBox";
            chatTextBox.Size = new Size(1133, 453);
            chatTextBox.TabIndex = 7;
            chatTextBox.Text = "";
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(12, 627);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(948, 108);
            messageTextBox.TabIndex = 7;
            messageTextBox.Text = "";
            // 
            // sendButton
            // 
            sendButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sendButton.Location = new Point(974, 649);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(171, 56);
            sendButton.TabIndex = 8;
            sendButton.Text = "Надіслати";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click_1;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Times New Roman", 14F);
            loginButton.Location = new Point(995, 17);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(125, 50);
            loginButton.TabIndex = 3;
            loginButton.Text = "Вхід";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F);
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(156, 33);
            label2.TabIndex = 2;
            label2.Text = "Введіть ім'я";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userNameTextBox.Location = new Point(195, 57);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(488, 40);
            userNameTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(settingsButton);
            panel1.Controls.Add(userNameTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(logoutButton);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 150);
            panel1.TabIndex = 9;
            // 
            // settingsButton
            // 
            settingsButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            settingsButton.Location = new Point(708, 51);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(258, 50);
            settingsButton.TabIndex = 4;
            settingsButton.Text = "Налаштування чату";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 747);
            Controls.Add(panel1);
            Controls.Add(sendButton);
            Controls.Add(chatTextBox);
            Controls.Add(messageTextBox);
            Name = "Form1";
            ShowIcon = false;
            Text = "Лабораторна 29 Кривонос";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button logoutButton;
        private RichTextBox chatTextBox;
        private RichTextBox messageTextBox;
        private Button sendButton;
        private Button loginButton;
        private Label label2;
        private TextBox userNameTextBox;
        private Panel panel1;
        private Button settingsButton;
    }
}
