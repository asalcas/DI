package com.example.ejercicionavcontroller

class ListadoPersonas {
    private var listadoPersonasContactos: List<ClsPersona> = listOf(
        ClsPersona(1, "Alvaro", "Salvador", 911111111, "Hombre"),
        ClsPersona(2, "Chía", "Manzano", 922222222, "Mujer"),
        ClsPersona(3, "Pedro", "Lopez", 933333333, "Hombre"),
        ClsPersona(4, "Laura", "Fernandez", 944444444, "Mujer"),
        ClsPersona(5, "Carlos", "Diaz", 955555555, "Hombre"),
        ClsPersona(6, "Sofia", "Martinez", 966666666, "Mujer"),
        ClsPersona(7, "Javier", "Sanchez", 977777777, "Hombre"),
        ClsPersona(8, "Ana", "Ruiz", 988888888, "Mujer"),
        ClsPersona(9, "David", "Jimenez", 999999999, "Hombre")
    )
    fun ObtenerListadoPersonasCompleto(): List<ClsPersona> {
        return listadoPersonasContactos
    }

}