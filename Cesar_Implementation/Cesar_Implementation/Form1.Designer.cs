namespace Cesar_Implementation
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTashfer = new System.Windows.Forms.Button();
            this.txtPlanText = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtTashferKey = new System.Windows.Forms.TextBox();
            this.txtAfterTashfer = new System.Windows.Forms.TextBox();
            this.txtAfterFkTashfer = new System.Windows.Forms.TextBox();
            this.btnFkTashfer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cesar Algoriathm With Implementation";
            // 
            // btnTashfer
            // 
            this.btnTashfer.Location = new System.Drawing.Point(47, 62);
            this.btnTashfer.Name = "btnTashfer";
            this.btnTashfer.Size = new System.Drawing.Size(87, 23);
            this.btnTashfer.TabIndex = 1;
            this.btnTashfer.Text = "شفر";
            this.toolTip1.SetToolTip(this.btnTashfer, "اضغط هنا لتشفير النص ");
            this.btnTashfer.UseVisualStyleBackColor = true;
            this.btnTashfer.Click += new System.EventHandler(this.btnTashfer_Click);
            // 
            // txtPlanText
            // 
            this.txtPlanText.Location = new System.Drawing.Point(171, 47);
            this.txtPlanText.Multiline = true;
            this.txtPlanText.Name = "txtPlanText";
            this.txtPlanText.Size = new System.Drawing.Size(240, 50);
            this.txtPlanText.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtPlanText, "ادخل النص الذي تريد تشفيره");
            // 
            // txtTashferKey
            // 
            this.txtTashferKey.Location = new System.Drawing.Point(171, 117);
            this.txtTashferKey.Name = "txtTashferKey";
            this.txtTashferKey.Size = new System.Drawing.Size(240, 24);
            this.txtTashferKey.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtTashferKey, "ادخل المفتاح الذي سيتم التشفير به");
            // 
            // txtAfterTashfer
            // 
            this.txtAfterTashfer.Location = new System.Drawing.Point(171, 164);
            this.txtAfterTashfer.Multiline = true;
            this.txtAfterTashfer.Name = "txtAfterTashfer";
            this.txtAfterTashfer.Size = new System.Drawing.Size(240, 51);
            this.txtAfterTashfer.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtAfterTashfer, "النص بعد تشفيره");
            // 
            // txtAfterFkTashfer
            // 
            this.txtAfterFkTashfer.Location = new System.Drawing.Point(171, 233);
            this.txtAfterFkTashfer.Multiline = true;
            this.txtAfterFkTashfer.Name = "txtAfterFkTashfer";
            this.txtAfterFkTashfer.Size = new System.Drawing.Size(240, 50);
            this.txtAfterFkTashfer.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtAfterFkTashfer, "النص بعد فك تشفيره");
            // 
            // btnFkTashfer
            // 
            this.btnFkTashfer.Enabled = false;
            this.btnFkTashfer.Location = new System.Drawing.Point(47, 247);
            this.btnFkTashfer.Name = "btnFkTashfer";
            this.btnFkTashfer.Size = new System.Drawing.Size(87, 23);
            this.btnFkTashfer.TabIndex = 7;
            this.btnFkTashfer.Text = "فك التشفير";
            this.toolTip1.SetToolTip(this.btnFkTashfer, "اضغط هنا لفك تشفير النص ");
            this.btnFkTashfer.UseVisualStyleBackColor = true;
            this.btnFkTashfer.Click += new System.EventHandler(this.btnFkTashfer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(171, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back To Main Bage";
            this.toolTip1.SetToolTip(this.button1, "Back To Main Bage ");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "المفتاح";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFkTashfer);
            this.Controls.Add(this.txtAfterFkTashfer);
            this.Controls.Add(this.txtAfterTashfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTashferKey);
            this.Controls.Add(this.txtPlanText);
            this.Controls.Add(this.btnTashfer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cesar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTashfer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtPlanText;
        private System.Windows.Forms.TextBox txtTashferKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAfterTashfer;
        private System.Windows.Forms.TextBox txtAfterFkTashfer;
        private System.Windows.Forms.Button btnFkTashfer;
        private System.Windows.Forms.Button button1;
    }
}

