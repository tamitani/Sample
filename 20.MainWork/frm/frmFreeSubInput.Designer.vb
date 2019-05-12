Imports _10.SysCommon

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFreeSubInput
    Inherits _10.SysCommon.frmBaseForm

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
        Me.tlpHead1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtKanriCd = New System.Windows.Forms.TextBox()
        Me.txtKanriName = New System.Windows.Forms.TextBox()
        Me.lblKanriCd = New System.Windows.Forms.Label()
        Me.lblKanriName = New System.Windows.Forms.Label()
        Me.tlpButton = New System.Windows.Forms.TableLayoutPanel()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbHantei = New System.Windows.Forms.ComboBox()
        Me.lblHantei = New System.Windows.Forms.Label()
        Me.tlpHead1.SuspendLayout()
        Me.tlpButton.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpHead1
        '
        Me.tlpHead1.ColumnCount = 7
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 371.0!))
        Me.tlpHead1.Controls.Add(Me.txtKanriCd, 1, 0)
        Me.tlpHead1.Controls.Add(Me.txtKanriName, 5, 0)
        Me.tlpHead1.Controls.Add(Me.lblKanriCd, 0, 0)
        Me.tlpHead1.Controls.Add(Me.lblKanriName, 4, 0)
        Me.tlpHead1.Location = New System.Drawing.Point(8, 40)
        Me.tlpHead1.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpHead1.Name = "tlpHead1"
        Me.tlpHead1.RowCount = 1
        Me.tlpHead1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpHead1.Size = New System.Drawing.Size(856, 32)
        Me.tlpHead1.TabIndex = 3
        '
        'txtKanriCd
        '
        Me.txtKanriCd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtKanriCd.Location = New System.Drawing.Point(101, 3)
        Me.txtKanriCd.Name = "txtKanriCd"
        Me.txtKanriCd.Size = New System.Drawing.Size(58, 27)
        Me.txtKanriCd.TabIndex = 1
        Me.txtKanriCd.Text = "XXXXX"
        '
        'txtKanriName
        '
        Me.txtKanriName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtKanriName.Location = New System.Drawing.Point(288, 3)
        Me.txtKanriName.Name = "txtKanriName"
        Me.txtKanriName.Size = New System.Drawing.Size(190, 27)
        Me.txtKanriName.TabIndex = 2
        Me.txtKanriName.Text = "NNNNNNNNNN"
        '
        'lblKanriCd
        '
        Me.lblKanriCd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblKanriCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKanriCd.Location = New System.Drawing.Point(4, 4)
        Me.lblKanriCd.Margin = New System.Windows.Forms.Padding(4)
        Me.lblKanriCd.Name = "lblKanriCd"
        Me.lblKanriCd.Size = New System.Drawing.Size(90, 24)
        Me.lblKanriCd.TabIndex = 3
        Me.lblKanriCd.Text = "lblKanriCd"
        '
        'lblKanriName
        '
        Me.lblKanriName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblKanriName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKanriName.Location = New System.Drawing.Point(167, 4)
        Me.lblKanriName.Margin = New System.Windows.Forms.Padding(4)
        Me.lblKanriName.Name = "lblKanriName"
        Me.lblKanriName.Size = New System.Drawing.Size(114, 24)
        Me.lblKanriName.TabIndex = 4
        Me.lblKanriName.Text = "lblKanriName"
        '
        'tlpButton
        '
        Me.tlpButton.ColumnCount = 5
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButton.Controls.Add(Me.btnInsert, 0, 0)
        Me.tlpButton.Controls.Add(Me.btnClose, 4, 0)
        Me.tlpButton.Location = New System.Drawing.Point(8, 248)
        Me.tlpButton.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpButton.Name = "tlpButton"
        Me.tlpButton.RowCount = 1
        Me.tlpButton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButton.Size = New System.Drawing.Size(856, 40)
        Me.tlpButton.TabIndex = 5
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(4, 4)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(163, 32)
        Me.btnInsert.TabIndex = 4
        Me.btnInsert.Text = "btnInsert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(688, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(163, 32)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmbHantei, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblHantei, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 80)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(856, 32)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'cmbHantei
        '
        Me.cmbHantei.FormattingEnabled = True
        Me.cmbHantei.Location = New System.Drawing.Point(101, 3)
        Me.cmbHantei.Name = "cmbHantei"
        Me.cmbHantei.Size = New System.Drawing.Size(112, 27)
        Me.cmbHantei.TabIndex = 3
        '
        'lblHantei
        '
        Me.lblHantei.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblHantei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHantei.Location = New System.Drawing.Point(4, 5)
        Me.lblHantei.Margin = New System.Windows.Forms.Padding(4)
        Me.lblHantei.Name = "lblHantei"
        Me.lblHantei.Size = New System.Drawing.Size(85, 21)
        Me.lblHantei.TabIndex = 3
        Me.lblHantei.Text = "lblHantei"
        '
        'frmFreeSubInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 321)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.tlpButton)
        Me.Controls.Add(Me.tlpHead1)
        Me.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.Name = "frmFreeSubInput"
        Me.Controls.SetChildIndex(Me.tlpHead1, 0)
        Me.Controls.SetChildIndex(Me.tlpButton, 0)
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        Me.tlpHead1.ResumeLayout(False)
        Me.tlpHead1.PerformLayout()
        Me.tlpButton.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpHead1 As TableLayoutPanel
    Friend WithEvents lblKanriName As Label
    Friend WithEvents lblKanriCd As Label
    Friend WithEvents tlpButton As TableLayoutPanel
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblHantei As Label
    Friend WithEvents txtKanriCd As TextBox
    Friend WithEvents txtKanriName As TextBox
    Friend WithEvents cmbHantei As ComboBox
End Class
