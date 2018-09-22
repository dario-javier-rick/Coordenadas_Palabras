# Coordenadas Palabras

Ejercicio de búsqueda de palabras en array de strings

##Punto 1

Desarrollar un algoritmo que encuentre las palabras “TELEFE” “VIACOM” “JAVA” dentro del siguiente array de strings:

string[] secuencias = { "AGVNFT", "XJILSB", "CHAOHD", "ERCVTQ", "ASOYAO", "ERMYUA", "TELEFE" }

Este array de strings forma la siguiente matriz:

1 2 3 4 5 6

1 A G V N F T

2 X J I L S B

3 C H A O H D

4 E R C V T Q

5 A S O Y A O

6 E R M Y U A

7 T E L E F E

La función a desarrollar recibe como para parámetro de entrada la palabra a buscar y tiene que devolver las coordenadas de cada letra que forman la palabra. Las letras deben estar juntas.

Por ej.: Para la palabra JAVA debería devolver: [2,2][3,3][4,4][5,5]

Int[,] posicionesJava = getPosiciones(“JAVA”);

posicionesJava debería tener el valor: { {2,2}, {3,3}, {4,4}, {5,5} }

public int[,] getPosiciones(string palabra) {

//Algoritmo…

return coordenadas;

}

##Punto 2

a) Desarrollar una API REST que reciba la Palabra a buscar y devuelva las coordenadas usando el componente desarrollado en el punto (1)

b) Escribir los tests unitarios necesarios para lograr una cobertura mayor al 60%

##Punto 3

Persistir en una Base de Datos cada búsqueda que se haya realizado en la API. Permitir visualizar las búsquedas realizadas.
