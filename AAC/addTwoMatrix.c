#include <stdio.h>

void readMatrix(int rows, int cols, int matrix[rows][cols], char name)
{
    printf("Enter elements of Matrix %c (%d x %d):\n", name, rows, cols);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            printf("Enter element [%d][%d]: ", i + 1, j + 1);
            scanf("%d", &matrix[i][j]);
        }
    }
}
void printMatrix(int rows, int cols, int matrix[rows][cols])
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            printf("%d ", matrix[i][j]);
        }
        printf("\n");
    }
}

int main()
{
    int row1, col1, row2, col2;

    // Input for Matrix A
    printf("Enter number of rows and columns for Matrix A: ");
    scanf("%d%d", &row1, &col1);
    int A[row1][col1];
    readMatrix(row1, col1, A, 'A');

    // Input for Matrix B
    printf("Enter number of rows and columns for Matrix B: ");
    scanf("%d%d", &row2, &col2);
    int B[row2][col2];
    readMatrix(row2, col2, B, 'B');

    // Check if addition is possible
    if (row1 == row2 && col1 == col2)
    {
        int C[row1][col1];
        printf("Resultant Matrix after addition:\n");

        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < col1; j++)
            {
                C[i][j] = A[i][j] + B[i][j];
            }
        }

        printMatrix(row1, col1, C);
    }
    else
    {
        printf("Addition not possible. Matrices must have the same dimensions.\n");
    }

    return 0;
}
