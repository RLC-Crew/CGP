﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3603
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
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
'This source code was auto-generated by wsdl, Version=2.0.50727.1432.
'
Namespace Seguridad.UsrSeguridad.Dat_Padron


    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Web.Services.WebServiceBindingAttribute(Name:="Dat_PadronSoap", [Namespace]:="http://www.prosoft.cr/")> _
    Partial Public Class Dat_Padron
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

        Private TraerRegistroBDOperationCompleted As System.Threading.SendOrPostCallback

        '''<remarks/>
        Public Sub New()
            MyBase.New()
            Me.Url = ConfigurationManager.AppSettings(Constantes.ServidorDatos) + "UsrSeguridad/Dat_Padron.asmx"
        End Sub

        '''<remarks/>
        Public Event TraerRegistroBDCompleted As TraerRegistroBDCompletedEventHandler

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/TraerRegistroBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub TraerRegistroBD(ByVal varCedula As String, ByRef varCodigoElectoral As String, ByRef varSexo As Char, ByRef varFechaCaducidad As Date, ByRef varNombre As String, ByRef varPrimerApellido As String, ByRef varSegundoApellido As String, ByRef varEstado As Char)
            Dim results() As Object = Me.Invoke("TraerRegistroBD", New Object() {varCedula, varCodigoElectoral, varSexo, varFechaCaducidad, varNombre, varPrimerApellido, varSegundoApellido, varEstado})
            varCodigoElectoral = CType(results(0), String)
            varSexo = CType(results(1), Char)
            varFechaCaducidad = CType(results(2), Date)
            varNombre = CType(results(3), String)
            varPrimerApellido = CType(results(4), String)
            varSegundoApellido = CType(results(5), String)
            varEstado = CType(results(6), Char)
        End Sub

        '''<remarks/>
        Public Function BeginTraerRegistroBD(ByVal varCedula As String, ByVal varCodigoElectoral As String, ByVal varSexo As Char, ByVal varFechaCaducidad As Date, ByVal varNombre As String, ByVal varPrimerApellido As String, ByVal varSegundoApellido As String, ByVal varEstado As Char, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("TraerRegistroBD", New Object() {varCedula, varCodigoElectoral, varSexo, varFechaCaducidad, varNombre, varPrimerApellido, varSegundoApellido, varEstado}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndTraerRegistroBD(ByVal asyncResult As System.IAsyncResult, ByRef varCodigoElectoral As String, ByRef varSexo As Char, ByRef varFechaCaducidad As Date, ByRef varNombre As String, ByRef varPrimerApellido As String, ByRef varSegundoApellido As String, ByRef varEstado As Char)
            Dim results() As Object = Me.EndInvoke(asyncResult)
            varCodigoElectoral = CType(results(0), String)
            varSexo = CType(results(1), Char)
            varFechaCaducidad = CType(results(2), Date)
            varNombre = CType(results(3), String)
            varPrimerApellido = CType(results(4), String)
            varSegundoApellido = CType(results(5), String)
            varEstado = CType(results(6), Char)
        End Sub

        '''<remarks/>
        Public Overloads Sub TraerRegistroBDAsync(ByVal varCedula As String, ByVal varCodigoElectoral As String, ByVal varSexo As Char, ByVal varFechaCaducidad As Date, ByVal varNombre As String, ByVal varPrimerApellido As String, ByVal varSegundoApellido As String, ByVal varEstado As Char)
            Me.TraerRegistroBDAsync(varCedula, varCodigoElectoral, varSexo, varFechaCaducidad, varNombre, varPrimerApellido, varSegundoApellido, varEstado, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub TraerRegistroBDAsync(ByVal varCedula As String, ByVal varCodigoElectoral As String, ByVal varSexo As Char, ByVal varFechaCaducidad As Date, ByVal varNombre As String, ByVal varPrimerApellido As String, ByVal varSegundoApellido As String, ByVal varEstado As Char, ByVal userState As Object)
            If (Me.TraerRegistroBDOperationCompleted Is Nothing) Then
                Me.TraerRegistroBDOperationCompleted = AddressOf Me.OnTraerRegistroBDOperationCompleted
            End If
            Me.InvokeAsync("TraerRegistroBD", New Object() {varCedula, varCodigoElectoral, varSexo, varFechaCaducidad, varNombre, varPrimerApellido, varSegundoApellido, varEstado}, Me.TraerRegistroBDOperationCompleted, userState)
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")> _
    Public Delegate Sub TraerRegistroBDCompletedEventHandler(ByVal sender As Object, ByVal e As TraerRegistroBDCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432"), _
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
        Public ReadOnly Property varCodigoElectoral() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property varSexo() As Char
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(1), Char)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property varFechaCaducidad() As Date
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(2), Date)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property varNombre() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(3), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property varPrimerApellido() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(4), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property varSegundoApellido() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(5), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property varEstado() As Char
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(6), Char)
            End Get
        End Property
    End Class
End Namespace