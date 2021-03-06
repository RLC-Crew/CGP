﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.34014
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization
Imports System.Configuration
'
'This source code was auto-generated by wsdl, Version=4.0.30319.1.
'
Namespace Seguridad.UsrSeguridad.Dat_SG_UsuariosCentros

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Web.Services.WebServiceBindingAttribute(Name:="Dat_SG_UsuariosCentrosSoap", [Namespace]:="http://www.prosoft.cr/")> _
    Partial Public Class Dat_SG_UsuariosCentros
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

        Private ObtenerCentroCostoUsuariosOperationCompleted As System.Threading.SendOrPostCallback

        '''<remarks/>
        Public Sub New()
            MyBase.New()
            Me.Url = ConfigurationManager.AppSettings(Constantes.ServidorDatos) + "UsrSeguridad/Dat_SG_UsuariosCentros.asmx"
        End Sub

        '''<remarks/>
        Public Event ObtenerCentroCostoUsuariosCompleted As ObtenerCentroCostoUsuariosCompletedEventHandler

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/ObtenerCentroCostoUsuarios", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function ObtenerCentroCostoUsuarios(<System.Xml.Serialization.XmlElementAttribute(IsNullable:=True)> ByVal varEstado As System.Nullable(Of Char), ByVal varCedula As String, <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True)> ByVal varCodRol As System.Nullable(Of Integer), <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True)> ByVal varCodCentro As System.Nullable(Of Integer), ByVal usuario As String, ByVal IP As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("ObtenerCentroCostoUsuarios", New Object() {varEstado, varCedula, varCodRol, varCodCentro, usuario, IP})
            Return CType(results(0), System.Data.DataSet)
        End Function

        '''<remarks/>
        Public Function BeginObtenerCentroCostoUsuarios(ByVal varEstado As System.Nullable(Of Char), ByVal varCedula As String, ByVal varCodRol As System.Nullable(Of Integer), ByVal varCodCentro As System.Nullable(Of Integer), ByVal usuario As String, ByVal IP As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ObtenerCentroCostoUsuarios", New Object() {varEstado, varCedula, varCodRol, varCodCentro, usuario, IP}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndObtenerCentroCostoUsuarios(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), System.Data.DataSet)
        End Function

        '''<remarks/>
        Public Overloads Sub ObtenerCentroCostoUsuariosAsync(ByVal varEstado As System.Nullable(Of Char), ByVal varCedula As String, ByVal varCodRol As System.Nullable(Of Integer), ByVal varCodCentro As System.Nullable(Of Integer), ByVal usuario As String, ByVal IP As String)
            Me.ObtenerCentroCostoUsuariosAsync(varEstado, varCedula, varCodRol, varCodCentro, usuario, IP, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub ObtenerCentroCostoUsuariosAsync(ByVal varEstado As System.Nullable(Of Char), ByVal varCedula As String, ByVal varCodRol As System.Nullable(Of Integer), ByVal varCodCentro As System.Nullable(Of Integer), ByVal usuario As String, ByVal IP As String, ByVal userState As Object)
            If (Me.ObtenerCentroCostoUsuariosOperationCompleted Is Nothing) Then
                Me.ObtenerCentroCostoUsuariosOperationCompleted = AddressOf Me.OnObtenerCentroCostoUsuariosOperationCompleted
            End If
            Me.InvokeAsync("ObtenerCentroCostoUsuarios", New Object() {varEstado, varCedula, varCodRol, varCodCentro, usuario, IP}, Me.ObtenerCentroCostoUsuariosOperationCompleted, userState)
        End Sub

        Private Sub OnObtenerCentroCostoUsuariosOperationCompleted(ByVal arg As Object)
            If (Not (Me.ObtenerCentroCostoUsuariosCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ObtenerCentroCostoUsuariosCompleted(Me, New ObtenerCentroCostoUsuariosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")> _
    Public Delegate Sub ObtenerCentroCostoUsuariosCompletedEventHandler(ByVal sender As Object, ByVal e As ObtenerCentroCostoUsuariosCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class ObtenerCentroCostoUsuariosCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As System.Data.DataSet
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), System.Data.DataSet)
            End Get
        End Property
    End Class
End Namespace