<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblr1 = New System.Windows.Forms.Label()
        Me.lblr2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTitle.Location = New System.Drawing.Point(33, 26)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(254, 16)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Dada la formula:   Ax^2 + Bx + C = 0 "
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.BackColor = System.Drawing.Color.White
        Me.lblA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblA.Location = New System.Drawing.Point(37, 55)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(18, 16)
        Me.lblA.TabIndex = 1
        Me.lblA.Text = "A"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.BackColor = System.Drawing.Color.White
        Me.lblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblB.Location = New System.Drawing.Point(140, 58)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(18, 16)
        Me.lblB.TabIndex = 2
        Me.lblB.Text = "B"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.BackColor = System.Drawing.Color.White
        Me.lblC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.ForeColor = System.Drawing.Color.Black
        Me.lblC.Location = New System.Drawing.Point(246, 58)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(18, 16)
        Me.lblC.TabIndex = 3
        Me.lblC.Text = "C"
        '
        'txtA
        '
        Me.txtA.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtA.ForeColor = System.Drawing.SystemColors.Window
        Me.txtA.Location = New System.Drawing.Point(61, 54)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(59, 20)
        Me.txtA.TabIndex = 4
        '
        'txtB
        '
        Me.txtB.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtB.ForeColor = System.Drawing.SystemColors.Window
        Me.txtB.Location = New System.Drawing.Point(164, 55)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(59, 20)
        Me.txtB.TabIndex = 5
        '
        'txtC
        '
        Me.txtC.BackColor = System.Drawing.SystemColors.MenuText
        Me.txtC.ForeColor = System.Drawing.SystemColors.Window
        Me.txtC.Location = New System.Drawing.Point(270, 55)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(59, 20)
        Me.txtC.TabIndex = 6
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.Cornsilk
        Me.btnCompute.BackgroundImage = Global.Ecuacion2grado.My.Resources.Resources.calcular
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(40, 91)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(289, 116)
        Me.btnCompute.TabIndex = 7
        Me.btnCompute.Text = " "
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(347, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Raiz 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(347, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Raiz 2:"
        '
        'lblr1
        '
        Me.lblr1.AutoSize = True
        Me.lblr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblr1.ForeColor = System.Drawing.Color.Black
        Me.lblr1.Location = New System.Drawing.Point(408, 107)
        Me.lblr1.Name = "lblr1"
        Me.lblr1.Size = New System.Drawing.Size(0, 16)
        Me.lblr1.TabIndex = 10
        '
        'lblr2
        '
        Me.lblr2.AutoSize = True
        Me.lblr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblr2.ForeColor = System.Drawing.Color.Black
        Me.lblr2.Location = New System.Drawing.Point(408, 138)
        Me.lblr2.Name = "lblr2"
        Me.lblr2.Size = New System.Drawing.Size(0, 16)
        Me.lblr2.TabIndex = 11
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Black
        Me.lblResult.Location = New System.Drawing.Point(347, 173)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 16)
        Me.lblResult.TabIndex = 12
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(620, 220)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblr2)
        Me.Controls.Add(Me.lblr1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblTitle)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Main"
        Me.Text = "Second Degree Ecuation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblr1 As System.Windows.Forms.Label
    Friend WithEvents lblr2 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
