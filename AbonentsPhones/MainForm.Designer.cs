namespace AbonentsPhones
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCities = new System.Windows.Forms.ListBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelKod = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelFio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listCities
            // 
            this.listCities.FormattingEnabled = true;
            this.listCities.ItemHeight = 16;
            this.listCities.Location = new System.Drawing.Point(148, 55);
            this.listCities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listCities.Name = "listCities";
            this.listCities.Size = new System.Drawing.Size(272, 324);
            this.listCities.TabIndex = 0;
            this.listCities.SelectedIndexChanged += new System.EventHandler(this.listCities_SelectedIndexChanged);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(701, 143);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(159, 22);
            this.textBoxNumber.TabIndex = 1;
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(701, 191);
            this.textBoxFio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(159, 22);
            this.textBoxFio.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(605, 352);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(201, 28);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить абонента";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelKod
            // 
            this.labelKod.AutoSize = true;
            this.labelKod.Location = new System.Drawing.Point(547, 102);
            this.labelKod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKod.Name = "labelKod";
            this.labelKod.Size = new System.Drawing.Size(86, 17);
            this.labelKod.TabIndex = 4;
            this.labelKod.Text = "Код города:";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelValue.Location = new System.Drawing.Point(643, 102);
            this.labelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(58, 17);
            this.labelValue.TabIndex = 5;
            this.labelValue.Text = "7-777-7";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(547, 146);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(125, 17);
            this.labelNumber.TabIndex = 6;
            this.labelNumber.Text = "Номер телефона:";
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Location = new System.Drawing.Point(547, 191);
            this.labelFio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFio.Name = "labelFio";
            this.labelFio.Size = new System.Drawing.Size(107, 17);
            this.labelFio.TabIndex = 7;
            this.labelFio.Text = "Фамилия И.О.:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelFio);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelKod);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxFio);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.listCities);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Добавление абонента в базу данных";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCities;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelKod;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelFio;
    }
}

