package com.example.ejercicionavcontroller

import androidx.compose.foundation.Image
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.material3.Button
import androidx.compose.material3.Card
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavController

@Composable
fun ListadoContactos(miNavController: NavController){
    val instanciaListado = ListadoPersonas()
    val personas = instanciaListado.ObtenerListadoPersonasCompleto()
    Button(modifier = Modifier.fillMaxWidth().padding(top = 50.dp),
        onClick = {miNavController.popBackStack()
        }
    ) { Text(fontSize = 30.sp, text = "Atrás") }
    LazyColumn(Modifier.padding(top = 100.dp)) {
        items(personas){ persona ->
            VistaContactos(persona, miNavController)

        }
    }
}

@Composable
fun VistaContactos(persona: ClsPersona, miNavController: NavController){
    Card(modifier = Modifier
        .padding(8.dp).fillMaxWidth()){
        Row (Modifier.clickable(
            enabled = true,
            onClick = {miNavController.navigate("DetalleContacto/${persona.id}")}
                )
            )
        {
            Column (modifier = Modifier.padding(10.dp).fillMaxWidth(.33f)){
                if(persona.sexo contentEquals "Hombre"){
                    Image(painterResource(id = R.drawable.hombre), contentDescription = "Imagen de un hombre")

                }else{
                    Image(painterResource(id = R.drawable.mujer), contentDescription = "Imagen de una mujer")

                }
            }
            Column (modifier = Modifier.padding(15.dp)){
                Text(
                    text = persona.nombre,
                    fontSize = 24.sp,
                )
                Text(
                    text= persona.apellido,
                    fontSize = 18.sp
                )
                Text(
                    text = "${persona.numero}",
                    fontSize = 36.sp,
                )

            }
        }
    }
}