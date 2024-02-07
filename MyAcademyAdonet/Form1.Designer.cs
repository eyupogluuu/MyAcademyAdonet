namespace MyAcademyAdonet
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
			this.btnliste = new System.Windows.Forms.Button();
			this.btngetir = new System.Windows.Forms.Button();
			this.btnguncel = new System.Windows.Forms.Button();
			this.btnsil = new System.Windows.Forms.Button();
			this.btnekle = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtprobaslik = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtoran = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtfiyat = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.richTextdetaylar = new System.Windows.Forms.RichTextBox();
			this.combokategori = new System.Windows.Forms.ComboBox();
			this.txtid = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnliste
			// 
			this.btnliste.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnliste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnliste.Location = new System.Drawing.Point(21, 12);
			this.btnliste.Name = "btnliste";
			this.btnliste.Size = new System.Drawing.Size(82, 30);
			this.btnliste.TabIndex = 0;
			this.btnliste.Text = "Listele";
			this.btnliste.UseVisualStyleBackColor = false;
			this.btnliste.Click += new System.EventHandler(this.btnliste_Click);
			// 
			// btngetir
			// 
			this.btngetir.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btngetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btngetir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btngetir.Location = new System.Drawing.Point(21, 165);
			this.btngetir.Name = "btngetir";
			this.btngetir.Size = new System.Drawing.Size(82, 33);
			this.btngetir.TabIndex = 1;
			this.btngetir.Text = "Getir";
			this.btngetir.UseVisualStyleBackColor = false;
			this.btngetir.Click += new System.EventHandler(this.btngetir_Click);
			// 
			// btnguncel
			// 
			this.btnguncel.BackColor = System.Drawing.Color.LawnGreen;
			this.btnguncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnguncel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnguncel.Location = new System.Drawing.Point(21, 128);
			this.btnguncel.Name = "btnguncel";
			this.btnguncel.Size = new System.Drawing.Size(82, 30);
			this.btnguncel.TabIndex = 2;
			this.btnguncel.Text = "Güncelle";
			this.btnguncel.UseVisualStyleBackColor = false;
			this.btnguncel.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnsil
			// 
			this.btnsil.BackColor = System.Drawing.Color.Red;
			this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnsil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnsil.Location = new System.Drawing.Point(21, 86);
			this.btnsil.Name = "btnsil";
			this.btnsil.Size = new System.Drawing.Size(82, 35);
			this.btnsil.TabIndex = 3;
			this.btnsil.Text = "Sil";
			this.btnsil.UseVisualStyleBackColor = false;
			this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
			// 
			// btnekle
			// 
			this.btnekle.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnekle.Location = new System.Drawing.Point(21, 49);
			this.btnekle.Name = "btnekle";
			this.btnekle.Size = new System.Drawing.Size(82, 30);
			this.btnekle.TabIndex = 4;
			this.btnekle.Text = "Ekle";
			this.btnekle.UseVisualStyleBackColor = false;
			this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(21, 222);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(810, 216);
			this.dataGridView1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(198, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Proje Basligi:";
			// 
			// txtprobaslik
			// 
			this.txtprobaslik.Location = new System.Drawing.Point(303, 33);
			this.txtprobaslik.Name = "txtprobaslik";
			this.txtprobaslik.Size = new System.Drawing.Size(121, 20);
			this.txtprobaslik.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(225, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Kategori:";
			// 
			// txtoran
			// 
			this.txtoran.Location = new System.Drawing.Point(303, 86);
			this.txtoran.Name = "txtoran";
			this.txtoran.Size = new System.Drawing.Size(121, 20);
			this.txtoran.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(146, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(151, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Tamamlanma Oranı:";
			// 
			// txtfiyat
			// 
			this.txtfiyat.Location = new System.Drawing.Point(303, 116);
			this.txtfiyat.Name = "txtfiyat";
			this.txtfiyat.Size = new System.Drawing.Size(121, 20);
			this.txtfiyat.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(250, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "Fiyat:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(442, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 20);
			this.label5.TabIndex = 14;
			this.label5.Text = "Proje Detayları:";
			// 
			// richTextdetaylar
			// 
			this.richTextdetaylar.Location = new System.Drawing.Point(559, 33);
			this.richTextdetaylar.Name = "richTextdetaylar";
			this.richTextdetaylar.Size = new System.Drawing.Size(272, 125);
			this.richTextdetaylar.TabIndex = 15;
			this.richTextdetaylar.Text = "";
			// 
			// combokategori
			// 
			this.combokategori.FormattingEnabled = true;
			this.combokategori.Location = new System.Drawing.Point(303, 59);
			this.combokategori.Name = "combokategori";
			this.combokategori.Size = new System.Drawing.Size(121, 21);
			this.combokategori.TabIndex = 16;
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(303, 142);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(121, 20);
			this.txtid.TabIndex = 18;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(267, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(30, 20);
			this.label6.TabIndex = 17;
			this.label6.Text = "ID:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(871, 450);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.combokategori);
			this.Controls.Add(this.richTextdetaylar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtfiyat);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtoran);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtprobaslik);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnekle);
			this.Controls.Add(this.btnsil);
			this.Controls.Add(this.btnguncel);
			this.Controls.Add(this.btngetir);
			this.Controls.Add(this.btnliste);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnliste;
		private System.Windows.Forms.Button btngetir;
		private System.Windows.Forms.Button btnguncel;
		private System.Windows.Forms.Button btnsil;
		private System.Windows.Forms.Button btnekle;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtprobaslik;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtoran;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtfiyat;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RichTextBox richTextdetaylar;
		private System.Windows.Forms.ComboBox combokategori;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.Label label6;
	}
}

