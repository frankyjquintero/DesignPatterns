# EL PATRON ABSTRACT FACTORY
## Descripción 
El objetivo del patrón Abstract Factory es la creación de objetos agrupados en familias
sin tener que conocer las clases concretas destinadas a la creación de estos objetos. 

## Ejemplo 
El sistema de venta de vehículos gestiona vehículos que funcionan con gasolina y
vehículos eléctricos. Esta gestión está delegada en el objeto Catálogo encargado de
crear tales objetos. 

Para cada producto, disponemos de una clase abstracta, de una subclase concreta
derivando una versión del producto que funciona con gasolina y de una subclase
concreta derivando una versión del producto que funciona con electricidad. Por
ejemplo, en la figura 4.1, para el objeto Scooter, existe una clase abstracta Scooter y dos
subclases concretas ScooterElectricidad y ScooterGasolina. 

El objeto Catálogo puede utilizar estas subclases concretas para instanciar los productos.
No obstante si fuera necesario incluir nuevas clases de familias de vehículos (diésel o
mixto gasolina-eléctrico), las modificaciones a realizar en el objeto Catálogo pueden ser
bastante pesadas. 

El patrón Abstract Factory resuelve este problema introduciendo una interfaz
FábricaVehículo que contiene la firma de los métodos para definir cada producto. El
tipo devuelto por estos métodos está constituido por una de las clases abstractas del
producto. De este modo el objeto Catálogo no necesita conocer las subclases concretas y
permanece desacoplado de las familias de producto. 

Se incluye una subclase de implementación de FábricaVehículo por cada familia de
producto, a saber las subclases FábricaVehículoElectricidad y
FábricaVehículoGasolina. Dicha subclase implementa las operaciones de creación del
vehículo apropiado para la familia a la que está asociada. 

El objeto Catálogo recibe como parámetro una instancia que responde a la interfaz
FábricaVehículo, es decir o bien una instancia de FábricaVehículoElectricidad, o bien
una instancia de FábricaVehículoGasolina. Con dicha instancia, el catálogo puede crear
y manipular los vehículos sin tener que conocer las familias de vehículos y las clases
concretas de instanciación correspondientes. 

El conjunto de clases del patrón Abstract Factory para este ejemplo se detalla en la
figura 4.1. 
![alt text](https://raw.githubusercontent.com/frankyjquintero/DesignPatterns/master/DesignPatterns.AbstractFactory/4.1.jpg)

## Estructura 
### 1. Diagrama de clases 
La figura 4.2 detalla la estructura genérica del patrón. 

![alt text](https://raw.githubusercontent.com/frankyjquintero/DesignPatterns/master/DesignPatterns.AbstractFactory/4.2.jpg)

### 2. Participantes 
Los participantes del patrón son los siguientes: 
* FábricaAbstracta (FábricaVehículo) es una interfaz que define las firmas de los
métodos que crean los distintos productos. 
* FábricaConcreta1, FábricaConcreta2 (FábricaVehículoElectricidad,
FábricaVehículoGasolina) son las clases concretas que implementan los
métodos que crean los productos para cada familia de producto. Conociendo la
familia y el producto, son capaces de crear una instancia del producto para esta
familia. 
* ProductoAbstractoA y ProductoAbstractoB (Scooter y Automóvil) son las clases
abstractas de los productos independientemente de su familia. Las familias se
introducen en las subclases concretas. 
* Cliente es la clase que utiliza la interfaz de FábricaAbstracta. 
### 3. Colaboraciones 
La clase Cliente utiliza una instancia de una de las fábricas concretas para crear sus
productos a partir de la interfaz FábricaAbstracta. 
 
Normalmente sólo es necesario crear una instancia de cada fábrica concreta, que puede
compartirse por varios clientes. 


## Dominios de uso 
El patrón se utiliza en los dominios siguientes: 
* Un sistema que utiliza productos necesita ser independiente de la forma en que
se crean y agrupan estos productos. 
* Un sistema está configurado según varias familias de productos que pueden
evolucionar. 
## Ejemplo  

Presentamos a continuación un pequeño ejemplo de uso del patrón escrito en C# .Net core. El
código C# .Net core correspondiente a la clase abstracta Automovil y sus subclases aparece a
continuación. Es muy sencillo, describe los cuatro atributos de los automóviles así como
el método mostrarCaracteristicas que permite visualizarlas. 

 [CODE]

El código C# .Net core correspondiente a la clase abstracta Scooter y sus subclases aparece a
continuación. Es similar al de los automóviles, salvo por el atributo espacio que no
existe para las scooters. 
 [CODE]

Ahora podemos introducir la interfaz FabricaVehiculo y sus dos clases de
implementación, una para cada familia (eléctrico/gasolina). Es fácil darse cuenta de que
sólo las clases de implementación utilizan las clases concretas de los vehículos. 

 [CODE]
Por último, se presenta el código fuente C# .Net core del cliente de la fábrica, a saber el catálogo
que es, en nuestro ejemplo, el programa principal. Por motivos de simplicidad, el
catálogo solicita al comienzo la fábrica que se quiere utilizar (electricidad o gasolina).
Esta fábrica debería proporcionarse como parámetro al catálogo. 
El resto del programa es totalmente independiente de la familia de objetos, respetando el
objetivo del patrón Abstract Factory. 

 [CODE]

A continuación se muestra un ejemplo de ejecución para vehículos eléctricos:

` Desea utilizar vehiculos electricos (1)   
o a gasolina (2): 1  
Automovil electrico de modelo: estandar de color:   
amarillo de potencia: 6   
de espacio: 3.2  
Automovil electrico de modelo: estandar de color:   
amarillo de potencia: 7   
de espacio: 3.2  
Automovil electrico de modelo: estandar de color:   
amarillo de potencia: 8   
de espacio: 3.2  
Scooter electrica de modelo: clasico de color:   
rojo de potencia: 2  
Scooter electrica de modelo: clasico de color:   
rojo de potencia: 3 
`

En este ejemplo de ejecución se ha creado una fábrica de vehículos eléctricos, de modo
que el catálogo se compone de automóviles y scooters eléctricos. 
