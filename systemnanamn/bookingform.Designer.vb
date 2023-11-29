<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bookingform
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.monthcontainer = New System.Windows.Forms.Panel()
        Me.weekcontainer = New System.Windows.Forms.Panel()
        Me.daycontainerrow1 = New System.Windows.Forms.Panel()
        Me.daycontainerrow3 = New System.Windows.Forms.Panel()
        Me.daycontainerrow4 = New System.Windows.Forms.Panel()
        Me.daycontainerrow5 = New System.Windows.Forms.Panel()
        Me.daycontainerrow6 = New System.Windows.Forms.Panel()
        Me.daycontainerrow2 = New System.Windows.Forms.Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Customer_table1TableAdapter1 = New systemnanamn.user_accDataSet3TableAdapters.customer_table1TableAdapter()
        Me.User_accDataSet31 = New systemnanamn.user_accDataSet3()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.User_accDataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.White
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.Location = New System.Drawing.Point(1150, 22)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(113, 37)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "Add +"
        '
        'monthcontainer
        '
        Me.monthcontainer.BackColor = System.Drawing.Color.White
        Me.monthcontainer.Location = New System.Drawing.Point(34, 60)
        Me.monthcontainer.Name = "monthcontainer"
        Me.monthcontainer.Size = New System.Drawing.Size(1224, 60)
        Me.monthcontainer.TabIndex = 2
        '
        'weekcontainer
        '
        Me.weekcontainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.weekcontainer.Location = New System.Drawing.Point(34, 134)
        Me.weekcontainer.Name = "weekcontainer"
        Me.weekcontainer.Size = New System.Drawing.Size(1224, 44)
        Me.weekcontainer.TabIndex = 3
        '
        'daycontainerrow1
        '
        Me.daycontainerrow1.BackColor = System.Drawing.Color.White
        Me.daycontainerrow1.Location = New System.Drawing.Point(37, 201)
        Me.daycontainerrow1.Name = "daycontainerrow1"
        Me.daycontainerrow1.Size = New System.Drawing.Size(1224, 77)
        Me.daycontainerrow1.TabIndex = 3
        '
        'daycontainerrow3
        '
        Me.daycontainerrow3.BackColor = System.Drawing.Color.White
        Me.daycontainerrow3.Location = New System.Drawing.Point(37, 367)
        Me.daycontainerrow3.Name = "daycontainerrow3"
        Me.daycontainerrow3.Size = New System.Drawing.Size(1224, 77)
        Me.daycontainerrow3.TabIndex = 3
        '
        'daycontainerrow4
        '
        Me.daycontainerrow4.BackColor = System.Drawing.Color.White
        Me.daycontainerrow4.Location = New System.Drawing.Point(37, 450)
        Me.daycontainerrow4.Name = "daycontainerrow4"
        Me.daycontainerrow4.Size = New System.Drawing.Size(1224, 77)
        Me.daycontainerrow4.TabIndex = 3
        '
        'daycontainerrow5
        '
        Me.daycontainerrow5.BackColor = System.Drawing.Color.White
        Me.daycontainerrow5.Location = New System.Drawing.Point(37, 533)
        Me.daycontainerrow5.Name = "daycontainerrow5"
        Me.daycontainerrow5.Size = New System.Drawing.Size(1224, 77)
        Me.daycontainerrow5.TabIndex = 3
        '
        'daycontainerrow6
        '
        Me.daycontainerrow6.BackColor = System.Drawing.Color.White
        Me.daycontainerrow6.Location = New System.Drawing.Point(37, 616)
        Me.daycontainerrow6.Name = "daycontainerrow6"
        Me.daycontainerrow6.Size = New System.Drawing.Size(1224, 77)
        Me.daycontainerrow6.TabIndex = 3
        '
        'daycontainerrow2
        '
        Me.daycontainerrow2.BackColor = System.Drawing.Color.White
        Me.daycontainerrow2.Location = New System.Drawing.Point(37, 284)
        Me.daycontainerrow2.Name = "daycontainerrow2"
        Me.daycontainerrow2.Size = New System.Drawing.Size(1224, 77)
        Me.daycontainerrow2.TabIndex = 3
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1283, 714)
        Me.Guna2Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Customer_table1TableAdapter1
        '
        Me.Customer_table1TableAdapter1.ClearBeforeFill = True
        '
        'User_accDataSet31
        '
        Me.User_accDataSet31.DataSetName = "user_accDataSet3"
        Me.User_accDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'bookingform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1283, 714)
        Me.Controls.Add(Me.daycontainerrow5)
        Me.Controls.Add(Me.daycontainerrow2)
        Me.Controls.Add(Me.daycontainerrow6)
        Me.Controls.Add(Me.daycontainerrow4)
        Me.Controls.Add(Me.daycontainerrow3)
        Me.Controls.Add(Me.daycontainerrow1)
        Me.Controls.Add(Me.weekcontainer)
        Me.Controls.Add(Me.monthcontainer)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bookingform"
        Me.Text = "bookingform"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.User_accDataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents monthcontainer As Panel
    Friend WithEvents weekcontainer As Panel
    Friend WithEvents daycontainerrow1 As Panel
    Friend WithEvents daycontainerrow3 As Panel
    Friend WithEvents daycontainerrow4 As Panel
    Friend WithEvents daycontainerrow5 As Panel
    Friend WithEvents daycontainerrow6 As Panel
    Friend WithEvents daycontainerrow2 As Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Customer_table1TableAdapter1 As user_accDataSet3TableAdapters.customer_table1TableAdapter
    Friend WithEvents User_accDataSet31 As user_accDataSet3
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
