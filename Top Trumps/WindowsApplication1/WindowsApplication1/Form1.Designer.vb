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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StartButton = New System.Windows.Forms.Button()
        Me.ListBoxName1 = New System.Windows.Forms.ListBox()
        Me.ListBoxName2 = New System.Windows.Forms.ListBox()
        Me.Qbutton = New System.Windows.Forms.Button()
        Me.Speed1 = New System.Windows.Forms.Label()
        Me.Size1 = New System.Windows.Forms.Label()
        Me.Lifespan1 = New System.Windows.Forms.Label()
        Me.Weight1 = New System.Windows.Forms.Label()
        Me.Weight2 = New System.Windows.Forms.Label()
        Me.Lifespan2 = New System.Windows.Forms.Label()
        Me.Size2 = New System.Windows.Forms.Label()
        Me.Speed2 = New System.Windows.Forms.Label()
        Me.SpeedAI = New System.Windows.Forms.Label()
        Me.SizeAI = New System.Windows.Forms.Label()
        Me.LifespanAI = New System.Windows.Forms.Label()
        Me.WeightAI = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelScore = New System.Windows.Forms.Label()
        Me.hintButton = New System.Windows.Forms.Button()
        Me.Ibutton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowLeaderboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picDisplay2 = New System.Windows.Forms.PictureBox()
        Me.picDisplay = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button_Card = New System.Windows.Forms.Button()
        Me.lbl_lifes = New System.Windows.Forms.Label()
        Me.lbl_lifesvalue = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picDisplay2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Transparent
        Me.StartButton.Font = New System.Drawing.Font("Forte", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(368, 89)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(149, 50)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Start..."
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'ListBoxName1
        '
        Me.ListBoxName1.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxName1.FormattingEnabled = True
        Me.ListBoxName1.ItemHeight = 16
        Me.ListBoxName1.Location = New System.Drawing.Point(109, 63)
        Me.ListBoxName1.Name = "ListBoxName1"
        Me.ListBoxName1.Size = New System.Drawing.Size(160, 20)
        Me.ListBoxName1.TabIndex = 11
        '
        'ListBoxName2
        '
        Me.ListBoxName2.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxName2.FormattingEnabled = True
        Me.ListBoxName2.ItemHeight = 16
        Me.ListBoxName2.Location = New System.Drawing.Point(612, 64)
        Me.ListBoxName2.Name = "ListBoxName2"
        Me.ListBoxName2.Size = New System.Drawing.Size(161, 20)
        Me.ListBoxName2.TabIndex = 12
        '
        'Qbutton
        '
        Me.Qbutton.BackColor = System.Drawing.Color.Transparent
        Me.Qbutton.Font = New System.Drawing.Font("Forte", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qbutton.Location = New System.Drawing.Point(799, 424)
        Me.Qbutton.Name = "Qbutton"
        Me.Qbutton.Size = New System.Drawing.Size(88, 34)
        Me.Qbutton.TabIndex = 14
        Me.Qbutton.Text = "Quit"
        Me.Qbutton.UseVisualStyleBackColor = False
        '
        'Speed1
        '
        Me.Speed1.AutoSize = True
        Me.Speed1.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Speed1.Location = New System.Drawing.Point(151, 232)
        Me.Speed1.Name = "Speed1"
        Me.Speed1.Size = New System.Drawing.Size(73, 16)
        Me.Speed1.TabIndex = 15
        Me.Speed1.Text = "Speed (mph)"
        '
        'Size1
        '
        Me.Size1.AutoSize = True
        Me.Size1.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size1.Location = New System.Drawing.Point(163, 249)
        Me.Size1.Name = "Size1"
        Me.Size1.Size = New System.Drawing.Size(48, 16)
        Me.Size1.TabIndex = 16
        Me.Size1.Text = "Size (m)"
        '
        'Lifespan1
        '
        Me.Lifespan1.AutoSize = True
        Me.Lifespan1.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lifespan1.Location = New System.Drawing.Point(145, 266)
        Me.Lifespan1.Name = "Lifespan1"
        Me.Lifespan1.Size = New System.Drawing.Size(91, 16)
        Me.Lifespan1.TabIndex = 17
        Me.Lifespan1.Text = "Lifespan (years)"
        '
        'Weight1
        '
        Me.Weight1.AutoSize = True
        Me.Weight1.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Weight1.Location = New System.Drawing.Point(156, 283)
        Me.Weight1.Name = "Weight1"
        Me.Weight1.Size = New System.Drawing.Size(66, 16)
        Me.Weight1.TabIndex = 18
        Me.Weight1.Text = "Weight (kg)"
        '
        'Weight2
        '
        Me.Weight2.AutoSize = True
        Me.Weight2.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Weight2.Location = New System.Drawing.Point(616, 283)
        Me.Weight2.Name = "Weight2"
        Me.Weight2.Size = New System.Drawing.Size(66, 16)
        Me.Weight2.TabIndex = 19
        Me.Weight2.Text = "Weight (kg)"
        '
        'Lifespan2
        '
        Me.Lifespan2.AutoSize = True
        Me.Lifespan2.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lifespan2.Location = New System.Drawing.Point(616, 266)
        Me.Lifespan2.Name = "Lifespan2"
        Me.Lifespan2.Size = New System.Drawing.Size(91, 16)
        Me.Lifespan2.TabIndex = 20
        Me.Lifespan2.Text = "Lifespan (years)"
        '
        'Size2
        '
        Me.Size2.AutoSize = True
        Me.Size2.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size2.Location = New System.Drawing.Point(616, 249)
        Me.Size2.Name = "Size2"
        Me.Size2.Size = New System.Drawing.Size(48, 16)
        Me.Size2.TabIndex = 21
        Me.Size2.Text = "Size (m)"
        '
        'Speed2
        '
        Me.Speed2.AutoSize = True
        Me.Speed2.Font = New System.Drawing.Font("Kristen ITC", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Speed2.Location = New System.Drawing.Point(616, 232)
        Me.Speed2.Name = "Speed2"
        Me.Speed2.Size = New System.Drawing.Size(73, 16)
        Me.Speed2.TabIndex = 22
        Me.Speed2.Text = "Speed (mph)"
        '
        'SpeedAI
        '
        Me.SpeedAI.AutoSize = True
        Me.SpeedAI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedAI.Location = New System.Drawing.Point(720, 235)
        Me.SpeedAI.Name = "SpeedAI"
        Me.SpeedAI.Size = New System.Drawing.Size(0, 13)
        Me.SpeedAI.TabIndex = 23
        '
        'SizeAI
        '
        Me.SizeAI.AutoSize = True
        Me.SizeAI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SizeAI.Location = New System.Drawing.Point(720, 250)
        Me.SizeAI.Name = "SizeAI"
        Me.SizeAI.Size = New System.Drawing.Size(0, 13)
        Me.SizeAI.TabIndex = 24
        '
        'LifespanAI
        '
        Me.LifespanAI.AutoSize = True
        Me.LifespanAI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LifespanAI.Location = New System.Drawing.Point(720, 267)
        Me.LifespanAI.Name = "LifespanAI"
        Me.LifespanAI.Size = New System.Drawing.Size(0, 13)
        Me.LifespanAI.TabIndex = 25
        '
        'WeightAI
        '
        Me.WeightAI.AutoSize = True
        Me.WeightAI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightAI.Location = New System.Drawing.Point(720, 284)
        Me.WeightAI.Name = "WeightAI"
        Me.WeightAI.Size = New System.Drawing.Size(0, 13)
        Me.WeightAI.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(399, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 22)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Score : "
        '
        'LabelScore
        '
        Me.LabelScore.AutoSize = True
        Me.LabelScore.BackColor = System.Drawing.Color.Transparent
        Me.LabelScore.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelScore.Location = New System.Drawing.Point(464, 38)
        Me.LabelScore.Name = "LabelScore"
        Me.LabelScore.Size = New System.Drawing.Size(21, 22)
        Me.LabelScore.TabIndex = 29
        Me.LabelScore.Text = "0"
        '
        'hintButton
        '
        Me.hintButton.BackColor = System.Drawing.Color.Transparent
        Me.hintButton.Font = New System.Drawing.Font("Forte", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hintButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.hintButton.Location = New System.Drawing.Point(397, 145)
        Me.hintButton.Name = "hintButton"
        Me.hintButton.Size = New System.Drawing.Size(88, 34)
        Me.hintButton.TabIndex = 31
        Me.hintButton.Text = "Hint"
        Me.hintButton.UseVisualStyleBackColor = False
        '
        'Ibutton
        '
        Me.Ibutton.BackColor = System.Drawing.Color.Transparent
        Me.Ibutton.Font = New System.Drawing.Font("Forte", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ibutton.ForeColor = System.Drawing.Color.Black
        Me.Ibutton.Location = New System.Drawing.Point(799, 384)
        Me.Ibutton.Name = "Ibutton"
        Me.Ibutton.Size = New System.Drawing.Size(88, 34)
        Me.Ibutton.TabIndex = 32
        Me.Ibutton.Text = "Instructions"
        Me.Ibutton.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Orange
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(909, 24)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowLeaderboardToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.FileToolStripMenuItem.Text = "Leaderboard"
        '
        'ShowLeaderboardToolStripMenuItem
        '
        Me.ShowLeaderboardToolStripMenuItem.Name = "ShowLeaderboardToolStripMenuItem"
        Me.ShowLeaderboardToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ShowLeaderboardToolStripMenuItem.Text = "Show leaderboard"
        '
        'picDisplay2
        '
        Me.picDisplay2.Location = New System.Drawing.Point(611, 98)
        Me.picDisplay2.Name = "picDisplay2"
        Me.picDisplay2.Size = New System.Drawing.Size(162, 119)
        Me.picDisplay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDisplay2.TabIndex = 13
        Me.picDisplay2.TabStop = False
        '
        'picDisplay
        '
        Me.picDisplay.Location = New System.Drawing.Point(109, 98)
        Me.picDisplay.Name = "picDisplay"
        Me.picDisplay.Size = New System.Drawing.Size(160, 119)
        Me.picDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDisplay.TabIndex = 9
        Me.picDisplay.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(95, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 273)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(598, 48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(188, 273)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(925, 519)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'Button_Card
        '
        Me.Button_Card.BackColor = System.Drawing.Color.Transparent
        Me.Button_Card.Font = New System.Drawing.Font("Forte", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Card.Location = New System.Drawing.Point(398, 185)
        Me.Button_Card.Name = "Button_Card"
        Me.Button_Card.Size = New System.Drawing.Size(87, 37)
        Me.Button_Card.TabIndex = 35
        Me.Button_Card.Text = "New Card"
        Me.Button_Card.UseVisualStyleBackColor = False
        '
        'lbl_lifes
        '
        Me.lbl_lifes.AutoSize = True
        Me.lbl_lifes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_lifes.Font = New System.Drawing.Font("Forte", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lifes.Location = New System.Drawing.Point(415, 64)
        Me.lbl_lifes.Name = "lbl_lifes"
        Me.lbl_lifes.Size = New System.Drawing.Size(42, 14)
        Me.lbl_lifes.TabIndex = 36
        Me.lbl_lifes.Text = "Lifes : "
        '
        'lbl_lifesvalue
        '
        Me.lbl_lifesvalue.AutoSize = True
        Me.lbl_lifesvalue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_lifesvalue.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lifesvalue.Location = New System.Drawing.Point(452, 60)
        Me.lbl_lifesvalue.Name = "lbl_lifesvalue"
        Me.lbl_lifesvalue.Size = New System.Drawing.Size(20, 21)
        Me.lbl_lifesvalue.TabIndex = 37
        Me.lbl_lifesvalue.Text = "3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(909, 480)
        Me.Controls.Add(Me.lbl_lifesvalue)
        Me.Controls.Add(Me.lbl_lifes)
        Me.Controls.Add(Me.Button_Card)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Ibutton)
        Me.Controls.Add(Me.hintButton)
        Me.Controls.Add(Me.LabelScore)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.WeightAI)
        Me.Controls.Add(Me.LifespanAI)
        Me.Controls.Add(Me.SizeAI)
        Me.Controls.Add(Me.SpeedAI)
        Me.Controls.Add(Me.Speed2)
        Me.Controls.Add(Me.Size2)
        Me.Controls.Add(Me.Lifespan2)
        Me.Controls.Add(Me.Weight2)
        Me.Controls.Add(Me.Weight1)
        Me.Controls.Add(Me.Lifespan1)
        Me.Controls.Add(Me.Size1)
        Me.Controls.Add(Me.Speed1)
        Me.Controls.Add(Me.Qbutton)
        Me.Controls.Add(Me.picDisplay2)
        Me.Controls.Add(Me.ListBoxName2)
        Me.Controls.Add(Me.ListBoxName1)
        Me.Controls.Add(Me.picDisplay)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(925, 519)
        Me.MinimumSize = New System.Drawing.Size(925, 519)
        Me.Name = "Form1"
        Me.Text = "Top Trumps"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picDisplay2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picDisplay As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ListBoxName1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxName2 As System.Windows.Forms.ListBox
    Friend WithEvents picDisplay2 As System.Windows.Forms.PictureBox
    Friend WithEvents Qbutton As System.Windows.Forms.Button
    Friend WithEvents Speed1 As System.Windows.Forms.Label
    Friend WithEvents Size1 As System.Windows.Forms.Label
    Friend WithEvents Lifespan1 As System.Windows.Forms.Label
    Friend WithEvents Weight1 As System.Windows.Forms.Label
    Friend WithEvents Weight2 As System.Windows.Forms.Label
    Friend WithEvents Lifespan2 As System.Windows.Forms.Label
    Friend WithEvents Size2 As System.Windows.Forms.Label
    Friend WithEvents Speed2 As System.Windows.Forms.Label
    Friend WithEvents SpeedAI As System.Windows.Forms.Label
    Friend WithEvents SizeAI As System.Windows.Forms.Label
    Friend WithEvents LifespanAI As System.Windows.Forms.Label
    Friend WithEvents WeightAI As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelScore As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents hintButton As System.Windows.Forms.Button
    Friend WithEvents Ibutton As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowLeaderboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button_Card As System.Windows.Forms.Button
    Friend WithEvents lbl_lifes As Label
    Friend WithEvents lbl_lifesvalue As Label
End Class
