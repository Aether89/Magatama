<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAbout
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblMagatama = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.rtfCredits = New System.Windows.Forms.RichTextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMagatama
        '
        Me.lblMagatama.BackColor = System.Drawing.Color.Transparent
        Me.lblMagatama.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMagatama.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMagatama.Location = New System.Drawing.Point(67, 7)
        Me.lblMagatama.Name = "lblMagatama"
        Me.lblMagatama.Size = New System.Drawing.Size(150, 35)
        Me.lblMagatama.TabIndex = 0
        Me.lblMagatama.Text = "Magatama"
        Me.lblMagatama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.Control
        Me.lblVersion.Location = New System.Drawing.Point(67, 42)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(150, 20)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Version : αlpha (64bit)"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rtfCredits
        '
        Me.rtfCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtfCredits.Cursor = System.Windows.Forms.Cursors.Default
        Me.rtfCredits.Location = New System.Drawing.Point(9, 68)
        Me.rtfCredits.Name = "rtfCredits"
        Me.rtfCredits.ReadOnly = True
        Me.rtfCredits.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtfCredits.Size = New System.Drawing.Size(266, 180)
        Me.rtfCredits.TabIndex = 1
        Me.rtfCredits.Text = ""
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(73, 252)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(144, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnOK
        Me.ClientSize = New System.Drawing.Size(284, 290)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.rtfCredits)
        Me.Controls.Add(Me.lblMagatama)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAbout"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About Magatama..."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtfCredits As RichTextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents lblMagatama As Label
    Friend WithEvents lblVersion As Label
End Class
