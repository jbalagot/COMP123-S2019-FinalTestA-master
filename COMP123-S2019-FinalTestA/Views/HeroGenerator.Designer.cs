﻿/*
 * STUDENT NAME: JEANNERY MAE BALAGOT
 * *STUDENT NUMBER: 301051646
 * DESCRIPTION: This is the main form of the hero generator form
 * */
namespace COMP123_S2019_FinalTestA.Views
{
   public partial class HeroGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroGenerator));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.GenerateNameButton = new System.Windows.Forms.Button();
            this.HeroNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.HeroNameLabel = new System.Windows.Forms.Label();
            this.AbilityPage = new System.Windows.Forms.TabPage();
            this.AbilityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PhysicalAbilitiesLabel = new System.Windows.Forms.Label();
            this.PopularityDataLabel = new System.Windows.Forms.Label();
            this.MentalAbilitiesLabel = new System.Windows.Forms.Label();
            this.PsycheDataLabel = new System.Windows.Forms.Label();
            this.IntuitionDataLabel = new System.Windows.Forms.Label();
            this.PopularityLabel = new System.Windows.Forms.Label();
            this.FightingLabel = new System.Windows.Forms.Label();
            this.ReasonDataLabel = new System.Windows.Forms.Label();
            this.EnduranceDataLabel = new System.Windows.Forms.Label();
            this.AgilityLabel = new System.Windows.Forms.Label();
            this.PsycheLabel = new System.Windows.Forms.Label();
            this.IntuitionLabel = new System.Windows.Forms.Label();
            this.StrenghLabel = new System.Windows.Forms.Label();
            this.EnduranceLabel = new System.Windows.Forms.Label();
            this.AgilityDataLabel = new System.Windows.Forms.Label();
            this.ReasonLabel = new System.Windows.Forms.Label();
            this.StrengthDataLabel = new System.Windows.Forms.Label();
            this.FightingDataLabel = new System.Windows.Forms.Label();
            this.GenerateAbilitiesButton = new System.Windows.Forms.Button();
            this.PowersPage = new System.Windows.Forms.TabPage();
            this.PowerLabel1 = new System.Windows.Forms.Label();
            this.PoweLabel4 = new System.Windows.Forms.Label();
            this.PowerLabel2 = new System.Windows.Forms.Label();
            this.PowerLabel3 = new System.Windows.Forms.Label();
            this.InventoryHeaderLabel = new System.Windows.Forms.Label();
            this.CharacterSheet = new System.Windows.Forms.TabPage();
            this.HeroToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.HeroMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.AbilityPage.SuspendLayout();
            this.AbilityTableLayoutPanel.SuspendLayout();
            this.PowersPage.SuspendLayout();
            this.CharacterSheet.SuspendLayout();
            this.HeroToolStrip.SuspendLayout();
            this.HeroMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.IdentityPage);
            this.MainTabControl.Controls.Add(this.AbilityPage);
            this.MainTabControl.Controls.Add(this.PowersPage);
            this.MainTabControl.Controls.Add(this.CharacterSheet);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(614, 377);
            this.MainTabControl.TabIndex = 0;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Controls.Add(this.GenerateNameButton);
            this.IdentityPage.Controls.Add(this.HeroNameTextBox);
            this.IdentityPage.Controls.Add(this.LastNameLabel);
            this.IdentityPage.Controls.Add(this.LastNameDataLabel);
            this.IdentityPage.Controls.Add(this.FirstNameDataLabel);
            this.IdentityPage.Controls.Add(this.FirstNameLabel);
            this.IdentityPage.Controls.Add(this.HeroNameLabel);
            this.IdentityPage.Location = new System.Drawing.Point(4, 33);
            this.IdentityPage.Margin = new System.Windows.Forms.Padding(2);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Size = new System.Drawing.Size(606, 340);
            this.IdentityPage.TabIndex = 2;
            this.IdentityPage.Text = "Identity";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // GenerateNameButton
            // 
            this.GenerateNameButton.Location = new System.Drawing.Point(334, 209);
            this.GenerateNameButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateNameButton.Name = "GenerateNameButton";
            this.GenerateNameButton.Size = new System.Drawing.Size(160, 36);
            this.GenerateNameButton.TabIndex = 2;
            this.GenerateNameButton.Text = "Generate Name";
            this.GenerateNameButton.UseVisualStyleBackColor = true;
            // 
            // HeroNameTextBox
            // 
            this.HeroNameTextBox.Location = new System.Drawing.Point(187, 42);
            this.HeroNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HeroNameTextBox.Name = "HeroNameTextBox";
            this.HeroNameTextBox.Size = new System.Drawing.Size(308, 29);
            this.HeroNameTextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(6, 155);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(175, 32);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameDataLabel.Location = new System.Drawing.Point(183, 155);
            this.LastNameDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(312, 33);
            this.LastNameDataLabel.TabIndex = 0;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameDataLabel.Location = new System.Drawing.Point(183, 113);
            this.FirstNameDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(312, 33);
            this.FirstNameDataLabel.TabIndex = 0;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Location = new System.Drawing.Point(7, 113);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(175, 32);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeroNameLabel
            // 
            this.HeroNameLabel.Location = new System.Drawing.Point(7, 38);
            this.HeroNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeroNameLabel.Name = "HeroNameLabel";
            this.HeroNameLabel.Size = new System.Drawing.Size(175, 32);
            this.HeroNameLabel.TabIndex = 0;
            this.HeroNameLabel.Text = "Enter Hero Name";
            this.HeroNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AbilityPage
            // 
            this.AbilityPage.Controls.Add(this.AbilityTableLayoutPanel);
            this.AbilityPage.Location = new System.Drawing.Point(4, 33);
            this.AbilityPage.Margin = new System.Windows.Forms.Padding(2);
            this.AbilityPage.Name = "AbilityPage";
            this.AbilityPage.Padding = new System.Windows.Forms.Padding(2);
            this.AbilityPage.Size = new System.Drawing.Size(606, 340);
            this.AbilityPage.TabIndex = 0;
            this.AbilityPage.Text = "Abilities";
            this.AbilityPage.UseVisualStyleBackColor = true;
            // 
            // AbilityTableLayoutPanel
            // 
            this.AbilityTableLayoutPanel.ColumnCount = 4;
            this.AbilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayoutPanel.Controls.Add(this.PhysicalAbilitiesLabel, 0, 0);
            this.AbilityTableLayoutPanel.Controls.Add(this.PopularityDataLabel, 3, 4);
            this.AbilityTableLayoutPanel.Controls.Add(this.MentalAbilitiesLabel, 2, 0);
            this.AbilityTableLayoutPanel.Controls.Add(this.PsycheDataLabel, 3, 3);
            this.AbilityTableLayoutPanel.Controls.Add(this.IntuitionDataLabel, 3, 2);
            this.AbilityTableLayoutPanel.Controls.Add(this.PopularityLabel, 2, 4);
            this.AbilityTableLayoutPanel.Controls.Add(this.FightingLabel, 0, 1);
            this.AbilityTableLayoutPanel.Controls.Add(this.ReasonDataLabel, 3, 1);
            this.AbilityTableLayoutPanel.Controls.Add(this.EnduranceDataLabel, 1, 4);
            this.AbilityTableLayoutPanel.Controls.Add(this.AgilityLabel, 0, 2);
            this.AbilityTableLayoutPanel.Controls.Add(this.PsycheLabel, 2, 3);
            this.AbilityTableLayoutPanel.Controls.Add(this.IntuitionLabel, 2, 2);
            this.AbilityTableLayoutPanel.Controls.Add(this.StrenghLabel, 0, 3);
            this.AbilityTableLayoutPanel.Controls.Add(this.EnduranceLabel, 0, 4);
            this.AbilityTableLayoutPanel.Controls.Add(this.AgilityDataLabel, 1, 2);
            this.AbilityTableLayoutPanel.Controls.Add(this.ReasonLabel, 2, 1);
            this.AbilityTableLayoutPanel.Controls.Add(this.StrengthDataLabel, 1, 3);
            this.AbilityTableLayoutPanel.Controls.Add(this.FightingDataLabel, 1, 1);
            this.AbilityTableLayoutPanel.Controls.Add(this.GenerateAbilitiesButton, 2, 6);
            this.AbilityTableLayoutPanel.Location = new System.Drawing.Point(7, 6);
            this.AbilityTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AbilityTableLayoutPanel.Name = "AbilityTableLayoutPanel";
            this.AbilityTableLayoutPanel.RowCount = 7;
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilityTableLayoutPanel.Size = new System.Drawing.Size(595, 332);
            this.AbilityTableLayoutPanel.TabIndex = 3;
            // 
            // PhysicalAbilitiesLabel
            // 
            this.PhysicalAbilitiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilityTableLayoutPanel.SetColumnSpan(this.PhysicalAbilitiesLabel, 2);
            this.PhysicalAbilitiesLabel.Location = new System.Drawing.Point(2, 0);
            this.PhysicalAbilitiesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhysicalAbilitiesLabel.Name = "PhysicalAbilitiesLabel";
            this.PhysicalAbilitiesLabel.Size = new System.Drawing.Size(292, 47);
            this.PhysicalAbilitiesLabel.TabIndex = 2;
            this.PhysicalAbilitiesLabel.Text = "Physical Abilities";
            this.PhysicalAbilitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopularityDataLabel
            // 
            this.PopularityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PopularityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PopularityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PopularityDataLabel.Location = new System.Drawing.Point(446, 188);
            this.PopularityDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PopularityDataLabel.Name = "PopularityDataLabel";
            this.PopularityDataLabel.Size = new System.Drawing.Size(147, 47);
            this.PopularityDataLabel.TabIndex = 1;
            this.PopularityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MentalAbilitiesLabel
            // 
            this.MentalAbilitiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilityTableLayoutPanel.SetColumnSpan(this.MentalAbilitiesLabel, 2);
            this.MentalAbilitiesLabel.Location = new System.Drawing.Point(298, 0);
            this.MentalAbilitiesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MentalAbilitiesLabel.Name = "MentalAbilitiesLabel";
            this.MentalAbilitiesLabel.Size = new System.Drawing.Size(295, 47);
            this.MentalAbilitiesLabel.TabIndex = 2;
            this.MentalAbilitiesLabel.Text = "Mental Abilities";
            this.MentalAbilitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PsycheDataLabel
            // 
            this.PsycheDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PsycheDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PsycheDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PsycheDataLabel.Location = new System.Drawing.Point(446, 141);
            this.PsycheDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PsycheDataLabel.Name = "PsycheDataLabel";
            this.PsycheDataLabel.Size = new System.Drawing.Size(147, 47);
            this.PsycheDataLabel.TabIndex = 1;
            this.PsycheDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntuitionDataLabel
            // 
            this.IntuitionDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntuitionDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IntuitionDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntuitionDataLabel.Location = new System.Drawing.Point(446, 94);
            this.IntuitionDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntuitionDataLabel.Name = "IntuitionDataLabel";
            this.IntuitionDataLabel.Size = new System.Drawing.Size(147, 47);
            this.IntuitionDataLabel.TabIndex = 1;
            this.IntuitionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopularityLabel
            // 
            this.PopularityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PopularityLabel.Location = new System.Drawing.Point(298, 188);
            this.PopularityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PopularityLabel.Name = "PopularityLabel";
            this.PopularityLabel.Size = new System.Drawing.Size(144, 47);
            this.PopularityLabel.TabIndex = 2;
            this.PopularityLabel.Text = "Popularity";
            this.PopularityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FightingLabel
            // 
            this.FightingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FightingLabel.Location = new System.Drawing.Point(2, 47);
            this.FightingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FightingLabel.Name = "FightingLabel";
            this.FightingLabel.Size = new System.Drawing.Size(144, 47);
            this.FightingLabel.TabIndex = 2;
            this.FightingLabel.Text = "Fighting";
            this.FightingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReasonDataLabel
            // 
            this.ReasonDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReasonDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReasonDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReasonDataLabel.Location = new System.Drawing.Point(446, 47);
            this.ReasonDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReasonDataLabel.Name = "ReasonDataLabel";
            this.ReasonDataLabel.Size = new System.Drawing.Size(147, 47);
            this.ReasonDataLabel.TabIndex = 1;
            this.ReasonDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnduranceDataLabel
            // 
            this.EnduranceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnduranceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnduranceDataLabel.Location = new System.Drawing.Point(150, 188);
            this.EnduranceDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnduranceDataLabel.Name = "EnduranceDataLabel";
            this.EnduranceDataLabel.Size = new System.Drawing.Size(144, 47);
            this.EnduranceDataLabel.TabIndex = 1;
            this.EnduranceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgilityLabel
            // 
            this.AgilityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgilityLabel.Location = new System.Drawing.Point(2, 94);
            this.AgilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AgilityLabel.Name = "AgilityLabel";
            this.AgilityLabel.Size = new System.Drawing.Size(144, 47);
            this.AgilityLabel.TabIndex = 2;
            this.AgilityLabel.Text = "Agility";
            this.AgilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PsycheLabel
            // 
            this.PsycheLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PsycheLabel.Location = new System.Drawing.Point(298, 141);
            this.PsycheLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PsycheLabel.Name = "PsycheLabel";
            this.PsycheLabel.Size = new System.Drawing.Size(144, 47);
            this.PsycheLabel.TabIndex = 2;
            this.PsycheLabel.Text = "Psyche";
            this.PsycheLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntuitionLabel
            // 
            this.IntuitionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntuitionLabel.Location = new System.Drawing.Point(298, 94);
            this.IntuitionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntuitionLabel.Name = "IntuitionLabel";
            this.IntuitionLabel.Size = new System.Drawing.Size(144, 47);
            this.IntuitionLabel.TabIndex = 2;
            this.IntuitionLabel.Text = "Intuition";
            this.IntuitionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StrenghLabel
            // 
            this.StrenghLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrenghLabel.Location = new System.Drawing.Point(2, 141);
            this.StrenghLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StrenghLabel.Name = "StrenghLabel";
            this.StrenghLabel.Size = new System.Drawing.Size(144, 47);
            this.StrenghLabel.TabIndex = 2;
            this.StrenghLabel.Text = "Strength";
            this.StrenghLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnduranceLabel
            // 
            this.EnduranceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceLabel.Location = new System.Drawing.Point(2, 188);
            this.EnduranceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnduranceLabel.Name = "EnduranceLabel";
            this.EnduranceLabel.Size = new System.Drawing.Size(144, 47);
            this.EnduranceLabel.TabIndex = 2;
            this.EnduranceLabel.Text = "Endurance";
            this.EnduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgilityDataLabel
            // 
            this.AgilityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgilityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AgilityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgilityDataLabel.Location = new System.Drawing.Point(150, 94);
            this.AgilityDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AgilityDataLabel.Name = "AgilityDataLabel";
            this.AgilityDataLabel.Size = new System.Drawing.Size(144, 47);
            this.AgilityDataLabel.TabIndex = 1;
            this.AgilityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReasonLabel
            // 
            this.ReasonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReasonLabel.Location = new System.Drawing.Point(298, 47);
            this.ReasonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReasonLabel.Name = "ReasonLabel";
            this.ReasonLabel.Size = new System.Drawing.Size(144, 47);
            this.ReasonLabel.TabIndex = 2;
            this.ReasonLabel.Text = "Reason";
            this.ReasonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StrengthDataLabel
            // 
            this.StrengthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDataLabel.Location = new System.Drawing.Point(150, 141);
            this.StrengthDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StrengthDataLabel.Name = "StrengthDataLabel";
            this.StrengthDataLabel.Size = new System.Drawing.Size(144, 47);
            this.StrengthDataLabel.TabIndex = 1;
            this.StrengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FightingDataLabel
            // 
            this.FightingDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FightingDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FightingDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FightingDataLabel.Location = new System.Drawing.Point(150, 47);
            this.FightingDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FightingDataLabel.Name = "FightingDataLabel";
            this.FightingDataLabel.Size = new System.Drawing.Size(144, 47);
            this.FightingDataLabel.TabIndex = 1;
            this.FightingDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerateAbilitiesButton
            // 
            this.GenerateAbilitiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilityTableLayoutPanel.SetColumnSpan(this.GenerateAbilitiesButton, 2);
            this.GenerateAbilitiesButton.Location = new System.Drawing.Point(298, 284);
            this.GenerateAbilitiesButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateAbilitiesButton.Name = "GenerateAbilitiesButton";
            this.GenerateAbilitiesButton.Size = new System.Drawing.Size(295, 46);
            this.GenerateAbilitiesButton.TabIndex = 3;
            this.GenerateAbilitiesButton.Text = "Generate Abilities";
            this.GenerateAbilitiesButton.UseVisualStyleBackColor = true;
            // 
            // PowersPage
            // 
            this.PowersPage.Controls.Add(this.PowerLabel1);
            this.PowersPage.Controls.Add(this.PoweLabel4);
            this.PowersPage.Controls.Add(this.PowerLabel2);
            this.PowersPage.Controls.Add(this.PowerLabel3);
            this.PowersPage.Controls.Add(this.InventoryHeaderLabel);
            this.PowersPage.Location = new System.Drawing.Point(4, 33);
            this.PowersPage.Margin = new System.Windows.Forms.Padding(2);
            this.PowersPage.Name = "PowersPage";
            this.PowersPage.Padding = new System.Windows.Forms.Padding(2);
            this.PowersPage.Size = new System.Drawing.Size(606, 340);
            this.PowersPage.TabIndex = 1;
            this.PowersPage.Text = "Powers";
            this.PowersPage.UseVisualStyleBackColor = true;
            // 
            // PowerLabel1
            // 
            this.PowerLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PowerLabel1.AutoSize = true;
            this.PowerLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.PowerLabel1.Location = new System.Drawing.Point(107, 158);
            this.PowerLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.PowerLabel1.Name = "PowerLabel1";
            this.PowerLabel1.Size = new System.Drawing.Size(79, 24);
            this.PowerLabel1.TabIndex = 6;
            this.PowerLabel1.Text = "Power 1";
            this.PowerLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PoweLabel4
            // 
            this.PoweLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PoweLabel4.AutoSize = true;
            this.PoweLabel4.BackColor = System.Drawing.Color.Gainsboro;
            this.PoweLabel4.Location = new System.Drawing.Point(399, 158);
            this.PoweLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.PoweLabel4.Name = "PoweLabel4";
            this.PoweLabel4.Size = new System.Drawing.Size(79, 24);
            this.PoweLabel4.TabIndex = 8;
            this.PoweLabel4.Text = "Power 4";
            this.PoweLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PowerLabel2
            // 
            this.PowerLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PowerLabel2.AutoSize = true;
            this.PowerLabel2.BackColor = System.Drawing.Color.Gainsboro;
            this.PowerLabel2.Location = new System.Drawing.Point(203, 158);
            this.PowerLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.PowerLabel2.Name = "PowerLabel2";
            this.PowerLabel2.Size = new System.Drawing.Size(79, 24);
            this.PowerLabel2.TabIndex = 4;
            this.PowerLabel2.Text = "Power 2";
            this.PowerLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PowerLabel3
            // 
            this.PowerLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PowerLabel3.AutoSize = true;
            this.PowerLabel3.BackColor = System.Drawing.Color.Gainsboro;
            this.PowerLabel3.Location = new System.Drawing.Point(302, 158);
            this.PowerLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.PowerLabel3.Name = "PowerLabel3";
            this.PowerLabel3.Size = new System.Drawing.Size(79, 24);
            this.PowerLabel3.TabIndex = 5;
            this.PowerLabel3.Text = "Power 3";
            this.PowerLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InventoryHeaderLabel
            // 
            this.InventoryHeaderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InventoryHeaderLabel.AutoSize = true;
            this.InventoryHeaderLabel.BackColor = System.Drawing.Color.Silver;
            this.InventoryHeaderLabel.Location = new System.Drawing.Point(230, 5);
            this.InventoryHeaderLabel.Margin = new System.Windows.Forms.Padding(3);
            this.InventoryHeaderLabel.Name = "InventoryHeaderLabel";
            this.InventoryHeaderLabel.Size = new System.Drawing.Size(64, 24);
            this.InventoryHeaderLabel.TabIndex = 1;
            this.InventoryHeaderLabel.Text = "Power";
            this.InventoryHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharacterSheet
            // 
            this.CharacterSheet.Controls.Add(this.HeroToolStrip);
            this.CharacterSheet.Controls.Add(this.HeroMenuStrip);
            this.CharacterSheet.Location = new System.Drawing.Point(4, 33);
            this.CharacterSheet.Margin = new System.Windows.Forms.Padding(2);
            this.CharacterSheet.Name = "CharacterSheet";
            this.CharacterSheet.Padding = new System.Windows.Forms.Padding(2);
            this.CharacterSheet.Size = new System.Drawing.Size(606, 340);
            this.CharacterSheet.TabIndex = 3;
            this.CharacterSheet.Text = "Character Sheet";
            this.CharacterSheet.UseVisualStyleBackColor = true;
            // 
            // HeroToolStrip
            // 
            this.HeroToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.HeroToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.toolStripSeparator3,
            this.helpToolStripButton});
            this.HeroToolStrip.Location = new System.Drawing.Point(2, 26);
            this.HeroToolStrip.Name = "HeroToolStrip";
            this.HeroToolStrip.Size = new System.Drawing.Size(602, 27);
            this.HeroToolStrip.TabIndex = 1;
            this.HeroToolStrip.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // HeroMenuStrip
            // 
            this.HeroMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.HeroMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.HeroMenuStrip.Location = new System.Drawing.Point(2, 2);
            this.HeroMenuStrip.Name = "HeroMenuStrip";
            this.HeroMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.HeroMenuStrip.Size = new System.Drawing.Size(602, 24);
            this.HeroMenuStrip.TabIndex = 0;
            this.HeroMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(147, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(519, 401);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(86, 38);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(9, 401);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(86, 38);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HeroGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.ClientSize = new System.Drawing.Size(614, 458);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MainTabControl);
            this.MainMenuStrip = this.HeroMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HeroGenerator";
            this.Text = "Hero Generator";
            this.MainTabControl.ResumeLayout(false);
            this.IdentityPage.ResumeLayout(false);
            this.IdentityPage.PerformLayout();
            this.AbilityPage.ResumeLayout(false);
            this.AbilityTableLayoutPanel.ResumeLayout(false);
            this.PowersPage.ResumeLayout(false);
            this.PowersPage.PerformLayout();
            this.CharacterSheet.ResumeLayout(false);
            this.CharacterSheet.PerformLayout();
            this.HeroToolStrip.ResumeLayout(false);
            this.HeroToolStrip.PerformLayout();
            this.HeroMenuStrip.ResumeLayout(false);
            this.HeroMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.TabPage AbilityPage;
        private System.Windows.Forms.TabPage PowersPage;
        private System.Windows.Forms.TabPage CharacterSheet;
        private System.Windows.Forms.MenuStrip HeroMenuStrip;
        private System.Windows.Forms.ToolStrip HeroToolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label HeroNameLabel;
        private System.Windows.Forms.Button GenerateNameButton;
        private System.Windows.Forms.TextBox HeroNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TableLayoutPanel AbilityTableLayoutPanel;
        private System.Windows.Forms.Label PhysicalAbilitiesLabel;
        private System.Windows.Forms.Label PopularityDataLabel;
        private System.Windows.Forms.Label MentalAbilitiesLabel;
        private System.Windows.Forms.Label PsycheDataLabel;
        private System.Windows.Forms.Label IntuitionDataLabel;
        private System.Windows.Forms.Label PopularityLabel;
        private System.Windows.Forms.Label FightingLabel;
        private System.Windows.Forms.Label ReasonDataLabel;
        private System.Windows.Forms.Label EnduranceDataLabel;
        private System.Windows.Forms.Label AgilityLabel;
        private System.Windows.Forms.Label PsycheLabel;
        private System.Windows.Forms.Label IntuitionLabel;
        private System.Windows.Forms.Label StrenghLabel;
        private System.Windows.Forms.Label EnduranceLabel;
        private System.Windows.Forms.Label AgilityDataLabel;
        private System.Windows.Forms.Label ReasonLabel;
        private System.Windows.Forms.Label StrengthDataLabel;
        private System.Windows.Forms.Label FightingDataLabel;
        private System.Windows.Forms.Button GenerateAbilitiesButton;
        private System.Windows.Forms.Label PowerLabel1;
        private System.Windows.Forms.Label PoweLabel4;
        private System.Windows.Forms.Label PowerLabel2;
        private System.Windows.Forms.Label PowerLabel3;
        private System.Windows.Forms.Label InventoryHeaderLabel;
    }
}
