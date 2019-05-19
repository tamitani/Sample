<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOya
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblCd = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(16, 120)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(144, 50)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "子画面"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(640, 120)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(144, 50)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblCd
        '
        Me.lblCd.Location = New System.Drawing.Point(16, 16)
        Me.lblCd.Name = "lblCd"
        Me.lblCd.Size = New System.Drawing.Size(200, 32)
        Me.lblCd.TabIndex = 2
        Me.lblCd.Text = "Label1"
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(224, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(200, 32)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Label1"
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(440, 8)
        Me.btnSet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(144, 50)
        Me.btnSet.TabIndex = 4
        Me.btnSet.Text = "セット"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'frmOya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 205)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCd)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnShow)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmOya"
        Me.Text = "frmOya"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShow As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblCd As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnSet As Button
End Class
