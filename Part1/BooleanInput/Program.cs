using System;

namespace BooleanInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // ใน Java การแปลง string เป็น boolean, ข้อความอื่นที่ไม่ใช่ true, True จะเป็น false ทั้งหมด
            // แต่ใน C# แปลงได้เฉพาะข้อความ true, false เท่านั้น, ข้อความอื่นโปรแกรมจะ error และจบการทำงาน

            Console.WriteLine("Write something: ");
            // Convert ใช้ได้เฉพาะ string ที่ค่าเป็น true หรือ false เท่านั้นถ้าเป็นข้อความอื่นโปรแกรมจะ crash
            bool trustValue = Convert.ToBoolean(Console.ReadLine()); 
            System.Console.WriteLine("True of false? " + trustValue);
        }
    }
}
