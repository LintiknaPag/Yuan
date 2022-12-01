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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtRooms = New System.Windows.Forms.TextBox()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRooms = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DB = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(635, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HOTEL RESERVATION MANAGEMENT SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "How many rooms will you avail?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "How many days will you stay?"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(131, 17)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 4
        '
        'txtRooms
        '
        Me.txtRooms.Location = New System.Drawing.Point(222, 56)
        Me.txtRooms.Name = "txtRooms"
        Me.txtRooms.Size = New System.Drawing.Size(100, 22)
        Me.txtRooms.TabIndex = 5
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(210, 93)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(100, 22)
        Me.txtDays.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDays)
        Me.GroupBox1.Controls.Add(Me.txtRooms)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 145)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reservation"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPrice)
        Me.GroupBox2.Controls.Add(Me.lblDays)
        Me.GroupBox2.Controls.Add(Me.lblRooms)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(407, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 154)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Room/Rooms:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Day/Days:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Total Price:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(181, 18)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 16)
        Me.lblName.TabIndex = 4
        '
        'lblRooms
        '
        Me.lblRooms.AutoSize = True
        Me.lblRooms.Location = New System.Drawing.Point(181, 50)
        Me.lblRooms.Name = "lblRooms"
        Me.lblRooms.Size = New System.Drawing.Size(0, 16)
        Me.lblRooms.TabIndex = 5
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(181, 90)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(0, 16)
        Me.lblDays.TabIndex = 6
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(181, 123)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 16)
        Me.lblPrice.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 29)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(176, 221)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 29)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(49, 261)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(671, 135)
        Me.DataGridView1.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id"
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "name"
        Me.Column2.HeaderText = "NAME"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "room"
        Me.Column3.HeaderText = "ROOM/ROOMS"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "day"
        Me.Column4.HeaderText = "DAY/DAYS"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "price"
        Me.Column5.HeaderText = "PRICE"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'DB
        '
        Me.DB.Location = New System.Drawing.Point(283, 221)
        Me.DB.Name = "DB"
        Me.DB.Size = New System.Drawing.Size(75, 23)
        Me.DB.TabIndex = 12
        Me.DB.Text = "DB"
        Me.DB.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(122, 415)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "ADD"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(212, 415)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "VIEW"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DB)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtRooms As TextBox
    Friend WithEvents txtDays As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents lblRooms As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents DB As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
