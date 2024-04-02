#include <stdio.h>

int main() {
    int num1, num2;

    printf("두 수를 입력하세요: ");
    scanf("%d %d", &num1, &num2);

    if (num1 > num2) {
        printf("큰 수는: %d\n", num1);
    } else if (num2 > num1) {
        printf("큰 수는: %d\n", num2);
    } else {
        printf("두 수는 같습니다.\n");
    }

    return 0;
}
