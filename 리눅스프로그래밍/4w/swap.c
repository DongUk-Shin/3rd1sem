#include <stdio.h>

int main() {
    int num1, num2;

    printf("두 수를 입력하세요: ");
    scanf("%d %d", &num1, &num2);

    int temp = num1;
    num1 = num2;
    num2 = temp;
    printf("교환된 숫자는 %d와 %d입니다.\n", num1, num2);

    return 0;
}
