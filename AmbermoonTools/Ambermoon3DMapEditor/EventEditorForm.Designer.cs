﻿namespace Ambermoon3DMapEditor
{
    partial class EventEditorForm
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
            eventEditor = new AmbermoonUIEventEditor.EventEditorControl();
            SuspendLayout();
            // 
            // eventEditor
            // 
            eventEditor.Dock = DockStyle.Fill;
            eventEditor.Location = new Point(0, 0);
            eventEditor.Name = "eventEditor";
            eventEditor.ShowCharEvents = false;
            eventEditor.ShowMapEvents = true;
            eventEditor.Size = new Size(800, 450);
            eventEditor.TabIndex = 0;
            // 
            // EventEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(eventEditor);
            MinimumSize = new Size(400, 400);
            Name = "EventEditorForm";
            Text = "Event Editor";
            ResumeLayout(false);
        }

        #endregion

        private AmbermoonUIEventEditor.EventEditorControl eventEditor;
    }
}