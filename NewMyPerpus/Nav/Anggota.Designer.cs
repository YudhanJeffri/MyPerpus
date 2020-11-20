namespace NewMyPerpus.Nav
{
    partial class Anggota
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableAnggotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseAnggotaDataSet = new NewMyPerpus.DatabaseAnggotaDataSet();
            this.tableAnggotaTableAdapter = new NewMyPerpus.DatabaseAnggotaDataSetTableAdapters.TableAnggotaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableAnggotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAnggotaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAnggotaBindingSource
            // 
            this.tableAnggotaBindingSource.DataMember = "TableAnggota";
            this.tableAnggotaBindingSource.DataSource = this.databaseAnggotaDataSet;
            // 
            // databaseAnggotaDataSet
            // 
            this.databaseAnggotaDataSet.DataSetName = "DatabaseAnggotaDataSet";
            this.databaseAnggotaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAnggotaTableAdapter
            // 
            this.tableAnggotaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 99);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coming soon !!";
            // 
            // Anggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Name = "Anggota";
            this.Size = new System.Drawing.Size(1363, 1045);
            this.Load += new System.EventHandler(this.Anggota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableAnggotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAnggotaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tableAnggotaBindingSource;
        private DatabaseAnggotaDataSet databaseAnggotaDataSet;
        private DatabaseAnggotaDataSetTableAdapters.TableAnggotaTableAdapter tableAnggotaTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}
