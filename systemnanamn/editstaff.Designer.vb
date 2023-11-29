<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editstaff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editstaff))
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnback = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxstaffln = New Guna.UI2.WinForms.Guna2TextBox()
        Me.staffupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxstaffname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.staffdelete = New Guna.UI2.WinForms.Guna2Button()
        Me.staffadd = New Guna.UI2.WinForms.Guna2Button()
        Me.txtboxid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.btnback)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(604, 41)
        Me.Guna2Panel2.TabIndex = 17
        '
        'btnback
        '
        Me.btnback.Animated = True
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.BorderColor = System.Drawing.Color.Transparent
        Me.btnback.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnback.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnback.FillColor = System.Drawing.Color.Transparent
        Me.btnback.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.White
        Me.btnback.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.btnback.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnback.HoverState.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Image = CType(resources.GetObject("btnback.Image"), System.Drawing.Image)
        Me.btnback.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnback.ImageSize = New System.Drawing.Size(10, 10)
        Me.btnback.Location = New System.Drawing.Point(4, 5)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(83, 34)
        Me.btnback.TabIndex = 9
        Me.btnback.Text = "Back"
        Me.btnback.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnback.UseTransparentBackground = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Last Name:"
        '
        'txtboxstaffln
        '
        Me.txtboxstaffln.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxstaffln.DefaultText = ""
        Me.txtboxstaffln.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxstaffln.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxstaffln.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxstaffln.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxstaffln.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxstaffln.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txtboxstaffln.ForeColor = System.Drawing.Color.Black
        Me.txtboxstaffln.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxstaffln.Location = New System.Drawing.Point(165, 172)
        Me.txtboxstaffln.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxstaffln.Name = "txtboxstaffln"
        Me.txtboxstaffln.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtboxstaffln.PlaceholderText = ""
        Me.txtboxstaffln.SelectedText = ""
        Me.txtboxstaffln.Size = New System.Drawing.Size(393, 36)
        Me.txtboxstaffln.TabIndex = 26
        '
        'staffupdate
        '
        Me.staffupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.staffupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.staffupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.staffupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.staffupdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.staffupdate.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.staffupdate.ForeColor = System.Drawing.Color.White
        Me.staffupdate.Location = New System.Drawing.Point(302, 251)
        Me.staffupdate.Name = "staffupdate"
        Me.staffupdate.Size = New System.Drawing.Size(117, 32)
        Me.staffupdate.TabIndex = 25
        Me.staffupdate.Text = "Update"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "First name:"
        '
        'txtboxstaffname
        '
        Me.txtboxstaffname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxstaffname.DefaultText = ""
        Me.txtboxstaffname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxstaffname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxstaffname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxstaffname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxstaffname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxstaffname.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txtboxstaffname.ForeColor = System.Drawing.Color.Black
        Me.txtboxstaffname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxstaffname.Location = New System.Drawing.Point(163, 111)
        Me.txtboxstaffname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxstaffname.Name = "txtboxstaffname"
        Me.txtboxstaffname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtboxstaffname.PlaceholderText = ""
        Me.txtboxstaffname.SelectedText = ""
        Me.txtboxstaffname.Size = New System.Drawing.Size(393, 36)
        Me.txtboxstaffname.TabIndex = 23
        '
        'staffdelete
        '
        Me.staffdelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.staffdelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.staffdelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.staffdelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.staffdelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.staffdelete.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.staffdelete.ForeColor = System.Drawing.Color.White
        Me.staffdelete.Location = New System.Drawing.Point(441, 251)
        Me.staffdelete.Name = "staffdelete"
        Me.staffdelete.Size = New System.Drawing.Size(117, 32)
        Me.staffdelete.TabIndex = 22
        Me.staffdelete.Text = "Delete"
        '
        'staffadd
        '
        Me.staffadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.staffadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.staffadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.staffadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.staffadd.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.staffadd.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.staffadd.ForeColor = System.Drawing.Color.White
        Me.staffadd.Location = New System.Drawing.Point(165, 251)
        Me.staffadd.Name = "staffadd"
        Me.staffadd.Size = New System.Drawing.Size(117, 32)
        Me.staffadd.TabIndex = 21
        Me.staffadd.Text = "Add"
        '
        'txtboxid
        '
        Me.txtboxid.BorderThickness = 0
        Me.txtboxid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxid.DefaultText = ""
        Me.txtboxid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxid.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txtboxid.ForeColor = System.Drawing.Color.Black
        Me.txtboxid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxid.Location = New System.Drawing.Point(163, 68)
        Me.txtboxid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxid.Name = "txtboxid"
        Me.txtboxid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtboxid.PlaceholderText = ""
        Me.txtboxid.SelectedText = ""
        Me.txtboxid.Size = New System.Drawing.Size(36, 33)
        Me.txtboxid.TabIndex = 28
        Me.txtboxid.Visible = False
        '
        'editstaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(604, 345)
        Me.Controls.Add(Me.txtboxid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtboxstaffln)
        Me.Controls.Add(Me.staffupdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtboxstaffname)
        Me.Controls.Add(Me.staffdelete)
        Me.Controls.Add(Me.staffadd)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "editstaff"
        Me.Text = "editstaff"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxstaffln As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents staffupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxstaffname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents staffdelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents staffadd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtboxid As Guna.UI2.WinForms.Guna2TextBox
End Class
