Imports System.Configuration

Namespace Seguridad.Configuracion

    Public Class Configuracion

        Public Shared URL_CONFIGURADO As String = String.Empty
        Public Shared SERVIDOR_CONFIGURADO As String = String.Empty

        Public Shared Sub CargarConfiguracion(Optional ByRef url As String = Nothing, _
                                                Optional ByRef servidor As String = Nothing)

            Try
                URL_CONFIGURADO = ConfigurationManager.AppSettings(Constantes.ServidorDatos)
                SERVIDOR_CONFIGURADO = ObtenerNombreServidor(URL_CONFIGURADO)

                url = URL_CONFIGURADO
                servidor = SERVIDOR_CONFIGURADO

            Catch ex As Exception

                URL_CONFIGURADO = String.Empty
                SERVIDOR_CONFIGURADO = String.Empty

            End Try

        End Sub

        Private Shared Function ObtenerNombreServidor(ByVal url As String) As String

            Dim servidor As String = String.Empty

            If Not String.IsNullOrEmpty(url) Then

                Dim partesUrl() As String = url.Split(":")

                If partesUrl.Length > 1 Then

                    Dim seccionesDireccion() As String = partesUrl(1).Replace("//", String.Empty).Split("/")

                    If seccionesDireccion.Length > 0 Then

                        servidor = seccionesDireccion(0)

                    End If

                End If

            End If

            Return servidor

        End Function

    End Class

End Namespace
