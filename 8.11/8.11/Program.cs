Random rand = new Random();
int[] obligatory = new int[15];// обязательная
int[] shortly = new int[15];// короткая

int[] arbitary = new int[15];// произвольная
Console.WriteLine($"{"Спортсмен",15} {"Обязательная",15} {"Короткая",15} {"Произвольная",15}");
for (int j = 0; j < 15; j++)// вывод д
{
    obligatory[j] = rand.Next(20);
    shortly[j] = rand.Next(20);
    arbitary[j] = rand.Next(20);
    Console.WriteLine($"{j + 1,15}{obligatory[j],15}{shortly[j],15}{arbitary[j],15}");
}
Console.WriteLine();

double averageObligatory = 0;// среднее значение по каждой программе
double averageShortly = 0;
double averageArbitary = 0;
for (int h = 0; h < 15; h++)
{

    averageObligatory += Convert.ToDouble(obligatory[h]);
    averageShortly += Convert.ToDouble(shortly[h]);
    averageArbitary += Convert.ToDouble(arbitary[h]);
}
averageObligatory = averageObligatory / 15;
averageShortly = averageShortly / 15;
averageArbitary = averageArbitary / 15;


Console.WriteLine("Среднее количество очков по обязательному виду программы - " + averageObligatory);
Console.WriteLine("Среднее количество очков по короткому виду программы - " + averageShortly);
Console.WriteLine("Среднее количество очков по произвольному виду программы - " + averageArbitary);
