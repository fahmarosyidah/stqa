using System;

namespace Exercise1
{
    //Membuat class IPA
    class IPA
    {
        //Deklarasi variable
        string nama;
        public double nilM, nilF, nilK, nilB, rerata;

        //Method yang melewatkan nilai
        public void inputData()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Selamat Datang Anak IPA");
            Console.WriteLine("==============================");

            //Display 'Masukkan Nama: '
            Console.Write("Masukkan Nama: ");
            //Accept nama
            nama = Convert.ToString(Console.ReadLine());
            //Display 'Masukkan Nilai Matematika: '
            Console.Write("Masukkan Nilai Matematika: ");
            //Accept nilM
            nilM = Convert.ToDouble(Console.ReadLine());
            //Display 'Masukkan Nilai Fisika: '
            Console.Write("Masukkan Nilai Fisika: ");
            //Accept nilF
            nilF = Convert.ToDouble(Console.ReadLine());
            //Display 'Masukkan Nilai Kimia: '
            Console.Write("Masukkan Nilai Kimia: ");
            //Accept nilK
            nilK = Convert.ToDouble(Console.ReadLine());
            //Display 'Masukkan Nilai Biologi: '
            Console.Write("Masukkan Nilai Biologi: ");
            //Accept nilB
            nilB = Convert.ToDouble(Console.ReadLine());
        }
        //Method yang melewatkan nilai
        public void prosesData()
        {
            //Compute rerata = (nilM + nilF + nilK + nilB) / 4;
            rerata = (nilM + nilF + nilK + nilB) / 4;
            if (rerata >= 80 & rerata <= 100)
            {
                Console.WriteLine("Grade: A");
            }
            else if (rerata <= 80 & rerata >= 65)
            {
                Console.WriteLine("Grade: B");
            }
            else if (rerata <= 65 & rerata >= 50)
            {
                Console.WriteLine("Grade: C");
            }
            else if (rerata <= 50 & rerata >= 35)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: E");
            }
        }

        //Method yang mengembalikan nilai
        public double prosesData1()
        {
            return (nilM + nilF + nilK + nilB) / 4;
        }

        //Method yang mengembalikan nilai dengan parameter
        public double prosesData2(double matematika, double fisika, double kimia, double biologi)
        {
            return (matematika + fisika + kimia + biologi) / 4;
        }

        //Method yang melewatkan nilai
        public void outputData()
        {
            //Display 'Rerata: ' +rerata
            Console.WriteLine("Rerata: " + rerata);
        }

        //Method yang melewatkan nilai
        public void outputData1()
        {
            //Display 'Rerata: ' +rerata
            Console.WriteLine("Nilai Matematika: {0} Nilai Fisika: {1} Nilai Kimia: {2} Nilai Biologi: {3} Rerata: {4}", nilM, nilF, nilK, nilB, prosesData1());
        }

        //Method dengan menggunakan parameter
        public void outputData2(double rerata)
        {
            //Display 'Rerata: ' +rerata
            Console.WriteLine("Nilai Matematika: {0} Nilai Fisika: {1} Nilai Kimia: {2} Nilai Biologi: {3} Rerata: {4}", nilM, nilF, nilK, nilB, rerata);
        }
    }

    //Membuat class IPS
    class IPS
    {
        //Deklarasi variable
        string nama;
        public double nilSej, nilSos, nilG, nilE, rerata;

        //Method yang melewatkan nilai
        public void inputData()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Selamat Datang Anak IPS");
            Console.WriteLine("==============================");
            //Display 'Masukkan Nama: '
            Console.Write("Masukkan Nama: ");
            //Accept nama
            nama = Convert.ToString(Console.ReadLine());
            //Display 'Masukkan Nilai Sejarah: '
            Console.Write("Masukkan Nilai Sejarah: ");
            //Accept nilSej
            nilSej = Convert.ToDouble(Console.ReadLine());
            //Display 'Masukkan Nilai Sosiologi: '
            Console.Write("Masukkan Nilai Sosiologi: ");
            //Accept nilSos
            nilSos = Convert.ToDouble(Console.ReadLine());
            //Display 'Masukkan Nilai Geografi: '
            Console.Write("Masukkan Nilai Geografi: ");
            //Accept nilG
            nilG = Convert.ToDouble(Console.ReadLine());
            //Display 'Masukkan Nilai Ekonomi: '
            Console.Write("Masukkan Nilai Ekonomi: ");
            //Accept nilE
            nilE = Convert.ToDouble(Console.ReadLine());
        }

        //Method yang melewatkan nilai
        public void prosesData()
        {
            //Compute rerata = (nilSej + nilSos + nilG + nilE)/4
            rerata = (nilSej + nilSos + nilG + nilE) / 4;
            if (rerata >= 80 & rerata <= 100)
            {
                Console.WriteLine("Grade: A");
            }
            else if (rerata <= 80 & rerata >= 65)
            {
                Console.WriteLine("Grade: B");
            }
            else if (rerata <= 65 & rerata >= 50)
            {
                Console.WriteLine("Grade: C");
            }
            else if (rerata <= 50 & rerata >= 35)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: E");
            }
        }

        //Method yang mengembalikan nilai
        public double prosesData1()
        {
            return (nilSej + nilSos + nilG + nilE) / 4;
        }

        //Method yang mengembalikan nilai dengan parameter
        public double prosesData2(double sejarah, double sosiologi, double geografi, double ekonomi)
        {
            return (sejarah + sosiologi + geografi + ekonomi) / 4;
        }

        //Method yang melewatkan nilai
        public void outputData()
        {
            //Display 'Rerata: '
            Console.WriteLine("Rerata: " + rerata);
        }

        //Method yang mengembalikan nilai
        public void outputData1()
        {
            //Display 'Rerata: ' +rerata
            Console.WriteLine("Nilai Sejarah: {0} Nilai Sosiologi: {1} Nilai Geografi: {2} Nilai Ekonomi: {3} Rerata: {4}", nilSej, nilSos, nilG, nilE, prosesData1());
        }

        //Method dengan menggunakan parameter
        public void outputData2(double rerata)
        {
            //Display 'Rerata: ' +rerata
            Console.WriteLine("Nilai Sejarah: {0} Nilai Sosiologi: {1} Nilai Geografi: {2} Nilai Ekonomi: {3} Rerata: {4}", nilSej, nilSos, nilG, nilE, rerata);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Membuat objek baru untuk kelas
            IPA ipa = new IPA();
            IPS ips = new IPS();

            //Deklarasi variable untuk ekspresi switch
            int pilih;
            //Membuat tampilan menu
            Console.WriteLine("==============================");
            Console.WriteLine("Daftar Jurusan");
            Console.WriteLine("1. IPA");
            Console.WriteLine("2. IPS");
            Console.WriteLine("==============================");
            Console.Write("Silahkan Pilih Jurusan: ");
            pilih = Convert.ToInt32(Console.ReadLine());
            switch (pilih)
            {
                case 1:
                    ipa.inputData();
                    ipa.prosesData();
                    ipa.outputData();
                    break;
                case 2:
                    ips.inputData();
                    ips.prosesData();
                    ips.outputData();
                    break;
            }
            string pilihan;
            Console.Write("Apakah Anda Ingin Kembali ke Menu Utama? (Y/N)");
            pilihan = Console.ReadLine();
            while (pilihan.Equals("y") || pilihan.Equals("Y"))
            {
                Console.WriteLine("==============================");
                Console.WriteLine("Daftar Jurusan");
                Console.WriteLine("1. IPA");
                Console.WriteLine("2. IPS");
                Console.WriteLine("==============================");
                Console.Write("Silahkan Pilih Jurusan: ");
                pilih = Convert.ToInt32(Console.ReadLine());
                switch (pilih)
                {
                    case 1:
                        ipa.inputData();
                        ipa.prosesData();
                        ipa.outputData();
                        break;
                    case 2:
                        ips.inputData();
                        ips.prosesData();
                        ips.outputData();
                        break;
                }
                Console.Write("Apakah Anda Ingin Kembali ke Menu Utama? (Y/N)");
                pilihan = Console.ReadLine();
            }
        }
    }
}

