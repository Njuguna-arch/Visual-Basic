<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblTask = New System.Windows.Forms.Label()
        Me.txtNewTask = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lstTasks = New System.Windows.Forms.ListBox()
        Me.lblAdded = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTask
        '
        Me.lblTask.AutoSize = True
        Me.lblTask.Location = New System.Drawing.Point(160, 144)
        Me.lblTask.Name = "lblTask"
        Me.lblTask.Size = New System.Drawing.Size(68, 16)
        Me.lblTask.TabIndex = 0
        Me.lblTask.Text = "New Task"
        '
        'txtNewTask
        '
        Me.txtNewTask.Location = New System.Drawing.Point(244, 141)
        Me.txtNewTask.Name = "txtNewTask"
        Me.txtNewTask.Size = New System.Drawing.Size(225, 22)
        Me.txtNewTask.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(163, 242)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(134, 35)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add Task"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(363, 242)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(106, 35)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove Task"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lstTasks
        '
        Me.lstTasks.FormattingEnabled = True
        Me.lstTasks.ItemHeight = 16
        Me.lstTasks.Location = New System.Drawing.Point(576, 159)
        Me.lstTasks.Name = "lstTasks"
        Me.lstTasks.Size = New System.Drawing.Size(157, 148)
        Me.lstTasks.TabIndex = 4
        '
        'lblAdded
        '
        Me.lblAdded.AutoSize = True
        Me.lblAdded.Location = New System.Drawing.Point(583, 140)
        Me.lblAdded.Name = "lblAdded"
        Me.lblAdded.Size = New System.Drawing.Size(89, 16)
        Me.lblAdded.TabIndex = 5
        Me.lblAdded.Text = "Added Tasks"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAdded)
        Me.Controls.Add(Me.lstTasks)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNewTask)
        Me.Controls.Add(Me.lblTask)
        Me.Name = "Form1"
        Me.Text = "To-Do List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTask As Label
    Friend WithEvents txtNewTask As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents lstTasks As ListBox
    Friend WithEvents lblAdded As Label
End Class
