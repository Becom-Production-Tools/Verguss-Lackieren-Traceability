<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Error
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Error))
        Me.TBFehler = New System.Windows.Forms.TextBox()
        Me.LblError = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBsearch = New System.Windows.Forms.TextBox()
        Me.Lblcheck = New System.Windows.Forms.Label()
        Me.Timer_Error = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBFehler
        '
        Me.TBFehler.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBFehler.Location = New System.Drawing.Point(247, 108)
        Me.TBFehler.Name = "TBFehler"
        Me.TBFehler.ReadOnly = True
        Me.TBFehler.Size = New System.Drawing.Size(406, 31)
        Me.TBFehler.TabIndex = 0
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.Location = New System.Drawing.Point(37, 52)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(57, 24)
        Me.LblError.TabIndex = 1
        Me.LblError.Text = "Error"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fehlerhaft Seriennummer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(249, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fehlerhafte Baugruppe suchen"
        '
        'TBsearch
        '
        Me.TBsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBsearch.Location = New System.Drawing.Point(175, 293)
        Me.TBsearch.Name = "TBsearch"
        Me.TBsearch.Size = New System.Drawing.Size(403, 29)
        Me.TBsearch.TabIndex = 4
        '
        'Lblcheck
        '
        Me.Lblcheck.AutoSize = True
        Me.Lblcheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcheck.Location = New System.Drawing.Point(249, 341)
        Me.Lblcheck.Name = "Lblcheck"
        Me.Lblcheck.Size = New System.Drawing.Size(39, 20)
        Me.Lblcheck.TabIndex = 5
        Me.Lblcheck.Text = "???"
        '
        'Timer_Error
        '
        Me.Timer_Error.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Green
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(162, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fenster schließt automatisch in "
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Green
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(440, 401)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "6"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Green
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(482, 401)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sekunden"
        Me.Label5.Visible = False
        '
        'bclose
        '
        Me.bclose.Enabled = False
        Me.bclose.Location = New System.Drawing.Point(653, 397)
        Me.bclose.Name = "bclose"
        Me.bclose.Size = New System.Drawing.Size(129, 36)
        Me.bclose.TabIndex = 7
        Me.bclose.Text = "schließen"
        Me.bclose.UseVisualStyleBackColor = True
        '
        'Form_Error
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bclose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lblcheck)
        Me.Controls.Add(Me.TBsearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.TBFehler)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Error"
        Me.Text = "Form_Error"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBFehler As TextBox
    Friend WithEvents LblError As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBsearch As TextBox
    Friend WithEvents Lblcheck As Label
    Friend WithEvents Timer_Error As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bclose As Button
End Class
