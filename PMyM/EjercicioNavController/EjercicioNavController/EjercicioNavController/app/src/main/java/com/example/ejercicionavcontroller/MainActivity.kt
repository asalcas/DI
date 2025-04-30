package com.example.ejercicionavcontroller

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.composable
import androidx.navigation.compose.rememberNavController

class MainActivity : ComponentActivity() {

    companion object{
        var num1: Int = 0
        var num2: Int = 0
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContent {

            // DECLARAMOS EL NAV CONTROLLER PARA PODER NAVEGAR ENTRE PANTALLAS
            val miNavController = rememberNavController()
            NavHost(
                navController = miNavController,
                startDestination = "ir_al_login"
            ) {
                //Rutas de navegación
                composable("ir_al_login") { login(miNavController) }

                // le pasamos a la ruta la "variable" 'usuario' que vamos a declararlo aqui abajo
                composable("Seleccion/{usuario}") {backStackEntry ->

                    seleccion(miNavController, backStackEntry.arguments?.getString("usuario")) // AQUI DECLARAMOS USUARIO con lo que retornemos
                    }
                composable("Calculadora") { calculadora(miNavController) }
                composable("Contactos") { ListadoContactos(miNavController) }
                composable( "DetalleContacto/{idUsuario}") {backStackEntry ->
                    detalleContactos(miNavController, backStackEntry.arguments?.getString("idUsuario"))
                }
            }

            }
        }
    }






