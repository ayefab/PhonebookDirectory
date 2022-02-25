<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContactDirectory
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSearchbyName = New System.Windows.Forms.Label()
        Me.lblSearchByID = New System.Windows.Forms.Label()
        Me.txtSearchByName = New System.Windows.Forms.TextBox()
        Me.txtSearchByID = New System.Windows.Forms.TextBox()
        Me.btnSearchByName = New System.Windows.Forms.Button()
        Me.btnSearchByID = New System.Windows.Forms.Button()
        Me.lblAddNewContact = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.btnAddNewContact = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(124, 18)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Contact Directory"
        '
        'lblSearchbyName
        '
        Me.lblSearchbyName.AutoSize = True
        Me.lblSearchbyName.Location = New System.Drawing.Point(12, 41)
        Me.lblSearchbyName.Name = "lblSearchbyName"
        Me.lblSearchbyName.Size = New System.Drawing.Size(90, 13)
        Me.lblSearchbyName.TabIndex = 1
        Me.lblSearchbyName.Text = "Search By Name:"
        '
        'lblSearchByID
        '
        Me.lblSearchByID.AutoSize = True
        Me.lblSearchByID.Location = New System.Drawing.Point(12, 76)
        Me.lblSearchByID.Name = "lblSearchByID"
        Me.lblSearchByID.Size = New System.Drawing.Size(73, 13)
        Me.lblSearchByID.TabIndex = 2
        Me.lblSearchByID.Text = "Search By ID:"
        '
        'txtSearchByName
        '
        Me.txtSearchByName.Location = New System.Drawing.Point(109, 41)
        Me.txtSearchByName.Name = "txtSearchByName"
        Me.txtSearchByName.Size = New System.Drawing.Size(200, 20)
        Me.txtSearchByName.TabIndex = 3
        '
        'txtSearchByID
        '
        Me.txtSearchByID.Location = New System.Drawing.Point(109, 76)
        Me.txtSearchByID.Name = "txtSearchByID"
        Me.txtSearchByID.Size = New System.Drawing.Size(200, 20)
        Me.txtSearchByID.TabIndex = 4
        '
        'btnSearchByName
        '
        Me.btnSearchByName.Location = New System.Drawing.Point(332, 41)
        Me.btnSearchByName.Name = "btnSearchByName"
        Me.btnSearchByName.Size = New System.Drawing.Size(130, 23)
        Me.btnSearchByName.TabIndex = 5
        Me.btnSearchByName.Text = "Search For Name >>"
        Me.btnSearchByName.UseVisualStyleBackColor = True
        '
        'btnSearchByID
        '
        Me.btnSearchByID.Location = New System.Drawing.Point(332, 76)
        Me.btnSearchByID.Name = "btnSearchByID"
        Me.btnSearchByID.Size = New System.Drawing.Size(130, 23)
        Me.btnSearchByID.TabIndex = 6
        Me.btnSearchByID.Text = "Search For ID >>"
        Me.btnSearchByID.UseVisualStyleBackColor = True
        '
        'lblAddNewContact
        '
        Me.lblAddNewContact.AutoSize = True
        Me.lblAddNewContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddNewContact.Location = New System.Drawing.Point(12, 117)
        Me.lblAddNewContact.Name = "lblAddNewContact"
        Me.lblAddNewContact.Size = New System.Drawing.Size(123, 18)
        Me.lblAddNewContact.TabIndex = 7
        Me.lblAddNewContact.Text = "Add New Contact"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(12, 152)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 8
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(160, 152)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 9
        Me.lblLastName.Text = "Last Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(15, 179)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 10
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(163, 179)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 11
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(319, 152)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(81, 13)
        Me.lblPhoneNumber.TabIndex = 12
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(322, 179)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtPhoneNumber.TabIndex = 13
        '
        'btnAddNewContact
        '
        Me.btnAddNewContact.Location = New System.Drawing.Point(15, 209)
        Me.btnAddNewContact.Name = "btnAddNewContact"
        Me.btnAddNewContact.Size = New System.Drawing.Size(120, 40)
        Me.btnAddNewContact.TabIndex = 14
        Me.btnAddNewContact.Text = "Add New Contact"
        Me.btnAddNewContact.UseVisualStyleBackColor = True
        '
        'frmContactDirectory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.btnAddNewContact)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblAddNewContact)
        Me.Controls.Add(Me.btnSearchByID)
        Me.Controls.Add(Me.btnSearchByName)
        Me.Controls.Add(Me.txtSearchByID)
        Me.Controls.Add(Me.txtSearchByName)
        Me.Controls.Add(Me.lblSearchByID)
        Me.Controls.Add(Me.lblSearchbyName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmContactDirectory"
        Me.Text = "Contact Directory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSearchbyName As Label
    Friend WithEvents lblSearchByID As Label
    Friend WithEvents txtSearchByName As TextBox
    Friend WithEvents txtSearchByID As TextBox
    Friend WithEvents btnSearchByName As Button
    Friend WithEvents btnSearchByID As Button
    Friend WithEvents lblAddNewContact As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents btnAddNewContact As Button
End Class
