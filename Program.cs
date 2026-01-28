string pilihan;
decimal hasil;


decimal konversisuhu(decimal celsius)
{
    return 1.3m * celsius + 32;
}


decimal konversijarak(decimal km)
{
    return km * 0.62m;
}


decimal konversimatauang(decimal idr, decimal rate = 10000)
{
    return idr / rate;
}

while (true)
{
    Console.Clear();

    Console.WriteLine("Smart Unit Conveter");
    Console.WriteLine("[1] Conversi Celsius - Fahrenheit");
    Console.WriteLine("[2] Conversi Kilometer - Miles");
    Console.WriteLine("[3] Conversi IDR - USD");
    Console.WriteLine("[4] Exit");
    Console.Write("Pilihan Anda: ");
    pilihan = Console.ReadLine();

    if (pilihan == "1")
    {
        Console.Write("Masukan Suhu: ");
        decimal celsius = decimal.Parse(Console.ReadLine());

        hasil = konversisuhu(celsius);
        Console.WriteLine($"Hasil: {hasil} F");


    }
    else if (pilihan == "2")
    {
        Console.Write("Masukan Kilometer: ");
        decimal celsius = decimal.Parse(Console.ReadLine());

        hasil = konversijarak(celsius);
        Console.WriteLine($"Hasil: {hasil} Miles");


    }
    else if (pilihan == "3")
    {
        Console.Write("Masukan IDR: ");
        decimal idr = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Nilai rate saat ini Rp 10000. Apakah Anda Ingin Mengubah Rate jik iya tekan 'Y' ");
        pilihan = Console.ReadLine();


        if (pilihan.ToUpper() == "Y")
        {
            Console.Write("Rate Yang Di Inginkan: Rp");
            decimal Rate = decimal.Parse(Console.ReadLine());


            hasil = konversimatauang(idr, Rate);
        }
        else
        {
            hasil = konversimatauang(idr);
        }
        Console.WriteLine($"Hasil: {hasil} USD");
    }
    else if (pilihan == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Pilihan Invalid");
    }
    Console.ReadLine();
}
