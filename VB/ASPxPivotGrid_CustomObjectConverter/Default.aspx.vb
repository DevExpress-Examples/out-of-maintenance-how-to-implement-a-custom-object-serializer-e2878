Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Web.UI
Imports DevExpress.Utils.Serializing.Helpers

Namespace ASPxPivotGrid_CustomObjectConverter
	Partial Public Class _Default
		Inherits Page
		Protected Overrides Sub OnInit(ByVal e As EventArgs)
			MyBase.OnInit(e)
			ASPxPivotGrid1.DataSource = DataHelper.GetData()
			ASPxPivotGrid1.OptionsData.CustomObjectConverter = New CustomObjectConverter()
		End Sub

		' Handles the Save button's Click event to save pivot grid data to a stream
		' (requires data source serialization).
		Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Session("Layout") = ASPxPivotGrid1.SaveLayoutToString()
		End Sub

		' Handles the Load button's Click event to load pivot grid data from a stream
		' (requires stream content deserialization).
		Protected Sub ASPxButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim layout As String = CStr(Session("Layout"))
			If layout Is Nothing Then
				Return
			End If
			ASPxPivotGrid1.LoadLayoutFromString(layout)
		End Sub
	End Class

	' Implements a custom serializer.
	Public Class CustomObjectConverter
		Implements ICustomObjectConverter

		' Returns a value, indicating whether objects of the specified type
		' can be serialized/deserialized.
		Public Function CanConvert(ByVal type As Type) As Boolean Implements ICustomObjectConverter.CanConvert
			Return type Is GetType(Employee)
		End Function

		' Deserializes objects of the specified type.
		Public Function FromString(ByVal type As Type, ByVal str As String) As Object Implements ICustomObjectConverter.FromString
			If type IsNot GetType(Employee) Then
				Return Nothing
			End If
			Dim array() As String = str.Split("#"c)
			If array.Length >= 3 Then
				Return New Employee(array(0), array(1), Integer.Parse(array(2)))
			ElseIf array.Length = 2 Then
				Return New Employee(array(0), array(1), 0)
			ElseIf array.Length = 1 Then
				Return New Employee(array(0), String.Empty, 0)
			Else
				Return New Employee(String.Empty, String.Empty, 0)
			End If
		End Function

		' Serializes objects of the specified type.
		Public Overloads Function ToString(ByVal type As Type, ByVal obj As Object) As String Implements ICustomObjectConverter.ToString
			If type IsNot GetType(Employee) Then
				Return String.Empty
			End If
			Dim value As Employee = TryCast(obj, Employee)
			Return value.FirstName + "#"c + value.LastName + "#"c + value.Age
		End Function

		' Returns the type by its full name.
		Public Overloads Function [GetType](ByVal typeName As String) As Type Implements ICustomObjectConverter.GetType
			If typeName IsNot GetType(Employee).FullName Then
				Return Nothing
			End If
			Return GetType(Employee)
		End Function
	End Class
End Namespace
