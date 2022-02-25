Public Class frmContactDirectory

    Const MAX_CONTACTS As Integer = 20

    Private firstName(MAX_CONTACTS) As String
    Private lastName(MAX_CONTACTS) As String
    Private phoneNumber(MAX_CONTACTS) As String

    Private currentIndex As Integer = 0

    Private Sub displayContact(ByVal index As Integer)

        MessageBox.Show(index & ")" & firstName(index) & " " & lastName(index) & " - " & phoneNumber(index))

    End Sub

    Private Sub addContact(ByVal fname As String, ByVal lname As String, ByVal pnumber As String)

        firstName(currentIndex) = fname
        lastName(currentIndex) = lname
        phoneNumber(currentIndex) = pnumber

        MessageBox.Show("Contact added successfully: " & currentIndex & ")" & firstName(currentIndex) & " " & lastName(currentIndex) & " - " & phoneNumber(currentIndex))

        currentIndex = currentIndex + 1
        clearAddContactForm()
        checkContactSize()


    End Sub

    Private Sub clearAddContactForm()

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPhoneNumber.Text = ""

    End Sub

    Private Sub checkContactSize()

        If currentIndex = MAX_CONTACTS Then

            MessageBox.Show("You have reached the max amount of contacts available.")

            btnAddNewContact.Enabled = False
            txtFirstName.Enabled = False
            txtLastName.Enabled = False
            txtPhoneNumber.Enabled = False

        End If
    End Sub

    Private Sub btnAddNewContact_Click(sender As Object, e As EventArgs) Handles btnAddNewContact.Click

        If String.IsNullOrEmpty(txtFirstName.Text) Then

            MessageBox.Show("Please enter a first name to continue.")
            Return
        ElseIf String.IsNullOrEmpty(txtLastName.Text) Then
            MessageBox.Show("Please enter a last name to continue.")
            Return
        ElseIf String.IsNullOrEmpty(txtPhoneNumber.Text) Then
            MessageBox.Show("Please enter a phone number to continue.")

        End If

        addContact(txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text)
    End Sub

    Private Sub btnSearchByName_Click(sender As Object, e As EventArgs) Handles btnSearchByName.Click

        Dim queryValue As String = txtSearchByName.Text
        Dim isLocated As Boolean = False

        If String.IsNullOrEmpty(queryValue) Then

            Return
        End If

        For index As Integer = 0 To MAX_CONTACTS - 1 Step 1

            If String.IsNullOrEmpty(firstName(index)) Then

                Exit For
            End If

            If firstName(index).ToLower() = queryValue.ToLower Or lastName(index).ToLower() = queryValue.ToLower Then

                displayContact(index)

                isLocated = True

                Exit For

            End If
        Next

        If Not isLocated Then

            MessageBox.Show("No contact meets this search")

        End If

    End Sub

    Private Sub btnSearchByID_Click(sender As Object, e As EventArgs) Handles btnSearchByID.Click

        Dim queryValue As String = txtSearchByID.Text

        If String.IsNullOrEmpty(queryValue) Then
            Return

        End If

        If Not IsNumeric(queryValue) Or CInt(queryValue) < 0 Or CInt(queryValue) >= MAX_CONTACTS Then

            MessageBox.Show("Please enter a valid index.")

            Return
        ElseIf String.IsNullOrEmpty(firstName(queryValue)) Then
            MessageBox.Show("No contact stored at that position.")

            Return
        End If

        displayContact(CInt(queryValue))

    End Sub
End Class

