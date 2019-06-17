namespace Adder
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
            this.lCharacter = new System.Windows.Forms.Label();
            this.bCharacter = new System.Windows.Forms.Button();
            this.tbCharacter = new System.Windows.Forms.TextBox();
            this.tbScene = new System.Windows.Forms.TextBox();
            this.bScene = new System.Windows.Forms.Button();
            this.lScene = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.bModel = new System.Windows.Forms.Button();
            this.lModel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lCharacter
            // 
            this.lCharacter.AutoSize = true;
            this.lCharacter.Location = new System.Drawing.Point(12, 9);
            this.lCharacter.Name = "lCharacter";
            this.lCharacter.Size = new System.Drawing.Size(81, 13);
            this.lCharacter.TabIndex = 0;
            this.lCharacter.Text = "New Character:";
            // 
            // bCharacter
            // 
            this.bCharacter.Location = new System.Drawing.Point(15, 52);
            this.bCharacter.Name = "bCharacter";
            this.bCharacter.Size = new System.Drawing.Size(149, 23);
            this.bCharacter.TabIndex = 2;
            this.bCharacter.Text = "Add Character";
            this.bCharacter.UseVisualStyleBackColor = true;
            this.bCharacter.Click += new System.EventHandler(this.BCharacter_Click);
            // 
            // tbCharacter
            // 
            this.tbCharacter.Location = new System.Drawing.Point(15, 26);
            this.tbCharacter.Name = "tbCharacter";
            this.tbCharacter.Size = new System.Drawing.Size(149, 20);
            this.tbCharacter.TabIndex = 1;
            // 
            // tbScene
            // 
            this.tbScene.Location = new System.Drawing.Point(15, 105);
            this.tbScene.Name = "tbScene";
            this.tbScene.Size = new System.Drawing.Size(149, 20);
            this.tbScene.TabIndex = 4;
            // 
            // bScene
            // 
            this.bScene.Location = new System.Drawing.Point(15, 131);
            this.bScene.Name = "bScene";
            this.bScene.Size = new System.Drawing.Size(149, 23);
            this.bScene.TabIndex = 5;
            this.bScene.Text = "Add Scene";
            this.bScene.UseVisualStyleBackColor = true;
            this.bScene.Click += new System.EventHandler(this.BScene_Click);
            // 
            // lScene
            // 
            this.lScene.AutoSize = true;
            this.lScene.Location = new System.Drawing.Point(12, 88);
            this.lScene.Name = "lScene";
            this.lScene.Size = new System.Drawing.Size(66, 13);
            this.lScene.TabIndex = 3;
            this.lScene.Text = "New Scene:";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(15, 186);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(149, 20);
            this.tbModel.TabIndex = 7;
            // 
            // bModel
            // 
            this.bModel.Location = new System.Drawing.Point(15, 212);
            this.bModel.Name = "bModel";
            this.bModel.Size = new System.Drawing.Size(149, 23);
            this.bModel.TabIndex = 8;
            this.bModel.Text = "Add Model";
            this.bModel.UseVisualStyleBackColor = true;
            this.bModel.Click += new System.EventHandler(this.BModel_Click);
            // 
            // lModel
            // 
            this.lModel.AutoSize = true;
            this.lModel.Location = new System.Drawing.Point(12, 169);
            this.lModel.Name = "lModel";
            this.lModel.Size = new System.Drawing.Size(64, 13);
            this.lModel.TabIndex = 6;
            this.lModel.Text = "New Model:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 249);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.bModel);
            this.Controls.Add(this.lModel);
            this.Controls.Add(this.tbScene);
            this.Controls.Add(this.bScene);
            this.Controls.Add(this.lScene);
            this.Controls.Add(this.tbCharacter);
            this.Controls.Add(this.bCharacter);
            this.Controls.Add(this.lCharacter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCharacter;
        private System.Windows.Forms.Button bCharacter;
        private System.Windows.Forms.TextBox tbCharacter;
        private System.Windows.Forms.TextBox tbScene;
        private System.Windows.Forms.Button bScene;
        private System.Windows.Forms.Label lScene;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Button bModel;
        private System.Windows.Forms.Label lModel;
    }
}

