<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFreeInput
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
        Me.lblKanriCd = New System.Windows.Forms.Label()
        Me.txtKanriCd = New System.Windows.Forms.TextBox()
        Me.lblKanriName = New System.Windows.Forms.Label()
        Me.txtKAnriName = New System.Windows.Forms.TextBox()
        Me.tlpGridView = New System.Windows.Forms.TableLayoutPanel()
        Me.lblGridNama = New System.Windows.Forms.Label()
        Me.dgvIchiran = New System.Windows.Forms.DataGridView()
        Me.tlpButton = New System.Windows.Forms.TableLayoutPanel()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tlpHead1.SuspendLayout()
        Me.tlpGridView.SuspendLayout()
        CType(Me.dgvIchiran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpHead1
        '
        Me.tlpHead1.ColumnCount = 6
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212.0!))
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.tlpHead1.Controls.Add(Me.btnSearch, 5, 0)
        Me.tlpHead1.Controls.Add(Me.txtKAnriName, 3, 0)
        Me.tlpHead1.Controls.Add(Me.lblKanriName, 2, 0)
        Me.tlpHead1.Controls.Add(Me.txtKanriCd, 1, 0)
        Me.tlpHead1.Controls.Add(Me.lblKanriCd, 0, 0)
        Me.tlpHead1.Location = New System.Drawing.Point(8, 32)
        Me.tlpHead1.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpHead1.Name = "tlpHead1"
        Me.tlpHead1.RowCount = 1
        Me.tlpHead1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.78125!))
        Me.tlpHead1.Size = New System.Drawing.Size(856, 40)
        Me.tlpHead1.TabIndex = 2
        '
        'lblKanriCd
        '
        Me.lblKanriCd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblKanriCd.AutoSize = True
        Me.lblKanriCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKanriCd.Location = New System.Drawing.Point(4, 9)
        Me.lblKanriCd.Margin = New System.Windows.Forms.Padding(4)
        Me.lblKanriCd.Name = "lblKanriCd"
        Me.lblKanriCd.Size = New System.Drawing.Size(85, 21)
        Me.lblKanriCd.TabIndex = 3
        Me.lblKanriCd.Text = "lblKanriCd"
        '
        'txtKanriCd
        '
        Me.txtKanriCd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtKanriCd.Location = New System.Drawing.Point(96, 6)
        Me.txtKanriCd.Name = "txtKanriCd"
        Me.txtKanriCd.Size = New System.Drawing.Size(60, 27)
        Me.txtKanriCd.TabIndex = 1
        Me.txtKanriCd.Text = "XXXXX"
        '
        'lblKanriName
        '
        Me.lblKanriName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblKanriName.AutoSize = True
        Me.lblKanriName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKanriName.Location = New System.Drawing.Point(163, 9)
        Me.lblKanriName.Margin = New System.Windows.Forms.Padding(4)
        Me.lblKanriName.Name = "lblKanriName"
        Me.lblKanriName.Size = New System.Drawing.Size(109, 21)
        Me.lblKanriName.TabIndex = 4
        Me.lblKanriName.Text = "lblKanriName"
        '
        'txtKAnriName
        '
        Me.txtKAnriName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtKAnriName.Location = New System.Drawing.Point(279, 6)
        Me.txtKAnriName.Name = "txtKAnriName"
        Me.txtKAnriName.Size = New System.Drawing.Size(120, 27)
        Me.txtKAnriName.TabIndex = 2
        Me.txtKAnriName.Text = "NNNNNNNNNN"
        '
        'tlpGridView
        '
        Me.tlpGridView.ColumnCount = 1
        Me.tlpGridView.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpGridView.Controls.Add(Me.lblGridNama, 0, 0)
        Me.tlpGridView.Controls.Add(Me.dgvIchiran, 0, 1)
        Me.tlpGridView.Location = New System.Drawing.Point(8, 80)
        Me.tlpGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpGridView.Name = "tlpGridView"
        Me.tlpGridView.RowCount = 2
        Me.tlpGridView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.78125!))
        Me.tlpGridView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.tlpGridView.Size = New System.Drawing.Size(664, 168)
        Me.tlpGridView.TabIndex = 3
        '
        'lblGridNama
        '
        Me.lblGridNama.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblGridNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGridNama.Location = New System.Drawing.Point(4, 4)
        Me.lblGridNama.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGridNama.Name = "lblGridNama"
        Me.lblGridNama.Size = New System.Drawing.Size(652, 23)
        Me.lblGridNama.TabIndex = 4
        Me.lblGridNama.Text = "lblGridNama"
        '
        'dgvIchiran
        '
        Me.dgvIchiran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIchiran.Location = New System.Drawing.Point(5, 33)
        Me.dgvIchiran.Margin = New System.Windows.Forms.Padding(5, 2, 5, 5)
        Me.dgvIchiran.Name = "dgvIchiran"
        Me.dgvIchiran.RowTemplate.Height = 21
        Me.dgvIchiran.Size = New System.Drawing.Size(651, 124)
        Me.dgvIchiran.TabIndex = 4
        '
        'tlpButton
        '
        Me.tlpButton.ColumnCount = 5
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButton.Controls.Add(Me.btnDelete, 2, 0)
        Me.tlpButton.Controls.Add(Me.btnInsert, 0, 0)
        Me.tlpButton.Controls.Add(Me.btnClose, 4, 0)
        Me.tlpButton.Controls.Add(Me.btnExcel, 1, 0)
        Me.tlpButton.Location = New System.Drawing.Point(8, 248)
        Me.tlpButton.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpButton.Name = "tlpButton"
        Me.tlpButton.RowCount = 1
        Me.tlpButton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButton.Size = New System.Drawing.Size(856, 40)
        Me.tlpButton.TabIndex = 4
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(4, 4)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(163, 32)
        Me.btnInsert.TabIndex = 5
        Me.btnInsert.Text = "btnInsert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(175, 4)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(163, 32)
        Me.btnExcel.TabIndex = 6
        Me.btnExcel.Text = "btnExcel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(346, 4)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(163, 32)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "btnDelete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(688, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(163, 32)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(689, 4)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(163, 32)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "btnSearch"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmFreeInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 321)
        Me.Controls.Add(Me.tlpButton)
        Me.Controls.Add(Me.tlpGridView)
        Me.Controls.Add(Me.tlpHead1)
        Me.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.Name = "frmFreeInput"
        Me.Controls.SetChildIndex(Me.tlpHead1, 0)
        Me.Controls.SetChildIndex(Me.tlpGridView, 0)
        Me.Controls.SetChildIndex(Me.tlpButton, 0)
        Me.tlpHead1.ResumeLayout(False)
        Me.tlpHead1.PerformLayout()
        Me.tlpGridView.ResumeLayout(False)
        CType(Me.dgvIchiran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpHead1 As TableLayoutPanel
    Friend WithEvents txtKAnriName As TextBox
    Friend WithEvents lblKanriName As Label
    Friend WithEvents txtKanriCd As TextBox
    Friend WithEvents lblKanriCd As Label
    Friend WithEvents tlpGridView As TableLayoutPanel
    Friend WithEvents lblGridNama As Label
    Friend WithEvents dgvIchiran As DataGridView
    Friend WithEvents tlpButton As TableLayoutPanel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSearch As Button
End Class
