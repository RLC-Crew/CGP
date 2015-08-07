﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión del motor en tiempo de ejecución:2.0.50727.3603
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization
Imports System.Configuration

'
'This source code was auto-generated by wsdl, Version=2.0.50727.3038.
'

Namespace UsrPagos.Dat_PC_Padron

    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
  System.Diagnostics.DebuggerStepThroughAttribute(), _
  System.ComponentModel.DesignerCategoryAttribute("code"), _
  System.Web.Services.WebServiceBindingAttribute(Name:="Dat_PC_PadronSoap", [Namespace]:="http://www.prosoft.cr/")> _
 Partial Public Class Dat_PC_Padron
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

        Private TraerRegistroBDOperationCompleted As System.Threading.SendOrPostCallback

        '''<remarks/>
        Public Sub New()
            MyBase.New()
            Me.Url = ConfigurationManager.AppSettings(Constantes.ServidorDatos) + "UsrPagos/Dat_PC_Padron.asmx"
        End Sub

        '''<remarks/>
        Public Event TraerRegistroBDCompleted As TraerRegistroBDCompletedEventHandler

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/TraerRegistroBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function TraerRegistroBD(ByVal v_Cedula As String, ByVal usuario As String, ByVal IP As String) As String
            Dim results() As Object = Me.Invoke("TraerRegistroBD", New Object() {v_Cedula, usuario, IP})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Function BeginTraerRegistroBD(ByVal v_Cedula As String, ByVal usuario As String, ByVal IP As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("TraerRegistroBD", New Object() {v_Cedula, usuario, IP}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndTraerRegistroBD(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub TraerRegistroBDAsync(ByVal v_Cedula As String, ByVal usuario As String, ByVal IP As String)
            Me.TraerRegistroBDAsync(v_Cedula, usuario, IP, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub TraerRegistroBDAsync(ByVal v_Cedula As String, ByVal usuario As String, ByVal IP As String, ByVal userState As Object)
            If (Me.TraerRegistroBDOperationCompleted Is Nothing) Then
                Me.TraerRegistroBDOperationCompleted = AddressOf Me.OnTraerRegistroBDOperationCompleted
            End If
            Me.InvokeAsync("TraerRegistroBD", New Object() {v_Cedula, usuario, IP}, Me.TraerRegistroBDOperationCompleted, userState)
        End Sub

        Private Sub OnTraerRegistroBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.TraerRegistroBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent TraerRegistroBDCompleted(Me, New TraerRegistroBDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub TraerRegistroBDCompletedEventHandler(ByVal sender As Object, ByVal e As TraerRegistroBDCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class TraerRegistroBDCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property
    End Class

End Namespace
