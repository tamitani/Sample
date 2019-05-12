<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseForm
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
        Me.tlpHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSysName = New System.Windows.Forms.Label()
        Me.lblLogiNm = New System.Windows.Forms.Label()
        Me.tlpFooter = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.tlpHeader.SuspendLayout()
        Me.tlpFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpHeader
        '
        Me.tlpHeader.BackColor = System.Drawing.Color.Cornsilk
        Me.tlpHeader.ColumnCount = 3
        Me.tlpHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 451.0!))
        Me.tlpHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201.0!))
        Me.tlpHeader.Controls.Add(Me.lblSysName, 0, 0)
        Me.tlpHeader.Controls.Add(Me.lblLogiNm, 2, 0)
        Me.tlpHeader.Location = New System.Drawing.Point(0, 0)
        Me.tlpHeader.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tlpHeader.Name = "tlpHeader"
        Me.tlpHeader.RowCount = 1
        Me.tlpHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHeader.Size = New System.Drawing.Size(864, 32)
        Me.tlpHeader.TabIndex = 0
        '
        'lblSysName
        '
        Me.lblSysName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSysName.Location = New System.Drawing.Point(4, 4)
        Me.lblSysName.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSysName.Name = "lblSysName"
        Me.lblSysName.Size = New System.Drawing.Size(204, 24)
        Me.lblSysName.TabIndex = 4
        Me.lblSysName.Text = "lblSysName"
        '
        'lblLogiNm
        '
        Me.lblLogiNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLogiNm.Location = New System.Drawing.Point(667, 4)
        Me.lblLogiNm.Margin = New System.Windows.Forms.Padding(4)
        Me.lblLogiNm.Name = "lblLogiNm"
        Me.lblLogiNm.Size = New System.Drawing.Size(193, 24)
        Me.lblLogiNm.TabIndex = 5
        Me.lblLogiNm.Text = "lblLogiNm"
        '
        'tlpFooter
        '
        Me.tlpFooter.BackColor = System.Drawing.Color.Cornsilk
        Me.tlpFooter.ColumnCount = 2
        Me.tlpFooter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpFooter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203.0!))
        Me.tlpFooter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 258.0!))
        Me.tlpFooter.Controls.Add(Me.lblMsg, 0, 0)
        Me.tlpFooter.Controls.Add(Me.lblDateTime, 1, 0)
        Me.tlpFooter.Location = New System.Drawing.Point(0, 288)
        Me.tlpFooter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tlpFooter.Name = "tlpFooter"
        Me.tlpFooter.RowCount = 1
        Me.tlpFooter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpFooter.Size = New System.Drawing.Size(864, 32)
        Me.tlpFooter.TabIndex = 1
        '
        'lblMsg
        '
        Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMsg.Location = New System.Drawing.Point(4, 4)
        Me.lblMsg.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(652, 24)
        Me.lblMsg.TabIndex = 4
        Me.lblMsg.Text = "lblMsg"
        '
        'lblDateTime
        '
        Me.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateTime.Location = New System.Drawing.Point(665, 4)
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(193, 24)
        Me.lblDateTime.TabIndex = 3
        Me.lblDateTime.Text = "lblDateTime"
        '
        'frmBaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(864, 321)
        Me.Controls.Add(Me.tlpFooter)
        Me.Controls.Add(Me.tlpHeader)
        Me.Font = New System.Drawing.Font("Meiryo UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmBaseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tlpHeader.ResumeLayout(False)
        Me.tlpFooter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpHeader As TableLayoutPanel
    Friend WithEvents tlpFooter As TableLayoutPanel
    Friend WithEvents lblSysName As Label
    Friend WithEvents lblLogiNm As Label
    Friend WithEvents lblMsg As Label
    Friend WithEvents lblDateTime As Label
End Class
