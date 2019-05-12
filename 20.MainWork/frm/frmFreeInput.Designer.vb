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
        Me.lblKanriNameNm = New System.Windows.Forms.Label()
        Me.lblKanriCd = New System.Windows.Forms.Label()
        Me.lblKanriName = New System.Windows.Forms.Label()
        Me.lblKanriCdNm = New System.Windows.Forms.Label()
        Me.lblHantei = New System.Windows.Forms.Label()
        Me.lblHanteiNm = New System.Windows.Forms.Label()
        Me.tlpGridView = New System.Windows.Forms.TableLayoutPanel()
        Me.lblGridName = New System.Windows.Forms.Label()
        Me.dgvIchiran = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tlpButton = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnFrmSubInput = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.tlpHead1.SuspendLayout()
        Me.tlpGridView.SuspendLayout()
        CType(Me.dgvIchiran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpHead1
        '
        Me.tlpHead1.ColumnCount = 9
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198.0!))
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.tlpHead1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340.0!))
        Me.tlpHead1.Controls.Add(Me.lblKanriNameNm, 6, 0)
        Me.tlpHead1.Controls.Add(Me.lblKanriCd, 0, 0)
        Me.tlpHead1.Controls.Add(Me.lblKanriName, 5, 0)
        Me.tlpHead1.Controls.Add(Me.lblKanriCdNm, 4, 0)
        Me.tlpHead1.Controls.Add(Me.lblHantei, 7, 0)
        Me.tlpHead1.Controls.Add(Me.lblHanteiNm, 8, 0)
        Me.tlpHead1.Location = New System.Drawing.Point(8, 40)
        Me.tlpHead1.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpHead1.Name = "tlpHead1"
        Me.tlpHead1.RowCount = 1
        Me.tlpHead1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.78125!))
        Me.tlpHead1.Size = New System.Drawing.Size(856, 32)
        Me.tlpHead1.TabIndex = 2
        '
        'lblKanriNameNm
        '
        Me.lblKanriNameNm.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblKanriNameNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKanriNameNm.Location = New System.Drawing.Point(280, 4)
        Me.lblKanriNameNm.Margin = New System.Windows.Forms.Padding(4)
        Me.lblKanriNameNm.Name = "lblKanriNameNm"
        Me.lblKanriNameNm.Size = New System.Drawing.Size(190, 24)
        Me.lblKanriNameNm.TabIndex = 7
        Me.lblKanriNameNm.Text = "〇〇〇〇〇〇〇〇〇〇"
        '
        'lblKanriCd
        '
        Me.lblKanriCd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblKanriCd.AutoSize = True
        Me.lblKanriCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKanriCd.Location = New System.Drawing.Point(4, 5)
        Me.lblKanriCd.Margin = New System.Windows.Forms.Padding(4)
        Me.lblKanriCd.Name = "lblKanriCd"
        Me.lblKanriCd.Size = New System.Drawing.Size(85, 21)
        Me.lblKanriCd.TabIndex = 3
        Me.lblKanriCd.Text = "lblKanriCd"
        '
        'lblKanriName
        '
        Me.lblKanriName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblKanriName.AutoSize = True
        Me.lblKanriName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKanriName.Location = New System.Drawing.Point(163, 5)
        Me.lblKanriName.Margin = New System.Windows.Forms.Padding(4)
        Me.lblKanriName.Name = "lblKanriName"
        Me.lblKanriName.Size = New System.Drawing.Size(109, 21)
        Me.lblKanriName.TabIndex = 4
        Me.lblKanriName.Text = "lblKanriName"
        '
        'lblKanriCdNm
        '
        Me.lblKanriCdNm.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblKanriCdNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKanriCdNm.Location = New System.Drawing.Point(97, 4)
        Me.lblKanriCdNm.Margin = New System.Windows.Forms.Padding(4)
        Me.lblKanriCdNm.Name = "lblKanriCdNm"
        Me.lblKanriCdNm.Size = New System.Drawing.Size(58, 24)
        Me.lblKanriCdNm.TabIndex = 6
        Me.lblKanriCdNm.Text = "00001"
        '
        'lblHantei
        '
        Me.lblHantei.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblHantei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHantei.Location = New System.Drawing.Point(478, 5)
        Me.lblHantei.Margin = New System.Windows.Forms.Padding(4)
        Me.lblHantei.Name = "lblHantei"
        Me.lblHantei.Size = New System.Drawing.Size(59, 21)
        Me.lblHantei.TabIndex = 9
        Me.lblHantei.Text = "lblHantei"
        '
        'lblHanteiNm
        '
        Me.lblHanteiNm.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblHanteiNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHanteiNm.Location = New System.Drawing.Point(546, 5)
        Me.lblHanteiNm.Margin = New System.Windows.Forms.Padding(4)
        Me.lblHanteiNm.Name = "lblHanteiNm"
        Me.lblHanteiNm.Size = New System.Drawing.Size(110, 21)
        Me.lblHanteiNm.TabIndex = 10
        Me.lblHanteiNm.Text = "NG"
        '
        'tlpGridView
        '
        Me.tlpGridView.ColumnCount = 2
        Me.tlpGridView.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpGridView.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195.0!))
        Me.tlpGridView.Controls.Add(Me.lblGridName, 0, 0)
        Me.tlpGridView.Controls.Add(Me.dgvIchiran, 0, 1)
        Me.tlpGridView.Controls.Add(Me.btnSearch, 1, 0)
        Me.tlpGridView.Location = New System.Drawing.Point(8, 72)
        Me.tlpGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpGridView.Name = "tlpGridView"
        Me.tlpGridView.RowCount = 2
        Me.tlpGridView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.78125!))
        Me.tlpGridView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.tlpGridView.Size = New System.Drawing.Size(856, 176)
        Me.tlpGridView.TabIndex = 3
        '
        'lblGridName
        '
        Me.lblGridName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblGridName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGridName.Location = New System.Drawing.Point(4, 14)
        Me.lblGridName.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGridName.Name = "lblGridName"
        Me.lblGridName.Size = New System.Drawing.Size(652, 23)
        Me.lblGridName.TabIndex = 4
        Me.lblGridName.Text = "lblGridName"
        '
        'dgvIchiran
        '
        Me.dgvIchiran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIchiran.Location = New System.Drawing.Point(5, 43)
        Me.dgvIchiran.Margin = New System.Windows.Forms.Padding(5, 2, 5, 5)
        Me.dgvIchiran.Name = "dgvIchiran"
        Me.dgvIchiran.RowTemplate.Height = 21
        Me.dgvIchiran.Size = New System.Drawing.Size(651, 124)
        Me.dgvIchiran.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(689, 11)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(163, 24)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "btnSearch"
        Me.btnSearch.UseVisualStyleBackColor = True
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
        Me.tlpButton.Controls.Add(Me.btnFrmSubInput, 0, 0)
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
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(346, 4)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(163, 32)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "btnDelete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnFrmSubInput
        '
        Me.btnFrmSubInput.Location = New System.Drawing.Point(4, 4)
        Me.btnFrmSubInput.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFrmSubInput.Name = "btnFrmSubInput"
        Me.btnFrmSubInput.Size = New System.Drawing.Size(163, 32)
        Me.btnFrmSubInput.TabIndex = 3
        Me.btnFrmSubInput.Text = "btnFrmSubInput"
        Me.btnFrmSubInput.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(688, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(163, 32)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(175, 4)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(163, 32)
        Me.btnExcel.TabIndex = 4
        Me.btnExcel.Text = "btnExcel"
        Me.btnExcel.UseVisualStyleBackColor = True
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
    Friend WithEvents lblKanriName As Label
    Friend WithEvents lblKanriCd As Label
    Friend WithEvents tlpGridView As TableLayoutPanel
    Friend WithEvents lblGridName As Label
    Friend WithEvents dgvIchiran As DataGridView
    Friend WithEvents tlpButton As TableLayoutPanel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents btnFrmSubInput As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblKanriCdNm As Label
    Friend WithEvents lblKanriNameNm As Label
    Friend WithEvents lblHantei As Label
    Friend WithEvents lblHanteiNm As Label
    Friend WithEvents btnSearch As Button
End Class
