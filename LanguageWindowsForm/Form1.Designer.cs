namespace LanguageWindowsForm
{
    partial class MainMenuForm
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
            this.BoxListNames = new System.Windows.Forms.ListBox();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.ButtonAddLanguage = new System.Windows.Forms.Button();
            this.LabelNewLangueage = new System.Windows.Forms.Label();
            this.NewLanguageBox = new System.Windows.Forms.TextBox();
            this.LabelNumOfWords = new System.Windows.Forms.Label();
            this.ActualNumWordsLabel = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ListLabTab = new System.Windows.Forms.TabPage();
            this.ButtonRemoveRow = new System.Windows.Forms.Button();
            this.NamePrecedesLanguageLabel = new System.Windows.Forms.Label();
            this.PracticeTab = new System.Windows.Forms.TabPage();
            this.NoWordsLabel = new System.Windows.Forms.Label();
            this.SessionInfoLabel = new System.Windows.Forms.Label();
            this.CorrectOrNotLabel = new System.Windows.Forms.Label();
            this.TranslateThisLabel = new System.Windows.Forms.Label();
            this.UserTranslationBox = new System.Windows.Forms.TextBox();
            this.TranslateFromXToYLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.NoPeekingLabel = new System.Windows.Forms.Label();
            this.PracticeLabel = new System.Windows.Forms.Label();
            this.NoPeekingLabelTimer = new System.Windows.Forms.Timer(this.components);
            this.CorrectOrNotTimer = new System.Windows.Forms.Timer(this.components);
            this.NamePrecedesLanguageTimer = new System.Windows.Forms.Timer(this.components);
            this.NoWordsTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.TabControl.SuspendLayout();
            this.ListLabTab.SuspendLayout();
            this.PracticeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxListNames
            // 
            this.BoxListNames.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxListNames.ForeColor = System.Drawing.Color.Gray;
            this.BoxListNames.FormattingEnabled = true;
            this.BoxListNames.ItemHeight = 16;
            this.BoxListNames.Location = new System.Drawing.Point(32, 49);
            this.BoxListNames.Margin = new System.Windows.Forms.Padding(2);
            this.BoxListNames.Name = "BoxListNames";
            this.BoxListNames.Size = new System.Drawing.Size(102, 196);
            this.BoxListNames.TabIndex = 0;
            this.BoxListNames.SelectedIndexChanged += new System.EventHandler(this.ListNamesBox_SelectedIndexChanged);
            // 
            // ButtonNew
            // 
            this.ButtonNew.Location = new System.Drawing.Point(138, 49);
            this.ButtonNew.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(68, 21);
            this.ButtonNew.TabIndex = 1;
            this.ButtonNew.Text = "New";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(138, 99);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(68, 21);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(138, 74);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(68, 21);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(327, 260);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(76, 21);
            this.NameBox.TabIndex = 5;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(272, 263);
            this.LabelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(39, 14);
            this.LabelName.TabIndex = 6;
            this.LabelName.Text = "Name:";
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.Color.White;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.GridColor = System.Drawing.Color.Gray;
            this.GridView.Location = new System.Drawing.Point(210, 50);
            this.GridView.Margin = new System.Windows.Forms.Padding(2);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 51;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.Size = new System.Drawing.Size(410, 195);
            this.GridView.TabIndex = 8;
            this.GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellContentClick);
            // 
            // ButtonAddLanguage
            // 
            this.ButtonAddLanguage.Location = new System.Drawing.Point(413, 289);
            this.ButtonAddLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAddLanguage.Name = "ButtonAddLanguage";
            this.ButtonAddLanguage.Size = new System.Drawing.Size(68, 21);
            this.ButtonAddLanguage.TabIndex = 9;
            this.ButtonAddLanguage.Text = "Add";
            this.ButtonAddLanguage.UseVisualStyleBackColor = true;
            this.ButtonAddLanguage.Click += new System.EventHandler(this.AddLanguageButton_Click);
            // 
            // LabelNewLangueage
            // 
            this.LabelNewLangueage.AutoSize = true;
            this.LabelNewLangueage.Location = new System.Drawing.Point(226, 293);
            this.LabelNewLangueage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelNewLangueage.Name = "LabelNewLangueage";
            this.LabelNewLangueage.Size = new System.Drawing.Size(85, 14);
            this.LabelNewLangueage.TabIndex = 10;
            this.LabelNewLangueage.Text = "New language:";
            // 
            // NewLanguageBox
            // 
            this.NewLanguageBox.Location = new System.Drawing.Point(327, 290);
            this.NewLanguageBox.Margin = new System.Windows.Forms.Padding(2);
            this.NewLanguageBox.Name = "NewLanguageBox";
            this.NewLanguageBox.Size = new System.Drawing.Size(76, 21);
            this.NewLanguageBox.TabIndex = 11;
            this.NewLanguageBox.TextChanged += new System.EventHandler(this.NewLanguageBox_TextChanged);
            // 
            // LabelNumOfWords
            // 
            this.LabelNumOfWords.AutoSize = true;
            this.LabelNumOfWords.Location = new System.Drawing.Point(320, 21);
            this.LabelNumOfWords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelNumOfWords.Name = "LabelNumOfWords";
            this.LabelNumOfWords.Size = new System.Drawing.Size(100, 14);
            this.LabelNumOfWords.TabIndex = 12;
            this.LabelNumOfWords.Text = "Number of words:";
            // 
            // ActualNumWordsLabel
            // 
            this.ActualNumWordsLabel.AutoSize = true;
            this.ActualNumWordsLabel.Location = new System.Drawing.Point(410, 21);
            this.ActualNumWordsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActualNumWordsLabel.Name = "ActualNumWordsLabel";
            this.ActualNumWordsLabel.Size = new System.Drawing.Size(10, 14);
            this.ActualNumWordsLabel.TabIndex = 13;
            this.ActualNumWordsLabel.Text = " ";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Enabled = false;
            this.ButtonStart.Location = new System.Drawing.Point(283, 48);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(68, 25);
            this.ButtonStart.TabIndex = 14;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.PracticeButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ListLabTab);
            this.TabControl.Controls.Add(this.PracticeTab);
            this.TabControl.Location = new System.Drawing.Point(0, 11);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(668, 393);
            this.TabControl.TabIndex = 15;
            this.TabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl_Selecting);
            // 
            // ListLabTab
            // 
            this.ListLabTab.BackColor = System.Drawing.Color.Transparent;
            this.ListLabTab.Controls.Add(this.ButtonRemoveRow);
            this.ListLabTab.Controls.Add(this.NamePrecedesLanguageLabel);
            this.ListLabTab.Controls.Add(this.BoxListNames);
            this.ListLabTab.Controls.Add(this.GridView);
            this.ListLabTab.Controls.Add(this.NameBox);
            this.ListLabTab.Controls.Add(this.NewLanguageBox);
            this.ListLabTab.Controls.Add(this.ButtonNew);
            this.ListLabTab.Controls.Add(this.LabelNewLangueage);
            this.ListLabTab.Controls.Add(this.ButtonDelete);
            this.ListLabTab.Controls.Add(this.ActualNumWordsLabel);
            this.ListLabTab.Controls.Add(this.LabelName);
            this.ListLabTab.Controls.Add(this.LabelNumOfWords);
            this.ListLabTab.Controls.Add(this.ButtonSave);
            this.ListLabTab.Controls.Add(this.ButtonAddLanguage);
            this.ListLabTab.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListLabTab.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ListLabTab.Location = new System.Drawing.Point(4, 22);
            this.ListLabTab.Margin = new System.Windows.Forms.Padding(2);
            this.ListLabTab.Name = "ListLabTab";
            this.ListLabTab.Padding = new System.Windows.Forms.Padding(2);
            this.ListLabTab.Size = new System.Drawing.Size(660, 367);
            this.ListLabTab.TabIndex = 0;
            this.ListLabTab.Text = "ListLab";
            // 
            // ButtonRemoveRow
            // 
            this.ButtonRemoveRow.Location = new System.Drawing.Point(534, 19);
            this.ButtonRemoveRow.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonRemoveRow.Name = "ButtonRemoveRow";
            this.ButtonRemoveRow.Size = new System.Drawing.Size(86, 20);
            this.ButtonRemoveRow.TabIndex = 16;
            this.ButtonRemoveRow.Text = "Remove row";
            this.ButtonRemoveRow.UseVisualStyleBackColor = true;
            this.ButtonRemoveRow.Click += new System.EventHandler(this.RemoveWordButton_Click);
            // 
            // NamePrecedesLanguageLabel
            // 
            this.NamePrecedesLanguageLabel.AutoSize = true;
            this.NamePrecedesLanguageLabel.BackColor = System.Drawing.Color.White;
            this.NamePrecedesLanguageLabel.Location = new System.Drawing.Point(272, 154);
            this.NamePrecedesLanguageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NamePrecedesLanguageLabel.Name = "NamePrecedesLanguageLabel";
            this.NamePrecedesLanguageLabel.Size = new System.Drawing.Size(246, 14);
            this.NamePrecedesLanguageLabel.TabIndex = 14;
            this.NamePrecedesLanguageLabel.Text = "Please enter a name before adding languages!";
            this.NamePrecedesLanguageLabel.Visible = false;
            // 
            // PracticeTab
            // 
            this.PracticeTab.BackColor = System.Drawing.Color.Transparent;
            this.PracticeTab.Controls.Add(this.NoWordsLabel);
            this.PracticeTab.Controls.Add(this.SessionInfoLabel);
            this.PracticeTab.Controls.Add(this.CorrectOrNotLabel);
            this.PracticeTab.Controls.Add(this.TranslateThisLabel);
            this.PracticeTab.Controls.Add(this.UserTranslationBox);
            this.PracticeTab.Controls.Add(this.TranslateFromXToYLabel);
            this.PracticeTab.Controls.Add(this.NextButton);
            this.PracticeTab.Controls.Add(this.NoPeekingLabel);
            this.PracticeTab.Controls.Add(this.PracticeLabel);
            this.PracticeTab.Controls.Add(this.ButtonStart);
            this.PracticeTab.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PracticeTab.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PracticeTab.Location = new System.Drawing.Point(4, 22);
            this.PracticeTab.Margin = new System.Windows.Forms.Padding(2);
            this.PracticeTab.Name = "PracticeTab";
            this.PracticeTab.Padding = new System.Windows.Forms.Padding(2);
            this.PracticeTab.Size = new System.Drawing.Size(660, 367);
            this.PracticeTab.TabIndex = 1;
            this.PracticeTab.Text = "Practice";
            // 
            // NoWordsLabel
            // 
            this.NoWordsLabel.AutoSize = true;
            this.NoWordsLabel.Location = new System.Drawing.Point(246, 123);
            this.NoWordsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoWordsLabel.Name = "NoWordsLabel";
            this.NoWordsLabel.Size = new System.Drawing.Size(108, 14);
            this.NoWordsLabel.TabIndex = 25;
            this.NoWordsLabel.Text = "Contains no words.";
            this.NoWordsLabel.Visible = false;
            // 
            // SessionInfoLabel
            // 
            this.SessionInfoLabel.AutoSize = true;
            this.SessionInfoLabel.Location = new System.Drawing.Point(269, 168);
            this.SessionInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SessionInfoLabel.Name = "SessionInfoLabel";
            this.SessionInfoLabel.Size = new System.Drawing.Size(82, 14);
            this.SessionInfoLabel.TabIndex = 23;
            this.SessionInfoLabel.Text = "<sessionInfo>";
            this.SessionInfoLabel.Visible = false;
            // 
            // CorrectOrNotLabel
            // 
            this.CorrectOrNotLabel.AutoSize = true;
            this.CorrectOrNotLabel.Location = new System.Drawing.Point(246, 295);
            this.CorrectOrNotLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CorrectOrNotLabel.Name = "CorrectOrNotLabel";
            this.CorrectOrNotLabel.Size = new System.Drawing.Size(109, 14);
            this.CorrectOrNotLabel.TabIndex = 22;
            this.CorrectOrNotLabel.Text = "Correct or Incorrect!";
            this.CorrectOrNotLabel.Visible = false;
            // 
            // TranslateThisLabel
            // 
            this.TranslateThisLabel.AutoSize = true;
            this.TranslateThisLabel.Location = new System.Drawing.Point(212, 235);
            this.TranslateThisLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TranslateThisLabel.Name = "TranslateThisLabel";
            this.TranslateThisLabel.Size = new System.Drawing.Size(50, 14);
            this.TranslateThisLabel.TabIndex = 21;
            this.TranslateThisLabel.Text = "<word>";
            this.TranslateThisLabel.Visible = false;
            // 
            // UserTranslationBox
            // 
            this.UserTranslationBox.Location = new System.Drawing.Point(283, 232);
            this.UserTranslationBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserTranslationBox.Name = "UserTranslationBox";
            this.UserTranslationBox.Size = new System.Drawing.Size(100, 21);
            this.UserTranslationBox.TabIndex = 20;
            this.UserTranslationBox.Visible = false;
            this.UserTranslationBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserTranslationBox_KeyPress);
            // 
            // TranslateFromXToYLabel
            // 
            this.TranslateFromXToYLabel.AutoSize = true;
            this.TranslateFromXToYLabel.Location = new System.Drawing.Point(21, 235);
            this.TranslateFromXToYLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TranslateFromXToYLabel.Name = "TranslateFromXToYLabel";
            this.TranslateFromXToYLabel.Size = new System.Drawing.Size(117, 14);
            this.TranslateFromXToYLabel.TabIndex = 19;
            this.TranslateFromXToYLabel.Text = "Language translation";
            this.TranslateFromXToYLabel.Visible = false;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(403, 235);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(56, 19);
            this.NextButton.TabIndex = 18;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Visible = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // NoPeekingLabel
            // 
            this.NoPeekingLabel.Location = new System.Drawing.Point(0, 0);
            this.NoPeekingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoPeekingLabel.Name = "NoPeekingLabel";
            this.NoPeekingLabel.Size = new System.Drawing.Size(75, 19);
            this.NoPeekingLabel.TabIndex = 26;
            // 
            // PracticeLabel
            // 
            this.PracticeLabel.AutoSize = true;
            this.PracticeLabel.Location = new System.Drawing.Point(233, 78);
            this.PracticeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PracticeLabel.Name = "PracticeLabel";
            this.PracticeLabel.Padding = new System.Windows.Forms.Padding(38, 0, 38, 0);
            this.PracticeLabel.Size = new System.Drawing.Size(191, 14);
            this.PracticeLabel.TabIndex = 16;
            this.PracticeLabel.Text = "No wordlist selected.";
            this.PracticeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CorrectOrNotTimer
            // 
            this.CorrectOrNotTimer.Interval = 4000;
            this.CorrectOrNotTimer.Tick += new System.EventHandler(this.CorrectOrNotTimer_Tick);
            // 
            // NamePrecedesLanguageTimer
            // 
            this.NamePrecedesLanguageTimer.Interval = 4000;
            this.NamePrecedesLanguageTimer.Tick += new System.EventHandler(this.NamePrecedesLanguageTimer_Tick);
            // 
            // NoWordsTimer
            // 
            this.NoWordsTimer.Interval = 4000;
            this.NoWordsTimer.Tick += new System.EventHandler(this.NoWordsTimer_Tick);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 405);
            this.Controls.Add(this.TabControl);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "LanguagePractice";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.ListLabTab.ResumeLayout(false);
            this.ListLabTab.PerformLayout();
            this.PracticeTab.ResumeLayout(false);
            this.PracticeTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BoxListNames;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button ButtonAddLanguage;
        private System.Windows.Forms.Label LabelNewLangueage;
        private System.Windows.Forms.TextBox NewLanguageBox;
        private System.Windows.Forms.Label LabelNumOfWords;
        private System.Windows.Forms.Label ActualNumWordsLabel;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ListLabTab;
        private System.Windows.Forms.TabPage PracticeTab;
        private System.Windows.Forms.Label PracticeLabel;
        private System.Windows.Forms.Label NoPeekingLabel;
        private System.Windows.Forms.Timer NoPeekingLabelTimer;
        private System.Windows.Forms.TextBox UserTranslationBox;
        private System.Windows.Forms.Label TranslateFromXToYLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label TranslateThisLabel;
        private System.Windows.Forms.Label CorrectOrNotLabel;
        private System.Windows.Forms.Timer CorrectOrNotTimer;
        private System.Windows.Forms.Label SessionInfoLabel;
        private System.Windows.Forms.Label NamePrecedesLanguageLabel;
        private System.Windows.Forms.Timer NamePrecedesLanguageTimer;
        private System.Windows.Forms.Button ButtonRemoveRow;
        private System.Windows.Forms.Label NoWordsLabel;
        private System.Windows.Forms.Timer NoWordsTimer;
    }
}
