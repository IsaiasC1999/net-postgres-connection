public class Usuario {

     public int id { get; set; }
     public string Nombre { get; set; }

     public string Apellido { get; set; }

     public int Edad { get; set; }

     public string correo { get; set; }

     

}



//  id SERIAL PRIMARY KEY,
//     nombre VARCHAR(50),
//     apellido VARCHAR(50),
//     edad INT,
//     correo VARCHAR(100),
//     fecha_creacion TIMESTAMP DEFAULT NOW()