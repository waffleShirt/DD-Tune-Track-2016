﻿namespace DD_Tune_Track
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnShowTechEditForm = new System.Windows.Forms.Button();
            this.btnShowBikeListEditor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Summer Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Winter Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShowTechEditForm
            // 
            this.btnShowTechEditForm.Location = new System.Drawing.Point(12, 70);
            this.btnShowTechEditForm.Name = "btnShowTechEditForm";
            this.btnShowTechEditForm.Size = new System.Drawing.Size(147, 23);
            this.btnShowTechEditForm.TabIndex = 2;
            this.btnShowTechEditForm.Text = "Show Tech Edit Form";
            this.btnShowTechEditForm.UseVisualStyleBackColor = true;
            this.btnShowTechEditForm.Click += new System.EventHandler(this.btnShowTechEditForm_Click);
            // 
            // btnShowBikeListEditor
            // 
            this.btnShowBikeListEditor.Location = new System.Drawing.Point(12, 99);
            this.btnShowBikeListEditor.Name = "btnShowBikeListEditor";
            this.btnShowBikeListEditor.Size = new System.Drawing.Size(147, 23);
            this.btnShowBikeListEditor.TabIndex = 3;
            this.btnShowBikeListEditor.Text = "Show Bike List Editor Form";
            this.btnShowBikeListEditor.UseVisualStyleBackColor = true;
            this.btnShowBikeListEditor.Click += new System.EventHandler(this.btnShowBikeListEditor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnShowBikeListEditor);
            this.Controls.Add(this.btnShowTechEditForm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnShowTechEditForm;
        private System.Windows.Forms.Button btnShowBikeListEditor;
    }
}

