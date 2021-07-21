
namespace Program3_LogoStore
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
            this.NumItems = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumItemsText = new System.Windows.Forms.TextBox();
            this.EngravingText = new System.Windows.Forms.TextBox();
            this.ItemTypes = new System.Windows.Forms.GroupBox();
            this.USB = new System.Windows.Forms.RadioButton();
            this.Mug = new System.Windows.Forms.RadioButton();
            this.Pen = new System.Windows.Forms.RadioButton();
            this.LogoCheckBox = new System.Windows.Forms.CheckBox();
            this.NumColors = new System.Windows.Forms.Label();
            this.NumColorsText = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.ItemTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumItems
            // 
            this.NumItems.AutoSize = true;
            this.NumItems.Location = new System.Drawing.Point(12, 9);
            this.NumItems.Name = "NumItems";
            this.NumItems.Size = new System.Drawing.Size(123, 20);
            this.NumItems.TabIndex = 0;
            this.NumItems.Text = "Number Of Items";
            this.NumItems.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text to Engrave/Print";
            // 
            // NumItemsText
            // 
            this.NumItemsText.Location = new System.Drawing.Point(12, 45);
            this.NumItemsText.Name = "NumItemsText";
            this.NumItemsText.Size = new System.Drawing.Size(198, 27);
            this.NumItemsText.TabIndex = 2;
            // 
            // EngravingText
            // 
            this.EngravingText.AllowDrop = true;
            this.EngravingText.Location = new System.Drawing.Point(12, 229);
            this.EngravingText.Multiline = true;
            this.EngravingText.Name = "EngravingText";
            this.EngravingText.Size = new System.Drawing.Size(454, 53);
            this.EngravingText.TabIndex = 3;
            // 
            // ItemTypes
            // 
            this.ItemTypes.Controls.Add(this.USB);
            this.ItemTypes.Controls.Add(this.Mug);
            this.ItemTypes.Controls.Add(this.Pen);
            this.ItemTypes.Location = new System.Drawing.Point(12, 78);
            this.ItemTypes.Name = "ItemTypes";
            this.ItemTypes.Size = new System.Drawing.Size(198, 125);
            this.ItemTypes.TabIndex = 4;
            this.ItemTypes.TabStop = false;
            this.ItemTypes.Text = "Item Type";
            this.ItemTypes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // USB
            // 
            this.USB.AutoSize = true;
            this.USB.Location = new System.Drawing.Point(6, 80);
            this.USB.Name = "USB";
            this.USB.Size = new System.Drawing.Size(57, 24);
            this.USB.TabIndex = 7;
            this.USB.TabStop = true;
            this.USB.Text = "USB";
            this.USB.UseVisualStyleBackColor = true;
            this.USB.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Mug
            // 
            this.Mug.AutoSize = true;
            this.Mug.Location = new System.Drawing.Point(6, 50);
            this.Mug.Name = "Mug";
            this.Mug.Size = new System.Drawing.Size(60, 24);
            this.Mug.TabIndex = 6;
            this.Mug.TabStop = true;
            this.Mug.Text = "Mug";
            this.Mug.UseVisualStyleBackColor = true;
            this.Mug.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Pen
            // 
            this.Pen.AutoSize = true;
            this.Pen.Location = new System.Drawing.Point(6, 20);
            this.Pen.Name = "Pen";
            this.Pen.Size = new System.Drawing.Size(53, 24);
            this.Pen.TabIndex = 5;
            this.Pen.TabStop = true;
            this.Pen.Text = "Pen";
            this.Pen.UseVisualStyleBackColor = true;
            // 
            // LogoCheckBox
            // 
            this.LogoCheckBox.AutoSize = true;
            this.LogoCheckBox.Location = new System.Drawing.Point(18, 288);
            this.LogoCheckBox.Name = "LogoCheckBox";
            this.LogoCheckBox.Size = new System.Drawing.Size(72, 24);
            this.LogoCheckBox.TabIndex = 5;
            this.LogoCheckBox.Text = "Logo?";
            this.LogoCheckBox.UseVisualStyleBackColor = true;
            this.LogoCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NumColors
            // 
            this.NumColors.AutoSize = true;
            this.NumColors.Location = new System.Drawing.Point(12, 317);
            this.NumColors.Name = "NumColors";
            this.NumColors.Size = new System.Drawing.Size(129, 20);
            this.NumColors.TabIndex = 6;
            this.NumColors.Text = "Number Of Colors";
            this.NumColors.Visible = false;
            // 
            // NumColorsText
            // 
            this.NumColorsText.Location = new System.Drawing.Point(12, 340);
            this.NumColorsText.Name = "NumColorsText";
            this.NumColorsText.Size = new System.Drawing.Size(198, 27);
            this.NumColorsText.TabIndex = 7;
            this.NumColorsText.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 392);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 29);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(116, 392);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbOutput
            // 
            this.txbOutput.Location = new System.Drawing.Point(225, 314);
            this.txbOutput.Multiline = true;
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.ReadOnly = true;
            this.txbOutput.Size = new System.Drawing.Size(257, 107);
            this.txbOutput.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.NumColorsText);
            this.Controls.Add(this.NumColors);
            this.Controls.Add(this.LogoCheckBox);
            this.Controls.Add(this.ItemTypes);
            this.Controls.Add(this.EngravingText);
            this.Controls.Add(this.NumItemsText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ItemTypes.ResumeLayout(false);
            this.ItemTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumItemsText;
        private System.Windows.Forms.TextBox EngravingText;
        private System.Windows.Forms.GroupBox ItemTypes;
        private System.Windows.Forms.RadioButton USB;
        private System.Windows.Forms.RadioButton Mug;
        private System.Windows.Forms.RadioButton Pen;
        private System.Windows.Forms.CheckBox LogoCheckBox;
        private System.Windows.Forms.Label NumColors;
        private System.Windows.Forms.TextBox NumColorsText;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txbOutput;
    }
}

