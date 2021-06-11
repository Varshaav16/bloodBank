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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnOpositive = New System.Windows.Forms.Button()
        Me.btnOnegative = New System.Windows.Forms.Button()
        Me.btnABnegative = New System.Windows.Forms.Button()
        Me.btnABpositive = New System.Windows.Forms.Button()
        Me.btnAnegative = New System.Windows.Forms.Button()
        Me.btnBnegative = New System.Windows.Forms.Button()
        Me.btnBpositive = New System.Windows.Forms.Button()
        Me.btnApositive = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpositive
        '
        Me.btnOpositive.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOpositive.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOpositive.ForeColor = System.Drawing.Color.Red
        Me.btnOpositive.Location = New System.Drawing.Point(165, 470)
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
        Me.btnOnegative.Location = New System.Drawing.Point(165, 594)
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
        Me.btnABnegative.Location = New System.Drawing.Point(1021, 594)
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
        Me.btnABpositive.Location = New System.Drawing.Point(1021, 470)
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
        Me.btnAnegative.Location = New System.Drawing.Point(446, 594)
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
        Me.btnBnegative.Location = New System.Drawing.Point(735, 594)
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
        Me.btnBpositive.Location = New System.Drawing.Point(735, 470)
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
        Me.btnApositive.Location = New System.Drawing.Point(446, 470)
        Me.btnApositive.Name = "btnApositive"
        Me.btnApositive.Size = New System.Drawing.Size(187, 74)
        Me.btnApositive.TabIndex = 16
        Me.btnApositive.Text = "A+"
        Me.btnApositive.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(132, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1103, 321)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(152, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1067, 81)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "BLOOD BANK MANAGEMENT SYSTEM"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(459, 687)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(463, 64)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "HOSPITAL LOGIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1367, 763)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnApositive)
        Me.Controls.Add(Me.btnBpositive)
        Me.Controls.Add(Me.btnBnegative)
        Me.Controls.Add(Me.btnAnegative)
        Me.Controls.Add(Me.btnABpositive)
        Me.Controls.Add(Me.btnABnegative)
        Me.Controls.Add(Me.btnOnegative)
        Me.Controls.Add(Me.btnOpositive)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpositive As Button
    Friend WithEvents btnOnegative As Button
    Friend WithEvents btnABnegative As Button
    Friend WithEvents btnABpositive As Button
    Friend WithEvents btnAnegative As Button
    Friend WithEvents btnBnegative As Button
    Friend WithEvents btnBpositive As Button
    Friend WithEvents btnApositive As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
