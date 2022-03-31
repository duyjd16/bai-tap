 class Program
    {
        static void Main(string[] args)
        {
            //1 suc khoe

            //    float cannang, chieucao ;
            //    Console.WriteLine("Nhap Can Nang(kg) ");
            //    cannang = float.Parse(Console.ReadLine());
            //    Console.WriteLine("Nhap Chieu Cao(m) ");
            //    chieucao = float.Parse(Console.ReadLine());
            //    BMI(cannang , chieucao);
            //    Console.ReadKey();
            //}
            //static void BMI(float cannang , float chieucao )
            //{             
            //    float BMI = (cannang) / (chieucao * chieucao);
            //    Console.WriteLine("BMI =" + BMI);
            //    if (BMI > 35)
            //        Console.WriteLine("BeoPhiDo III");
            //    if (BMI >=30 )
            //        Console.WriteLine("BeoPhiDo II");
            //    if (BMI >= 25)
            //        Console.WriteLine("BeoPhiDo I");
            //    if (BMI >= 18)
            //        Console.WriteLine("BinhThuong");
            //    if (BMI < 18)
            //        Console.WriteLine("Gay");


            //2 tinh tien dien
            Console.Write("Nhap vao kw tieu thu: ");
            double tieuThu = double.Parse(Console.ReadLine());
            Console.WriteLine($"tong tien dien phai tra la: {tinhTienDien(tieuThu)}");
        }
        static double tinhTienDien(double tieuThu)
        {
            double
                tongTien = 0;
            double bac1 = 3000;
            double bac2 = 5000;
            double bac3 = 7000;
            if (tieuThu <= 100) tongTien = tieuThu * bac1;
            else if (tieuThu <= 100) tongTien = tieuThu - 100 * bac2 + 100 * bac1;
            else if (tieuThu <= 150) tongTien = (100 * bac1) + (50 * bac2) + ((tieuThu - 150) * bac3);
            else tongTien = (100 * bac1) + (50 * bac2) + ((tieuThu - 150) * bac3);
            return tongTien * 0.1 + tongTien;


        }

    }
}
