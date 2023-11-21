/*
 Create un altro elenco di 1000 numeri interi casuali. 
 Riuscite a ordinarli dal più basso al più alto? Stampate il risultato. 
 Punti bonus se riuscite a farlo anche al contrario.
 */


Random random = new Random();

List<int> listaInteri = Enumerable.Range(1, 1000).Select(numeriCasuali => random.Next(numeriCasuali)).OrderBy(numeriOrdinati => numeriOrdinati).ToList();

Console.WriteLine("Lista numeri casuali ordinati da più basso al più alto :");

listaInteri.ForEach(numero => Console.WriteLine(numero));

List<int> listaInteriAlContrario = Enumerable.Range(1, 1000).Select(numeriCasuali => random.Next(numeriCasuali)).OrderBy(numeriOrdinati => numeriOrdinati).Reverse().ToList();

Console.WriteLine("\n-----------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------\n");


Console.WriteLine("Lista numeri casuali ordinati da più basso al più alto al contrario:");

listaInteriAlContrario.ForEach(numero => Console.WriteLine(numero));



