﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FromCategory))
        Me.Butcan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGfcus = New System.Windows.Forms.DataGridView()
        Me.ButSel = New System.Windows.Forms.Button()
        Me.Txtcat = New System.Windows.Forms.TextBox()
        CType(Me.DGfcus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Butcan
        '
        Me.Butcan.Location = New System.Drawing.Point(292, 313)
        Me.Butcan.Name = "Butcan"
        Me.Butcan.Size = New System.Drawing.Size(75, 23)
        Me.Butcan.TabIndex = 83
        Me.Butcan.Text = "Cancel"
        Me.Butcan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Description"
        '
        'Txtname
        '
        Me.Txtname.Location = New System.Drawing.Point(107, 34)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(237, 20)
        Me.Txtname.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Category"
        '
        'DGfcus
        '
        Me.DGfcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGfcus.Location = New System.Drawing.Point(0, 59)
        Me.DGfcus.Name = "DGfcus"
        Me.DGfcus.Size = New System.Drawing.Size(388, 244)
        Me.DGfcus.TabIndex = 81
        '
        'ButSel
        '
        Me.ButSel.Location = New System.Drawing.Point(20, 313)
        Me.ButSel.Name = "ButSel"
        Me.ButSel.Size = New System.Drawing.Size(75, 23)
        Me.ButSel.TabIndex = 82
        Me.ButSel.Text = "Select"
        Me.ButSel.UseVisualStyleBackColor = True
        '
        'Txtcat
        '
        Me.Txtcat.Location = New System.Drawing.Point(108, 11)
        Me.Txtcat.Name = "Txtcat"
        Me.Txtcat.Size = New System.Drawing.Size(237, 20)
        Me.Txtcat.TabIndex = 77
        '
        'FromCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 347)
        Me.Controls.Add(Me.Butcan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGfcus)
        Me.Controls.Add(Me.ButSel)
        Me.Controls.Add(Me.Txtcat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FromCategory"
        Me.Text = "From Category"
        CType(Me.DGfcus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Butcan As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGfcus As System.Windows.Forms.DataGridView
    Friend WithEvents ButSel As System.Windows.Forms.Button
    Friend WithEvents Txtcat As System.Windows.Forms.TextBox
End Class
