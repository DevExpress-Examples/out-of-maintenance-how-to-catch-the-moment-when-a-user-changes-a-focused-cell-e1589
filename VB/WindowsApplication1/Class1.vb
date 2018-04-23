Imports Microsoft.VisualBasic
Imports System

Namespace WindowsApplication1
	Public Class Record
		Private fID As Integer
		Private fProductName As String
		Private fCategory As String
		Private fDiscontinued As Boolean
		Private fUnitPrice As Double
		Private fA As Integer
		Private fB As Integer
		Private fC As Integer
		Private fD As Integer
		Private fE As Integer
		Private fF As Integer
		Private fG As Integer
		Private fH As Integer
		Private fI As Integer
		Private fJ As Integer

		Public Sub New(ByVal fID As Integer, ByVal fProductName As String, ByVal fCategory As String, ByVal fDiscontinued As Boolean, ByVal fUnitPrice As Double)
			Me.fID = fID
			Me.fProductName = fProductName
			Me.fCategory = fCategory
			Me.fDiscontinued = fDiscontinued
			Me.fUnitPrice = fUnitPrice
		End Sub

		Public ReadOnly Property ID() As Integer
			Get
				Return fID
			End Get
		End Property

		Public Property ProductName() As String
			Get
				Return fProductName
			End Get
			Set(ByVal value As String)
				fProductName = value
			End Set
		End Property

		Public Property Category() As String
			Get
				Return fCategory
			End Get
			Set(ByVal value As String)
				fCategory = value
			End Set
		End Property

		Public Property Discontinued() As Boolean
			Get
				Return fDiscontinued
			End Get
			Set(ByVal value As Boolean)
				fDiscontinued = value
			End Set
		End Property

		Public Property UnitPrice() As Double
			Get
				Return fUnitPrice
			End Get
			Set(ByVal value As Double)
				fUnitPrice = value
			End Set
		End Property

		Public Property A() As Integer
			Get
				Return fA
			End Get
			Set(ByVal value As Integer)
				fA = value
			End Set
		End Property
		Public Property B() As Integer
			Get
				Return fB
			End Get
			Set(ByVal value As Integer)
				fB = value
			End Set
		End Property
		Public Property C() As Integer
			Get
				Return fC
			End Get
			Set(ByVal value As Integer)
				fC = value
			End Set
		End Property
		Public Property D() As Integer
			Get
				Return fD
			End Get
			Set(ByVal value As Integer)
				fD = value
			End Set
		End Property
		Public Property E() As Integer
			Get
				Return fE
			End Get
			Set(ByVal value As Integer)
				fE = value
			End Set
		End Property
		Public Property F() As Integer
			Get
				Return fF
			End Get
			Set(ByVal value As Integer)
				fF = value
			End Set
		End Property

		Public Property G() As Integer
			Get
				Return fG
			End Get
			Set(ByVal value As Integer)
				fF = value
			End Set
		End Property

		Public Property H() As Integer
			Get
				Return fF
			End Get
			Set(ByVal value As Integer)
				fF = value
			End Set
		End Property

		Public Property I() As Integer
			Get
				Return fF
			End Get
			Set(ByVal value As Integer)
				fF = value
			End Set
		End Property
		Public Property J() As Integer
			Get
				Return fF
			End Get
			Set(ByVal value As Integer)
				fF = value
			End Set
		End Property
	End Class
End Namespace
