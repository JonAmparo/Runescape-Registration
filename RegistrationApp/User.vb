Public Class User

    Public newUser As User
    Private _username As String
    Private _password As String
    Private _firstname As String
    Private _lastname As String
    Private _dob As Date
    Private _address As String
    Private _telephone As String
    Private _school As String
    Private _program As String
    Private _character As Integer

    Public Sub New(Optional Username As String = "",
                   Optional Password As String = "",
                   Optional Firstname As String = "",
                   Optional Lastname As String = "",
                   Optional Address As String = "",
                   Optional Telephone As String = "",
                   Optional School As String = "",
                   Optional Program As String = "",
                   Optional Character As Integer = 0)
        'Optional Dob As Date = DateTime.Now,

        'Me._newUser = NewUser
        Me._username = Username
        Me._password = Password
        Me._firstname = Firstname
        Me._lastname = Lastname
        'Me._dob = Dob
        Me._address = Address
        Me._telephone = Telephone
        Me._school = School
        Me._program = Program
        Me._character = Character

    End Sub

    Public ReadOnly Property getCharacter() As Integer
        Get
            Return _character
        End Get
    End Property
    Public Sub SetCharacter(value As Integer)
        _character = value
    End Sub

    Public Property Program() As String
        Get
            Return _program
        End Get
        Set(ByVal value As String)
            _program = value
        End Set
    End Property

    Public Property School() As String
        Get
            Return _school
        End Get
        Set(ByVal value As String)
            _school = value
        End Set
    End Property

    Public Property Telephone() As String
        Get
            Return _telephone
        End Get
        Set(ByVal value As String)
            _telephone = value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set
    End Property

    Public Property Dob() As Date
        Get
            Return _dob
        End Get
        Set(ByVal value As Date)
            _dob = value
        End Set
    End Property

    Public Property Lastname() As String
        Get
            Return _lastname
        End Get
        Set(ByVal value As String)
            _lastname = value
        End Set
    End Property

    Public Property Firstname() As String
        Get
            Return _firstname
        End Get
        Set(ByVal value As String)
            _firstname = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    'Public Property NewUser() As String
    '    Get
    '        Return _newUser
    '    End Get
    '    Set(ByVal value As String)
    '        _newUser = value
    '    End Set
    'End Property
End Class
