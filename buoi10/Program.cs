//Lop va doi tuong


//phuong thuc
//cach viet phuong thuc:
//ten pt + () {
//cac cau lenh
//}

void tinhTong(int a, int b)
{
    int tong = a + b;
    Console.WriteLine(tong);
}

//goi phuong thuc nhieu lan ma ko can code

tinhTong(2,4);

void TinhTich (int a, int b)
{
    int tich = a * b;
    int soCuoi = tich * 3;
    Console.WriteLine(soCuoi);
}
TinhTich(3, 4);
TinhTich(4, 5);

//bang cuu chuong
void BangCuuChuong(int so)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{so} X {i} = {so * i}");
    }
}
BangCuuChuong(5);
