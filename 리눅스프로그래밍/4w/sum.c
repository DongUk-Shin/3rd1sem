#include <stdio.h>

int main() {
    int inputNum;

    printf("1부터 5의 정수를 입력하세요: ");
    scanf("%d", &inputNum);

    int sum = 0;
    while (inputNum != 0) {
        int digit = inputNum % 10;

        if (1 > digit || digit > 5) {
            printf("5를 초과하였습니다");
            return 0;
        }

        sum += digit % 10;
        inputNum /= 10;
    }
    printf("입력한 정수의 자리수 합은: %d\n", sum);

    return 0;
}
