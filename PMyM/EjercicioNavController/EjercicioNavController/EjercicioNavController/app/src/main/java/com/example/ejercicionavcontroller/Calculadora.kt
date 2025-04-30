package com.example.ejercicionavcontroller

import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.AlertDialog
import androidx.compose.material3.Button
import androidx.compose.material3.Text
import androidx.compose.material3.TextField
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.saveable.rememberSaveable
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.unit.dp
import androidx.navigation.NavController



@Composable
fun calculadora(miNavController: NavController){
    Column(modifier = Modifier.padding(10.dp).fillMaxSize(),
        horizontalAlignment = Alignment.CenterHorizontally,
        verticalArrangement = Arrangement.Center)
    {
        var numero1 by rememberSaveable { mutableStateOf("") }
        var numero2 by rememberSaveable { mutableStateOf("") }
        var resultado by rememberSaveable { mutableStateOf("") }
        var operacion by remember { mutableStateOf("") }
        var mostrarMensaje by rememberSaveable { mutableStateOf(false) }

        TextField(
            value = numero1,
            onValueChange = {numero1 = it},
            label = { Text("Introduzca un número") }
        )
        TextField(
            value = numero2,
            onValueChange = {numero2 = it},
            label = { Text("Introduzca otro número") }
        )




        Row (modifier = Modifier.fillMaxWidth().padding(30.dp),
            verticalAlignment = Alignment.CenterVertically,
            horizontalArrangement = Arrangement.Center )
        {
            Button(onClick = {
                resultado = operaciones(numero1, numero2, operacion = "sumar")
                mostrarMensaje = true
                operacion = "suma"
            }
            ) { Text("+") }

            Button(onClick = {
                resultado = operaciones(numero1, numero2, operacion = "restar")
                mostrarMensaje = true
                operacion = "resta"
            }
            ) { Text("-")}

            Button(onClick = {
                resultado = operaciones(numero1, numero2, operacion = "dividir")
                mostrarMensaje = true
                operacion = "división"
            }
            ) { Text("/")}

            Button(onClick = {
                resultado = operaciones(numero1, numero2, operacion = "multiplicar")
                mostrarMensaje = true
                operacion = "multiplicación"
            }
            ) { Text("X")}
        }
        Button(onClick = {miNavController.popBackStack()}) { Text("Atrás") }
        if (mostrarMensaje){
            AlertDialog(
                onDismissRequest = {mostrarMensaje = false},
                confirmButton = {
                    Button(onClick = {mostrarMensaje = false}) { Text("Ok") }
                },
                title = { Text("Resultado")},
                text = { Text("El resultado de la $operacion es $resultado") }

            )
        }
    }
}
fun operaciones(num1: String, num2: String, operacion: String): String {
    var resultado = 0f

    when(operacion){
        "sumar" -> resultado = num1.toFloat() + num2.toFloat()
        "restar" -> resultado = num1.toFloat() - num2.toFloat()

        "dividir" -> resultado = if (num2.toFloatOrNull() != 0f){
            (num1.toFloatOrNull() ?: 0f) / (num2.toFloatOrNull() ?: 1f)
        }else{
            0f
        }
        "multiplicar" -> resultado = num1.toFloat() * num2.toFloat()
    }
    if(resultado % 1 == 0f){ // Condicion para poder pasarlo a Int y que no pete
        return resultado.toInt().toString()
    }
    return resultado.toString()
}