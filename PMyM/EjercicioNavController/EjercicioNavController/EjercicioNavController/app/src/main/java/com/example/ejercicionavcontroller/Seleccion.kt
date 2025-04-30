package com.example.ejercicionavcontroller

import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.Button
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.style.TextAlign
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavController

@Composable
fun seleccion(miNavController: NavController, username: String?){ // Recibo aqui el usuario pasado en el NavHost
    Column(modifier = Modifier.padding(10.dp).fillMaxSize(),
        horizontalAlignment = Alignment.CenterHorizontally,
        verticalArrangement = Arrangement.Center )
    {
        Text(
            textAlign = TextAlign.Center,
            fontSize = 30.sp,
            fontWeight = FontWeight.Bold,
            modifier = Modifier.padding(bottom = 10.dp),
            text = "Bienvenido de nuevo")
        Text(
            text = "${username}!",
            color = androidx.compose.ui.graphics.Color.Magenta,
            textAlign = TextAlign.Center,
            fontSize = 30.sp,
            fontWeight = FontWeight.Bold,
            modifier = Modifier.padding(bottom = 20.dp))
        Button(modifier = Modifier.fillMaxWidth().padding(bottom = 10.dp),
            onClick = { miNavController.navigate("Calculadora")}
        ) { Text(fontSize = 30.sp ,text = "Calculadora") }

        Button(modifier = Modifier.fillMaxWidth().padding(top = 10.dp),
            onClick = { miNavController.navigate("Contactos")}
        ) { Text(fontSize = 30.sp ,text = "Contactos") }

    }

}