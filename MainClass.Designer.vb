<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainClass
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
        Me.ImportFileButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BeginDNASearch = New System.Windows.Forms.Button()
        Me.ComboBoxForFileTools = New System.Windows.Forms.ComboBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Needs = New System.Windows.Forms.Label()
        Me.ComboBoxForNonFileTools = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ImportFileButton
        '
        Me.ImportFileButton.Location = New System.Drawing.Point(12, 157)
        Me.ImportFileButton.Name = "ImportFileButton"
        Me.ImportFileButton.Size = New System.Drawing.Size(77, 22)
        Me.ImportFileButton.TabIndex = 0
        Me.ImportFileButton.Text = "File Directory"
        Me.ImportFileButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 131)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(412, 20)
        Me.TextBox1.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BeginDNASearch
        '
        Me.BeginDNASearch.Location = New System.Drawing.Point(12, 251)
        Me.BeginDNASearch.Name = "BeginDNASearch"
        Me.BeginDNASearch.Size = New System.Drawing.Size(228, 23)
        Me.BeginDNASearch.TabIndex = 3
        Me.BeginDNASearch.Text = "Search"
        Me.BeginDNASearch.UseVisualStyleBackColor = True
        '
        'ComboBoxForFileTools
        '
        Me.ComboBoxForFileTools.FormattingEnabled = True
        Me.ComboBoxForFileTools.Items.AddRange(New Object() {"Mean, Median & Modal Length", "%C,A,G,T", "CG Content", "Basket of Lengths", "Search for Seq in File", "Regular Expression"})
        Me.ComboBoxForFileTools.Location = New System.Drawing.Point(12, 104)
        Me.ComboBoxForFileTools.Name = "ComboBoxForFileTools"
        Me.ComboBoxForFileTools.Size = New System.Drawing.Size(412, 21)
        Me.ComboBoxForFileTools.TabIndex = 4
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 324)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(412, 27)
        Me.ProgressBar1.TabIndex = 5
        '
        'Needs
        '
        Me.Needs.AutoSize = True
        Me.Needs.Location = New System.Drawing.Point(9, 52)
        Me.Needs.Name = "Needs"
        Me.Needs.Size = New System.Drawing.Size(0, 13)
        Me.Needs.TabIndex = 7
        '
        'ComboBoxForNonFileTools
        '
        Me.ComboBoxForNonFileTools.FormattingEnabled = True
        Me.ComboBoxForNonFileTools.Items.AddRange(New Object() {"Codon Usage", "Start and Stop Codons", "CpG Islands", "Random DNA Sequence", "PCR Primer Stats", "Translation Map"})
        Me.ComboBoxForNonFileTools.Location = New System.Drawing.Point(12, 224)
        Me.ComboBoxForNonFileTools.Name = "ComboBoxForNonFileTools"
        Me.ComboBoxForNonFileTools.Size = New System.Drawing.Size(412, 21)
        Me.ComboBoxForNonFileTools.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "File Required Tools - These Tools Require A Imported file"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Non-File Requied Tools"
        '
        'MainClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 467)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxForNonFileTools)
        Me.Controls.Add(Me.Needs)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ComboBoxForFileTools)
        Me.Controls.Add(Me.BeginDNASearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ImportFileButton)
        Me.Name = "MainClass"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImportFileButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BeginDNASearch As System.Windows.Forms.Button
    Friend WithEvents ComboBoxForFileTools As System.Windows.Forms.ComboBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Needs As System.Windows.Forms.Label
    Friend WithEvents ComboBoxForNonFileTools As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
