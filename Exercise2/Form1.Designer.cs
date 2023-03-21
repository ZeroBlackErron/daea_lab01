namespace Exercise2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.personalInformation = new System.Windows.Forms.GroupBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.extaInformation = new System.Windows.Forms.GroupBox();
            this.dniLabel = new System.Windows.Forms.Label();
            this.dpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.statusCheckBok = new System.Windows.Forms.CheckBox();
            this.idLabel = new System.Windows.Forms.LinkLabel();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.usersTable = new System.Windows.Forms.DataGridView();
            this.codeHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deparmentHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalInformation.SuspendLayout();
            this.extaInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // personalInformation
            // 
            this.personalInformation.Controls.Add(this.idLabel);
            this.personalInformation.Controls.Add(this.statusCheckBok);
            this.personalInformation.Controls.Add(this.dpBirthdate);
            this.personalInformation.Controls.Add(this.dniLabel);
            this.personalInformation.Controls.Add(this.txtDNI);
            this.personalInformation.Controls.Add(this.txtLastName);
            this.personalInformation.Controls.Add(this.txtEmail);
            this.personalInformation.Controls.Add(this.txtPhone);
            this.personalInformation.Controls.Add(this.txtAddress);
            this.personalInformation.Controls.Add(this.txtName);
            this.personalInformation.Controls.Add(this.birthdateLabel);
            this.personalInformation.Controls.Add(this.emailLabel);
            this.personalInformation.Controls.Add(this.phoneLabel);
            this.personalInformation.Controls.Add(this.addressLabel);
            this.personalInformation.Controls.Add(this.lastNameLabel);
            this.personalInformation.Controls.Add(this.nameLabel);
            this.personalInformation.Controls.Add(this.codeLabel);
            this.personalInformation.Location = new System.Drawing.Point(30, 29);
            this.personalInformation.Name = "personalInformation";
            this.personalInformation.Size = new System.Drawing.Size(390, 230);
            this.personalInformation.TabIndex = 0;
            this.personalInformation.TabStop = false;
            this.personalInformation.Text = "Datos personales";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(266, 51);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(97, 20);
            this.txtDNI.TabIndex = 14;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(79, 82);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(284, 20);
            this.txtLastName.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(79, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(284, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(79, 135);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(79, 109);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(284, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 20);
            this.txtName.TabIndex = 8;
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(10, 187);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(63, 13);
            this.birthdateLabel.TabIndex = 6;
            this.birthdateLabel.Text = "Fecha Nac:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(38, 163);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(21, 138);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(52, 13);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Teléfono:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(18, 113);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(55, 13);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Dirección:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(26, 87);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(47, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Apellido:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(27, 58);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Nombre:";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(30, 33);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(43, 13);
            this.codeLabel.TabIndex = 0;
            this.codeLabel.Text = "Código:";
            // 
            // extaInformation
            // 
            this.extaInformation.Controls.Add(this.cboPosition);
            this.extaInformation.Controls.Add(this.cboDepartment);
            this.extaInformation.Controls.Add(this.label2);
            this.extaInformation.Controls.Add(this.departmentLabel);
            this.extaInformation.Location = new System.Drawing.Point(426, 29);
            this.extaInformation.Name = "extaInformation";
            this.extaInformation.Size = new System.Drawing.Size(297, 230);
            this.extaInformation.TabIndex = 1;
            this.extaInformation.TabStop = false;
            this.extaInformation.Text = "Information adicional";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(231, 58);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(29, 13);
            this.dniLabel.TabIndex = 2;
            this.dniLabel.Text = "DNI:";
            // 
            // dpBirthdate
            // 
            this.dpBirthdate.Location = new System.Drawing.Point(79, 188);
            this.dpBirthdate.Name = "dpBirthdate";
            this.dpBirthdate.Size = new System.Drawing.Size(194, 20);
            this.dpBirthdate.TabIndex = 15;
            // 
            // statusCheckBok
            // 
            this.statusCheckBok.AutoSize = true;
            this.statusCheckBok.Location = new System.Drawing.Point(307, 191);
            this.statusCheckBok.Name = "statusCheckBok";
            this.statusCheckBok.Size = new System.Drawing.Size(56, 17);
            this.statusCheckBok.TabIndex = 16;
            this.statusCheckBok.Text = "Activo";
            this.statusCheckBok.UseVisualStyleBackColor = true;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(79, 33);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(45, 13);
            this.idLabel.TabIndex = 17;
            this.idLabel.TabStop = true;
            this.idLabel.Text = "U10023";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(24, 37);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(77, 13);
            this.departmentLabel.TabIndex = 0;
            this.departmentLabel.Text = "Departamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargo:";
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Items.AddRange(new object[] {
            "RRHH",
            "Conabilidad",
            "Logistica"});
            this.cboDepartment.Location = new System.Drawing.Point(120, 34);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(121, 21);
            this.cboDepartment.TabIndex = 2;
            // 
            // cboPosition
            // 
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(120, 61);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(121, 21);
            this.cboPosition.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(360, 265);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 31);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(459, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(544, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(635, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // usersTable
            // 
            this.usersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeHeader,
            this.dniHeader,
            this.lastNameHeader,
            this.addressHeader,
            this.phoneHeader,
            this.emailHeader,
            this.birthdateHeader,
            this.deparmentHeader});
            this.usersTable.Location = new System.Drawing.Point(30, 313);
            this.usersTable.Name = "usersTable";
            this.usersTable.Size = new System.Drawing.Size(693, 150);
            this.usersTable.TabIndex = 6;
            // 
            // codeHeader
            // 
            this.codeHeader.HeaderText = "Código";
            this.codeHeader.Name = "codeHeader";
            // 
            // dniHeader
            // 
            this.dniHeader.HeaderText = "DNI";
            this.dniHeader.Name = "dniHeader";
            // 
            // lastNameHeader
            // 
            this.lastNameHeader.HeaderText = "Apellidos";
            this.lastNameHeader.Name = "lastNameHeader";
            // 
            // addressHeader
            // 
            this.addressHeader.HeaderText = "Dirección";
            this.addressHeader.Name = "addressHeader";
            // 
            // phoneHeader
            // 
            this.phoneHeader.HeaderText = "Teléfono";
            this.phoneHeader.Name = "phoneHeader";
            // 
            // emailHeader
            // 
            this.emailHeader.HeaderText = "Email";
            this.emailHeader.Name = "emailHeader";
            // 
            // birthdateHeader
            // 
            this.birthdateHeader.HeaderText = "Fec/Nac";
            this.birthdateHeader.Name = "birthdateHeader";
            // 
            // deparmentHeader
            // 
            this.deparmentHeader.HeaderText = "Departamento";
            this.deparmentHeader.Name = "deparmentHeader";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 483);
            this.Controls.Add(this.usersTable);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.extaInformation);
            this.Controls.Add(this.personalInformation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.personalInformation.ResumeLayout(false);
            this.personalInformation.PerformLayout();
            this.extaInformation.ResumeLayout(false);
            this.extaInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox personalInformation;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.GroupBox extaInformation;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.LinkLabel idLabel;
        private System.Windows.Forms.CheckBox statusCheckBok;
        private System.Windows.Forms.DateTimePicker dpBirthdate;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView usersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn deparmentHeader;
    }
}

