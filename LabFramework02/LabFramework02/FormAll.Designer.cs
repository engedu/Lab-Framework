namespace LabFramework01
{
    partial class FormAll
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
            this.display1 = new LabFramework01.Display();
            this.fgenDisplay1 = new LabFramework01.FgenDisplay();
            this.multimeter1 = new LabFramework01.Multimeter();
            this.multimeter2 = new LabFramework01.Multimeter();
            this.multimeter3 = new LabFramework01.Multimeter();
            this.multimeter4 = new LabFramework01.Multimeter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display1
            // 
            this.display1.BackColor = System.Drawing.SystemColors.Control;
            this.display1.Location = new System.Drawing.Point(12, 12);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(727, 533);
            this.display1.TabIndex = 0;
            // 
            // fgenDisplay1
            // 
            this.fgenDisplay1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fgenDisplay1.BackColor = System.Drawing.SystemColors.Control;
            this.fgenDisplay1.Location = new System.Drawing.Point(756, 13);
            this.fgenDisplay1.Name = "fgenDisplay1";
            this.fgenDisplay1.Size = new System.Drawing.Size(435, 225);
            this.fgenDisplay1.TabIndex = 1;
            // 
            // multimeter1
            // 
            this.multimeter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.multimeter1.Location = new System.Drawing.Point(935, 244);
            this.multimeter1.Name = "multimeter1";
            this.multimeter1.Size = new System.Drawing.Size(256, 71);
            this.multimeter1.TabIndex = 2;
            // 
            // multimeter2
            // 
            this.multimeter2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.multimeter2.Location = new System.Drawing.Point(935, 321);
            this.multimeter2.Name = "multimeter2";
            this.multimeter2.Size = new System.Drawing.Size(256, 71);
            this.multimeter2.TabIndex = 3;
            // 
            // multimeter3
            // 
            this.multimeter3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.multimeter3.Location = new System.Drawing.Point(935, 398);
            this.multimeter3.Name = "multimeter3";
            this.multimeter3.Size = new System.Drawing.Size(256, 71);
            this.multimeter3.TabIndex = 4;
            // 
            // multimeter4
            // 
            this.multimeter4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.multimeter4.Location = new System.Drawing.Point(935, 475);
            this.multimeter4.Name = "multimeter4";
            this.multimeter4.Size = new System.Drawing.Size(256, 71);
            this.multimeter4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(870, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "V1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(870, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "V2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(870, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "V3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(870, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "V4";
            // 
            // FormAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 574);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.multimeter4);
            this.Controls.Add(this.multimeter3);
            this.Controls.Add(this.multimeter2);
            this.Controls.Add(this.multimeter1);
            this.Controls.Add(this.fgenDisplay1);
            this.Controls.Add(this.display1);
            this.Name = "FormAll";
            this.Text = "FormAll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Display display1;
        private FgenDisplay fgenDisplay1;
        private Multimeter multimeter1;
        private Multimeter multimeter2;
        private Multimeter multimeter3;
        private Multimeter multimeter4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}