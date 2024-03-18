////task1//

////temp=havanin temp ; 
//int temp = 15;
//if (temp < 15)
//{
//    Console.WriteLine("Hava soyuqdur.");
//}
//else if (temp == 15)
//{
//    Console.WriteLine("Hava soyuqdur.");

//}
//else
//{
//    Console.WriteLine("Hava istidir.");
//}


//task2
//string months = "Yanvar";
//switch (months)
//{
//    case "Yanvar":
//        Console.WriteLine("31");
//        break;
//    case "Mart":
//        Console.WriteLine("31");
//        break;

//    case "Aprel":
//    case "Iyun":
//        Console.WriteLine("30");
//        break;
//    case "Fevral":
//        Console.WriteLine("29");
//        break;
//    default:
//        Console.WriteLine("Ay daxil edilmeyib.");
//        break;



//}


//====
//task3
//====

//int num = 3;
//int fac = num * (num - 1)!;
//for (int i = 0; i < num; i++)
//{
//    fac = num * (num - 1)!;

//}
//Console.WriteLine(fac);



//task4////
//int num = 19;
//bool result = false;
//for (int i = 2; i < num; i++)
//{

//    if (num % i == 0 && num % i == 0)
//    {
//        result = true;
//        break;


//    }
//}
//if (result)
//{
//    result = true;
//    Console.WriteLine("Bu eded murekebdir");


//}
//else
//{
//    Console.WriteLine("Bu eded sadedir.");
//}

//task5//

//int[] nums = { 1, 2, 3, 4, 5, 6,7 };
//int sum = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] != 1)
//        //    {
//        using System;

///        if (nums[i] % 2 == 1)
//////        {
//////            sum += nums[i];

//        }
//    }   


//}
//Console.WriteLine(sum);


//task6   //

//int[] nums = { 2, 4, 5, 6, 7,8 };
//int min = nums[0];
//int max = nums[0];

//for (int i = 0; i < nums.Length; i++)
//{
//    if (min > nums[i])
//    {
//        min = nums[i];
//    }
//    if (max < nums[i])
//    {
//        max = nums[i];
//    }

//}
//Console.WriteLine(max);


//task7   //

//int nums = 12378;
//int first = nums;
//int temp;

//while (first != 0)
//{

//    temp = first % 10; //3
//    int second = first / 10; //12
//    while (second != 0)
//    {
//        if (temp == second % 10)
//        {

//            break;

//        }
//        second /= 10;
//    }

//    Console.WriteLine(temp);
//    break;

//}


//// task8 //


//int remainder;
//Console.WriteLine("Bir eded ve ya reqem daxil edin");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num == 0)
//    Console.Write("2-nin quvvetidir.");


//else if (num == 2)
//{
//    Console.WriteLine("2-nin quvveti deyil.");
//}
//else
//{
//    while (num > 1)
//    {
//        remainder = num % 2;
//        if (remainder != 0)
//        {
//            break;

//        }


//        num /= 2;



//    }
//    if (num == 1)
//        Console.WriteLine("2-nin quvvetidir.");

//    else
//    {
//        Console.WriteLine("2-nin quvveti deyil.");

//    }
//}







//task9//
//int first = 1234;
//int sum = 0;

//while (first != 0)
//{
//    int second = first % 10; //second=3, 2
//    sum += second;
//    first = first / 10; //first=12\


//}
//Console.WriteLine(sum);



//task10//

//int[] nums = { 3, 4, 5, 7, 9 };
//int min = nums[0];
//int max = nums[0];

//for (int i = 1; i < nums.Length; i++)
//{
//    if (min > nums[i])
//    {
//        min = nums[i];
//    }
//    if (max < nums[i])
//    {
//        max = nums[i];
//    }




//}

//Console.WriteLine(max);







//// task11 //
//int[] nums = { 3, 10, 2, 33, 1, 7 };
//int count = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 10 == nums[i])
//        count += 1;

//}
//Console.WriteLine(count);


//// task12 //

//int num = 54;
//int first = num;
//int count = 0;

//int temp = first % 10;// temp=4

//int second = first / 10; // second =5
//if (second > temp)
//{
//    Console.WriteLine("Onluqlar boyukdur.");

//}
//else
//{
//    Console.WriteLine("Teklikler boyukdur.");


//}



////// task13 //


//int[] nums = { 90, 50, 1, 56, 13 };

//int max = 0;
//int min = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[max] < nums[i])
//    {
//        max = i;
//    }
//    if (nums[min] > nums[i])
//    {
//        min = i;
//    }
//}

//int temp = nums[max];
//nums[max] = nums[min];
//nums[min] = temp;

//Console.WriteLine("Massivin siralanmis hali:");

//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(nums[i]);
//}


/////
////               //task14//



//int num = 34589;
//int count = 0;

//while (num != 0)
//{
//    num /= 10;
//    count++;
//}

//Console.WriteLine(" Verilmiş ededin mertebe sayı: " + count);
// =====





////   task15  //- 2 usul ile yazmisam:


//1.usul:

//int num = 1111;
//int newStart = 2;
//int newEnd = 3;

//int newNum = newStart * 10000 + num; //21111
//newNum = newNum * 10 + newEnd;

//Console.WriteLine(newNum);

//2.usul = en sade: :)

//int num = 2222;
//Console.WriteLine("7" + num + "8");



////task16//
//int num = 567;

//int newNum = num * 1000 + num;
//Console.WriteLine(newNum);


////task17//
//int num = 123;

//int newNum = num * 10 + 7;
//newNum %= 7;
//Console.WriteLine(newNum);


////task18//
//int num = 121;

//if (num % 2 == 0)
//{
//    Console.WriteLine("Bu eded cutdur");
//}
//else
//{
//    Console.WriteLine("Bu eded tekdir");
//}



////task19//

//int num = 49;
//if (num % 21 == 0)
//{
//    Console.WriteLine("Bu eded 3-e ve 7-e bolunur.");
//}
//else
//{
//    Console.WriteLine("Bolunmur");
//}



////task20//

//int num = 42;
//int num2 = 22;

//if (num > num2)
//{
//    Console.WriteLine(num);
//}

//else if (num2 > num)
//{
//    Console.WriteLine(num2);
//}

//else
//{
//    Console.WriteLine("Bu ededler beraberdir.");

//}



////task21//

//string[] array = { "Men Kod Akademiyada AB106 qrupunda oxuyuram." };
//string arananKelime = "AB106";

//foreach (string metin in array)
//{
//    if (metin.Contains(arananKelime))
//    {
//        Console.WriteLine("Kelime bulundu.");
//    }
//    else
//    {
//        Console.WriteLine("Kelime bulunamadı.");
//    }
//}




////task22//


//int a;
//int M = 45;
//int count = 0;
//for (a = 15; a <= M; a++)
//{
//    if (a % 15 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);



//-=======================

////yeni task

// //task2//

//int[] num = { 4, 6, 8, 9, 10, 11, 12 };
//int[] num2 = { 1, 5, 13, 15 };
//bool found = false;

//Console.WriteLine("Her iki arrayde eyni olan reqem ve ya ededler:");

//for (int i = 0; i < num.Length; i++)
//{
//    for (int j = 0; j < num2.Length; j++)
//    {
//        if (num[i] == num2[j])
//        {
//            Console.WriteLine(num[i]);
//            found = true;
//        }
//    }
//}

//if (!found)
//{
//    Console.WriteLine("Bu ededler eyni deyil.");
//}




//task3

//Eger arrayin icindeki ededleri ve ya reqemleri kicikden boyuye dogru sort edirikse:

//int[] arr = { 6, 3, 1, 3, 8, 6, 7 };

//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = i + 1; j < arr.Length; j++)
//    {
//        if (arr[i] > arr[j]) // Karşılaştırma işareti tersine çevrildi
//        {
//            // Geçici bir değişken kullanarak iki elemanın yerini değiştirme
//            int temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;
//        }
//    }
//}

//// Sıralanmış diziyi yazdırma
//Console.WriteLine("Sıralanmış dizi:");
//foreach (int num in arr)
//{
//    Console.WriteLine(num);
//}




//Eger arrayin icindeki ededleri ve ya reqemleri boyukden kiciye dogru sort edirikse:


//int[] arr = { 6, 3, 1, 3, 8, 6, 7 };

//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = i + 1; j < arr.Length; j++)
//    {
//        if (arr[i] < arr[j]) // Karşılaştırma işareti tersine çevrildi
//        {
//            // Geçici bir değişken kullanarak iki elemanın yerini değiştirme
//            int temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;
//        }
//    }
//}

//// Sıralanmış diziyi yazdırma
//Console.WriteLine("Sıralanmış dizi:");
//foreach (int num in arr)
//{
//    Console.WriteLine(num);
//}










