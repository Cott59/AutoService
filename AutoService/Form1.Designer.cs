namespace AutoService
{
    partial class Form1
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
            this.cmbMechanic = new System.Windows.Forms.ComboBox();
            this.lbMechanic = new System.Windows.Forms.Label();
            this.tb_add_del_edit_Master = new System.Windows.Forms.TextBox();
            this.btn_AddMaster = new System.Windows.Forms.Button();
            this.btn_DelMechanic = new System.Windows.Forms.Button();
            this.btn_EditMechanic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbMechanic
            // 
            this.cmbMechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbMechanic.FormattingEnabled = true;
            this.cmbMechanic.Location = new System.Drawing.Point(32, 58);
            this.cmbMechanic.Name = "cmbMechanic";
            this.cmbMechanic.Size = new System.Drawing.Size(175, 41);
            this.cmbMechanic.TabIndex = 0;
            // 
            // lbMechanic
            // 
            this.lbMechanic.AutoSize = true;
            this.lbMechanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMechanic.Location = new System.Drawing.Point(32, 13);
            this.lbMechanic.Name = "lbMechanic";
            this.lbMechanic.Size = new System.Drawing.Size(87, 26);
            this.lbMechanic.TabIndex = 1;
            this.lbMechanic.Text = "Мастер";
            // 
            // tb_add_del_edit_Master
            // 
            this.tb_add_del_edit_Master.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_add_del_edit_Master.Location = new System.Drawing.Point(235, 58);
            this.tb_add_del_edit_Master.Name = "tb_add_del_edit_Master";
            this.tb_add_del_edit_Master.Size = new System.Drawing.Size(179, 41);
            this.tb_add_del_edit_Master.TabIndex = 2;
            // 
            // btn_AddMaster
            // 
            this.btn_AddMaster.Location = new System.Drawing.Point(459, 61);
            this.btn_AddMaster.Name = "btn_AddMaster";
            this.btn_AddMaster.Size = new System.Drawing.Size(75, 32);
            this.btn_AddMaster.TabIndex = 3;
            this.btn_AddMaster.Text = "Добавить";
            this.btn_AddMaster.UseVisualStyleBackColor = true;
            this.btn_AddMaster.Click += new System.EventHandler(this.btn_AddMaster_Click);
            // 
            // btn_DelMechanic
            // 
            this.btn_DelMechanic.Location = new System.Drawing.Point(459, 99);
            this.btn_DelMechanic.Name = "btn_DelMechanic";
            this.btn_DelMechanic.Size = new System.Drawing.Size(75, 28);
            this.btn_DelMechanic.TabIndex = 4;
            this.btn_DelMechanic.Text = "Удалить";
            this.btn_DelMechanic.UseVisualStyleBackColor = true;
            this.btn_DelMechanic.Click += new System.EventHandler(this.btn_DelMechanic_Click);
            // 
            // btn_EditMechanic
            // 
            this.btn_EditMechanic.Location = new System.Drawing.Point(459, 133);
            this.btn_EditMechanic.Name = "btn_EditMechanic";
            this.btn_EditMechanic.Size = new System.Drawing.Size(75, 31);
            this.btn_EditMechanic.TabIndex = 5;
            this.btn_EditMechanic.Text = "Изменить";
            this.btn_EditMechanic.UseVisualStyleBackColor = true;
            this.btn_EditMechanic.Click += new System.EventHandler(this.btn_EditMechanic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "новое имя";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_EditMechanic);
            this.Controls.Add(this.btn_DelMechanic);
            this.Controls.Add(this.btn_AddMaster);
            this.Controls.Add(this.tb_add_del_edit_Master);
            this.Controls.Add(this.lbMechanic);
            this.Controls.Add(this.cmbMechanic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMechanic;
        private System.Windows.Forms.Label lbMechanic;
        private System.Windows.Forms.TextBox tb_add_del_edit_Master;
        private System.Windows.Forms.Button btn_AddMaster;
        private System.Windows.Forms.Button btn_DelMechanic;
        private System.Windows.Forms.Button btn_EditMechanic;
        private System.Windows.Forms.Label label1;
    }
}

