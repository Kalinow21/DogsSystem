
namespace DogsSystem.View
{
    partial class MainView
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
            this.dgvDogs = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dogBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dogsDBEntities1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogsDBEntities1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDogs
            // 
            this.dgvDogs.AutoGenerateColumns = false;
            this.dgvDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dgvDogs.DataSource = this.dogBindingSource3;
            this.dgvDogs.Location = new System.Drawing.Point(-1, 12);
            this.dgvDogs.Name = "dgvDogs";
            this.dgvDogs.Size = new System.Drawing.Size(316, 169);
            this.dgvDogs.TabIndex = 0;
            this.dgvDogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(321, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 41);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAge
            // 
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(322, 78);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(129, 41);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(469, 23);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 39);
            this.txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(470, 80);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(134, 39);
            this.txtAge.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(615, 53);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(135, 40);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create Dog";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // dogBindingSource3
            // 
            this.dogBindingSource3.DataSource = typeof(DogsSystem.Model.Dog);
            // 
            // dogBindingSource2
            // 
            this.dogBindingSource2.DataSource = typeof(DogsSystem.Model.Dog);
            // 
            // dogBindingSource
            // 
            this.dogBindingSource.DataSource = typeof(DogsSystem.Model.Dog);
            // 
            // dogBindingSource1
            // 
            this.dogBindingSource1.DataSource = typeof(DogsSystem.Model.Dog);
            // 
            // dogsDBEntities1BindingSource
            // 
            this.dogsDBEntities1BindingSource.DataSource = typeof(DogsSystem.Model.DogsDBEntities1);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DogsSystem.Properties.Resources.saasassasasa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvDogs);
            this.Name = "MainView";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogsDBEntities1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dogBindingSource;
        private System.Windows.Forms.DataGridView dgvDogs;
        private System.Windows.Forms.BindingSource dogBindingSource1;
        private System.Windows.Forms.BindingSource dogBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dogBindingSource3;
        private System.Windows.Forms.BindingSource dogsDBEntities1BindingSource;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnCreate;
    }
}