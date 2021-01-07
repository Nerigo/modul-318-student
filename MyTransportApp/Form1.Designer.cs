namespace MyTransportApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startStationLabel = new System.Windows.Forms.Label();
            this.endStationLabel = new System.Windows.Forms.Label();
            this.datumLabel = new System.Windows.Forms.Label();
            this.zeitLabel = new System.Windows.Forms.Label();
            this.suchenButton = new System.Windows.Forms.Button();
            this.verbindungenAnzeige = new System.Windows.Forms.DataGridView();
            this.startColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunftColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dauerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumEingabe = new System.Windows.Forms.DateTimePicker();
            this.zeitEingabe = new System.Windows.Forms.DateTimePicker();
            this.startStationEingabe = new System.Windows.Forms.TextBox();
            this.endStationEingabe = new System.Windows.Forms.TextBox();
            this.stopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.verbindungenAnzeige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startStationLabel
            // 
            this.startStationLabel.AutoSize = true;
            this.startStationLabel.Location = new System.Drawing.Point(12, 15);
            this.startStationLabel.Name = "startStationLabel";
            this.startStationLabel.Size = new System.Drawing.Size(42, 17);
            this.startStationLabel.TabIndex = 0;
            this.startStationLabel.Text = "Start:";
            // 
            // endStationLabel
            // 
            this.endStationLabel.AutoSize = true;
            this.endStationLabel.Location = new System.Drawing.Point(12, 43);
            this.endStationLabel.Name = "endStationLabel";
            this.endStationLabel.Size = new System.Drawing.Size(45, 17);
            this.endStationLabel.TabIndex = 1;
            this.endStationLabel.Text = "Ende:";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(12, 73);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(53, 17);
            this.datumLabel.TabIndex = 2;
            this.datumLabel.Text = "Datum:";
            // 
            // zeitLabel
            // 
            this.zeitLabel.AutoSize = true;
            this.zeitLabel.Location = new System.Drawing.Point(12, 101);
            this.zeitLabel.Name = "zeitLabel";
            this.zeitLabel.Size = new System.Drawing.Size(36, 17);
            this.zeitLabel.TabIndex = 3;
            this.zeitLabel.Text = "Zeit:";
            // 
            // suchenButton
            // 
            this.suchenButton.Location = new System.Drawing.Point(376, 68);
            this.suchenButton.Name = "suchenButton";
            this.suchenButton.Size = new System.Drawing.Size(124, 50);
            this.suchenButton.TabIndex = 8;
            this.suchenButton.Text = "Suchen";
            this.suchenButton.UseVisualStyleBackColor = true;
            this.suchenButton.Click += new System.EventHandler(this.suchenButton_Click);
            // 
            // verbindungenAnzeige
            // 
            this.verbindungenAnzeige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verbindungenAnzeige.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startColumn,
            this.abfahrtColumn,
            this.endeColumn,
            this.ankunftColumn,
            this.dauerColumn});
            this.verbindungenAnzeige.Location = new System.Drawing.Point(12, 124);
            this.verbindungenAnzeige.Name = "verbindungenAnzeige";
            this.verbindungenAnzeige.RowHeadersWidth = 51;
            this.verbindungenAnzeige.RowTemplate.Height = 24;
            this.verbindungenAnzeige.Size = new System.Drawing.Size(904, 303);
            this.verbindungenAnzeige.TabIndex = 9;
            // 
            // startColumn
            // 
            this.startColumn.HeaderText = "Start";
            this.startColumn.MinimumWidth = 6;
            this.startColumn.Name = "startColumn";
            this.startColumn.Width = 125;
            // 
            // abfahrtColumn
            // 
            this.abfahrtColumn.HeaderText = "Abfahrt";
            this.abfahrtColumn.MinimumWidth = 6;
            this.abfahrtColumn.Name = "abfahrtColumn";
            this.abfahrtColumn.Width = 125;
            // 
            // endeColumn
            // 
            this.endeColumn.HeaderText = "Ende";
            this.endeColumn.MinimumWidth = 6;
            this.endeColumn.Name = "endeColumn";
            this.endeColumn.Width = 125;
            // 
            // ankunftColumn
            // 
            this.ankunftColumn.HeaderText = "Ankunft";
            this.ankunftColumn.MinimumWidth = 6;
            this.ankunftColumn.Name = "ankunftColumn";
            this.ankunftColumn.Width = 125;
            // 
            // dauerColumn
            // 
            this.dauerColumn.HeaderText = "Dauer";
            this.dauerColumn.MinimumWidth = 6;
            this.dauerColumn.Name = "dauerColumn";
            this.dauerColumn.Width = 125;
            // 
            // datumEingabe
            // 
            this.datumEingabe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumEingabe.Location = new System.Drawing.Point(98, 68);
            this.datumEingabe.Name = "datumEingabe";
            this.datumEingabe.Size = new System.Drawing.Size(126, 22);
            this.datumEingabe.TabIndex = 10;
            this.datumEingabe.Value = new System.DateTime(2021, 1, 7, 14, 30, 1, 0);
            // 
            // zeitEingabe
            // 
            this.zeitEingabe.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.zeitEingabe.Location = new System.Drawing.Point(98, 96);
            this.zeitEingabe.Name = "zeitEingabe";
            this.zeitEingabe.Size = new System.Drawing.Size(126, 22);
            this.zeitEingabe.TabIndex = 11;
            this.zeitEingabe.Value = new System.DateTime(2021, 1, 7, 14, 30, 36, 0);
            // 
            // startStationEingabe
            // 
            this.startStationEingabe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.startStationEingabe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.startStationEingabe.Location = new System.Drawing.Point(98, 12);
            this.startStationEingabe.Name = "startStationEingabe";
            this.startStationEingabe.Size = new System.Drawing.Size(234, 22);
            this.startStationEingabe.TabIndex = 12;
            this.startStationEingabe.TextChanged += new System.EventHandler(this.startStationEingabe_TextChanged);
            // 
            // endStationEingabe
            // 
            this.endStationEingabe.Location = new System.Drawing.Point(98, 40);
            this.endStationEingabe.Name = "endStationEingabe";
            this.endStationEingabe.Size = new System.Drawing.Size(234, 22);
            this.endStationEingabe.TabIndex = 13;
            // 
            // stopBindingSource
            // 
            this.stopBindingSource.DataSource = typeof(SwissTransport.Models.Stop);
            // 
            // stationsBindingSource
            // 
            this.stationsBindingSource.DataSource = typeof(SwissTransport.Models.Stations);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 439);
            this.Controls.Add(this.endStationEingabe);
            this.Controls.Add(this.startStationEingabe);
            this.Controls.Add(this.zeitEingabe);
            this.Controls.Add(this.datumEingabe);
            this.Controls.Add(this.verbindungenAnzeige);
            this.Controls.Add(this.suchenButton);
            this.Controls.Add(this.zeitLabel);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.endStationLabel);
            this.Controls.Add(this.startStationLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.verbindungenAnzeige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startStationLabel;
        private System.Windows.Forms.Label endStationLabel;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Label zeitLabel;
        private System.Windows.Forms.Button suchenButton;
        private System.Windows.Forms.DataGridView verbindungenAnzeige;
        private System.Windows.Forms.DateTimePicker datumEingabe;
        private System.Windows.Forms.DateTimePicker zeitEingabe;
        private System.Windows.Forms.DataGridViewTextBoxColumn startColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ankunftColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dauerColumn;
        private System.Windows.Forms.BindingSource stopBindingSource;
        private System.Windows.Forms.BindingSource stationsBindingSource;
        private System.Windows.Forms.TextBox startStationEingabe;
        private System.Windows.Forms.TextBox endStationEingabe;
    }
}

