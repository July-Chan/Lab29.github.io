namespace Lab29
{
    partial class SettingsForm
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
            hostTextBox = new TextBox();
            localPortTextBox = new TextBox();
            remotePortTextBox = new TextBox();
            ttlTextBox = new TextBox();
            button1 = new Button();
            fontComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            fontSizeTextBox = new TextBox();
            SuspendLayout();
            // 
            // hostTextBox
            // 
            hostTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hostTextBox.Location = new Point(222, 89);
            hostTextBox.Name = "hostTextBox";
            hostTextBox.Size = new Size(348, 40);
            hostTextBox.TabIndex = 0;
            // 
            // localPortTextBox
            // 
            localPortTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            localPortTextBox.Location = new Point(344, 237);
            localPortTextBox.Name = "localPortTextBox";
            localPortTextBox.Size = new Size(354, 40);
            localPortTextBox.TabIndex = 0;
            // 
            // remotePortTextBox
            // 
            remotePortTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            remotePortTextBox.Location = new Point(344, 292);
            remotePortTextBox.Name = "remotePortTextBox";
            remotePortTextBox.Size = new Size(354, 40);
            remotePortTextBox.TabIndex = 0;
            // 
            // ttlTextBox
            // 
            ttlTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ttlTextBox.Location = new Point(222, 157);
            ttlTextBox.Name = "ttlTextBox";
            ttlTextBox.Size = new Size(348, 40);
            ttlTextBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(600, 374);
            button1.Name = "button1";
            button1.Size = new Size(172, 50);
            button1.TabIndex = 1;
            button1.Text = "Зберегти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fontComboBox
            // 
            fontComboBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fontComboBox.FormattingEnabled = true;
            fontComboBox.Location = new Point(222, 29);
            fontComboBox.Name = "fontComboBox";
            fontComboBox.Size = new Size(348, 41);
            fontComboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(90, 37);
            label1.Name = "label1";
            label1.Size = new Size(101, 33);
            label1.TabIndex = 3;
            label1.Text = "Шрифт";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(119, 96);
            label2.Name = "label2";
            label2.Size = new Size(72, 33);
            label2.TabIndex = 3;
            label2.Text = "Хост";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(37, 244);
            label3.Name = "label3";
            label3.Size = new Size(261, 33);
            label3.TabIndex = 3;
            label3.Text = "Порт для приймання";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(37, 296);
            label4.Name = "label4";
            label4.Size = new Size(276, 33);
            label4.TabIndex = 3;
            label4.Text = "Порт для передавання";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(22, 160);
            label5.Name = "label5";
            label5.Size = new Size(179, 33);
            label5.TabIndex = 3;
            label5.Text = "Значення TTL";
            // 
            // fontSizeTextBox
            // 
            fontSizeTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fontSizeTextBox.Location = new Point(600, 30);
            fontSizeTextBox.Name = "fontSizeTextBox";
            fontSizeTextBox.Size = new Size(98, 40);
            fontSizeTextBox.TabIndex = 0;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fontComboBox);
            Controls.Add(button1);
            Controls.Add(ttlTextBox);
            Controls.Add(remotePortTextBox);
            Controls.Add(localPortTextBox);
            Controls.Add(fontSizeTextBox);
            Controls.Add(hostTextBox);
            Name = "SettingsForm";
            ShowIcon = false;
            Text = "SettingsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox hostTextBox;
        private TextBox localPortTextBox;
        private TextBox remotePortTextBox;
        private TextBox ttlTextBox;
        private Button button1;
        private ComboBox fontComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox fontSizeTextBox;
    }
}