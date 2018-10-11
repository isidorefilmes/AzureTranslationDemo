using System;
using System.Linq;
using System.Windows.Forms;

// Translating text with Azure cognitive services
// http://www.cyotek.com/blog/translating-text-with-azure-cognitive-services

// This work is licensed under the Creative Commons Attribution 4.0 International License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

namespace Cyotek.Demo.AzureTranslation
{
  public partial class MainForm : Form
  {
    #region Fields

    private string[] _languages;

    private TranslationClient _translationClient;

    #endregion

    #region Constructors

    public MainForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Methods

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      _translationClient = new TranslationClient(apiKeyTextBox.Text);

      localComboBox.Text = "de";
      fromComboBox.Text = "en";
      toComboBox.Text = "de";

      _languages = new[]
                   {
                     "en",
                     "fr",
                     "de"
                   };
    }

    private void apiKeyTextBox_TextChanged(object sender, EventArgs e)
    {
      _translationClient.AuthorizationKey = apiKeyTextBox.Text;
    }

    private void FillItems(ListBox control, string[] items)
    {
      ListBox.ObjectCollection listItems;

      control.BeginUpdate();

      listItems = control.Items;
      listItems.Clear();

      foreach (string item in items.OrderBy(item => item))
      {
        listItems.Add(item);
      }

      control.EndUpdate();
    }

    private void FillItems(ComboBox control, string[] items)
    {
      ComboBox.ObjectCollection listItems;

      control.BeginUpdate();

      listItems = control.Items;
      listItems.Clear();

      foreach (string item in items.OrderBy(item => item))
      {
        listItems.Add(item);
      }

      control.EndUpdate();
    }

    private void getLanguageNamesButton_Click(object sender, EventArgs e)
    {
      this.WrapRequest(() =>
                       {
                         string[] names;

                         names = _translationClient.GetLocalizedLanguageNames(localComboBox.Text, _languages);

                         this.FillItems(namesListBox, names);
                       });
    }

    private void getLanguagesButton_Click(object sender, EventArgs e)
    {
      this.WrapRequest(() =>
                       {
                         _languages = _translationClient.GetLanguages();

                         this.FillItems(languageListBox, _languages);
                         this.FillItems(localComboBox, _languages);
                         this.FillItems(fromComboBox, _languages);
                         this.FillItems(toComboBox, _languages);
                       });
    }

    private void translateButton_Click(object sender, EventArgs e)
    {
      this.WrapRequest(() => translatedTextBox.Text = _translationClient.Translate(sourceTextBox.Text, fromComboBox.Text, toComboBox.Text));
    }

    private void WrapRequest(Action action)
    {
      this.UseWaitCursor = true;
      Cursor.Current = Cursors.WaitCursor;

      try
      {
        action();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.GetBaseException().Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      Cursor.Current = Cursors.Default;
      this.UseWaitCursor = false;
    }

    #endregion
  }
}
