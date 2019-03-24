<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GWXtractor
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
        Me.BtnGrab = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.txtUrl = New System.Windows.Forms.TextBox
        Me.lblSaorceCode = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.lblDescription = New System.Windows.Forms.Label
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.txtSKU = New System.Windows.Forms.TextBox
        Me.lblSKU = New System.Windows.Forms.Label
        Me.txtUPC = New System.Windows.Forms.TextBox
        Me.txtMPN = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.txtMapPrice = New System.Windows.Forms.TextBox
        Me.lblUrl = New System.Windows.Forms.Label
        Me.lblMPN = New System.Windows.Forms.Label
        Me.lblUPC = New System.Windows.Forms.Label
        Me.lblPrice = New System.Windows.Forms.Label
        Me.lblMapPrice = New System.Windows.Forms.Label
        Me.grpWebSource = New System.Windows.Forms.GroupBox
        Me.chkEbay = New System.Windows.Forms.CheckBox
        Me.chk = New System.Windows.Forms.CheckBox
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.txtSelectedFile = New System.Windows.Forms.TextBox
        Me.LblCurrentFile = New System.Windows.Forms.Label
        Me.grpWebSource.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGrab
        '
        Me.BtnGrab.Location = New System.Drawing.Point(422, 38)
        Me.BtnGrab.Name = "BtnGrab"
        Me.BtnGrab.Size = New System.Drawing.Size(92, 26)
        Me.BtnGrab.TabIndex = 0
        Me.BtnGrab.Text = "Go"
        Me.BtnGrab.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(24, 73)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(490, 146)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(47, 12)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(467, 20)
        Me.txtUrl.TabIndex = 2
        '
        'lblSaorceCode
        '
        Me.lblSaorceCode.AutoSize = True
        Me.lblSaorceCode.Location = New System.Drawing.Point(21, 54)
        Me.lblSaorceCode.Name = "lblSaorceCode"
        Me.lblSaorceCode.Size = New System.Drawing.Size(69, 13)
        Me.lblSaorceCode.TabIndex = 4
        Me.lblSaorceCode.Text = "Sauce Code:"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(24, 280)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(490, 20)
        Me.txtDescription.TabIndex = 5
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(21, 264)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 6
        Me.lblDescription.Text = "Description"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(24, 244)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(490, 20)
        Me.txtTitle.TabIndex = 7
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(21, 228)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Title"
        '
        'txtSKU
        '
        Me.txtSKU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSKU.Location = New System.Drawing.Point(24, 327)
        Me.txtSKU.Name = "txtSKU"
        Me.txtSKU.Size = New System.Drawing.Size(181, 20)
        Me.txtSKU.TabIndex = 9
        '
        'lblSKU
        '
        Me.lblSKU.AutoSize = True
        Me.lblSKU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSKU.Location = New System.Drawing.Point(23, 389)
        Me.lblSKU.Name = "lblSKU"
        Me.lblSKU.Size = New System.Drawing.Size(29, 13)
        Me.lblSKU.TabIndex = 10
        Me.lblSKU.Text = "SKU"
        '
        'txtUPC
        '
        Me.txtUPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPC.Location = New System.Drawing.Point(26, 405)
        Me.txtUPC.Name = "txtUPC"
        Me.txtUPC.Size = New System.Drawing.Size(179, 20)
        Me.txtUPC.TabIndex = 11
        '
        'txtMPN
        '
        Me.txtMPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMPN.Location = New System.Drawing.Point(24, 366)
        Me.txtMPN.Name = "txtMPN"
        Me.txtMPN.Size = New System.Drawing.Size(181, 20)
        Me.txtMPN.TabIndex = 12
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(281, 327)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(77, 20)
        Me.txtPrice.TabIndex = 13
        '
        'txtMapPrice
        '
        Me.txtMapPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMapPrice.Location = New System.Drawing.Point(281, 356)
        Me.txtMapPrice.Name = "txtMapPrice"
        Me.txtMapPrice.Size = New System.Drawing.Size(77, 20)
        Me.txtMapPrice.TabIndex = 14
        '
        'lblUrl
        '
        Me.lblUrl.AutoSize = True
        Me.lblUrl.Location = New System.Drawing.Point(12, 15)
        Me.lblUrl.Name = "lblUrl"
        Me.lblUrl.Size = New System.Drawing.Size(32, 13)
        Me.lblUrl.TabIndex = 15
        Me.lblUrl.Text = "URL:"
        '
        'lblMPN
        '
        Me.lblMPN.AutoSize = True
        Me.lblMPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMPN.Location = New System.Drawing.Point(21, 311)
        Me.lblMPN.Name = "lblMPN"
        Me.lblMPN.Size = New System.Drawing.Size(31, 13)
        Me.lblMPN.TabIndex = 16
        Me.lblMPN.Text = "MPN"
        '
        'lblUPC
        '
        Me.lblUPC.AutoSize = True
        Me.lblUPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUPC.Location = New System.Drawing.Point(23, 350)
        Me.lblUPC.Name = "lblUPC"
        Me.lblUPC.Size = New System.Drawing.Size(29, 13)
        Me.lblUPC.TabIndex = 17
        Me.lblUPC.Text = "UPC"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(244, 330)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 18
        Me.lblPrice.Text = "Price"
        '
        'lblMapPrice
        '
        Me.lblMapPrice.AutoSize = True
        Me.lblMapPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMapPrice.Location = New System.Drawing.Point(235, 359)
        Me.lblMapPrice.Name = "lblMapPrice"
        Me.lblMapPrice.Size = New System.Drawing.Size(40, 13)
        Me.lblMapPrice.TabIndex = 19
        Me.lblMapPrice.Text = "MPrice"
        '
        'grpWebSource
        '
        Me.grpWebSource.Controls.Add(Me.chk)
        Me.grpWebSource.Controls.Add(Me.chkEbay)
        Me.grpWebSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpWebSource.Location = New System.Drawing.Point(390, 319)
        Me.grpWebSource.Name = "grpWebSource"
        Me.grpWebSource.Size = New System.Drawing.Size(103, 77)
        Me.grpWebSource.TabIndex = 20
        Me.grpWebSource.TabStop = False
        Me.grpWebSource.Text = "Source"
        '
        'chkEbay
        '
        Me.chkEbay.AutoSize = True
        Me.chkEbay.Location = New System.Drawing.Point(11, 19)
        Me.chkEbay.Name = "chkEbay"
        Me.chkEbay.Size = New System.Drawing.Size(50, 17)
        Me.chkEbay.TabIndex = 0
        Me.chkEbay.Text = "Ebay"
        Me.chkEbay.UseVisualStyleBackColor = True
        '
        'chk
        '
        Me.chk.AutoSize = True
        Me.chk.Location = New System.Drawing.Point(10, 50)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(64, 17)
        Me.chk.TabIndex = 1
        Me.chk.Text = "Amazon"
        Me.chk.UseVisualStyleBackColor = True
        '
        'txtSelectedFile
        '
        Me.txtSelectedFile.Location = New System.Drawing.Point(64, 431)
        Me.txtSelectedFile.Name = "txtSelectedFile"
        Me.txtSelectedFile.Size = New System.Drawing.Size(429, 20)
        Me.txtSelectedFile.TabIndex = 21
        '
        'LblCurrentFile
        '
        Me.LblCurrentFile.AutoSize = True
        Me.LblCurrentFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrentFile.ForeColor = System.Drawing.Color.Red
        Me.LblCurrentFile.Location = New System.Drawing.Point(21, 434)
        Me.LblCurrentFile.Name = "LblCurrentFile"
        Me.LblCurrentFile.Size = New System.Drawing.Size(45, 13)
        Me.LblCurrentFile.TabIndex = 22
        Me.LblCurrentFile.Text = "Output"
        '
        'GWXtractor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 465)
        Me.Controls.Add(Me.LblCurrentFile)
        Me.Controls.Add(Me.txtSelectedFile)
        Me.Controls.Add(Me.grpWebSource)
        Me.Controls.Add(Me.lblMapPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblUPC)
        Me.Controls.Add(Me.lblMPN)
        Me.Controls.Add(Me.lblUrl)
        Me.Controls.Add(Me.txtMapPrice)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtMPN)
        Me.Controls.Add(Me.txtUPC)
        Me.Controls.Add(Me.lblSKU)
        Me.Controls.Add(Me.txtSKU)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblSaorceCode)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BtnGrab)
        Me.Name = "GWXtractor"
        Me.Text = "Xtractor"
        Me.grpWebSource.ResumeLayout(False)
        Me.grpWebSource.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGrab As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents lblSaorceCode As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtSKU As System.Windows.Forms.TextBox
    Friend WithEvents lblSKU As System.Windows.Forms.Label
    Friend WithEvents txtUPC As System.Windows.Forms.TextBox
    Friend WithEvents txtMPN As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtMapPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblUrl As System.Windows.Forms.Label
    Friend WithEvents lblMPN As System.Windows.Forms.Label
    Friend WithEvents lblUPC As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblMapPrice As System.Windows.Forms.Label
    Friend WithEvents grpWebSource As System.Windows.Forms.GroupBox
    Friend WithEvents chk As System.Windows.Forms.CheckBox
    Friend WithEvents chkEbay As System.Windows.Forms.CheckBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtSelectedFile As System.Windows.Forms.TextBox
    Friend WithEvents LblCurrentFile As System.Windows.Forms.Label

End Class
