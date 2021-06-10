<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnOpositive = New System.Windows.Forms.Button()
        Me.btnOnegative = New System.Windows.Forms.Button()
        Me.btnABnegative = New System.Windows.Forms.Button()
        Me.btnABpositive = New System.Windows.Forms.Button()
        Me.btnAnegative = New System.Windows.Forms.Button()
        Me.btnBnegative = New System.Windows.Forms.Button()
        Me.btnBpositive = New System.Windows.Forms.Button()
        Me.btnApositive = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(455, 647)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(94, 29)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(165, 662)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(254, 27)
        Me.txtName.TabIndex = 1
        '
        'btnOpositive
        '
        Me.btnOpositive.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOpositive.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOpositive.ForeColor = System.Drawing.Color.Red
        Me.btnOpositive.Location = New System.Drawing.Point(165, 359)
        Me.btnOpositive.Name = "btnOpositive"
        Me.btnOpositive.Size = New System.Drawing.Size(187, 74)
        Me.btnOpositive.TabIndex = 2
        Me.btnOpositive.Text = "O+"
        Me.btnOpositive.UseVisualStyleBackColor = False
        '
        'btnOnegative
        '
        Me.btnOnegative.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOnegative.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOnegative.ForeColor = System.Drawing.Color.Red
        Me.btnOnegative.Location = New System.Drawing.Point(165, 514)
        Me.btnOnegative.Name = "btnOnegative"
        Me.btnOnegative.Size = New System.Drawing.Size(187, 74)
        Me.btnOnegative.TabIndex = 10
        Me.btnOnegative.Text = "O-"
        Me.btnOnegative.UseVisualStyleBackColor = False
        '
        'btnABnegative
        '
        Me.btnABnegative.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnABnegative.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnABnegative.ForeColor = System.Drawing.Color.Red
        Me.btnABnegative.Location = New System.Drawing.Point(1021, 514)
        Me.btnABnegative.Name = "btnABnegative"
        Me.btnABnegative.Size = New System.Drawing.Size(187, 74)
        Me.btnABnegative.TabIndex = 11
        Me.btnABnegative.Text = "AB-"
        Me.btnABnegative.UseVisualStyleBackColor = False
        '
        'btnABpositive
        '
        Me.btnABpositive.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnABpositive.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnABpositive.ForeColor = System.Drawing.Color.Red
        Me.btnABpositive.Location = New System.Drawing.Point(1021, 359)
        Me.btnABpositive.Name = "btnABpositive"
        Me.btnABpositive.Size = New System.Drawing.Size(187, 74)
        Me.btnABpositive.TabIndex = 12
        Me.btnABpositive.Text = "AB+"
        Me.btnABpositive.UseVisualStyleBackColor = False
        '
        'btnAnegative
        '
        Me.btnAnegative.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAnegative.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAnegative.ForeColor = System.Drawing.Color.Red
        Me.btnAnegative.Location = New System.Drawing.Point(446, 514)
        Me.btnAnegative.Name = "btnAnegative"
        Me.btnAnegative.Size = New System.Drawing.Size(187, 74)
        Me.btnAnegative.TabIndex = 13
        Me.btnAnegative.Text = "A-"
        Me.btnAnegative.UseVisualStyleBackColor = False
        '
        'btnBnegative
        '
        Me.btnBnegative.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBnegative.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBnegative.ForeColor = System.Drawing.Color.Red
        Me.btnBnegative.Location = New System.Drawing.Point(735, 514)
        Me.btnBnegative.Name = "btnBnegative"
        Me.btnBnegative.Size = New System.Drawing.Size(187, 74)
        Me.btnBnegative.TabIndex = 14
        Me.btnBnegative.Text = "B-"
        Me.btnBnegative.UseVisualStyleBackColor = False
        '
        'btnBpositive
        '
        Me.btnBpositive.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBpositive.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBpositive.ForeColor = System.Drawing.Color.Red
        Me.btnBpositive.Location = New System.Drawing.Point(735, 359)
        Me.btnBpositive.Name = "btnBpositive"
        Me.btnBpositive.Size = New System.Drawing.Size(187, 74)
        Me.btnBpositive.TabIndex = 15
        Me.btnBpositive.Text = "B+"
        Me.btnBpositive.UseVisualStyleBackColor = False
        '
        'btnApositive
        '
        Me.btnApositive.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnApositive.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnApositive.ForeColor = System.Drawing.Color.Red
        Me.btnApositive.Location = New System.Drawing.Point(446, 359)
        Me.btnApositive.Name = "btnApositive"
        Me.btnApositive.Size = New System.Drawing.Size(187, 74)
        Me.btnApositive.TabIndex = 16
        Me.btnApositive.Text = "A+"
        Me.btnApositive.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1367, 763)
        Me.Controls.Add(Me.btnApositive)
        Me.Controls.Add(Me.btnBpositive)
        Me.Controls.Add(Me.btnBnegative)
        Me.Controls.Add(Me.btnAnegative)
        Me.Controls.Add(Me.btnABpositive)
        Me.Controls.Add(Me.btnABnegative)
        Me.Controls.Add(Me.btnOnegative)
        Me.Controls.Add(Me.btnOpositive)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnOk)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOk As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnOpositive As Button
    Friend WithEvents btnOnegative As Button
    Friend WithEvents btnABnegative As Button
    Friend WithEvents btnABpositive As Button
    Friend WithEvents btnAnegative As Button
    Friend WithEvents btnBnegative As Button
    Friend WithEvents btnBpositive As Button
    Friend WithEvents btnApositive As Button
End Class
