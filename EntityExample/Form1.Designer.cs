namespace EntityExample
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
            this.BtnStudentList = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPhoto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtStudentSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtStudentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtLectureName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtLectureID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnJoin = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TxtSituation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtExam3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtExam2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtExam1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnLectureList = new System.Windows.Forms.Button();
            this.BtnNoteList = new System.Windows.Forms.Button();
            this.BtnProcedure = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BtnLinqEntity = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(629, 112);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnStudentList
            // 
            this.BtnStudentList.Location = new System.Drawing.Point(11, 114);
            this.BtnStudentList.Margin = new System.Windows.Forms.Padding(2);
            this.BtnStudentList.Name = "BtnStudentList";
            this.BtnStudentList.Size = new System.Drawing.Size(138, 31);
            this.BtnStudentList.TabIndex = 1;
            this.BtnStudentList.Text = "Student List";
            this.BtnStudentList.UseVisualStyleBackColor = true;
            this.BtnStudentList.Click += new System.EventHandler(this.BtnStudentList_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(11, 184);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(138, 32);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(11, 220);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(138, 31);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(11, 149);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(138, 31);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(11, 256);
            this.BtnFind.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(138, 31);
            this.BtnFind.TabIndex = 7;
            this.BtnFind.Text = "Find";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtPhoto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtStudentSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtStudentName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtStudentID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(154, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 146);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // TxtPhoto
            // 
            this.TxtPhoto.Location = new System.Drawing.Point(106, 106);
            this.TxtPhoto.Name = "TxtPhoto";
            this.TxtPhoto.Size = new System.Drawing.Size(100, 24);
            this.TxtPhoto.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "PHOTO:";
            // 
            // TxtStudentSurname
            // 
            this.TxtStudentSurname.Location = new System.Drawing.Point(106, 77);
            this.TxtStudentSurname.Name = "TxtStudentSurname";
            this.TxtStudentSurname.Size = new System.Drawing.Size(100, 24);
            this.TxtStudentSurname.TabIndex = 21;
            this.TxtStudentSurname.TextChanged += new System.EventHandler(this.TxtStudentSurname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "SURNAME:";
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.Location = new System.Drawing.Point(106, 48);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(100, 24);
            this.TxtStudentName.TabIndex = 19;
            this.TxtStudentName.TextChanged += new System.EventHandler(this.TxtStudentName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "NAME:";
            // 
            // TxtStudentID
            // 
            this.TxtStudentID.Location = new System.Drawing.Point(106, 18);
            this.TxtStudentID.Name = "TxtStudentID";
            this.TxtStudentID.Size = new System.Drawing.Size(100, 24);
            this.TxtStudentID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtLectureName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtLectureID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(154, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 117);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lectures";
            // 
            // TxtLectureName
            // 
            this.TxtLectureName.Location = new System.Drawing.Point(106, 48);
            this.TxtLectureName.Name = "TxtLectureName";
            this.TxtLectureName.Size = new System.Drawing.Size(100, 24);
            this.TxtLectureName.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "NAME:";
            // 
            // TxtLectureID
            // 
            this.TxtLectureID.Location = new System.Drawing.Point(106, 18);
            this.TxtLectureID.Name = "TxtLectureID";
            this.TxtLectureID.Size = new System.Drawing.Size(100, 24);
            this.TxtLectureID.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnJoin);
            this.groupBox3.Controls.Add(this.BtnCalculate);
            this.groupBox3.Controls.Add(this.TxtSituation);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TxtAverage);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtExam3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtExam2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtExam1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(401, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 269);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notes";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // BtnJoin
            // 
            this.BtnJoin.Location = new System.Drawing.Point(69, 204);
            this.BtnJoin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnJoin.Name = "BtnJoin";
            this.BtnJoin.Size = new System.Drawing.Size(138, 25);
            this.BtnJoin.TabIndex = 28;
            this.BtnJoin.Text = "Use Join";
            this.BtnJoin.UseVisualStyleBackColor = true;
            this.BtnJoin.Click += new System.EventHandler(this.BtnJoin_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(69, 175);
            this.BtnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(138, 25);
            this.BtnCalculate.TabIndex = 27;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            // 
            // TxtSituation
            // 
            this.TxtSituation.Location = new System.Drawing.Point(107, 137);
            this.TxtSituation.Name = "TxtSituation";
            this.TxtSituation.Size = new System.Drawing.Size(100, 24);
            this.TxtSituation.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "SITUATION:";
            // 
            // TxtAverage
            // 
            this.TxtAverage.Location = new System.Drawing.Point(106, 106);
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.Size = new System.Drawing.Size(100, 24);
            this.TxtAverage.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "AVERAGE:";
            // 
            // TxtExam3
            // 
            this.TxtExam3.Location = new System.Drawing.Point(106, 77);
            this.TxtExam3.Name = "TxtExam3";
            this.TxtExam3.Size = new System.Drawing.Size(100, 24);
            this.TxtExam3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "EXAM3:";
            // 
            // TxtExam2
            // 
            this.TxtExam2.Location = new System.Drawing.Point(106, 48);
            this.TxtExam2.Name = "TxtExam2";
            this.TxtExam2.Size = new System.Drawing.Size(100, 24);
            this.TxtExam2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "EXAM2:";
            // 
            // TxtExam1
            // 
            this.TxtExam1.Location = new System.Drawing.Point(106, 18);
            this.TxtExam1.Name = "TxtExam1";
            this.TxtExam1.Size = new System.Drawing.Size(100, 24);
            this.TxtExam1.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "EXAM1:";
            // 
            // BtnLectureList
            // 
            this.BtnLectureList.Location = new System.Drawing.Point(11, 290);
            this.BtnLectureList.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLectureList.Name = "BtnLectureList";
            this.BtnLectureList.Size = new System.Drawing.Size(138, 31);
            this.BtnLectureList.TabIndex = 25;
            this.BtnLectureList.Text = "Lecture List";
            this.BtnLectureList.UseVisualStyleBackColor = true;
            this.BtnLectureList.Click += new System.EventHandler(this.BtnLectureList_Click);
            // 
            // BtnNoteList
            // 
            this.BtnNoteList.Location = new System.Drawing.Point(11, 325);
            this.BtnNoteList.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNoteList.Name = "BtnNoteList";
            this.BtnNoteList.Size = new System.Drawing.Size(138, 31);
            this.BtnNoteList.TabIndex = 26;
            this.BtnNoteList.Text = "Note List";
            this.BtnNoteList.UseVisualStyleBackColor = true;
            this.BtnNoteList.Click += new System.EventHandler(this.BtnNoteList_Click);
            // 
            // BtnProcedure
            // 
            this.BtnProcedure.Location = new System.Drawing.Point(11, 360);
            this.BtnProcedure.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProcedure.Name = "BtnProcedure";
            this.BtnProcedure.Size = new System.Drawing.Size(138, 31);
            this.BtnProcedure.TabIndex = 27;
            this.BtnProcedure.Text = "Procedure";
            this.BtnProcedure.UseVisualStyleBackColor = true;
            this.BtnProcedure.Click += new System.EventHandler(this.BtnProcedure_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(683, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(168, 22);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sort by Name (A-->Z)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BtnLinqEntity
            // 
            this.BtnLinqEntity.Location = new System.Drawing.Point(684, 356);
            this.BtnLinqEntity.Name = "BtnLinqEntity";
            this.BtnLinqEntity.Size = new System.Drawing.Size(116, 31);
            this.BtnLinqEntity.TabIndex = 29;
            this.BtnLinqEntity.Text = "Linq Entity";
            this.BtnLinqEntity.UseVisualStyleBackColor = true;
            this.BtnLinqEntity.Click += new System.EventHandler(this.BtnLinqEntity_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(683, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(168, 22);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sort by Name (Z-->A)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(683, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(128, 22);
            this.radioButton3.TabIndex = 31;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "First 3 Records";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(684, 96);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(97, 22);
            this.radioButton4.TabIndex = 32;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Data for ID";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(684, 124);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(181, 22);
            this.radioButton5.TabIndex = 33;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Names Starting with \"A\"";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(683, 152);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(176, 22);
            this.radioButton6.TabIndex = 34;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Names Ending with \"A\"";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(684, 180);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(114, 22);
            this.radioButton7.TabIndex = 35;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Empty or Not";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(686, 209);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(113, 22);
            this.radioButton8.TabIndex = 36;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Total Student";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(686, 238);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(153, 22);
            this.radioButton9.TabIndex = 37;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Exam1 Total Score";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(686, 267);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(146, 22);
            this.radioButton10.TabIndex = 38;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Average of Exam1";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(686, 294);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(185, 22);
            this.radioButton11.TabIndex = 39;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Highest Score in Exam1";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(687, 325);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(183, 22);
            this.radioButton12.TabIndex = 40;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Lowest Score in Exam1";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 489);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.BtnLinqEntity);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnProcedure);
            this.Controls.Add(this.BtnNoteList);
            this.Controls.Add(this.BtnLectureList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnStudentList);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnStudentList;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtStudentSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtStudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtLectureName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtLectureID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtSituation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtAverage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtExam3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtExam2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtExam1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnLectureList;
        private System.Windows.Forms.Button BtnNoteList;
        private System.Windows.Forms.Button BtnJoin;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnProcedure;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button BtnLinqEntity;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
    }
}

