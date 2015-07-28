﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión del motor en tiempo de ejecución:2.0.50727.4952
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


Namespace Seguridad.UsrSeguridad.Dat_RolesSistema


    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Web.Services.WebServiceBindingAttribute(Name:="Dat_RolesSistemaSoap", [Namespace]:="http://www.prosoft.cr/")> _
    Partial Public Class Dat_RolesSistema
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

        Private AgregarBDOperationCompleted As System.Threading.SendOrPostCallback

        Private BorrarBDOperationCompleted As System.Threading.SendOrPostCallback

        Private ModificarBDOperationCompleted As System.Threading.SendOrPostCallback

        Private TraerRegistroBDOperationCompleted As System.Threading.SendOrPostCallback

        Private TraerListaTotalBDOperationCompleted As System.Threading.SendOrPostCallback

        Private CopiarOpcionesPerfilBDOperationCompleted As System.Threading.SendOrPostCallback

        Private AsignarOpcionesDeModuloBDOperationCompleted As System.Threading.SendOrPostCallback
        Public Sub New()
            MyBase.New()
            Me.Url = ConfigurationManager.AppSettings(Constantes.ServidorDatos) + "UsrSeguridad/Dat_RolesSistema.asmx"
        End Sub

        '''<remarks/>
        Public Event AgregarBDCompleted As AgregarBDCompletedEventHandler

        '''<remarks/>
        Public Event BorrarBDCompleted As BorrarBDCompletedEventHandler

        '''<remarks/>
        Public Event ModificarBDCompleted As ModificarBDCompletedEventHandler

        '''<remarks/>
        Public Event TraerRegistroBDCompleted As TraerRegistroBDCompletedEventHandler

        '''<remarks/>
        Public Event TraerListaTotalBDCompleted As TraerListaTotalBDCompletedEventHandler

        '''<remarks/>
        Public Event CopiarOpcionesPerfilBDCompleted As CopiarOpcionesPerfilBDCompletedEventHandler

        '''<remarks/>
        Public Event AsignarOpcionesDeModuloBDCompleted As AsignarOpcionesDeModuloBDCompletedEventHandler

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/AgregarBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub AgregarBD(ByVal varCodigoRol As Double, ByVal varNombreRol As String, ByVal varEstado As Char, ByVal usuario As String, ByVal IP As String)
            Me.Invoke("AgregarBD", New Object() {varCodigoRol, varNombreRol, varEstado, usuario, IP})
        End Sub

        '''<remarks/>
        Public Function BeginAgregarBD(ByVal varCodigoRol As Double, ByVal varNombreRol As String, ByVal varEstado As Char, ByVal usuario As String, ByVal IP As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("AgregarBD", New Object() {varCodigoRol, varNombreRol, varEstado, usuario, IP}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndAgregarBD(ByVal asyncResult As System.IAsyncResult)
            Me.EndInvoke(asyncResult)
        End Sub

        '''<remarks/>
        Public Overloads Sub AgregarBDAsync(ByVal varCodigoRol As Double, ByVal varNombreRol As String, ByVal varEstado As Char, ByVal usuario As String, ByVal IP As String)
            Me.AgregarBDAsync(varCodigoRol, varNombreRol, varEstado, usuario, IP, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub AgregarBDAsync(ByVal varCodigoRol As Double, ByVal varNombreRol As String, ByVal varEstado As Char, ByVal usuario As String, ByVal IP As String, ByVal userState As Object)
            If (Me.AgregarBDOperationCompleted Is Nothing) Then
                Me.AgregarBDOperationCompleted = AddressOf Me.OnAgregarBDOperationCompleted
            End If
            Me.InvokeAsync("AgregarBD", New Object() {varCodigoRol, varNombreRol, varEstado, usuario, IP}, Me.AgregarBDOperationCompleted, userState)
        End Sub

        Private Sub OnAgregarBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.AgregarBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent AgregarBDCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/BorrarBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub BorrarBD(ByVal varCodigoRol As Double, ByVal usuario As String, ByVal IP As String)
            Me.Invoke("BorrarBD", New Object() {varCodigoRol, usuario, IP})
        End Sub

        '''<remarks/>
        Public Function BeginBorrarBD(ByVal varCodigoRol As Double, ByVal usuario As String, ByVal IP As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("BorrarBD", New Object() {varCodigoRol, usuario, IP}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndBorrarBD(ByVal asyncResult As System.IAsyncResult)
            Me.EndInvoke(asyncResult)
        End Sub

        '''<remarks/>
        Public Overloads Sub BorrarBDAsync(ByVal varCodigoRol As Double, ByVal usuario As String, ByVal IP As String)
            Me.BorrarBDAsync(varCodigoRol, usuario, IP, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub BorrarBDAsync(ByVal varCodigoRol As Double, ByVal usuario As String, ByVal IP As String, ByVal userState As Object)
            If (Me.BorrarBDOperationCompleted Is Nothing) Then
                Me.BorrarBDOperationCompleted = AddressOf Me.OnBorrarBDOperationCompleted
            End If
            Me.InvokeAsync("BorrarBD", New Object() {varCodigoRol, usuario, IP}, Me.BorrarBDOperationCompleted, userState)
        End Sub

        Private Sub OnBorrarBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.BorrarBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent BorrarBDCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/ModificarBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub ModificarBD(ByVal varCodigoRol As Double, ByVal varNombreRol As String, ByVal varEstado As Char, ByVal usuario As String, ByVal IP As String)
            Me.Invoke("ModificarBD", New Object() {varCodigoRol, varNombreRol, varEstado, usuario, IP})
        End Sub

        '''<remarks/>
        Public Function BeginModificarBD(ByVal varCodigoRol As Double, ByVal varNombreRol As String, ByVal varEstado As Char, ByVal usuario As String, ByVal IP As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ModificarBD", New Object() {varCodigoRol, varNombreRol, varEstado, usuario, IP}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndModificarBD(ByVal asyncResult As System.IAsyncResult)
            Me.EndInvoke(asyncResult)
        End Sub

        '''<remarks/>
        Public Overloads Sub ModificarBDAsync(ByVal varCodigoRol As Double, ByVal varNombreRol As String, ByVal varEstado As Char, ByVal usuario As String, ByVal IP As String)
            Me.ModificarBDAsync(varCodigoRol, varNombreRol, varEstado, usuario, IP, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub ModificarBDAsync(ByVal varCodigoRol As Double, ByVal varNombreRol As String, ByVal varEstado As Char, ByVal usuario As String, ByVal IP As String, ByVal userState As Object)
            If (Me.ModificarBDOperationCompleted Is Nothing) Then
                Me.ModificarBDOperationCompleted = AddressOf Me.OnModificarBDOperationCompleted
            End If
            Me.InvokeAsync("ModificarBD", New Object() {varCodigoRol, varNombreRol, varEstado, usuario, IP}, Me.ModificarBDOperationCompleted, userState)
        End Sub

        Private Sub OnModificarBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.ModificarBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ModificarBDCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/TraerRegistroBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub TraerRegistroBD(ByVal varCodigoRol As Double, ByRef varNombreRol As String, ByRef varEstado As Char, ByVal usuario As String, ByVal IP As String)
            Dim results() As Object = Me.Invoke("TraerRegistroBD", New Object() {varCodigoRol, varNombreRol, varEstado, usuario, IP})
            varNombreRol = CType(results(0), String)
            varEstado = CType(results(1), Char)
        End Sub

        '''<remarks/>
        Public Function BeginTraerRegistroBD(ByVal varCodigoRol As Double, ByVal varNombreRol As String, ByVal varEstado As Char, ByVal usuario As String, ByVal IP As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("TraerRegistroBD", New Object() {varCodigoRol, varNombreRol, varEstado, usuario, IP}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndTraerRegistroBD(ByVal asyncResult As System.IAsyncResult, ByRef varNombreRol As String, ByRef varEstado As Char)
            Dim results() As Object = Me.EndInvoke(asyncResult)
            varNombreRol = CType(results(0), String)
            varEstado = CType(results(1), Char)
        End Sub

        '''<remarks/>
        Public Overloads Sub TraerRegistroBDAsync(ByVal varCodigoRol As Double, ByVal varNombreRol As String, ByVal varEstado As Char, ByVal usuario As String, ByVal IP As String)
            Me.TraerRegistroBDAsync(varCodigoRol, varNombreRol, varEstado, usuario, IP, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub TraerRegistroBDAsync(ByVal varCodigoRol As Double, ByVal varNombreRol As String, ByVal varEstado As Char, ByVal usuario As String, ByVal IP As String, ByVal userState As Object)
            If (Me.TraerRegistroBDOperationCompleted Is Nothing) Then
                Me.TraerRegistroBDOperationCompleted = AddressOf Me.OnTraerRegistroBDOperationCompleted
            End If
            Me.InvokeAsync("TraerRegistroBD", New Object() {varCodigoRol, varNombreRol, varEstado, usuario, IP}, Me.TraerRegistroBDOperationCompleted, userState)
        End Sub

        Private Sub OnTraerRegistroBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.TraerRegistroBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent TraerRegistroBDCompleted(Me, New TraerRegistroBDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/TraerListaTotalBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function TraerListaTotalBD(ByVal ListaCondiciones As clsListaCondiciones, ByVal MaxRegistros As Integer, ByVal usuario As String, ByVal IP As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("TraerListaTotalBD", New Object() {ListaCondiciones, MaxRegistros, usuario, IP})
            Return CType(results(0), System.Data.DataSet)
        End Function

        '''<remarks/>
        Public Function BeginTraerListaTotalBD(ByVal ListaCondiciones As clsListaCondiciones, ByVal MaxRegistros As Integer, ByVal usuario As String, ByVal IP As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("TraerListaTotalBD", New Object() {ListaCondiciones, MaxRegistros, usuario, IP}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndTraerListaTotalBD(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), System.Data.DataSet)
        End Function

        '''<remarks/>
        Public Overloads Sub TraerListaTotalBDAsync(ByVal ListaCondiciones As clsListaCondiciones, ByVal MaxRegistros As Integer, ByVal usuario As String, ByVal IP As String)
            Me.TraerListaTotalBDAsync(ListaCondiciones, MaxRegistros, usuario, IP, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub TraerListaTotalBDAsync(ByVal ListaCondiciones As clsListaCondiciones, ByVal MaxRegistros As Integer, ByVal usuario As String, ByVal IP As String, ByVal userState As Object)
            If (Me.TraerListaTotalBDOperationCompleted Is Nothing) Then
                Me.TraerListaTotalBDOperationCompleted = AddressOf Me.OnTraerListaTotalBDOperationCompleted
            End If
            Me.InvokeAsync("TraerListaTotalBD", New Object() {ListaCondiciones, MaxRegistros, usuario, IP}, Me.TraerListaTotalBDOperationCompleted, userState)
        End Sub

        Private Sub OnTraerListaTotalBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.TraerListaTotalBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent TraerListaTotalBDCompleted(Me, New TraerListaTotalBDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/CopiarOpcionesPerfilBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub CopiarOpcionesPerfilBD(ByVal PerfilOrigen As Double, ByVal PerfilDestino As Double, ByVal usuario As String, ByVal IP As String)
            Me.Invoke("CopiarOpcionesPerfilBD", New Object() {PerfilOrigen, PerfilDestino, usuario, IP})
        End Sub

        '''<remarks/>
        Public Function BeginCopiarOpcionesPerfilBD(ByVal PerfilOrigen As Double, ByVal PerfilDestino As Double, ByVal usuario As String, ByVal IP As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("CopiarOpcionesPerfilBD", New Object() {PerfilOrigen, PerfilDestino, usuario, IP}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndCopiarOpcionesPerfilBD(ByVal asyncResult As System.IAsyncResult)
            Me.EndInvoke(asyncResult)
        End Sub

        '''<remarks/>
        Public Overloads Sub CopiarOpcionesPerfilBDAsync(ByVal PerfilOrigen As Double, ByVal PerfilDestino As Double, ByVal usuario As String, ByVal IP As String)
            Me.CopiarOpcionesPerfilBDAsync(PerfilOrigen, PerfilDestino, usuario, IP, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub CopiarOpcionesPerfilBDAsync(ByVal PerfilOrigen As Double, ByVal PerfilDestino As Double, ByVal usuario As String, ByVal IP As String, ByVal userState As Object)
            If (Me.CopiarOpcionesPerfilBDOperationCompleted Is Nothing) Then
                Me.CopiarOpcionesPerfilBDOperationCompleted = AddressOf Me.OnCopiarOpcionesPerfilBDOperationCompleted
            End If
            Me.InvokeAsync("CopiarOpcionesPerfilBD", New Object() {PerfilOrigen, PerfilDestino, usuario, IP}, Me.CopiarOpcionesPerfilBDOperationCompleted, userState)
        End Sub

        Private Sub OnCopiarOpcionesPerfilBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.CopiarOpcionesPerfilBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CopiarOpcionesPerfilBDCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/AsignarOpcionesDeModuloBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub AsignarOpcionesDeModuloBD(ByVal PerfilDestino As Double, ByVal CodigoSistema As Double, ByVal CodigoModulo As Double, ByVal usuario As String, ByVal IP As String)
            Me.Invoke("AsignarOpcionesDeModuloBD", New Object() {PerfilDestino, CodigoSistema, CodigoModulo, usuario, IP})
        End Sub

        '''<remarks/>
        Public Function BeginAsignarOpcionesDeModuloBD(ByVal PerfilDestino As Double, ByVal CodigoSistema As Double, ByVal CodigoModulo As Double, ByVal usuario As String, ByVal IP As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("AsignarOpcionesDeModuloBD", New Object() {PerfilDestino, CodigoSistema, CodigoModulo, usuario, IP}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndAsignarOpcionesDeModuloBD(ByVal asyncResult As System.IAsyncResult)
            Me.EndInvoke(asyncResult)
        End Sub

        '''<remarks/>
        Public Overloads Sub AsignarOpcionesDeModuloBDAsync(ByVal PerfilDestino As Double, ByVal CodigoSistema As Double, ByVal CodigoModulo As Double, ByVal usuario As String, ByVal IP As String)
            Me.AsignarOpcionesDeModuloBDAsync(PerfilDestino, CodigoSistema, CodigoModulo, usuario, IP, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub AsignarOpcionesDeModuloBDAsync(ByVal PerfilDestino As Double, ByVal CodigoSistema As Double, ByVal CodigoModulo As Double, ByVal usuario As String, ByVal IP As String, ByVal userState As Object)
            If (Me.AsignarOpcionesDeModuloBDOperationCompleted Is Nothing) Then
                Me.AsignarOpcionesDeModuloBDOperationCompleted = AddressOf Me.OnAsignarOpcionesDeModuloBDOperationCompleted
            End If
            Me.InvokeAsync("AsignarOpcionesDeModuloBD", New Object() {PerfilDestino, CodigoSistema, CodigoModulo, usuario, IP}, Me.AsignarOpcionesDeModuloBDOperationCompleted, userState)
        End Sub

        Private Sub OnAsignarOpcionesDeModuloBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.AsignarOpcionesDeModuloBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent AsignarOpcionesDeModuloBDCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub AgregarBDCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub BorrarBDCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub ModificarBDCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

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
        Public ReadOnly Property varNombreRol() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property varEstado() As Char
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(1), Char)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub TraerListaTotalBDCompletedEventHandler(ByVal sender As Object, ByVal e As TraerListaTotalBDCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class TraerListaTotalBDCompletedEventArgs
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

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub CopiarOpcionesPerfilBDCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub AsignarOpcionesDeModuloBDCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
End Namespace