
using p1bpoo.MisClases;

//Vehiculo miCarrito = new Vehiculo(2026,"Azul","Alfa Romeo");

//Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

//CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

//miBYD.InformacionVehiculo();
//miBYD.cargarBateria();
//Console.WriteLine("El nivel de bateria es: {0}",miBYD.NivelBateria());

Chofer Piloto1 = new Chofer("Juan", 25, "A");
Chofer Piloto2 = new Chofer("Pedro", 30, "M");

//Piloto1.MostrarInformacion();
//Piloto2.MostrarInformacion();

Vehiculo sedan = new Vehiculo(2025, "Azul", "Honda");

Moto Yamaha = new Moto(2024, "Rojo", "Yamaha");

string respuesta;
respuesta = Yamaha.asignarPiloto(Piloto1);
Console.WriteLine(respuesta);
respuesta = Yamaha.asignarPiloto(Piloto2);
Console.WriteLine(respuesta);
Yamaha.encender();
Yamaha.acelerar(20);
Yamaha.acelerar(120);
Yamaha.acelerar(20);
Yamaha.frenar(20);
Yamaha.frenar(120);
Yamaha.acelerar(10);
Yamaha.hacerCaballito();
Yamaha.apagar();
Yamaha.frenar(10);
Yamaha.hacerCaballito();
Yamaha.apagar();
Yamaha.InformacionVehiculo();
//respuesta = sedan.asignarPiloto(Piloto1);
//Console.WriteLine(respuesta);
//sedan.encender();
//sedan.acelerar(20);
//sedan.acelerar(101);
//sedan.frenar(20);
//sedan.acelerar(10);
//sedan.apagar();
//sedan.frenar(10);
//sedan.apagar();
//sedan.InformacionVehiculo();









