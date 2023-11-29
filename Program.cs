using Npgsql;
using Dapper;


var connString = "Host=172.20.255.250;Username=fdiaz;Password=root;Database=dim";


using(var db = new NpgsqlConnection(connString))
{


    db.Open();
    var listado =  db.Query<Usuario>($"SELECT * FROM helpdesk.usuario_pruebas ORDER BY id ASC");
    
    // expresion lambda
    var resu =  listado.Where(x=> x.Edad >= 30);

    

     foreach (var item in resu)
     {
          Console.WriteLine($"{item.Apellido} - {item.Edad} ");
     }

}