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
        Me.components = New System.ComponentModel.Container()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Minimize = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Close = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.LineShape1, Me.Minimize, Me.OvalShape2, Me.Close, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1280, 800)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'Minimize
        '
        Me.Minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Minimize.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Minimize.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Minimize.Location = New System.Drawing.Point(1206, 16)
        Me.Minimize.Name = "Minimize"
        Me.Minimize.Size = New System.Drawing.Size(14, 15)
        '
        'OvalShape2
        '
        Me.OvalShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.OvalShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.OvalShape2.Location = New System.Drawing.Point(1227, 16)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(14, 15)
        '
        'Close
        '
        Me.Close.BackColor = System.Drawing.Color.Red
        Me.Close.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Close.BorderColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close.Location = New System.Drawing.Point(1248, 16)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(14, 15)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1283, 46)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(558, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Acadomia"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 630
        Me.LineShape1.X2 = 630
        Me.LineShape1.Y1 = 79
        Me.LineShape1.Y2 = 748
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(708, 495)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(511, 61)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.Location = New System.Drawing.Point(707, 589)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(511, 61)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.Location = New System.Drawing.Point(844, 682)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(242, 60)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 800)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents Label1 As Label
    Friend WithEvents Close As PowerPacks.OvalShape
    Friend WithEvents Minimize As PowerPacks.OvalShape
    Friend WithEvents OvalShape2 As PowerPacks.OvalShape
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
End Class
