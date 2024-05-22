#include <stdio.h>
#include <time.h>

#define N 3

void matmul_1(int A[N][N], int B[N][N]) {

    int C[N][N];

    int i, j, k;
    for (i = 0; i < N; i++) {
        for (j = 0; j < N; j++) {
            C[i][j] = 0;
        }
    }

    for (i = 0; i < N; i++) {
        for (j = 0; j < N; j++) {
            for (k = 0; k < N; k++) {
                C[i][j] += A[i][k] * B[k][j];
            }
        }
    }
}

void matmul_2(int A[N][N], int B[N][N]) {
    int C[N][N];
    int i, j, k;

    for (i = 0; i < N; i++) {
        for (j = 0; j < N; j++) {
            *(*(C + i) + j) = 0;
        }
    }

    for (i = 0; i < N; i++) {
        for (j = 0; j < N; j++) {
            for (k = 0; k < N; k++) {
                *(*(C + i) + j) += *(*(A + i) + k) * *(*(B + k) + j);
            }
        }
    }
}


int main() {
    double start, end;

    int A[N][N] = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
    int B[N][N] = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };


    start = (double)clock() / CLOCKS_PER_SEC;
    for(int i = 0; i < 1000000; i++)
        matmul_1(A, B);
    end = (((double)clock()) / CLOCKS_PER_SEC);
    printf("matmul_1 시간 : %lf\n", (end - start));


    start = (double)clock() / CLOCKS_PER_SEC;
    for (int i = 0; i < 1000000; i++)
        matmul_2(A, B);
    end = (((double)clock()) / CLOCKS_PER_SEC);
    printf("matmul_2 시간 : %lf\n", (end - start));
}
