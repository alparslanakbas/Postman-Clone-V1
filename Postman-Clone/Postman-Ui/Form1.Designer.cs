namespace Postman_Ui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            apiText = new TextBox();
            label3 = new Label();
            resultText = new TextBox();
            apiBar = new ProgressBar();
            callApi = new Button();
            statusStrip1 = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Postman Clone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 1;
            label2.Text = "Your Api Url";
            // 
            // apiText
            // 
            apiText.Location = new Point(12, 66);
            apiText.Multiline = true;
            apiText.Name = "apiText";
            apiText.ScrollBars = ScrollBars.Vertical;
            apiText.Size = new Size(776, 43);
            apiText.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 3;
            label3.Text = "Result";
            // 
            // resultText
            // 
            resultText.Location = new Point(12, 168);
            resultText.Multiline = true;
            resultText.Name = "resultText";
            resultText.ReadOnly = true;
            resultText.ScrollBars = ScrollBars.Vertical;
            resultText.Size = new Size(776, 279);
            resultText.TabIndex = 4;
            // 
            // apiBar
            // 
            apiBar.Location = new Point(12, 115);
            apiBar.Name = "apiBar";
            apiBar.Size = new Size(776, 22);
            apiBar.TabIndex = 5;
            // 
            // callApi
            // 
            callApi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            callApi.Location = new Point(139, 38);
            callApi.Name = "callApi";
            callApi.Size = new Size(98, 27);
            callApi.TabIndex = 6;
            callApi.Text = "Send Request";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip1.Location = new Point(0, 448);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 25);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(44, 20);
            systemStatus.Text = "Hazır";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(statusStrip1);
            Controls.Add(callApi);
            Controls.Add(apiBar);
            Controls.Add(resultText);
            Controls.Add(label3);
            Controls.Add(apiText);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Postman Clone V1.0";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox apiText;
        private Label label3;
        private TextBox resultText;
        private ProgressBar apiBar;
        private Button callApi;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel systemStatus;
    }
}
