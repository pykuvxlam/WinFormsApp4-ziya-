namespace WinFormsApp4__ziya_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.NumericUpDown numericAge;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label labelResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(30, 30);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(250, 22);
            this.textBoxFio.TabIndex = 0;
            this.textBoxFio.PlaceholderText = "Введите ФИО";
            // 
            // numericAge
            // 
            this.numericAge.Location = new System.Drawing.Point(30, 70);
            this.numericAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            this.numericAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(120, 22);
            this.numericAge.TabIndex = 1;
            this.numericAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // comboGender
            // 
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] { "Муж", "Жен" });
            this.comboGender.Location = new System.Drawing.Point(30, 110);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(120, 24);
            this.comboGender.TabIndex = 2;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(30, 150);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(150, 30);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Показать данные";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // labelResult
            // 
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResult.Location = new System.Drawing.Point(30, 200);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(250, 100);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Результат появится здесь";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.numericAge);
            this.Controls.Add(this.textBoxFio);
            this.Name = "Form1";
            this.Text = "Мини-анкета";
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
