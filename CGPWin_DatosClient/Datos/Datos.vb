'''<comentarios/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
 System.SerializableAttribute(), _
 System.Diagnostics.DebuggerStepThroughAttribute(), _
 System.ComponentModel.DesignerCategoryAttribute("code"), _
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.prosoft.cr/")> _
Partial Public Class clsListaCondiciones

    Private listaField() As clsCondicion

    '''<comentarios/>
    Public Property Lista() As clsCondicion()
        Get
            Return Me.listaField
        End Get
        Set(ByVal value As clsCondicion())
            Me.listaField = value
        End Set
    End Property
End Class

'''<comentarios/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
 System.SerializableAttribute(), _
 System.Diagnostics.DebuggerStepThroughAttribute(), _
 System.ComponentModel.DesignerCategoryAttribute("code"), _
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.prosoft.cr/")> _
Partial Public Class clsCondicion

    Private campoField As clsCampo

    Private operadorField As TOperadorLogico

    Private valorField As Object

    '''<comentarios/>
    Public Property Campo() As clsCampo
        Get
            Return Me.campoField
        End Get
        Set(ByVal value As clsCampo)
            Me.campoField = value
        End Set
    End Property

    '''<comentarios/>
    Public Property Operador() As TOperadorLogico
        Get
            Return Me.operadorField
        End Get
        Set(ByVal value As TOperadorLogico)
            Me.operadorField = value
        End Set
    End Property

    '''<comentarios/>
    Public Property Valor() As Object
        Get
            Return Me.valorField
        End Get
        Set(ByVal value As Object)
            Me.valorField = value
        End Set
    End Property
End Class

'''<comentarios/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
 System.SerializableAttribute(), _
 System.Diagnostics.DebuggerStepThroughAttribute(), _
 System.ComponentModel.DesignerCategoryAttribute("code"), _
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.prosoft.cr/")> _
Partial Public Class clsCampo

    Private nombreField As String

    Private descripcionField As String

    Private nombreBDField As String

    Private tipoDatoField As TTipo

    Private largoPMostrarField As Integer

    Private llaveField As Boolean

    '''<comentarios/>
    Public Property Nombre() As String
        Get
            Return Me.nombreField
        End Get
        Set(ByVal value As String)
            Me.nombreField = value
        End Set
    End Property

    '''<comentarios/>
    Public Property Descripcion() As String
        Get
            Return Me.descripcionField
        End Get
        Set(ByVal value As String)
            Me.descripcionField = value
        End Set
    End Property

    '''<comentarios/>
    Public Property NombreBD() As String
        Get
            Return Me.nombreBDField
        End Get
        Set(ByVal value As String)
            Me.nombreBDField = value
        End Set
    End Property

    '''<comentarios/>
    Public Property TipoDato() As TTipo
        Get
            Return Me.tipoDatoField
        End Get
        Set(ByVal value As TTipo)
            Me.tipoDatoField = value
        End Set
    End Property

    '''<comentarios/>
    Public Property LargoPMostrar() As Integer
        Get
            Return Me.largoPMostrarField
        End Get
        Set(ByVal value As Integer)
            Me.largoPMostrarField = value
        End Set
    End Property

    '''<comentarios/>
    Public Property Llave() As Boolean
        Get
            Return Me.llaveField
        End Get
        Set(ByVal value As Boolean)
            Me.llaveField = value
        End Set
    End Property
End Class

'''<comentarios/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
 System.SerializableAttribute(), _
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.prosoft.cr/")> _
Public Enum TTipo

    '''<comentarios/>
    Entero

    '''<comentarios/>
    Caracter

    '''<comentarios/>
    Fecha
End Enum

'''<comentarios/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
 System.SerializableAttribute(), _
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.prosoft.cr/")> _
Public Enum TOperadorLogico

    '''<comentarios/>
    Igual

    '''<comentarios/>
    MayorIgual

    '''<comentarios/>
    MenorIgual

    '''<comentarios/>
    Contiene

    '''<comentarios/>
    Entre
End Enum