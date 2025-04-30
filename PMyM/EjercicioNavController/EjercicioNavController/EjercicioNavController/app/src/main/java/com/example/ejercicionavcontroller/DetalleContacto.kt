package com.example.ejercicionavcontroller

import android.content.Intent
import android.net.Uri
import androidx.compose.foundation.Image
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.Button
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavController

@Composable
fun detalleContactos(miNavController: NavController, idUsuario: String?){
    var personaEncontrada = false
    val listadoPersonas = ListadoPersonas().ObtenerListadoPersonasCompleto()
    var indice = 0
    var nombre = ""
    var apellido = ""
    var numero = ""
    var sexo = ""


    Column(
        modifier = Modifier.fillMaxSize().
        padding(10.dp),
        horizontalAlignment = Alignment.CenterHorizontally,
        verticalArrangement = Arrangement.Center
    )
    {
        while(!personaEncontrada && idUsuario != "0"){
            if (idUsuario != null) {
                if(listadoPersonas[indice].id == idUsuario.toInt()){
                    nombre = listadoPersonas[indice].nombre
                    apellido = listadoPersonas[indice].apellido
                    numero = listadoPersonas[indice].numero.toString()
                    sexo = listadoPersonas[indice].sexo
                    personaEncontrada = true
                }
            }
            indice++
        }

        // Si tuvieramos un enlace en lo que viene a ser cada usuario en la "BD" que es una lista y ya
        // podriamos meterle fotos personalizadas a cada usuario, mientras jugaremos con lo que ya tenemos
        // que viene a ser simplemente el sexo.
        if (sexo.equals("Hombre")){
            Image(painterResource(id = R.drawable.hombre), contentDescription = "Imagen del usuario")
        }else if (sexo.equals("Mujer")) {
            Image(painterResource(id = R.drawable.mujer), contentDescription = "Imagen del usuario")
        }else{
            Image(painterResource(id = R.drawable.grogu), contentDescription = "Imagen predefinida del usuario por si acaso foto es null en la BD")
        }
        Text(text = "${nombre}", fontWeight = FontWeight.Bold, fontSize = 40.sp)
        Text("${apellido}", fontWeight = FontWeight.Medium, fontSize = 30.sp)
        Text("${numero}", fontWeight = FontWeight.Black, fontSize = 50.sp)
        val context = LocalContext.current
        Row(modifier = Modifier.padding(8.dp)){
            Button(onClick = { var numeroTelefono = "${numero}"
                               val intent = Intent(Intent.ACTION_DIAL).apply{
                                   data = Uri.parse("tel:$numeroTelefono")
                               }
            context.startActivity(intent)
            }) { Text(text =  "☎", fontSize = 25.sp)}
            Button(onClick = {miNavController.popBackStack()}) { Text(text =  "Atrás", fontSize = 25.sp)}
            Button(onClick = {miNavController.popBackStack()}) { Text(text =  "🗑", fontSize = 25.sp)}


            //val intent = Intent(Intent.ACTION_DIAL, Uri.parse("tel:$numero"))
            //context.startActivity(intent)
        }
    }
}