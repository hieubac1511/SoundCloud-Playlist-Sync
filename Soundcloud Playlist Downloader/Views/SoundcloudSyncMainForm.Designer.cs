﻿using Soundcloud_Playlist_Downloader.Properties;

namespace Soundcloud_Playlist_Downloader.Views
{
    partial class SoundcloudSyncMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundcloudSyncMainForm));
            this.syncButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.favoritesRadio = new System.Windows.Forms.RadioButton();
            this.playlistRadio = new System.Windows.Forms.RadioButton();
            this.artistRadio = new System.Windows.Forms.RadioButton();
            this.chk_folderByArtist = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chk_highquality = new System.Windows.Forms.CheckBox();
            this.tt_qualityExplanation = new System.Windows.Forms.ToolTip(this.components);
            this.chk_convertToMp3 = new System.Windows.Forms.CheckBox();
            this.chk_replaceIllegalCharacters = new System.Windows.Forms.CheckBox();
            this.chk_includeArtistinFilename = new System.Windows.Forms.CheckBox();
            this.lbl_exclude = new System.Windows.Forms.Label();
            this.chk_excl_m4a = new System.Windows.Forms.CheckBox();
            this.chk_exl_aac = new System.Windows.Forms.CheckBox();
            this.pnl_convert = new System.Windows.Forms.Panel();
            this.rbttn_twoWay = new System.Windows.Forms.RadioButton();
            this.rbttn_oneWay = new System.Windows.Forms.RadioButton();
            this.gbox_syncMethod = new System.Windows.Forms.GroupBox();
            this.gbox_downMethod = new System.Windows.Forms.GroupBox();
            this.trackRadio = new System.Windows.Forms.RadioButton();
            this.gbox_url = new System.Windows.Forms.GroupBox();
            this.url = new System.Windows.Forms.TextBox();
            this.gbox_advanced = new System.Windows.Forms.GroupBox();
            this.nudConcurrency = new System.Windows.Forms.NumericUpDown();
            this.concurrency = new System.Windows.Forms.Label();
            this.gbox_localdir = new System.Windows.Forms.GroupBox();
            this.directoryPath = new System.Windows.Forms.TextBox();
            this.lb_progressOfTracks = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnl_convert.SuspendLayout();
            this.gbox_syncMethod.SuspendLayout();
            this.gbox_downMethod.SuspendLayout();
            this.gbox_url.SuspendLayout();
            this.gbox_advanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConcurrency)).BeginInit();
            this.gbox_localdir.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // syncButton
            // 
            this.syncButton.Location = new System.Drawing.Point(12, 483);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(397, 23);
            this.syncButton.TabIndex = 4;
            this.syncButton.Text = "Synchronize";
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(327, 19);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(62, 20);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(417, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 512);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(397, 10);
            this.progressBar.TabIndex = 10;
            // 
            // favoritesRadio
            // 
            this.favoritesRadio.AutoSize = true;
            this.favoritesRadio.Location = new System.Drawing.Point(6, 42);
            this.favoritesRadio.Name = "favoritesRadio";
            this.favoritesRadio.Size = new System.Drawing.Size(253, 17);
            this.favoritesRadio.TabIndex = 12;
            this.favoritesRadio.Text = "All songs favorited by the user at this profile URL";
            this.favoritesRadio.UseVisualStyleBackColor = true;
            // 
            // playlistRadio
            // 
            this.playlistRadio.AutoSize = true;
            this.playlistRadio.Checked = true;
            this.playlistRadio.Location = new System.Drawing.Point(6, 19);
            this.playlistRadio.Name = "playlistRadio";
            this.playlistRadio.Size = new System.Drawing.Size(168, 17);
            this.playlistRadio.TabIndex = 11;
            this.playlistRadio.TabStop = true;
            this.playlistRadio.Text = "All songs from this playlist URL";
            this.playlistRadio.UseVisualStyleBackColor = true;
            // 
            // artistRadio
            // 
            this.artistRadio.AutoSize = true;
            this.artistRadio.Location = new System.Drawing.Point(6, 65);
            this.artistRadio.Name = "artistRadio";
            this.artistRadio.Size = new System.Drawing.Size(155, 17);
            this.artistRadio.TabIndex = 13;
            this.artistRadio.Text = "All songs by this artists URL";
            this.artistRadio.UseVisualStyleBackColor = true;
            // 
            // chk_folderByArtist
            // 
            this.chk_folderByArtist.AutoSize = true;
            this.chk_folderByArtist.Checked = true;
            this.chk_folderByArtist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_folderByArtist.Location = new System.Drawing.Point(6, 47);
            this.chk_folderByArtist.Name = "chk_folderByArtist";
            this.chk_folderByArtist.Size = new System.Drawing.Size(172, 17);
            this.chk_folderByArtist.TabIndex = 15;
            this.chk_folderByArtist.Text = "Sort songs into folders by artist ";
            this.chk_folderByArtist.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // chk_highquality
            // 
            this.chk_highquality.AutoSize = true;
            this.chk_highquality.Checked = true;
            this.chk_highquality.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_highquality.Location = new System.Drawing.Point(6, 24);
            this.chk_highquality.Name = "chk_highquality";
            this.chk_highquality.Size = new System.Drawing.Size(213, 17);
            this.chk_highquality.TabIndex = 17;
            this.chk_highquality.Text = "Choose high quality versions if available";
            this.tt_qualityExplanation.SetToolTip(this.chk_highquality, "Some songs (not all) can be downloaded in high quality. These files are usually m" +
        "uch larger than the low quality MP3, thus taking more time to download. ");
            this.chk_highquality.UseVisualStyleBackColor = true;
            this.chk_highquality.CheckedChanged += new System.EventHandler(this.chk_highquality_CheckedChanged);
            // 
            // chk_convertToMp3
            // 
            this.chk_convertToMp3.AutoSize = true;
            this.chk_convertToMp3.Checked = true;
            this.chk_convertToMp3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_convertToMp3.Location = new System.Drawing.Point(3, 3);
            this.chk_convertToMp3.Name = "chk_convertToMp3";
            this.chk_convertToMp3.Size = new System.Drawing.Size(156, 17);
            this.chk_convertToMp3.TabIndex = 18;
            this.chk_convertToMp3.Text = "Convert high quality to MP3";
            this.tt_qualityExplanation.SetToolTip(this.chk_convertToMp3, "Writing metadata to high quality files in a lossless format is problematic for so" +
        "me fields. There isn\'t a broadly used standard like ID3 for MP3.");
            this.chk_convertToMp3.UseVisualStyleBackColor = true;
            this.chk_convertToMp3.CheckedChanged += new System.EventHandler(this.chk_convertToMp3_CheckedChanged);
            // 
            // chk_replaceIllegalCharacters
            // 
            this.chk_replaceIllegalCharacters.AutoSize = true;
            this.chk_replaceIllegalCharacters.Checked = true;
            this.chk_replaceIllegalCharacters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_replaceIllegalCharacters.Location = new System.Drawing.Point(6, 93);
            this.chk_replaceIllegalCharacters.Name = "chk_replaceIllegalCharacters";
            this.chk_replaceIllegalCharacters.Size = new System.Drawing.Size(333, 17);
            this.chk_replaceIllegalCharacters.TabIndex = 22;
            this.chk_replaceIllegalCharacters.Text = "Replace illegal characters in filename with equivalent instead of _";
            this.tt_qualityExplanation.SetToolTip(this.chk_replaceIllegalCharacters, "Characters to be replaced: / ? < > \\ : * | \"\r\nWill be replaced with Halfwidth and" +
        " Fullwidth Forms\r\n");
            this.chk_replaceIllegalCharacters.UseVisualStyleBackColor = true;
            // 
            // chk_includeArtistinFilename
            // 
            this.chk_includeArtistinFilename.AutoSize = true;
            this.chk_includeArtistinFilename.Checked = true;
            this.chk_includeArtistinFilename.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_includeArtistinFilename.Location = new System.Drawing.Point(6, 70);
            this.chk_includeArtistinFilename.Name = "chk_includeArtistinFilename";
            this.chk_includeArtistinFilename.Size = new System.Drawing.Size(168, 17);
            this.chk_includeArtistinFilename.TabIndex = 20;
            this.chk_includeArtistinFilename.Text = "Include artist name in filename";
            this.chk_includeArtistinFilename.UseVisualStyleBackColor = true;
            // 
            // lbl_exclude
            // 
            this.lbl_exclude.AutoSize = true;
            this.lbl_exclude.Location = new System.Drawing.Point(51, 25);
            this.lbl_exclude.Name = "lbl_exclude";
            this.lbl_exclude.Size = new System.Drawing.Size(48, 13);
            this.lbl_exclude.TabIndex = 23;
            this.lbl_exclude.Text = "Exclude:";
            // 
            // chk_excl_m4a
            // 
            this.chk_excl_m4a.AutoSize = true;
            this.chk_excl_m4a.Location = new System.Drawing.Point(105, 25);
            this.chk_excl_m4a.Name = "chk_excl_m4a";
            this.chk_excl_m4a.Size = new System.Drawing.Size(49, 17);
            this.chk_excl_m4a.TabIndex = 24;
            this.chk_excl_m4a.Text = ".m4a";
            this.chk_excl_m4a.UseVisualStyleBackColor = true;
            // 
            // chk_exl_aac
            // 
            this.chk_exl_aac.AutoSize = true;
            this.chk_exl_aac.Location = new System.Drawing.Point(105, 44);
            this.chk_exl_aac.Name = "chk_exl_aac";
            this.chk_exl_aac.Size = new System.Drawing.Size(47, 17);
            this.chk_exl_aac.TabIndex = 25;
            this.chk_exl_aac.Text = ".aac";
            this.chk_exl_aac.UseVisualStyleBackColor = true;
            // 
            // pnl_convert
            // 
            this.pnl_convert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_convert.Controls.Add(this.chk_convertToMp3);
            this.pnl_convert.Controls.Add(this.chk_exl_aac);
            this.pnl_convert.Controls.Add(this.lbl_exclude);
            this.pnl_convert.Controls.Add(this.chk_excl_m4a);
            this.pnl_convert.Location = new System.Drawing.Point(228, 19);
            this.pnl_convert.Name = "pnl_convert";
            this.pnl_convert.Size = new System.Drawing.Size(161, 68);
            this.pnl_convert.TabIndex = 26;
            // 
            // rbttn_twoWay
            // 
            this.rbttn_twoWay.AutoSize = true;
            this.rbttn_twoWay.Location = new System.Drawing.Point(6, 39);
            this.rbttn_twoWay.Name = "rbttn_twoWay";
            this.rbttn_twoWay.Size = new System.Drawing.Size(279, 17);
            this.rbttn_twoWay.TabIndex = 28;
            this.rbttn_twoWay.Text = "Two-way sync: Locally delete songs removed from SC";
            this.rbttn_twoWay.UseVisualStyleBackColor = true;
            this.rbttn_twoWay.CheckedChanged += new System.EventHandler(this.rbttn_twoWay_CheckedChanged);
            // 
            // rbttn_oneWay
            // 
            this.rbttn_oneWay.AutoSize = true;
            this.rbttn_oneWay.Checked = true;
            this.rbttn_oneWay.Location = new System.Drawing.Point(6, 17);
            this.rbttn_oneWay.Name = "rbttn_oneWay";
            this.rbttn_oneWay.Size = new System.Drawing.Size(268, 17);
            this.rbttn_oneWay.TabIndex = 29;
            this.rbttn_oneWay.TabStop = true;
            this.rbttn_oneWay.Text = "One-way sync: Re-download locally removed songs";
            this.rbttn_oneWay.UseVisualStyleBackColor = true;
            // 
            // gbox_syncMethod
            // 
            this.gbox_syncMethod.Controls.Add(this.rbttn_oneWay);
            this.gbox_syncMethod.Controls.Add(this.rbttn_twoWay);
            this.gbox_syncMethod.Location = new System.Drawing.Point(12, 260);
            this.gbox_syncMethod.Name = "gbox_syncMethod";
            this.gbox_syncMethod.Size = new System.Drawing.Size(290, 62);
            this.gbox_syncMethod.TabIndex = 30;
            this.gbox_syncMethod.TabStop = false;
            this.gbox_syncMethod.Text = "Sync Method";
            // 
            // gbox_downMethod
            // 
            this.gbox_downMethod.Controls.Add(this.trackRadio);
            this.gbox_downMethod.Controls.Add(this.playlistRadio);
            this.gbox_downMethod.Controls.Add(this.artistRadio);
            this.gbox_downMethod.Controls.Add(this.favoritesRadio);
            this.gbox_downMethod.Location = new System.Drawing.Point(12, 138);
            this.gbox_downMethod.Name = "gbox_downMethod";
            this.gbox_downMethod.Size = new System.Drawing.Size(290, 114);
            this.gbox_downMethod.TabIndex = 31;
            this.gbox_downMethod.TabStop = false;
            this.gbox_downMethod.Text = "Download Method";
            this.gbox_downMethod.Enter += new System.EventHandler(this.gbox_downMethod_Enter);
            // 
            // trackRadio
            // 
            this.trackRadio.AutoSize = true;
            this.trackRadio.Location = new System.Drawing.Point(6, 88);
            this.trackRadio.Name = "trackRadio";
            this.trackRadio.Size = new System.Drawing.Size(212, 17);
            this.trackRadio.TabIndex = 14;
            this.trackRadio.TabStop = true;
            this.trackRadio.Text = "Single track URL (ignores sync method)";
            this.trackRadio.UseVisualStyleBackColor = true;
            // 
            // gbox_url
            // 
            this.gbox_url.Controls.Add(this.url);
            this.gbox_url.Location = new System.Drawing.Point(12, 27);
            this.gbox_url.Name = "gbox_url";
            this.gbox_url.Size = new System.Drawing.Size(397, 48);
            this.gbox_url.TabIndex = 32;
            this.gbox_url.TabStop = false;
            this.gbox_url.Text = "SoundCloud URL";
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(6, 19);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(376, 20);
            this.url.TabIndex = 0;
            // 
            // gbox_advanced
            // 
            this.gbox_advanced.Controls.Add(this.nudConcurrency);
            this.gbox_advanced.Controls.Add(this.concurrency);
            this.gbox_advanced.Controls.Add(this.chk_highquality);
            this.gbox_advanced.Controls.Add(this.chk_folderByArtist);
            this.gbox_advanced.Controls.Add(this.chk_includeArtistinFilename);
            this.gbox_advanced.Controls.Add(this.chk_replaceIllegalCharacters);
            this.gbox_advanced.Controls.Add(this.pnl_convert);
            this.gbox_advanced.Location = new System.Drawing.Point(12, 328);
            this.gbox_advanced.Name = "gbox_advanced";
            this.gbox_advanced.Size = new System.Drawing.Size(397, 149);
            this.gbox_advanced.TabIndex = 33;
            this.gbox_advanced.TabStop = false;
            this.gbox_advanced.Text = "Advanced Options";
            // 
            // nudConcurrency
            // 
            this.nudConcurrency.Location = new System.Drawing.Point(129, 116);
            this.nudConcurrency.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudConcurrency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudConcurrency.Name = "nudConcurrency";
            this.nudConcurrency.ReadOnly = true;
            this.nudConcurrency.Size = new System.Drawing.Size(45, 20);
            this.nudConcurrency.TabIndex = 30;
            this.nudConcurrency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // concurrency
            // 
            this.concurrency.AutoSize = true;
            this.concurrency.Location = new System.Drawing.Point(6, 118);
            this.concurrency.Name = "concurrency";
            this.concurrency.Size = new System.Drawing.Size(117, 13);
            this.concurrency.TabIndex = 29;
            this.concurrency.Text = "Amount of concurrency";
            // 
            // gbox_localdir
            // 
            this.gbox_localdir.Controls.Add(this.directoryPath);
            this.gbox_localdir.Controls.Add(this.browseButton);
            this.gbox_localdir.Location = new System.Drawing.Point(12, 81);
            this.gbox_localdir.Name = "gbox_localdir";
            this.gbox_localdir.Size = new System.Drawing.Size(397, 51);
            this.gbox_localdir.TabIndex = 34;
            this.gbox_localdir.TabStop = false;
            this.gbox_localdir.Text = "Local Directory";
            // 
            // directoryPath
            // 
            this.directoryPath.Location = new System.Drawing.Point(6, 19);
            this.directoryPath.Name = "directoryPath";
            this.directoryPath.Size = new System.Drawing.Size(315, 20);
            this.directoryPath.TabIndex = 5;
            // 
            // lb_progressOfTracks
            // 
            this.lb_progressOfTracks.BackColor = System.Drawing.SystemColors.Menu;
            this.lb_progressOfTracks.FormattingEnabled = true;
            this.lb_progressOfTracks.HorizontalScrollbar = true;
            this.lb_progressOfTracks.Location = new System.Drawing.Point(8, 19);
            this.lb_progressOfTracks.Name = "lb_progressOfTracks";
            this.lb_progressOfTracks.Size = new System.Drawing.Size(89, 160);
            this.lb_progressOfTracks.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_progressOfTracks);
            this.groupBox1.Location = new System.Drawing.Point(308, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 184);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Downl. Progress";
            // 
            // SoundcloudSyncMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbox_localdir);
            this.Controls.Add(this.gbox_advanced);
            this.Controls.Add(this.gbox_url);
            this.Controls.Add(this.gbox_downMethod);
            this.Controls.Add(this.gbox_syncMethod);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.syncButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SoundcloudSyncMainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_convert.ResumeLayout(false);
            this.pnl_convert.PerformLayout();
            this.gbox_syncMethod.ResumeLayout(false);
            this.gbox_syncMethod.PerformLayout();
            this.gbox_downMethod.ResumeLayout(false);
            this.gbox_downMethod.PerformLayout();
            this.gbox_url.ResumeLayout(false);
            this.gbox_url.PerformLayout();
            this.gbox_advanced.ResumeLayout(false);
            this.gbox_advanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConcurrency)).EndInit();
            this.gbox_localdir.ResumeLayout(false);
            this.gbox_localdir.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.TextBox directoryPath;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RadioButton playlistRadio;
        private System.Windows.Forms.RadioButton favoritesRadio;
        private System.Windows.Forms.RadioButton artistRadio;
        private System.Windows.Forms.CheckBox chk_folderByArtist;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox chk_highquality;
        private System.Windows.Forms.ToolTip tt_qualityExplanation;
        private System.Windows.Forms.CheckBox chk_convertToMp3;
        private System.Windows.Forms.CheckBox chk_includeArtistinFilename;
        private System.Windows.Forms.CheckBox chk_replaceIllegalCharacters;
        private System.Windows.Forms.Label lbl_exclude;
        private System.Windows.Forms.CheckBox chk_excl_m4a;
        private System.Windows.Forms.CheckBox chk_exl_aac;
        private System.Windows.Forms.Panel pnl_convert;
        private System.Windows.Forms.RadioButton rbttn_twoWay;
        private System.Windows.Forms.RadioButton rbttn_oneWay;
        private System.Windows.Forms.GroupBox gbox_syncMethod;
        private System.Windows.Forms.GroupBox gbox_downMethod;
        private System.Windows.Forms.GroupBox gbox_url;
        private System.Windows.Forms.GroupBox gbox_advanced;
        private System.Windows.Forms.GroupBox gbox_localdir;
        private System.Windows.Forms.RadioButton trackRadio;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Label concurrency;
        private System.Windows.Forms.NumericUpDown nudConcurrency;
        private System.Windows.Forms.ListBox lb_progressOfTracks;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

