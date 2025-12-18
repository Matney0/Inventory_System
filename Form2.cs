using Microsoft.Data.SqlClient; // Use Microsoft.Data.SqlClient instead of System.Data.SqlClient
using System.Data;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Inventory_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadProducts();
            LoadStock();
            LoadLocations();
        }
        //hhhjhhjhghj

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            label3 = new Label();
            listView2 = new ListView();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            label8 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            button2 = new Button();
            listView3 = new ListView();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            button3 = new Button();
            label7 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label17 = new Label();
            label18 = new Label();
            button4 = new Button();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            textBox11 = new TextBox();
            label26 = new Label();
            button5 = new Button();
            label27 = new Label();
            button6 = new Button();
            label28 = new Label();
            textBox12 = new TextBox();
            button7 = new Button();
            label29 = new Label();
            textBox13 = new TextBox();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            textBox14 = new TextBox();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            textBox15 = new TextBox();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(842, 286);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 0;
            label1.Text = "Location Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(730, 9);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 1;
            label2.Text = "Inventory Management";
            // 
            // listView1
            // 
            listView1.Location = new Point(525, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(499, 182);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 279);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 4;
            label3.Text = "Stock On Hand";
            // 
            // listView2
            // 
            listView2.Location = new Point(312, 297);
            listView2.Name = "listView2";
            listView2.Size = new Size(207, 127);
            listView2.TabIndex = 5;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(320, 515);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(92, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(320, 547);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(92, 23);
            numericUpDown2.TabIndex = 7;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 517);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 8;
            label4.Text = "Add To Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 547);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 9;
            label5.Text = "Delete From Stock";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 476);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(312, 458);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 11;
            label6.Text = "Enter ProductID:";
            // 
            // button1
            // 
            button1.Location = new Point(431, 524);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(417, 20);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 14;
            label8.Text = "Add new product:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(419, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 15;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(419, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(419, 130);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(419, 173);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(371, 42);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 19;
            label9.Text = "Name:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(343, 86);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 20;
            label10.Text = "Description:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(355, 133);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 21;
            label11.Text = "Category:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(371, 176);
            label12.Name = "label12";
            label12.Size = new Size(36, 15);
            label12.TabIndex = 22;
            label12.Text = "Price:";
            // 
            // button2
            // 
            button2.Location = new Point(420, 210);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 23;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView3
            // 
            listView3.Location = new Point(821, 304);
            listView3.Name = "listView3";
            listView3.Size = new Size(245, 127);
            listView3.TabIndex = 24;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.SelectedIndexChanged += listView3_SelectedIndexChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(840, 483);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 25;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(966, 483);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 26;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(840, 524);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(891, 434);
            label13.Name = "label13";
            label13.Size = new Size(108, 15);
            label13.TabIndex = 28;
            label13.Text = "Add New Location:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(836, 465);
            label14.Name = "label14";
            label14.Size = new Size(42, 15);
            label14.TabIndex = 29;
            label14.Text = "Name:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(966, 463);
            label15.Name = "label15";
            label15.Size = new Size(52, 15);
            label15.TabIndex = 30;
            label15.Text = "Address:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(836, 506);
            label16.Name = "label16";
            label16.Size = new Size(34, 15);
            label16.TabIndex = 31;
            label16.Text = "Type:";
            // 
            // button3
            // 
            button3.Location = new Point(966, 524);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 32;
            button3.Text = "Submit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(587, 297);
            label7.Name = "label7";
            label7.Size = new Size(155, 15);
            label7.TabIndex = 33;
            label7.Text = "Stock Product at a Location:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(557, 355);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 34;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(692, 355);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 35;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(716, 335);
            label17.Name = "label17";
            label17.Size = new Size(63, 15);
            label17.TabIndex = 36;
            label17.Text = "ProductID:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(576, 334);
            label18.Name = "label18";
            label18.Size = new Size(67, 15);
            label18.TabIndex = 37;
            label18.Text = "LocationID:";
            // 
            // button4
            // 
            button4.Location = new Point(635, 390);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 38;
            button4.Text = "Submit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(386, 428);
            label19.Name = "label19";
            label19.Size = new Size(79, 15);
            label19.TabIndex = 39;
            label19.Text = "Add To Stock:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(587, 421);
            label20.Name = "label20";
            label20.Size = new Size(198, 15);
            label20.TabIndex = 41;
            label20.Text = "(This will link a product to a location";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(557, 436);
            label21.Name = "label21";
            label21.Size = new Size(253, 15);
            label21.TabIndex = 42;
            label21.Text = "in turn this allows the admin to stock quantity)";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(539, 513);
            label22.Name = "label22";
            label22.Size = new Size(221, 15);
            label22.TabIndex = 43;
            label22.Text = "To add or delete from a product quantity";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(516, 528);
            label23.Name = "label23";
            label23.Size = new Size(294, 15);
            label23.TabIndex = 44;
            label23.Text = "first enter a ProductID and LocationID, then from there";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(550, 543);
            label24.Name = "label24";
            label24.Size = new Size(235, 15);
            label24.TabIndex = 45;
            label24.Text = "use the numeric scales to change quantity. ";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(29, 20);
            label25.Name = "label25";
            label25.Size = new Size(119, 15);
            label25.TabIndex = 46;
            label25.Text = "Delete From Product:";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(80, 42);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 47;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(11, 45);
            label26.Name = "label26";
            label26.Size = new Size(63, 15);
            label26.TabIndex = 48;
            label26.Text = "ProductID:";
            // 
            // button5
            // 
            button5.Location = new Point(73, 71);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 49;
            button5.Text = "Submit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(29, 180);
            label27.Name = "label27";
            label27.Size = new Size(106, 15);
            label27.TabIndex = 50;
            label27.Text = "Delete From Stock:";
            // 
            // button6
            // 
            button6.Location = new Point(80, 267);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 53;
            button6.Text = "Submit";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(12, 213);
            label28.Name = "label28";
            label28.Size = new Size(63, 15);
            label28.TabIndex = 52;
            label28.Text = "ProductID:";
            label28.Click += label28_Click;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(80, 210);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 23);
            textBox12.TabIndex = 51;
            // 
            // button7
            // 
            button7.Location = new Point(73, 417);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 57;
            button7.Text = "Submit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(12, 391);
            label29.Name = "label29";
            label29.Size = new Size(67, 15);
            label29.TabIndex = 56;
            label29.Text = "LocationID:";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(80, 388);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(100, 23);
            textBox13.TabIndex = 55;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(29, 358);
            label30.Name = "label30";
            label30.Size = new Size(123, 15);
            label30.TabIndex = 54;
            label30.Text = "Delete From Location:";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(29, 97);
            label31.Name = "label31";
            label31.Size = new Size(197, 15);
            label31.TabIndex = 58;
            label31.Text = "Must delete product from stock first";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(31, 112);
            label32.Name = "label32";
            label32.Size = new Size(162, 15);
            label32.TabIndex = 59;
            label32.Text = "if present in \"Stock On Hand\"";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(12, 242);
            label33.Name = "label33";
            label33.Size = new Size(67, 15);
            label33.TabIndex = 61;
            label33.Text = "LocationID:";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(80, 239);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(100, 23);
            textBox14.TabIndex = 60;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(12, 454);
            label34.Name = "label34";
            label34.Size = new Size(198, 15);
            label34.TabIndex = 62;
            label34.Text = "Must delete location from stock first";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(12, 469);
            label35.Name = "label35";
            label35.Size = new Size(162, 15);
            label35.TabIndex = 63;
            label35.Text = "if present in \"Stock On Hand\"";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(419, 458);
            label36.Name = "label36";
            label36.Size = new Size(97, 15);
            label36.TabIndex = 65;
            label36.Text = "Enter LocationID:";
            label36.Click += label36_Click;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(419, 476);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(100, 23);
            textBox15.TabIndex = 64;
            // 
            // button8
            // 
            button8.Location = new Point(12, 547);
            button8.Name = "button8";
            button8.Size = new Size(150, 23);
            button8.TabIndex = 66;
            button8.Text = "Click Here to Logout!";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form2
            // 
            ClientSize = new Size(1078, 586);
            Controls.Add(button8);
            Controls.Add(label36);
            Controls.Add(textBox15);
            Controls.Add(label35);
            Controls.Add(label34);
            Controls.Add(label33);
            Controls.Add(textBox14);
            Controls.Add(label32);
            Controls.Add(label31);
            Controls.Add(button7);
            Controls.Add(label29);
            Controls.Add(textBox13);
            Controls.Add(label30);
            Controls.Add(button6);
            Controls.Add(label28);
            Controls.Add(textBox12);
            Controls.Add(label27);
            Controls.Add(button5);
            Controls.Add(label26);
            Controls.Add(textBox11);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(button4);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(listView3);
            Controls.Add(button2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(listView2);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private Label label1;
        private ListView listView1;
        private Label label3;
        private ListView listView2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private Button button1;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button2;
        private ListView listView3;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button button3;
        private Label label7;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label17;
        private Label label18;
        private Button button4;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private TextBox textBox11;
        private Label label26;
        private Button button5;
        private Label label27;
        private Button button6;
        private Label label28;
        private TextBox textBox12;
        private Button button7;
        private Label label29;
        private TextBox textBox13;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private TextBox textBox14;
        private Label label34;
        private Label label35;
        private Label label36;
        private TextBox textBox15;
        private Button button8;
        private Label label2;

        private void LoadProducts()
        {
            string connectionString = @"Data Source=BB21318\SQL_FALL_MATNEY;Initial Catalog=Login;User ID=user;password=matney;TrustServerCertificate=True";


            string query = "SELECT ProductID, Name, Description, Category, UnitPrice FROM Products";

            try
            {
                listView1.BeginUpdate();
                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.View = View.Details;
                listView1.FullRowSelect = true;

                listView1.Columns.Add("ProductID", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Name", 180, HorizontalAlignment.Left);
                listView1.Columns.Add("Description", 300, HorizontalAlignment.Left);
                listView1.Columns.Add("Category", 120, HorizontalAlignment.Left);
                listView1.Columns.Add("UnitPrice", 80, HorizontalAlignment.Right);

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productId = reader["ProductID"]?.ToString() ?? "";
                            string name = reader["Name"]?.ToString() ?? "";
                            string description = reader["Description"]?.ToString() ?? "";
                            string category = reader["Category"]?.ToString() ?? "";
                            string unitPrice = reader["UnitPrice"]?.ToString() ?? "";

                            var item = new ListViewItem(productId);
                            item.SubItems.Add(name);
                            item.SubItems.Add(description);
                            item.SubItems.Add(category);
                            item.SubItems.Add(unitPrice);

                            listView1.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                listView1.EndUpdate();
            }
        }
        private void LoadStock()
        {
            string connectionString = @"Data Source=BB21318\SQL_FALL_MATNEY;Initial Catalog=Login;User ID=user;password=matney;TrustServerCertificate=True";
            string query = "SELECT LocationID, ProductID, Quantity FROM Stock";

            try
            {
                listView2.BeginUpdate();
                listView2.Items.Clear();
                listView2.Columns.Clear();
                listView2.View = View.Details;
                listView2.FullRowSelect = true;
                listView2.Columns.Add("LocationID", 100, HorizontalAlignment.Left);
                listView2.Columns.Add("ProductID", 100, HorizontalAlignment.Left);
                listView2.Columns.Add("Quantity", 80, HorizontalAlignment.Right);
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string locationId = reader["LocationID"]?.ToString() ?? "";
                            string productId = reader["ProductID"]?.ToString() ?? "";
                            string quantity = reader["Quantity"]?.ToString() ?? "";
                            var item = new ListViewItem(locationId);
                            item.SubItems.Add(productId);
                            item.SubItems.Add(quantity);
                            listView2.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                listView2.EndUpdate();
            }
        }
        private void LoadLocations()
        {
            string connectionString = @"Data Source=BB21318\SQL_FALL_MATNEY;Initial Catalog=Login;User ID=user;password=matney;TrustServerCertificate=True";
            string query = "SELECT LocationID, Name, Address, Type FROM Locations";
            try
            {
                listView3.BeginUpdate();
                listView3.Items.Clear();
                listView3.Columns.Clear();
                listView3.View = View.Details;
                listView3.FullRowSelect = true;
                listView3.Columns.Add("LocationID", 100, HorizontalAlignment.Left);
                listView3.Columns.Add("Name", 150, HorizontalAlignment.Left);
                listView3.Columns.Add("Address", 200, HorizontalAlignment.Left);
                listView3.Columns.Add("Type", 100, HorizontalAlignment.Left);
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string locationId = reader["LocationID"]?.ToString() ?? "";
                            string name = reader["Name"]?.ToString() ?? "";
                            string address = reader["Address"]?.ToString() ?? "";
                            string type = reader["Type"]?.ToString() ?? "";
                            var item = new ListViewItem(locationId);
                            item.SubItems.Add(name);
                            item.SubItems.Add(address);
                            item.SubItems.Add(type);
                            listView3.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load locations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                listView3.EndUpdate();

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int productId;
            int locationId;
            if (!int.TryParse(textBox1.Text, out productId))
            {
                MessageBox.Show("Please enter a valid ProductID.");
                return;
            }
            if (!int.TryParse(textBox15.Text, out locationId))
            {
                MessageBox.Show("Please enter a valid LocationID.");
                return;
            }
            int addQuantity = (int)numericUpDown1.Value;

            int deleteQuantity = (int)numericUpDown2.Value;
            string connectionString = @"Data Source=BB21318\SQL_FALL_MATNEY;Initial Catalog=Login;User ID=user;password=matney;TrustServerCertificate=True";
            if (productId > 0)
            {
                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        if (addQuantity > 0)
                        {
                            string addQuery = "UPDATE Stock SET Quantity = Quantity + @AddQuantity WHERE ProductID = @ProductID AND LocationID = @LocationID";
                            using (var cmd = new SqlCommand(addQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@AddQuantity", addQuantity);
                                cmd.Parameters.AddWithValue("@ProductID", productId);
                                cmd.Parameters.AddWithValue("@LocationID", locationId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        if (deleteQuantity > 0)
                        {
                            string deleteQuery = "UPDATE Stock SET Quantity = Quantity - @DeleteQuantity WHERE ProductID = @ProductID AND LocationID = @LocationID AND Quantity >= @DeleteQuantity";
                            using (var cmd = new SqlCommand(deleteQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@DeleteQuantity", deleteQuantity);
                                cmd.Parameters.AddWithValue("@ProductID", productId);
                                cmd.Parameters.AddWithValue("@LocationID", locationId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    MessageBox.Show("Stock updated successfully.");
                    LoadStock();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ProductID greater than zero.");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string description = textBox3.Text;
            string category = textBox4.Text;
            decimal price;
            if (!decimal.TryParse(textBox5.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Please fill in all product details.");
                return;
            }
            string connectionString = @"Data Source=BB21318\SQL_FALL_MATNEY;Initial Catalog=Login;User ID=user;password=matney;TrustServerCertificate=True";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO Products (Name, Description, Category, UnitPrice) VALUES (@Name, @Description, @Category, @UnitPrice)";
                    using (var cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@UnitPrice", price);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Product added successfully.");
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox6.Text;
            string address = textBox7.Text;
            string type = textBox8.Text;
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Please fill in all location details.");
                return;
            }
            string connectionString = @"Data Source=BB21318\SQL_FALL_MATNEY;Initial Catalog=Login;User ID=user;password=matney;TrustServerCertificate=True";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO Locations (Name, Address, Type) VALUES (@Name, @Address, @Type)";
                    using (var cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Location added successfully.");
                LoadLocations();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add location: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int locationId;
            if (!int.TryParse(textBox9.Text, out locationId))
            {
                MessageBox.Show("Please enter a valid LocationID.");
                return;
            }
            int productId;
            //
            if (!int.TryParse(textBox10.Text, out productId))
            {
                MessageBox.Show("Please enter a valid ProductID.");
                return;
            }
            string connectionString = @"Data Source=BB21318\SQL_FALL_MATNEY;Initial Catalog=Login;User ID=user;password=matney;TrustServerCertificate=True";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO Stock (LocationID, ProductID, Quantity) VALUES (@LocationID, @ProductID, 0)";
                    using (var cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@LocationID", locationId);
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Stock entry created successfully.");
                LoadStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to create stock entry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int productId;
            if (!int.TryParse(textBox11.Text, out productId))
            {
                MessageBox.Show("Please enter a valid ProductID.");
                return;
            }
            string connectionString = @"Data Source=BB21318\SQL_FALL_MATNEY;Initial Catalog=Login;User ID=user;password=matney;TrustServerCertificate=True";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM Products WHERE ProductID = @ProductID";
                    using (var cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No product found with the specified ProductID.");
                        }
                    }
                }
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int productId;
            int locationId;
            if (!int.TryParse(textBox12.Text, out productId))
            {
                MessageBox.Show("Please enter a valid ProductID.");
                return;
            }
            if (!int.TryParse(textBox14.Text, out locationId))
            {
                MessageBox.Show("Please enter a valid LocationID.");
                return;
            }
            string connectionString = @"Data Source=BB21318\SQL_FALL_MATNEY;Initial Catalog=Login;User ID=user;password=matney;TrustServerCertificate=True";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM Stock WHERE ProductID = @ProductID AND LocationID = @LocationID";
                    using (var cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        cmd.Parameters.AddWithValue("@LocationID", locationId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stock entries deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No stock entries found with the specified ProductID and LocationID.");
                        }
                    }
                }
                LoadStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete stock entries: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int locationId;
            if (!int.TryParse(textBox13.Text, out locationId))
            {
                MessageBox.Show("Please enter a valid LocationID.");
                return;
            }
            string connectionString = @"Data Source=BB21318\SQL_FALL_MATNEY;Initial Catalog=Login;User ID=user;password=matney;TrustServerCertificate=True";
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM Locations WHERE LocationID = @LocationID";
                    using (var cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@LocationID", locationId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Location deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No location found with the specified LocationID.");
                        }
                    }
                }
                LoadLocations();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete location: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}