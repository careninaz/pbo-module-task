﻿//Mendefinisikan class Prosessor dengan atribut merk dan tipe
class Processor
{
    public string merk;
    public string tipe;
}

//Mendefinisikan class Intel (Turunan dari Prosessor dan menginisialisasi merk menjadi "Intel")
class Intel : Processor
{
    public Intel(string _tipe)
    {
        base.merk = "Intel";
        base.tipe = _tipe;
    }
}

//Mendefinisikan class AMD (Turunan dari Prosesor dan menginisialisasi merk mendjadi "AMD")
class AMD : Processor
{
    public AMD(string _tipe)
    {
        base.merk = "AMD";
        base.tipe = _tipe;
    }
}

// Mendefinisikan class Vga dengan atribut merk
class Vga
{
    public string merk;
}

// Mendefinisikan class Nvidia (Turunan dari Vga dan menginisialisasi merk menjadi "Nvidia")

class Nvidia : Vga
{
    public Nvidia()
    {
        base.merk = "Nvidia";
    }
}

// Mendefinisikan class AMD_Vga (Turunan dari Vga dan menginisialisasi merk menjadi "AMD")
class AMD_Vga : Vga
{
    public AMD_Vga()
    {
        base.merk = "AMD";
    }
}

// Mendefinisikan class Laptop dengan atribut merk, tipe, vga, dan processor
class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    // Method LaptopDinyalakan untuk menampilkan pesan saat laptop dinyalakan
    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }

    // Method LaptopDimatikan untuk menampilkan pesan saat laptop dimatikan
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}

// Mendefinisikan class ASUS (Turunan dari Laptop dan menginisialisasi merk menjadi "ASUS")
class ASUS : Laptop
{
    public ASUS(string _tipe, Vga _vga, Processor _processor)
    {
        base.merk = "ASUS";
        base.tipe = _tipe;
        base.vga = _vga;
        base.processor = _processor;
    }
}

// Mendefinisikan class Acer (Turunan dari Laptop dan menginisialisasi merk menjadi "ACER")
class Acer : Laptop
{
    public Acer(string _tipe, Vga _vga, Processor _processor)
    {
        base.merk = "ACER";
        base.tipe = _tipe;
        base.vga = _vga;
        base.processor = _processor;
    }
}

// Mendefinisikan class Lenovo (Turunan dari Laptop dan menginisialisasi merk menjadi "Lenovo")
class Lenovo : Laptop
{
    public Lenovo(string _tipe, Vga _vga, Processor _processor)
    {
        base.merk = "Lenovo";
        base.tipe = _tipe;
        base.vga = _vga;
        base.processor = _processor;
    }
}

// Mendefinisikan class ROG (Turunan dari ASUS)
class ROG : ASUS
{
    public ROG(Vga _vga, Processor _processor) : base("ROG", _vga, _processor)
    {

    }
}

// Mendefinisikan class Vivobook (Turunan dari ASUS dan memiliki method Ngoding)
class Vivobook : ASUS
{
    public Vivobook(Vga _vga, Processor _processor) : base("Vivobook", _vga, _processor)
    {

    }

    // Method Ngoding untuk menampilkan pesan saat ngoding
    public void Ngoding()
    {
        Console.WriteLine($"Ctak, Ctak, Ctak, error lagi!!");
    }
}

// Mendefinisikan class Swift (Turunan dari Acer)
class Swift : Acer
{
    public Swift(Vga _vga, Processor _processor) : base("Swift", _vga, _processor)
    {

    }
}

// Mendefinisikan class Predator (Turunan dari Acer dan memiliki method BermainGame)
class Predator : Acer
{
    public Predator(Vga _vga, Processor _processor) : base("Predator", _vga, _processor)
    {

    }

    // Method BermainGame untuk menampilkan pesan saat bermain game
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}

// Mendefinisikan class IdeaPad (Turunan dari Lenovo)
class IdeaPad : Lenovo
{
    public IdeaPad(Vga _vga, Processor _processor) : base("IdeaPad", _vga, _processor)
    {

    }
}

// Mendefinisikan class Legion (Turunan dari Lenovo)
class Legion : Lenovo
{
    public Legion(Vga _vga, Processor _processor) : base("Legion", _vga, _processor)
    {

    }
}


class Program
{
    static void Main(string[] args)
    {
        // No 1
        Laptop laptop2 = new Lenovo("ThinkPad", new Nvidia(), new Intel("Core i5"));
        laptop2.LaptopDinyalakan();  // Menyala
        laptop2.LaptopDimatikan();   // Mati

        // No 2
        Laptop laptop1 = new Vivobook(new Nvidia(), new Intel("Core i5"));
        //laptop1.Ngoding();  // Ctak, Ctak, Ctak, error lagi!!

        // No 3
        Console.WriteLine("Spesifikasi Laptop 1:");
        Console.WriteLine("Merk VGA: " + laptop1.vga.merk);
        Console.WriteLine("Merk Processor: " + laptop1.processor.merk);
        Console.WriteLine("Tipe Processor: " + laptop1.processor.tipe);

        // No 4
        Predator predator = new Predator(new Nvidia(), new Intel("Core i7"));
        predator.BermainGame();  // Laptop Predator sedang memainkan game

        //No 5
        //ACER acer = new Predator(new Nvidia(), new Intel("Core i7"));
        //acer.BermainGame();  // Error: Tidak dapat memanggil method BermainGame() pada ACER

    }
}
