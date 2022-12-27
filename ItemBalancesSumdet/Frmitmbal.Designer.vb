<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmitmbal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmitmbal))
        Me.Butexit = New System.Windows.Forms.Button()
        Me.DTPupdate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Btdit = New System.Windows.Forms.Button()
        Me.Txttoitem = New System.Windows.Forms.TextBox()
        Me.Bfdit = New System.Windows.Forms.Button()
        Me.Txtfrmitem = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btdcat = New System.Windows.Forms.Button()
        Me.Txttocat = New System.Windows.Forms.TextBox()
        Me.Bfdcat = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txtfrmcat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Butprint = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btdloc = New System.Windows.Forms.Button()
        Me.Txttoloc = New System.Windows.Forms.TextBox()
        Me.bfdloc = New System.Windows.Forms.Button()
        Me.Txtfrmloc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Butexit
        '
        Me.Butexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butexit.Location = New System.Drawing.Point(293, 383)
        Me.Butexit.Name = "Butexit"
        Me.Butexit.Size = New System.Drawing.Size(80, 38)
        Me.Butexit.TabIndex = 45
        Me.Butexit.Text = "Exit"
        Me.Butexit.UseVisualStyleBackColor = True
        '
        'DTPupdate
        '
        Me.DTPupdate.Location = New System.Drawing.Point(105, 25)
        Me.DTPupdate.Name = "DTPupdate"
        Me.DTPupdate.Size = New System.Drawing.Size(267, 23)
        Me.DTPupdate.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Up To Date"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DTPupdate)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(14, 285)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(400, 59)
        Me.GroupBox5.TabIndex = 42
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Date"
        '
        'Btdit
        '
        Me.Btdit.BackColor = System.Drawing.SystemColors.Control
        Me.Btdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btdit.Image = CType(resources.GetObject("Btdit.Image"), System.Drawing.Image)
        Me.Btdit.Location = New System.Drawing.Point(348, 43)
        Me.Btdit.Name = "Btdit"
        Me.Btdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btdit.Size = New System.Drawing.Size(25, 24)
        Me.Btdit.TabIndex = 31
        Me.Btdit.TabStop = False
        Me.Btdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btdit.UseVisualStyleBackColor = False
        '
        'Txttoitem
        '
        Me.Txttoitem.Location = New System.Drawing.Point(100, 44)
        Me.Txttoitem.Name = "Txttoitem"
        Me.Txttoitem.Size = New System.Drawing.Size(250, 23)
        Me.Txttoitem.TabIndex = 3
        '
        'Bfdit
        '
        Me.Bfdit.BackColor = System.Drawing.SystemColors.Control
        Me.Bfdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.Bfdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bfdit.Image = CType(resources.GetObject("Bfdit.Image"), System.Drawing.Image)
        Me.Bfdit.Location = New System.Drawing.Point(348, 19)
        Me.Bfdit.Name = "Bfdit"
        Me.Bfdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Bfdit.Size = New System.Drawing.Size(24, 22)
        Me.Bfdit.TabIndex = 30
        Me.Bfdit.TabStop = False
        Me.Bfdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bfdit.UseVisualStyleBackColor = False
        '
        'Txtfrmitem
        '
        Me.Txtfrmitem.Location = New System.Drawing.Point(100, 19)
        Me.Txtfrmitem.Name = "Txtfrmitem"
        Me.Txtfrmitem.Size = New System.Drawing.Size(250, 23)
        Me.Txtfrmitem.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "To"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "From "
        '
        'Btdcat
        '
        Me.Btdcat.BackColor = System.Drawing.SystemColors.Control
        Me.Btdcat.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btdcat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btdcat.Image = CType(resources.GetObject("Btdcat.Image"), System.Drawing.Image)
        Me.Btdcat.Location = New System.Drawing.Point(348, 43)
        Me.Btdcat.Name = "Btdcat"
        Me.Btdcat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btdcat.Size = New System.Drawing.Size(25, 24)
        Me.Btdcat.TabIndex = 31
        Me.Btdcat.TabStop = False
        Me.Btdcat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btdcat.UseVisualStyleBackColor = False
        '
        'Txttocat
        '
        Me.Txttocat.Location = New System.Drawing.Point(100, 44)
        Me.Txttocat.Name = "Txttocat"
        Me.Txttocat.Size = New System.Drawing.Size(250, 23)
        Me.Txttocat.TabIndex = 3
        '
        'Bfdcat
        '
        Me.Bfdcat.BackColor = System.Drawing.SystemColors.Control
        Me.Bfdcat.Cursor = System.Windows.Forms.Cursors.Default
        Me.Bfdcat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bfdcat.Image = CType(resources.GetObject("Bfdcat.Image"), System.Drawing.Image)
        Me.Bfdcat.Location = New System.Drawing.Point(348, 19)
        Me.Bfdcat.Name = "Bfdcat"
        Me.Bfdcat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Bfdcat.Size = New System.Drawing.Size(24, 22)
        Me.Bfdcat.TabIndex = 30
        Me.Bfdcat.TabStop = False
        Me.Bfdcat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bfdcat.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btdit)
        Me.GroupBox4.Controls.Add(Me.Txttoitem)
        Me.GroupBox4.Controls.Add(Me.Bfdit)
        Me.GroupBox4.Controls.Add(Me.Txtfrmitem)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(14, 195)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 75)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Item"
        '
        'Txtfrmcat
        '
        Me.Txtfrmcat.Location = New System.Drawing.Point(100, 19)
        Me.Txtfrmcat.Name = "Txtfrmcat"
        Me.Txtfrmcat.Size = New System.Drawing.Size(250, 23)
        Me.Txtfrmcat.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "From "
        '
        'Butprint
        '
        Me.Butprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butprint.Location = New System.Drawing.Point(50, 383)
        Me.Butprint.Name = "Butprint"
        Me.Butprint.Size = New System.Drawing.Size(80, 38)
        Me.Butprint.TabIndex = 44
        Me.Butprint.Text = "Print"
        Me.Butprint.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btdcat)
        Me.GroupBox3.Controls.Add(Me.Txttocat)
        Me.GroupBox3.Controls.Add(Me.Bfdcat)
        Me.GroupBox3.Controls.Add(Me.Txtfrmcat)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(14, 105)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 75)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "To"
        '
        'btdloc
        '
        Me.btdloc.BackColor = System.Drawing.SystemColors.Control
        Me.btdloc.Cursor = System.Windows.Forms.Cursors.Default
        Me.btdloc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btdloc.Image = CType(resources.GetObject("btdloc.Image"), System.Drawing.Image)
        Me.btdloc.Location = New System.Drawing.Point(348, 43)
        Me.btdloc.Name = "btdloc"
        Me.btdloc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btdloc.Size = New System.Drawing.Size(25, 24)
        Me.btdloc.TabIndex = 31
        Me.btdloc.TabStop = False
        Me.btdloc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdloc.UseVisualStyleBackColor = False
        '
        'Txttoloc
        '
        Me.Txttoloc.Location = New System.Drawing.Point(100, 44)
        Me.Txttoloc.Name = "Txttoloc"
        Me.Txttoloc.Size = New System.Drawing.Size(250, 23)
        Me.Txttoloc.TabIndex = 3
        '
        'bfdloc
        '
        Me.bfdloc.BackColor = System.Drawing.SystemColors.Control
        Me.bfdloc.Cursor = System.Windows.Forms.Cursors.Default
        Me.bfdloc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bfdloc.Image = CType(resources.GetObject("bfdloc.Image"), System.Drawing.Image)
        Me.bfdloc.Location = New System.Drawing.Point(348, 19)
        Me.bfdloc.Name = "bfdloc"
        Me.bfdloc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bfdloc.Size = New System.Drawing.Size(24, 22)
        Me.bfdloc.TabIndex = 30
        Me.bfdloc.TabStop = False
        Me.bfdloc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bfdloc.UseVisualStyleBackColor = False
        '
        'Txtfrmloc
        '
        Me.Txtfrmloc.Location = New System.Drawing.Point(100, 19)
        Me.Txtfrmloc.Name = "Txtfrmloc"
        Me.Txtfrmloc.Size = New System.Drawing.Size(250, 23)
        Me.Txtfrmloc.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btdloc)
        Me.GroupBox2.Controls.Add(Me.Txttoloc)
        Me.GroupBox2.Controls.Add(Me.bfdloc)
        Me.GroupBox2.Controls.Add(Me.Txtfrmloc)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 75)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Location"
        '
        'Frmitmbal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 436)
        Me.Controls.Add(Me.Butexit)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Butprint)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmitmbal"
        Me.Text = "Itam Balance Cut Of Date"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Butexit As System.Windows.Forms.Button
    Friend WithEvents DTPupdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Public WithEvents Btdit As System.Windows.Forms.Button
    Friend WithEvents Txttoitem As System.Windows.Forms.TextBox
    Public WithEvents Bfdit As System.Windows.Forms.Button
    Friend WithEvents Txtfrmitem As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Btdcat As System.Windows.Forms.Button
    Friend WithEvents Txttocat As System.Windows.Forms.TextBox
    Public WithEvents Bfdcat As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Txtfrmcat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Butprint As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents btdloc As System.Windows.Forms.Button
    Friend WithEvents Txttoloc As System.Windows.Forms.TextBox
    Public WithEvents bfdloc As System.Windows.Forms.Button
    Friend WithEvents Txtfrmloc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
