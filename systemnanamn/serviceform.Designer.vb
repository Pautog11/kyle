<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class serviceform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(serviceform))
        Me.serviceadd = New Guna.UI2.WinForms.Guna2Button()
        Me.servicedelete = New Guna.UI2.WinForms.Guna2Button()
        Me.txtboxservicename = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnback = New Guna.UI2.WinForms.Guna2Button()
        Me.serviceupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.txtboxid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxserviceprice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'serviceadd
        '
        Me.serviceadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.serviceadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.serviceadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.serviceadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.serviceadd.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.serviceadd.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.serviceadd.ForeColor = System.Drawing.Color.White
        Me.serviceadd.Location = New System.Drawing.Point(175, 246)
        Me.serviceadd.Name = "serviceadd"
        Me.serviceadd.Size = New System.Drawing.Size(117, 32)
        Me.serviceadd.TabIndex = 11
        Me.serviceadd.Text = "Add"
        '
        'servicedelete
        '
        Me.servicedelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.servicedelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.servicedelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.servicedelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.servicedelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.servicedelete.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.servicedelete.ForeColor = System.Drawing.Color.White
        Me.servicedelete.Location = New System.Drawing.Point(451, 246)
        Me.servicedelete.Name = "servicedelete"
        Me.servicedelete.Size = New System.Drawing.Size(117, 32)
        Me.servicedelete.TabIndex = 13
        Me.servicedelete.Text = "Delete"
        '
        'txtboxservicename
        '
        Me.txtboxservicename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxservicename.DefaultText = ""
        Me.txtboxservicename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxservicename.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxservicename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxservicename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxservicename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxservicename.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txtboxservicename.ForeColor = System.Drawing.Color.Black
        Me.txtboxservicename.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxservicename.Location = New System.Drawing.Point(173, 106)
        Me.txtboxservicename.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxservicename.Name = "txtboxservicename"
        Me.txtboxservicename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtboxservicename.PlaceholderText = ""
        Me.txtboxservicename.SelectedText = ""
        Me.txtboxservicename.Size = New System.Drawing.Size(393, 36)
        Me.txtboxservicename.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Service name:"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.btnback)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(625, 41)
        Me.Guna2Panel2.TabIndex = 16
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
        'serviceupdate
        '
        Me.serviceupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.serviceupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.serviceupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.serviceupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.serviceupdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.serviceupdate.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.serviceupdate.ForeColor = System.Drawing.Color.White
        Me.serviceupdate.Location = New System.Drawing.Point(312, 246)
        Me.serviceupdate.Name = "serviceupdate"
        Me.serviceupdate.Size = New System.Drawing.Size(117, 32)
        Me.serviceupdate.TabIndex = 17
        Me.serviceupdate.Text = "Update"
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
        Me.txtboxid.Location = New System.Drawing.Point(173, 63)
        Me.txtboxid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxid.Name = "txtboxid"
        Me.txtboxid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtboxid.PlaceholderText = ""
        Me.txtboxid.SelectedText = ""
        Me.txtboxid.Size = New System.Drawing.Size(36, 33)
        Me.txtboxid.TabIndex = 18
        Me.txtboxid.Visible = False
        '
        'txtboxserviceprice
        '
        Me.txtboxserviceprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxserviceprice.DefaultText = ""
        Me.txtboxserviceprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxserviceprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxserviceprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxserviceprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxserviceprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxserviceprice.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.txtboxserviceprice.ForeColor = System.Drawing.Color.Black
        Me.txtboxserviceprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxserviceprice.Location = New System.Drawing.Point(175, 167)
        Me.txtboxserviceprice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxserviceprice.Name = "txtboxserviceprice"
        Me.txtboxserviceprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtboxserviceprice.PlaceholderText = ""
        Me.txtboxserviceprice.SelectedText = ""
        Me.txtboxserviceprice.Size = New System.Drawing.Size(393, 36)
        Me.txtboxserviceprice.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Price:"
        '
        'serviceform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(625, 329)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtboxserviceprice)
        Me.Controls.Add(Me.txtboxid)
        Me.Controls.Add(Me.serviceupdate)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtboxservicename)
        Me.Controls.Add(Me.servicedelete)
        Me.Controls.Add(Me.serviceadd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "serviceform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "serviceform"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents serviceadd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents servicedelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtboxservicename As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents serviceupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtboxid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxserviceprice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
End Class
