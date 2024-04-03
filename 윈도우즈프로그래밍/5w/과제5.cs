
Console.Write("단을 입력하세요: ");
int input1 = int.Parse(Console.ReadLine());

String[] arr = new String[9];
for (int i = 0; i < 9; i++)
{
    arr[i] = input1 + " * " + (i + 1);
}
foreach (String s in arr)
{
    Console.WriteLine(s);
}

Console.WriteLine();



String[] arr2 = { "computer", "science", "ENGINEERING", "android", "VISUALSTUDIO" };
Console.Write("검색할 단어를 입력하세요: ");
String input2 = Console.ReadLine();

bool flag = false;
foreach (String s in arr2)
{
    if (s.ToLower() == input2.ToLower())
    {
        Console.WriteLine("검색한 단어 '" + input2 + "' (이)가 배열에 있습니다");
        flag = true;
        break;
    }
}
if (!flag)
{
    Console.WriteLine("검색한 단어 '" + input2 + "' (이)가 배열에 없습니다");
}





bool isWhile = true;
String[,] list = new string[10,2];
int bookNum = 0;
do
{
    Console.WriteLine("\n******************************************");
    Console.WriteLine("1: 도서추가  2: 도서검색  3: 도서 리스트 출력  0: 종료");
    Console.Write("****************************************** >>> ");

    int num = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (num) { 
        case 1:
            if (bookNum < 10)
            {
                Console.WriteLine("입력할 도서(책이름,저자)를 입력하시오. 최대 10개 입력 가능 : ex)무라카미 하루키,상실의 시대");

                String[] inputCase1 = Console.ReadLine().Split(",");
                list[bookNum, 0] = inputCase1[0];
                list[bookNum, 1] = inputCase1[1];
                Console.WriteLine(">>> 입력 값: " + (bookNum + 1) + ". " + inputCase1[0] + " " + inputCase1[1]);
                bookNum++;
            } else
            {
                Console.WriteLine("책장이 가득 찼습니다. 최대 10권 입력 가능");

            }
            break;

        case 2:
            bool bookExist = false;
            Console.WriteLine("찾고자 하는 도서의 이름이나 저자의 이름을 입력하시오");
            String inputCase2 = Console.ReadLine();

            foreach (String s in list) {
                if (s == null)
                {
                    break;
                } else if (s.Contains(inputCase2))
                {
                    Console.WriteLine(">>> 찾고자 하는 도서가 존재함");
                    bookExist = true;
                    break;
                }
            }
            if (!bookExist)
            {
                Console.WriteLine(">>> 찾고자 하는 도서가 존재하지 않음");
            }
            break;

        case 3:
            Console.WriteLine("전체 도서 목록");
            for (int i = 0; i < bookNum; i++) 
            {
                Console.Write((i + 1) + ". ");
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(list[i,j] + " ");
                }
                Console.WriteLine();
            }

        break;

        case 0:
            isWhile = false;
        break;
    }
} while (isWhile);
Console.WriteLine("종료");



