namespace Cyotek.Demo.AzureTranslation
{
  partial class MainForm
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
      System.Windows.Forms.GroupBox optionsGroupBox;
      System.Windows.Forms.Label apiKeyLabel;
      System.Windows.Forms.Label languageLabel;
      System.Windows.Forms.Label fromLabel;
      System.Windows.Forms.Label toLabel;
      System.Windows.Forms.GroupBox translateGroupBox;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      System.Windows.Forms.GroupBox getLanguagesForTranslateGroupBox;
      System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
      System.Windows.Forms.GroupBox getLanguageNamesGroupBox;
      System.Windows.Forms.Label localLabel;
      System.Windows.Forms.Label namesLabel;
      this.apiKeyTextBox = new System.Windows.Forms.TextBox();
      this.translateButton = new System.Windows.Forms.Button();
      this.translatedTextBox = new System.Windows.Forms.TextBox();
      this.sourceLabel = new System.Windows.Forms.Label();
      this.translatedLabel = new System.Windows.Forms.Label();
      this.toComboBox = new System.Windows.Forms.ComboBox();
      this.sourceTextBox = new System.Windows.Forms.TextBox();
      this.fromComboBox = new System.Windows.Forms.ComboBox();
      this.languageListBox = new System.Windows.Forms.ListBox();
      this.getLanguagesButton = new System.Windows.Forms.Button();
      this.namesListBox = new System.Windows.Forms.ListBox();
      this.getLanguageNamesButton = new System.Windows.Forms.Button();
      this.localComboBox = new System.Windows.Forms.ComboBox();
      optionsGroupBox = new System.Windows.Forms.GroupBox();
      apiKeyLabel = new System.Windows.Forms.Label();
      languageLabel = new System.Windows.Forms.Label();
      fromLabel = new System.Windows.Forms.Label();
      toLabel = new System.Windows.Forms.Label();
      translateGroupBox = new System.Windows.Forms.GroupBox();
      getLanguagesForTranslateGroupBox = new System.Windows.Forms.GroupBox();
      tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      getLanguageNamesGroupBox = new System.Windows.Forms.GroupBox();
      localLabel = new System.Windows.Forms.Label();
      namesLabel = new System.Windows.Forms.Label();
      optionsGroupBox.SuspendLayout();
      translateGroupBox.SuspendLayout();
      getLanguagesForTranslateGroupBox.SuspendLayout();
      tableLayoutPanel.SuspendLayout();
      getLanguageNamesGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // optionsGroupBox
      // 
      optionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      optionsGroupBox.Controls.Add(this.apiKeyTextBox);
      optionsGroupBox.Controls.Add(apiKeyLabel);
      optionsGroupBox.Location = new System.Drawing.Point(12, 12);
      optionsGroupBox.Name = "optionsGroupBox";
      optionsGroupBox.Size = new System.Drawing.Size(786, 59);
      optionsGroupBox.TabIndex = 0;
      optionsGroupBox.TabStop = false;
      optionsGroupBox.Text = "Options:";
      // 
      // apiKeyTextBox
      // 
      this.apiKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.apiKeyTextBox.Location = new System.Drawing.Point(6, 32);
      this.apiKeyTextBox.Name = "apiKeyTextBox";
      this.apiKeyTextBox.Size = new System.Drawing.Size(774, 20);
      this.apiKeyTextBox.TabIndex = 1;
      this.apiKeyTextBox.TextChanged += new System.EventHandler(this.apiKeyTextBox_TextChanged);
      // 
      // apiKeyLabel
      // 
      apiKeyLabel.AutoSize = true;
      apiKeyLabel.Location = new System.Drawing.Point(3, 16);
      apiKeyLabel.Name = "apiKeyLabel";
      apiKeyLabel.Size = new System.Drawing.Size(48, 13);
      apiKeyLabel.TabIndex = 0;
      apiKeyLabel.Text = "API &Key:";
      // 
      // languageLabel
      // 
      languageLabel.AutoSize = true;
      languageLabel.Location = new System.Drawing.Point(3, 16);
      languageLabel.Name = "languageLabel";
      languageLabel.Size = new System.Drawing.Size(58, 13);
      languageLabel.TabIndex = 0;
      languageLabel.Text = "&Language:";
      // 
      // fromLabel
      // 
      fromLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      fromLabel.AutoSize = true;
      fromLabel.Location = new System.Drawing.Point(258, 16);
      fromLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
      fromLabel.Name = "fromLabel";
      fromLabel.Size = new System.Drawing.Size(33, 13);
      fromLabel.TabIndex = 2;
      fromLabel.Text = "&From:";
      // 
      // toLabel
      // 
      toLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      toLabel.AutoSize = true;
      toLabel.Location = new System.Drawing.Point(258, 65);
      toLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
      toLabel.Name = "toLabel";
      toLabel.Size = new System.Drawing.Size(23, 13);
      toLabel.TabIndex = 4;
      toLabel.Text = "T&o:";
      // 
      // translateGroupBox
      // 
      translateGroupBox.Controls.Add(this.translateButton);
      translateGroupBox.Controls.Add(this.translatedTextBox);
      translateGroupBox.Controls.Add(this.sourceLabel);
      translateGroupBox.Controls.Add(this.translatedLabel);
      translateGroupBox.Controls.Add(this.toComboBox);
      translateGroupBox.Controls.Add(this.sourceTextBox);
      translateGroupBox.Controls.Add(toLabel);
      translateGroupBox.Controls.Add(fromLabel);
      translateGroupBox.Controls.Add(this.fromComboBox);
      translateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      translateGroupBox.Location = new System.Drawing.Point(395, 3);
      translateGroupBox.Name = "translateGroupBox";
      translateGroupBox.Size = new System.Drawing.Size(388, 435);
      translateGroupBox.TabIndex = 2;
      translateGroupBox.TabStop = false;
      translateGroupBox.Text = "/Translate";
      // 
      // translateButton
      // 
      this.translateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.translateButton.Location = new System.Drawing.Point(307, 406);
      this.translateButton.Name = "translateButton";
      this.translateButton.Size = new System.Drawing.Size(75, 23);
      this.translateButton.TabIndex = 8;
      this.translateButton.Text = "&Translate";
      this.translateButton.UseVisualStyleBackColor = true;
      this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
      // 
      // translatedTextBox
      // 
      this.translatedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.translatedTextBox.Location = new System.Drawing.Point(9, 167);
      this.translatedTextBox.Multiline = true;
      this.translatedTextBox.Name = "translatedTextBox";
      this.translatedTextBox.ReadOnly = true;
      this.translatedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.translatedTextBox.Size = new System.Drawing.Size(239, 262);
      this.translatedTextBox.TabIndex = 7;
      // 
      // sourceLabel
      // 
      this.sourceLabel.AutoSize = true;
      this.sourceLabel.Location = new System.Drawing.Point(3, 16);
      this.sourceLabel.Name = "sourceLabel";
      this.sourceLabel.Size = new System.Drawing.Size(44, 13);
      this.sourceLabel.TabIndex = 0;
      this.sourceLabel.Text = "&Source:";
      // 
      // translatedLabel
      // 
      this.translatedLabel.AutoSize = true;
      this.translatedLabel.Location = new System.Drawing.Point(6, 151);
      this.translatedLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
      this.translatedLabel.Name = "translatedLabel";
      this.translatedLabel.Size = new System.Drawing.Size(84, 13);
      this.translatedLabel.TabIndex = 6;
      this.translatedLabel.Text = "T&ranslated Text:";
      // 
      // toComboBox
      // 
      this.toComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.toComboBox.FormattingEnabled = true;
      this.toComboBox.Location = new System.Drawing.Point(261, 81);
      this.toComboBox.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
      this.toComboBox.Name = "toComboBox";
      this.toComboBox.Size = new System.Drawing.Size(121, 21);
      this.toComboBox.TabIndex = 5;
      // 
      // sourceTextBox
      // 
      this.sourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sourceTextBox.Location = new System.Drawing.Point(6, 32);
      this.sourceTextBox.Multiline = true;
      this.sourceTextBox.Name = "sourceTextBox";
      this.sourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.sourceTextBox.Size = new System.Drawing.Size(240, 104);
      this.sourceTextBox.TabIndex = 1;
      this.sourceTextBox.Text = resources.GetString("sourceTextBox.Text");
      // 
      // fromComboBox
      // 
      this.fromComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.fromComboBox.FormattingEnabled = true;
      this.fromComboBox.Location = new System.Drawing.Point(261, 32);
      this.fromComboBox.Name = "fromComboBox";
      this.fromComboBox.Size = new System.Drawing.Size(121, 21);
      this.fromComboBox.TabIndex = 3;
      // 
      // getLanguagesForTranslateGroupBox
      // 
      getLanguagesForTranslateGroupBox.Controls.Add(this.languageListBox);
      getLanguagesForTranslateGroupBox.Controls.Add(languageLabel);
      getLanguagesForTranslateGroupBox.Controls.Add(this.getLanguagesButton);
      getLanguagesForTranslateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      getLanguagesForTranslateGroupBox.Location = new System.Drawing.Point(3, 3);
      getLanguagesForTranslateGroupBox.Name = "getLanguagesForTranslateGroupBox";
      getLanguagesForTranslateGroupBox.Size = new System.Drawing.Size(190, 435);
      getLanguagesForTranslateGroupBox.TabIndex = 0;
      getLanguagesForTranslateGroupBox.TabStop = false;
      getLanguagesForTranslateGroupBox.Text = "/GetLanguagesForTranslate ";
      // 
      // languageListBox
      // 
      this.languageListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.languageListBox.FormattingEnabled = true;
      this.languageListBox.IntegralHeight = false;
      this.languageListBox.Location = new System.Drawing.Point(6, 32);
      this.languageListBox.Name = "languageListBox";
      this.languageListBox.Size = new System.Drawing.Size(178, 368);
      this.languageListBox.TabIndex = 1;
      // 
      // getLanguagesButton
      // 
      this.getLanguagesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.getLanguagesButton.Location = new System.Drawing.Point(93, 406);
      this.getLanguagesButton.Name = "getLanguagesButton";
      this.getLanguagesButton.Size = new System.Drawing.Size(91, 23);
      this.getLanguagesButton.TabIndex = 2;
      this.getLanguagesButton.Text = "&Request";
      this.getLanguagesButton.UseVisualStyleBackColor = true;
      this.getLanguagesButton.Click += new System.EventHandler(this.getLanguagesButton_Click);
      // 
      // tableLayoutPanel
      // 
      tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      tableLayoutPanel.ColumnCount = 3;
      tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      tableLayoutPanel.Controls.Add(getLanguageNamesGroupBox, 0, 0);
      tableLayoutPanel.Controls.Add(getLanguagesForTranslateGroupBox, 0, 0);
      tableLayoutPanel.Controls.Add(translateGroupBox, 2, 0);
      tableLayoutPanel.Location = new System.Drawing.Point(12, 77);
      tableLayoutPanel.Name = "tableLayoutPanel";
      tableLayoutPanel.RowCount = 1;
      tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      tableLayoutPanel.Size = new System.Drawing.Size(786, 441);
      tableLayoutPanel.TabIndex = 1;
      // 
      // getLanguageNamesGroupBox
      // 
      getLanguageNamesGroupBox.Controls.Add(namesLabel);
      getLanguageNamesGroupBox.Controls.Add(this.localComboBox);
      getLanguageNamesGroupBox.Controls.Add(this.namesListBox);
      getLanguageNamesGroupBox.Controls.Add(localLabel);
      getLanguageNamesGroupBox.Controls.Add(this.getLanguageNamesButton);
      getLanguageNamesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      getLanguageNamesGroupBox.Location = new System.Drawing.Point(199, 3);
      getLanguageNamesGroupBox.Name = "getLanguageNamesGroupBox";
      getLanguageNamesGroupBox.Size = new System.Drawing.Size(190, 435);
      getLanguageNamesGroupBox.TabIndex = 1;
      getLanguageNamesGroupBox.TabStop = false;
      getLanguageNamesGroupBox.Text = "/GetLanguageNames";
      // 
      // namesListBox
      // 
      this.namesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.namesListBox.FormattingEnabled = true;
      this.namesListBox.IntegralHeight = false;
      this.namesListBox.Location = new System.Drawing.Point(6, 84);
      this.namesListBox.Name = "namesListBox";
      this.namesListBox.Size = new System.Drawing.Size(178, 316);
      this.namesListBox.TabIndex = 3;
      // 
      // localLabel
      // 
      localLabel.AutoSize = true;
      localLabel.Location = new System.Drawing.Point(3, 16);
      localLabel.Name = "localLabel";
      localLabel.Size = new System.Drawing.Size(42, 13);
      localLabel.TabIndex = 0;
      localLabel.Text = "L&ocale:";
      // 
      // getLanguageNamesButton
      // 
      this.getLanguageNamesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.getLanguageNamesButton.Location = new System.Drawing.Point(93, 406);
      this.getLanguageNamesButton.Name = "getLanguageNamesButton";
      this.getLanguageNamesButton.Size = new System.Drawing.Size(91, 23);
      this.getLanguageNamesButton.TabIndex = 4;
      this.getLanguageNamesButton.Text = "Re&quest";
      this.getLanguageNamesButton.UseVisualStyleBackColor = true;
      this.getLanguageNamesButton.Click += new System.EventHandler(this.getLanguageNamesButton_Click);
      // 
      // localComboBox
      // 
      this.localComboBox.FormattingEnabled = true;
      this.localComboBox.Location = new System.Drawing.Point(6, 32);
      this.localComboBox.Name = "localComboBox";
      this.localComboBox.Size = new System.Drawing.Size(121, 21);
      this.localComboBox.TabIndex = 1;
      // 
      // namesLabel
      // 
      namesLabel.AutoSize = true;
      namesLabel.Location = new System.Drawing.Point(3, 68);
      namesLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
      namesLabel.Name = "namesLabel";
      namesLabel.Size = new System.Drawing.Size(43, 13);
      namesLabel.TabIndex = 2;
      namesLabel.Text = "&Names:";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(810, 530);
      this.Controls.Add(tableLayoutPanel);
      this.Controls.Add(optionsGroupBox);
      this.Name = "MainForm";
      this.Text = "cyotek.com Azure Cognitive Services Translation Demonstration";
      optionsGroupBox.ResumeLayout(false);
      optionsGroupBox.PerformLayout();
      translateGroupBox.ResumeLayout(false);
      translateGroupBox.PerformLayout();
      getLanguagesForTranslateGroupBox.ResumeLayout(false);
      getLanguagesForTranslateGroupBox.PerformLayout();
      tableLayoutPanel.ResumeLayout(false);
      getLanguageNamesGroupBox.ResumeLayout(false);
      getLanguageNamesGroupBox.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.TextBox apiKeyTextBox;
    private System.Windows.Forms.Button getLanguagesButton;
    private System.Windows.Forms.ListBox languageListBox;
    private System.Windows.Forms.Label sourceLabel;
    private System.Windows.Forms.TextBox sourceTextBox;
    private System.Windows.Forms.Label translatedLabel;
    private System.Windows.Forms.TextBox translatedTextBox;
    private System.Windows.Forms.ComboBox fromComboBox;
    private System.Windows.Forms.ComboBox toComboBox;
    private System.Windows.Forms.Button translateButton;
    private System.Windows.Forms.ListBox namesListBox;
    private System.Windows.Forms.Button getLanguageNamesButton;
    private System.Windows.Forms.ComboBox localComboBox;
  }
}

