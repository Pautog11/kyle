<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addonform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addonform))
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnback = New Guna.UI2.WinForms.Guna2Button()
        Me.serviceaddon = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbaddontype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxaddonprice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.btnback)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(533, 41)
        Me.Guna2Panel2.TabIndex = 23
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
        'serviceaddon
        '
        Me.serviceaddon.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.serviceaddon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.serviceaddon.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.serviceaddon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.serviceaddon.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.serviceaddon.Font = New System.Drawing.Font("Tahoma", 10.2!)
        Me.serviceaddon.ForeColor = System.Drawing.Color.White
        Me.serviceaddon.Location = New System.Drawing.Point(352, 196)
        Me.serviceaddon.Name = "serviceaddon"
        Me.serviceaddon.Size = New System.Drawing.Size(117, 32)
        Me.serviceaddon.TabIndex = 19
        Me.serviceaddon.Text = "Add"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Type:"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.txtboxaddonprice)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.cmbaddontype)
        Me.Guna2Panel1.Controls.Add(Me.serviceaddon)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(533, 248)
        Me.Guna2Panel1.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(175, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Add another service:"
        '
        'cmbaddontype
        '
        Me.cmbaddontype.BackColor = System.Drawing.Color.Transparent
        Me.cmbaddontype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbaddontype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaddontype.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbaddontype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbaddontype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbaddontype.ForeColor = System.Drawing.Color.Black
        Me.cmbaddontype.ItemHeight = 30
        Me.cmbaddontype.Location = New System.Drawing.Point(145, 115)
        Me.cmbaddontype.Name = "cmbaddontype"
        Me.cmbaddontype.Size = New System.Drawing.Size(324, 36)
        Me.cmbaddontype.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Price:"
        Me.Label1.Visible = False
        '
        'txtboxaddonprice
        '
        Me.txtboxaddonprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxaddonprice.DefaultText = ""
        Me.txtboxaddonprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxaddonprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxaddonprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxaddonprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxaddonprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxaddonprice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxaddonprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxaddonprice.Location = New System.Drawing.Point(145, 203)
        Me.txtboxaddonprice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtboxaddonprice.Name = "txtboxaddonprice"
        Me.txtboxaddonprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtboxaddonprice.PlaceholderText = ""
        Me.txtboxaddonprice.SelectedText = ""
        Me.txtboxaddonprice.Size = New System.Drawing.Size(54, 32)
        Me.txtboxaddonprice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtboxaddonprice.TabIndex = 31
        Me.txtboxaddonprice.Visible = False
        '
        'addonform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(533, 248)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "addonform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addonform"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents serviceaddon As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmbaddontype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxaddonprice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
End Class
