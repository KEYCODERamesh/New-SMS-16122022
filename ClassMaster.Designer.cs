
namespace SMS
{
    partial class ClassMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassMaster));
            this.TopCtrl = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnMoveFirst = new System.Windows.Forms.ToolStripButton();
            this.bnMovePrevious = new System.Windows.Forms.ToolStripButton();
            this.bnMoveNext = new System.Windows.Forms.ToolStripButton();
            this.bnMoveLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTypeToSearch = new System.Windows.Forms.ToolStripLabel();
            this.txtFind = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TopCtrl)).BeginInit();
            this.TopCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopCtrl
            // 
            this.TopCtrl.AddNewItem = null;
            this.TopCtrl.BackColor = System.Drawing.Color.LightGray;
            this.TopCtrl.CountItem = null;
            this.TopCtrl.DeleteItem = null;
            this.TopCtrl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnMoveFirst,
            this.bnMovePrevious,
            this.bnMoveNext,
            this.bnMoveLast,
            this.bindingNavigatorSeparator2,
            this.bnPrint,
            this.toolStripSeparator1,
            this.lblTypeToSearch,
            this.txtFind});
            this.TopCtrl.Location = new System.Drawing.Point(0, 0);
            this.TopCtrl.MoveFirstItem = null;
            this.TopCtrl.MoveLastItem = null;
            this.TopCtrl.MoveNextItem = null;
            this.TopCtrl.MovePreviousItem = null;
            this.TopCtrl.Name = "TopCtrl";
            this.TopCtrl.PositionItem = null;
            this.TopCtrl.Size = new System.Drawing.Size(468, 25);
            this.TopCtrl.TabIndex = 2;
            this.TopCtrl.Text = "bindingNavigator1";
            // 
            // bnMoveFirst
            // 
            this.bnMoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnMoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("bnMoveFirst.Image")));
            this.bnMoveFirst.Name = "bnMoveFirst";
            this.bnMoveFirst.RightToLeftAutoMirrorImage = true;
            this.bnMoveFirst.Size = new System.Drawing.Size(23, 22);
            this.bnMoveFirst.Text = "Move first";
            // 
            // bnMovePrevious
            // 
            this.bnMovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnMovePrevious.Image = ((System.Drawing.Image)(resources.GetObject("bnMovePrevious.Image")));
            this.bnMovePrevious.Name = "bnMovePrevious";
            this.bnMovePrevious.RightToLeftAutoMirrorImage = true;
            this.bnMovePrevious.Size = new System.Drawing.Size(23, 22);
            this.bnMovePrevious.Text = "Move previous";
            // 
            // bnMoveNext
            // 
            this.bnMoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnMoveNext.Image = ((System.Drawing.Image)(resources.GetObject("bnMoveNext.Image")));
            this.bnMoveNext.Name = "bnMoveNext";
            this.bnMoveNext.RightToLeftAutoMirrorImage = true;
            this.bnMoveNext.Size = new System.Drawing.Size(23, 22);
            this.bnMoveNext.Text = "Move next";
            // 
            // bnMoveLast
            // 
            this.bnMoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnMoveLast.Image = ((System.Drawing.Image)(resources.GetObject("bnMoveLast.Image")));
            this.bnMoveLast.Name = "bnMoveLast";
            this.bnMoveLast.RightToLeftAutoMirrorImage = true;
            this.bnMoveLast.Size = new System.Drawing.Size(23, 22);
            this.bnMoveLast.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bnPrint
            // 
            this.bnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnPrint.Image = ((System.Drawing.Image)(resources.GetObject("bnPrint.Image")));
            this.bnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnPrint.Name = "bnPrint";
            this.bnPrint.Size = new System.Drawing.Size(23, 22);
            this.bnPrint.Text = "Print";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblTypeToSearch
            // 
            this.lblTypeToSearch.Name = "lblTypeToSearch";
            this.lblTypeToSearch.Size = new System.Drawing.Size(108, 22);
            this.lblTypeToSearch.Text = "Type here to search";
            this.lblTypeToSearch.ToolTipText = "Type here to search";
            // 
            // txtFind
            // 
            this.txtFind.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.txtFind.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.Black;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(200, 25);
            this.txtFind.ToolTipText = "Type here to search";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(11, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 410);
            this.panel1.TabIndex = 3;
            // 
            // ClassMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopCtrl);
            this.Name = "ClassMaster";
            this.Text = "Class Master";
            ((System.ComponentModel.ISupportInitialize)(this.TopCtrl)).EndInit();
            this.TopCtrl.ResumeLayout(false);
            this.TopCtrl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator TopCtrl;
        private System.Windows.Forms.ToolStripButton bnMoveFirst;
        private System.Windows.Forms.ToolStripButton bnMovePrevious;
        private System.Windows.Forms.ToolStripButton bnMoveNext;
        private System.Windows.Forms.ToolStripButton bnMoveLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bnPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblTypeToSearch;
        private System.Windows.Forms.ToolStripTextBox txtFind;
        private System.Windows.Forms.Panel panel1;
    }
}