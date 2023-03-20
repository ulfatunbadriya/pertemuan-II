
namespace CaculatorConsoleaApp1
{
    class program
    {
        static void Main(string[]args )
        {
            Console.WriteLine("Belajar Membuat Caculator");

            int angka1 = 0;
            int angka2 = 0;

            


            Console.WriteLine("Masukkan Angka Pertama:");
                angka1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Masukkan Angka Kedua:");
            angka2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Masukkan Operator:");
            switch (Console.ReadLine())
            {
                case "+":
                    var total = angka1 + angka2;
                    Console.WriteLine("Hasil :" + total);
                    break;
                case "-":
                  var totalKurang = angka1 - angka2;
                    Console.WriteLine("Hasil :" + totalKurang);
                    break;
                case "X":
                    var totalKali = angka1 * angka2;
                    Console.WriteLine("Hasil :" + totalKali);
                    break;
                case "/":
                  double totalBagi = angka1 / angka2;
                    Console.WriteLine("Hasil :" + totalBagi);
                    break;
            }
            

            
           
        }

    }
}