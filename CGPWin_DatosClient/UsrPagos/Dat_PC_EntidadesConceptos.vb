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
Imports System.Data
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization
Imports System.Configuration

'
'This source code was auto-generated by wsdl, Version=2.0.50727.3038.
'

Namespace UsrPagos.Dat_PC_EntidadesConceptos

    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
   System.Diagnostics.DebuggerStepThroughAttribute(), _
   System.ComponentModel.DesignerCategoryAttribute("code"), _
   System.Web.Services.WebServiceBindingAttribute(Name:="Dat_PC_EntidadesConceptosSoap", [Namespace]:="http://www.prosoft.cr/")> _
  Partial Public Class Dat_PC_EntidadesConceptos
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

        Private AgregarBDOperationCompleted As System.Threading.SendOrPostCallback

        Private BorrarBDOperationCompleted As System.Threading.SendOrPostCallback

        Private TraerRegistroBDOperationCompleted As System.Threading.SendOrPostCallback

        Private TraerListaTotalPorCentroOperationCompleted As System.Threading.SendOrPostCallback

        '''<remarks/>
        Public Sub New()
            MyBase.New()
            Me.Url = ConfigurationManager.AppSettings(Constantes.ServidorDatos) + "UsrPagos/Dat_PC_EntidadesConceptos.asmx"
        End Sub

        '''<remarks/>
        Public Event AgregarBDCompleted As AgregarBDCompletedEventHandler

        '''<remarks/>
        Public Event BorrarBDCompleted As BorrarBDCompletedEventHandler

        '''<remarks/>
        Public Event TraerRegistroBDCompleted As TraerRegistroBDCompletedEventHandler

        '''<remarks/>
        Public Event TraerListaTotalPorCentroCompleted As TraerListaTotalPorCentroCompletedEventHandler

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/AgregarBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function AgregarBD(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal v_CodigoEntidad As String, ByVal v_TipoImportacion As String, ByVal v_Dominio As String, ByVal v_url As String, ByVal v_usuario As String, ByVal v_password As String, ByVal usuario As String, ByVal IP As String) As Decimal
            Dim results() As Object = Me.Invoke("AgregarBD", New Object() {v_TipoOperacion, v_CodigoConcepto, v_CodigoEntidad, v_TipoImportacion, v_Dominio, v_url, v_usuario, v_password, usuario, IP})
            Return CType(results(0), Decimal)
        End Function

        '''<remarks/>
        Public Function BeginAgregarBD(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal v_CodigoEntidad As String, ByVal v_TipoImportacion As String, ByVal v_Dominio As String, ByVal v_url As String, ByVal v_usuario As String, ByVal v_password As String, ByVal usuario As String, ByVal IP As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("AgregarBD", New Object() {v_TipoOperacion, v_CodigoConcepto, v_CodigoEntidad, v_TipoImportacion, v_Dominio, v_url, v_usuario, v_password, usuario, IP}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndAgregarBD(ByVal asyncResult As System.IAsyncResult) As Decimal
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), Decimal)
        End Function

        '''<remarks/>
        Public Overloads Sub AgregarBDAsync(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal v_CodigoEntidad As String, ByVal v_TipoImportacion As String, ByVal v_Dominio As String, ByVal v_url As String, ByVal v_usuario As String, ByVal v_password As String, ByVal usuario As String, ByVal IP As String)
            Me.AgregarBDAsync(v_TipoOperacion, v_CodigoConcepto, v_CodigoEntidad, v_TipoImportacion, v_Dominio, v_url, v_usuario, v_password, usuario, IP, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub AgregarBDAsync(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal v_CodigoEntidad As String, ByVal v_TipoImportacion As String, ByVal v_Dominio As String, ByVal v_url As String, ByVal v_usuario As String, ByVal v_password As String, ByVal usuario As String, ByVal IP As String, ByVal userState As Object)
            If (Me.AgregarBDOperationCompleted Is Nothing) Then
                Me.AgregarBDOperationCompleted = AddressOf Me.OnAgregarBDOperationCompleted
            End If
            Me.InvokeAsync("AgregarBD", New Object() {v_TipoOperacion, v_CodigoConcepto, v_CodigoEntidad, v_TipoImportacion, v_Dominio, v_url, v_usuario, v_password, usuario, IP}, Me.AgregarBDOperationCompleted, userState)
        End Sub

        Private Sub OnAgregarBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.AgregarBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent AgregarBDCompleted(Me, New AgregarBDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/BorrarBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub BorrarBD(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal v_CodigoEntidad As String, ByVal usuario As String, ByVal IP As String)
            Me.Invoke("BorrarBD", New Object() {v_TipoOperacion, v_CodigoConcepto, v_CodigoEntidad, usuario, IP})
        End Sub

        '''<remarks/>
        Public Function BeginBorrarBD(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal v_CodigoEntidad As String, ByVal usuario As String, ByVal IP As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("BorrarBD", New Object() {v_TipoOperacion, v_CodigoConcepto, v_CodigoEntidad, usuario, IP}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndBorrarBD(ByVal asyncResult As System.IAsyncResult)
            Me.EndInvoke(asyncResult)
        End Sub

        '''<remarks/>
        Public Overloads Sub BorrarBDAsync(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal v_CodigoEntidad As String, ByVal usuario As String, ByVal IP As String)
            Me.BorrarBDAsync(v_TipoOperacion, v_CodigoConcepto, v_CodigoEntidad, usuario, IP, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub BorrarBDAsync(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal v_CodigoEntidad As String, ByVal usuario As String, ByVal IP As String, ByVal userState As Object)
            If (Me.BorrarBDOperationCompleted Is Nothing) Then
                Me.BorrarBDOperationCompleted = AddressOf Me.OnBorrarBDOperationCompleted
            End If
            Me.InvokeAsync("BorrarBD", New Object() {v_TipoOperacion, v_CodigoConcepto, v_CodigoEntidad, usuario, IP}, Me.BorrarBDOperationCompleted, userState)
        End Sub

        Private Sub OnBorrarBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.BorrarBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent BorrarBDCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/TraerRegistroBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub TraerRegistroBD(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal v_CodigoEntidad As String, ByRef v_url As String, ByRef v_dominio As String, ByRef v_user As String, ByRef v_pass As String, ByVal usuario As String, ByVal IP As String)
            Dim results() As Object = Me.Invoke("TraerRegistroBD", New Object() {v_TipoOperacion, v_CodigoConcepto, v_CodigoEntidad, v_url, v_dominio, v_user, v_pass, usuario, IP})
            v_url = CType(results(0), String)
            v_dominio = CType(results(1), String)
            v_user = CType(results(2), String)
            v_pass = CType(results(3), String)
        End Sub

        '''<remarks/>
        Public Function BeginTraerRegistroBD(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal v_CodigoEntidad As String, ByVal v_url As String, ByVal v_dominio As String, ByVal v_user As String, ByVal v_pass As String, ByVal usuario As String, ByVal IP As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("TraerRegistroBD", New Object() {v_TipoOperacion, v_CodigoConcepto, v_CodigoEntidad, v_url, v_dominio, v_user, v_pass, usuario, IP}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndTraerRegistroBD(ByVal asyncResult As System.IAsyncResult, ByRef v_url As String, ByRef v_dominio As String, ByRef v_user As String, ByRef v_pass As String)
            Dim results() As Object = Me.EndInvoke(asyncResult)
            v_url = CType(results(0), String)
            v_dominio = CType(results(1), String)
            v_user = CType(results(2), String)
            v_pass = CType(results(3), String)
        End Sub

        '''<remarks/>
        Public Overloads Sub TraerRegistroBDAsync(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal v_CodigoEntidad As String, ByVal v_url As String, ByVal v_dominio As String, ByVal v_user As String, ByVal v_pass As String, ByVal usuario As String, ByVal IP As String)
            Me.TraerRegistroBDAsync(v_TipoOperacion, v_CodigoConcepto, v_CodigoEntidad, v_url, v_dominio, v_user, v_pass, usuario, IP, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub TraerRegistroBDAsync(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal v_CodigoEntidad As String, ByVal v_url As String, ByVal v_dominio As String, ByVal v_user As String, ByVal v_pass As String, ByVal usuario As String, ByVal IP As String, ByVal userState As Object)
            If (Me.TraerRegistroBDOperationCompleted Is Nothing) Then
                Me.TraerRegistroBDOperationCompleted = AddressOf Me.OnTraerRegistroBDOperationCompleted
            End If
            Me.InvokeAsync("TraerRegistroBD", New Object() {v_TipoOperacion, v_CodigoConcepto, v_CodigoEntidad, v_url, v_dominio, v_user, v_pass, usuario, IP}, Me.TraerRegistroBDOperationCompleted, userState)
        End Sub

        Private Sub OnTraerRegistroBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.TraerRegistroBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent TraerRegistroBDCompleted(Me, New TraerRegistroBDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/TraerListaTotalPorCentro", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function TraerListaTotalPorCentro(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal usuario As String, ByVal IP As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("TraerListaTotalPorCentro", New Object() {v_TipoOperacion, v_CodigoConcepto, usuario, IP})
            Return CType(results(0), System.Data.DataSet)
        End Function

        '''<remarks/>
        Public Function BeginTraerListaTotalPorCentro(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal usuario As String, ByVal IP As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("TraerListaTotalPorCentro", New Object() {v_TipoOperacion, v_CodigoConcepto, usuario, IP}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndTraerListaTotalPorCentro(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), System.Data.DataSet)
        End Function

        '''<remarks/>
        Public Overloads Sub TraerListaTotalPorCentroAsync(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal usuario As String, ByVal IP As String)
            Me.TraerListaTotalPorCentroAsync(v_TipoOperacion, v_CodigoConcepto, usuario, IP, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub TraerListaTotalPorCentroAsync(ByVal v_TipoOperacion As String, ByVal v_CodigoConcepto As String, ByVal usuario As String, ByVal IP As String, ByVal userState As Object)
            If (Me.TraerListaTotalPorCentroOperationCompleted Is Nothing) Then
                Me.TraerListaTotalPorCentroOperationCompleted = AddressOf Me.OnTraerListaTotalPorCentroOperationCompleted
            End If
            Me.InvokeAsync("TraerListaTotalPorCentro", New Object() {v_TipoOperacion, v_CodigoConcepto, usuario, IP}, Me.TraerListaTotalPorCentroOperationCompleted, userState)
        End Sub

        Private Sub OnTraerListaTotalPorCentroOperationCompleted(ByVal arg As Object)
            If (Not (Me.TraerListaTotalPorCentroCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent TraerListaTotalPorCentroCompleted(Me, New TraerListaTotalPorCentroCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub AgregarBDCompletedEventHandler(ByVal sender As Object, ByVal e As AgregarBDCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class AgregarBDCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As Decimal
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Decimal)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub BorrarBDCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

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
        Public ReadOnly Property v_url() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property v_dominio() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(1), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property v_user() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(2), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property v_pass() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(3), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub TraerListaTotalPorCentroCompletedEventHandler(ByVal sender As Object, ByVal e As TraerListaTotalPorCentroCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class TraerListaTotalPorCentroCompletedEventArgs
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
