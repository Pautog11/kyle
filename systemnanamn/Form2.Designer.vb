<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnsetting = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.mainpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnreports = New Guna.UI2.WinForms.Guna2Button()
        Me.btnbooking = New Guna.UI2.WinForms.Guna2Button()
        Me.btntask = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.btnsetting)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1520, 51)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-69, -49)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(311, 152)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        '
        'btnsetting
        '
        Me.btnsetting.Animated = True
        Me.btnsetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsetting.FillColor = System.Drawing.Color.Transparent
        Me.btnsetting.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnsetting.ForeColor = System.Drawing.Color.White
        Me.btnsetting.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnsetting.Image = CType(resources.GetObject("btnsetting.Image"), System.Drawing.Image)
        Me.btnsetting.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnsetting.Location = New System.Drawing.Point(1478, 12)
        Me.btnsetting.Name = "btnsetting"
        Me.btnsetting.Size = New System.Drawing.Size(30, 30)
        Me.btnsetting.TabIndex = 0
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2CustomGradientPanel1.BorderThickness = 1
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.mainpanel)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2CustomGradientPanel1.CustomBorderThickness = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1520, 765)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'mainpanel
        '
        Me.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainpanel.Location = New System.Drawing.Point(234, 51)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(1286, 714)
        Me.mainpanel.TabIndex = 2
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2Panel2.Controls.Add(Me.btnbooking)
        Me.Guna2Panel2.Controls.Add(Me.btnreports)
        Me.Guna2Panel2.Controls.Add(Me.btntask)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(234, 714)
        Me.Guna2Panel2.TabIndex = 3
        '
        'btnreports
        '
        Me.btnreports.Animated = True
        Me.btnreports.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btnreports.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnreports.CheckedState.Font = New System.Drawing.Font("Standerd Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreports.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnreports.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btnreports.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnreports.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnreports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnreports.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnreports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnreports.FillColor = System.Drawing.Color.White
        Me.btnreports.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnreports.Font = New System.Drawing.Font("Standerd Free", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnreports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnreports.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnreports.HoverState.Font = New System.Drawing.Font("Standerd Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreports.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnreports.Location = New System.Drawing.Point(3, 147)
        Me.btnreports.Name = "btnreports"
        Me.btnreports.PressedColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnreports.Size = New System.Drawing.Size(231, 53)
        Me.btnreports.TabIndex = 4
        Me.btnreports.Text = "Reports"
        Me.btnreports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnbooking
        '
        Me.btnbooking.Animated = True
        Me.btnbooking.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btnbooking.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnbooking.CheckedState.Font = New System.Drawing.Font("Standerd Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbooking.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnbooking.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btnbooking.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnbooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnbooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnbooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnbooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnbooking.FillColor = System.Drawing.Color.White
        Me.btnbooking.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnbooking.Font = New System.Drawing.Font("Standerd Free", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnbooking.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnbooking.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnbooking.HoverState.Font = New System.Drawing.Font("Standerd Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbooking.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnbooking.Location = New System.Drawing.Point(3, 58)
        Me.btnbooking.Name = "btnbooking"
        Me.btnbooking.PressedColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnbooking.Size = New System.Drawing.Size(231, 53)
        Me.btnbooking.TabIndex = 3
        Me.btnbooking.Text = "Bookings"
        Me.btnbooking.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btntask
        '
        Me.btntask.Animated = True
        Me.btntask.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btntask.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btntask.CheckedState.Font = New System.Drawing.Font("Standerd Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntask.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btntask.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btntask.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btntask.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btntask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btntask.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btntask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btntask.FillColor = System.Drawing.Color.White
        Me.btntask.FocusedColor = System.Drawing.Color.Black
        Me.btntask.Font = New System.Drawing.Font("Standerd Free", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btntask.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btntask.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btntask.HoverState.Font = New System.Drawing.Font("Standerd Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntask.HoverState.ForeColor = System.Drawing.Color.White
        Me.btntask.Location = New System.Drawing.Point(3, 100)
        Me.btntask.Name = "btntask"
        Me.btntask.PressedColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btntask.Size = New System.Drawing.Size(231, 53)
        Me.btntask.TabIndex = 2
        Me.btntask.Text = "Tasks"
        Me.btntask.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1520, 765)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnsetting As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents mainpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnreports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnbooking As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btntask As Guna.UI2.WinForms.Guna2Button
End Class
