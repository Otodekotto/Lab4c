using LanguageLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Windows.Forms;

namespace LanguageWindowsForm
{
    public partial class MainMenuForm : Form
    {
        private static bool PracticeMode;
        private static ScoreBoard latestSession;
        private string CorrectTranslation;

        public MainMenuForm()
        {
            InitializeComponent();
            WordListFolder.CreateMap();
            ListNamesBoxClear();
        }
        private void ListNamesBoxClear()
        {
            BoxListNames.Items.Clear();
            BoxListNames.Items.AddRange(WordList.GetLists());
        }

        private void NumberOfWords()
        {
            if ((GridView.Rows.Count - 1) <= 0)
            {
                ActualNumWordsLabel.Text = "0";
            }
            else
            {
                ActualNumWordsLabel.Text = (GridView.Rows.Count - 1).ToString();
            }
        }
        private void GridClear()
        {
            GridView.Rows.Clear();
            GridView.Columns.Clear();
            NameBox.Text = null;
        }

        private void RefreshPracticeLabel()
        {
            if (BoxListNames.SelectedItem != null)
            {
                PracticeLabel.Text = $"Selected list: {BoxListNames.SelectedItem}";
                return;
            }
            PracticeLabel.Text = "No wordlist selected.";
        }

        private void PracticeModeAppearance()
        {
            TranslateFromXToYLabel.Visible = PracticeMode;
            TranslateThisLabel.Visible = PracticeMode;
            UserTranslationBox.Visible = PracticeMode;
            NextButton.Visible = PracticeMode;

            if (PracticeMode)
            {
                ButtonStart.Text = "Stop";
            }
            else
            {
                ButtonStart.Text = "Start";
            }
        }

        private void Practice()
        {
            if (PracticeMode)
            {
                PracticeModeAppearance();

                WordList listToPractice = WordList.LoadList(BoxListNames.Text);
                Word wordOfPractice = listToPractice.GetWordToPractice();
                string fromLanguage = listToPractice.Languages[wordOfPractice.FromLanguage];
                string toLanguage = listToPractice.Languages[wordOfPractice.ToLanguage];

                CorrectTranslation = wordOfPractice.Translations[wordOfPractice.ToLanguage];

                TranslateFromXToYLabel.Text = $"Translate from {fromLanguage} to {toLanguage}:";
                TranslateThisLabel.Text = wordOfPractice.Translations[wordOfPractice.FromLanguage];
            }
        }

        private void CorrectOrNot(bool correctOrNot)
        {
            if (correctOrNot)
            {
                CorrectOrNotLabel.Text = "Congratulations! The answer is correct!";
                latestSession.Score++;
            }
            else
            {
                CorrectOrNotLabel.Text = "Sorry, The answer is incorrect";
            }
            CorrectOrNotLabel.Visible = true;
            CorrectOrNotTimer.Enabled = true;
            UserTranslationBox.Text = null;
        }

        private void SessionInfo()
        {
            if (PracticeMode)
            {
                SessionInfoLabel.Visible = true;
                SessionInfoLabel.Text = $"Words practiced: {latestSession.PracticedWords}";
            }
            else if (!PracticeMode && latestSession != null)
            {
                string p = Environment.NewLine;
                SessionInfoLabel.Visible = true;
                SessionInfoLabel.Text = $"List: {latestSession.Name} {p}Words practiced: {latestSession.PracticedWords} {p}Score: {latestSession.Score}";
            }
        }

        private void ContinuePractice()
        {
            latestSession.PracticedWords++;
            CorrectOrNot(UserTranslationBox.Text.ToLower() == CorrectTranslation.ToLower());
            SessionInfo();
            Practice();
        }

        private bool IsRowEmpty(DataGridViewRow row)
        {
            foreach (DataGridViewTextBoxCell cell in row.Cells)
            {
                if (!string.IsNullOrEmpty(cell.Value?.ToString()))
                {
                    return false;
                }
            }
            return true;
        }


        private void NewButton_Click(object sender, EventArgs e)
        {
            GridClear();
            NumberOfWords();
            BoxListNames.SelectedItem = null;
            ButtonStart.Enabled = false;
        }



        private void ListNamesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BoxListNames.SelectedItem != null)
            {
                GridClear();
                ButtonStart.Enabled = true;

                NameBox.Text = BoxListNames.SelectedItem.ToString();

                WordList selectedWList = WordList.LoadList(NameBox.Text);

                foreach (string language in selectedWList.Languages)
                {
                    GridView.Columns.Add(language, language);
                }

                List<string[]> words = new List<string[]>();
                selectedWList.List(0, t => words.Add(t));

                foreach (string[] translations in words)
                {
                    GridView.Rows.Add(translations);
                }

                NumberOfWords();
                RefreshPracticeLabel();
            }
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            List<string> languages = new List<string>();
            foreach (DataGridViewTextBoxColumn column in GridView.Columns)
            {
                languages.Add(column.HeaderText);
            }

            if (languages.Count < 2)
            {
                MessageBox.Show("Could not save list. The list must have at least two languages.");
                return;
            }

            WordList currentList = new WordList(NameBox.Text, languages.ToArray());
            List<string> translations = new List<string>();

            foreach (DataGridViewRow row in GridView.Rows)
            {
                if (IsRowEmpty(row))
                {
                    continue;
                }

                foreach (DataGridViewTextBoxCell cell in row.Cells)
                {
                    translations.Add(cell.Value?.ToString() ?? "");
                }

                if (translations.Any(t => String.IsNullOrWhiteSpace(t)))
                {
                    string n = Environment.NewLine;
                    MessageBox.Show($"Could not save list.{n + n}Symmetry required between number of translations and number of languages.");
                    return;
                }
                currentList.Add(translations.ToArray());
                translations.Clear();
            }
            currentList.Save();
            ListNamesBoxClear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (BoxListNames.SelectedItem != null)
            {
                DialogResult yesOrNo = MessageBox.Show("Are you sure you want to delete this list?", "Delete wordlist", MessageBoxButtons.YesNo);
                if (yesOrNo == DialogResult.Yes)
                {
                    File.Delete(WordListFolder.GetFilePath(BoxListNames.SelectedItem.ToString()));
                    ListNamesBoxClear();
                    GridClear();
                    RefreshPracticeLabel();
                }
            }
        }

        private void AddLanguageButton_Click(object sender, EventArgs e)
        {
            if (NewLanguageBox.Text != "")
            {
                if (NameBox.Text == "")
                {
                    NamePrecedesLanguageLabel.Visible = true;
                    NamePrecedesLanguageTimer.Enabled = true;
                    return;
                }
                GridView.Columns.Add(NewLanguageBox.Text, NewLanguageBox.Text);
                NewLanguageBox.Text = "";
            }
        }

        private void RemoveWordButton_Click(object sender, EventArgs e)
        {
            var rowsToRemove = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in GridView.SelectedRows)
            {
                if (!IsRowEmpty(row))
                {
                    rowsToRemove.Add(row);
                }
            }

            if (rowsToRemove.Count > 0)
            {
                DialogResult yesOrNo = MessageBox.Show("Are you sure you want to remove the selected words?", "Delete words", MessageBoxButtons.YesNo);
                if (yesOrNo == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in rowsToRemove)
                    {
                        GridView.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void PracticeButton_Click(object sender, EventArgs e)
        {
            if (WordList.LoadList(BoxListNames.SelectedItem.ToString()).Count() < 2)
            {
                NoWordsLabel.Visible = true;
                NoWordsTimer.Enabled = true;
                return;
            }

            if (PracticeMode)
            {
                PracticeMode = false;
                ButtonStart.Text = "Start";
                PracticeModeAppearance();
            }
            else
            {
                latestSession = new ScoreBoard(BoxListNames.Text);
                PracticeMode = true;
                ButtonStart.Text = "Stop";
                Practice();
            }
            SessionInfo();
        }

        private void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (PracticeMode == true)
            {
                e.Cancel = true;

            }
        }
        private void CorrectOrNotTimer_Tick(object sender, EventArgs e)
        {
            CorrectOrNotLabel.Visible = false;
            CorrectOrNotTimer.Enabled = false;
        }

        private void NamePrecedesLanguageTimer_Tick(object sender, EventArgs e)
        {
            NamePrecedesLanguageLabel.Visible = false;
            NamePrecedesLanguageTimer.Enabled = false;
        }

        private void NoWordsTimer_Tick(object sender, EventArgs e)
        {
            NoWordsLabel.Visible = false;
            NoWordsTimer.Enabled = false;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ContinuePractice();
        }

        private void UserTranslationBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                ContinuePractice();
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewLanguageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
