using IteratorrDP;

DateTimeAggregate tarih = new DateTimeAggregate();
tarih.startDate = new DateTime(2023, 04, 01);
tarih.endDate = DateTime.Now;
IIterator iterator = tarih.CreateIterator();
while (iterator.HasDate())
{
    Console.WriteLine(iterator.CurrentDate());
}

Console.Read();
