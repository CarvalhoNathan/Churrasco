// Faça um programa que calcule a quantidade de itens necessários para um churrasco a partir da quantidade de adultos (que consomem e que não consomem bebidas alcoólicas) e de crianças.

// Item	Por adulto	Por criança
// Carne	400g	200g
// Acompanhamentos	200g	200g
// Cerveja	2l	--
// Refrigerante	500ml	500ml
// Água	400ml	400ml
// Estime cerveja e refrigerantes de acordo com a indicação de consumo dos adultos. Estime refrigerante para todas as crianças. Estime água para todos.

// Exemplo:
// --- Churrasco ---

// Adultos (que consomem bebidas alcoólicas).......: 5
// Adultos (que não consomem bebidas alcoólicas)...: 3
// Crianças........................................: 6

// Carne.............: 4,4kg
// Acompanhamentos...: 2,8kg
// Cerveja...........: 10,0l
// Refrigerante......: 4,5l
// Água..............: 5,6l

Console.Clear();

int adultosComBebida, adultosSemBebida, criancas;
double acompanhamentos, cerveja, refrigerante, agua;

acompanhamentos = 0.2;
cerveja = 2;
refrigerante = 0.5;
agua = 0.4;

Console.WriteLine("--- Churrasco ---");
Console.Write("\nAdultos (que consomem bebidas alcoólicas).......: ");
adultosComBebida = Convert.ToInt32(Console.ReadLine())!;

Console.Write("Adultos (que não consomem bebidas alcoólicas)...: ");
adultosSemBebida = Convert.ToInt32(Console.ReadLine())!;

Console.Write("Crianças........................................: ");
criancas = Convert.ToInt32(Console.ReadLine())!;

Console.WriteLine(" ");
Console.WriteLine($"Carne.............: {((adultosComBebida + adultosSemBebida) * 0.4 + criancas * 0.2)}kg");
Console.WriteLine($"Acompanhamentos...: {((adultosComBebida + adultosSemBebida) * acompanhamentos + criancas * acompanhamentos):F1}kg");
Console.WriteLine($"Cerveja...........: {(adultosComBebida * cerveja):F1}l");
Console.WriteLine($"Refrigerante......: {(adultosSemBebida * refrigerante + criancas * refrigerante):F1}l");
Console.WriteLine($"Água..............: {(adultosComBebida + adultosSemBebida + criancas) * agua:F1}l");
