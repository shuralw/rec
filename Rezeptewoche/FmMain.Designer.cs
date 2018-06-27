namespace Rezeptewoche
{
    partial class FmMain
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
            this.gbAddRecipe = new System.Windows.Forms.GroupBox();
            this.cbRecipename = new System.Windows.Forms.ComboBox();
            this.lbRecipename = new System.Windows.Forms.Label();
            this.lvZutatenDesRezepts = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAddIngredientToRecipe = new System.Windows.Forms.Button();
            this.lbMeasure = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.tbIngredientName = new System.Windows.Forms.TextBox();
            this.lbZutat = new System.Windows.Forms.Label();
            this.cbMeasure = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbSelectedRecipes = new System.Windows.Forms.RichTextBox();
            this.btMixOfWeek = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLaden = new System.Windows.Forms.Button();
            this.btspeichern = new System.Windows.Forms.Button();
            this.btZeigeRezeptemix = new System.Windows.Forms.Button();
            this.gbAddRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddRecipe
            // 
            this.gbAddRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddRecipe.Controls.Add(this.cbRecipename);
            this.gbAddRecipe.Controls.Add(this.lbRecipename);
            this.gbAddRecipe.Controls.Add(this.lvZutatenDesRezepts);
            this.gbAddRecipe.Controls.Add(this.btAddIngredientToRecipe);
            this.gbAddRecipe.Controls.Add(this.lbMeasure);
            this.gbAddRecipe.Controls.Add(this.lbAmount);
            this.gbAddRecipe.Controls.Add(this.nudAmount);
            this.gbAddRecipe.Controls.Add(this.tbIngredientName);
            this.gbAddRecipe.Controls.Add(this.lbZutat);
            this.gbAddRecipe.Controls.Add(this.cbMeasure);
            this.gbAddRecipe.Location = new System.Drawing.Point(12, 12);
            this.gbAddRecipe.Name = "gbAddRecipe";
            this.gbAddRecipe.Size = new System.Drawing.Size(834, 188);
            this.gbAddRecipe.TabIndex = 0;
            this.gbAddRecipe.TabStop = false;
            this.gbAddRecipe.Text = "1. Rezept Hinzufügen";
            // 
            // cbRecipename
            // 
            this.cbRecipename.FormattingEnabled = true;
            this.cbRecipename.Location = new System.Drawing.Point(6, 38);
            this.cbRecipename.Name = "cbRecipename";
            this.cbRecipename.Size = new System.Drawing.Size(145, 21);
            this.cbRecipename.TabIndex = 0;
            this.cbRecipename.TextChanged += new System.EventHandler(this.cbRecipename_TextChanged);
            // 
            // lbRecipename
            // 
            this.lbRecipename.AutoSize = true;
            this.lbRecipename.Location = new System.Drawing.Point(6, 20);
            this.lbRecipename.Name = "lbRecipename";
            this.lbRecipename.Size = new System.Drawing.Size(67, 13);
            this.lbRecipename.TabIndex = 21;
            this.lbRecipename.Text = "Rezeptname";
            // 
            // lvZutatenDesRezepts
            // 
            this.lvZutatenDesRezepts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvZutatenDesRezepts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chAmount,
            this.chUnit});
            this.lvZutatenDesRezepts.Location = new System.Drawing.Point(6, 63);
            this.lvZutatenDesRezepts.Name = "lvZutatenDesRezepts";
            this.lvZutatenDesRezepts.Size = new System.Drawing.Size(822, 119);
            this.lvZutatenDesRezepts.TabIndex = 20;
            this.lvZutatenDesRezepts.UseCompatibleStateImageBehavior = false;
            this.lvZutatenDesRezepts.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Bezeichnung";
            // 
            // chAmount
            // 
            this.chAmount.Text = "Menge";
            // 
            // chUnit
            // 
            this.chUnit.Text = "Maßeinheit";
            // 
            // btAddIngredientToRecipe
            // 
            this.btAddIngredientToRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddIngredientToRecipe.Location = new System.Drawing.Point(512, 19);
            this.btAddIngredientToRecipe.Name = "btAddIngredientToRecipe";
            this.btAddIngredientToRecipe.Size = new System.Drawing.Size(316, 40);
            this.btAddIngredientToRecipe.TabIndex = 4;
            this.btAddIngredientToRecipe.Text = "Zutat dem Rezept Hinzufügen";
            this.btAddIngredientToRecipe.UseVisualStyleBackColor = true;
            this.btAddIngredientToRecipe.Click += new System.EventHandler(this.btRecipeSubmission_Click);
            // 
            // lbMeasure
            // 
            this.lbMeasure.AutoSize = true;
            this.lbMeasure.Location = new System.Drawing.Point(409, 18);
            this.lbMeasure.Name = "lbMeasure";
            this.lbMeasure.Size = new System.Drawing.Size(39, 13);
            this.lbMeasure.TabIndex = 17;
            this.lbMeasure.Text = "Einheit";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(339, 18);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(40, 13);
            this.lbAmount.TabIndex = 16;
            this.lbAmount.Text = "Menge";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(342, 38);
            this.nudAmount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(64, 20);
            this.nudAmount.TabIndex = 2;
            // 
            // tbIngredientName
            // 
            this.tbIngredientName.Location = new System.Drawing.Point(154, 38);
            this.tbIngredientName.Name = "tbIngredientName";
            this.tbIngredientName.Size = new System.Drawing.Size(181, 20);
            this.tbIngredientName.TabIndex = 1;
            // 
            // lbZutat
            // 
            this.lbZutat.AutoSize = true;
            this.lbZutat.Location = new System.Drawing.Point(151, 22);
            this.lbZutat.Name = "lbZutat";
            this.lbZutat.Size = new System.Drawing.Size(32, 13);
            this.lbZutat.TabIndex = 13;
            this.lbZutat.Text = "Zutat";
            // 
            // cbMeasure
            // 
            this.cbMeasure.FormattingEnabled = true;
            this.cbMeasure.Items.AddRange(new object[] {
            "mg ",
            "g",
            "kg",
            "ml",
            "l",
            "TL",
            "EL",
            "Prise",
            "Tropfen",
            "Stk"});
            this.cbMeasure.Location = new System.Drawing.Point(412, 37);
            this.cbMeasure.Name = "cbMeasure";
            this.cbMeasure.Size = new System.Drawing.Size(95, 21);
            this.cbMeasure.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rtbSelectedRecipes);
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 201);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Einkaufsliste";
            // 
            // rtbSelectedRecipes
            // 
            this.rtbSelectedRecipes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSelectedRecipes.Location = new System.Drawing.Point(6, 18);
            this.rtbSelectedRecipes.Name = "rtbSelectedRecipes";
            this.rtbSelectedRecipes.Size = new System.Drawing.Size(822, 177);
            this.rtbSelectedRecipes.TabIndex = 0;
            this.rtbSelectedRecipes.Text = "";
            // 
            // btMixOfWeek
            // 
            this.btMixOfWeek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btMixOfWeek.Location = new System.Drawing.Point(12, 206);
            this.btMixOfWeek.Name = "btMixOfWeek";
            this.btMixOfWeek.Size = new System.Drawing.Size(834, 32);
            this.btMixOfWeek.TabIndex = 1;
            this.btMixOfWeek.Text = "2. Zur Einkaufsliste Hinzufügen";
            this.btMixOfWeek.UseVisualStyleBackColor = true;
            this.btMixOfWeek.Click += new System.EventHandler(this.RezeptZumEinkaufszettelHinzufügen);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btZeigeRezeptemix);
            this.groupBox1.Controls.Add(this.btLaden);
            this.groupBox1.Controls.Add(this.btspeichern);
            this.groupBox1.Location = new System.Drawing.Point(12, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 64);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "3. Speichern";
            // 
            // btLaden
            // 
            this.btLaden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLaden.Location = new System.Drawing.Point(290, 27);
            this.btLaden.Name = "btLaden";
            this.btLaden.Size = new System.Drawing.Size(260, 23);
            this.btLaden.TabIndex = 6;
            this.btLaden.Text = "Laden";
            this.btLaden.UseVisualStyleBackColor = true;
            this.btLaden.Click += new System.EventHandler(this.btLaden_Click);
            // 
            // btspeichern
            // 
            this.btspeichern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btspeichern.Location = new System.Drawing.Point(9, 27);
            this.btspeichern.Name = "btspeichern";
            this.btspeichern.Size = new System.Drawing.Size(272, 23);
            this.btspeichern.TabIndex = 5;
            this.btspeichern.Text = "Speichern";
            this.btspeichern.UseVisualStyleBackColor = true;
            this.btspeichern.Click += new System.EventHandler(this.btspeichern_Click);
            // 
            // btZeigeRezeptemix
            // 
            this.btZeigeRezeptemix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btZeigeRezeptemix.Location = new System.Drawing.Point(559, 27);
            this.btZeigeRezeptemix.Name = "btZeigeRezeptemix";
            this.btZeigeRezeptemix.Size = new System.Drawing.Size(260, 23);
            this.btZeigeRezeptemix.TabIndex = 7;
            this.btZeigeRezeptemix.Text = "Rezeptemix anzeigen";
            this.btZeigeRezeptemix.UseVisualStyleBackColor = true;
            this.btZeigeRezeptemix.Click += new System.EventHandler(this.btZeigeRezeptemix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btMixOfWeek);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbAddRecipe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAddRecipe.ResumeLayout(false);
            this.gbAddRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAddRecipe;
        private System.Windows.Forms.Button btAddIngredientToRecipe;
        private System.Windows.Forms.Label lbMeasure;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.TextBox tbIngredientName;
        private System.Windows.Forms.Label lbZutat;
        private System.Windows.Forms.ComboBox cbMeasure;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbSelectedRecipes;
        private System.Windows.Forms.Button btMixOfWeek;
        private System.Windows.Forms.ListView lvZutatenDesRezepts;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chAmount;
        private System.Windows.Forms.ColumnHeader chUnit;
        private System.Windows.Forms.Label lbRecipename;
        private System.Windows.Forms.ComboBox cbRecipename;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btLaden;
        private System.Windows.Forms.Button btspeichern;
        private System.Windows.Forms.Button btZeigeRezeptemix;
    }
}

