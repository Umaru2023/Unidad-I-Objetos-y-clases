class Mascota:
    def __init__(self, nombre, tipo, edad):
        self.nombre = nombre
        self.tipo = tipo
        self.edad = edad
    
    def informacion(self):
        print(f"Mi nombre es {self.nombre}, soy un {self.tipo} y tengo {self.edad} años.")

# Crear objetos de la clase Mascota
mascota1 = Mascota("Luna", "perro", 3)
mascota2 = Mascota("Simba", "gato", 5)
mascota3 = Mascota("Nemo", "pez", 1)

# Mostrar información de las mascotas
mascota1.informacion()
mascota2.informacion()
mascota3.informacion()
