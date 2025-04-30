package com.example.ejercicionavcontroller

import androidx.compose.foundation.Image
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.foundation.text.KeyboardOptions
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
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.input.KeyboardType
import androidx.compose.ui.text.input.PasswordVisualTransformation
import androidx.compose.ui.unit.dp
import androidx.navigation.NavController

@Composable
fun login(miNavController: NavController) {
    var textoUsuario by rememberSaveable { mutableStateOf("") }
    var password by remember { mutableStateOf("") }

    Column(
        modifier = Modifier.padding(8.dp).fillMaxSize(),
        horizontalAlignment = Alignment.CenterHorizontally,
        verticalArrangement = Arrangement.Center
    ) {
        Image(
            modifier = Modifier.size(250.dp),
            painter = painterResource(id = R.drawable.grogu),
            contentDescription = "Grogu rarete"
        )
        TextField(
            value = textoUsuario,
            onValueChange = { textoUsuario = it },
            label = { Text("Usuario") }
        )
        TextField(
            value = password,
            onValueChange = { password = it },
            label = { Text("Contraseña") },
            visualTransformation = PasswordVisualTransformation(), // Transforma la contraseña en asteriscos
            keyboardOptions = KeyboardOptions(keyboardType = KeyboardType.Password) // Configura el tipo de teclado a usar

        )
        Button(onClick = { miNavController.navigate("Seleccion/${textoUsuario}") }) { Text("Login") }

    }
}