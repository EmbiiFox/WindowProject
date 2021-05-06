
namespace test
{
    partial class frmFluentMain
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
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.ctrlDashboard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.ctrlStudents = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ctrlBooks = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CtrlLogOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ctrlTypeBooks = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ctrlAddBooks = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ctrEditBooks = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ctrManageBooks = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ctrlTimeWorks = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(431, 434);
            this.fluentDesignFormContainer1.TabIndex = 0;
            this.fluentDesignFormContainer1.Click += new System.EventHandler(this.fluentDesignFormContainer1_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ctrlDashboard,
            this.ctrlStudents,
            this.ctrlBooks,
            this.ctrlTimeWorks,
            this.CtrlLogOut});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 434);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // ctrlDashboard
            // 
            this.ctrlDashboard.Name = "ctrlDashboard";
            this.ctrlDashboard.Text = "Dashboard";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(691, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // ctrlStudents
            // 
            this.ctrlStudents.Name = "ctrlStudents";
            this.ctrlStudents.Text = "Students";
            // 
            // ctrlBooks
            // 
            this.ctrlBooks.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ctrlTypeBooks,
            this.ctrlAddBooks,
            this.ctrEditBooks,
            this.ctrManageBooks});
            this.ctrlBooks.Expanded = true;
            this.ctrlBooks.Name = "ctrlBooks";
            this.ctrlBooks.Text = "Books";
            // 
            // CtrlLogOut
            // 
            this.CtrlLogOut.Expanded = true;
            this.CtrlLogOut.Name = "CtrlLogOut";
            this.CtrlLogOut.Text = "Log Out";
            // 
            // ctrlTypeBooks
            // 
            this.ctrlTypeBooks.Name = "ctrlTypeBooks";
            this.ctrlTypeBooks.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ctrlTypeBooks.Text = "Type Of Books";
            // 
            // ctrlAddBooks
            // 
            this.ctrlAddBooks.Name = "ctrlAddBooks";
            this.ctrlAddBooks.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ctrlAddBooks.Text = "Add Books";
            // 
            // ctrEditBooks
            // 
            this.ctrEditBooks.Name = "ctrEditBooks";
            this.ctrEditBooks.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ctrEditBooks.Text = "Edit Books";
            // 
            // ctrManageBooks
            // 
            this.ctrManageBooks.Name = "ctrManageBooks";
            this.ctrManageBooks.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ctrManageBooks.Text = "Manage Books";
            // 
            // ctrlTimeWorks
            // 
            this.ctrlTimeWorks.Name = "ctrlTimeWorks";
            this.ctrlTimeWorks.Text = "TimeWorks";
            // 
            // frmFluentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 473);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmFluentMain";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Library";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctrlDashboard;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctrlStudents;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctrlBooks;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctrlTypeBooks;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctrlAddBooks;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctrEditBooks;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctrManageBooks;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctrlTimeWorks;
        private DevExpress.XtraBars.Navigation.AccordionControlElement CtrlLogOut;
    }
}