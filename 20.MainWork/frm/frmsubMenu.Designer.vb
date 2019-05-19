<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubMenu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnFreeInput = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnFreeInput, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button5, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(7, 8)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(727, 304)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnFreeInput
        '
        Me.btnFreeInput.Location = New System.Drawing.Point(9, 10)
        Me.btnFreeInput.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.btnFreeInput.Name = "btnFreeInput"
        Me.btnFreeInput.Size = New System.Drawing.Size(127, 40)
        Me.btnFreeInput.TabIndex = 0
        Me.btnFreeInput.Text = "btnFreeInput"
        Me.btnFreeInput.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(154, 10)
        Me.Button1.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "子画面引き渡し確認"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(299, 10)
        Me.Button2.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "frmList"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(444, 10)
        Me.Button3.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 40)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "frmLinq"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(589, 10)
        Me.Button4.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 40)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "frmList"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(9, 70)
        Me.Button5.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 40)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "別フォーム(引数)"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frmSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 321)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmSubMenu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnFreeInput As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
