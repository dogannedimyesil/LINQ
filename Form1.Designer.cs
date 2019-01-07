namespace LINQ
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AllNumbers = new System.Windows.Forms.Button();
            this.btn_AllNames = new System.Windows.Forms.Button();
            this.btn_AllOrders = new System.Windows.Forms.Button();
            this.btn_Negatives = new System.Windows.Forms.Button();
            this.btn_Pozitive = new System.Windows.Forms.Button();
            this.btn_Even = new System.Windows.Forms.Button();
            this.btn_Odd = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.btn_Min = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.name_Alphabetical = new System.Windows.Forms.Button();
            this.alphabetical_Reverse = new System.Windows.Forms.Button();
            this.name_Lengths = new System.Windows.Forms.Button();
            this.names_IncludesD = new System.Windows.Forms.Button();
            this.startswithA = new System.Windows.Forms.Button();
            this.justDates = new System.Windows.Forms.Button();
            this.firstFive = new System.Windows.Forms.Button();
            this.lastFive = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.qtyofOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_AllNumbers
            // 
            this.btn_AllNumbers.Location = new System.Drawing.Point(12, 14);
            this.btn_AllNumbers.Name = "btn_AllNumbers";
            this.btn_AllNumbers.Size = new System.Drawing.Size(87, 23);
            this.btn_AllNumbers.TabIndex = 1;
            this.btn_AllNumbers.Text = "Tüm Sayılar";
            this.btn_AllNumbers.UseVisualStyleBackColor = true;
            this.btn_AllNumbers.Click += new System.EventHandler(this.btn_AllNumbers_Click);
            // 
            // btn_AllNames
            // 
            this.btn_AllNames.Location = new System.Drawing.Point(12, 43);
            this.btn_AllNames.Name = "btn_AllNames";
            this.btn_AllNames.Size = new System.Drawing.Size(87, 23);
            this.btn_AllNames.TabIndex = 2;
            this.btn_AllNames.Text = "Tüm İsimler";
            this.btn_AllNames.UseVisualStyleBackColor = true;
            // 
            // btn_AllOrders
            // 
            this.btn_AllOrders.Location = new System.Drawing.Point(12, 72);
            this.btn_AllOrders.Name = "btn_AllOrders";
            this.btn_AllOrders.Size = new System.Drawing.Size(87, 23);
            this.btn_AllOrders.TabIndex = 3;
            this.btn_AllOrders.Text = "Tüm Siparişler";
            this.btn_AllOrders.UseVisualStyleBackColor = true;
            this.btn_AllOrders.Click += new System.EventHandler(this.btn_AllOrders_Click);
            // 
            // btn_Negatives
            // 
            this.btn_Negatives.Location = new System.Drawing.Point(105, 14);
            this.btn_Negatives.Name = "btn_Negatives";
            this.btn_Negatives.Size = new System.Drawing.Size(50, 23);
            this.btn_Negatives.TabIndex = 4;
            this.btn_Negatives.Text = "Negatif";
            this.btn_Negatives.UseVisualStyleBackColor = true;
            this.btn_Negatives.Click += new System.EventHandler(this.btn_Negatives_Click);
            // 
            // btn_Pozitive
            // 
            this.btn_Pozitive.Location = new System.Drawing.Point(161, 14);
            this.btn_Pozitive.Name = "btn_Pozitive";
            this.btn_Pozitive.Size = new System.Drawing.Size(48, 23);
            this.btn_Pozitive.TabIndex = 5;
            this.btn_Pozitive.Text = "Pozitif";
            this.btn_Pozitive.UseVisualStyleBackColor = true;
            this.btn_Pozitive.Click += new System.EventHandler(this.btn_Pozitive_Click);
            // 
            // btn_Even
            // 
            this.btn_Even.Location = new System.Drawing.Point(215, 14);
            this.btn_Even.Name = "btn_Even";
            this.btn_Even.Size = new System.Drawing.Size(42, 23);
            this.btn_Even.TabIndex = 6;
            this.btn_Even.Text = "Çift";
            this.btn_Even.UseVisualStyleBackColor = true;
            this.btn_Even.Click += new System.EventHandler(this.btn_Even_Click);
            // 
            // btn_Odd
            // 
            this.btn_Odd.Location = new System.Drawing.Point(263, 14);
            this.btn_Odd.Name = "btn_Odd";
            this.btn_Odd.Size = new System.Drawing.Size(42, 23);
            this.btn_Odd.TabIndex = 7;
            this.btn_Odd.Text = "Tek";
            this.btn_Odd.UseVisualStyleBackColor = true;
            this.btn_Odd.Click += new System.EventHandler(this.btn_Odd_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.Location = new System.Drawing.Point(311, 14);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(66, 23);
            this.btn_Max.TabIndex = 8;
            this.btn_Max.Text = "En Büyük";
            this.btn_Max.UseVisualStyleBackColor = true;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_Min
            // 
            this.btn_Min.Location = new System.Drawing.Point(383, 14);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(64, 23);
            this.btn_Min.TabIndex = 9;
            this.btn_Min.Text = "En Küçük";
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(453, 14);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(66, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "Kaç Tane";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(4, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(95, 147);
            this.listBox1.TabIndex = 11;
            // 
            // name_Alphabetical
            // 
            this.name_Alphabetical.Location = new System.Drawing.Point(107, 43);
            this.name_Alphabetical.Name = "name_Alphabetical";
            this.name_Alphabetical.Size = new System.Drawing.Size(66, 23);
            this.name_Alphabetical.TabIndex = 12;
            this.name_Alphabetical.Text = "Alfabetik";
            this.name_Alphabetical.UseVisualStyleBackColor = true;
            this.name_Alphabetical.Click += new System.EventHandler(this.name_Alphabetical_Click);
            // 
            // alphabetical_Reverse
            // 
            this.alphabetical_Reverse.Location = new System.Drawing.Point(179, 43);
            this.alphabetical_Reverse.Name = "alphabetical_Reverse";
            this.alphabetical_Reverse.Size = new System.Drawing.Size(85, 23);
            this.alphabetical_Reverse.TabIndex = 13;
            this.alphabetical_Reverse.Text = "Alfabetik Ters";
            this.alphabetical_Reverse.UseVisualStyleBackColor = true;
            this.alphabetical_Reverse.Click += new System.EventHandler(this.alphabetical_Reverse_Click);
            // 
            // name_Lengths
            // 
            this.name_Lengths.Location = new System.Drawing.Point(270, 43);
            this.name_Lengths.Name = "name_Lengths";
            this.name_Lengths.Size = new System.Drawing.Size(72, 23);
            this.name_Lengths.TabIndex = 14;
            this.name_Lengths.Text = "Uzunluklar";
            this.name_Lengths.UseVisualStyleBackColor = true;
            this.name_Lengths.Click += new System.EventHandler(this.name_Lengths_Click);
            // 
            // names_IncludesD
            // 
            this.names_IncludesD.Location = new System.Drawing.Point(348, 43);
            this.names_IncludesD.Name = "names_IncludesD";
            this.names_IncludesD.Size = new System.Drawing.Size(77, 23);
            this.names_IncludesD.TabIndex = 15;
            this.names_IncludesD.Text = "D Barındıran";
            this.names_IncludesD.UseVisualStyleBackColor = true;
            this.names_IncludesD.Click += new System.EventHandler(this.names_IncludesD_Click);
            // 
            // startswithA
            // 
            this.startswithA.Location = new System.Drawing.Point(431, 43);
            this.startswithA.Name = "startswithA";
            this.startswithA.Size = new System.Drawing.Size(88, 23);
            this.startswithA.TabIndex = 16;
            this.startswithA.Text = "A ile başlayan";
            this.startswithA.UseVisualStyleBackColor = true;
            this.startswithA.Click += new System.EventHandler(this.startswithA_Click);
            // 
            // justDates
            // 
            this.justDates.Location = new System.Drawing.Point(107, 72);
            this.justDates.Name = "justDates";
            this.justDates.Size = new System.Drawing.Size(94, 23);
            this.justDates.TabIndex = 17;
            this.justDates.Text = "Sadece Tarihler";
            this.justDates.UseVisualStyleBackColor = true;
            this.justDates.Click += new System.EventHandler(this.justDates_Click);
            // 
            // firstFive
            // 
            this.firstFive.Location = new System.Drawing.Point(211, 72);
            this.firstFive.Name = "firstFive";
            this.firstFive.Size = new System.Drawing.Size(53, 23);
            this.firstFive.TabIndex = 18;
            this.firstFive.Text = "İlk 5";
            this.firstFive.UseVisualStyleBackColor = true;
            this.firstFive.Click += new System.EventHandler(this.firstFive_Click);
            // 
            // lastFive
            // 
            this.lastFive.Location = new System.Drawing.Point(270, 72);
            this.lastFive.Name = "lastFive";
            this.lastFive.Size = new System.Drawing.Size(53, 23);
            this.lastFive.TabIndex = 19;
            this.lastFive.Text = "Son 5";
            this.lastFive.UseVisualStyleBackColor = true;
            this.lastFive.Click += new System.EventHandler(this.lastFive_Click);
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(329, 72);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(73, 23);
            this.customer.TabIndex = 20;
            this.customer.Text = "Yang Wang";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // qtyofOrders
            // 
            this.qtyofOrders.Location = new System.Drawing.Point(408, 72);
            this.qtyofOrders.Name = "qtyofOrders";
            this.qtyofOrders.Size = new System.Drawing.Size(80, 23);
            this.qtyofOrders.TabIndex = 21;
            this.qtyofOrders.Text = "Sipariş Sayısı";
            this.qtyofOrders.UseVisualStyleBackColor = true;
            this.qtyofOrders.Click += new System.EventHandler(this.qtyofOrders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 278);
            this.Controls.Add(this.qtyofOrders);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.lastFive);
            this.Controls.Add(this.firstFive);
            this.Controls.Add(this.justDates);
            this.Controls.Add(this.startswithA);
            this.Controls.Add(this.names_IncludesD);
            this.Controls.Add(this.name_Lengths);
            this.Controls.Add(this.alphabetical_Reverse);
            this.Controls.Add(this.name_Alphabetical);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btn_Min);
            this.Controls.Add(this.btn_Max);
            this.Controls.Add(this.btn_Odd);
            this.Controls.Add(this.btn_Even);
            this.Controls.Add(this.btn_Pozitive);
            this.Controls.Add(this.btn_Negatives);
            this.Controls.Add(this.btn_AllOrders);
            this.Controls.Add(this.btn_AllNames);
            this.Controls.Add(this.btn_AllNumbers);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AllNumbers;
        private System.Windows.Forms.Button btn_AllNames;
        private System.Windows.Forms.Button btn_AllOrders;
        private System.Windows.Forms.Button btn_Negatives;
        private System.Windows.Forms.Button btn_Pozitive;
        private System.Windows.Forms.Button btn_Even;
        private System.Windows.Forms.Button btn_Odd;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button name_Alphabetical;
        private System.Windows.Forms.Button alphabetical_Reverse;
        private System.Windows.Forms.Button name_Lengths;
        private System.Windows.Forms.Button names_IncludesD;
        private System.Windows.Forms.Button startswithA;
        private System.Windows.Forms.Button justDates;
        private System.Windows.Forms.Button firstFive;
        private System.Windows.Forms.Button lastFive;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button qtyofOrders;
    }
}

