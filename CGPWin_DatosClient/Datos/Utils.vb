Option Explicit On
Option Strict On

Public Class Utils

    'Public Shared Function ConvierteDato(ByVal valor As ObjetosBase.clsListaCampos) As CGP.clsListaCampos

    '    Dim retorno As New CGP.clsListaCampos
    '    Dim i As Integer = 0
    '    While i < valor.Cantidad
    '        Dim campo As New clsCampo
    '        campo.Descripcion = valor.Item(i).Descripcion
    '        campo.LargoPMostrar = valor.Item(i).LargoPMostrar
    '        campo.Llave = valor.Item(i).Llave
    '        campo.Nombre = valor.Item(i).Nombre
    '        campo.NombreBD = valor.Item(i).NombreBD
    '        campo.TipoDato = ConvierteDato(valor.Item(i).TipoDato)
    '    End While
    '    Return retorno

    'End Function

    Public Shared Function ConvierteDato(ByVal valor As ObjetosBase.clsListaCondiciones) As CGP.clsListaCondiciones

        Dim Retorno As New CGP.clsListaCondiciones

        If Not valor Is Nothing Then

            Dim i As Integer = 0
            Dim lista As New System.Collections.Generic.List(Of CGP.clsCondicion)
            While i < valor.Cantidad
                i = i + 1
                Dim condicion As New CGP.clsCondicion
                condicion.Campo = ConvierteDato(valor.Item(i).Campo)
                condicion.Valor = valor.Item(i).Valor.ToString

                'se evalua el tipo de datos y el valor de consulta
                'esto con el fin de que no de errores los querys que se generan
                Select Case condicion.Campo.TipoDato
                    Case TTipo.Caracter
                        'los caracteres planos no importan

                    Case TTipo.Entero

                        If Not Decimal.TryParse(condicion.Valor.ToString(), Nothing) Then
                            Throw New Exception("El valor '" + condicion.Valor.ToString() + "' no es un filtro de tipo numerico comparable con el campo " + condicion.Campo.Nombre)
                        End If

                    Case TTipo.Fecha

                        If Not Date.TryParse(condicion.Valor.ToString(), Nothing) Then
                            Throw New Exception("El valor '" + condicion.Valor.ToString() + "' no es un filtro de tipo fecha comparable con el campo " + condicion.Campo.Nombre)
                        End If

                End Select

                Select Case valor.Item(i).Operador
                    Case ObjetosBase.clsCondicion.TOperadorLogico.Contiene
                        condicion.Operador = TOperadorLogico.Contiene
                    Case ObjetosBase.clsCondicion.TOperadorLogico.Entre
                        condicion.Operador = TOperadorLogico.Entre
                    Case ObjetosBase.clsCondicion.TOperadorLogico.Igual
                        condicion.Operador = TOperadorLogico.Igual
                    Case ObjetosBase.clsCondicion.TOperadorLogico.MayorIgual
                        condicion.Operador = TOperadorLogico.MayorIgual
                    Case ObjetosBase.clsCondicion.TOperadorLogico.MenorIgual
                        condicion.Operador = TOperadorLogico.MenorIgual
                End Select
                lista.Add(condicion)
                'Retorno.Lista(i - 1) = condicion
                'i = i + 1
            End While

            Retorno.Lista = lista.ToArray()

        End If

        Return Retorno

    End Function

    Private Shared Function ConvierteDato(ByVal valor As ObjetosBase.clsCampo) As CGP.clsCampo

        Dim retorno As New clsCampo
        retorno.Descripcion = valor.Descripcion
        retorno.LargoPMostrar = valor.LargoPMostrar
        retorno.Llave = valor.Llave
        retorno.Nombre = valor.Nombre
        retorno.NombreBD = valor.NombreBD
        retorno.TipoDato = ConvierteDato(valor.TipoDato)
        Return retorno

    End Function

    Private Shared Function ConvierteDato(ByVal valor As ObjetosBase.clsCampo.TTipo) As CGP.TTipo
        Dim retorno As New CGP.TTipo
        Select Case valor
            Case ObjetosBase.clsCampo.TTipo.Caracter
                retorno = TTipo.Caracter
            Case ObjetosBase.clsCampo.TTipo.Entero
                retorno = TTipo.Entero
            Case ObjetosBase.clsCampo.TTipo.Fecha
                retorno = TTipo.Fecha
        End Select
        Return retorno
    End Function
End Class